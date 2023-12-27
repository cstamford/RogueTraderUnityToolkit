using NeoSmart.Hashing.XXHash;
using System.Collections.Concurrent;
using System.Text;

namespace RogueTraderUnityToolkit.Core;

public static class StringPool
{
    public static string Fetch(ReadOnlyMemory<byte> memory)
    {
        MemoryBytesHasher hasher = new(memory);
        if (!_pool.TryGetValue(hasher, out string? str))
        {
            str = Encoding.ASCII.GetString(memory.Span);
            _pool[hasher] = str;
        }

        return str;
    }

    private static readonly ConcurrentDictionary<MemoryBytesHasher, string> _pool = [];
        
    private readonly struct MemoryBytesHasher(
        ReadOnlyMemory<byte> memory)
        : IEquatable<MemoryBytesHasher>
    {
        private readonly ReadOnlyMemory<byte> _memory = memory;
        private readonly int _hashCode = (int)XXHash32.Hash(memory.Span);

        public bool Equals(MemoryBytesHasher other)
        {
            return _memory.Span.SequenceEqual(other._memory.Span);
        }

        public override bool Equals(object? obj)
        {
            return obj is MemoryBytesHasher other && Equals(other);
        }

        public override int GetHashCode() => _hashCode;
    }
}
