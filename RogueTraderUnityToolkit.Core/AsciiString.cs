using System.Runtime.InteropServices;
using System.Text;

namespace RogueTraderUnityToolkit.Core;

public readonly record struct AsciiString(
    byte BlockIdx,
    byte BlockData,
    ushort BlockOffset,
    int Hash) : IEquatable<string>,
                IEquatable<AsciiString>,
                IComparable<string>,
                IComparable<AsciiString>
{
    public int Length => AsciiStringPool.GetLength(this);
    public ReadOnlyMemory<byte> Bytes => AsciiStringPool.GetBytes(this);

    public static bool operator ==(AsciiString lhs, string? rhs) => Equals(lhs, rhs);
    public static bool operator !=(AsciiString lhs, string? rhs) => !Equals(lhs, rhs);

    public bool Equals(string? rhs) => Equals(this, rhs);
    public bool Equals(AsciiString rhs) => Equals(this, rhs);

    private static bool Equals(AsciiString lhs, AsciiString rhs)
    {
        if (lhs.BlockIdx != rhs.BlockIdx ||
            lhs.BlockData != rhs.BlockData ||
            lhs.BlockOffset != rhs.BlockOffset ||
            lhs.Hash != rhs.Hash)
        {
            // If we're not the same string instance, we still need to run an exhaustive check,
            // because the same string could be added multiple times to the string pool under
            // very heavy contention.
            if (lhs.Length != rhs.Length) return false;

            ReadOnlySpan<byte> lhsSpan = lhs.Bytes.Span;
            ReadOnlySpan<byte> rhsSpan = rhs.Bytes.Span;
            return lhsSpan.SequenceEqual(rhsSpan);

            return false;
        }

        // We refer to the same string from the string pool.
        return true;
    }

    private static unsafe bool Equals(AsciiString lhs, string? rhs)
    {
        if (rhs == null) return false;
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
    public int CompareTo(string? rhs) => string.CompareOrdinal(ToString(), rhs);

    public override int GetHashCode() => Hash;

    public static AsciiString FromMemory(ReadOnlySpan<byte> span) => AsciiStringPool.Fetch(span);
    public static AsciiString FromString(string str) => AsciiStringPool.Fetch(Encoding.ASCII.GetBytes(str).AsSpan());
    public static AsciiString From<T>(T value) where T : notnull => FromString(value.ToString()!);

    public override string ToString() => AsciiStringPool.GetCSharpString(this);
}
