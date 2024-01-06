using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace RogueTraderUnityToolkit.UnityGenerated;

public interface IUnityObject;
public interface IUnityStructure : IUnityObject;
public interface IUnityRootStructure : IUnityStructure;
public interface IUnityEngineStructure : IUnityRootStructure;
public interface IUnityGameStructure : IUnityRootStructure;

public static class GeneratedTypes
{
    static GeneratedTypes()
    {
        foreach (Type type in Assembly.GetExecutingAssembly().GetTypes()
            .Where(t => typeof(IUnityRootStructure).IsAssignableFrom(t))
            .Where(t => t is { IsInterface: false, IsAbstract: false }))
        {
            _fnReadLookup.Add(type.GetHash(), type.GetReadFunc<IUnityObject>());
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
    public static Hash128 GetHash(this Type type) =>
        (Hash128)type.GetProperty("Hash", BindingFlags.Public | BindingFlags.Static)!.GetValue(null)!;

    public static Func<EndianBinaryReader, T> GetReadFunc<T>(this Type type) => (Func<EndianBinaryReader, T>)
        Delegate.CreateDelegate(typeof(Func<EndianBinaryReader, T>), type.GetMethod("Read", BindingFlags.Public | BindingFlags.Static));

}
