using Codegen;
using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using RogueTraderUnityToolkit.Unity.File;
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

files = files
    .Where(file => file.Length != 0)
    .OrderBy(x => x.FullName);

ParallelOptions parallelOpts = new();

#if DEBUG_VERBOSE
parallelOpts.MaxDegreeOfParallelism = 1;
files = files.Take(50);
#endif

Dictionary<TreePathObject, int> treePathObjects = [];

Parallel.ForEach(files
        .Where(file => file.Length != 0)
        .OrderByDescending(file => file.Length),
    parallelOpts,
    () =>
    {
        Dictionary<TreePathObject, int> dict = [];
        return new ThreadLocalWorkData(true switch
        {
            false => new TreeReaderDebug(Console.OpenStandardOutput()),
            true => new TreeReader(new TreePathAllocator(), dict)
        }, dict);
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
#if DEBUG_VERBOSE
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
#if DEBUG_VERBOSE
            Log.Write($"Skipping {diskFileInfo}", ConsoleColor.DarkGray);
#endif
        }

        return workData;
    },
    workData =>
    {
        Dictionary<TreePathObject, int> ours = workData.Objects;

        lock (treePathObjects)
        {
            foreach ((TreePathObject obj, int refs) in ours)
            {
                if (!treePathObjects.TryAdd(obj, refs))
                    treePathObjects[obj] += refs;
            }
        }
    });

Log.Write($"{treePathObjects.Count} objects", ConsoleColor.Green);

TreeReport report = TreeAnalysis.CalculateReport(treePathObjects);
ExportAnalysis(report);

Codegen.Codegen codegen = new(report);
ExportCodegen(codegen);

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

static void ExportAnalysis(in TreeReport report)
{
    const bool exportAllPaths = true;
    const bool exportFieldAccessByTypeName = true;
    const bool exportFieldAccessByUnityType = true;

    if (exportAllPaths)
    {
        const string path = "allPaths.txt";
        using FileStream stream = File.Create(path);
        using StreamWriter sw = new(stream);
        TreeAnalysis.WriteAllPaths(sw, report);
        Log.Write($"Saved {Path.GetFullPath(path)}", ConsoleColor.Cyan);
    }

    if (exportFieldAccessByTypeName)
    {
        const string path = "fieldAccessByTypeName.txt";
        using FileStream stream = File.Create(path);
        using StreamWriter sw = new(stream);
        TreeAnalysis.WriteFieldAccessByTypeName(sw, report);
        Log.Write($"Saved {Path.GetFullPath(path)}", ConsoleColor.Cyan);
    }

    if (exportFieldAccessByUnityType)
    {
        const string path = "fieldAccessByUnityType.txt";
        using FileStream stream = File.Create(path);
        using StreamWriter sw = new(stream);
        TreeAnalysis.WriteFieldAccessByUnityType(sw, report);
        Log.Write($"Saved {Path.GetFullPath(path)}", ConsoleColor.Cyan);
    }
}

static void ProcessSerializedFile(
    SerializedFile file,
    ThreadLocalWorkData workData)
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
            fnStartedOne: i =>
            {
                int typeIdx = file.ObjectInstances[i].TypeIdx;
                UnityObjectType type = file.Objects[typeIdx].Info.Type;
                workData.Reader.StartObject(type);
            },
            fnFinishedOne: i =>
            {
                int typeIdx = file.ObjectInstances[i].TypeIdx;
                UnityObjectType type = file.Objects[typeIdx].Info.Type;
                workData.Reader.FinishObject(type);
            });

        workData.Reader.FinishFile(file);
    }
    else
    {
        Log.Write($"{file.Info.Identifier} does not have embedded type tree info.", ConsoleColor.Yellow);
    }
}

record class ThreadLocalWorkData(ITreeReader Reader, Dictionary<TreePathObject, int> Objects);
