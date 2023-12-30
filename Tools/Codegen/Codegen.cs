using Codegen;
using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using System.Collections.Concurrent;
using System.IO.MemoryMappedFiles;

SuperluminalPerf.Initialize();

List<string> paths = [
    @"C:\Program Files (x86)\Steam\steamapps\common\Warhammer 40,000 Rogue Trader\Bundles",
    @"C:\Program Files (x86)\Steam\steamapps\common\Warhammer 40,000 Rogue Trader\WH40KRT_Data"
];

IEnumerable<FileInfo> files = [];

foreach (string path in paths)
{
    FileInfo info = new(path);
    bool isDir = (info.Attributes & FileAttributes.Directory) != 0;
        
    files = isDir ?
        files.Concat(Directory
            .EnumerateFiles(info.FullName, "*", SearchOption.AllDirectories)
            .Select(x => new FileInfo(x))) :
        files.Append(info);
}

ParallelOptions parallelOpts = new();

#if DEBUG
parallelOpts.MaxDegreeOfParallelism = 1;
files = files.Take(50);
#endif

Dictionary<UnityObjectType, PerTypeTreeData> perTypeTreeData = new();

foreach (UnityObjectType type in Enum.GetValues<UnityObjectType>())
{
    perTypeTreeData[type] = new();
}

ThreadLocal<AnalyseTreesReader> readers = new(() => new(perTypeTreeData));

Parallel.ForEach(files
        .Where(file => file.Length != 0)
        .OrderByDescending(file => file.Length),
    parallelOpts, fileInfo =>
{
    using MemoryMappedFile diskFile = MemoryMappedFile.CreateFromFile(fileInfo.FullName, FileMode.Open);
    SerializedAssetInfo diskFileInfo = new(null, fileInfo.Name, fileInfo.Length, diskFile.CreateViewStream);
    
    AnalyseTreesReader treeReader = readers.Value!;

    if (AssetBundle.CanRead(diskFileInfo))
    {
        AssetBundle bundle = AssetBundle.Read(diskFileInfo);
        IRelocatableMemoryRegion[] memory = bundle.CreateRelocatableMemoryRegions();

        foreach (AssetBundleNode node in bundle.Manifest.Nodes)
        {
            SerializedAssetInfo nodeInfo = bundle.CreateAssetInfoForNode(node, memory);
        
            if (!SerializedFile.CanRead(nodeInfo))
            {
#if DEBUG
                Log.Write($"Skipping {nodeInfo} (probably a resource file)", ConsoleColor.Yellow);
#endif
                continue;
            }

            SerializedFile serializedFile = SerializedFile.Read(nodeInfo);
            ProcessSerializedFile(serializedFile, treeReader);
        }
    }
    else if (SerializedFile.CanRead(diskFileInfo))
    {
        SerializedFile serializedFile = SerializedFile.Read(diskFileInfo);
        ProcessSerializedFile(serializedFile, treeReader);
    }
    else
    {
        Log.Write($"Skipping {diskFileInfo}", ConsoleColor.DarkGray);
        return;
    }
});

static void ProcessSerializedFile(SerializedFile file, AnalyseTreesReader treeReader)
{
    SerializedFileReader fileReader = new(file);

    if (file.Target.WithTypeTree)
    {
        treeReader.StartFile(file.TypeReferences);
        
        fileReader.ReadObjectRange(
            treeReader: treeReader,
            withDebugReader: false,
            startIdx: 0,
            endIdx: file.ObjectInstances.Length,
            fnStartedOne: (i, _) =>
            {
                int typeIdx = file.ObjectInstances[i].TypeIdx;
                UnityObjectType type = file.Objects[typeIdx].Info.Type;
                treeReader.StartObject(type);
            },
            fnFinishedOne: (_, _) => { });
    }
    else
    {
        Log.Write($"{file.Info.Identifier} does not have embedded type tree info.", ConsoleColor.Yellow);
    }
}

//AnalyseTreesReport.OutputReportToLog(perTypeTreeData);
//Console.ReadLine();
return;

public sealed record class PerTypeTreeData(
    ConcurrentDictionary<AnalyseTreesNodePath, int> PathRefs)
{
    public PerTypeTreeData() : this([]) { }

    public int ObjectCount => _objectCount;
    public void IncObjectCount() => Interlocked.Increment(ref _objectCount);
    private int _objectCount;

    public override string ToString() => $"{ObjectCount} objects";
}
