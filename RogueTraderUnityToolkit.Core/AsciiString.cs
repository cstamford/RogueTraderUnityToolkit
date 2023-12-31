using System.Runtime.InteropServices;
using System.Text;

namespace RogueTraderUnityToolkit.Core;

public readonly record struct AsciiString(
    byte BlockIdx,
    byte BlockData,
    ushort BlockOffset)
    : IEquatable<string>, IComparable<AsciiString>
{
    public int Length => AsciiStringPool.GetLength(this);
    public ReadOnlyMemory<byte> Bytes => AsciiStringPool.GetBytes(this);

    public static bool operator ==(AsciiString asciiString, string? str) => Equals(asciiString, str);
    public static bool operator !=(AsciiString asciiString, string? str) => !Equals(asciiString, str);
    public bool Equals(string? str) => Equals(this, str);
    
    private static unsafe bool Equals(AsciiString lhs, string? rhs)
    {
        if (string.IsNullOrEmpty(rhs)) return false;
        if (lhs.Length != rhs.Length) return false;

        fixed (char* rhsPtr = rhs)
        {
            ReadOnlySpan<byte> lhsSpan = lhs.Bytes.Span;
            ReadOnlySpan<byte> rhsSpan = MemoryMarshal.AsBytes(new ReadOnlySpan<char>(rhsPtr, rhs.Length));
            
            for (int i = 0; i < lhsSpan.Length; i++)
            {
                byte l = lhsSpan[i]; // ascii
                byte r = rhsSpan[i * 2]; // utf16
                if (l != r) return false;
            }

            return true;
        }
    }

    public int CompareTo(AsciiString rhs) => Bytes.Span.SequenceCompareTo(rhs.Bytes.Span);

    public static AsciiString FromMemory(ReadOnlyMemory<byte> memory) => AsciiStringPool.Fetch(memory);
    public static AsciiString FromString(string str) => AsciiStringPool.Fetch(Encoding.ASCII.GetBytes(str));
    public static AsciiString From<T>(T value) where T : notnull => FromString(value.ToString()!);

    public override string ToString() => AsciiStringPool.GetCSharpString(this);
}
