using System.Diagnostics;
using System.Runtime.InteropServices;

namespace RogueTraderUnityToolkit.Tree;

public class TreePathAllocator
{
    public TreePathAllocation Rent(int size) => size switch
    {
        <= 4 => _alloc4.Rent(size),
        <= 8 => _alloc8.Rent(size),
        <= 16 => _alloc16.Rent(size),
        <= 32 => _alloc32.Rent(size),
        _ => throw new()
    };

    public void Return(TreePathMemoryHandle handle)
    {
        switch (handle.GroupIdx)
        {
            case 4: _alloc4.Return(handle); return;
            case 8: _alloc8.Return(handle); return;
            case 16: _alloc16.Return(handle); return;
            case 32: _alloc32.Return(handle); return;
            default: throw new();
        }
    }

    private readonly TreePathAllocatorGroup _alloc4 = new(4);
    private readonly TreePathAllocatorGroup _alloc8 = new(8);
    private readonly TreePathAllocatorGroup _alloc16 = new(16);
    private readonly TreePathAllocatorGroup _alloc32 = new(32);

    public override string ToString() => $"4: {_alloc4}\n" +
                                         $"8: {_alloc8}\n" +
                                         $"16: {_alloc16}\n" +
                                         $"32: {_alloc32}";
}

public class TreePathAllocatorGroup
{
    public TreePathAllocatorGroup(byte allocationSize)
    {
        _allocationSize = allocationSize;
        Debug.Assert(_chunkSize < 65535); // max offset
        AllocateNewChunk();
    }

    public TreePathAllocation Rent(int size)
    {
        Debug.Assert(size <= _allocationSize, $"Size {size} mismatched with stride {_allocationSize}");

        if (!_freeList.TryPop(out TreePathMemoryHandle handle))
        {
            if (_chunkOffset * _allocationSize + _allocationSize > _chunkSize)
            {
                AllocateNewChunk();
            }

            handle = new(_allocationSize, _chunkIdx, _chunkOffset++);
        }

        ++_rented;
        _rentedElements += size;

        int offset = handle.ChunkOffset * _allocationSize;
        return new(_chunks[handle.ChunkIdx].AsMemory().Slice(offset, size), handle);
    }

    public void Return(TreePathMemoryHandle handle)
    {
        ++_returned;
        Debug.Assert(_returned <= _rented);
        _freeList.Push(handle);
    }

    private const int _targetChunkSize = 128 * 1024;
    private readonly int _chunkSize = _targetChunkSize / Marshal.SizeOf<TreePathEntry>();
    private readonly byte _allocationSize;

    private readonly List<TreePathEntry[]> _chunks = [];
    private readonly Stack<TreePathMemoryHandle> _freeList = [];

    private byte _chunkIdx = 0xFF;
    private ushort _chunkOffset;

    private int _rented;
    private int _rentedElements;
    private int _returned;

    private void AllocateNewChunk()
    {
        ++_chunkIdx;
        _chunkOffset = 0;
        _chunks.Add(new TreePathEntry[_chunkSize]);
    }

    private float AverageAllocSize => (float)_rentedElements / _rented;
    private float OverheadPercent => (1.0f - (float)_rentedElements / _rented / _allocationSize) * 100;

    public override string ToString() => $"{_chunks.Count} / {AverageAllocSize:F1} / {OverheadPercent:F1}%";
}

public readonly record struct TreePathAllocation(
    Memory<TreePathEntry> Memory,
    TreePathMemoryHandle Handle)
{
    public int Length => Memory.Length;

    public TreePathAllocation Slice(int offset) =>
        this with { Memory = Memory[offset..] };

    public TreePathAllocation Slice(int offset, int length) =>
        this with { Memory = Memory.Slice(offset, length) };

    public Span<TreePathEntry> Span => Memory.Span;

    public TreePathEntry this[int idx]
    {
        get => Span[idx];
        set => Span[idx] = value;
    }
}

public readonly record struct TreePathMemoryHandle(
    byte GroupIdx,
    byte ChunkIdx,
    ushort ChunkOffset);
