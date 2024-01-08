using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using RogueTraderUnityToolkit.Unity.TypeTree;
using System.Diagnostics;
using System.Reflection;

namespace RogueTraderUnityToolkit.Tree;

public readonly struct TreeBuilderAssembly(
    Dictionary<AsciiString, ObjectParserNode[]> subTrees)
{
    public ObjectTypeTree CreateTypeTreeFromAssembly(
        Assembly assembly,
        AsciiString ns,
        AsciiString cls,
        ObjectParserNode[] baseClass)
    {
        Log.Write($"{ns} {cls}");

        Type? type = assembly.GetType($"{ns}.{cls}") ?? assembly.GetType($"{ns}+{cls}");
        Debug.Assert(type != null);

        List<ObjectParserNode> allNodes = [ .. baseClass];
        MakeNodesForTypeChildren(allNodes, type, 1);

        Span<byte> allLevels = stackalloc byte[allNodes.Count];

        for (int i = 0; i < allNodes.Count; ++i)
        {
            allLevels[i] = allNodes[i].Level;
        }

        for (int i = 0; i < allNodes.Count; ++i)
        {
            ObjectParserNodeUtil.ResolveHierarchy(i,
                allNodes[i].Level,
                allLevels,
                out ushort firstChildIdx,
                out ushort firstSiblingIdx);

            allNodes[i] = allNodes[i] with { FirstChildIdx = firstChildIdx, FirstSiblingIdx = firstSiblingIdx };
        }

        ObjectTypeTree tree = new([.. allNodes]);

        Debug.Assert(allNodes.Select((_, i) => i).All(i => tree[i].Index == i), "Node indices were incorrect");
        Debug.Assert(allNodes.All(x => !x.IsPrimitive || x.Type != ObjectParserType.Complex), "Complex primitive?");
        Debug.Assert(allNodes.Zip(allNodes.Skip(1), (prev, cur) => cur.Level - prev.Level <= 1).All(x => x), "Gaps in levels?");

        return tree;
    }

    private void MakeNodesForType(
        List<ObjectParserNode> nodes,
        AsciiString name,
        Type type,
        byte level,
        Type? nextType = null)
    {
        if (type.IsEnum) type = type.GetEnumUnderlyingType();

        CheckType(type, out bool isString, out bool isArray, out bool isMap);

        ObjectParserType parserType = GetParserType(type);
        ObjectParserNodeFlags parserFlags = ObjectParserNodeFlags.None;

        // Size: Based on our type. Some nodes have a size defined even if they aren't primitives, but we don't care about that.
        if (parserType.Size() > 0)
        {
            parserFlags |= ObjectParserNodeFlags.HasSize;
        }

        // Alignment: I've seen a bunch of bools back to back with no align, and then one bordering an int with align.
        //            IDK what the actual rules are but this seems to most closely model what Unity does.
        bool alignBecauseNextType = (nextType == null && parserType.Size() < 4) || // no next type (we're exiting a complex type)
                                    (nextType != null && GetParserType(nextType).Size() > parserType.Size()) || // next step is bigger than us
                                    (nextType != null && GetParserType(nextType).Size() == 0 && parserType.Size() < 4); // complex next type

        if (alignBecauseNextType || isArray || isString) parserFlags |= ObjectParserNodeFlags.IsAlignTo4;

        AsciiString typeName = GetTypeName(type, parserType, isString, isArray, isMap);
        nodes.Add(new(name, typeName, parserType, parserFlags, (ushort)nodes.Count, 0xFF, 0xFF, level));

        Debug.Assert(parserType == ObjectParserType.Complex || !isArray);
        Debug.Assert(parserType == ObjectParserType.Complex || !isMap);
        Debug.Assert(parserType == ObjectParserType.Complex || !isString);

        if (isArray)
        {
            Type dataType = type.IsArray ? type.GetElementType()! : type.GetGenericArguments().First();
            CreateArray(nodes, dataType, (byte)(level + 1));
        }
        else if (isMap)
        {
            Debug.Assert(false, "Serialization rules don't allow maps to be serialized!");
            Type[] arguments = type.GetGenericArguments();
            CreateMap(nodes, arguments[0], arguments[1], (byte)(level + 1));
        }
        else if (isString)
        {
            CreateArray(nodes, typeof(char), (byte)(level + 1));
        }
        else if (parserType == ObjectParserType.Complex)
        {
            MakeNodesForTypeChildren(nodes, type, (byte)(level + 1));
        }
    }

    private void MakeNodesForTypeChildren(List<ObjectParserNode> nodes, Type type, byte level)
    {
        FieldInfo[] fields = type.GetFields(_fieldFlags).OrderBy(field => field.MetadataToken).ToArray();

        for (int fieldIdx = 0; fieldIdx < fields.Length; ++fieldIdx)
        {
            /*
                Is public, or has a SerializeField attribute
                    isn’t static
                    isn’t const
                    isn’t readonly
                Has a field type that can be serialized:
                    Primitive data types (int, float, double, bool, string, etc.)
                    Enum types (32 bites or smaller)
                    Fixed-size buffers
                    Unity built-in types, for example, Vector2, Vector3, Rect, Matrix4x4, Color, AnimationCurve
                    Custom structs with the Serializable attribute
                    References to objects that derive from UnityEngine.Object
                    Custom classes with the Serializable attribute. (See Serialization of custom classes).
                    An array of a field type mentioned above
                    A List<T> of a field type mentioned above
            */

            FieldInfo f = fields[fieldIdx];

            bool isPublic = (f.IsPublic && (f.Attributes & FieldAttributes.NotSerialized) == 0) ||
                             f.CustomAttributes.Any(x => x.AttributeType.Name.EndsWith("SerializeField"));
            bool isStatic = f.IsStatic;
            bool isConst = f.IsLiteral;
            bool isReadonly = f.IsInitOnly;

            CheckType(f.FieldType, out bool typeIsString, out bool typeIsArray, out bool _);
            bool typeIsPrimitive = f.FieldType.IsPrimitive || typeIsString;
            bool typeIsEnum = f.FieldType.IsEnum && GetParserType(f.FieldType.GetEnumUnderlyingType()).Size() <= 4;
            // TODO: Fixed size buffers?
            bool typeIsEngineType = f.FieldType.Namespace?.Contains("UnityEngine") ?? false;
            bool typeIsSerializableClass = (f.FieldType.Attributes & TypeAttributes.Serializable) != 0;
            bool typeIsReference = f.FieldType.BaseType?.FullName == "UnityEngine.Object";
            bool typeIsArrayOrList = typeIsArray;

            bool fieldPassesRequirements = isPublic && !isStatic && !isConst && !isReadonly;

            bool fieldTypePassesRequirements =
                typeIsPrimitive ||
                typeIsEnum ||
                typeIsEngineType ||
                typeIsSerializableClass ||
                typeIsReference ||
                typeIsArrayOrList;

            if (!fieldPassesRequirements || !fieldTypePassesRequirements) continue;

            Debug.Assert(!f.CustomAttributes.Any(x => x.AttributeType.Name.EndsWith("SerializeReference")),
                "I'm hoping that we don't have to deal with managed references.");

            Debug.Assert(f.FieldType.BaseType?.FullName != "UnityEngine.Object",
                "WIP: PPtr");

            if (typeIsEngineType && subTrees.TryGetValue(AsciiString.From(f.FieldType.Name), out ObjectParserNode[]? subTree))
            {
                nodes.Add(subTree[0] with { Index = (ushort)nodes.Count, Level = level, Name = AsciiString.From(f.Name) });

                for (int i = 1; i < subTree.Length; ++i)
                {
                    int relLevel = subTree[i].Level - subTree[0].Level;
                    Debug.Assert(relLevel >= 1);
                    nodes.Add(subTree[i] with { Index = (ushort)nodes.Count, Level = (byte)(level + relLevel) });
                }
            }
            else
            {
                MakeNodesForType(nodes, AsciiString.From(f.Name), f.FieldType, level,
                    fieldIdx == fields.Length - 1 ? null : fields[fieldIdx + 1].FieldType);
            }
        }
    }

    private static ObjectParserType GetParserType(Type type) => type.FullName switch
    {
        _ when type.FullName == typeof(ulong).FullName => ObjectParserType.U64,
        _ when type.FullName == typeof(uint).FullName => ObjectParserType.U32,
        _ when type.FullName == typeof(ushort).FullName => ObjectParserType.U16,
        _ when type.FullName == typeof(byte).FullName => ObjectParserType.U8,
        _ when type.FullName == typeof(long).FullName => ObjectParserType.S64,
        _ when type.FullName == typeof(int).FullName => ObjectParserType.S32,
        _ when type.FullName == typeof(short).FullName => ObjectParserType.S16,
        _ when type.FullName == typeof(sbyte).FullName => ObjectParserType.S8,
        _ when type.FullName == typeof(double).FullName => ObjectParserType.F64,
        _ when type.FullName == typeof(float).FullName => ObjectParserType.F32,
        _ when type.FullName == typeof(bool).FullName => ObjectParserType.Bool,
        _ when type.FullName == typeof(char).FullName => ObjectParserType.Char,
        _ => ObjectParserType.Complex
    };

    private static void CheckType(Type type, out bool isString, out bool isArray, out bool isMap)
    {
        isString = type.FullName == typeof(string).FullName;
        isArray = type.IsArray || (type.IsGenericType && type.GetGenericTypeDefinition().FullName == typeof(List<>).FullName);
        isMap = type.IsGenericType && type.GetGenericTypeDefinition().FullName == typeof(Dictionary<,>).FullName;
    }

    private static AsciiString GetTypeName(Type type, ObjectParserType parserType, bool isString, bool isArray, bool isMap) =>
        parserType == ObjectParserType.Complex ?
            isString ? AsciiString.From("string") :
            isArray ? AsciiString.From("vector") :
            isMap ? AsciiString.From("map") :
            AsciiString.From(type.Name) :
            ObjectParserNodeUtil.TypeMap[parserType].First();

    private void CreateArray(List<ObjectParserNode> nodes, Type dataType, byte level)
    {
        nodes.Add(new(
            AsciiString.From("Array"),
            AsciiString.From("Array"),
            ObjectParserType.Complex,
            ObjectParserNodeFlags.IsArray | ObjectParserNodeFlags.IsAlignTo4,
            (ushort)nodes.Count, 0, 0, level));

        MakeNodesForType(nodes, AsciiString.From("size"), typeof(int), (byte)(level + 1));
        MakeNodesForType(nodes, AsciiString.From("data"), dataType, (byte)(level + 1));
    }

    private void CreateMap(List<ObjectParserNode> nodes, Type keyType, Type valueType, byte level)
    {
        nodes.Add(new(
            AsciiString.From("Array"),
            AsciiString.From("Array"),
            ObjectParserType.Complex,
            ObjectParserNodeFlags.IsArray | ObjectParserNodeFlags.IsAlignTo4,
            (ushort)nodes.Count, 0, 0, level));

        MakeNodesForType(nodes, AsciiString.From("size"), typeof(int), (byte)(level + 1));

        nodes.Add(new(
            AsciiString.From("data"),
            AsciiString.From("pair"),
            ObjectParserType.Complex,
            ObjectParserNodeFlags.IsAlignTo4,
            (ushort)nodes.Count, 0, 0, (byte)(level + 1)));

        MakeNodesForType(nodes, AsciiString.From("first"), keyType, (byte)(level + 2));
        MakeNodesForType(nodes, AsciiString.From("second"), valueType, (byte)(level + 2)); ;
    }

    private const BindingFlags _fieldFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;
}
