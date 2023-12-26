using System.Numerics;
using System.Runtime.CompilerServices;

namespace RogueTraderUnityToolkit.Helper;

public static class Util
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int FastFindNull(ReadOnlySpan<byte> buffer, int offset = 0)
    {
        Vector<byte> nullVector = new(0);
        int vectorSize = Vector<byte>.Count;
        int blocks = buffer.Length / vectorSize;

        for (int i = offset / vectorSize * vectorSize; i < blocks * vectorSize; i += vectorSize)
        {
            Vector<byte> v = new(buffer.Slice(i, vectorSize));
            Vector<byte> equals = Vector.Equals(v, nullVector);

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
                        if (buffer[k] == 0) return k;
                    }
                }
            }
        }

        int lastBlock = blocks * vectorSize;

        for (int i = Math.Max(lastBlock, offset); i < buffer.Length; i++)
        {
            if (buffer[i] == 0) return i;
        }

        return -1;
    }

    public static Task RunTask(Action fn)
    {
        Task task = new(fn);

        if (Options.ShouldRunSingleThreaded)
        {
            task.RunSynchronously();
        }
        else
        {
            task.Start();
        }

        return task;
    }

    public static Task<T> RunTask<T>(Func<T> fn)
    {
        Task<T> task = new(fn);

        if (Options.ShouldRunSingleThreaded)
        {
            task.RunSynchronously();
        }
        else
        {
            task.Start();
        }

        return task;
    }

    public static SuperluminalPerf.EventMarker PerfScope(string name) 
        => SuperluminalPerf.BeginEvent(name, data: null);

    public static SuperluminalPerf.EventMarker PerfScopeDatabase(string name) 
        => SuperluminalPerf.BeginEvent($"Database/{name}", data: null, color: new(0, 128, 128));

    public static SuperluminalPerf.EventMarker PerfScopeLRU(string name) 
        => SuperluminalPerf.BeginEvent($"LRU/{name}", data: null, color: new(128, 0, 128));

    public static int CharWidth(int value)
    {
        return value == 0 ? 1 : (value < 0 ? 1 : 0) + (int)Math.Log10(Math.Abs(value)) + 1;
    }
}
