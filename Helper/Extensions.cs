using RogueTraderUnityToolkit.Unity;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Linq;

namespace RogueTraderUnityToolkit.Helper;

public static class Extensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte* AsPtr(this Span<byte> span)
    {
        fixed (byte* buf = span)
        {
            return buf;
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static UnmanagedMemoryStream AsStream(this Span<byte> span)
    {
        return new(span.AsPtr(), span.Length);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static UnmanagedMemoryStream AsWriteableStream(this Span<byte> span)
    {
        return new(span.AsPtr(), span.Length, span.Length, FileAccess.ReadWrite);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ParallelQuery<T> AsParallelSafe<T>(this IEnumerable<T> source)
    {
        ParallelQuery<T> query = source.AsParallel().AsOrdered();

        if (Options.ShouldRunSingleThreaded)
        {
            query = query.WithDegreeOfParallelism(1);
        }

        return query;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IEnumerable<int> Indices<T>(this IEnumerable<T> self)
    {
        return self.Select((_, index) => index);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IEnumerable<(T item, int index)> WithIndex<T>(this IEnumerable<T> self)
    {
        return self.Select((item, index) => (item, index));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> self)
    {
        List<T> list = self.ToList();
    
        int n = list.Count;

        while (n-- > 1)
        {
            int k = Random.Shared.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    
        return list;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TaskContinuationOptions DebugFriendly(this TaskContinuationOptions options)
    {
        if (Options.ShouldRunSingleThreaded)
        {
            options |= TaskContinuationOptions.ExecuteSynchronously;
        }

        return options;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void AppendIndent(this StringBuilder sb, int indent)
    {
        for (int i = 0; i < indent; ++i) sb.Append(' ');
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void AppendIndented(this StringBuilder sb, int indent, string line)
    {
        sb.AppendIndent(indent);
        sb.Append(line);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void AppendLineIndented(this StringBuilder sb, int indent, string line)
    {
        sb.AppendIndent(indent);
        sb.AppendLine(line);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Repeat(this char ch, int num) => new(ch, num);

    public static string Dump(this byte[] bytes) => DumpImpl(bytes);
    public static string Dump(this Span<byte> bytes) => DumpImpl(bytes);
    public static string Dump(this ReadOnlySpan<byte> bytes) => bytes.DumpImpl();
    public static string Dump(this EndianBinaryReader reader, int offset = 0, int len = 256) => DumpImpl(reader, offset, len, false);

    public static string DumpFile(this byte[] bytes) => DumpFileImpl(bytes);
    public static string DumpFile(this Span<byte> bytes) => DumpFileImpl(bytes);
    public static string DumpFile(this ReadOnlySpan<byte> bytes) => bytes.DumpFileImpl();
    public static string DumpFile(this EndianBinaryReader reader, int offset = 0, int len = 256) => DumpImpl(reader, offset, len, true);

    public static string DumpImpl(this ReadOnlySpan<byte> bytes)
    {
        StringBuilder sb = new();
        sb.AppendLine(new string([.. bytes.ToArray().Select(x => x > 32 && x < 127 ? (char)x : '?')]));
        sb.AppendLine(string.Join(' ', [.. bytes.ToArray().Select(x => $"0x{x:x}")]));
        return sb.ToString();
    }

    public static string DumpFileImpl(this ReadOnlySpan<byte> bytes)
    {
        string path = Path.GetTempFileName();
        File.WriteAllBytes(path, bytes.ToArray());
        return path;
    }

    private static string DumpImpl(EndianBinaryReader reader, int offset, int len, bool file)
    {
        int start = reader.Position;
        Span<byte> bytes = stackalloc byte[len];

        reader.Seek(offset);
        reader.ReadBytes(bytes);
        reader.Position = start;

        return file ? bytes.DumpFile() : bytes.Dump();
    }
}
