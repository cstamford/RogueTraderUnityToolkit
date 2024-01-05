using Codegen;
using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using RogueTraderUnityToolkit.Unity.File;
using RogueTraderUnityToolkit.UnityGenerated;
using RogueTraderUnityToolkit.UnityGenerated.Types.Engine;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO.MemoryMappedFiles;
using System.Runtime.CompilerServices;
using AssetBundle = RogueTraderUnityToolkit.Unity.File.AssetBundle;

SuperluminalPerf.Initialize();

List<string> paths = [
    @"C:\Program Files (x86)\Steam\steamapps\common\Warhammer 40,000 Rogue Trader\Bundles",
    @"C:\Program Files (x86)\Steam\steamapps\common\Warhammer 40,000 Rogue Trader\WH40KRT_Data"
];

List<FileInfo> files = [];

foreach (FileInfo info in paths.Select(path => new FileInfo(path)))
{
    if ((info.Attributes & FileAttributes.Directory) != 0)
    {
        files.AddRange(Directory
            .EnumerateFiles(info.FullName, "*", SearchOption.AllDirectories)
            .Select(x => new FileInfo(x))
            .Where(x => x.Length > 0));
    }
    else
    {
        files.Add(info);
    }
}

files.Sort((x, y) => y.Length.CompareTo(x.Length));

ParallelOptions parallelOpts = new();

#if DEBUG_VERBOSE
parallelOpts.MaxDegreeOfParallelism = 1;
files = files[..5];
#endif

ConcurrentBag<ThreadLocalWorkData> workDatas = [];

Parallel.ForEach(
    Partitioner.Create(files, EnumerablePartitionerOptions.NoBuffering),
    parallelOpts, (fileInfo, _, _) =>
{
    ThreadLocalWorkData workData = TakeWorkData();
    ProcessOneFileInfo(fileInfo, workData);
    ReturnWorkData(workData);
});

Dictionary<TreePathObject, int> treePathObjects = [];
List<IUnityObject> deserializedObjects = [];

foreach (ThreadLocalWorkData wd in workDatas)
{
    foreach ((TreePathObject obj, int refs) in wd.Objects)
    {
        if (!treePathObjects.TryAdd(obj, refs)) treePathObjects[obj] += refs;
    }

    deserializedObjects.AddRange(wd.DeserializedObjects);
}

TreeReport report = TreeAnalysis.CalculateReport(treePathObjects);
ExportAnalysis(report);

IEnumerable<MonoScript> deserializedScriptInfo = deserializedObjects.OfType<MonoScript>();
ExportScripts(deserializedScriptInfo);

Log.Write($"{report.AllPathObjects.Length} objects with " +
          $"{report.AllPathObjects.Sum(x => x.Item2)} refs, " +
          $"{report.AllPathObjects.Sum(x => x.Item1.Paths.Count)} paths", ConsoleColor.Green);

Codegen.Codegen codegen = new(report);

codegen.ReadGameStructures(report, deserializedScriptInfo
    .DistinctBy(x => x.m_PropertiesHash)
    .ToDictionary(x => x.m_PropertiesHash, x => x.m_ClassName));

ExportCodegen(codegen);

return;

static void ExportCodegen(Codegen.Codegen codegen)
{
    const bool exportStructures = true;

    if (exportStructures)
    {
        const string path = @"D:\\RogueTraderUnityToolkit\\RogueTraderUnityToolkit.UnityGenerated\\Types";

        if (Directory.Exists(path))
        {
            Log.Write($"Cleaning up {path}");
            Directory.Delete(path, recursive: true);
        }

        Directory.CreateDirectory(path);
        codegen.WriteStructures(path);
        Log.Write($"Wrote structures to {path}", ConsoleColor.Cyan);
    }
}

static void ExportAnalysis(in TreeReport report)
{
    const bool exportAllPaths = true;
    const bool exportFieldAccessByTypeName = true;
    const bool exportFieldAccessByUnityType = true;
    const bool exportHashAnalysis = true;

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

    if (exportHashAnalysis)
    {
        const string path = "hashAnalysis.txt";
        using FileStream stream = File.Create(path);
        using StreamWriter sw = new(stream);
        TreeAnalysis.WriteHashAnalysis(sw, report);
        Log.Write($"Saved {Path.GetFullPath(path)}", ConsoleColor.Cyan);
    }
}

static void ExportScripts(IEnumerable<MonoScript> scripts)
{
    const bool exportScripts = true;

    if (exportScripts)
    {
        const string path = "scripts.txt";
        using FileStream stream = File.Create(path);
        using StreamWriter sw = new(stream);

        foreach (MonoScript script in scripts
            .DistinctBy(x => x.m_PropertiesHash)
            .OrderBy(x => x.m_AssemblyName)
            .ThenBy(x => x.m_Namespace)
            .ThenBy(x => x.m_ClassName))
        {
            sw.WriteLine($"{script.m_PropertiesHash} {script.m_AssemblyName}:{script.m_Namespace}.{script.m_ClassName}");
        }

        Log.Write($"Saved {Path.GetFullPath(path)}", ConsoleColor.Cyan);
    }
}

static void ProcessOneFileInfo(
    FileInfo fileInfo,
    ThreadLocalWorkData workData)
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
}

static void ProcessSerializedFile(
    SerializedFile file,
    ThreadLocalWorkData workData)
{
    ParseTypeTree(file, workData);
    DeserializeObjects(file, workData);
}

static void ParseTypeTree(
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
                ref SerializedFileObjectInstance instance = ref file.ObjectInstances[i];
                workData.Reader.StartObject(file.Objects[instance.TypeIdx].Info, instance);
            },
            fnFinishedOne: i =>
            {
                ref SerializedFileObjectInstance instance = ref file.ObjectInstances[i];
                workData.Reader.FinishObject(file.Objects[instance.TypeIdx].Info, instance);
            });

        workData.Reader.FinishFile(file);
    }
    else
    {
        // TODO: These actually have a bunch of instances in them, but don't come with type trees.
        // So I suppose we need to look up their dependencies and get the type trees from them.
        Log.Write($"{file.Info.Identifier} does not have embedded type tree info.", ConsoleColor.Yellow);
    }
}

static void DeserializeObjects(
    SerializedFile file,
    ThreadLocalWorkData workData)
{
    using Stream stream = file.Info.Open(file.Header.DataOffset);
    EndianBinaryReader reader = new(stream, file.Header.IsBigEndian);

    foreach (SerializedFileObjectInstance instance in file.ObjectInstances)
    {
        SerializedFileObjectInfo info = file.Objects[instance.TypeIdx].Info;
        //if (info.Type != UnityObjectType.MonoScript) continue;

        reader.Position = (int)instance.Offset;

        if (GeneratedTypes.TryCreateType(info.Hash, reader, out IUnityObject obj))
        {
            workData.DeserializedObjects.Add(obj);

#if DEBUG_VERBOSE
            Log.Write($"Created {obj}!", ConsoleColor.Green);
#endif
        }
        else
        {
            Log.Write($"Failed to create type {info.Hash}", ConsoleColor.Yellow);
        }

        // Because of the way we handle the alignment (reading top to bottom for performance reasons), we miss the final alignment
        // at the end of each object, so we have to align the stream position to 4 for this check to make sense.
        Debug.Assert(Memory.AlignTo(reader.Position, 4) == instance.Offset + instance.Size);
    }
}

[MethodImpl(MethodImplOptions.NoInlining)]
ThreadLocalWorkData TakeWorkData()
{
    using var _ = SuperluminalPerf.BeginEvent("TakeWorkData");

    if (!workDatas.TryTake(out ThreadLocalWorkData? workData))
    {
        Dictionary<TreePathObject, int> dict = [];
        workData = new(new TreeReader(new(), dict), dict, []);
    }

    return workData;
}

[MethodImpl(MethodImplOptions.NoInlining)]
void ReturnWorkData(ThreadLocalWorkData data)
{
    using var _ = SuperluminalPerf.BeginEvent("ReturnWorkData");
    workDatas.Add(data);
}

internal record class ThreadLocalWorkData(
    ITreeReader Reader,
    Dictionary<TreePathObject, int> Objects,
    List<IUnityObject> DeserializedObjects);
