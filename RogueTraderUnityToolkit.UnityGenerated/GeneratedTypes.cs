using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using System.Reflection;

namespace RogueTraderUnityToolkit.UnityGenerated;

public interface IUnityObject;
public interface IUnityStructure : IUnityObject;
public interface IUnityRootStructure : IUnityStructure;
public interface IUnityEngineStructure : IUnityRootStructure;
public interface IUnityGameStructure : IUnityRootStructure;

public static class GeneratedTypes
{
    public static ThreadLocal<bool> WithByteArrays { get; } = new(() => throw new());

    static GeneratedTypes()
    {
        foreach (Type type in Assembly.GetExecutingAssembly().GetTypes()
            .Where(t => typeof(IUnityRootStructure).IsAssignableFrom(t))
            .Where(t => t is { IsInterface: false, IsAbstract: false }))
        {
            Func<EndianBinaryReader, IUnityObject> readFn = type.GetReadFunc<IUnityObject>();

            try
            {
                _fnReadHashLookup.Add(type.GetHash(), readFn);
                _fnReadObjectTypeLookup.TryAdd(type.GetObjectType(), readFn); // only add the first one
            }
            catch (Exception e)
            {
                // TODO: very probably it's a double type with the same fields but different alignment flags
                Log.Write($"When constructing {type}: {e.Message}", ConsoleColor.Yellow);
            }
        }
    }

    public static bool TryCreateType(Hash128 hash, UnityObjectType type, EndianBinaryReader reader, out IUnityObject obj, bool withByteArrays = true)
    {
        WithByteArrays.Value = withByteArrays;
        return TryCreateTypeInternal(hash, type, reader, out obj);
    }

    private static readonly Dictionary<Hash128, Func<EndianBinaryReader, IUnityObject>> _fnReadHashLookup = [];
    private static readonly Dictionary<UnityObjectType, Func<EndianBinaryReader, IUnityObject>> _fnReadObjectTypeLookup = [];

    private static bool TryCreateTypeInternal(Hash128 hash, UnityObjectType type, EndianBinaryReader reader, out IUnityObject obj)
    {
        if (_fnReadHashLookup.TryGetValue(hash, out Func<EndianBinaryReader, IUnityObject>? fnRead))
        {
            obj = fnRead(reader);
            return true;
        }

        if (_fnReadObjectTypeLookup.TryGetValue(type, out fnRead))
        {
            obj = fnRead(reader);
            return true;
        }

        obj = default!;
        return false;
    }
}

public static class GeneratedTypesExtensions
{
    public static UnityObjectType GetObjectType(this Type type) =>
        (UnityObjectType)type.GetProperty("ObjectType", BindingFlags.Public | BindingFlags.Static)!.GetValue(null)!;

    public static Hash128 GetHash(this Type type) =>
        (Hash128)type.GetProperty("Hash", BindingFlags.Public | BindingFlags.Static)!.GetValue(null)!;

    public static Func<EndianBinaryReader, T> GetReadFunc<T>(this Type type) => (Func<EndianBinaryReader, T>)
        Delegate.CreateDelegate(typeof(Func<EndianBinaryReader, T>), type.GetMethod("Read", BindingFlags.Public | BindingFlags.Static)!);
}
