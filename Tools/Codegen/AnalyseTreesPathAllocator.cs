using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Codegen;

public class AnalyseTreesPathAllocator
{
    public AnalyseTreesPathAllocator()
    {
        Debug.Assert(_chunkSize < 65535); // max offset
        AllocateNewChunk();
    }

    public AnalyseTreesAllocation Rent(int size)
    {
        Debug.Assert(size <= _allocAlign);
        
        if (!_freeList.TryPop(out AnalyseTreesMemoryHandle handle))
        {
            if (_chunkOffset * _allocAlign + _allocAlign > _chunkSize)
            {
                AllocateNewChunk();
            }

            handle = new(_chunkIdx, _chunkOffset++);
        }
        
#if DEBUG
        ++_rented;
        _rentedElements += size;
#endif

        int offset = handle.ChunkOffset * _allocAlign;
        return new(_chunks[handle.ChunkIdx].AsMemory().Slice(offset, size), handle);
    }

    public void Return(AnalyseTreesMemoryHandle handle)
    {
        _freeList.Push(handle);
        
#if DEBUG
        ++_returned;
#endif
    }
    
    private const int _targetChunkSize = 128 * 1024; // this'll get us into the LOH
    private const int _allocAlign = 24; // max path length
    
    private readonly int _chunkSize = _targetChunkSize / Marshal.SizeOf<AnalyseTreesNodePathEntry>();
    
    private readonly List<AnalyseTreesNodePathEntry[]> _chunks = [];
    private readonly Stack<AnalyseTreesMemoryHandle> _freeList = [];

    private ushort _chunkIdx = 0xFFFF;
    private ushort _chunkOffset;

#if DEBUG
    private int _rented;
    private int _rentedElements;
    private int _returned;

    private float AverageAllocSize => (float)_rentedElements / _rented;
    private float OverheadPercent => (1.0f - (float)_rentedElements / _rented / _allocAlign) * 100;
#endif
    
    private void AllocateNewChunk()
    {
        ++_chunkIdx;
        _chunkOffset = 0;
        _chunks.Add(new AnalyseTreesNodePathEntry[_chunkSize]);
    }
    
#if DEBUG
    public override string ToString() => $"{AverageAllocSize:F1} avg {OverheadPercent:F1}% overhead";
#endif
}

public readonly record struct AnalyseTreesAllocation(
    Memory<AnalyseTreesNodePathEntry> Memory,
    AnalyseTreesMemoryHandle Handle)
{
    public int Length => Memory.Length;
    
    public AnalyseTreesAllocation Slice(int offset) =>
        this with { Memory = Memory[offset..] };
    
    public AnalyseTreesAllocation Slice(int offset, int length) =>
        this with { Memory = Memory.Slice(offset, length) };

    public Span<AnalyseTreesNodePathEntry> Span => Memory.Span;
    
    public AnalyseTreesNodePathEntry this[int idx]
    {
        get => Span[idx];
        set => Span[idx] = value;
    }
}

public readonly record struct AnalyseTreesMemoryHandle(
    ushort ChunkIdx,
    ushort ChunkOffset);