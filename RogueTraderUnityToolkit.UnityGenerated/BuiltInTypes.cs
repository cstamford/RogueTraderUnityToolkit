using RogueTraderUnityToolkit.Core;
using System.Diagnostics;

namespace RogueTraderUnityToolkit.UnityGenerated;

public readonly record struct PPtr<T>
{
    public static PPtr<T> Read(EndianBinaryReader reader)
    {
        return default;
    }
}

public readonly record struct RefRegistry
{
    public static RefRegistry Read(EndianBinaryReader reader)
    {
        return default!;
    }
}

// Wrappers that forward to existing types

public static class BuiltInString
{
    public static AsciiString Read(EndianBinaryReader reader)
    {
        int stringLen = reader.ReadS32();
        Debug.Assert(stringLen >= 0);
        return reader.ReadString(stringLen);
    }
}

public static class BuiltInArray<T>
{
    public static T[] Read(EndianBinaryReader reader)
    {
        return default!;
    }
}

public static class BuiltInMap<TKey, TValue> where TKey : notnull
{
    public static Dictionary<TKey, TValue> Read(EndianBinaryReader reader)
    {
        return default!;
    }
}
