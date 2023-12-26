using RogueTraderUnityToolkit.Helper;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace RogueTraderUnityToolkit.Unity;

public readonly ref struct SerializedObjectParserNodeReader
{
    public int Base => _objectOffset;
    public int Start => _dataOffset;
    public int End => _dataOffsetEnd;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public SerializedObjectParserNodeReader(
        EndianBinaryReader reader,
        SerializedObjectParserType type,
        int objectOffset,
        int dataOffset,
        int dataOffsetEnd)
    {
        _reader = reader;
        _type = type;
        _objectOffset = objectOffset;
        _dataOffset = dataOffset;
        _dataOffsetEnd = dataOffsetEnd;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public readonly ulong ReadU64(in SerializedObjectParserNode node)
    {
        Debug.Assert(node.IsPrimitive);
        Debug.Assert(node.Size == 8);
        Debug.Assert(_type == SerializedObjectParserType.U64);
        PrepareForRead();
        return _reader.ReadU64();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint ReadU32(in SerializedObjectParserNode node)
    {
        Debug.Assert(node.IsPrimitive);
        Debug.Assert(node.Size == 4);
        Debug.Assert(_type == SerializedObjectParserType.U32);
        PrepareForRead();
        return _reader.ReadU32();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public ushort ReadU16(in SerializedObjectParserNode node)
    {
        Debug.Assert(node.IsPrimitive);
        Debug.Assert(node.Size == 2);
        Debug.Assert(_type == SerializedObjectParserType.U16);
        PrepareForRead();
        return _reader.ReadU16();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public byte ReadU8(in SerializedObjectParserNode node)
    {
        Debug.Assert(node.IsPrimitive);
        Debug.Assert(node.Size == 1);
        Debug.Assert(_type == SerializedObjectParserType.U8);
        PrepareForRead();
        return _reader.ReadU8();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public long ReadS64(in SerializedObjectParserNode node)
    {
        Debug.Assert(node.IsPrimitive);
        Debug.Assert(node.Size == 8);
        Debug.Assert(_type == SerializedObjectParserType.S64);
        PrepareForRead();
        return _reader.ReadS64();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int ReadS32(in SerializedObjectParserNode node)
    {
        Debug.Assert(node.IsPrimitive);
        Debug.Assert(node.Size == 4);
        Debug.Assert(_type == SerializedObjectParserType.S32);
        PrepareForRead();
        return _reader.ReadS32();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public short ReadS16(in SerializedObjectParserNode node)
    {
        Debug.Assert(node.IsPrimitive);
        Debug.Assert(node.Size == 2);
        Debug.Assert(_type == SerializedObjectParserType.S16);
        PrepareForRead();
        return _reader.ReadS16();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public sbyte ReadS8(in SerializedObjectParserNode node)
    {
        Debug.Assert(node.IsPrimitive);
        Debug.Assert(node.Size == 1);
        Debug.Assert(_type == SerializedObjectParserType.S8);
        PrepareForRead();
        return _reader.ReadS8();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public double ReadF64(in SerializedObjectParserNode node)
    {
        Debug.Assert(node.IsPrimitive);
        Debug.Assert(node.Size == 8);
        Debug.Assert(_type == SerializedObjectParserType.F64);
        PrepareForRead();
        return _reader.ReadF64();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public float ReadF32(in SerializedObjectParserNode node)
    {
        Debug.Assert(node.IsPrimitive);
        Debug.Assert(node.Size == 4);
        Debug.Assert(_type == SerializedObjectParserType.F32);
        PrepareForRead();
        return _reader.ReadF32();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool ReadBool(in SerializedObjectParserNode node)
    {
        Debug.Assert(node.IsPrimitive);
        Debug.Assert(node.Size == 1);
        Debug.Assert(_type == SerializedObjectParserType.Bool);
        PrepareForRead();
        byte value = _reader.ReadByte();
        Debug.Assert(value == 0 || value == 1, "non-bool bool, memory alignment issue");
        return value != 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public char ReadChar(in SerializedObjectParserNode node)
    {
        Debug.Assert(node.IsPrimitive);
        Debug.Assert(node.Size == 1);
        Debug.Assert(_type == SerializedObjectParserType.Char);
        PrepareForRead();
        return Convert.ToChar(_reader.ReadByte());
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int ReadArrayLength(in SerializedObjectParserNode node)
    {
        Debug.Assert(node.IsArray);
        PrepareForRead();

        int length = _reader.ReadS32();
        Debug.Assert(length >= 0);

        return length;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void ReadPrimitiveArray(
        in SerializedObjectParserNode node,
        int arrayLength,
        Span<byte> buffer,
        Func<int, int, bool> fnOnReadChunk)
    {
        Debug.Assert(node.IsArray);
        Debug.Assert(_type != SerializedObjectParserType.Complex);

        int sizePerElement = _type.Size();
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
    public unsafe string ReadPrimitiveArrayAsString(
        in SerializedObjectParserNode node,
        int arrayLength,
        int readLength = -1,
        string separator = ", ")
    {
        int chunkAlignment = _type.Size();
        int chunkSize = chunkAlignment * Math.Min(256, readLength != -1 ? readLength : 64);

        byte* buffer = stackalloc byte[chunkSize + chunkAlignment];
        buffer = Memory.AlignTo(buffer, chunkAlignment);

        SerializedObjectParserType type = _type;
        int sizePerElement = type.Size();

        StringBuilder sb = new();

        ReadPrimitiveArray(node, arrayLength, new(buffer, chunkSize), (start, end) =>
        {
            for (int i = 0; i < end - start; ++i)
            {
                byte* elem = buffer + i * sizePerElement;        
                
                sb.Append(type switch
                {
                    SerializedObjectParserType.U64 => (*(ulong*)elem).ToString(),
                    SerializedObjectParserType.U32 => (*(uint*)elem).ToString(),
                    SerializedObjectParserType.U16 => (*(ushort*)elem).ToString(),
                    SerializedObjectParserType.U8 => (*elem).ToString(),
                    SerializedObjectParserType.S64 => (*(long*)elem).ToString(),
                    SerializedObjectParserType.S32 => (*(int*)elem).ToString(),
                    SerializedObjectParserType.S16 => (*(short*)elem).ToString(),
                    SerializedObjectParserType.S8 => (*(sbyte*)elem).ToString(),
                    SerializedObjectParserType.F64 => (*(double*)elem).ToString("F16"),
                    SerializedObjectParserType.F32 => (*(float*)elem).ToString("F8"),
                    SerializedObjectParserType.Bool => (*elem != 0) ? "true" : "false", // TODO are bool arrays bitpacked?
                    SerializedObjectParserType.Char => Convert.ToChar(*(elem)).ToString(),
                    _ => string.Empty
                });

                sb.Append(separator);
            }

            return end != readLength;
        });

        if (sb.Length != 0) // remove trailing seperator
        {
            sb.Remove(sb.Length - separator.Length, separator.Length);
        }

        return sb.ToString();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public string ReadString(
        in SerializedObjectParserNode node,
        int stringLength,
        int readLength = -1)
    {
        Debug.Assert(node.Type == SerializedObjectParserType.String);
        PrepareForRead();
        return _reader.ReadString(readLength != -1 ? Math.Min(stringLength, readLength) : stringLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void ReadPrimitive(
        in SerializedObjectParserNode node,
        Span<byte> buffer)
    {
        Debug.Assert(node.IsPrimitive);
        Debug.Assert(node.Size is 1 or 2 or 4 or 8);
        Debug.Assert(buffer.Length >= node.Size);

        PrepareForRead();
        ReadPrimitiveInternal(buffer[..node.Size]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public string ReadPrimitiveAsString(in SerializedObjectParserNode node) => node.Type switch
    {
        SerializedObjectParserType.U64 => ReadU64(node).ToString(),
        SerializedObjectParserType.U32 => ReadU32(node).ToString(),
        SerializedObjectParserType.U16 => ReadU16(node).ToString(),
        SerializedObjectParserType.U8 => ReadU8(node).ToString(),
        SerializedObjectParserType.S64 => ReadS64(node).ToString(),
        SerializedObjectParserType.S32 => ReadS32(node).ToString(),
        SerializedObjectParserType.S16 => ReadS16(node).ToString(),
        SerializedObjectParserType.S8 => ReadS8(node).ToString(),
        SerializedObjectParserType.F64 => ReadF64(node).ToString("F16"),
        SerializedObjectParserType.F32 => ReadF32(node).ToString("F8"),
        SerializedObjectParserType.Bool => ReadBool(node) ? "true" : "false",
        SerializedObjectParserType.Char => ReadChar(node).ToString(),
        _ => string.Empty
    };

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private void ReadPrimitiveInternal(
        Span<byte> buffer)
    {
        Debug.Assert(buffer.Length is 1 or 2 or 4 or 8);

        switch (buffer.Length)
        {
            case 8: _reader.ReadSwap64(buffer); break;
            case 4: _reader.ReadSwap32(buffer); break;
            case 2: _reader.ReadSwap16(buffer); break;
            case 1: _reader.ReadBytes(buffer); break;
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private void PrepareForRead() => _reader.SeekStart(_objectOffset + _dataOffset);

    private readonly EndianBinaryReader _reader;
    private readonly SerializedObjectParserType _type;
    private readonly int _objectOffset;
    private readonly int _dataOffset;
    private readonly int _dataOffsetEnd;
}
