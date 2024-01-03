using System.Collections;
using System.Reflection;
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

    public static void Dump(this object? obj, int indentLevel = 0, HashSet<object>? visited = null)
    {
        int curIndent = ++indentLevel;

        if (obj == null)
        {
            Log.Write($"(null)", ConsoleColor.Yellow);
            return;
        }

        if (curIndent >= 16)
        {
            Log.Write($"(max indent reached)", ConsoleColor.Yellow);
            return;
        }

        visited ??= new HashSet<object>(ReferenceEqualityComparer.Instance);

        if (!visited.Add(obj))
        {
            Log.Write($"(circular reference detected)", ConsoleColor.Yellow);
            return;
        }

        Type type = obj.GetType();

        const BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;
        bool primitiveType = type.IsPrimitive || type.IsEnum || (type.IsValueType && type.GetFields(flags).Length == 0);

        Log.Write($"{obj}", primitiveType ? ConsoleColor.DarkCyan : ConsoleColor.DarkBlue);

        if (primitiveType) return;

        const bool dumpEnumerable = true;
        const bool dumpFields = true;

        if (dumpEnumerable && obj is IEnumerable enumerable and not string)
        {
            const int max = 50;
            int i = 0;

            foreach (object? item in enumerable)
            {
                Log.WriteSingle($"IEnumerable {type.Name} ", ConsoleColor.DarkGray);
                Log.Write($"[{i}]", ConsoleColor.DarkGreen);

                Dump(item, indentLevel, visited);

                if (++i == max)
                {
                    Log.Write($"(terminated enumerable early)", ConsoleColor.Yellow);
                    break;
                }
            }

            return;
        }

        if (dumpFields)
        {
            FieldInfo[] fields = type.GetFields(flags).ToArray();
            foreach (FieldInfo field in fields)
            {
                object fieldValue = field.GetValue(obj)!;
                Log.WriteSingle(curIndent, []);
                Log.WriteSingle(field.FieldType.Name, ConsoleColor.DarkMagenta);
                Log.WriteSingle($" {field.Name}: ", ConsoleColor.DarkGray);
                Dump(fieldValue, indentLevel, visited);
            }
        }
    }
}
