using System.Buffers;
using System.Buffers.Text;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace RogueTraderUnityToolkit.Core;

public readonly unsafe struct FastTextWriter(Stream stream)
{
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void Write(ulong value)
    {
        byte* buf = stackalloc byte[20];
        byte* end = buf + 20;
        byte* start = end;
    
        do
        {
            *--start = (byte)(_asciiZero + value % 10);
            value /= 10;
        } while (value != 0);
        
        stream.Write(new(start, (int)(end - start)));
    }
    
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void Write(uint value)
    {
        byte* buf = stackalloc byte[10];
        byte* end = buf + 10;
        byte* start = end;
        
        do
        {
            *--start = (byte)(_asciiZero + value % 10);
            value /= 10;
        } while (value != 0);
        
        stream.Write(new(start, (int)(end - start)));
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void Write(ushort value)
    {
        byte* buf = stackalloc byte[5];
        byte* end = buf + 5;
        byte* start = end;
        
        do
        {
            *--start = (byte)(_asciiZero + value % 10);
            value /= 10;
        } while (value != 0);
        
        stream.Write(new(start, (int)(end - start)));
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void Write(byte value)
    {
        byte* buf = stackalloc byte[3];
        byte* end = buf + 3;
        byte* start = end;
        
        do
        {
            *--start = (byte)(_asciiZero + value % 10);
            value /= 10;
        } while (value != 0);
        
        stream.Write(new(start, (int)(end - start)));
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void Write(long value)
    {
        byte* buf = stackalloc byte[20];
        byte* end = buf + 20;
        byte* start = end;
        
        bool isNegative = value < 0;
        if (isNegative) value = -value;
        
        do
        {
            *--start = (byte)(_asciiZero + value % 10);
            value /= 10;
        } while (value != 0);
        
        if (isNegative) *--start = _asciiMinus;
        
        stream.Write(new(start, (int)(end - start)));
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void Write(int value)
    {
        byte* buf = stackalloc byte[11];
        byte* end = buf + 11;
        byte* start = end;
        
        bool isNegative = value < 0;
        if (isNegative) value = -value;
        
        do
        {
            *--start = (byte)(_asciiZero + value % 10);
            value /= 10;
        } while (value != 0);
        
        if (isNegative) *--start = _asciiMinus;
        
        stream.Write(new(start, (int)(end - start)));
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void Write(short value)
    {
        byte* buf = stackalloc byte[6];
        byte* end = buf + 6;
        byte* start = end;
        
        bool isNegative = value < 0;
        
        if (isNegative) value = (short)-value;
        
        do
        {
            *--start = (byte)(_asciiZero + value % 10);
            value /= 10;
        } while (value != 0);
        
        if (isNegative) *--start = _asciiMinus;
        
        stream.Write(new(start, (int)(end - start)));
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void Write(sbyte value)
    {
        byte* buf = stackalloc byte[4];
        byte* end = buf + 4;
        byte* start = end;
        
        bool isNegative = value < 0;
        if (isNegative) value = (sbyte)-value;
        
        do
        {
            *--start = (byte)(_asciiZero + value % 10);
            value /= 10;
        } while (value != 0);
        
        if (isNegative) *--start = _asciiMinus;
        
        stream.Write(new(start, (int)(end - start)));
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void Write(double value)
    {
        byte* buf = stackalloc byte[64];
        Span<byte> bufSpan = new(buf, 64);

        Utf8Formatter.TryFormat(value, bufSpan, out int written, _dbl);
        byte* end = buf + written;
        
        if (Util.FastFindByte(_asciiDot, bufSpan) == -1)
        {
            *end++ = _asciiDot;
            *end++ = _asciiZero;
        }

        int finalWritten = (int)(end - buf);
        stream.Write(bufSpan[..finalWritten]);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void Write(float value)
    {
        if (Optimization_WriteCommonFloats(value)) return;
        
        byte* buf = stackalloc byte[32];
        Span<byte> bufSpan = new(buf, 32);

        Utf8Formatter.TryFormat(value, bufSpan, out int written, _flt);
        byte* end = buf + written;
        
        if (Util.FastFindByte(_asciiDot, bufSpan) == -1)
        {
            *end++ = _asciiDot;
            *end++ = _asciiZero;
        }

        int finalWritten = (int)(end - buf);
        stream.Write(bufSpan[..finalWritten]);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private bool Optimization_WriteCommonFloats(float value)
    {
        if (value == 0f)
        {
            stream.Write("0.0"u8);
            return true;
        }
        
        if (value == 1f)
        {
            stream.Write("1.0"u8);
            return true;
        }

        return false;
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void Write(bool value)
    {
        stream.Write(value ? "true"u8 : "false"u8);
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void Write(char ch)
    {
        Debug.Assert(ch < 0x7F);
        stream.WriteByte((byte)ch);
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void Write(AsciiString str)
    {
        stream.Write(str.Bytes.Span);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void Write(ReadOnlySpan<byte> bytes)
    {
        stream.Write(bytes);
    }

    private const byte _asciiDot = 0x2E;
    private const byte _asciiMinus = 0x2D;
    private const byte _asciiZero = 0x30;
    
    private static readonly StandardFormat _dbl = new('G', 16);
    private static readonly StandardFormat _flt = new('G', 8);
}
