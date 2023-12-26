using RogueTraderUnityToolkit.Helper;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace RogueTraderUnityToolkit.Unity;

public record struct SerializedObjectParser
{
    public readonly int Offset
    {
        get => _reader.Position - _start;
        set => _reader.Position = _start + value;
    }

    public readonly int Length => _end - _start;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Read(
        in SerializedObjectType type,
        in SerializedFileObjectManifest manifest,
        in SerializedFileTypeReference[] typeReferences,
        EndianBinaryReader reader,
        ISerializedObjectReader extReader)
    {
        _start = reader.Position;
        _end = _start + manifest.Size;
        _references = typeReferences;
        _reader = reader;
        _extReader = extReader;

        _extReader.BeginTree(type.Tree);
        Read(type.Tree, type.Tree.Root, 0);
        _extReader.EndTree(type.Tree);
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    private readonly void Read(
        in SerializedObjectTypeTree tree,
        in SerializedObjectParserNode node,
        int treeDepth)
    {
        bool isRoot = node.Index == 0;
        bool isRootTree = treeDepth == 0;

        _extReader.Visit(node, tree);

        // leaf
        if (node.IsPrimitive)
        {
            SerializedObjectParserNodeReader nodeReader = ReadPrimitive(node);
            _extReader.ReadPrimitive(node, nodeReader);
            Offset = nodeReader.End;
        }
        // complex types with primitive aliases/parsing
        else if (node.IsBuiltin)
        {
            // string -> char array -> { length, data }
            if (node.Type == SerializedObjectParserType.String)
            {
                SerializedObjectParserNodeReader nodeReader = ReadString(node, out int stringLength);
                _extReader.ReadString(node, nodeReader, stringLength);
                Offset = nodeReader.End;
            }
            // refobjecttree -> { version, info -> { rid, cls, ns, asm }, data (embedded tree) }
            else if (node.Type == SerializedObjectParserType.RefObjectTree)
            {
                if (TryReadRefObjectTree(node, tree, out long refId, out int typeRefIdx))
                {
                    ref SerializedFileTypeReference typeRef = ref _references[typeRefIdx];
                    _extReader.ReadRefObjectRegistry(node, refId, typeRef.Class, typeRef.Namespace, typeRef.Assembly);

                    _extReader.BeginTree(typeRef.Tree);
                    Read(typeRef.Tree, typeRef.Tree.Root, treeDepth + 1);
                    _extReader.EndTree(typeRef.Tree);
                }
                else
                {
                    // We reach this point with [SerializeReference].
                    // It doesn't actually fail import and we read all bytes, but cls/ns/sdm are empty strings and there are no references.
                    // I *think* this means that we can resolve the type in the primary assembly, but idk.
                    // Reference: (SpawnerAiScenario/PriorityTargetScenario) end == 2921276
                }
            }
            else
            {
                Debug.Assert(false);
            }           
        }
        // array -> { length, data }
        else if (node.IsArray)
        {
            ref SerializedObjectParserNode lengthNode = ref tree[node.FirstChildIdx];
            ref SerializedObjectParserNode dataNode = ref tree[lengthNode.FirstSiblingIdx];

            if (dataNode.IsLeaf)
            {
                SerializedObjectParserNodeReader nodeReader = ReadPrimitiveArray(node, dataNode, out int arrayLength);
                _extReader.ReadPrimitiveArray(node, dataNode, nodeReader, arrayLength);
                Offset = nodeReader.End;
            }
            else
            {
                int arrayLength = _reader.ReadS32();
                Debug.Assert(arrayLength >= 0 && Offset + arrayLength <= Length); // sanity check
                _extReader.ReadComplexArray(node, dataNode, arrayLength);

                for (int i = 0; i < arrayLength; ++i)
                {
                    Read(tree, dataNode, treeDepth);
                }
            }
        }
        // parent -> { children ... }
        else if (!node.IsLeaf)
        {
            if (node.IsRefRegistry && !isRootTree)
            {
                // Embedded types do not have their registries embedded inside, even though the type tree claims they do.
                // I've found that UnityDataTools fails in the same way, so it can't read certain assets from RT.
                // Skipping the embedded registry enables these assets to be fully parsed without any errors.
                return;
            }

            ushort startIdx = node.FirstChildIdx;
            ushort endIdx = node.FirstSiblingIdx != 0 ? node.FirstSiblingIdx : (ushort)tree.Length;
            ushort childIdx = startIdx;

            while (childIdx < endIdx)
            {
                ref SerializedObjectParserNode childNode = ref tree[childIdx];

                if (childNode.Level == node.Level + 1)
                {
                    Read(tree, childNode, treeDepth);
                }

                ++childIdx;
            }
        }

        // TODO: !isRoot || !isRootTree - if child trees align after
        if (!isRoot && node.IsAlignTo4)
        {
            int alignedBytes = _reader.AlignTo(4);
            _extReader.Align(node, alignedBytes);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private readonly SerializedObjectParserNodeReader ReadPrimitive(
        in SerializedObjectParserNode node)
    {
        Debug.Assert(node.IsPrimitive);
        return CreateReader(node.Type, node.Size);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private readonly SerializedObjectParserNodeReader ReadPrimitiveArray(
        in SerializedObjectParserNode node,
        in SerializedObjectParserNode dataNode,
        out int arrayLength)
    {
        Debug.Assert(node.IsArray);
        Debug.Assert(dataNode.IsPrimitive);

        arrayLength = _reader.ReadS32();
        return CreateReader(dataNode.Type, arrayLength * dataNode.Size);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private readonly SerializedObjectParserNodeReader ReadString(
        in SerializedObjectParserNode node,
        out int stringLength)
    {
        Debug.Assert(node.IsBuiltin);
        Debug.Assert(node.Type == SerializedObjectParserType.String);

        stringLength = _reader.ReadS32();
        return CreateReader(SerializedObjectParserType.String, stringLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private readonly bool TryReadRefObjectTree(
        in SerializedObjectParserNode node,
        in SerializedObjectTypeTree tree,
        out long refId,
        out int typeRefIdx)
    {
        Debug.Assert(node.IsBuiltin);
        Debug.Assert(node.Type == SerializedObjectParserType.RefObjectTree);

        ref SerializedObjectParserNode refIdNode = ref tree[node.FirstChildIdx];
        ref SerializedObjectParserNode refTypeNode = ref tree[refIdNode.FirstSiblingIdx];
        ref SerializedObjectParserNode refTypeClsNode = ref tree[refTypeNode.FirstChildIdx];
        ref SerializedObjectParserNode refTypeNsNode = ref tree[refTypeClsNode.FirstSiblingIdx];
        ref SerializedObjectParserNode refTypeAsmNode = ref tree[refTypeNsNode.FirstSiblingIdx];
        ref SerializedObjectParserNode refDataNode = ref tree[refTypeNode.FirstSiblingIdx];

        Debug.Assert(refIdNode.Type == SerializedObjectParserType.S64);
        Debug.Assert(refTypeClsNode.Type == SerializedObjectParserType.String);
        Debug.Assert(refTypeNsNode.Type == SerializedObjectParserType.String);
        Debug.Assert(refTypeAsmNode.Type == SerializedObjectParserType.String);

        refId = _reader.ReadS64();

        string cls = _reader.ReadString(_reader.ReadS32());
        _reader.AlignTo(4);

        string ns = _reader.ReadString(_reader.ReadS32());
        _reader.AlignTo(4);

        string asm = _reader.ReadString(_reader.ReadS32());
        _reader.AlignTo(4);

        for (int i = 0; i < _references.Length; ++i)
        {
            ref SerializedFileTypeReference candidate = ref _references[i];
            if (candidate.Class == cls && candidate.Namespace == ns && candidate.Assembly == asm)
            {
                typeRefIdx = i;
                return true;
            }
        }

        typeRefIdx = -1;
        return false;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private readonly SerializedObjectParserNodeReader CreateReader(
        SerializedObjectParserType type,
        int length)
    {
        int offset = Offset;
        Debug.Assert(offset + length <= Length);
        return new(_reader, type, _start, offset, offset + length);
    }

    private int _start;
    private int _end;
    private SerializedFileTypeReference[] _references;
    private EndianBinaryReader _reader;
    private ISerializedObjectReader _extReader;
}
