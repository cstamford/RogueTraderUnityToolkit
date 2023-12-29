using CsvHelper;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Security.Cryptography;

if (args.Length == 0)
{
    Console.WriteLine("Please provide the path to the RogueTraderUnityToolkit executable.");
    return;
}

const int runCount = 4;

string executablePath = args[0];
string executableArgs = string.Join(" ", args[1..].Select(x => $"\"{x}\""));
string executableHash = CalculateMd5(executablePath);
string outputDataPath = "historical.csv";

ProcessStartInfo executablePsi = new()
{
    FileName = executablePath,
    Arguments = executableArgs,
    UseShellExecute = false,
    RedirectStandardOutput = true,
    CreateNoWindow = true
};

Console.WriteLine($"executablePath: {executablePath}");
Console.WriteLine($"executableArgs: {executableArgs}");
Console.WriteLine($"executableHash: {executableHash}");
Console.WriteLine($"outputDataPath: {outputDataPath}");
Console.WriteLine();
Console.WriteLine($"runCount: {runCount}");
Console.WriteLine();

DateTime startTime = DateTime.UtcNow;
BenchmarkRecordEntry[] currentRunEntries = new BenchmarkRecordEntry[runCount];

for (int i = 0; i < runCount + 1; i++)
{
    Console.Write($"Run {i}...");

    Stopwatch sw = Stopwatch.StartNew();
    RunOne();
    sw.Stop();

    BenchmarkRecordEntry entry = new(sw.Elapsed.TotalSeconds);
    Console.WriteLine($"{entry.RunTime:F2} s");

    if (i == 0)
    {
        Console.WriteLine($" (cold discard)");
        continue;
    }

    currentRunEntries[i - 1] = new(sw.Elapsed.TotalSeconds);
}

WriteRecord(outputDataPath, startTime, executableHash, currentRunEntries);

double min = currentRunEntries.Min(x => x.RunTime);
double max = currentRunEntries.Max(x => x.RunTime);
double avg = currentRunEntries.Average(x => x.RunTime);
double sumOfSquaresOfDifferences = currentRunEntries
    .Select(val => (val.RunTime - avg) * (val.RunTime - avg))
    .Sum();
double sd = Math.Sqrt(sumOfSquaresOfDifferences / currentRunEntries.Length);

Console.WriteLine();
Console.WriteLine($"min: {min:F2}, max: {max:F2}, avg: {avg:F2}, sd: {sd:F6}");

List<BenchmarkRecord> historicalData = ReadRecords(outputDataPath);
historicalData.RemoveAt(historicalData.Count - 1); // remove last, since we just wrote it
PlotBenchmarkData(currentRunEntries, historicalData);

return;



void RunOne() => Process.Start(executablePsi)!.WaitForExit();

static void WriteRecord(
    string csvPath,
    DateTime startTime, 
    string executableHash, 
    BenchmarkRecordEntry[] entries)
{
    bool fileExists = File.Exists(csvPath);

    using FileStream fs = File.Open(csvPath, FileMode.Append);
    using StreamWriter writer = new(fs);
    using CsvWriter csv = new(writer, CultureInfo.InvariantCulture);

    if (!fileExists)
    {
        csv.WriteHeader<BenchmarkRecordCsv>();
        csv.NextRecord();
    }

    csv.WriteRecord(new BenchmarkRecordCsv(null, startTime, executableHash, entries.Length));
    csv.NextRecord();

    foreach (BenchmarkRecordEntry entry in entries)
    {
        csv.WriteRecord(new BenchmarkRecordCsv($"{entry.RunTime:F2}", null, null, null));
        csv.NextRecord();
    }
}

static List<BenchmarkRecord> ReadRecords(string csvPath)
{
    using FileStream readFs = new(csvPath, FileMode.Open, FileAccess.Read, FileShare.Read);
    using StreamReader reader = new(readFs);
    using CsvReader csv = new(reader, CultureInfo.InvariantCulture);

    List<BenchmarkRecordCsv> records = csv.GetRecords<BenchmarkRecordCsv>().ToList();
    List<int> recordIndices = [];

    for (int i = 0; i < records.Count; ++i)
    {
        Debug.Assert(records[i].StartTime.HasValue);
        recordIndices.Add(i);
        i += records[i].RunCount!.Value;
    }

    List<BenchmarkRecord> recordReturns = [];
    recordReturns.AddRange(from header in recordIndices 
        let start = header + 1 
        let end = start + records[header].RunCount!.Value 
        select new BenchmarkRecord(
            records[header].StartTime!.Value,
            records[header].ExecutableHash!,
            records[start..end]
                .Select(x => new BenchmarkRecordEntry(Convert.ToDouble(x.Entry))).ToArray()));

    return recordReturns;
}

static string CalculateMd5(string filePath)
{
    using MD5 md5 = MD5.Create();
    using FileStream stream = File.OpenRead(filePath);
    byte[] hash = md5.ComputeHash(stream);
    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
}

static void PlotBenchmarkData(
    BenchmarkRecordEntry[] currentEntries,
    List<BenchmarkRecord> historicalEntries)
{
    ScottPlot.Plot plt = new(600, 400);

    // Plot current run
    double[] currentRunTimes = currentEntries.Select(x => x.RunTime).ToArray();
    plt.AddScatter(Enumerable.Range(1, currentEntries.Length).Select(x => (double)x).ToArray(),
        currentRunTimes, label: "Current Run", color: Color.Blue);

    if (historicalEntries.Count > 0)
    {
        // Run with the lowest average time
        BenchmarkRecord lowestEntry = historicalEntries.OrderBy(e => e.Entries.Average(entry => entry.RunTime)).First();
        PlotHistoricalRun(lowestEntry, "Lowest Avg Time", plt, Color.FromArgb(96, Color.Green));

        // Run with the highest average time
        BenchmarkRecord highestEntry = historicalEntries.OrderBy(e => e.Entries.Average(entry => entry.RunTime)).Last();
        if (lowestEntry != highestEntry)
        {
            PlotHistoricalRun(highestEntry, "Highest Avg Time", plt, Color.FromArgb(96, Color.Red));
        }

        // Heuristic 3: Runs within the last month
        DateTime dateRange = DateTime.UtcNow.AddMonths(-1);

        foreach (BenchmarkRecord run in historicalEntries
            .Where(e => e.StartTime >= dateRange)
            .Where(e => e != lowestEntry && e != highestEntry)
            .OrderByDescending(e => e.StartTime)
            .Take(5))
        {
            PlotHistoricalRun(run, $"Run {run.StartTime:MM-dd-HH-mm}", plt, Color.FromArgb(32, Color.Black));
        }

        plt.Title("Benchmark Performance Over Runs");
        plt.XLabel("Run Number");
        plt.YLabel("Run Time (s)");
        plt.Legend();
    }

    string filePath = Path.Combine(Path.GetTempPath(), "BenchmarkPlot.png");
    plt.SaveFig(filePath);
    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true })!.WaitForExit();
    File.Delete(filePath);
}

static void PlotHistoricalRun(BenchmarkRecord run, string label, ScottPlot.Plot plt, Color color)
{
    double[] runTimes = run.Entries.Select(x => x.RunTime).ToArray();
    plt.AddScatter(Enumerable.Range(1, run.Entries.Length).Select(x => (double)x).ToArray(),
        runTimes, label: label, color: color);
}

record struct BenchmarkRecordEntry(
    double RunTime);

record struct BenchmarkRecord(
    DateTime StartTime,
    string ExecutableHash,
    BenchmarkRecordEntry[] Entries);

record struct BenchmarkRecordCsv(
    string? Entry,
    DateTime? StartTime,
    string? ExecutableHash,
    int? RunCount);
    