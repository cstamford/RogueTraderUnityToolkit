using RogueTraderUnityToolkit;
using RogueTraderUnityToolkit.Export;
using RogueTraderUnityToolkit.Helper;
using RogueTraderUnityToolkit.Unity;
using System.Buffers;
using System.Diagnostics;
using System.IO.MemoryMappedFiles;

const string _gameBundleFolder = @"C:\Program Files (x86)\Steam\steamapps\common\Warhammer 40,000 Rogue Trader\Bundles";
const string _gameDataFolder = @"C:\Program Files (x86)\Steam\steamapps\common\Warhammer 40,000 Rogue Trader\WH40KRT_Data";
const string _outputDir = @"D:\RogueTraderModding\output";

SuperluminalPerf.Initialize();

Stopwatch _sw = Stopwatch.StartNew();
TimeSpan _printTime = TimeSpan.FromMilliseconds(333);

if (Directory.Exists(_outputDir))
{
    Log.WriteSingle($"!WARNING! Output dir {_outputDir} exists! Enter Y to delete it!: ", ConsoleColor.Yellow);
    if (!Console.ReadLine()?.Equals("y", StringComparison.CurrentCultureIgnoreCase) ?? false) return;
    Log.Write($"Deleting {_outputDir}", ConsoleColor.Yellow);
    Directory.Delete(_outputDir, recursive: true);
}

Directory.CreateDirectory(_outputDir);

IEnumerable<FileInfo> importFiles = Directory
    .EnumerateFiles(Path.Combine(_gameBundleFolder), "*", SearchOption.AllDirectories)
    .Select(x => new FileInfo(x));

if (Options.FastIterationInDebug)
{
    importFiles = importFiles.Shuffle().Take(250);
}

ISerializedAsset[] containers = ImportContainers(importFiles);
ProcessContainers(containers);

Log.Write($"Total time: {_sw.Elapsed.TotalSeconds:f2} seconds");
Log.Write("Ave Deus Mechanicus!");

ISerializedAsset[] ImportContainers(IEnumerable<FileInfo> files)
{
    Log.Write($"Import: Importing {files.Count()} containers");
    TimeSpan startTime = _sw.Elapsed;

    Task<Task<ISerializedAsset?>[]> queueLoadsTask = Util.RunTask(() => files.Select((file) =>
    {
        MemoryMappedFile mapped = MemoryMappedFile.CreateFromFile(file.FullName, FileMode.Open);
        Stream OpenStream(long offset, long length) => mapped.CreateViewStream(offset, length);

        return AssetDatabase.LoadUnityAssetAsync(
            loader: new(file.Name, file.Length, OpenStream),
            importers: [SerializedAssetBundle.Importer]);
    }).ToArray());

    bool done = false;

    while (!done)
    {
        int processed = AssetDatabase.ImportedAssets;
        int skipped = AssetDatabase.ImportedAssetsWarning + AssetDatabase.ImportedAssetsError;
        int pending = AssetDatabase.ImportedAssetsPending;
        Log.Write($"Import: {processed} processed, {skipped} skipped, {pending} pending");

        for (int i = 0; i < 10 && !done; ++i)
        {
            done = queueLoadsTask.IsCompleted && Task.WaitAll(queueLoadsTask.Result, 0);
            Thread.Sleep(_printTime / 10);
        }
    }

    int totalAssets = AssetDatabase.ImportedAssets;
    int totalWarnings = AssetDatabase.ImportedAssetsWarning;
    int totalErrors = AssetDatabase.ImportedAssetsError;
    ConsoleColor color = totalErrors > 0 ? ConsoleColor.Red : totalWarnings > 0 ? ConsoleColor.Yellow : ConsoleColor.White;

    Log.Write(
        new LogEntry($"Import: Loaded {totalAssets} assets in {_sw.Elapsed.Subtract(startTime).TotalSeconds:f2} seconds ("),
        new LogEntry($"{totalWarnings} warnings, {totalErrors} errors", color),
        new LogEntry($")"));

    return [.. queueLoadsTask.Result.Select(x => x.Result).Where(x => x != null) ];
}

void ProcessContainers(ISerializedAsset[] assets)
{
    TimeSpan startTime = _sw.Elapsed;

    IEnumerable<SerializedFile> files = assets
        .OfType<SerializedAssetBundle>()
        .SelectMany(x => x.Assets.Select(y => y.Result))
        .OfType<SerializedFile>();

    int processedCount = 0;
    int totalCount = files.Sum(x => x.ObjectManifests.Length);

    List<ValueTask> streamFlushes = [];

    Task[] readObjectTasks = [.. files.
        Select(x => Util.RunTask(() =>
        {
            string path = Path.Combine(_outputDir, $"{x.Loader.Identifier}.txt");

            using FileStream fs = File.OpenWrite(path);
            using BufferedStream bufferedStream = new(fs);
            using StreamWriter sw = new(bufferedStream);

            try
            {
                x.ReadObjectRange(0, x.ObjectManifests.Length, new SerializedObjectTextExporter(sw, () => { }));
            }
            catch (Exception ex)
            {
                Log.Write(ex.ToString(), ConsoleColor.Red);
            }

            // TODO: perf bottleneck on IO flushes, maybe dispose async?

            Interlocked.Add(ref processedCount, x.ObjectManifests.Length);
        }))];

    bool done = false;

    while (!done)
    {
        Log.Write($"Process: {processedCount} processed, {totalCount - processedCount} to go");

        for (int i = 0; i < 10 && !done; ++i)
        {
            done = Task.WaitAll(readObjectTasks, _printTime / 10);
        }
    }

    Log.Write($"Process: Processed {processedCount} embedded objects in {_sw.Elapsed.Subtract(startTime).TotalSeconds:f2} seconds");
}
