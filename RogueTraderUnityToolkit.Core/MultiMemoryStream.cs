using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace RogueTraderUnityToolkit.Core;

public interface IRelocatableMemoryRegion
{
    int BaseAddress { get; }
    int Offset { get; }
    int Length { get; }

    ReadOnlyMemory<byte> Acquire();
    void Release();
    IRelocatableMemoryRegion Slice(int offset, int length);
}

public sealed class MultiMemoryStream : Stream
{
    public IReadOnlyList<IRelocatableMemoryRegion> Regions => _regions;

    public MultiMemoryStream(IRelocatableMemoryRegion[] regions)
    {
        _regions = regions;
        _length = regions.Sum(x => x.Length);

        Debug.Assert(_regions.Length > 0);
        Debug.Assert(Length > 0);
    }

    public override bool CanRead => true;
    public override bool CanSeek => true;
    public override bool CanWrite => false;
    public override long Length => _length;

    public override long Position
    {
        get => _offset;
        set => _offset = (int)value;
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public override int Read(Span<byte> buffer)
    {
        // Hot path: In most cases, we'll already have prefetched the region we're reading, and the read won't cross it's boundaries.
        // We do a quick check here, and if that's the case, we read from the region and early return.

        int totalBytesToRead = buffer.Length;
        Debug.Assert(Position + totalBytesToRead <= Length);

        if (_offset >= _primedRegionOffset &&
            _offset + totalBytesToRead <= _primedRegionOffset + _primedRegionLength)
        {
            int regionOffset = _offset - _primedRegionOffset;
            _primedRegionMemory.Span.Slice(regionOffset, totalBytesToRead).CopyTo(buffer);
            _offset += totalBytesToRead;
            return totalBytesToRead;
        }

        // Cold path: Loop through every region, find the one we must read, prime it, and then read. Can read across region boundaries.
        // TODO: We might be able to further optimize for sequential reads by starting at the most recent region, and doing the earlier ones last.

        return ReadCold(buffer);
    }

    public override int Read(byte[] buffer, int offset, int count)
        => Read(buffer.AsSpan(offset, count));

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public MultiMemoryStream Slice(int offset, int length)
    {
        Debug.Assert(offset >= 0);
        Debug.Assert(length > 0);

        List<IRelocatableMemoryRegion> slicedRegions = [];

        int currentPosition = 0;
        int end = offset + length;
        Debug.Assert(end <= _length);

        foreach (IRelocatableMemoryRegion region in _regions)
        {
            int regionEnd = currentPosition + region.Length;

            if (regionEnd > offset && currentPosition < end)
            {
                int sliceStart = Math.Max(offset - currentPosition, 0);
                int sliceEnd = Math.Min(end - currentPosition, region.Length);
                int sliceLength = sliceEnd - sliceStart;

                slicedRegions.Add(region.Slice(sliceStart, sliceLength));
            }

            currentPosition += region.Length;

            if (currentPosition >= end) break;
        }

        return new([.. slicedRegions]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public MultiMemoryStream Slice(long offset, long length) => Slice((int)offset, (int)length);

    public override void Flush() { }

    public override long Seek(long offset, SeekOrigin origin)
    {
        long newPos = origin switch
        {
            SeekOrigin.Begin => offset,
            SeekOrigin.Current => _offset + offset,
            SeekOrigin.End => Length + offset,
            _ => throw new ArgumentException("Invalid SeekOrigin", nameof(origin))
        };

        _offset = (int)newPos;
        return newPos;
    }

    public override void SetLength(long value) => throw new NotImplementedException();

    public override void Write(byte[] buffer, int offset, int count) => throw new NotImplementedException();

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            _primedRegion?.Release();
            _primedRegion = null;
            _primedRegionMemory = null;
        }

        base.Dispose(disposing);
    }

    private readonly IRelocatableMemoryRegion[] _regions;
    private readonly int _length;
    private int _offset;
    private IRelocatableMemoryRegion? _primedRegion;
    private ReadOnlyMemory<byte> _primedRegionMemory;
    private int _primedRegionOffset;
    private int _primedRegionLength;

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    private int ReadCold(Span<byte> buffer)
    {
        int totalBytesToRead = buffer.Length;
        int totalBytesRead = 0;
        int positionInStream = 0;

        foreach (IRelocatableMemoryRegion region in _regions)
        {
            if (positionInStream + region.Length <= _offset)
            {
                positionInStream += region.Length;
                continue;
            }

            if (_offset >= positionInStream && totalBytesRead < totalBytesToRead)
            {
                int regionOffset = (_offset - positionInStream);
                int bytesToRead = Math.Min(region.Length - regionOffset, totalBytesToRead - totalBytesRead);

                ReadOnlySpan<byte> from = FetchForRead(region, positionInStream).Span.Slice(regionOffset, bytesToRead);
                Span<byte> to = buffer.Slice(totalBytesRead, bytesToRead);
                from.CopyTo(to);

                totalBytesRead += bytesToRead;
                _offset += bytesToRead;
            }

            if (totalBytesRead == totalBytesToRead) break;

            positionInStream += region.Length;
        }

        Debug.Assert(totalBytesRead == totalBytesToRead);

        return totalBytesRead;
    }

    private ReadOnlyMemory<byte> FetchForRead(IRelocatableMemoryRegion region, int regionStreamOffset)
    {
        if (region != _primedRegion)
        {
            _primedRegion?.Release();
            _primedRegion = region;
            _primedRegionMemory = region.Acquire();
            _primedRegionOffset = regionStreamOffset;
            _primedRegionLength = _primedRegion.Length;
        }

        // Note: always keeps the most recently used page pinned, which helps a lot with contention for many small reads
        Debug.Assert(_primedRegion != null);
        return _primedRegionMemory;
    }

    public override string ToString() => $"{Length} over {_regions.Length} regions";
}
