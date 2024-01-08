using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using RogueTraderUnityToolkit.Unity.TypeTree;
using System.Diagnostics;
using System.Reflection;

namespace RogueTraderUnityToolkit.Tree;

public readonly ref struct TreeBuilderAssembly()
{
    public ObjectTypeTree CreateTypeTreeFromAssembly(
        Assembly assembly,
        AsciiString ns,
        AsciiString cls,
        IEnumerable<ObjectParserNode> baseClass)
    {
        Type? type = assembly.GetTypes().FirstOrDefault(x => cls == x.Name && (ns == x.Namespace || (ns.Length == 0 && x.Namespace == null)));
        if (type == null) return new([]);

        _nodes.AddRange(baseClass);
        MakeNodesForTypeChildren(type, 1);

        Span<byte> allLevels = stackalloc byte[_nodes.Count];

        for (int i = 0; i < _nodes.Count; ++i)
        {
            allLevels[i] = _nodes[i].Level;
        }

        for (int i = 0; i < _nodes.Count; ++i)
        {
            ObjectParserNode node = _nodes[i];

            ObjectParserNodeUtil.ResolveHierarchy(i,
                node.Level,
                allLevels,
                out ushort firstChildIdx,
                out ushort firstSiblingIdx);

            _nodes[i] = node with {
                FirstChildIdx = firstChildIdx,
                FirstSiblingIdx = firstSiblingIdx
            };
        }

        ObjectTypeTree tree = new([.. _nodes]);

        Debug.Assert(_nodes.Select((_, i) => i).All(i => tree[i].Index == i), "Node indices were incorrect");
        Debug.Assert(_nodes.All(x => !x.IsPrimitive || x.Type != ObjectParserType.Complex), "Complex primitive?");
        Debug.Assert(_nodes.Zip(_nodes.Skip(1), (prev, cur) => cur.Level - prev.Level <= 1).All(x => x), "Gaps in levels?");

        _nodes.Clear();
        _visited.Clear();

        return tree;
    }

    private readonly List<ObjectParserNode> _nodes = [];
    private readonly Stack<Type> _visited = [];

    private void MakeNodesForType(AsciiString name, Type type, byte level, bool skipAlignment = false)
    {
        CheckType(type, out bool isUnityObject, out bool isString, out Type? innerType);

        // Handle aliasing UnityEngine.* type names to built-in types.
        if (!isString && innerType == null)
        {
            type = GetBuiltInTypeAlias(type) ?? type;
        }

        // Unity objects become PPTR references.
        if (isUnityObject)
        {
            CreatePPtr(name, AsciiString.From(type.Name), level);
            return;
        }

        ObjectParserType parserType = GetParserType(type);
        ObjectParserNodeFlags parserFlags = ObjectParserNodeFlags.None;

        // Size: Based on our type. Some _nodes have a size defined even if they aren't primitives, but we don't care about that.
        if (parserType.Size() > 0)
        {
            parserFlags |= ObjectParserNodeFlags.HasSize;
        }

        if (!skipAlignment && parserType.Size() <= 2)
        {
            parserFlags |= ObjectParserNodeFlags.IsAlignTo4;
        }

        AsciiString typeName = GetTypeName(type, innerType, parserType, isString);
        _nodes.Add(new(name, typeName, parserType, parserFlags, (ushort)_nodes.Count, 0xFF, 0xFF, level));

        Debug.Assert(parserType == ObjectParserType.Complex || innerType == null);
        Debug.Assert(parserType == ObjectParserType.Complex || !isString);

        if (innerType != null)
        {
            CreateArray(innerType, (byte)(level + 1));
        }
        else if (isString)
        {
            CreateArray(typeof(char), (byte)(level + 1));
        }
        else if (parserType == ObjectParserType.Complex)
        {
            MakeNodesForTypeChildren(type, (byte)(level + 1));
        }
    }

    private void MakeNodesForTypeChildren(Type type, byte level)
    {
        CheckType(type,
            out bool rootTypeIsUnityObject,
            out bool rootTypeIsString,
            out Type? rootTypeInnerType);

        Debug.Assert(level == 1 || !rootTypeIsUnityObject, "We should have written a PPtr for this type.");
        Debug.Assert(!rootTypeIsString && rootTypeInnerType == null, "We've probably tried to write a multidimensional array.");

        if (_visited.Contains(type))
        {
            Debug.Assert(true, "Circular reference detected.");
            return;
        };

        _visited.Push(type);
        FieldInfo[] fields = GetAllFields(type);

        int fieldsWritten = 0;

        for (int fieldIdx = 0; fieldIdx < fields.Length; ++fieldIdx)
        {
            FieldInfo f = fields[fieldIdx];

            if (!ShouldSerializeField(f)) continue;
            if (!ShouldSerializeFieldType(f.FieldType)) continue;

            Debug.Assert(!f.CustomAttributes.Any(x => x.AttributeType.Name.EndsWith("SerializeReference")),
                "I'm hoping that we don't have to deal with managed references.");

            Type fieldType = f.FieldType.IsEnum ? f.FieldType.GetEnumUnderlyingType() : f.FieldType;
            bool skipAlign = f.CustomAttributes.Any(x => x.AttributeType.Name == nameof(TreeBuilderAssemblyBuiltins.SkipAlignmentAttribute));
            MakeNodesForType(AsciiString.From(f.Name), fieldType, level, skipAlign);
            ++fieldsWritten;
        }

        Debug.Assert(!IsUnityEngineType(type) || fieldsWritten > 0, "Missing built-in.");

        _visited.Pop();
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

    private static void CheckType(
        Type type,
        out bool isUnityObject,
        out bool isString,
        out Type? innerType)
    {
        isUnityObject = IsUnityObject(type);
        isString = type.FullName == typeof(string).FullName;
        bool isArray = type.IsArray || (type.IsGenericType && type.GetGenericTypeDefinition().FullName == typeof(List<>).FullName);
        innerType = isArray ? (type.IsArray ? type.GetElementType()! : type.GetGenericArguments().First()) : null;
    }

    private static AsciiString GetTypeName(Type type, Type? innerType, ObjectParserType parserType, bool isString) =>
        parserType == ObjectParserType.Complex ?
            isString ? AsciiString.From("string") :
            innerType != null ? AsciiString.From("vector") :
            AsciiString.From(type.Name) :
            ObjectParserNodeUtil.TypeMap[parserType].First();

    private static bool ShouldSerializeField(FieldInfo field)
    {
        // Is public, or has a SerializeField attribute
        // isn’t static
        // isn’t const
        // isn’t readonly

        bool isPublic = field.IsPublic;
        bool isNotSerializable = (field.Attributes & FieldAttributes.NotSerialized) != 0;
        bool isSerializable = field.CustomAttributes.Any(x => x.AttributeType.Name.EndsWith("SerializeField"));
        bool isStatic = field.IsStatic;
        bool isConst = field.IsLiteral;
        bool isReadonly = field.IsInitOnly;

        return ((isPublic || isSerializable) && !isNotSerializable) && !isStatic && !isConst && !isReadonly;
    }

    private static bool ShouldSerializeFieldType(Type type)
    {
        // Has a field type that can be serialized:
        // Primitive data types (int, float, double, bool, string, etc.)
        // Enum types (32 bites or smaller)
        // Fixed-size buffers
        // Unity built-in types, for example, Vector2, Vector3, Rect, Matrix4x4, Color, AnimationCurve
        // Custom structs with the Serializable attribute
        // References to objects that derive from UnityEngine.Object
        // Custom classes with the Serializable attribute. (See Serialization of custom classes).
        // An array of a field type mentioned above
        // A List<T> of a field type mentioned above

        CheckType(type, out bool isUnityObject, out bool isString, out Type? innerType);

        if (innerType != null)
        {
            type = innerType; // we need to check the inner type to see if it's serializable
            CheckType(innerType, out isUnityObject, out isString, out Type? typeInnerInnerType);
            if (typeInnerInnerType != null) return false;
        }

        bool isPrimitive = type.IsPrimitive || isString;
        bool isEnum = type.IsEnum && GetParserType(type.GetEnumUnderlyingType()).Size() <= 4;
        // TODO: Fixed size buffers?
        bool isBuiltIn = IsUnityEngineType(type);
        bool isSerializable = (type.Attributes & TypeAttributes.Serializable) != 0;
        bool isCollection = innerType != null;

        return isPrimitive || isEnum || isSerializable || isUnityObject || isCollection || isBuiltIn;
    }

    private static Type? GetBuiltInTypeAlias(Type type)
    {
        if (IsUnityEngineType(type))
        {
            if (_builtInTypes.TryGetValue(AsciiString.From(type.Name), out Type? aliasedType))
            {
                return aliasedType;
            }

            Debug.Assert(GetAllFields(type).Length > 0, "Unity engine type with no fields: it probably needs a type alias.");
        }

        return null;
    }

    private static bool IsUnityObject(Type? type)
    {
        while (type != null)
        {
            if (type.FullName == "UnityEngine.Object")
            {
                return true;
            }

            type = type.BaseType;
        }

        return false;
    }

    private static bool IsUnityEngineType(Type type) => type.Namespace?.StartsWith("UnityEngine") ?? false;

    private static FieldInfo[] GetAllFields(Type? type)
    {
        List<FieldInfo> fields = [];
        Stack<Type> types = [];

        while (type != null)
        {
            types.Push(type);
            type = type.BaseType;
        }

        while (types.Count > 0)
        {
            fields.AddRange(types.Pop().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
        }

        return fields
            .GroupBy(f => f.Name)
            .Select(g => g.Last()) // Select the most derived version of the field
            .ToArray();
    }

    private void CreateArray(Type dataType, byte level)
    {
        _nodes.Add(new(
            AsciiString.From("Array"),
            AsciiString.From("Array"),
            ObjectParserType.Complex,
            ObjectParserNodeFlags.IsArray | ObjectParserNodeFlags.IsAlignTo4,
            (ushort)_nodes.Count, 0, 0, level));

        MakeNodesForType(AsciiString.From("size"), typeof(int), (byte)(level + 1));

        int nodeCountStart = _nodes.Count;
        MakeNodesForType(AsciiString.From("data"), dataType, (byte)(level + 1));

        Debug.Assert(GetParserType(dataType) != ObjectParserType.Complex || _nodes.Count > nodeCountStart + 1,
            "Didn't add any nodes for complex data type. It's probably a missing built-in.");
    }

    private void CreatePPtr(AsciiString name, AsciiString typeName, byte level)
    {
        _nodes.Add(new(
            name,
            AsciiString.From($"PPtr<{typeName}>"),
            ObjectParserType.Complex,
            ObjectParserNodeFlags.HasSize,
            (ushort)_nodes.Count, 0, 0, level));

        MakeNodesForType(AsciiString.From("m_FileID"), typeof(int), (byte)(level + 1));
        MakeNodesForType(AsciiString.From("m_PathID"), typeof(long), (byte)(level + 1));
    }

    private readonly static Dictionary<AsciiString, Type> _builtInTypes = new()
    {
        [AsciiString.From("AnimationCurve")] = typeof(TreeBuilderAssemblyBuiltins.AnimationCurve),
        [AsciiString.From("Bounds")] = typeof(TreeBuilderAssemblyBuiltins.AABB),
        [AsciiString.From("Color")] = typeof(TreeBuilderAssemblyBuiltins.F16.ColorRGBA),
        [AsciiString.From("Color32")] = typeof(TreeBuilderAssemblyBuiltins.I4.ColorRGBA),
        [AsciiString.From("Gradient")] = typeof(TreeBuilderAssemblyBuiltins.Gradient),
        [AsciiString.From("Keyframe")] = typeof(TreeBuilderAssemblyBuiltins.Keyframe),
        [AsciiString.From("LayerMask")] = typeof(TreeBuilderAssemblyBuiltins.LayerMask),
        [AsciiString.From("RectOffset")] = typeof(TreeBuilderAssemblyBuiltins.RectOffset),
        [AsciiString.From("Rect")] = typeof(TreeBuilderAssemblyBuiltins.Rectf),
        [AsciiString.From("Vector2")] = typeof(TreeBuilderAssemblyBuiltins.Vector2f),
        [AsciiString.From("Vector2Int")] = typeof(TreeBuilderAssemblyBuiltins.Vector2i),
        [AsciiString.From("Vector3")] = typeof(TreeBuilderAssemblyBuiltins.Vector3f),
        [AsciiString.From("Vector3Int")] = typeof(TreeBuilderAssemblyBuiltins.Vector3i),
        [AsciiString.From("Vector4")] = typeof(TreeBuilderAssemblyBuiltins.Vector4f),
        [AsciiString.From("Vector4Int")] = typeof(TreeBuilderAssemblyBuiltins.Vector4i),
    };
}

public static class TreeBuilderAssemblyBuiltins
{
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class SkipAlignmentAttribute : Attribute { }

    [Serializable]
    public struct AABB
    {
        public Vector3f m_Center;
        public Vector3f m_Extent;
    }

    [Serializable]
    public struct AnimationCurve
    {
        public Keyframe[] m_Curve;
        public int m_PreInfinity;
        public int m_PostInfinity;
        public int m_RotationOrder;
    }

    // REEEEEE. Color and Color32 (C#) map to the same type name in trees, ColorRGBA.
    // I have to do this so they have the same name when we export.

    public static class I4
    {
        [Serializable]
        public struct ColorRGBA
        {
            public uint rgba;
        }
    }

    public static class F16
    {
        [Serializable]
        public struct ColorRGBA
        {
            public float r;
            public float g;
            public float b;
            public float a;
        }
    }

    [Serializable]
    public struct Gradient
    {
        public F16.ColorRGBA key0;
        public F16.ColorRGBA key1;
        public F16.ColorRGBA key2;
        public F16.ColorRGBA key3;
        public F16.ColorRGBA key4;
        public F16.ColorRGBA key5;
        public F16.ColorRGBA key6;
        public F16.ColorRGBA key7;

        [SkipAlignment] public ushort ctime0;
        [SkipAlignment] public ushort ctime1;
        [SkipAlignment] public ushort ctime2;
        [SkipAlignment] public ushort ctime3;
        [SkipAlignment] public ushort ctime4;
        [SkipAlignment] public ushort ctime5;
        [SkipAlignment] public ushort ctime6;
        [SkipAlignment] public ushort ctime7;

        [SkipAlignment] public ushort atime0;
        [SkipAlignment] public ushort atime1;
        [SkipAlignment] public ushort atime2;
        [SkipAlignment] public ushort atime3;
        [SkipAlignment] public ushort atime4;
        [SkipAlignment] public ushort atime5;
        [SkipAlignment] public ushort atime6;
        [SkipAlignment] public ushort atime7;

        [SkipAlignment] public byte m_Mode;
        [SkipAlignment] public sbyte m_ColorSpace;
        [SkipAlignment] public byte m_NumColorKeys;
        [SkipAlignment] public byte m_NumAlphaKeys;
    }

    [Serializable]
    public struct RectOffset
    {
        public int left;
        public int right;
        public int top;
        public int bottom;
    }

    [Serializable]
    public struct Rectf
    {
        public float x;
        public float y;
        public float width;
        public float height;
    }

    [Serializable]
    public struct Keyframe
    {
        public float time;
        public float value;
        public float inSlope;
        public float outSlope;
        public int tangentMode;
        public int weightedMode;
        public float outWeight;
    }

    [Serializable]
    public struct LayerMask
    {
        public uint m_Bits;
    }

    [Serializable]
    public struct Vector2f
    {
        public float x;
        public float y;
    }

    [Serializable]
    public struct Vector2i
    {
        public int x;
        public int y;
    }

    [Serializable]
    public struct Vector3f
    {
        public float x;
        public float y;
        public float z;
    }

    [Serializable]
    public struct Vector3i
    {
        public int x;
        public int y;
        public int z;
    }

    [Serializable]
    public struct Vector4f
    {
        public float x;
        public float y;
        public float z;
        public float w;
    }

    [Serializable]
    public struct Vector4i
    {
        public int x;
        public int y;
        public int z;
        public int w;
    }
}
