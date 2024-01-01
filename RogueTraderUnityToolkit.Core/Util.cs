using NeoSmart.Hashing.XXHash;
using System.Numerics;
using System.Text;

namespace RogueTraderUnityToolkit.Core;

public static class Util
{
    public static int FastFindByte(byte b, ReadOnlySpan<byte> buffer, int offset = 0)
    {
        Vector<byte> byteVector = new(b);
        int vectorSize = Vector<byte>.Count;
        int blocks = buffer.Length / vectorSize;

        for (int i = offset / vectorSize * vectorSize; i < blocks * vectorSize; i += vectorSize)
        {
            Vector<byte> v = new(buffer.Slice(i, vectorSize));
            Vector<byte> equals = Vector.Equals(v, byteVector);

            if (!equals.Equals(Vector<byte>.Zero))
            {
                Vector<uint> mask = Vector.AsVectorUInt32(equals);

                // TODO: SSE/assembly instruction to find first non-zero bit?

                for (int j = Math.Max(0, (offset - i) / 4); j < 8; j++)
                {
                    uint maskBits = mask[j];
                    if (maskBits == 0) continue;

                    int currentBlock = i + j * 4;
                    int nextBlock = currentBlock + 4;

                    for (int k = Math.Max(currentBlock, offset); k < nextBlock; ++k)
                    {
                        if (buffer[k] == b) return k;
                    }
                }
            }
        }

        int lastBlock = blocks * vectorSize;

        for (int i = Math.Max(lastBlock, offset); i < buffer.Length; i++)
        {
            if (buffer[i] == b) return i;
        }

        return -1;
    }

    public static SuperluminalPerf.EventMarker PerfScope(string name, SuperluminalPerf.ProfilerColor color)
        => SuperluminalPerf.BeginEvent(name, data: null, color: color);

    public static uint Hash(string str) => Hash(Encoding.ASCII.GetBytes(str));

    public static uint Hash(ReadOnlySpan<byte> str) => XXHash32.Hash(str);

    public static int CharWidth(int value)
    {
        return value == 0 ? 1 : (value < 0 ? 1 : 0) + (int)Math.Log10(Math.Abs(value)) + 1;
    }
}
