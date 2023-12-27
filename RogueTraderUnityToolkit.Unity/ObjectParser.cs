using RogueTraderUnityToolkit.Core;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace RogueTraderUnityToolkit.Unity;

public record struct ObjectParser
{
    public readonly int Offset
    {
        get => _reader.Position - _start;
        set => _reader.Position = _start + value;
    }

    public readonly int Length => _end - _start;

    public void Read(
        in SerializedFileObject type,
        in SerializedFileObjectInstance instance,
        in SerializedFileTypeReference[] typeReferences,
        EndianBinaryReader reader,
        IObjectTypeTreeReader extReader)
    {
        _start = reader.Position;
        _end = _start + instance.Size;
        _references = typeReferences;
        _reader = reader;
        _extReader = extReader;

        _extReader.BeginTree(type.Tree);
        Read(type.Tree, type.Tree.Root, 0);
        _extReader.EndTree(type.Tree);
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    private readonly void Read(
        in ObjectTypeTree tree,
        in ObjectParserNode node,
        int treeDepth)
    {
        bool isRoot = node.Index == 0;
        bool isRootTree = treeDepth == 0;

        _extReader.Visit(node, tree);

        // leaf
        if (node.IsPrimitive)
        {
            ObjectParserReader nodeReader = ReadPrimitive(node);
            _extReader.ReadPrimitive(node, nodeReader);
            Offset = nodeReader.End;
        }
        // complex types with primitive aliases/parsing
        else if (node.IsBuiltin)
        {
            // string -> char array -> { length, data }
            if (node.Type == ObjectParserType.String)
            {
                ObjectParserReader nodeReader = ReadString(node, out int stringLength);
                _extReader.ReadString(node, nodeReader, stringLength);
                Offset = nodeReader.End;
            }
            // refObjectTree -> { version, info -> { rid, cls, ns, asm }, data (embedded tree) }
            else if (node.Type == ObjectParserType.RefObjectTree)
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
            ref ObjectParserNode lengthNode = ref tree[node.FirstChildIdx];
            ref ObjectParserNode dataNode = ref tree[lengthNode.FirstSiblingIdx];

            if (dataNode.IsLeaf)
            {
                ObjectParserReader nodeReader = ReadPrimitiveArray(node, dataNode, out int arrayLength);
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
                ref ObjectParserNode childNode = ref tree[childIdx];

                if (childNode.Level == node.Level + 1)
                {
                    Read(tree, childNode, treeDepth);
                }

                ++childIdx;
            }
        }
        
        if (!isRoot && node.IsAlignTo4)
        {
            int alignedBytes = _reader.AlignTo(4);
            _extReader.Align(node, alignedBytes);
        }
    }

    private readonly ObjectParserReader ReadPrimitive(
        in ObjectParserNode node)
    {
        Debug.Assert(node.IsPrimitive);
        return CreateReader(node.Type, node.Size);
    }

    private readonly ObjectParserReader ReadPrimitiveArray(
        in ObjectParserNode node,
        in ObjectParserNode dataNode,
        out int arrayLength)
    {
        Debug.Assert(node.IsArray);
        Debug.Assert(dataNode.IsPrimitive);

        arrayLength = _reader.ReadS32();
        return CreateReader(dataNode.Type, arrayLength * dataNode.Size);
    }

    private readonly ObjectParserReader ReadString(
        in ObjectParserNode node,
        out int stringLength)
    {
        Debug.Assert(node.IsBuiltin);
        Debug.Assert(node.Type == ObjectParserType.String);

        stringLength = _reader.ReadS32();
        return CreateReader(ObjectParserType.String, stringLength);
    }

    private readonly bool TryReadRefObjectTree(
        in ObjectParserNode node,
        in ObjectTypeTree tree,
        out long refId,
        out int typeRefIdx)
    {
        Debug.Assert(node.IsBuiltin);
        Debug.Assert(node.Type == ObjectParserType.RefObjectTree);

        ref ObjectParserNode refIdNode = ref tree[node.FirstChildIdx];
        ref ObjectParserNode refTypeNode = ref tree[refIdNode.FirstSiblingIdx];
        ref ObjectParserNode refTypeClsNode = ref tree[refTypeNode.FirstChildIdx];
        ref ObjectParserNode refTypeNsNode = ref tree[refTypeClsNode.FirstSiblingIdx];
        ref ObjectParserNode refTypeAsmNode = ref tree[refTypeNsNode.FirstSiblingIdx];

        Debug.Assert(refIdNode.Type == ObjectParserType.S64);
        Debug.Assert(refTypeClsNode.Type == ObjectParserType.String);
        Debug.Assert(refTypeNsNode.Type == ObjectParserType.String);
        Debug.Assert(refTypeAsmNode.Type == ObjectParserType.String);

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
    private readonly ObjectParserReader CreateReader(
        ObjectParserType type,
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
    private IObjectTypeTreeReader _extReader;
}
