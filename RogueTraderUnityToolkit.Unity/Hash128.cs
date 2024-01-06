using RogueTraderUnityToolkit.Core;

namespace RogueTraderUnityToolkit.Unity;

public readonly record struct Hash128(
    uint Uint0,
    uint Uint1,
    uint Uint2,
    uint Uint3)
    : IComparable<Hash128>
{
    public Hash128(string hashString) : this(
        Convert.ToUInt32(hashString[..8], 16),
        Convert.ToUInt32(hashString[8..16], 16),
        Convert.ToUInt32(hashString[16..24], 16),
        Convert.ToUInt32(hashString[24..32], 16)) { }

    public static Hash128 Read(EndianBinaryReader reader)
    {
        uint uint0 = reader.ReadU32();
        uint uint1 = reader.ReadU32();
        uint uint2 = reader.ReadU32();
        uint uint3 = reader.ReadU32();

        return new(
            Uint0: uint0,
            Uint1: uint1,
            Uint2: uint2,
            Uint3: uint3);
    }

    public override string ToString() => $"{Uint0:X8}{Uint1:X8}{Uint2:X8}{Uint3:X8}";

    public int CompareTo(Hash128 other)
    {
        int uint0Comparison = Uint0.CompareTo(other.Uint0);
        if (uint0Comparison != 0) return uint0Comparison;
        int uint1Comparison = Uint1.CompareTo(other.Uint1);
        if (uint1Comparison != 0) return uint1Comparison;
        int uint2Comparison = Uint2.CompareTo(other.Uint2);
        if (uint2Comparison != 0) return uint2Comparison;
        return Uint3.CompareTo(other.Uint3);
    }
}
