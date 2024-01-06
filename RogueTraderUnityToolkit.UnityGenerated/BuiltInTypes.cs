using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity.TypeTree;
using System.Diagnostics;
using System.Reflection;

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
        Debug.Assert(stringLen <= reader.Remaining);
        return reader.ReadString(stringLen);
    }
}

public static class BuiltInArray<T>
{
    static BuiltInArray()
    {
        if (typeof(T).IsArray) // Nested array type
        {
            Type elementType = typeof(T).GetElementType()!;
            Type genericClass = typeof(BuiltInArray<>).MakeGenericType(elementType);
            MethodInfo methodInfo = genericClass.GetMethod("Read", BindingFlags.Public | BindingFlags.Static)!;
            Type delegateType = typeof(TypeReader.ReadFunc<>).MakeGenericType(typeof(T));
            Delegate readFunc = Delegate.CreateDelegate(delegateType, methodInfo);
            _fnRead = (TypeReader.ReadFunc<T>)readFunc;
        }
        else
        {
            _fnRead = TypeReaderHolder<T>.FnRead;
        }
    }

    public static T[] Read(EndianBinaryReader reader)
    {
        int arrayLen = reader.ReadS32();
        Debug.Assert(arrayLen >= 0);

        T[] array = new T[arrayLen];

        for (int i = 0; i < arrayLen; ++i)
        {
            array[i] = _fnRead(reader);
        }

        return array;
    }

    private static TypeReader.ReadFunc<T> _fnRead;
}


public static class BuiltInMap<TKey, TValue> where TKey : notnull
{
    public static Dictionary<TKey, TValue> Read(EndianBinaryReader reader)
    {
        int dictLen = reader.ReadS32();
        Debug.Assert(dictLen >= 0);

        Dictionary<TKey, TValue> dict = new();

        for (int i = 0; i < dictLen; ++i)
        {
            TKey key = _fnReadKey(reader);
            TValue value = _fnReadValue(reader);

            if (!dict.TryAdd(key, value))
            {
#if DEBUG_VERBOSE
                Log.Write($"Dict had duplicate key {key}. Naughty data! Using the most recent one.", ConsoleColor.Yellow);
#endif

                dict[key] = value;
            }
        }

        return dict;
    }

    private static TypeReader.ReadFunc<TKey> _fnReadKey = TypeReaderHolder<TKey>.FnRead;
    private static TypeReader.ReadFunc<TValue> _fnReadValue = TypeReaderHolder<TValue>.FnRead;
}

public static class TypeReader
{
    public delegate T ReadFunc<out T>(EndianBinaryReader reader);
}

public static class TypeReaderHolder<T>
{
    public static TypeReader.ReadFunc<T> FnRead = typeof(T) switch
    {
        { } t when t == typeof(ulong) => (TypeReader.ReadFunc<T>)(object)TypeReaderPrimitive.ReadU64,
        { } t when t == typeof(uint) => (TypeReader.ReadFunc<T>)(object)TypeReaderPrimitive.ReadU32,
        { } t when t == typeof(ushort) => (TypeReader.ReadFunc<T>)(object)TypeReaderPrimitive.ReadU16,
        { } t when t == typeof(byte) => (TypeReader.ReadFunc<T>)(object)TypeReaderPrimitive.ReadU8,
        { } t when t == typeof(long) => (TypeReader.ReadFunc<T>)(object)TypeReaderPrimitive.ReadS64,
        { } t when t == typeof(int) => (TypeReader.ReadFunc<T>)(object)TypeReaderPrimitive.ReadS32,
        { } t when t == typeof(short) => (TypeReader.ReadFunc<T>)(object)TypeReaderPrimitive.ReadS16,
        { } t when t == typeof(sbyte) => (TypeReader.ReadFunc<T>)(object)TypeReaderPrimitive.ReadS8,
        { } t when t == typeof(double) => (TypeReader.ReadFunc<T>)(object)TypeReaderPrimitive.ReadF64,
        { } t when t == typeof(float) => (TypeReader.ReadFunc<T>)(object)TypeReaderPrimitive.ReadF32,
        { } t when t == typeof(bool) => (TypeReader.ReadFunc<T>)(object)TypeReaderPrimitive.ReadBool,
        { } t when t == typeof(char) => (TypeReader.ReadFunc<T>)(object)TypeReaderPrimitive.ReadChar,
        { } t when t == typeof(AsciiString) => (TypeReader.ReadFunc<T>)(object)TypeReaderPrimitive.ReadString,
        _ => (TypeReader.ReadFunc<T>)(object)TypeReaderCodegenned<T>.ReadComplex
    };
}

public static class TypeReaderPrimitive
{
    public static readonly TypeReader.ReadFunc<ulong> ReadU64 = r => r.ReadU64();
    public static readonly TypeReader.ReadFunc<uint> ReadU32 = r => r.ReadU32();
    public static readonly TypeReader.ReadFunc<ushort> ReadU16 = r => r.ReadU16();
    public static readonly TypeReader.ReadFunc<byte> ReadU8 = r => r.ReadU8();
    public static readonly TypeReader.ReadFunc<long> ReadS64 = r => r.ReadS64();
    public static readonly TypeReader.ReadFunc<int> ReadS32 = r => r.ReadS32();
    public static readonly TypeReader.ReadFunc<short> ReadS16 = r => r.ReadS16();
    public static readonly TypeReader.ReadFunc<sbyte> ReadS8 = r => r.ReadS8();
    public static readonly TypeReader.ReadFunc<double> ReadF64 = r => r.ReadF64();
    public static readonly TypeReader.ReadFunc<float> ReadF32 = r => r.ReadF32();
    public static readonly TypeReader.ReadFunc<bool> ReadBool = r => r.ReadBool();
    public static readonly TypeReader.ReadFunc<char> ReadChar = r => r.ReadChar();

    public static readonly TypeReader.ReadFunc<AsciiString> ReadString = r =>
    {
        AsciiString str = BuiltInString.Read(r);
        r.AlignTo(4);
        return str;
    };
}

public static class TypeReaderCodegenned<T>
{
    public static TypeReader.ReadFunc<T> ReadComplex => r =>
    {
        T ret = _fn(r);
        r.AlignTo(4);
        return ret;
    };

    private static Func<EndianBinaryReader, T> _fn = typeof(T).GetReadFunc<T>();
}
