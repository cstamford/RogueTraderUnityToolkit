using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using System.Reflection;

namespace RogueTraderUnityToolkit.UnityGenerated;

public interface IUnityObject;

public static class GeneratedTypes
{
    static GeneratedTypes()
    {
        // Get all types in the assembly that implement IUnityObject
        foreach (Type type in Assembly.GetExecutingAssembly().GetTypes()
            .Where(t => typeof(IUnityObject).IsAssignableFrom(t))
            .Where(t => t is { IsInterface: false, IsAbstract: false }))
        {
            Hash128 hash = (Hash128)type.GetProperty("Hash", BindingFlags.Public | BindingFlags.Static)!.GetValue(null)!;
            MethodInfo fnReadInfo = type.GetMethod("Read", BindingFlags.Public | BindingFlags.Static)!;
            Func<EndianBinaryReader, IUnityObject> fnRead = (Func<EndianBinaryReader, IUnityObject>)Delegate
                .CreateDelegate(typeof(Func<EndianBinaryReader, IUnityObject>), fnReadInfo);
            _fnReadLookup.Add(hash, fnRead);
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
