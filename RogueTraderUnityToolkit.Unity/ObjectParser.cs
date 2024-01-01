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
        bool isRootTree = treeDepth == 0;
        
        using var _ = _extReader.Visit(tree, node.Index);

        // leaf
        if (node.IsPrimitive)
        {
            ObjectParserReader nodeReader = ReadPrimitive(node, reading);
            _extReader.ReadPrimitive(node, nodeReader);
            Offset = nodeReader.End;
        }
        // complex types with primitive aliases/parsing
        else if (node.IsBuiltin)
        {
            // string -> char array -> { length, data }
            if (node.Type == ObjectParserType.String)
            {
                ObjectParserReader nodeReader = ReadString(node, reading, out int stringLength);
                _extReader.ReadString(node, nodeReader, stringLength);
                Offset = nodeReader.End;
            }
            // refObjectTree -> { version, info -> { rid, cls, ns, asm }, data (embedded tree) }
            else if (node.Type == ObjectParserType.RefObjectTree)
            {
                if (TryReadRefObjectTree(node, tree, reading, out long refId, out int typeRefIdx))
                {
                    ref SerializedFileTypeReference typeRef = ref _references[typeRefIdx];
                    _extReader.ReadRefObjectRegistry(node, refId, typeRef.Class, typeRef.Namespace, typeRef.Assembly);
                    
                    _extReader.BeginTree(typeRef.Tree);
                    Read(typeRef.Tree, typeRef.Tree.Root, treeDepth + 1, reading: true /* we can't be here otherwise */);
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
            else if (node.Type == ObjectParserType.Vector)
            {
                
            }
            else if (node.Type == ObjectParserType.Map)
            {
                
            }
            // pptr -> { m_FileID, m_PathID }, type extracted from name 
            else if (node.Type == ObjectParserType.PPTr)
            {
                ObjectParserReader nodeReader = ReadPPtr(node, tree, reading, out AsciiString typeName);
                _extReader.ReadPPtr(node, nodeReader, typeName);
                Offset = nodeReader.End;
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
                ObjectParserReader nodeReader = ReadPrimitiveArray(node, dataNode, reading, out int arrayLength);
                _extReader.ReadPrimitiveArray(node, dataNode, nodeReader, arrayLength);
                Offset = nodeReader.End;
            }
            else
            {
                int arrayLength = reading ? _reader.ReadS32() : 0;
                Debug.Assert(arrayLength >= 0 && Offset + arrayLength <= Length); // sanity check
                _extReader.ReadComplexArray(node, dataNode, arrayLength);
                
                // In the event we have a zero-sized complex array, we still visit all the nodes once,
                // so users are informed about their structure.
                // However, we obviously can't read any data, so we set the flag 'reading' to false
                // so we skip over any reads and disallow users from reading as well by setting the
                // flag on the reader.

                for (int i = 0; i < Math.Max(1, arrayLength); ++i)
                {
                    Read(tree, dataNode, treeDepth, reading && arrayLength != 0);
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
                    Read(tree, childNode, treeDepth, reading);
                }

                ++childIdx;
            }
        }
        
        if (!isRoot && node.IsAlignTo4)
        {
            int alignedBytes = reading ? _reader.AlignTo(4) : 0;
            _extReader.Align(node, alignedBytes);
        }
    }

    private readonly ObjectParserReader ReadPrimitive(
        in ObjectParserNode node,
        bool reading)
    {
        Debug.Assert(node.IsPrimitive);
        return CreateReader(node.Type, node.Size, reading);
    }

    private readonly ObjectParserReader ReadPrimitiveArray(
        in ObjectParserNode node,
        in ObjectParserNode dataNode,
        bool reading,
        out int arrayLength)
    {
        Debug.Assert(node.IsArray);
        Debug.Assert(dataNode.IsPrimitive);

        arrayLength = reading ? _reader.ReadS32() : 0;
        return CreateReader(dataNode.Type, arrayLength * dataNode.Size, reading);
    }

    private readonly ObjectParserReader ReadString(
        in ObjectParserNode node,
        bool reading,
        out int stringLength)
    {
        Debug.Assert(node.IsBuiltin);
        Debug.Assert(node.Type == ObjectParserType.String);

        stringLength = reading ? _reader.ReadS32() : 0;
        return CreateReader(ObjectParserType.String, stringLength, reading);
    }
    
    private readonly ObjectParserReader ReadPPtr(
        in ObjectParserNode node,
        in ObjectTypeTree tree,
        bool reading,
        out AsciiString typeName)
    {
        Debug.Assert(node.IsBuiltin);
        Debug.Assert(node.Type == ObjectParserType.PPTr);

        const int typeNameStartIdx = 5;
        int typeNameEndIdx = node.TypeName.Length - 1;
        int typeNameLength = typeNameEndIdx - typeNameStartIdx;
        
        Debug.Assert(typeNameLength >= 1);

        ReadOnlyMemory<byte> mem = node.TypeName.Bytes.Slice(typeNameStartIdx, typeNameLength);
        typeName = AsciiStringPool.Fetch(mem);
        
        ref ObjectParserNode fileIdNode = ref tree[node.FirstChildIdx];
        ref ObjectParserNode pathIdNode = ref tree[fileIdNode.FirstSiblingIdx];
        
        Debug.Assert(fileIdNode.Type == ObjectParserType.S32);
        Debug.Assert(pathIdNode.Type == ObjectParserType.S64);
        
        return CreateReader(ObjectParserType.PPTr, fileIdNode.Size + pathIdNode.Size, reading);
    }

    private readonly bool TryReadRefObjectTree(
        in ObjectParserNode node,
        in ObjectTypeTree tree,
        bool reading,
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
        EndianBinaryReader reader = reading ? _reader : new(new NullStream());
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
}

public readonly struct ObjectParserNodeScopeWrapper : IDisposable
{
    public ObjectParserNodeScopeWrapper(
        IObjectTypeTreeReader reader,
        ObjectTypeTree tree,
        ushort nodeIdx)
    {
        _reader = reader;
        _tree = tree;
        _nodeIdx = nodeIdx;
        
        _reader.BeginNode(_tree[_nodeIdx], _tree);
    }
    
    public void Dispose()
    {
        _reader.EndNode(_tree[_nodeIdx], _tree);
    }

    private readonly IObjectTypeTreeReader _reader;
    private readonly ObjectTypeTree _tree;
    private readonly ushort _nodeIdx;
}
