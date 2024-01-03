using Codegen;
using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using RogueTraderUnityToolkit.Unity.File;
using System.Buffers.Binary;
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

                if (false)
                {
                    MemoryScanSerializedFile(serializedFile);
                }
                else
                {
                    ProcessSerializedFile(serializedFile, workData);
                }
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
/* TODO codegen.ReadGameStructures(...); */

ExportCodegen(codegen);

return;

static void ExportCodegen(Codegen.Codegen codegen)
{
    const bool exportStructures = true;

    if (exportStructures)
    {
        const string path = @"D:\\RogueTraderUnityToolkit\\RogueTraderUnityToolkit.Unity\\Generated";

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
            fnStartedOne: i => workData.Reader.StartObject(file.Objects[file.ObjectInstances[i].TypeIdx].Info),
            fnFinishedOne: i => workData.Reader.FinishObject(file.Objects[file.ObjectInstances[i].TypeIdx].Info));

        workData.Reader.FinishFile(file);
    }
    else
    {
        // TODO: These actually have a bunch of instances in them, but don't come with type trees.
        // So I suppose we need to look up their dependencies and get the type trees from them.
        Log.Write($"{file.Info.Identifier} does not have embedded type tree info.", ConsoleColor.Yellow);
    }
}

static void MemoryScanSerializedFile(
    SerializedFile file)
{
    using Stream stream = file.Info.Open();

    Span<byte> hashLittleEndian = stackalloc byte[16];
    BinaryPrimitives.WriteUInt32LittleEndian(hashLittleEndian[..4], 3082389775);
    BinaryPrimitives.WriteUInt32LittleEndian(hashLittleEndian[4..8], 2284741498);
    BinaryPrimitives.WriteUInt32LittleEndian(hashLittleEndian[8..12], 3972055074);
    BinaryPrimitives.WriteUInt32LittleEndian(hashLittleEndian[12..], 2155042913);

    Span<byte> hashBigEndian = stackalloc byte[16];
    BinaryPrimitives.WriteUInt32BigEndian(hashBigEndian[..4], 3082389775);
    BinaryPrimitives.WriteUInt32BigEndian(hashBigEndian[4..8], 2284741498);
    BinaryPrimitives.WriteUInt32BigEndian(hashBigEndian[8..12], 3972055074);
    BinaryPrimitives.WriteUInt32BigEndian(hashBigEndian[12..], 2155042913);

    (string, byte[])[] patternsToScan =
    [
        ("UnitDismembermentManager name", "UnitDismembermentManager"u8.ToArray()),
        ("Hash128 little endian", hashLittleEndian.ToArray()),
        ("Hash128 big endian", hashBigEndian.ToArray())
    ];

    List<(string, long)> matches = [];

    const int bufferSize = 32768;
    Span<byte> buffer = stackalloc byte[bufferSize];

    while (true)
    {
        buffer = buffer[..Math.Min((int)(stream.Length - stream.Position), bufferSize)];
        if (buffer.Length == 0) break;

        int bytesRead = stream.Read(buffer);

        foreach ((string name, byte[] pattern) in patternsToScan)
        {
            int index = 0;
            while (index < bytesRead)
            {
                int indexOf = buffer.Slice(index, bytesRead - index).IndexOf(pattern);
                if (indexOf < 0) break;

                matches.Add((name, stream.Position - bytesRead + index));
                index += indexOf + pattern.Length;
            }
        }

        buffer = buffer[..Math.Min((int)(stream.Length - stream.Position), bufferSize)];
    }

    foreach ((string match, long matchOffset) in matches)
    {
        Log.WriteSingle($"Match {match} at offset {matchOffset} in {file.Info.Identifier}");

        if (matchOffset < file.Header.DataOffset)
        {
            Log.Write(" Header Segment", ConsoleColor.DarkGreen);
        }
        else
        {
            long dataOffset = matchOffset - file.Header.DataOffset;

            Log.WriteSingle(" Data Segment in ", ConsoleColor.DarkMagenta);

            foreach (var overlap in file.ObjectInstances
                .Where(x => x.Offset <= dataOffset && x.Offset + x.Size >= dataOffset)
                .Select(x => new
                {
                    Instance = x,
                    Object = file.Objects[x.TypeIdx],
                    RelativeOffset = dataOffset - x.Offset
                }))
            {
                Log.Write($"[{overlap.Instance.TypeIdx}] " +
                          $"{overlap.Object.Info.Type}" +
                          $"+0x{overlap.RelativeOffset:X}", ConsoleColor.DarkMagenta);
            }
        }
    }
}

internal record class ThreadLocalWorkData(ITreeReader Reader, Dictionary<TreePathObject, int> Objects);
