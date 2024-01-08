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

internal class UnityAssemblyContext(string dir) : AssemblyLoadContext(isCollectible: true)
{
    internal record struct MonoScriptDataCopy(
        byte[] FilePathsData,
        byte[] TypesData,
        int TotalTypes,
        int TotalFiles,
        bool IsEditorOnly);

    protected override Assembly? Load(AssemblyName assemblyName)
    {
        string assemblyPath = Path.Combine(dir, assemblyName.Name + ".dll");
        return File.Exists(assemblyPath) ? LoadFromAssemblyPath(assemblyPath) : null;
    }
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
            TreeBuilderJson.CreateTypeTreesFromJsonPath(
                typeTreesPath.FullName,
                out _knownTypeTrees,
                out _knownTypeSubTrees);
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
        IReadOnlyList<FileInfo> files,
        ISerializedAsset[] assets)
    {
        End_MergeWorkData(_threadWorkData,
            out Dictionary<TreePathObject, int> treeObjects,
            out List<IUnityObject> parsedObjects,
            out List<DeferredObject> deferredObjects);

        End_AddDeferredObjects(files, treeObjects, parsedObjects, deferredObjects);

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

    private void End_AddDeferredObjects(
        IReadOnlyList<FileInfo> files,
        Dictionary<TreePathObject, int> storage,
        List<IUnityObject> parsedObjects,
        List<DeferredObject> deferredObjects)
    {
        List<string> assemblyPaths = files
            .Where(x => x.Extension.Equals(".dll", StringComparison.OrdinalIgnoreCase))
            .Select(x => x.FullName)
            .ToList();

        PathAssemblyResolver pathResolver = new(assemblyPaths);
        using MetadataLoadContext metadataLoadContext = new(pathResolver);

        foreach ((MonoScript script, IEnumerable<DeferredObject> objs) in deferredObjects
            .GroupBy(x => x.Info.Hash)
            .OrderByDescending(x => x.Count())
            .Select(x => (parsedObjects.OfType<MonoScript>().First(y => x.Key == y.m_PropertiesHash), x.Select(y => y))))
        {
            Assembly assembly = metadataLoadContext.LoadFromAssemblyPath(assemblyPaths
                .First(x => x.Contains(script.m_AssemblyName.ToString())));

            TreeBuilderAssembly treeBuilder = new(_knownTypeSubTrees);

            ObjectTypeTree tree = treeBuilder.CreateTypeTreeFromAssembly(
                assembly,
                script.m_Namespace,
                script.m_ClassName,
                _knownTypeTrees[UnityObjectType.MonoBehaviour].Nodes);

            TreeReader treeReader = new(new(), storage);

            foreach (DeferredObject obj in objs)
            {
                using MemoryStream mem = new(obj.Data);
                EndianBinaryReader reader = new(mem, obj.Owner.Header.IsBigEndian);
                ObjectParserDebug debugReader = new(() => reader.Position);

                ObjectParser parser = new();
                parser.Read(tree, [], reader, debugReader, obj.Instance.Size);
                Debug.Assert(reader.Remaining == 0);
            }
        }
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
    private Dictionary<AsciiString, ObjectParserNode[]> _knownTypeSubTrees = []; // for any referenced type inside engine trees

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
