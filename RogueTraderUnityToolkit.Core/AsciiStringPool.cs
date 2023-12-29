using NeoSmart.Hashing.XXHash;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace RogueTraderUnityToolkit.Core;

public static class AsciiStringPool
{
    static AsciiStringPool()
    {
        _smallStringBlocks = new Memory<byte>[_blockEndIndex + 1];
        
        for (int i = 0; i < _smallStringBlocks.Length; ++i)
        {
            _smallStringBlocks[i] = new byte[_blockSize];
        }

        _optimizedStrings = [
            "int"u8.ToArray(),
            "float"u8.ToArray(),
            "Array"u8.ToArray(),
            ""u8.ToArray(), // Empty string
            "size"u8.ToArray(),
            "data"u8.ToArray(),
            "UInt8"u8.ToArray(),
            "SInt64"u8.ToArray(),
            "m_PathID"u8.ToArray(),
            "m_FileID"u8.ToArray(),
        ];
    }
    
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public static AsciiString Fetch(ReadOnlyMemory<byte> memory)
    {
        MemoryBytesHasher hasher = new(memory);
        int length = memory.Length;

        if (Optimization_SelectCommonString(hasher.GetHashCode(), length, out AsciiString optimizedString))
        {
            return optimizedString;
        }
        
        if (memory.Length > _blockEndIndex || _currentBlockIndex == _blockEndIndex)
        {
            return _pool.GetOrAdd(hasher, static (hash, mem) =>
            {
                int id = Interlocked.Increment(ref _currentLargeStringId);

                byte blockIdx = (byte)(id & 0xFF);
                byte blockData = _blockIsLargeString;
                ushort blockOffset = (ushort)(id >> 8);

                byte[] memoryCopy = mem.ToArray();
                hash.Memory = memoryCopy;

                AsciiString asciiString = new(blockIdx, blockData, blockOffset);
                _largeStrings[asciiString] = memoryCopy;

                return asciiString;
            }, memory);
        }
        
        return _pool.GetOrAdd(hasher, static (hash, mem) =>
        {
            _smallStringBlocksLock.Wait();
            
            Debug.Assert(_currentBlockIndex <= _blockEndIndex);
            
            if (_currentBlockOffset + mem.Length > _blockSize)
            {
                ++_currentBlockIndex;
                _currentBlockOffset = 0;
            }
            
            byte blockIdx = (byte)_currentBlockIndex;
            byte blockData = (byte)mem.Length;
            ushort blockOffset = (ushort)_currentBlockOffset;
            _currentBlockOffset += mem.Length;
            
            _smallStringBlocksLock.Release();

            Memory<byte> block = _smallStringBlocks[blockIdx].Slice(blockOffset, mem.Length);
            mem.CopyTo(block);
            hash.Memory = block;

            return new(blockIdx, blockData, blockOffset);
        }, memory);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int GetLength(in AsciiString asciiString) => asciiString.BlockData switch
    {
        _blockIsOptimizedString => _optimizedStrings[asciiString.BlockIdx].Length,
        _blockIsLargeString => GetCSharpString(asciiString).Length,
        _ => asciiString.BlockData
    };
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ReadOnlyMemory<byte> GetBytes(in AsciiString asciiString) => asciiString.BlockData switch
    {
        _blockIsOptimizedString => _optimizedStrings[asciiString.BlockIdx],
        _blockIsLargeString => _largeStrings[asciiString],
        _ => _smallStringBlocks[asciiString.BlockIdx].Slice(asciiString.BlockOffset, asciiString.BlockData)
    };
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string GetCSharpString(in AsciiString asciiString)
    {
        ReadOnlyMemory<byte> bytes = GetBytes(asciiString);
        return Encoding.ASCII.GetString(bytes.Span);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsSmallBlockString(in AsciiString asciiString) =>
        asciiString.BlockData <= _blockEndIndex;
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOptimizedString(in AsciiString asciiString) =>
        asciiString.BlockData == _blockIsOptimizedString;
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLargeString(in AsciiString asciiString) =>
        asciiString.BlockData == _blockIsLargeString;

    private static readonly ConcurrentDictionary<MemoryBytesHasher, AsciiString> _pool = [];
    private static readonly Memory<byte>[] _smallStringBlocks;
    private static readonly SemaphoreSlim _smallStringBlocksLock = new(1, 1);
    private static readonly ConcurrentDictionary<AsciiString, Memory<byte>> _largeStrings = [];
    private static readonly Memory<byte>[] _optimizedStrings;
    
    private static int _currentBlockIndex;
    private static int _currentBlockOffset;
    private static int _currentLargeStringId;
    private const int _blockSize = 65535;
    
    private const int _blockEndIndex = 250;
    private const int _blockIsOptimizedString = 254;
    private const int _blockIsLargeString = 255;
    
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    private static bool Optimization_SelectCommonString(int hash, int length, out AsciiString asciiString)
    {
        switch (hash)
        {
            case 253518702: // "int"
                Debug.Assert(length == 3);
                asciiString = new(0, _blockIsOptimizedString, 0);
                return true;
        
            case -1533643913: // "float"
                Debug.Assert(length == 5);
                asciiString = new(1, _blockIsOptimizedString, 0);
                return true;

            case -1590466247: // "Array"
                Debug.Assert(length == 5);
                asciiString = new(2, _blockIsOptimizedString, 0);
                return true;
        
            case 46947589: // ""
                Debug.Assert(length == 0);
                asciiString = new(3, _blockIsOptimizedString, 0);
                return true;

            case 928651816: // "size"
                Debug.Assert(length == 4);
                asciiString = new(4, _blockIsOptimizedString, 0);
                return true;

            case 555911733: // "data"
                Debug.Assert(length == 4);
                asciiString = new(5, _blockIsOptimizedString, 0);
                return true;

            case -1583801780: // "UInt8"
                Debug.Assert(length == 5);
                asciiString = new(6, _blockIsOptimizedString, 0);
                return true;

            case -1101600518: // "SInt64"
                Debug.Assert(length == 6);
                asciiString = new(7, _blockIsOptimizedString, 0);
                return true;

            case -1598688481: // "m_PathID"
                Debug.Assert(length == 8);
                asciiString = new(8, _blockIsOptimizedString, 0);
                return true;

            case 1282957373: // "m_FileID"
                Debug.Assert(length == 8);
                asciiString = new(9, _blockIsOptimizedString, 0);
                return true;
        }

        asciiString = default;
        return false;
    }
    
    private record class MemoryBytesHasher 
    {
        public ReadOnlyMemory<byte> Memory
        {
            set
            {
                Debug.Assert((int)XXHash32.Hash(value.Span) == _hash);
                _memory = value;
            }
        }
        
        public MemoryBytesHasher(ReadOnlyMemory<byte> memory)
        {
            _memory = memory;
            _hash = (int)XXHash32.Hash(memory.Span);
        }

        public virtual bool Equals(MemoryBytesHasher? rhs) =>
            rhs != null &&
            _hash == rhs._hash &&
            _memory.Span.SequenceEqual(rhs._memory.Span);

        public override int GetHashCode() => _hash;

        private ReadOnlyMemory<byte> _memory;
        private readonly int _hash;
    }
}
