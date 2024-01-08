using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using RogueTraderUnityToolkit.Unity.TypeTree;
using System.Text.Json;

namespace RogueTraderUnityToolkit.Tree;

public static class TreeBuilderJson
{
    public static Dictionary<UnityObjectType, ObjectTypeTree> CreateTypeTreesFromJsonPath(string jsonPath)
    {
        Root data = JsonSerializer.Deserialize<Root>(File.ReadAllBytes(jsonPath))!;

        Dictionary<UnityObjectType, ObjectTypeTree> typeTrees = [];

        foreach (ClassRecord cls in data.Classes)
        {
            if (cls.ReleaseRootNode == null) continue;
            DoOne(typeTrees, cls);
        }

        return typeTrees;
    }

    private static void DoOne(Dictionary<UnityObjectType, ObjectTypeTree> typeTrees, ClassRecord cls)
    {
        List<TypeTreeNode> allNodes = [];
        SelectAllTypeTreeNodes(cls.ReleaseRootNode!, allNodes);
        allNodes.Sort((lhs, rhs) => lhs.Index.CompareTo(rhs.Index));

        Span<byte> allLevels = stackalloc byte[allNodes.Count];

        for (int i = 0; i < allLevels.Length; ++i)
        {
            allLevels[i] = (byte)allNodes[i].Level;
        }

        ObjectParserNode[] convertedNodes = new ObjectParserNode[allNodes.Count];

        for (int i = 0; i < convertedNodes.Length; ++i)
        {
            convertedNodes[i] = ConvertTypeTreeNode(allNodes[i], allLevels);
        }

        ObjectTypeTree typeTree = new(convertedNodes);
        typeTrees[Enum.Parse<UnityObjectType>(cls.Name)] = new ObjectTypeTree(convertedNodes);

    }


    // Data is sourced from https://github.com/AssetRipper/TypeTreeDumps.
    // We use this for a small number of types which never have their type info embedded in data, e.g. GraphicsSettings.
    // We could probably get this also by exporting a bundle with one of everything...

    private record class Root(List<ClassRecord> Classes);

    private record class ClassRecord(
        string Name,
        string Namespace,
        string FullName,
        string Module,
        int TypeID,
        string Base,
        List<string> Derived,
        int DescendantCount,
        int Size,
        int TypeIndex,
        bool IsAbstract,
        bool IsSealed,
        bool IsEditorOnly,
        bool IsStripped,
        TypeTreeNode? EditorRootNode,
        TypeTreeNode? ReleaseRootNode
    );

    private record class TypeTreeNode(
        string TypeName,
        string Name,
        int Level,
        int ByteSize,
        int Index,
        int Version,
        int TypeFlags,
        int MetaFlag,
        List<TypeTreeNode> SubNodes
    );

    private static void SelectAllTypeTreeNodes(in TypeTreeNode node, ICollection<TypeTreeNode> allNodes)
    {
        allNodes.Add(node);
        foreach (TypeTreeNode child in node.SubNodes ?? [])
        {
            SelectAllTypeTreeNodes(child, allNodes);
        }
    }

    private static ObjectParserNode ConvertTypeTreeNode(
        in TypeTreeNode node,
        ReadOnlySpan<byte> allLevels)
    {
        AsciiString name = AsciiString.From(node.Name);
        AsciiString typeName = AsciiString.From(node.TypeName);

        if (!ObjectParserNodeUtil.TryGetType(typeName, out ObjectParserType type))
        {
            type = ObjectParserType.Complex;
        }

        ObjectParserNodeFlags flags = ObjectParserNodeUtil.GetParserFlags(
            node.ByteSize,
            (ObjectTypeFlags)node.TypeFlags,
            (ObjectTypeMetaFlags)node.MetaFlag);

        ObjectParserNodeUtil.ResolveHierarchy(
            node.Index,
            (byte)node.Level,
            allLevels,
            out ushort firstChildIdx,
            out ushort firstSiblingIdx);

        return new ObjectParserNode(
            Name: name,
            TypeName: typeName,
            Type: type,
            Flags: flags,
            Index: (ushort)node.Index,
            FirstChildIdx: firstChildIdx,
            FirstSiblingIdx: firstSiblingIdx,
            Level: (byte)node.Level);
    }
}
