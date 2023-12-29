using System.Collections.Concurrent;
using System.Diagnostics;

namespace RogueTraderUnityToolkit.Core;

public class LruCache<TKey, TValue>(int maxSize)
    where TKey : notnull
    where TValue : IDisposable
{
    public void Add(TKey key, Func<TValue> fnMakeValue, int valueSize)
    {
        _data[key] = new(fnMakeValue, valueSize);
    }

    public TValue Pin(TKey key, out int pinCount)
    {
        using SuperluminalPerf.EventMarker _ = Util.PerfScope("LruCache.Pin", new(128, 128, 0));

        TValue? value;

        while (!TryPin(key, out value, out pinCount))
        {
            if (!TryGcOne())
            {
                Thread.Yield();
            }
        }

        TryGcOne();
        return value!;
    }

    public int Unpin(TKey key)
    {
        return _data[key].DecrementRefCount();
    }

    private readonly ConcurrentQueue<TKey> _lru = [];
    private readonly ConcurrentDictionary<TKey, CacheData> _data = [];
    private int _residentSize;

    private class CacheData(Func<TValue> fnLoadValue, int valueSize)
    {
        public bool Loaded => _loaded;
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

        public int IncrementRefCount() => Interlocked.Increment(ref _refs);
        public int DecrementRefCount() => Interlocked.Decrement(ref _refs);

        public void Load()
        {
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
        
        private bool Stale => _loaded && _refs == 0;

        private int _refs;
        private bool _loaded;
        private TValue? _value;
        private readonly ReaderWriterLockSlim _lock = new();

        private void LoadInternal()
        {
            Debug.Assert(!_loaded);

            using SuperluminalPerf.EventMarker _ = Util.PerfScope("LruCacheDataLoad", new(128, 128, 0));
            _value = fnLoadValue();
            _loaded = true;
        }

        private void UnloadInternal()
        {
            Debug.Assert(_loaded);

            using SuperluminalPerf.EventMarker _ = Util.PerfScope("LruCacheDataUnload", new(128, 128, 0));
            _value!.Dispose();
            _loaded = false;
        }

        public override string ToString() => $"{(!_loaded ? "Evicted" : _refs > 0 ? "!!PINNED!!" : "Resident")} {_refs} refs, {valueSize} bytes";
    }

    private bool TryPin(TKey key, out TValue? value, out int pinCount)
    {
        CacheData data = _data[key];

        if (data.Lock.TryEnterUpgradeableReadLock(0))
        {
            pinCount = data.IncrementRefCount();

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
        pinCount = -1;
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
