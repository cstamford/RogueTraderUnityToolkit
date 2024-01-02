using RogueTraderUnityToolkit.Core;

namespace RogueTraderUnityToolkit.Unity.TypeTree;

public readonly record struct ObjectParserPPtr(AsciiString TypeName);
public readonly record struct ObjectParserVector(AsciiString VectorTypeName);
public readonly record struct ObjectParserMap(ObjectParserPair PairType);
public readonly record struct ObjectParserPair(AsciiString KeyTypeName, AsciiString ValueTypeName);
