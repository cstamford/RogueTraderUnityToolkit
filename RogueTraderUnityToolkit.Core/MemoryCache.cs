using System.Diagnostics;

namespace RogueTraderUnityToolkit.Core;

public interface IMemoryCacheLoader
{
    ReadOnlyMemory<byte> Load();

    void Unload();
}

public static class MemoryCache
{
    public static IRelocatableMemoryRegion Register(
        IMemoryCacheLoader loader, int length, int baseAddress)
    {
        int id = Interlocked.Increment(ref _nextId);
        _cache.Add(id, () => new(loader), length);
        return new Region(id, 0, length, baseAddress);
    }

    private static readonly LruCache<int, MemoryCacheData> _cache = new(1024*1024*1024);
    private static int _nextId;

    public struct Region(int id, int offset, int length, int baseAddress) : IRelocatableMemoryRegion
    {
        public readonly int BaseAddress => baseAddress;
        public readonly int Offset => offset;
        public readonly int Length => length;

        public ReadOnlyMemory<byte> Acquire()
        {
            Debug.Assert(_pinCount == 0);
            _pinCount++;
            _data ??= _cache.Pin(id, out int _);
            return _data.Value.Memory.Slice(offset, length);
        }

        public void Release()
        {
            if (--_pinCount > 0) return;
            _cache.Unpin(id);
            _data = null;
        }

        public readonly IRelocatableMemoryRegion Slice(int newOffset, int newLength)
        {
            if (newOffset == 0 && newLength == Length) return this;
            Debug.Assert(newOffset + newLength <= Length);
            return new Region(id, offset + newOffset, newLength, baseAddress);
        }

        public override readonly string ToString() => $"0x{baseAddress+offset} -> 0x{baseAddress+offset+length} " +
                                                      $"{_data.ToString() ?? "(no data loaded)"}";

        private MemoryCacheData? _data = null;
        private int _pinCount = 0;
    }
}

public readonly struct MemoryCacheData(IMemoryCacheLoader loader) : IDisposable
{
    public ReadOnlyMemory<byte> Memory { get; } = loader.Load();
    public void Dispose() => loader.Unload();

    public override string? ToString() => loader.ToString()!;
}
