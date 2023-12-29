using K4os.Compression.LZ4;
using RogueTraderUnityToolkit.Core;
using System.Text;

namespace RogueTraderUnityToolkit.Unity;

public sealed record AssetBundle(
    AssetBundleHeader Header,
    AssetBundleManifest Manifest,
    AssetBundleBlockRegion[] Regions)
    : ISerializedAsset
{
    public SerializedAssetInfo Info => _info;

    public static bool CanRead(SerializedAssetInfo info)
    {
        using Stream stream = info.Open(0, 16);
        EndianBinaryReader reader = new(stream, 0, 16);
        return AssetBundleHeader.CheckMagicMatches(reader);
    }

    public static AssetBundle Read(SerializedAssetInfo info)
    {
        using Stream stream = info.Open();
        EndianBinaryReader reader = new(stream);

        AssetBundleHeader header = AssetBundleHeader.Read(reader);
        AssetBundleManifest manifest;

        reader.AlignTo(16);

        if (AssetBundleUtil.IsLz4Compression(header.Flags))
        {
            Span<byte> manifestCompressed = stackalloc byte[header.CompressedSize];
            Span<byte> manifestUncompressed = stackalloc byte[header.UncompressedSize];
            AssetBundleUtil.FetchCompressedData(reader, manifestCompressed, manifestUncompressed);
            manifest = AssetBundleManifest.Read(new(manifestUncompressed.AsStream()));
        }
        else
        {
            manifest = AssetBundleManifest.Read(reader);
        }
        
        reader.AlignTo(16);

        long fileOffset = stream.Position;
        long memoryOffset = 0;

        AssetBundleBlockRegion[] regions = new AssetBundleBlockRegion[manifest.Blocks.Length];

        for (int i = 0; i < manifest.Blocks.Length; ++i)
        {
            AssetBundleBlock block = manifest.Blocks[i];

            regions[i] = new(
                FileOffset: fileOffset,
                FileLength: block.CompressedSize,
                MemoryOffset: memoryOffset,
                MemoryLength: block.UncompressedSize);

            fileOffset += block.CompressedSize;
            memoryOffset += block.UncompressedSize;
        }
        
        return new(
            Header: header,
            Manifest: manifest,
            Regions: regions)
        {
            _info = info
        };
    }

    private SerializedAssetInfo _info = default!;
}

public readonly record struct AssetBundleHeader(
    int Version,
    StringPool.Entry UnityVersion1,
    StringPool.Entry UnityVersion2,
    long Size,
    int CompressedSize,
    int UncompressedSize,
    int Flags)
{

    public static AssetBundleHeader Read(EndianBinaryReader reader)
    {
        if (!CheckMagicMatches(reader)) throw new("Magic does not match");

        int version = reader.ReadS32();
        StringPool.Entry unityVersion1 = reader.ReadStringUntilNull();
        StringPool.Entry unityVersion2 = reader.ReadStringUntilNull();
        long size = reader.ReadS64();
        int compressedSize = reader.ReadS32();
        int uncompressedSize = reader.ReadS32();
        int flags = reader.ReadS32();
        
        if (version != _version)
        {
            throw new($"Expected version {_version} but got {version}.");
        }

        if (unityVersion2 != _unityVersion)
        {
            throw new($"Expected unityVersion {_unityVersion} but got {unityVersion2}.");
        }

        AssetBundleUtil.ValidateCompression(flags, uncompressedSize, compressedSize);

        return new(
            Version: version,
            UnityVersion1: unityVersion1,
            UnityVersion2: unityVersion2,
            Size: size,
            CompressedSize: compressedSize,
            UncompressedSize: uncompressedSize,
            Flags: flags);
    }

    public static bool CheckMagicMatches(EndianBinaryReader reader)
    {
        Span<byte> buffer = stackalloc byte[_magicBytes.Length];
        reader.ReadBytes(buffer);
        return buffer.SequenceEqual(_magicBytes);
    }
    
    private static readonly byte[] _magicBytes = [ .. Encoding.ASCII.GetBytes("UnityFS"), 0 ];
    private const int _version = 8;
    private const string _unityVersion = "2022.3.7f1";
}

public readonly record struct AssetBundleManifest(
    Hash128 Hash,
    AssetBundleBlock[] Blocks,
    AssetBundleNode[] Nodes)
{
    public static AssetBundleManifest Read(EndianBinaryReader reader)
    {
        Hash128 hash = Hash128.Read(reader);
        AssetBundleBlock[] blocks = reader.ReadArray(AssetBundleBlock.Read);
        AssetBundleNode[] nodes = reader.ReadArray(AssetBundleNode.Read);

        return new(
            Hash: hash,
            Blocks: blocks,
            Nodes: nodes);
    }
}

public readonly record struct AssetBundleBlock(
    uint UncompressedSize,
    uint CompressedSize,
    ushort Flags)
{
    public static AssetBundleBlock Read(EndianBinaryReader reader)
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

// Note: the offsets/size are relative to the uncompressed base, not the compressed file.
public readonly record struct AssetBundleNode(
    long Offset,
    long Size,
    int Flags,
    StringPool.Entry Path)
{
    public static AssetBundleNode Read(EndianBinaryReader reader)
    {
        long offset = reader.ReadS64();
        long size = reader.ReadS64();
        int flags = reader.ReadS32();
        StringPool.Entry path = reader.ReadStringUntilNull();

        return new(
            Offset: offset,
            Size: size,
            Flags: flags,
            Path: path);
    }
}

public readonly record struct AssetBundleBlockRegion(
    long FileOffset,
    uint FileLength,
    long MemoryOffset,
    uint MemoryLength)
{
    public bool Overlaps(AssetBundleNode node)
    {
        long nodeStart = node.Offset;
        long nodeEnd = nodeStart + node.Size;
        long regionStart = MemoryOffset;
        long regionEnd = regionStart + MemoryLength;
        return regionEnd > nodeStart && nodeEnd > regionStart;
    }

    public override string ToString() => $"0x{MemoryOffset:x} - 0x{MemoryOffset + MemoryLength:x} ({MemoryLength} bytes)";
}

public static class AssetBundleUtil
{
    public static void ValidateCompression(int flags, int compressedSize, int uncompressedSize)
    {
        if (IsLz4Compression(flags))
        {
            if (compressedSize == uncompressedSize)
            {
                throw new($"Compression enabled but compressedSize and uncompressedSize are the same ({compressedSize})");
            }
        }
        else
        {
            if (compressedSize != uncompressedSize)
            {
                throw new($"Compression disabled but compressedSize and uncompressedSize are not same ({compressedSize})");
            }
        }
    }

    public static void FetchCompressedData(EndianBinaryReader reader, Span<byte> compressed, Span<byte> uncompressed)
    {
        reader.ReadBytes(compressed);
        int bytesRead = LZ4Codec.Decode(compressed, uncompressed);

        if (bytesRead != uncompressed.Length)
        {
            throw new(
                $"Expected to read {uncompressed.Length} bytes but only read {bytesRead} bytes. " +
                "This is probably a data alignment issue.");
        }
    }

    public static bool IsLz4Compression(int flags) => (flags & 0xF) == 3;
}
