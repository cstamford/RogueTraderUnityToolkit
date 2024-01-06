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
    "PlayerSettings",
    "InputManager",
    "TagManager",
    "AudioManager",
    "ScriptMapper",
    "MonoManager",
    "GraphicsSettings",
    "TimeManager",
    "DelayedCallManager",
    "PhysicsManager",
    "BuildSettings",
    "QualitySettings",
    "ResourceManager",
    "NavMeshProjectSettings",
    "Physics2DSettings",
    "RuntimeInitializeOnLoadManager",
    "UnityConnectSettings",
    "StreamingManager",
    "VFXManager"
];

Span<Hash128> hashes = stackalloc Hash128[]
{
    new ("D2D3AF88ADFC2C6F3B5555C4959F094D"),
    new ("5C032E59D903C25FDBBAEEBB188794C7"),
    new ("D197953D3F842B5B278066ECEA0DDD84"),
    new ("9D77426282A6018654F7E310EE504546"),
    new ("D2317756261AD8084667018EC046CDDB"),
    new ("36707914DD4807B86B739B75E1174D9B"),
    new ("7E5F623B5483022F45905339A4042992"),
    new ("6523D3A3355A156FCD8279F091C11238"),
    new ("86113E640E726E7D7E104AE8BD4446B8"),
    new ("C99F640154DD6EB9FF6CD5EFD89BF79B"),
    new ("0CDC11E1487707EEAF408BB90FBC06C0"),
    new ("B9C38D273E2ADE0D7B47E754AA071146"),
    new ("0E889D0DC7337F079BC9C26F0AA529D6"),
    new ("F4C2943F0E5F89DAEF4DE9B5F5F3573E"),
    new ("367DF3D0A75E97FC985A7D933391DAFB"),
    new ("55A238E3B50102465496FEF531BB8543"),
    new ("D20A19A1F2AA3CE4E4364300D0BBE1BB"),
    new ("80963267FB7DBA9219B0A0A8DDAA3DDF"),
    new ("6BB91ED030F54C04B25E68474082794A")
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
    catch (Exception e)
    {
        Log.Write($"Failed {fileInfo.FullName}", ConsoleColor.Red);
    }
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
