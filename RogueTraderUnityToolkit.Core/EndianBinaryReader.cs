using System.Buffers;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace RogueTraderUnityToolkit.Core;

public sealed class EndianBinaryReader(Stream stream, bool isBigEndian = true)
{
    public EndianBinaryReader(Stream stream, int offset, int length, bool isBigEndian = true)
        : this(stream, isBigEndian)
    {
        _offset = offset;
        _length = length;
        _stream.Position = _stream.Position; // applies offset
    }

    public int Position
    {
        get => (int)_stream.Position - _offset;
        set => _stream.Position = value + _offset;
    }

    public int Length => _length >= 0 ? _length : (int)_stream.Length;
    public int Remaining => Length - Position;
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe ulong ReadU64()
    {
        ulong value;
        int bytesRead = _stream.Read(new(&value, 8));
        Debug.Assert(bytesRead == 8);
        return _needsEndianSwap ? EndianSwap.Swap(value) : value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe uint ReadU32()
    {
        uint value;
        int bytesRead = _stream.Read(new(&value, 4));
        Debug.Assert(bytesRead == 4);
        return _needsEndianSwap ? EndianSwap.Swap(value) : value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe ushort ReadU16()
    {
        ushort value;
        int bytesRead = _stream.Read(new(&value, 2));
        Debug.Assert(bytesRead == 2);
        return _needsEndianSwap ? EndianSwap.Swap(value) : value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe byte ReadU8()
    {
        byte value;
        int bytesRead = _stream.Read(new(&value, 1));
        Debug.Assert(bytesRead == 1);
        return value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe long ReadS64()
    {
        long value;
        int bytesRead = _stream.Read(new(&value, 8));
        Debug.Assert(bytesRead == 8);
        return _needsEndianSwap ? EndianSwap.Swap(value) : value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe int ReadS32()
    {
        int value;
        int bytesRead = _stream.Read(new(&value, 4));
        Debug.Assert(bytesRead == 4);
        return _needsEndianSwap ? EndianSwap.Swap(value) : value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe short ReadS16()
    {
        short value;
        int bytesRead = _stream.Read(new(&value, 2));
        Debug.Assert(bytesRead == 2);
        return _needsEndianSwap ? EndianSwap.Swap(value) : value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe sbyte ReadS8()
    {
        sbyte value;
        int bytesRead = _stream.Read(new(&value, 1));
        Debug.Assert(bytesRead == 1);
        return value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe double ReadF64()
    {
        double value;
        int bytesRead = _stream.Read(new(&value, 8));
        Debug.Assert(bytesRead == 8);
        return _needsEndianSwap ? EndianSwap.Swap(value) : value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe float ReadF32()
    {
        float value;
        int bytesRead = _stream.Read(new(&value, 4));
        Debug.Assert(bytesRead == 4);
        return _needsEndianSwap ? EndianSwap.Swap(value) : value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool ReadB32() => ReadB32(out uint _);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe bool ReadB32(out uint valueBytes)
    {
        uint value;
        int bytesRead = _stream.Read(new(&value, 4));
        Debug.Assert(bytesRead == 4);
        valueBytes = value;
        return value != 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool ReadB8() => ReadB8(out byte _);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe bool ReadB8(out byte valueByte)
    {
        byte value;
        int bytesRead = _stream.Read(new(&value, 1));
        Debug.Assert(bytesRead == 1);
        valueByte = value;
        return value != 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public StringPool.Entry ReadString(int len)
    {
        byte[] memory = ArrayPool<byte>.Shared.Rent(len);
        Memory<byte> memorySlice = memory.AsMemory()[..len];
        ReadBytes(memorySlice.Span);
        StringPool.Entry str = StringPool.Fetch(memorySlice);
        ArrayPool<byte>.Shared.Return(memory);
        return str;
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public StringPool.Entry ReadStringUntilNull()
    {
        const int blockSize = 32;
        Span<byte> scratch = stackalloc byte[blockSize];

        int startPos = Position;
        int stringLength = 0;

        while (true)
        {
            int bytesToRead = Math.Min(blockSize, Remaining);
            if (bytesToRead <= 0) break;

            Span<byte> scratchSlice = scratch[..bytesToRead];
            ReadBytes(scratchSlice);

            int nullIdx = Util.FastFindByte(0, scratchSlice);

            if (nullIdx != -1)
            {
                stringLength += nullIdx;
                break;
            }

            stringLength += bytesToRead;
        }

        Position = startPos;
        StringPool.Entry entry = ReadString(stringLength);
        Seek(1); // skip over the null terminator
        return entry;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe byte ReadByte()
    {
        byte value;
        int bytesRead = _stream.Read(new(&value, 1));
        Debug.Assert(bytesRead == 1);
        return value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int ReadBytes(Span<byte> span)
    {
        int bytesRead = _stream.Read(span);
        Debug.Assert(bytesRead == span.Length);
        return bytesRead;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int PeekBytes(Span<byte> span, int offset = 0)
    {
        int streamPos = Position;
        Seek(offset);
        int bytesRead = ReadBytes(span);
        Position = streamPos;
        return bytesRead;
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public unsafe void ReadSwap64(Span<byte> span)
    {
        Debug.Assert(span.Length == 8);

        byte* unaligned = stackalloc byte[16];
        byte* aligned = Memory.AlignTo(unaligned, 8);

        ReadBytes(new(aligned, 8));

        if (_needsEndianSwap) EndianSwap.Swap64(aligned);

        fixed (byte* dst = span)
        {
            Buffer.MemoryCopy(aligned, dst, span.Length, 8);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public unsafe void ReadSwap32(Span<byte> span)
    {
        Debug.Assert(span.Length == 4);

        byte* unaligned = stackalloc byte[8];
        byte* aligned = Memory.AlignTo(unaligned, 4);

        ReadBytes(new(aligned, 4));

        if (_needsEndianSwap) EndianSwap.Swap32(aligned);

        fixed (byte* dst = span)
        {
            Buffer.MemoryCopy(aligned, dst, span.Length, 4);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public unsafe void ReadSwap16(Span<byte> span)
    {
        Debug.Assert(span.Length == 2);

        byte* unaligned = stackalloc byte[4];
        byte* aligned = Memory.AlignTo(unaligned, 2);

        ReadBytes(new(aligned, 2));

        if (_needsEndianSwap) EndianSwap.Swap16(aligned);

        fixed (byte* dst = span)
        {
            Buffer.MemoryCopy(aligned, dst, span.Length, 2);
        }
    }

    public void Seek(int offset) => _stream.Seek(offset, SeekOrigin.Current);
    public void SeekStart(int offset) => _stream.Seek(offset, SeekOrigin.Begin);

    private readonly Stream _stream = stream;
    private readonly bool _needsEndianSwap = BitConverter.IsLittleEndian == isBigEndian;
    private readonly int _offset;
    private readonly int _length = -1;
    
    public override string ToString() => this.Dump();
}

public static class EndianBinaryReaderExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int AlignTo(this EndianBinaryReader reader, int alignment)
    {
        IntPtr unaligned = reader.Position;
        IntPtr aligned = Memory.AlignTo(unaligned, alignment);
        int skippedBytes = (int)(aligned - unaligned);
        reader.Seek(skippedBytes);
        return skippedBytes;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Guid ReadGuid(this EndianBinaryReader reader)
    {
        Span<byte> bytes = stackalloc byte[16];

        for (int i = 0; i < 16; i += 4)
        {
            reader.ReadSwap32(bytes.Slice(i, 4));
        }

        return new(bytes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static T[] ReadArray<T>(this EndianBinaryReader reader, Func<EndianBinaryReader, T> fnRead)
    {
        int len = reader.ReadS32();
        Debug.Assert(len >= 0);
        return ReadArray(reader, fnRead, len);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static T[] ReadArray<T>(this EndianBinaryReader reader, Func<EndianBinaryReader, T> fnRead, int len)
    {
        T[] values = new T[len];

        for (int i = 0; i < len; ++i)
        {
            values[i] = fnRead(reader);
        }

        return values;
    }

    // alias for Skip, to make it more explicit to the reader
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void UnknownData(this EndianBinaryReader reader, int len) => reader.Seek(len);
}
