using NeoSmart.Hashing.XXHash;
using System.Collections.Concurrent;
using System.Text;

namespace RogueTraderUnityToolkit
{
    public static class AssetStringPool
    {
        public static string Fetch(ReadOnlyMemory<byte> memory)
        {
            if (!_pool.TryGetValue(memory, out string? str))
            {
                str = Encoding.ASCII.GetString(memory.Span);
                _pool[memory] = str;
            }

            return str;
        }

        private static readonly ConcurrentDictionary<ReadOnlyMemory<byte>, string> _pool = new(new FastMemoryComparator());

        private class FastMemoryComparator : EqualityComparer<ReadOnlyMemory<byte>>
        {
            public override bool Equals(ReadOnlyMemory<byte> lhs, ReadOnlyMemory<byte> rhs)
            {
                ReadOnlySpan<byte> lhsSpan = lhs.Span;
                ReadOnlySpan<byte> rhsSpan = rhs.Span;

                if (lhsSpan.Length != rhsSpan.Length)
                {
                    return false;
                }

                for (int i = 0; i < lhsSpan.Length; i++)
                {
                    if (lhsSpan[i] != rhsSpan[i])
                    {
                        return false;
                    }
                }

                return true;
            }

            public override int GetHashCode(ReadOnlyMemory<byte> memory) => (int)XXHash32.Hash(memory.Span);
        }
    }
}
