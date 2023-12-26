using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace RogueTraderUnityToolkit.Helper;

public class LruCache<TKey, TValue>(int maxSize)
    where TKey : notnull
    where TValue : IDisposable
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Add(TKey key, Func<TValue> fnMakeValue, int valueSize)
    {
        using var _ = Util.PerfScopeDatabase("LruCache/Add");

        _data[key] = new(fnMakeValue, valueSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public TValue Pin(TKey key)
    {
        using var _ = Util.PerfScopeDatabase("LruCache/Pin");

        TValue value;

        while (!TryPin(key, out value!))
        {
            if (!TryGcOne())
            {
                //Thread.Sleep(1);
            }
        }

        TryGcOne();
        return value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Unpin(TKey key)
    {
        using var _ = Util.PerfScopeDatabase("LruCache/Unpin");

        _data[key].DecrementRefCount();
    }

    private readonly ConcurrentQueue<TKey> _lru = [];
    private readonly ConcurrentDictionary<TKey, CacheData> _data = [];
    private readonly ConcurrentQueue<TKey> _pendingUnpins = [];
    private int _residentSize;

    private class CacheData(Func<TValue> fnLoadValue, int valueSize)
    {
        public bool Loaded => _loaded;
        public bool Stale => _loaded && _refs == 0;
        public int RefCount => _refs;
        public TValue Value
        {
            get
            {
                Debug.Assert(_loaded);
                return _value!;
            }
        }
        public int ValueSize => valueSize;
        public ReaderWriterLockSlim Lock => _lock;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void IncrementRefCount() => Interlocked.Increment(ref _refs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DecrementRefCount() => Interlocked.Decrement(ref _refs);

        public void Load()
        {
            using var _ = Util.PerfScopeLRU("CacheData/Load");

            _lock.EnterWriteLock();
            LoadInternal();
            _lock.ExitWriteLock();
        }

        public bool TryGc()
        {
            bool succeeded = false;

            if (Stale && _lock.TryEnterWriteLock(0))
            {
                if (Stale)
                {
                    UnloadInternal();
                    succeeded = true;
                }

                _lock.ExitWriteLock();
            }

            return succeeded;
        }

        private int _refs = 0;
        private bool _loaded = false;
        private TValue? _value = default!;
        private readonly ReaderWriterLockSlim _lock = new();

        private void LoadInternal()
        {
            Debug.Assert(!_loaded);

            using var _ = Util.PerfScopeLRU("CacheData/LoadInternal");
            _value = fnLoadValue();
            _loaded = true;
        }

        private void UnloadInternal()
        {
            Debug.Assert(_loaded);

            using var _ = Util.PerfScopeLRU("CacheData/UnloadInternal");
            _value!.Dispose();
            _loaded = false;
        }

        public override string ToString() => $"{(!_loaded ? "Evicted" : _refs > 0 ? "!!PINNED!!" : "Resident")} {_refs} refs, {valueSize} bytes";
    }

    private bool TryPin(TKey key, out TValue? value)
    {
        CacheData data = _data[key];

        if (data.Lock.TryEnterUpgradeableReadLock(0))
        {
            data.IncrementRefCount();

            if (!data.Loaded)
            {
                data.Load();
                Interlocked.Add(ref _residentSize, data.ValueSize);
                _lru.Enqueue(key);
            }

            Debug.Assert(data.Loaded);
            Debug.Assert(data.RefCount > 0);

            value = data.Value;

            data.Lock.ExitUpgradeableReadLock();

            return true;
        }

        // if we can't enter, someone is already loading: just bail and come back later (we can do tasks like GC)

        value = default;
        return false;
    }

    private bool TryGcOne()
    {
        int attempts = 0;

        while (_residentSize > maxSize && attempts++ <= 16 && _lru.TryDequeue(out TKey? key))
        {
            CacheData data = _data[key];

            if (data.TryGc())
            {
                Interlocked.Add(ref _residentSize, -data.ValueSize);
                return true;
            }

            _lru.Enqueue(key);
        }

        return false;
    }
}
