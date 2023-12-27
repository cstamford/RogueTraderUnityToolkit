using System.Text;

namespace RogueTraderUnityToolkit.Core;

public static class Extensions
{
    public static unsafe byte* AsPtr(this Span<byte> span)
    {
        fixed (byte* buf = span)
        {
            return buf;
        }
    }

    public static unsafe UnmanagedMemoryStream AsStream(this Span<byte> span)
    {
        return new(span.AsPtr(), span.Length);
    }

    public static unsafe UnmanagedMemoryStream AsWriteableStream(this Span<byte> span)
    {
        return new(span.AsPtr(), span.Length, span.Length, FileAccess.ReadWrite);
    }

    public static IEnumerable<int> Indices<T>(this IEnumerable<T> self)
    {
        return self.Select((_, index) => index);
    }

    public static IEnumerable<(T item, int index)> WithIndex<T>(this IEnumerable<T> self)
    {
        return self.Select((item, index) => (item, index));
    }

    public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> self)
    {
        List<T> list = self.ToList();
        int n = list.Count;
        
        while (n-- > 1)
        {
            int k = Random.Shared.Next(n + 1);
            (list[k], list[n]) = (list[n], list[k]);
        }    

        return list;
    }

    public static void AppendIndent(this StringBuilder sb, int indent)
    {
        for (int i = 0; i < indent; ++i) sb.Append(' ');
    }

    public static void AppendIndented(this StringBuilder sb, int indent, string line)
    {
        sb.AppendIndent(indent);
        sb.Append(line);
    }

    public static void AppendLineIndented(this StringBuilder sb, int indent, string line)
    {
        sb.AppendIndent(indent);
        sb.AppendLine(line);
    }

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
        sb.AppendLine(new([.. bytes.ToArray().Select(x => x is > 32 and < 127 ? (char)x : '?')]));
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
        len = Math.Min(reader.Length, len);
        
        int start = reader.Position;
        Span<byte> bytes = stackalloc byte[len];

        reader.Seek(offset);
        reader.ReadBytes(bytes);
        reader.Position = start;

        return file ? bytes.DumpFile() : bytes.Dump();
    }
}
