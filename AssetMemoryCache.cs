using RogueTraderUnityToolkit.Helper;
using System.Diagnostics;

namespace RogueTraderUnityToolkit;

public interface IAssetMemoryCacheLoader
{
    ReadOnlyMemory<byte> Load();

    void Unload();
}

public static class AssetMemoryCache
{
    public static IRelocatableMemoryRegion Register(
        IAssetMemoryCacheLoader loader, int length, int baseAddress)
    {
        int id = Interlocked.Increment(ref _nextId);
        _cache.Add(id, () => new(loader), length);
        return new Region(id, 0, length, baseAddress);
    }

    private readonly static LruCache<int, AssetMemoryCacheData> _cache = new(Options.MemoryCacheLimit);
    private static int _nextId = 0;

    public struct Region(int id, int offset, int length, int baseAddress) : IRelocatableMemoryRegion
    {
        public readonly int BaseAddress => baseAddress;
        public readonly int Offset => offset;
        public readonly int Length => length;

        public ReadOnlyMemory<byte> Acquire()
        {
            int count = Interlocked.Increment(ref _pinCount);
            Debug.Assert(count == 1);
            AssetMemoryCacheData data = _cache.Pin(id);
            return data.Memory.Slice(offset, length);
        }

        public void Release()
        {
            int count = Interlocked.Decrement(ref _pinCount);
            Debug.Assert(count == 0);
            _cache.Unpin(id);
        }

        public readonly IRelocatableMemoryRegion Slice(int newOffset, int newLength)
        {
            if (newOffset == 0 && newLength == Length) return this;
            Debug.Assert(newOffset + newLength <= Length);
            return new Region(id, offset + newOffset, newLength, baseAddress);
        }

        public readonly override string ToString() => $"0x{baseAddress+offset} -> 0x{baseAddress+offset+length} length:{length} id:{id}";

        private int _pinCount = 0;
    }
}

public struct AssetMemoryCacheData(IAssetMemoryCacheLoader loader) : IDisposable
{
    public ReadOnlyMemory<byte> Memory { get; } = loader.Load();
    public readonly void Dispose() => loader.Unload();
}
