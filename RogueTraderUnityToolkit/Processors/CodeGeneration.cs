using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Tree;
using RogueTraderUnityToolkit.Unity.File;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace RogueTraderUnityToolkit.Processors;

public record class CodeGeneration : IAssetProcessor
{
    public void Process(
        Args args,
        AssetBundle bundle,
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

            if (file.Target.WithTypeTree)
            {
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
                        SerializedFileObjectInfo info = file.Objects[instance.TypeIdx].Info;
                        workData.Reader.FinishObject(info.Type, info.ScriptHash, info.Hash);
                    });

                assetCountProcessed = file.ObjectInstances.Length;
            }
            else
            {
                assetCountSkipped = file.ObjectInstances.Length;
            }

        }
        else if (asset is ResourceFile res)
        {
            // TODO: Load .json dump and convert to type tree, then parse it
        }

        ReturnWorkData(workData);
    }

    public void End(Args args, ISerializedAsset[] assets)
    {
        Dictionary<TreePathObject, int> objects = [];

        foreach (ThreadWorkData workData in _threadWorkData)
        {
            foreach ((TreePathObject obj, int refs) in workData.Objects)
            {
                if (!objects.TryAdd(obj, refs)) objects[obj] += refs;
            }
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

    internal record class ThreadWorkData(ITreeReader Reader, Dictionary<TreePathObject, int> Objects);
}
