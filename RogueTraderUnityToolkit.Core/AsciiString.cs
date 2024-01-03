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
    public ReadOnlySpan<byte> Bytes => Memory.Span;
    public ReadOnlyMemory<byte> Memory => AsciiStringPool.GetBytes(this);

    public char this[int idx] => (char)Bytes[idx];

    public AsciiString Slice(int offset) => AsciiStringPool.Slice(this, offset, Length - offset);
    public AsciiString Slice(int offset, int length) => AsciiStringPool.Slice(this, offset, length);

    public bool StartsWith(byte rhs) => Length > 0 && Bytes[0] == rhs;
    public bool StartsWith(char rhs) => StartsWith((byte)rhs);
    public bool StartsWith(AsciiString rhs) => rhs.Length <= Length && Bytes[..rhs.Length].SequenceEqual(rhs.Bytes);
    public bool StartsWith(string rhs)
    {
        if (rhs.Length > Length) return false;

        ReadOnlySpan<byte> lhsSpan = Bytes;
        ReadOnlySpan<char> rhsSpan = rhs.AsSpan();

        for (int i = 0; i < rhsSpan.Length; ++i)
        {
            if (lhsSpan[i] != rhsSpan[i]) return false;
        }

        return true;
    }

    public bool EndsWith(byte rhs) => Length > 0 && Bytes[^1] == rhs;
    public bool EndsWith(char rhs) => EndsWith((byte)rhs);
    public bool EndsWith(AsciiString rhs) => rhs.Length <= Length && Bytes[(Length - rhs.Length)..].SequenceEqual(rhs.Bytes);
    public bool EndsWith(string rhs)
    {
        if (rhs.Length > Length) return false;

        ReadOnlySpan<byte> lhsSpan = Bytes[(Length - rhs.Length)..];
        ReadOnlySpan<char> rhsSpan = rhs.AsSpan();

        for (int i = 0; i < rhsSpan.Length; ++i)
        {
            if (lhsSpan[i] != rhsSpan[i]) return false;
        }

        return true;
    }

    public bool Contains(byte rhs) => Bytes.Contains(rhs);
    public bool Contains(char rhs) => rhs < 0x7F && Bytes.Contains((byte)rhs);

    public int CompareTo(AsciiString rhs) => Bytes.SequenceCompareTo(rhs.Bytes);
    public int CompareTo(string? rhs) => string.CompareOrdinal(ToString(), rhs);

    public override int GetHashCode() => Hash;

    public static AsciiString From(ReadOnlySpan<byte> span) => AsciiStringPool.Fetch(span);
    public static AsciiString From(string str) => AsciiStringPool.Fetch(Encoding.ASCII.GetBytes(str).AsSpan());

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
            // because the same string could be added multiple times to the string pool under contention.
            if (lhs.Length != rhs.Length) return false;

            ReadOnlySpan<byte> lhsSpan = lhs.Bytes;
            ReadOnlySpan<byte> rhsSpan = rhs.Bytes;
            return lhsSpan.SequenceEqual(rhsSpan);
        }

        // We refer to the same string from the string pool.
        return true;
    }

    private static bool Equals(AsciiString lhs, string? rhs)
    {
        if (rhs == null) return false;
        if (lhs.Length != rhs.Length) return false;

        ReadOnlySpan<byte> lhsSpan = lhs.Bytes[(lhs.Length - rhs.Length)..];
        ReadOnlySpan<char> rhsSpan = rhs.AsSpan();

        for (int i = 0; i < lhsSpan.Length; ++i)
        {
            byte l = lhsSpan[i]; // ascii
            char r = rhsSpan[i]; // utf16
            if (l != r) return false;
        }

        return true;
    }

    public override string ToString() => AsciiStringPool.GetCSharpString(this);
}
