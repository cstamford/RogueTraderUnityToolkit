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

namespace RogueTraderUnityToolkit.Processors;

public record class CodeGeneration : IAssetProcessor
{
    public void Begin(
        Args args,
        IReadOnlyList<FileInfo> files)
    {
        FileInfo? typeTreesPath = files.FirstOrDefault(x => x.Name == "2022.3.44f1.json");

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
            ReadAllTypeTrees(file, workData);
            ReadAllMonoScripts(file, workData);
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
        List<MonoScript> monoScripts = _threadWorkData
            .SelectMany(x => x.ParsedObjects.OfType<MonoScript>())
            .DistinctBy(x => x.m_PropertiesHash)
            .ToList();

        ProcessDeferredObjects(args, files, monoScripts);

        Dictionary<TreePathObject, int> treeObjects = MergeWorkData();
        TreeReport report = TreeAnalysis.CalculateReport(treeObjects);

        Codegen.Codegen codegen = new(report);

        codegen.ReadGameStructures(report, monoScripts.ToDictionary(
            x => x.m_PropertiesHash,
            x => x.m_ClassName));

        if (args.ExportPath != null)
        {
            ExportAll(args.ExportPath, report, codegen);
        }
    }

    private void ReadAllTypeTrees(
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

    private static void ReadAllMonoScripts(
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
                    long remaining = (instance.Offset + instance.Size) - reader.Position;
                    Debug.Assert(remaining == 0);
                    workData.ParsedObjects.Add(createdObj);
                }
            }
        }
    }

    private void ProcessDeferredObjects(
        Args args,
        IReadOnlyList<FileInfo> files,
        IReadOnlyList<MonoScript> monoScripts)
    {
        using var _ = SuperluminalPerf.BeginEvent("AddDeferredObjects");

        List<string> assemblyPaths = files
            .Where(x => x.Extension.Equals(".dll", StringComparison.OrdinalIgnoreCase))
            .Select(x => x.FullName)
            .ToList();

        PathAssemblyResolver pathResolver = new(assemblyPaths);
        using MetadataLoadContext metadataLoadContext = new(pathResolver);

        List<DeferredObject> deferredObjects = _threadWorkData.SelectMany(x => x.DeferredObjects).ToList();

        IEnumerable<(MonoScript, IEnumerable<DeferredObject>)> objectsToProcess = deferredObjects
            .GroupBy(x => x.Info.Hash)
            .OrderByDescending(x => x.Count())
            .ThenBy(x => x.Key)
            .Select(x => (monoScripts.First(y => x.Key == y.m_PropertiesHash), x.Select(y => y)));

        int parsedObjectsCount = 0;
        int skippedObjectsCount = 0;

        ParallelOptions parallelOpts = new();

        if (args.ThreadCount > 0)
        {
            parallelOpts.MaxDegreeOfParallelism = args.ThreadCount;
        }

        Parallel.ForEach(objectsToProcess, parallelOpts, entry =>
        {
            (MonoScript script, IEnumerable<DeferredObject> objects) = entry;

            string targetAssemblyName = script.m_AssemblyName.ToString().Replace(".dll", "");
            string? assemblyPath = assemblyPaths.FirstOrDefault(x => Path.GetFileNameWithoutExtension(x) == targetAssemblyName);

            if (assemblyPath == null)
            {
                Log.Write($"Couldn't load assembly {targetAssemblyName}! Was it in the provided directories?");
                return;
            }

            Assembly assembly;

            lock (metadataLoadContext)
            {
                assembly = metadataLoadContext.LoadFromAssemblyPath(assemblyPath);
            }

            TreeBuilderAssembly treeBuilder = new();

            ObjectTypeTree tree = treeBuilder.CreateTypeTreeFromAssembly(
                assembly,
                script.m_Namespace,
                script.m_ClassName,
                _knownTypeTrees[UnityObjectType.MonoBehaviour].Nodes);

            if (tree.Nodes.Length == 0)
            {
                Log.Write($"Couldn't find type {script.m_Namespace}.{script.m_ClassName} in {assembly.FullName}", ConsoleColor.Yellow);
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

            ReturnWorkData(workData);
            Interlocked.Add(ref parsedObjectsCount, objects.Count());
        });

        Log.Write($"Processed {parsedObjectsCount} deferred objects, skipped {skippedObjectsCount}");
    }

    private static void ExportAll(
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

    private Dictionary<TreePathObject, int> MergeWorkData()
    {
        Dictionary<TreePathObject, int> treeObjects = [];

        foreach (ThreadWorkData workData in _threadWorkData)
        {
            foreach ((TreePathObject obj, int refs) in workData.Objects)
            {
                if (!treeObjects.TryAdd(obj, refs)) treeObjects[obj] += refs;
            }
        }

        _threadWorkData.Clear();
        return treeObjects;
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
