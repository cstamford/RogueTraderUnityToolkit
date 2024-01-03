﻿using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity.File;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace RogueTraderUnityToolkit.Unity.TypeTree;

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

        Debug.Assert(type.Tree != null);

        _extReader.BeginTree(type.Tree);
        Read(type.Tree, type.Tree.Root, treeDepth: 0, reading: true);
        _extReader.EndTree(type.Tree);
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    private readonly void Read(
        in ObjectTypeTree tree,
        in ObjectParserNode node,
        int treeDepth,
        bool reading)
    {
        bool isRoot = node.Index == 0;

        _extReader.BeginNode(node, tree);
        Debug.Assert(Offset >= 0 && Offset <= Length);

        // leaf
        if (node.IsPrimitive)
        {
            ObjectParserReader nodeReader = ReadPrimitive(node, reading);
            _extReader.ReadPrimitive(node, nodeReader);
            Offset = nodeReader.End;
        }
        // array -> { length, data }
        else if (node.IsArray)
        {
            ref ObjectParserNode lengthNode = ref tree[node.FirstChildIdx];
            ref ObjectParserNode dataNode = ref tree[lengthNode.FirstSiblingIdx];
            bool isPrimitiveArray = dataNode.IsLeaf;

            Debug.Assert(!isPrimitiveArray || dataNode.IsPrimitive);
            Debug.Assert(lengthNode.Type == ObjectParserType.S32);

            Peek(tree, lengthNode, treeDepth);
            int arrayLength = reading ? _reader.ReadS32() : 0;
            Debug.Assert(arrayLength >= 0);
            Debug.Assert(Offset + arrayLength <= Length); // sanity check

            if (isPrimitiveArray)
            {
                Debug.Assert(Offset + arrayLength * dataNode.Size <= Length);
                Peek(tree, dataNode, treeDepth);
                ObjectParserReader nodeReader = CreateReader(dataNode.Type, arrayLength * dataNode.Size, reading);
                _extReader.ReadPrimitiveArray(node, dataNode, nodeReader, arrayLength);
                Offset = nodeReader.End;
            }
            else
            {
                _extReader.ReadComplexArray(node, dataNode, arrayLength);

                for (int i = 0; i < Math.Max(1, arrayLength); ++i)
                {
                    Read(tree, dataNode, treeDepth, reading: reading && arrayLength != 0);
                }
            }
        }
        else if (node.IsRefRegistry)
        {
            ref ObjectParserNode versionNode = ref tree[node.FirstChildIdx];
            ref ObjectParserNode refIdsNode = ref tree[versionNode.FirstSiblingIdx];
            ref ObjectParserNode refIdsArrayNode = ref tree[refIdsNode.FirstChildIdx];
            ref ObjectParserNode refIdsArraySizeNode = ref tree[refIdsArrayNode.FirstChildIdx];
            ref ObjectParserNode refIdsArrayDataNode = ref tree[refIdsArraySizeNode.FirstSiblingIdx];

            Debug.Assert(versionNode.Type == ObjectParserType.S32);
            Debug.Assert(refIdsNode.Type == ObjectParserType.Complex);
            Debug.Assert(refIdsArrayNode is { Type: ObjectParserType.Complex, IsArray: true });
            Debug.Assert(refIdsArraySizeNode.Type == ObjectParserType.S32);
            Debug.Assert(refIdsArrayDataNode.Type == ObjectParserType.Complex);

            if (treeDepth == 0)
            {
                Peek(tree, versionNode, treeDepth); // version node only
                int version = _reader.ReadS32();
                Debug.Assert(version == 2, $"Unsupported reference registry version {version}");

                Peek(tree, refIdsNode, treeDepth); // peeks the rest
                int refs = _reader.ReadS32();

                for (int i = 0; i < refs; ++i)
                {
                    if (TryReadReferencedObject(tree, refIdsArrayDataNode, reading, out long refId, out int typeRefIdx))
                    {
                        ref SerializedFileTypeReference typeRef = ref _references[typeRefIdx];
                        _extReader.ReadReferencedObject(node, refId, typeRef.Class, typeRef.Namespace, typeRef.Assembly);

                        _extReader.BeginTree(typeRef.Tree);
                        Read(typeRef.Tree, typeRef.Tree.Root, treeDepth + 1, reading: true);
                        _extReader.EndTree(typeRef.Tree);
                    }
                    else
                    {
                        Debug.Assert(true, "TryReadReferencedObject can fail with [SerializeReference] sometimes. This is a cosmetic error.");
                    }
                }
            }
            else
            {
                // Embedded types do not have their registries embedded inside, even though the type tree claims they do.
                // I've found that UnityDataTools fails in the same way, so it can't read certain assets from RT.
                // Skipping the embedded registry enables these assets to be fully parsed without any errors.
                Debug.Assert(true, "Skipping ref registry for child trees");
            }
        }
        // parent -> { children ... }
        else if (!node.IsLeaf)
        {
            Debug.Assert(node.Type == ObjectParserType.Complex, $"Non-complex node with children?\n{node}");

            ushort startIdx = node.FirstChildIdx;
            ushort endIdx = node.FirstSiblingIdx != 0 ? node.FirstSiblingIdx : (ushort)tree.Length;
            ushort childIdx = startIdx;

            while (childIdx < endIdx)
            {
                ref ObjectParserNode childNode = ref tree[childIdx];

                if (childNode.Level == node.Level + 1)
                {
                    Read(tree, childNode, treeDepth, reading);
                }

                ++childIdx;
            }
        }
        else
        {
            Debug.Assert(true, "Sometimes we see leaf nodes with no data, but logging them is just noise.");
        }

        _extReader.EndNode(node, tree);
        Debug.Assert(Offset >= 0 && Offset <= Length);

        if (!isRoot && node.IsAlignTo4)
        {
            int alignedBytes = reading ? _reader.AlignTo(4) : 0;
            _extReader.Align(node, alignedBytes);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private readonly void Peek(in ObjectTypeTree tree, in ObjectParserNode node, int treeDepth) =>
        Read(tree, node, treeDepth, reading: false);

    private readonly ObjectParserReader ReadPrimitive(
        in ObjectParserNode node,
        bool reading)
    {
        Debug.Assert(node.IsPrimitive);
        Debug.Assert(node.Size > 0);
        return CreateReader(node.Type, node.Size, reading);
    }

    private readonly bool TryReadReferencedObject(
        in ObjectTypeTree tree,
        in ObjectParserNode node,
        bool reading,
        out long refId,
        out int typeRefIdx)
    {
        Debug.Assert(node.TypeName == "ReferencedObject");
        Debug.Assert(node.Type == ObjectParserType.Complex);

        ref ObjectParserNode refIdNode = ref tree[node.FirstChildIdx];
        ref ObjectParserNode refTypeNode = ref tree[refIdNode.FirstSiblingIdx];
        ref ObjectParserNode refTypeClsNode = ref tree[refTypeNode.FirstChildIdx];
        ref ObjectParserNode refTypeNsNode = ref tree[refTypeClsNode.FirstSiblingIdx];
        ref ObjectParserNode refTypeAsmNode = ref tree[refTypeNsNode.FirstSiblingIdx];
        ref ObjectParserNode refDataNode = ref tree[refTypeNode.FirstSiblingIdx];

        Debug.Assert(refIdNode.Type == ObjectParserType.S64);
        Debug.Assert(refTypeClsNode.TypeName == "string");
        Debug.Assert(refTypeNsNode.TypeName == "string");
        Debug.Assert(refTypeAsmNode.TypeName == "string");
        Debug.Assert(refDataNode.TypeName == "ReferencedObjectData");

        if (reading)
        {
            refId = _reader.ReadS64();

            AsciiString cls = _reader.ReadString(_reader.ReadS32());
            _reader.AlignTo(4);

            AsciiString ns = _reader.ReadString(_reader.ReadS32());
            _reader.AlignTo(4);

            AsciiString asm = _reader.ReadString(_reader.ReadS32());
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
        }

        refId = 0;
        typeRefIdx = -1;
        return false;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private readonly ObjectParserReader CreateReader(
        ObjectParserType type,
        int length,
        bool reading)
    {
        EndianBinaryReader reader = reading ? _reader : _dummyReader;
        int offset = Offset;
        int offsetEnd = reading ? offset + length : offset;
        Debug.Assert(offsetEnd <= Length);
        return new(reader, type, _start, offset, offsetEnd);
    }

    private int _start;
    private int _end;
    private SerializedFileTypeReference[] _references;
    private EndianBinaryReader _reader;
    private IObjectTypeTreeReader _extReader;
    private static readonly EndianBinaryReader _dummyReader = new(new NullStream());
}
