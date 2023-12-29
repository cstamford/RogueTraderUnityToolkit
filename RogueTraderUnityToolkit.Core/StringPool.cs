using NeoSmart.Hashing.XXHash;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace RogueTraderUnityToolkit.Core;

public static class StringPool
{
    static StringPool()
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
    public static Entry Fetch(ReadOnlyMemory<byte> memory)
    {
        MemoryBytesHasher hasher = new(memory);
        int length = memory.Length;

        if (Optimization_SelectCommonString(hasher.GetHashCode(), length, out Entry optimizedString))
        {
            return optimizedString;
        }
        
        if (memory.Length > _blockEndIndex || _currentBlockIndex == _blockEndIndex)
        {
            return _pool.GetOrAdd(hasher, static (hash, mem) =>
            {
                int id = Interlocked.Increment(ref _currentLargeStringId);

                byte blockIdx = (byte)(id & 0xFF);
                byte blockData = 255;
                ushort blockOffset = (ushort)(id >> 8);

                byte[] memoryCopy = mem.ToArray();
                hash.UpdatePointer(memoryCopy);

                Entry entry = new(blockIdx, blockData, blockOffset);
                _largeStrings[entry] = memoryCopy;

                return entry;
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
            hash.UpdatePointer(block);

            return new(blockIdx, blockData, blockOffset);
        }, memory);
    }

    public static Entry Fetch(string str) => Fetch(Encoding.ASCII.GetBytes(str));

    public readonly record struct Entry(
        byte BlockIdx,
        byte BlockData,
        ushort BlockOffset)
        : IEquatable<string>
    {
        public int Length => GetEntryLength(this);
        public ReadOnlyMemory<byte> Bytes => GetEntryBytes(this);
        public string String => GetEntryString(this); // WARNING: Allocates every time!

        public static bool operator ==(Entry entry, string? str) => Equals(entry, str);
        public static bool operator !=(Entry entry, string? str) => !Equals(entry, str);
        public bool Equals(string? str) => Equals(this, str);

        private static unsafe bool Equals(Entry lhs, string? rhs)
        {
            if (string.IsNullOrEmpty(rhs)) return false;
            if (lhs.Length != rhs.Length) return false;

            fixed (char* rhsPtr = rhs)
            {
                ReadOnlySpan<byte> lhsSpan = lhs.Bytes.Span;
                ReadOnlySpan<byte> rhsSpan = MemoryMarshal.AsBytes(new ReadOnlySpan<char>(rhsPtr, rhs.Length));
                
                for (int i = 0; i < lhsSpan.Length; i++)
                {
                    byte l = lhsSpan[i]; // ascii
                    byte r = rhsSpan[i * 2]; // utf16
                    if (l != r) return false;
                }

                return true;
            }
        }
    }

    private static readonly ConcurrentDictionary<MemoryBytesHasher, Entry> _pool = [];
    private static readonly Memory<byte>[] _smallStringBlocks = [];
    private static readonly SemaphoreSlim _smallStringBlocksLock = new(1, 1);
    private static readonly ConcurrentDictionary<Entry, Memory<byte>> _largeStrings = [];
    private static readonly Memory<byte>[] _optimizedStrings;
    
    private static int _currentBlockIndex;
    private static int _currentBlockOffset;
    private static int _currentLargeStringId;
    private const int _blockSize = 65535;
    
    private const int _blockEndIndex = 250;
    private const int _blockIsOptimizedString = 254;
    private const int _blockIsLargeString = 255;

    private static int GetEntryLength(Entry entry) => entry.BlockData switch
    {
        _blockIsOptimizedString => _optimizedStrings[entry.BlockIdx].Length,
        _blockIsLargeString => GetEntryString(entry).Length,
        _ => entry.BlockData
    };
    
    private static string GetEntryString(Entry entry)
    {
        ReadOnlyMemory<byte> bytes = GetEntryBytes(entry);
        return Encoding.ASCII.GetString(bytes.Span);
    }

    private static ReadOnlyMemory<byte> GetEntryBytes(Entry entry) => entry.BlockData switch
    {
        _blockIsOptimizedString => _optimizedStrings[entry.BlockIdx],
        _blockIsLargeString => _largeStrings[entry],
        _ => _smallStringBlocks[entry.BlockIdx].Slice(entry.BlockOffset, entry.BlockData)
    };
    
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    private static bool Optimization_SelectCommonString(int hash, int length, out Entry entry)
    {
        switch (hash)
        {
            case 253518702: // "int"
                Debug.Assert(length == 3);
                entry = new(0, _blockIsOptimizedString, 0);
                return true;
        
            case -1533643913: // "float"
                Debug.Assert(length == 5);
                entry = new(1, _blockIsOptimizedString, 0);
                return true;

            case -1590466247: // "Array"
                Debug.Assert(length == 5);
                entry = new(2, _blockIsOptimizedString, 0);
                return true;
        
            case 46947589: // ""
                Debug.Assert(length == 0);
                entry = new(3, _blockIsOptimizedString, 0);
                return true;

            case 928651816: // "size"
                Debug.Assert(length == 4);
                entry = new(4, _blockIsOptimizedString, 0);
                return true;

            case 555911733: // "data"
                Debug.Assert(length == 4);
                entry = new(5, _blockIsOptimizedString, 0);
                return true;

            case -1583801780: // "UInt8"
                Debug.Assert(length == 5);
                entry = new(6, _blockIsOptimizedString, 0);
                return true;

            case -1101600518: // "SInt64"
                Debug.Assert(length == 6);
                entry = new(7, _blockIsOptimizedString, 0);
                return true;

            case -1598688481: // "m_PathID"
                Debug.Assert(length == 8);
                entry = new(8, _blockIsOptimizedString, 0);
                return true;

            case 1282957373: // "m_FileID"
                Debug.Assert(length == 8);
                entry = new(9, _blockIsOptimizedString, 0);
                return true;
        }

        entry = default;
        return false;
    }
    
    private sealed class MemoryBytesHasher(
        ReadOnlyMemory<byte> memory) 
        : IEquatable<MemoryBytesHasher>
    {
        public bool Equals(MemoryBytesHasher? rhs) => rhs != null && _memory.Span.SequenceEqual(rhs._memory.Span);
        public override bool Equals(object? obj) => obj is MemoryBytesHasher other && Equals(other);
        public override int GetHashCode() => _hashCode;
        
        public void UpdatePointer(ReadOnlyMemory<byte> memory)
        {
            Debug.Assert((int)XXHash32.Hash(memory.Span) == _hashCode);
            _memory = memory;
        }
        
        private ReadOnlyMemory<byte> _memory = memory;
        private readonly int _hashCode = (int)XXHash32.Hash(memory.Span);
    }
}
