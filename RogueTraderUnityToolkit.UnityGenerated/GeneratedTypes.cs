using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using System.Diagnostics;
using System.Reflection;

namespace RogueTraderUnityToolkit.UnityGenerated;

public interface IUnityObject;
public interface IUnityEngineStructure : IUnityObject; // TODO
public interface IUnityGameStructue : IUnityObject; // TODO

public static class GeneratedTypes
{
    static GeneratedTypes()
    {
        // Get all types in the assembly that implement IUnityObject
        foreach (Type type in Assembly.GetExecutingAssembly().GetTypes()
            .Where(t => typeof(IUnityObject).IsAssignableFrom(t))
            .Where(t => t is { IsInterface: false, IsAbstract: false }))
        {
            _fnReadLookup.Add(type.GetHash(), type.GetReadFn<IUnityObject>());
        }
    }

    public static bool TryCreateType(Hash128 hash, EndianBinaryReader reader, out IUnityObject obj)
    {
        if (!_fnReadLookup.TryGetValue(hash, out Func<EndianBinaryReader, IUnityObject>? fnRead))
        {
            obj = default!;
            return false;
        }

        obj = fnRead(reader);
        return true;
    }

    private static readonly Dictionary<Hash128, Func<EndianBinaryReader, IUnityObject>> _fnReadLookup = [];
}

public static class GeneratedTypesExtensions
{
    public static Hash128 GetHash(this Type type)
    {
        Debug.Assert(typeof(IUnityObject).IsAssignableFrom(type));
        return (Hash128)type.GetProperty("Hash", BindingFlags.Public | BindingFlags.Static)!.GetValue(null)!;
    }

    public static Func<EndianBinaryReader, T> GetReadFn<T>(this Type type)
    {
        MethodInfo fnReadInfo = type.GetMethod("Read", BindingFlags.Public | BindingFlags.Static)!;
        return (Func<EndianBinaryReader, T>)Delegate.CreateDelegate(typeof(Func<EndianBinaryReader, T>), fnReadInfo);
    }
}
