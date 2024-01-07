using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Tree;
using RogueTraderUnityToolkit.Unity;
using RogueTraderUnityToolkit.Unity.File;
using RogueTraderUnityToolkit.Unity.TypeTree;
using RogueTraderUnityToolkit.UnityGenerated;
using RogueTraderUnityToolkit.UnityGenerated.Types.Engine;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Loader;
using System.Text.Json;

namespace RogueTraderUnityToolkit.Processors;

// Custom AssemblyLoadContext for unloading
internal class UnityAssemblyContext() : AssemblyLoadContext(isCollectible: true)
{
    internal record struct MonoScriptDataCopy(
        byte[] FilePathsData,
        byte[] TypesData,
        int TotalTypes,
        int TotalFiles,
        bool IsEditorOnly);
}

public record class CodeGeneration : IAssetProcessor
{
    public void Begin(
        Args args,
        IReadOnlyList<FileInfo> files)
    {
        FileInfo? typeTreesPath = files.FirstOrDefault(x => x.Name == "dumped_20223f7.json");

        if (typeTreesPath != null)
        {
            _knownTypeTrees = TreeConverter.CreateTypeTreesFromJsonPath(typeTreesPath.FullName);
        }

        Dictionary<AsciiString, List<(string, int)>> assemblyMonoScriptData = [];

        foreach (FileInfo file in files.Where(x => x.Extension.Equals(".dll", StringComparison.OrdinalIgnoreCase)))
        {
            UnityAssemblyContext loadContext = new();

            try
            {
                Assembly assembly = loadContext.LoadFromAssemblyPath(file.FullName);
                Type? monoScriptType = assembly.GetType("UnitySourceGeneratedAssemblyMonoScriptTypes_v1", false);
                if (monoScriptType != null)
                {
                    Type dataType = assembly.GetType("UnitySourceGeneratedAssemblyMonoScriptTypes_v1+MonoScriptData", false)!;
                    MethodInfo monoScriptGet = monoScriptType.GetMethod("Get", BindingFlags.Static | BindingFlags.NonPublic)!;
                    object data = monoScriptGet.Invoke(null, null)!;

                    byte[] typesData = (byte[])dataType.GetField("TypesData")!.GetValue(data)!;
                    using MemoryStream stream = new(typesData);
                    EndianBinaryReader reader = new(stream);

                    while (stream.Position < stream.Length)
                    {
                        int unknown = reader.ReadS32(); // 16777216 when it's an engine type, 0 otherwise?
                        byte len = reader.ReadByte();
                        AsciiString name = reader.ReadString(len);

                        assemblyMonoScriptData.TryAdd(name, []);
                        assemblyMonoScriptData[name].Add((file.FullName, unknown));
                    }
                }
            }
            catch (BadImageFormatException)
            {
                // Not a managed assembly, skip this file
            }
            catch (FileLoadException)
            {
                // File could not be loaded (e.g., not a .NET assembly), skip this file
            }
            finally
            {
                loadContext.Unload();
            }
        }
    }

    public void Process(
        Args args,
        ISerializedAsset asset,
        out int assetCountProcessed,
        out int assetCountSkipped,
        out int assetCountFailed)
    {
        assetCountProcessed = 0;
        assetCountSkipped = 0;
        assetCountFailed = 0;

        ThreadWorkData workData = TakeWorkData();

        if (asset is SerializedFile file)
        {
            Process_ReadAllTypeTrees(file, workData);
            Process_ReadAllMonoScripts(file, workData);
            assetCountProcessed = file.ObjectInstances.Length;
        }
        else
        {
            assetCountSkipped = 1;
        }

        ReturnWorkData(workData);
    }

    public void End(
        Args args,
        ISerializedAsset[] assets)
    {
        End_MergeWorkData(_threadWorkData,
            out Dictionary<TreePathObject, int> treeObjects,
            out List<IUnityObject> parsedObjects,
            out List<DeferredObject> deferredObjects);

        End_AddDeferredObjects(treeObjects, parsedObjects, deferredObjects);

        TreeReport report = TreeAnalysis.CalculateReport(treeObjects);

        Codegen.Codegen codegen = new(report);
        if (args.ExportPath != null)
        {
            End_ExportAll(args.ExportPath, report, codegen);

            File.WriteAllText(
                Path.Combine(args.ExportPath, "deferred.json"),
                JsonSerializer.Serialize(deferredObjects.Select(x => new
            {
                File = x.Owner.Info,
                ObjectInstance = x.Instance,
                OBjectInfo = x.Info
            }), new JsonSerializerOptions() { WriteIndented = true }));
        }
    }

    private void Process_ReadAllTypeTrees(
        SerializedFile file,
        ThreadWorkData workData)
    {
        SerializedFileReader fileReader = new(file);

        fileReader.ReadObjectRange(
            treeReader: workData.Reader,
            withDebugReader: false,
            startIdx: 0,
            endIdx: file.ObjectInstances.Length,
            fnStartedOne: i =>
            {
                ref SerializedFileObjectInstance instance = ref file.ObjectInstances[i];
                SerializedFileObjectInfo info = file.Objects[instance.TypeIdx].Info;
                workData.Reader.StartObject(info.Type, info.ScriptHash, info.Hash);
            },
            fnFinishedOne: i =>
            {
                ref SerializedFileObjectInstance instance = ref file.ObjectInstances[i];
                ref SerializedFileObject obj = ref file.Objects[instance.TypeIdx];
                SerializedFileObjectInfo info = file.Objects[instance.TypeIdx].Info;
                workData.Reader.FinishObject(info.Type, info.ScriptHash, info.Hash);

                // Keep a copy of every script tree, so we can reference it later, for stripped trees.
                if (file.Target.WithTypeTree && obj.Info.Type == UnityObjectType.MonoBehaviour)
                {
                    _knownScriptTypeTrees.TryAdd(info.Hash, obj.Tree!);
                }
            },
            fnGetObjectTypeTree: (instance, info) =>
            {
                if (info.Type == UnityObjectType.MonoBehaviour)
                {
                    if (_knownScriptTypeTrees.TryGetValue(info.Hash, out ObjectTypeTree? tree))
                    {
                        return tree;
                    }

                    // A small subset of game scripts won't have their type tree data available because:
                    //
                    // 1. We're in a file without type tree available. (shared assets, etc), and,
                    // 2a. None of the asset bundles have read this type yet due to ordering, or,
                    // 2b. None of the asset bundles will ever read this type, because all instances exist
                    //     inside files without type tree info baked in.
                    //
                    // If we reach this point, we collect the memory and object info, because we will later
                    // (at the end) create the type tree directly from the assembly.

                    using Stream stream = file.Info.Open(file.Header.DataOffset + instance.Offset, instance.Size);
                    EndianBinaryReader reader = new(stream, file.Header.IsBigEndian);
                    byte[] memoryCopy = new byte[instance.Size];
                    reader.ReadBytes(memoryCopy.AsSpan());
                    workData.DeferredObjects.Add(new(file, instance, info, memoryCopy));

                    // Returning null here will cause the reader to skip this particular object.

                    return null;
                }

                return _knownTypeTrees[info.Type];
            });
    }

    private static void Process_ReadAllMonoScripts(
        SerializedFile file,
        ThreadWorkData workData)
    {
        using Stream stream = file.Info.Open(file.Header.DataOffset);
        EndianBinaryReader reader = new(stream, file.Header.IsBigEndian);

        for (int i = 0; i < file.ObjectInstances.Length; ++i)
        {
            ref SerializedFileObjectInstance instance = ref file.ObjectInstances[i];
            ref SerializedFileObject obj = ref file.Objects[instance.TypeIdx];

            if (obj.Info.Type == UnityObjectType.MonoScript)
            {
                reader.Position = (int)instance.Offset;

                if (GeneratedTypes.TryCreateType(obj.Info.Hash, obj.Info.Type, reader, out IUnityObject createdObj))
                {
                    Debug.Assert(reader.Position == instance.Offset + instance.Size);
                    workData.ParsedObjects.Add(createdObj);
                }
            }
        }
    }

    private static void End_MergeWorkData(
        IEnumerable<ThreadWorkData> allWorkData,
        out Dictionary<TreePathObject, int> treeObjects,
        out List<IUnityObject> parsedObjects,
        out List<DeferredObject> deferredObjects)
    {
        treeObjects = [];
        parsedObjects = [];
        deferredObjects = [];

        foreach (ThreadWorkData workData in allWorkData)
        {
            foreach ((TreePathObject obj, int refs) in workData.Objects)
            {
                if (!treeObjects.TryAdd(obj, refs)) treeObjects[obj] += refs;
            }

            parsedObjects.AddRange(workData.ParsedObjects);
            deferredObjects.AddRange(workData.DeferredObjects);
        }
    }

    private static void End_AddDeferredObjects(
        Dictionary<TreePathObject, int> storage,
        List<IUnityObject> parsedObjects,
        List<DeferredObject> deferredObjects)
    {

    }

    private static void End_ExportAll(
        string path,
        TreeReport report,
        Codegen.Codegen codegen)
    {
        if (Directory.Exists(path))
        {
            Log.Write($"Cleaning up {path}");
            Directory.Delete(path, recursive: true);
        }

        Directory.CreateDirectory(path);
        TreeAnalysis.ExportReport(report, path);
        codegen.WriteStructures(path);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ThreadWorkData TakeWorkData()
    {
        using var _ = SuperluminalPerf.BeginEvent("TakeWorkData");

        if (!_threadWorkData.TryTake(out ThreadWorkData? workData))
        {
            Dictionary<TreePathObject, int> dict = [];
            workData = new(new TreeReader(new(), dict), dict, [], []);
        }

        return workData;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ReturnWorkData(ThreadWorkData data)
    {
        using var _ = SuperluminalPerf.BeginEvent("ReturnWorkData");
        _threadWorkData.Add(data);
    }

    private readonly ConcurrentBag<ThreadWorkData> _threadWorkData = [];
    private readonly ConcurrentDictionary<Hash128, ObjectTypeTree> _knownScriptTypeTrees = [];

    private Dictionary<UnityObjectType, ObjectTypeTree> _knownTypeTrees = [];

    private record class ThreadWorkData(
        ITreeReader Reader,
        Dictionary<TreePathObject, int> Objects,
        List<IUnityObject> ParsedObjects,
        List<DeferredObject> DeferredObjects);

    private record class DeferredObject(
        SerializedFile Owner,
        SerializedFileObjectInstance Instance,
        SerializedFileObjectInfo Info,
        byte[] Data);
}
