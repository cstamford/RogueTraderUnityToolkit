using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace RogueTraderUnityToolkit.Core;

public sealed class FastStringBuilder(
    byte[] buffer)
{
    public int Length
    {
        get => _len;
        set => _len = value;
    }

    public ReadOnlySpan<byte> Span => buffer.AsSpan()[.._len];

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void Append(AsciiString str)
    {
        ReadOnlySpan<byte> stringBytes = str.Bytes.Span;
        stringBytes.CopyTo(buffer.AsSpan(_len, str.Length));
        _len += stringBytes.Length;
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void Append(char ch)
    {
        buffer[_len++] = (byte)ch;
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public unsafe void Append(uint value)
    {
        byte* buf = stackalloc byte[10];
        byte* end = buf + 10;
        byte* start = end;

        do
        {
            *--start = (byte)(0x30 + value % 10);
            value /= 10;
        } while (value != 0);

        int len = (int)(end - start);

        fixed (byte* toBuf = buffer)
        {
            Buffer.MemoryCopy(start, toBuf + _len, len, len);
        }

        _len += len;
        Debug.Assert(_len < buffer.Length);
    }

    private int _len;
}
