using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Tree;
using RogueTraderUnityToolkit.Unity;
using RogueTraderUnityToolkit.Unity.File;
using RogueTraderUnityToolkit.Unity.TypeTree;
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
                    if (file.Target.WithTypeTree && info.Type == UnityObjectType.MonoBehaviour)
                    {
                        Debug.Assert(obj.Tree != null);
                        _knownScriptTypeTrees.TryAdd(info.ScriptHash, obj.Tree!);
                    }
                },
                fnGetObjectTypeTree: x =>
                {
                    if (x.Type == UnityObjectType.MonoBehaviour)
                    {
                        if (_knownScriptTypeTrees.TryGetValue(x.ScriptHash, out ObjectTypeTree? tree))
                        {
                            return tree;
                        }

                        _unknownScriptHashes.AddOrUpdate(x.ScriptHash, (_) => 1, (_, v) => v + 1);
                        return null;
                    }

                    return _knownTypeTrees[x.Type];
                });

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
        Dictionary<TreePathObject, int> objects = [];

        foreach (ThreadWorkData workData in _threadWorkData)
        {
            foreach ((TreePathObject obj, int refs) in workData.Objects)
            {
                if (!objects.TryAdd(obj, refs)) objects[obj] += refs;
            }
        }

        foreach ((Hash128 hash, int refs) in _unknownScriptHashes.OrderBy(x => x.Key.ToString()))
        {
            bool resolvableNow = _knownScriptTypeTrees.TryGetValue(hash, out _);
            Log.Write(
                $"{hash} ({refs} refs) was unresolveable and {(resolvableNow ? "no longer is!" : "still is!")}",
                resolvableNow ? ConsoleColor.Red : ConsoleColor.Yellow);
        }

        TreeReport report = TreeAnalysis.CalculateReport(objects);
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

            File.WriteAllText(Path.Combine(args.ExportPath, "missing_hash_report.json"),
                JsonSerializer.Serialize(_unknownScriptHashes
                    .ToDictionary(x => x.Key.ToString(), x => x.Value),
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
            workData = new(new TreeReader(new(), dict), dict);
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
    private readonly ConcurrentDictionary<Hash128, int> _unknownScriptHashes = [];

    private Dictionary<UnityObjectType, ObjectTypeTree> _knownTypeTrees = [];

    private record class ThreadWorkData(
        ITreeReader Reader,
        Dictionary<TreePathObject, int> Objects);
}
