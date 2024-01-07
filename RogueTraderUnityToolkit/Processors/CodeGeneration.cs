using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Tree;
using RogueTraderUnityToolkit.Unity;
using RogueTraderUnityToolkit.Unity.File;
using RogueTraderUnityToolkit.Unity.TypeTree;
using RogueTraderUnityToolkit.UnityGenerated;
using RogueTraderUnityToolkit.UnityGenerated.Types.Engine;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace RogueTraderUnityToolkit.Processors;

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
                fnGetObjectTypeTree: x =>
                {
                    if (x.Type == UnityObjectType.MonoBehaviour)
                    {
                        if (_knownScriptTypeTrees.TryGetValue(x.Hash, out ObjectTypeTree? tree))
                        {
                            return tree;
                        }

                        _unknownScriptHashes.AddOrUpdate(
                            (x.Hash, x.ScriptTypeIdx),
                            (_) => 1, (_, v) => v + 1);

                        return null;
                    }

                    return _knownTypeTrees[x.Type];
                });

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
                        workData.ScriptObjects.Add(createdObj);
                    }
                }
            }

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
        Dictionary<TreePathObject, int> treeObjects = [];
        List<IUnityObject> scriptObjects = [];

        foreach (ThreadWorkData workData in _threadWorkData)
        {
            foreach ((TreePathObject obj, int refs) in workData.Objects)
            {
                if (!treeObjects.TryAdd(obj, refs)) treeObjects[obj] += refs;
            }

            scriptObjects.AddRange(workData.ScriptObjects);
        }

        TreeReport report = TreeAnalysis.CalculateReport(treeObjects);
        Codegen.Codegen codegen = new(report);

        if (args.ExportPath != null)
        {
            if (Directory.Exists(args.ExportPath))
            {
                Log.Write($"Cleaning up {args.ExportPath}");
                Directory.Delete(args.ExportPath, recursive: true);
            }

            Directory.CreateDirectory(args.ExportPath);
            TreeAnalysis.ExportReport(report, args.ExportPath);
            codegen.WriteStructures(args.ExportPath);

            File.WriteAllText(
                Path.Combine(args.ExportPath, "missing_hash_report.json"),
                JsonSerializer.Serialize(_unknownScriptHashes
                    .ToDictionary(x => x.Key.ToString(), x => new
                    {
                        Refs = x.Value,
                        ResolvableInScriptTrees = _knownScriptTypeTrees.ContainsKey(x.Key.Item1),
                        MonoScriptObject = scriptObjects
                            .OfType<MonoScript>()
                            .Where(y => y.m_PropertiesHash == x.Key.Item1)
                            .Select(y => y.ToString())
                            .FirstOrDefault()
                    })
                    .OrderByDescending(x => x.Value.Refs),
                    new JsonSerializerOptions() { WriteIndented = true }));
        }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ThreadWorkData TakeWorkData()
    {
        using var _ = SuperluminalPerf.BeginEvent("TakeWorkData");

        if (!_threadWorkData.TryTake(out ThreadWorkData? workData))
        {
            Dictionary<TreePathObject, int> dict = [];
            workData = new(new TreeReader(new(), dict), dict, []);
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
    private readonly ConcurrentDictionary<(Hash128, ushort), int> _unknownScriptHashes = [];
    private Dictionary<UnityObjectType, ObjectTypeTree> _knownTypeTrees = [];

    private record class ThreadWorkData(
        ITreeReader Reader,
        Dictionary<TreePathObject, int> Objects,
        List<IUnityObject> ScriptObjects);
}
