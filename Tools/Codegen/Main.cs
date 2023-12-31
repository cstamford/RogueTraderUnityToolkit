using Codegen;
using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
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

Dictionary<UnityObjectType, PerTypeTreeData> perTypeTreeData = Enum
    .GetValues<UnityObjectType>()
    .ToDictionary(x => x, _ => new PerTypeTreeData());

Dictionary<UnityObjectType, SemaphoreSlim> perTypeTreeDataLocks = perTypeTreeData
    .Keys
    .ToDictionary(x => x, _ => new SemaphoreSlim(1, 1));

Parallel.ForEach(files
        .Where(file => file.Length != 0)
        .OrderByDescending(file => file.Length),
    parallelOpts,
    () =>
    {
        Dictionary<UnityObjectType, PerTypeTreeData> data = Enum
            .GetValues<UnityObjectType>()
            .ToDictionary(x => x, _ => new PerTypeTreeData());

        ITreeReader reader = true switch
        {
            false => new TreeReaderDebug(Console.OpenStandardOutput()),
            true => new TreeReader(new TreePathAllocator(), data)
        };
        
        return new ThreadLocalWorkData(reader, data);
    },
    (fileInfo, _, workData) =>
    {
        using MemoryMappedFile diskFile = MemoryMappedFile.CreateFromFile(fileInfo.FullName, FileMode.Open);
        SerializedAssetInfo diskFileInfo = new(null, fileInfo.Name, fileInfo.Length, diskFile.CreateViewStream);
        
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
                ProcessSerializedFile(serializedFile, workData);
            }
        }
        else if (SerializedFile.CanRead(diskFileInfo))
        {
            SerializedFile serializedFile = SerializedFile.Read(diskFileInfo);
            ProcessSerializedFile(serializedFile, workData);
        }
        else
        {
            Log.Write($"Skipping {diskFileInfo}", ConsoleColor.DarkGray);
        }

        return workData;
    },
    workData =>
    {
        Queue<UnityObjectType> typesToProcess = new(workData.Data.Keys);

        while (typesToProcess.TryDequeue(out UnityObjectType type))
        {
            SemaphoreSlim workLock = perTypeTreeDataLocks[type];

            if (workLock.Wait(0))
            {
                perTypeTreeData[type].IncObjectCount(workData.Data[type].ObjectCount);

                Dictionary<TreePath, int> ourPathRefs = workData.Data[type].PathRefs;
                Dictionary<TreePath, int> theirPathRefs = perTypeTreeData[type].PathRefs;
                
                foreach ((TreePath path, int count) in ourPathRefs)
                {
                    if (theirPathRefs.TryGetValue(path, out int existingCount))
                    {
                        theirPathRefs[path] = existingCount + count;
                    }
                    else
                    {
                        theirPathRefs.Add(path, count);
                    }
                }
                
                workLock.Release();
                continue;
            }
            
            typesToProcess.Enqueue(type);
        }
    });


ComplexTypeReport complexTypes = TreeAnalysis.CalculateComplexTypes(perTypeTreeData);

Codegen.Codegen codegen = new(complexTypes);
codegen.Analyse();

ExportCodegen(codegen);
ExportAnalysis(perTypeTreeData, complexTypes);

return;

static void ExportCodegen(Codegen.Codegen codegen)
{
    const bool exportStructures = true;

    if (exportStructures)
    {
        const string path = @"D:\\RogueTraderUnityToolkit\\RogueTraderUnityToolkit.UnityStructures\\Generated";

        if (Directory.Exists(path))
        {
            Log.Write($"Cleaning up {path}");
            Directory.Delete(path, recursive: true);
        }

        Directory.CreateDirectory(path);
        codegen.WriteStructures(path);
        Log.Write($"Wrote codegen structures to {path}", ConsoleColor.Cyan);
    }
}

static void ExportAnalysis(
    Dictionary<UnityObjectType, PerTypeTreeData> perTypeTreeData,
    ComplexTypeReport complexTypes)
{
    const bool exportBreakdown = true;
    const bool exportFieldAccesses = true;
    const bool exportComplexTypeFieldAccesses = true;
    const bool exportComplexTypeMap = true;
    const bool exportComplexTypeRefcounts = true;

    if (exportBreakdown)
    {
        const string path = "typeBreakdown.txt";
        using FileStream stream = File.Create(path);
        using StreamWriter sw = new(stream);
        TreeAnalysis.WriteUnityTypeBreakdown(sw, perTypeTreeData);
        Log.Write($"Wrote type breakdowns to {Path.GetFullPath(path)}", ConsoleColor.Cyan);
    }

    if (exportFieldAccesses)
    {
        const string path = "typeFieldAccesses.txt";
        using FileStream stream = File.Create(path);
        using StreamWriter sw = new(stream);
        TreeAnalysis.WriteUnityTypeFieldAccesses(sw, perTypeTreeData);
        Log.Write($"Wrote type field accesses to {Path.GetFullPath(path)}", ConsoleColor.Cyan);
    }

    if (exportComplexTypeFieldAccesses)
    {
        const string path = "complexTypeFieldAccesses.txt";
        using FileStream stream = File.Create(path);
        using StreamWriter sw = new(stream);
        TreeAnalysis.WriteComplexTypesFieldAccesses(sw, complexTypes);
        Log.Write($"Wrote complex type field accesses to {Path.GetFullPath(path)}", ConsoleColor.Cyan);
    }

    if (exportComplexTypeMap)
    {
        const string path = "complexTypeMap.json";
        using FileStream stream = File.Create(path);
        using StreamWriter sw = new(stream);
        TreeAnalysis.WriteComplexTypesJson(sw, complexTypes);
        Log.Write($"Wrote complex type map to {Path.GetFullPath(path)}", ConsoleColor.Cyan);
    }

    if (exportComplexTypeRefcounts)
    {
        const string path = "complexTypeRefcounts.txt";
        using FileStream stream = File.Create(path);
        using StreamWriter sw = new(stream);
        TreeAnalysis.WriteComplexTypesRefcounts(sw, complexTypes);
        Log.Write($"Wrote complex type refcounts to {Path.GetFullPath(path)}", ConsoleColor.Cyan);
    }

}

static void ProcessSerializedFile(SerializedFile file, ThreadLocalWorkData workData)
{
    SerializedFileReader fileReader = new(file);
    
    if (file.Target.WithTypeTree)
    {
        workData.Reader.StartFile(file);
        
        fileReader.ReadObjectRange(
            treeReader: workData.Reader,
            withDebugReader: false,
            startIdx: 0,
            endIdx: file.ObjectInstances.Length,
            fnStartedOne: (i, _) =>
            {
                int typeIdx = file.ObjectInstances[i].TypeIdx;
                UnityObjectType type = file.Objects[typeIdx].Info.Type;
                workData.Reader.StartObject(type);
            },
            fnFinishedOne: (_, _) => { });
    }
    else
    {
        Log.Write($"{file.Info.Identifier} does not have embedded type tree info.", ConsoleColor.Yellow);
    }
}

public readonly record struct ThreadLocalWorkData(
    ITreeReader Reader,
    Dictionary<UnityObjectType, PerTypeTreeData> Data);
    

public sealed record class PerTypeTreeData(
    Dictionary<TreePath, int> PathRefs)
{
    public PerTypeTreeData() : this([]) { }

    public int ObjectCount => _objectCount;
    public void IncObjectCount(int count) => Interlocked.Add(ref _objectCount, count);
    private int _objectCount;

    public override string ToString() => $"{ObjectCount} objects";
}
