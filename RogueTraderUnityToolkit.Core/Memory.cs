using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace RogueTraderUnityToolkit.Core;

public static class Memory
{
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe bool IsAligned(byte* ptr, int align) => (byte*)AlignTo((IntPtr)ptr, align) == ptr;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe bool IsAligned(Span<byte> span, int align)
    {
        fixed (byte* ptr = span)
        {
            return IsAligned(ptr, align);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void AssertAligned(byte* ptr, int align)
    {
        Debug.Assert(IsAligned(ptr, align), $"unaligned data (must be aligned to {align})");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void AssertAligned(Span<byte> span, int align)
    {
        fixed (byte* ptr = span)
        {
            AssertAligned(ptr, align);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe byte* AlignTo(byte* value, int alignment) => (byte*)((IntPtr)value + (alignment - 1) & ~(alignment - 1));

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static IntPtr AlignTo(IntPtr value, int alignment) => value + (alignment - 1) & ~(alignment - 1);

    public static bool MayBeAsciiString(ReadOnlySpan<byte> span)
    {
        foreach (byte t in span)
        {
            if (t > 0x7F) return false;
        }

        return true;
    }
}
