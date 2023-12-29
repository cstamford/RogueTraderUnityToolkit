using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace RogueTraderUnityToolkit.Core;

public sealed class FastStringBuilder
{
    public byte[] Buffer
    {
        get => _buf;
        set => _buf = value;
    }
    
    public int Index
    {
        get => _idx;
        set => _idx = value;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void Append(StringPool.Entry str)
    {
        ReadOnlySpan<byte> stringBytes = str.Bytes.Span;
        stringBytes.CopyTo(_buf.AsSpan(_idx, str.Length));
        _idx += stringBytes.Length;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void Append(char ch)
    {
        _buf[_idx++] = (byte)ch;
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

        fixed (byte* toBuf = _buf)
        {
            System.Buffer.MemoryCopy(start, toBuf + _idx, len, len);
        }

        _idx += len;
        Debug.Assert(_idx < _buf.Length);
    }

    private byte[] _buf = default!;
    private int _idx;
}
