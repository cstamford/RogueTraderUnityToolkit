using RogueTraderUnityToolkit.Core;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace RogueTraderUnityToolkit.Unity;

public readonly ref struct ObjectParserReader(
    EndianBinaryReader reader,
    ObjectParserType type,
    int objectOffset,
    int dataOffset,
    int dataOffsetEnd)
{
    public ObjectParserType Type => type;
    public int Base => objectOffset;
    public int Start => dataOffset;
    public int End => dataOffsetEnd;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public ulong ReadU64(in ObjectParserNode node)
    {
        Debug.Assert(node.IsPrimitive);
        Debug.Assert(node.Size == 8);
        Debug.Assert(type == ObjectParserType.U64);
        PrepareForRead();
        return reader.ReadU64();
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint ReadU32(in ObjectParserNode node)
    {
        Debug.Assert(node.IsPrimitive);
        Debug.Assert(node.Size == 4);
        Debug.Assert(type == ObjectParserType.U32);
        PrepareForRead();
        return reader.ReadU32();
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public ushort ReadU16(in ObjectParserNode node)
    {
        Debug.Assert(node.IsPrimitive);
        Debug.Assert(node.Size == 2);
        Debug.Assert(type == ObjectParserType.U16);
        PrepareForRead();
        return reader.ReadU16();
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public byte ReadU8(in ObjectParserNode node)
    {
        Debug.Assert(node.IsPrimitive);
        Debug.Assert(node.Size == 1);
        Debug.Assert(type == ObjectParserType.U8);
        PrepareForRead();
        return reader.ReadU8();
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public long ReadS64(in ObjectParserNode node)
    {
        Debug.Assert(node.IsPrimitive);
        Debug.Assert(node.Size == 8);
        Debug.Assert(type == ObjectParserType.S64);
        PrepareForRead();
        return reader.ReadS64();
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int ReadS32(in ObjectParserNode node)
    {
        Debug.Assert(node.IsPrimitive);
        Debug.Assert(node.Size == 4);
        Debug.Assert(type == ObjectParserType.S32);
        PrepareForRead();
        return reader.ReadS32();
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public short ReadS16(in ObjectParserNode node)
    {
        Debug.Assert(node.IsPrimitive);
        Debug.Assert(node.Size == 2);
        Debug.Assert(type == ObjectParserType.S16);
        PrepareForRead();
        return reader.ReadS16();
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public sbyte ReadS8(in ObjectParserNode node)
    {
        Debug.Assert(node.IsPrimitive);
        Debug.Assert(node.Size == 1);
        Debug.Assert(type == ObjectParserType.S8);
        PrepareForRead();
        return reader.ReadS8();
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public double ReadF64(in ObjectParserNode node)
    {
        Debug.Assert(node.IsPrimitive);
        Debug.Assert(node.Size == 8);
        Debug.Assert(type == ObjectParserType.F64);
        PrepareForRead();
        return reader.ReadF64();
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float ReadF32(in ObjectParserNode node)
    {
        Debug.Assert(node.IsPrimitive);
        Debug.Assert(node.Size == 4);
        Debug.Assert(type == ObjectParserType.F32);
        PrepareForRead();
        return reader.ReadF32();
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool ReadBool(in ObjectParserNode node)
    {
        Debug.Assert(node.IsPrimitive);
        Debug.Assert(node.Size == 1);
        Debug.Assert(type == ObjectParserType.Bool);
        PrepareForRead();
        byte value = reader.ReadByte();
        Debug.Assert(value is 0 or 1, "non-bool bool, memory alignment issue");
        return value != 0;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public char ReadChar(in ObjectParserNode node)
    {
        Debug.Assert(node.IsPrimitive);
        Debug.Assert(node.Size == 1);
        Debug.Assert(type == ObjectParserType.Char);
        PrepareForRead();
        return Convert.ToChar(reader.ReadByte());
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void ReadPrimitive(
        in ObjectParserNode node,
        Span<byte> buffer)
    {
        Debug.Assert(node.IsPrimitive);
        Debug.Assert(node.Size is 1 or 2 or 4 or 8);
        Debug.Assert(buffer.Length >= node.Size);

        PrepareForRead();
        ReadPrimitiveInternal(buffer[..node.Size]);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void ReadPrimitiveArray(
        in ObjectParserNode node,
        int arrayLength,
        Span<byte> buffer,
        Func<int, int, bool> fnOnReadChunk)
    {
        Debug.Assert(node.IsArray);
        Debug.Assert(type != ObjectParserType.Complex);

        int sizePerElement = type.Size();
        int entriesPerChunk = buffer.Length / sizePerElement;
        int chunks = arrayLength / entriesPerChunk;

        int element = 0;

        for (int chunk = 0; chunk < chunks; ++chunk)
        {
            for (int entry = 0; entry < entriesPerChunk; ++entry)
            {
                int start = entry * sizePerElement;
                int end = start + sizePerElement;
                ReadPrimitiveInternal(buffer[start..end]);
                ++element;
            }

            if (!fnOnReadChunk(element - entriesPerChunk, element)) return;
            if (element == arrayLength) return;
        }

        int drain = 0;

        while (element != arrayLength)
        {
            int start = drain++ * sizePerElement;
            int end = start + sizePerElement;
            ReadPrimitiveInternal(buffer[start..end]);
            ++element;
        }

        fnOnReadChunk(element - drain, element);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public AsciiString ReadString(
        in ObjectParserNode node,
        int stringLength,
        int readLength = -1)
    {
        Debug.Assert(node.Type == ObjectParserType.String);
        PrepareForRead();
        return reader.ReadString(readLength != -1 ? Math.Min(stringLength, readLength) : stringLength);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void ReadPPtr(
        in ObjectParserNode node,
        AsciiString typeName)
    {
        Debug.Assert(node.Type == ObjectParserType.PPTr);
        PrepareForRead();

        int fileId = reader.ReadS32();
        long pathId = reader.ReadS64();
        
        // TODO - codegen for C# type bindings so we can return PPtr<T>
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private void ReadPrimitiveInternal(
        Span<byte> buffer)
    {
        Debug.Assert(buffer.Length is 1 or 2 or 4 or 8);

        switch (buffer.Length)
        {
            case 8: reader.ReadSwap64(buffer); break;
            case 4: reader.ReadSwap32(buffer); break;
            case 2: reader.ReadSwap16(buffer); break;
            case 1: reader.ReadBytes(buffer); break;
        }
    }

    private void PrepareForRead() => reader.SeekStart(objectOffset + dataOffset);
}
