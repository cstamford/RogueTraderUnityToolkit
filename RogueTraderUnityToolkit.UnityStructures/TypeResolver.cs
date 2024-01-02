using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity.TypeTree;

namespace RogueTraderUnityToolkit.Unity;

public interface IUnityType;
public interface IUnityTypeBuiltin : IUnityType;
public interface IUnityTypeGenerated : IUnityType;

public static class TypeResolver
{
    public static Type Get(ObjectParserType type, AsciiString typeName) => type switch
    {
        ObjectParserType.U64 => typeof(ulong),
        ObjectParserType.U32 => typeof(uint),
        ObjectParserType.U16 => typeof(ushort),
        ObjectParserType.U8 => typeof(byte),
        ObjectParserType.S64 => typeof(long),
        ObjectParserType.S32 => typeof(int),
        ObjectParserType.S16 => typeof(short),
        ObjectParserType.S8 => typeof(uint),
        ObjectParserType.F64 => typeof(double),
        ObjectParserType.F32 => typeof(float),
        ObjectParserType.Bool => typeof(bool),
        ObjectParserType.Char => typeof(char),

        ObjectParserType.Complex => GetGeneratedType(typeName),

        //ObjectParserType.PPTr => typeof(object), /* TODO */
        //ObjectParserType.String => typeof(object), /* TODO */
        //ObjectParserType.Vector => typeof(object), /* TODO */
        //ObjectParserType.Map => typeof(object), /* TODO */
        //ObjectParserType.Pair => typeof(object), /* TODO */

        _ => throw new()
    };

    public static Type GetGeneratedType(AsciiString typeName) => _generatedTypes[typeName];

    internal static void RegisterGeneratedType(ReadOnlySpan<byte> typeName, Type type)
    {
        AsciiString typeNameString = AsciiStringPool.Fetch(typeName);

#if DEBUG_VERBOSE
        Log.Write($"Registering generated type {typeNameString} as {type}", ConsoleColor.DarkGray);
#endif

        _generatedTypes.Add(typeNameString, type);
    }

    private static Dictionary<AsciiString, Type> _generatedTypes = [];
}
