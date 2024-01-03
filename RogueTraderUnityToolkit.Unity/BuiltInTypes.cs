using RogueTraderUnityToolkit.Core;

namespace RogueTraderUnityToolkit.Unity;

public readonly record struct PPtr<T>
{
    public static PPtr<T> Read(EndianBinaryReader reader)
    {
        return default;
    }
}

public readonly record struct RefRegistry<T>
{
    public static RefRegistry<T> Read(EndianBinaryReader reader)
    {
        return default!;
    }
}

public readonly record struct Hash128(
    uint Uint0,
    uint Uint1,
    uint Uint2,
    uint Uint3)
{
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
}

// Wrappers that forward to existing types

public static class Array<T>
{
    public static T[] Read(EndianBinaryReader reader)
    {
        return default!;
    }
}

public static class Map<TKey, TValue> where TKey : notnull
{
    public static Dictionary<TKey, TValue> Read(EndianBinaryReader reader)
    {
        return default!;
    }
}

public static class String
{
    public static AsciiString Read(EndianBinaryReader reader)
    {
        return default;
    }
}
