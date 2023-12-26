using K4os.Compression.LZ4;
using RogueTraderUnityToolkit.Helper;
using System.Diagnostics;

namespace RogueTraderUnityToolkit.Unity;

public record class SerializedAssetBundle(
    SerializedAssetBundleHeader Header,
    SerializedAssetBundleManifest Manifest,
    IReadOnlyList<Task<ISerializedAsset?>> Assets) : ISerializedAsset
{
    public static AssetDatabaseImporter Importer => new(CanRead, Read);
    public AssetDatabaseLoader Loader => _loader;

    public static bool CanRead(AssetDatabaseLoader loader)
    {
        using Stream stream = loader.OpenStream(0, 16);
        EndianBinaryReader reader = new(stream, 0, 16);
        return reader.ReadStringUntilNull() == SerializedConstants.AssetBundleMagic;
    }

    public static SerializedAssetBundle Read(AssetDatabaseLoader loader)
    {
        using Stream stream = loader.OpenStream();
        EndianBinaryReader reader = new(stream);

        SerializedAssetBundleHeader header = SerializedAssetBundleHeader.Read(reader);
        SerializedAssetBundleManifest manifest;

        reader.AlignTo(16);

        if (AssetBundleUtil.IsLz4Compression(header.Flags))
        {
            Span<byte> manifestCompressed = stackalloc byte[header.CompressedSize];
            Span<byte> manifestUncompressed = stackalloc byte[header.UncompressedSize];
            AssetBundleUtil.FetchCompressedData(reader, manifestCompressed, manifestUncompressed);
            manifest = SerializedAssetBundleManifest.Read(new(manifestUncompressed.AsStream()));
        }
        else
        {
            manifest = SerializedAssetBundleManifest.Read(reader);
        }

        reader.AlignTo(16);

        SerializedAssetBundleBlockRegion[] regions = CreateRegions(manifest.Blocks, stream.Position);
        IRelocatableMemoryRegion[] regionsMemory = CreateRegionsMemory(loader.OpenStream, manifest.Blocks, regions);
        List<Task<ISerializedAsset?>> assets = LoadAssetsAsync(manifest.Nodes, regions, regionsMemory);

        return new(
            Header: header,
            Manifest: manifest,
            Assets: assets)
        {
            _loader = loader
        };
    }

    private static SerializedAssetBundleBlockRegion[] CreateRegions(
        SerializedAssetBundleBlock[] blocks,
        long initialOffset)
    {
        long fileOffset = initialOffset;
        long memoryOffset = 0;

        SerializedAssetBundleBlockRegion[] regions = new SerializedAssetBundleBlockRegion[blocks.Length];

        for (int i = 0; i < blocks.Length; ++i)
        {
            SerializedAssetBundleBlock block = blocks[i];

            regions[i] = new(
                FileOffset: fileOffset,
                FileLength: block.CompressedSize,
                MemoryOffset: memoryOffset,
                MemoryLength: block.UncompressedSize);

            fileOffset += block.CompressedSize;
            memoryOffset += block.UncompressedSize;
        }

        return regions;
    }

    private static IRelocatableMemoryRegion[] CreateRegionsMemory(
        OpenStreamForAssetFunc fnOpenStream,
        SerializedAssetBundleBlock[] blocks,
        SerializedAssetBundleBlockRegion[] regions)
    {
        IRelocatableMemoryRegion[] regionsMem = new IRelocatableMemoryRegion[blocks.Length];

        for (int i = 0; i < regions.Length; ++i)
        {
            regionsMem[i] = AssetMemoryCache.Register(
                new SerializedAssetBundleBlockLoader(fnOpenStream, blocks[i], regions[i]),
                (int)blocks[i].UncompressedSize, (int)regions[i].MemoryOffset);
        }

        return regionsMem;
    }

    private static List<Task<ISerializedAsset?>> LoadAssetsAsync(
        SerializedAssetBundleNode[] nodes,
        SerializedAssetBundleBlockRegion[] regions,
        IRelocatableMemoryRegion[] regionsMem)
    {
        List<Task<ISerializedAsset?>> assets = [];

        foreach ((SerializedAssetBundleNode node, int nodeIdx) in nodes.WithIndex())
        {
            IRelocatableMemoryRegion[] memoryRegions = [.. regions
                .WithIndex()
                .Where(x => x.item.Overlaps(node))
                .Select(x =>
                {
                    SerializedAssetBundleBlockRegion region = x.item;
                    IRelocatableMemoryRegion regionMem = regionsMem[x.index];

                    long nodeAddress = node.Offset;
                    long nodeLength = node.Size;
                    long blockAddress = region.MemoryOffset;
                    long blockLength = region.MemoryLength;

                    int start = (int)Math.Max(nodeAddress, blockAddress);
                    int end = (int)Math.Min(nodeAddress + nodeLength, blockAddress + blockLength);

                    int offset = (int)(start - blockAddress);
                    int length = end - start;

                    Debug.Assert(offset >= 0 && offset <= blockLength);
                    Debug.Assert(length > 0 && length <= blockLength);

                    return regionMem.Slice(offset, length);
                })];

            Stream OpenStream(long offset, long length)
            {
                MultiMemoryStream mms = new(memoryRegions);               
                if (offset != 0) return mms.Slice(offset, length == 0 ? memoryRegions.Sum(x => x.Length) - offset : length);
                if (length != 0) return mms.Slice(0, length);
                return mms;
            }

            Task<ISerializedAsset?> loadChildTask = AssetDatabase.LoadUnityAssetAsync(
                loader: new(node.Path, node.Size, OpenStream),
                importers: [SerializedFile.Importer, SerializedResourceFile.Importer]);

            assets.Add(loadChildTask);
        }

        return assets;
    }

    private AssetDatabaseLoader _loader = default!;
}

public record struct SerializedAssetBundleHeader(
    string Magic,
    int Version,
    string UnityVersion1,
    string UnityVersion2,
    long Size,
    int CompressedSize,
    int UncompressedSize,
    int Flags)
{
    public static SerializedAssetBundleHeader Read(EndianBinaryReader reader)
    {
        string magic = reader.ReadStringUntilNull();
        int version = reader.ReadS32();
        string unityVersion1 = reader.ReadStringUntilNull();
        string unityVersion2 = reader.ReadStringUntilNull();
        long size = reader.ReadS64();
        int compressedSize = reader.ReadS32();
        int uncompressedSize = reader.ReadS32();
        int flags = reader.ReadS32();

        if (magic != _magic)
        {
            throw new Exception($"SerializedAssetBundleHeader: Expected magic {_magic} but got {magic}.");
        }

        if (version != _version)
        {
            throw new Exception($"SerializedAssetBundleHeader: Expected version {_version} but got {version}.");
        }

        if (unityVersion2 != _unityVersion)
        {
            throw new Exception($"SerializedAssetBundleHeader: Expected unityVersion {_unityVersion} but got {unityVersion2}.");
        }

        AssetBundleUtil.ValidateCompression(flags, uncompressedSize, compressedSize);

        return new(
            Magic: magic,
            Version: version,
            UnityVersion1: unityVersion1,
            UnityVersion2: unityVersion2,
            Size: size,
            CompressedSize: compressedSize,
            UncompressedSize: uncompressedSize,
            Flags: flags);
    }

    private const string _magic = SerializedConstants.AssetBundleMagic;
    private const int _version = 8;
    private const string _unityVersion = "2022.3.7f1";
}

public record struct SerializedAssetBundleManifest(
    SerializedHash Hash,
    SerializedAssetBundleBlock[] Blocks,
    SerializedAssetBundleNode[] Nodes)
{
    public static SerializedAssetBundleManifest Read(EndianBinaryReader reader)
    {
        SerializedHash hash = SerializedHash.Read(reader);
        SerializedAssetBundleBlock[] blocks = reader.ReadArray(SerializedAssetBundleBlock.Read);
        SerializedAssetBundleNode[] nodes = reader.ReadArray(SerializedAssetBundleNode.Read);

        return new(
            Hash: hash,
            Blocks: blocks,
            Nodes: nodes);
    }
}

// Note: the offsets/size are relative to the uncompressed base, not the compressed file.
public record struct SerializedAssetBundleNode(
    long Offset,
    long Size,
    int Flags,
    string Path)
{
    public static SerializedAssetBundleNode Read(EndianBinaryReader reader)
    {
        long offset = reader.ReadS64();
        long size = reader.ReadS64();
        int flags = reader.ReadS32();
        string path = reader.ReadStringUntilNull();

        return new(
            Offset: offset,
            Size: size,
            Flags: flags,
            Path: path);
    }
}

public static class AssetBundleUtil
{
    public static void ValidateCompression(int flags, int compressedSize, int uncompressedSize)
    {
        if (IsLz4Compression(flags))
        {
            if (compressedSize == uncompressedSize)
            {
                throw new Exception($"AssetBundleUtil: Compression enabled but compressedSize and uncompressedSize are the same ({compressedSize})");
            }
        }
        else
        {
            if (compressedSize != uncompressedSize)
            {
                throw new Exception($"AssetBundleUtil: Compression disabled but compressedSize and uncompressedSize are not same ({compressedSize})");
            }
        }
    }

    public static void FetchCompressedData(EndianBinaryReader reader, Span<byte> compressed, Span<byte> uncompressed)
    {
        reader.ReadBytes(compressed);
        int bytesRead = LZ4Codec.Decode(compressed, uncompressed);

        if (bytesRead != uncompressed.Length)
        {
            throw new Exception(
                $"AssetBundleUtil: Expected to read {uncompressed.Length} bytes but only read {bytesRead} bytes. " +
                "This is probably a data alignment issue.");
        }
    }

    public static bool IsLz4Compression(int flags) => (flags & 0xF) == 3;
}