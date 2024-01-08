using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Tree;
using RogueTraderUnityToolkit.Unity;
using RogueTraderUnityToolkit.Unity.File;
using RogueTraderUnityToolkit.Unity.TypeTree;
using RogueTraderUnityToolkit.UnityGenerated;
using RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using System.Collections.Concurrent;
using System.Collections.Generic;
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
            _knownTypeTrees = TreeBuilderJson.CreateTypeTreesFromJsonPath(typeTreesPath.FullName);
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
        End_AddDeferredObjects(files, _threadWorkData);
        Dictionary<TreePathObject, int> treeObjects = End_MergeWorkData(_threadWorkData);

        TreeReport report = TreeAnalysis.CalculateReport(treeObjects);
        Codegen.Codegen codegen = new(report);

        if (args.ExportPath != null)
        {
            End_ExportAll(args.ExportPath, report, codegen);
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

                // Keep a copy of every script tree, so we can reference it later, for maidenless trees.
                if (file.Target.WithTypeTree && obj.Info.Type == UnityObjectType.MonoBehaviour)
                {
                    _knownScriptTypeTrees.TryAdd(info.Hash, obj.Tree!);
                }
            },
            fnGetObjectTypeTree: (instance, info) =>
            {
                if (info.Type == UnityObjectType.MonoBehaviour)
                {
                    if (info.Hash == default)
                    {
                        return _knownTypeTrees[info.Type];
                    }

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

    private static Dictionary<TreePathObject, int> End_MergeWorkData(
        IEnumerable<ThreadWorkData> allWorkData)
    {
        Dictionary<TreePathObject, int> treeObjects = [];

        foreach (ThreadWorkData workData in allWorkData)
        {
            foreach ((TreePathObject obj, int refs) in workData.Objects)
            {
                if (!treeObjects.TryAdd(obj, refs)) treeObjects[obj] += refs;
            }
        }

        return treeObjects;
    }

    private void End_AddDeferredObjects(
        IReadOnlyList<FileInfo> files,
        IEnumerable<ThreadWorkData> allWorkData)
    {
        List<string> assemblyPaths = files
            .Where(x => x.Extension.Equals(".dll", StringComparison.OrdinalIgnoreCase))
            .Select(x => x.FullName)
            .ToList();

        PathAssemblyResolver pathResolver = new(assemblyPaths);
        using MetadataLoadContext metadataLoadContext = new(pathResolver);

        List<DeferredObject> deferredObjects = _threadWorkData.SelectMany(x => x.DeferredObjects).ToList();
        List<MonoScript> monoScripts = _threadWorkData.SelectMany(x => x.ParsedObjects.OfType<MonoScript>()).ToList();

        IEnumerable<(MonoScript, IEnumerable<DeferredObject>)> objectsToProcess = deferredObjects
            .GroupBy(x => x.Info.Hash)
            .OrderByDescending(x => x.Count())
            .ThenBy(x => x.Key)
            .Select(x => (monoScripts.First(y => x.Key == y.m_PropertiesHash), x.Select(y => y)));

        int parsedObjectsCount = 0;
        int skippedObjectsCount = 0;

        Parallel.ForEach(objectsToProcess, entry =>
        {
            (MonoScript script, IEnumerable<DeferredObject> objects) = entry;

            Assembly assembly;

            lock (metadataLoadContext)
            {
                assembly = metadataLoadContext.LoadFromAssemblyPath(assemblyPaths
                    .First(x => x.Contains(script.m_AssemblyName.ToString())));
            }

            TreeBuilderAssembly treeBuilder = new();

            ObjectTypeTree tree = treeBuilder.CreateTypeTreeFromAssembly(
                assembly,
                script.m_Namespace,
                script.m_ClassName,
                _knownTypeTrees[UnityObjectType.MonoBehaviour].Nodes);

            if (tree.Nodes.Length == 0)
            {
                Interlocked.Add(ref skippedObjectsCount, objects.Count());
                return;
            }

            ThreadWorkData workData = TakeWorkData();
            ITreeReader treeReader = workData.Reader;

            ObjectParser parser = new();

            foreach (DeferredObject obj in objects)
            {
                using MemoryStream mem = new(obj.Data);
                EndianBinaryReader reader = new(mem, obj.Owner.Header.IsBigEndian);

                treeReader.StartObject(obj.Info.Type, obj.Info.ScriptHash, obj.Info.Hash);
                parser.Read(tree, [], reader, treeReader, obj.Instance.Size);
                treeReader.FinishObject(obj.Info.Type, obj.Info.ScriptHash, obj.Info.Hash);

                Debug.Assert(reader.Remaining == 0);
            }

            Interlocked.Add(ref parsedObjectsCount, objects.Count());

            ReturnWorkData(workData);

        });

        Log.Write($"Processed {parsedObjectsCount} deferred objects, skipped {skippedObjectsCount}");
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
