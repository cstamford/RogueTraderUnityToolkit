using RogueTraderUnityToolkit.Core;

namespace RogueTraderUnityToolkit.UnityStructures;

public interface IUnityType;
public interface IUnityTypeBuiltin : IUnityType;
public interface IUnityTypeGenerated : IUnityType;

public static class TypeResolver
{
    public static Type GetGeneratedType(AsciiString typeName) => _generatedTypes[typeName];

    internal static void RegisterGeneratedType(ReadOnlySpan<byte> typeName, Type type)
    {
        AsciiString typeNameString = AsciiString.From(typeName);

#if DEBUG_VERBOSE
        Log.Write($"Registering generated type {typeNameString} as {type}", ConsoleColor.DarkGray);
#endif

        _generatedTypes.Add(typeNameString, type);
    }

    private static readonly Dictionary<AsciiString, Type> _generatedTypes = [];
}
