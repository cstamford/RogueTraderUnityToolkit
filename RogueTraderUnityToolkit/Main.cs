using CommandLine;
using RogueTraderUnityToolkit;
using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Processors;
using RogueTraderUnityToolkit.Unity;
using RogueTraderUnityToolkit.Unity.File;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO.MemoryMappedFiles;

Stopwatch sw = Stopwatch.StartNew();
SuperluminalPerf.Initialize();

ParserResult<Args> argsResult = Parser.Default.ParseArguments<Args>(args);
if (argsResult.Tag == ParserResultType.NotParsed) return;

Args arguments = argsResult.Value;
Log.Write($"Collecting files from {string.Join(", ", arguments.ImportPaths)}");

List<FileInfo> files = [];

foreach (FileInfo info in arguments.ImportPaths
    .Where(path => !string.IsNullOrEmpty(path))
    .Select(path => new FileInfo(path)))
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

Log.Write($"Collected {files.Count} files.");

int fileCountLoaded = 0;
int assetCountLoaded = 0;
int assetCountPending = 0;
int assetCountSkipped = 0;
int assetCountFailed = 0;

bool finishedAll = false;

Thread logThread = new(() =>
{
    while (!finishedAll) // Use a flag to signal when to stop the thread
    {
        // Perform the logging
        Log.Write($"{fileCountLoaded} files loaded, " +
                  $"{assetCountLoaded} assets loaded, " +
                  $"{assetCountPending} pending, " +
                  $"{assetCountSkipped} skipped, " +
                  $"{assetCountFailed} failed");

        // Sleep for a short time before logging again
        Thread.Sleep(500); // Adjust the sleep interval as needed
    }
});

logThread.Start();

TimeSpan loadStartTime = sw.Elapsed;

IAssetLoader[] diskFileLoaders =
[
    new AssetBundleLoader(),
    new ResourceFileLoader()
];

IAssetLoader[] bundleLoaders =
[
    new SerializedFileLoader(),
    new ResourceFileLoader()
];

ParallelOptions parallelOpts = new();

if (arguments.ThreadCount > 0)
{
    parallelOpts.MaxDegreeOfParallelism = arguments.ThreadCount;
}

ConcurrentBag<ISerializedAsset> assets = [];
IAssetProcessor processor = SelectProcessor(arguments);

Parallel.ForEach(
    Partitioner.Create(files, EnumerablePartitionerOptions.NoBuffering),
    parallelOpts,
    fileInfo =>
{
    if (!TryLoadAssetFromPath(
        diskFileLoaders,
        fileInfo,
        out MemoryMappedFile? bundleFile,
        out ISerializedAsset? bundleAsset))
    {
        Log.Write($"Unable to load {fileInfo.Name}", ConsoleColor.Yellow);
        return;
    }

    try
    {
        AssetBundle? bundle = bundleAsset as AssetBundle;
        if (bundle == null) return;

        IRelocatableMemoryRegion[] bundleMemory = bundle.CreateRelocatableMemoryRegions();

        foreach (AssetBundleNode bundleNode in bundle.Manifest.Nodes)
        {
            if (!TryLoadAssetFromInfo(
                bundleLoaders,
                bundle.CreateAssetInfoForNode(bundleNode, bundleMemory),
                out ISerializedAsset asset))
            {
                Log.Write($"Unable to load {bundleNode.Path} from {bundle.Info.Identifier}", ConsoleColor.Yellow);
                continue;
            }

            processor.Process(
                arguments,
                bundle,
                asset,
                out int processed,
                out int skipped,
                out int failed);

            Interlocked.Add(ref assetCountLoaded, processed);
            Interlocked.Add(ref assetCountSkipped, skipped);
            Interlocked.Add(ref assetCountFailed, failed);
        }
    }
    catch (Exception e)
    {
        Log.Write(e.ToString(), ConsoleColor.Red);
    }
    finally
    {
        bundleFile?.Dispose();
    }

    Interlocked.Increment(ref fileCountLoaded);
});

finishedAll = true;
logThread.Join();

ConsoleColor color = assetCountFailed > 0 ? ConsoleColor.Red : assetCountSkipped > 0 ? ConsoleColor.Yellow : Log.DefaultColor;

Log.Write(
    new LogEntry($"Loaded {assetCountLoaded} assets in {sw.Elapsed.Subtract(loadStartTime).TotalSeconds:f2} seconds ("),
    new LogEntry($"{assetCountSkipped} skipped, {assetCountFailed} failed", color),
    new LogEntry(")"));

processor.End(arguments, [..assets]);

return;

bool TryLoadAssetFromPath(
    IEnumerable<IAssetLoader> loaders,
    FileInfo fileInfo,
    out MemoryMappedFile? file,
    out ISerializedAsset? asset)
{
    file = MemoryMappedFile.CreateFromFile(fileInfo.FullName, FileMode.Open);
    SerializedAssetInfo info = new(parent: null, identifier: fileInfo.Name, size: fileInfo.Length, file.CreateViewStream);

    if (!TryLoadAssetFromInfo(loaders, info, out asset))
    {
        file.Dispose();
        file = null;
        return false;
    }

    return true;
}

bool TryLoadAssetFromInfo(
    IEnumerable<IAssetLoader> loaders,
    SerializedAssetInfo info,
    out ISerializedAsset asset)
{
    using SuperluminalPerf.EventMarker _ = Util.PerfScope("TryLoadAssetFromInfo", new(0, 128, 128));

    IAssetLoader? loader = loaders.FirstOrDefault(loader => CanReadSafe(loader, info));

    if (loader != null)
    {
        Interlocked.Increment(ref assetCountPending);

        try
        {
            asset = loader.Read(info);
            Interlocked.Increment(ref assetCountLoaded);
            assets.Add(asset);
            return true;
        }
        catch (Exception e)
        {
            Log.Write($"Failed to load {info.Identifier} because:\n{e}", ConsoleColor.Red);
            Interlocked.Increment(ref assetCountFailed);
        }
        finally
        {
            Interlocked.Decrement(ref assetCountPending);
        }
    }
    else
    {
        Interlocked.Increment(ref assetCountSkipped);
    }

    asset = default!;
    return false;

    bool CanReadSafe(IAssetLoader loaderToTest, SerializedAssetInfo infoToTest)
    {
        try
        {
            return loaderToTest.CanRead(infoToTest);
        }
        catch (Exception e)
        {
            if (arguments.Debug)
            {
                Log.Write(e.Message, ConsoleColor.DarkGray);

                foreach (LogEntry entry in e.StackTrace!
                    .Split(Environment.NewLine)
                    .Take(2)
                    .Select(x => new LogEntry(x.Trim(), ConsoleColor.DarkGray)))
                {
                    Log.Write(indent: 4, entry);
                }
            }

            return false;
        }
    }
}

static IAssetProcessor SelectProcessor(Args args) => args.Mode switch
{
    ProcessMode.Codegen => new CodeGeneration(),
    _ => throw new ArgumentOutOfRangeException(nameof(args))
};
