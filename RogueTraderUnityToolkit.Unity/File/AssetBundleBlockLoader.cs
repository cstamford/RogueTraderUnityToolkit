using RogueTraderUnityToolkit.Core;
using System.Buffers;
using System.Diagnostics;

namespace RogueTraderUnityToolkit.Unity.File;

public struct AssetBundleBlockLoader(
    SerializedAssetInfo bundleInfo,
    AssetBundleBlock block,
    AssetBundleBlockRegion region) : IMemoryCacheLoader
{
    public ReadOnlyMemory<byte> Load()
    {
        using SuperluminalPerf.EventMarker _ = Util.PerfScope("LoadBlockMemory", new(0, 128, 128));

        using Stream stream = bundleInfo.Open(region.FileOffset, region.FileLength);
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

    public override string ToString() => $"Bundle:{bundleInfo.Identifier}, Block: {block}, region: {region}";
}
