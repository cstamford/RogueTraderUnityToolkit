using CommandLine;
using RogueTraderUnityToolkit;
using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Processors;
using RogueTraderUnityToolkit.Unity;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO.MemoryMappedFiles;

Stopwatch sw = Stopwatch.StartNew();
SuperluminalPerf.Initialize();

ParserResult<Args> argsResult = Parser.Default.ParseArguments<Args>(args);
if (argsResult.Tag == ParserResultType.NotParsed) return;

Args arguments = argsResult.Value;
bool withDebugger = Debugger.IsAttached;

Log.Write($"Collecting files from {string.Join(", ", arguments.ImportPaths)}");

IEnumerable<FileInfo> files = [];

foreach (string path in arguments.ImportPaths)
{
    FileInfo info = new(path);
    bool isDir = (info.Attributes & FileAttributes.Directory) != 0;
        
    files = isDir ?
        files.Concat(Directory
            .EnumerateFiles(info.FullName, "*", SearchOption.AllDirectories)
            .Select(x => new FileInfo(x))) :
        files.Append(info);
}

Log.Write($"Collected {files.Count()} files.");

// We order the files to ensure better parallelism.
// If we don't, we can waste a lot of time at the end waiting for one very big object to parse.
files = files.OrderByDescending(file => file.Length);

if (withDebugger)
{
    Log.Write("DEBUG: Randomizing order and capping input count.", ConsoleColor.Yellow);
    files = files.Shuffle().Take(250);
}

int fileCountLoaded = 0;
int assetCountLoaded = 0;
int assetCountPending = 0;
int assetCountSkipped = 0;
int assetCountFailed = 0;

Timer logOutputTimer = new(_ =>
{
    Log.Write($"{fileCountLoaded} files loaded, " +
              $"{assetCountLoaded} assets loaded, " +
              $"{assetCountPending} pending, " +
              $"{assetCountSkipped} skipped, " +
              $"{assetCountFailed} failed");
}, null, TimeSpan.FromSeconds(0.5), TimeSpan.FromSeconds(0.5));

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
IAssetProcessor processor = SelectProcessor();

Parallel.ForEach(files, parallelOpts, fileInfo =>
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

        IRelocatableMemoryRegion[] bundleMemory = PrepMemoryForBundle(bundle);

        foreach (AssetBundleNode bundleNode in bundle.Manifest.Nodes)
        {
            if (!TryLoadAssetFromNode(
                bundleLoaders,
                bundle,
                bundleNode,
                bundleMemory,
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

logOutputTimer.Dispose();

ConsoleColor color = assetCountFailed > 0 ? ConsoleColor.Red : assetCountSkipped > 0 ? ConsoleColor.Yellow : ConsoleColor.White;

Log.Write(
    new LogEntry($"Loaded {assetCountLoaded} assets in {sw.Elapsed.Subtract(loadStartTime).TotalSeconds:f2} seconds ("),
    new LogEntry($"{assetCountSkipped} skipped, {assetCountFailed} failed", color),
    new LogEntry(")"));

processor.End(arguments, [..assets]);

return;

IAssetProcessor SelectProcessor()
{
    /* TODO switch on mode */
    return new ExportTrees();
}

IRelocatableMemoryRegion[] PrepMemoryForBundle(AssetBundle bundle)
{
    AssetBundleBlock[] blocks = bundle.Manifest.Blocks;
    IRelocatableMemoryRegion[] regionsMem = new IRelocatableMemoryRegion[blocks.Length];
    
    for (int i = 0; i < blocks.Length; ++i)
    {
        ref AssetBundleBlock block = ref blocks[i];
        ref AssetBundleBlockRegion blockRegion = ref bundle.Regions[i];
        
        regionsMem[i] = MemoryCache.Register(
            new AssetBundleBlockLoader(bundle.Info, block, blockRegion),
            (int)block.UncompressedSize, (int)blockRegion.MemoryOffset);
    }
        
    return regionsMem;
}

bool TryLoadAssetFromNode(
    IEnumerable<IAssetLoader> loaders,
    AssetBundle bundle,
    AssetBundleNode node,
    IReadOnlyList<IRelocatableMemoryRegion> memory,
    out ISerializedAsset asset)
{
    IRelocatableMemoryRegion[] overlapMem = [.. bundle.Regions
        .WithIndex()
        .Where(x => x.item.Overlaps(node))
        .Select(x =>
        {
            AssetBundleBlockRegion region = x.item;
            IRelocatableMemoryRegion regionMem = memory[x.index];
        
            long nodeAddress = node.Offset;
            long nodeLength = node.Size;
            long blockAddress = region.MemoryOffset;
            long blockLength = region.MemoryLength;
        
            int start = (int)Math.Max(nodeAddress, blockAddress);
            int end = (int)Math.Min(nodeAddress + nodeLength, blockAddress + blockLength);
        
            int offset = (int)(start - blockAddress);
            int length = end - start;
        
            Debug.Assert(offset >= 0 && offset <= blockLength);
            Debug.Assert(length > 0 && length <= blockLength);
        
            return regionMem.Slice(offset, length);
        })];

    SerializedAssetInfo info = new(
        parent: bundle,
        identifier: node.Path.ToString(),
        size: node.Size,
        fnOpen: (offset, length) =>
        {
            MultiMemoryStream mms = new(overlapMem);
            if (offset != 0) return mms.Slice(offset, length == 0 ? overlapMem.Sum(x => x.Length) - offset : length);
            if (length != 0) return mms.Slice(0, length);
            return mms;
        });

    if (withDebugger)
    {
        info.UserData = overlapMem;
    }
    
    return TryLoadAssetFromInfo(loaders, info, out asset);
}

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

public interface IAssetLoader
{
    public bool CanRead(SerializedAssetInfo info);
    public ISerializedAsset Read(SerializedAssetInfo info);
}

public readonly struct AssetBundleLoader : IAssetLoader
{
    public bool CanRead(SerializedAssetInfo info) => AssetBundle.CanRead(info);
    public ISerializedAsset Read(SerializedAssetInfo info) => AssetBundle.Read(info);
}

public readonly struct SerializedFileLoader : IAssetLoader
{
    public bool CanRead(SerializedAssetInfo info) => SerializedFile.CanRead(info);
    public ISerializedAsset Read(SerializedAssetInfo info) => SerializedFile.Read(info);
}

public readonly struct ResourceFileLoader : IAssetLoader
{
    public bool CanRead(SerializedAssetInfo info) => ResourceFile.CanRead(info);
    public ISerializedAsset Read(SerializedAssetInfo info) => ResourceFile.Read(info);
}
