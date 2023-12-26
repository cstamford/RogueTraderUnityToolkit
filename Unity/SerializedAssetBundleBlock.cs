using RogueTraderUnityToolkit.Helper;
using System.Buffers;
using System.Diagnostics;

namespace RogueTraderUnityToolkit.Unity;

public record struct SerializedAssetBundleBlock(
    uint UncompressedSize,
    uint CompressedSize,
    ushort Flags)
{
    public static SerializedAssetBundleBlock Read(EndianBinaryReader reader)
    {
        uint uncompressedSize = reader.ReadU32();
        uint compressedSize = reader.ReadU32();
        ushort flags = reader.ReadU16();

        AssetBundleUtil.ValidateCompression(flags, (int)compressedSize, (int)uncompressedSize);

        return new(
            UncompressedSize: uncompressedSize,
            CompressedSize: compressedSize,
            Flags: flags);
    }
}

public record struct SerializedAssetBundleBlockRegion(
    long FileOffset,
    uint FileLength,
    long MemoryOffset,
    uint MemoryLength)
{
    public readonly bool Overlaps(SerializedAssetBundleNode node)
    {
        long nodeStart = node.Offset;
        long nodeEnd = nodeStart + node.Size;
        long regionStart = MemoryOffset;
        long regionEnd = regionStart + MemoryLength;
        return regionEnd > nodeStart && nodeEnd > regionStart;
    }

    public override readonly string ToString() => $"0x{MemoryOffset:x} - 0x{MemoryOffset + MemoryLength:x} ({MemoryLength} bytes)";
}

public sealed class SerializedAssetBundleBlockLoader(
    OpenStreamForAssetFunc fnOpenStream,
    SerializedAssetBundleBlock block,
    SerializedAssetBundleBlockRegion region) : IAssetMemoryCacheLoader
{
    public ReadOnlyMemory<byte> Load()
    {
        Debug.Assert(_data == null);

        using var _ = Util.PerfScope("BundleBlockLoader/Load");

        using Stream stream = fnOpenStream(region.FileOffset, region.FileLength);
        EndianBinaryReader reader = new(stream);

        int uncompressedDataLen = (int)block.UncompressedSize;
        _data = ArrayPool<byte>.Shared.Rent(uncompressedDataLen);
        Span<byte> uncompressedDataSpan = _data.AsSpan()[..uncompressedDataLen];

        if (AssetBundleUtil.IsLz4Compression(block.Flags))
        {
            int compressedSize = (int)block.CompressedSize;
            byte[] compressedBytes = ArrayPool<byte>.Shared.Rent(compressedSize);
            Span<byte> compressedSpan = compressedBytes.AsSpan()[..compressedSize];

            try
            {
                AssetBundleUtil.FetchCompressedData(reader, compressedSpan, uncompressedDataSpan);
            }
            finally
            {
                ArrayPool<byte>.Shared.Return(compressedBytes);
            }
        }
        else
        {
            reader.ReadBytes(uncompressedDataSpan);
        }

        return _data.AsMemory();
    }

    public void Unload()
    {
        Debug.Assert(_data != null);
        ArrayPool<byte>.Shared.Return(_data);
        _data = null;
    }

    private byte[]? _data;
}
