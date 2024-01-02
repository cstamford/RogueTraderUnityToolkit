using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Codegen;

public class TreePathAllocator
{
    public TreePathAllocator()
    {
        Debug.Assert(_chunkSize < 65535); // max offset
        AllocateNewChunk();
    }

    public TreePathAllocation Rent(int size)
    {
        Debug.Assert(size <= _allocStride, $"Size {size} mismatched with stride {_allocStride}");

        if (!_freeList.TryPop(out TreePathMemoryHandle handle))
        {
            if (_chunkOffset * _allocStride + _allocStride > _chunkSize)
            {
                AllocateNewChunk();
            }

            handle = new(_chunkIdx, _chunkOffset++);
        }

        ++_rented;
        _rentedElements += size;

        int offset = handle.ChunkOffset * _allocStride;
        return new(_chunks[handle.ChunkIdx].AsMemory().Slice(offset, size), handle);
    }

    public void Return(TreePathMemoryHandle handle)
    {
        ++_returned;
        Debug.Assert(_returned <= _rented);
        _freeList.Push(handle);
    }

    private const int _targetChunkSize = 128 * 1024; // this'll get us into the LOH
    private const int _allocStride = 32; // max path length

    private readonly int _chunkSize = _targetChunkSize / Marshal.SizeOf<TreePathEntry>();

    private readonly List<TreePathEntry[]> _chunks = [];
    private readonly Stack<TreePathMemoryHandle> _freeList = [];

    private ushort _chunkIdx = 0xFFFF;
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
    private float OverheadPercent => (1.0f - (float)_rentedElements / _rented / _allocStride) * 100;

    public override string ToString() => $"{AverageAllocSize:F1} avg {OverheadPercent:F1}% overhead";
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

public readonly record struct TreePathMemoryHandle(ushort ChunkIdx, ushort ChunkOffset);
