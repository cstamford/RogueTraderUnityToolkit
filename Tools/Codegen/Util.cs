using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity.File;

namespace Codegen;

public static class Util
{
    static void MemoryScanSerializedFile(
        SerializedFile file,
        params (string, ReadOnlyMemory<byte>)[] patternsToScan)
    {
        using Stream stream = file.Info.Open();

        List<(string, long)> matches = [];

        const int bufferSize = 32768;
        Span<byte> buffer = stackalloc byte[bufferSize];

        while (true)
        {
            buffer = buffer[..Math.Min((int)(stream.Length - stream.Position), bufferSize)];
            if (buffer.Length == 0) break;

            int bytesRead = stream.Read(buffer);

            foreach ((string name, ReadOnlyMemory<byte> pattern) in patternsToScan)
            {
                int index = 0;
                while (index < bytesRead)
                {
                    int indexOf = buffer.Slice(index, bytesRead - index).IndexOf(pattern.Span);
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
}
