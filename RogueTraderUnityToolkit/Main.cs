
using CommandLine;
using RogueTraderUnityToolkit;
using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Loaders;
using RogueTraderUnityToolkit.Readers;
using RogueTraderUnityToolkit.Unity;
using System.Diagnostics;
using System.IO.MemoryMappedFiles;

Stopwatch sw = Stopwatch.StartNew();
SuperluminalPerf.Initialize();

ParserResult<Args> argsResult = Parser.Default.ParseArguments<Args>(args);
if (argsResult.Tag == ParserResultType.NotParsed) return;

Args arguments = argsResult.Value;

Log.Write($"Collecting files from {string.Join(", ", arguments.ExportPaths)} ...");

IEnumerable<FileInfo> files = [];

foreach (string path in arguments.ExportPaths)
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

#if DEBUG
Log.Write("DEBUG: Randomizing order and capping input count.", ConsoleColor.Yellow);
files = files.Shuffle().Take(250);
#endif

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
    new SerializedResourceFileLoader()
];

ParallelOptions parallelOpts = new();

#if DEBUG
Log.Write("DEBUG: Running on a single thread.", ConsoleColor.Yellow);
parallelOpts.MaxDegreeOfParallelism = 1;
#endif

Parallel.ForEach(files, parallelOpts, fileInfo =>
{
    if (!TryLoadAssetFromPath(
        diskFileLoaders,
        fileInfo,
        out MemoryMappedFile? bundleFile,
        out SerializedAssetInfo? _,
        out ISerializedAsset? bundleAsset))
    {
        return;
    }
    
    try
    {
        AssetBundle? bundle = bundleAsset as AssetBundle;
        Debug.Assert(bundle != null);
        
        IRelocatableMemoryRegion[] bundleMemory = PrepMemoryForBundle(bundle);
        
        foreach (AssetBundleNode bundleNode in bundle.Manifest.Nodes)
        {
            if (!TryLoadSerializedFileFromNode(
                bundle,
                bundleNode,
                bundleMemory,
                out SerializedFile? file))
            {
                LogDebug.Write($"Unable to load {bundleNode.Path} from {bundle.Info.Identifier}", ConsoleColor.Yellow);
                return;
            }
            
            Debug.Assert(file != null);
            SerializedFileReader fileReader = new(file);
            
            int instances = file.ObjectInstances.Length;
            Interlocked.Add(ref assetCountPending, instances);
            
            using BufferedStream bufferedStream = new(new NullStream());
            using StreamWriter bufferedStreamWriter = new(bufferedStream);
            
            IObjectTypeTreeReader treeReader = new TypeTreeTextReader(bufferedStreamWriter, () =>
            {
                Interlocked.Increment(ref assetCountLoaded);
                Interlocked.Decrement(ref assetCountPending);
            });

            fileReader.ReadObjectRange(0, instances, treeReader);
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
    new LogEntry($"{assetCountSkipped} warnings, {assetCountFailed} errors", color),
    new LogEntry(")"));

return;

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

bool TryLoadSerializedFileFromNode(
    AssetBundle bundle,
    AssetBundleNode node,
    IReadOnlyList<IRelocatableMemoryRegion> memory,
    out SerializedFile? file)
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
        identifier: node.Path,
        size: node.Size,
        fnOpen: (offset, length) =>
        {
            MultiMemoryStream mms = new(overlapMem);
            if (offset != 0) return mms.Slice(offset, length == 0 ? overlapMem.Sum(x => x.Length) - offset : length);
            if (length != 0) return mms.Slice(0, length);
            return mms;
        });

#if DEBUG
    info.UserData = overlapMem;
#endif

    IEnumerable<IAssetLoader> loader = [new SerializedFileLoader()];

    if (!TryLoadAssetFromInfo(loader, info, out ISerializedAsset? asset))
    {
        file = null;
        return false;
    }

    file = asset as SerializedFile;
    return file != null;
}

bool TryLoadAssetFromPath(
    IEnumerable<IAssetLoader> loaders,
    FileInfo fileInfo,
    out MemoryMappedFile? file,
    out SerializedAssetInfo? info,
    out ISerializedAsset? asset)
{
    file = MemoryMappedFile.CreateFromFile(fileInfo.FullName, FileMode.Open);
    info = new(parent: null, identifier: fileInfo.Name, size: fileInfo.Length, file.CreateViewStream);

    if (!TryLoadAssetFromInfo(loaders, info, out asset))
    {
        file.Dispose();
        file = null;
        info = null;
        return false;
    }

    return true;
}

bool TryLoadAssetFromInfo(
    IEnumerable<IAssetLoader> loaders,
    SerializedAssetInfo info,
    out ISerializedAsset? asset)
{
    using var _ = Util.PerfScope("TryLoadAssetFromInfo", new(0, 128, 128));

    IAssetLoader? loader = loaders.FirstOrDefault(loader => CanReadSafe(loader, info));

    if (loader != null)
    {
        Interlocked.Increment(ref assetCountPending);

        try
        {
            asset = loader.Read(info);
            Interlocked.Increment(ref assetCountLoaded);
            return true;
        }
        catch (Exception e)
        {
            Log.Write($"Failed to load {info.Identifier} because:\n{e}", ConsoleColor.Red);
            Interlocked.Increment(ref assetCountFailed);
            asset = null;
        }
        finally
        {
            Interlocked.Decrement(ref assetCountPending);
        }
    }
    else
    {
        Interlocked.Increment(ref assetCountSkipped);
        asset = null;
    }
    
    return false;

    bool CanReadSafe(IAssetLoader loader, SerializedAssetInfo info)
    {
        try
        {
            return loader.CanRead(info);
        }
#if DEBUG
        catch (Exception e)
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
#else
        catch { /* intentionally ignored */ }
#endif

        return false;
    }
}
