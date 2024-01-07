using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using RogueTraderUnityToolkit.Unity.File;
using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;

List<string> paths = [
    @"C:\Program Files\Unity\Hub\Editor\2022.3.7f1",
    @"C:\Program Files (x86)\Steam\steamapps\common\Warhammer 40,000 Rogue Trader",
];

List<FileInfo> files = [];

foreach (FileInfo info in paths
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

string[] strings =
[
    "MonoBehaviour hash",
    "MonoBehaviour scriptHash"
];

Span<Hash128> hashes = stackalloc Hash128[]
{
    new ("61178B04221A50E2BD25ECD5A9B702D6"),
    new ("5C15E369908E9C75599B2CD4DF6B2CDA")
};

byte[] mem = new byte[hashes.Length * 16];
Span<byte> memSpan = mem.AsSpan(0, hashes.Length * 16);
MemoryMarshal.AsBytes(hashes).CopyTo(memSpan);

(string, ReadOnlyMemory<byte>)[] patterns = strings.Zip(
    Enumerable.Range(0, hashes.Length).Select(i => mem.AsMemory().Slice(i * 16, 16)),
    (s, bytes) => (s, (ReadOnlyMemory<byte>)bytes.ToArray())
).ToArray();

int processedFiles = 0;

Parallel.ForEach(files, fileInfo =>
{
    try
    {
        using MemoryMappedFile file = MemoryMappedFile.CreateFromFile(fileInfo.FullName, FileMode.Open);
        using MemoryMappedViewStream fileStream = file.CreateViewStream();

        foreach ((string name, long offset) in ScanStream(fileStream, patterns))
        {
            Log.Write($"{name} {fileInfo.FullName} + {offset}", ConsoleColor.Green);
        }
    }
    catch { /* ignored */ }
    finally
    {
        int processed = Interlocked.Increment(ref processedFiles);
        if (processed % 10000 == 0)
        {
            Console.WriteLine($"Processed {processed} of {files.Count}");
        }
    }
});

return;

static void ScanSerializedFile(
    SerializedFile file,
    params (string, ReadOnlyMemory<byte>)[] patternsToScan)
{
    using Stream stream = file.Info.Open();

    List<(string, long)> matches = ScanStream(stream, patternsToScan);

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

static List<(string, long)> ScanStream(
    Stream stream,
    params (string, ReadOnlyMemory<byte>)[] patternsToScan)
{
    List<(string, long)> matches = [];

    const int bufferSize = 32768;
    Span<byte> buffer = stackalloc byte[bufferSize];

    while (true)
    {
        int remaining = (int)(stream.Length - stream.Position);
        if (remaining == 0) break;

        int toRead = Math.Min(remaining, bufferSize);
        int bytesRead = stream.Read(buffer[..toRead]);

        foreach ((string name, ReadOnlyMemory<byte> pattern) in patternsToScan)
        {
            int index = 0;
            while (index < bytesRead)
            {
                int indexOf = buffer.Slice(index, bytesRead - index).IndexOf(pattern.Span);
                if (indexOf < 0) break;

                matches.Add((name, stream.Length - remaining + indexOf));
                index += indexOf + pattern.Length;
            }
        }
    }

    return matches;
}
