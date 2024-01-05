using RogueTraderUnityToolkit.Core;
using System.Diagnostics;

namespace RogueTraderUnityToolkit.UnityGenerated;

public readonly record struct PPtr<T>(int FileId, long PathId)
{
    public static PPtr<T> Read(EndianBinaryReader reader)
    {
        int fileId = reader.ReadS32();
        long pathId = reader.ReadS64();
        return new(fileId, pathId);
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
        int arrayLen = reader.ReadS32();
        Debug.Assert(arrayLen >= 0);

        // TODO: Switch on primitive!

        T[] array = new T[arrayLen];

        for (int i = 0; i < arrayLen; ++i)
        {
            array[i] = (T)_readFn(reader);
        }

        return array;
    }

    private static Func<EndianBinaryReader, T> _readFn = typeof(T).GetReadFn<T>();
}

public static class BuiltInMap<TKey, TValue> where TKey : notnull
{
    public static Dictionary<TKey, TValue> Read(EndianBinaryReader reader)
    {
        return default!;
    }
}
