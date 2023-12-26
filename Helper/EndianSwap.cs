using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace RogueTraderUnityToolkit.Helper;

public static class EndianSwap
{
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe ushort Swap(ushort value)
    {
        SwapImpl(&value);
        return value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe uint Swap(uint value)
    {
        SwapImpl(&value);
        return value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe ulong Swap(ulong value)
    {
        SwapImpl(&value);
        return value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe short Swap(short value)
    {
        Swap16((byte*)&value);
        return value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe int Swap(int value)
    {
        Swap32((byte*)&value);
        return value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe long Swap(long value)
    {
        Swap64((byte*)&value);
        return value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe float Swap(float value)
    {
        Swap32((byte*)&value);
        return value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe double Swap(double value)
    {
        Swap64((byte*)&value);
        return value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void Swap64(byte* bytes64)
    {
        Memory.AssertAligned(bytes64, 8);
        SwapImpl((ulong*)bytes64);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void Swap64(Span<byte> bytes64)
    { 
        fixed (byte* buf = bytes64)
        { 
            Swap64(buf);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void Swap32(byte* bytes32)
    {
        Memory.AssertAligned(bytes32, 4);
        SwapImpl((uint*)bytes32);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void Swap32(Span<byte> bytes32)
    { 
        fixed (byte* buf = bytes32)
        { 
            Swap32(buf);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void Swap16(byte* bytes16)
    {
        Memory.AssertAligned(bytes16, 2);
        SwapImpl((ushort*)bytes16);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void Swap16(Span<byte> bytes16)
    { 
        fixed (byte* buf = bytes16)
        { 
            Swap16(buf);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static unsafe void SwapImpl(ushort* ptr)
    {
        ushort value = *ptr;
        *ptr = (ushort)((value >> 8) | (value << 8));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static unsafe void SwapImpl(uint* ptr)
    {
        uint value = *ptr;
        *ptr = (value >> 24) |
               ((value << 8) & 0x00FF0000) |
               ((value >> 8) & 0x0000FF00) |
               (value << 24);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static unsafe void SwapImpl(ulong* ptr)
    {
        ulong value = *ptr;
        *ptr = (value >> 56) |
               ((value << 40) & 0x00FF000000000000) |
               ((value << 24) & 0x0000FF0000000000) |
               ((value << 8) & 0x000000FF00000000) |
               ((value >> 8) & 0x00000000FF000000) |
               ((value >> 24) & 0x0000000000FF0000) |
               ((value >> 40) & 0x000000000000FF00) |
               (value << 56);
    }
}
