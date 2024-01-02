using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity.File;
using RogueTraderUnityToolkit.Unity.TypeTree;
using System.Diagnostics;

namespace RogueTraderUnityToolkit.Unity;

public static class Extensions
{
    public static byte Size(this ObjectParserType type) => type switch
    {
        ObjectParserType.U64 => 8,
        ObjectParserType.U32 => 4,
        ObjectParserType.U16 => 2,
        ObjectParserType.U8 => 1,
        ObjectParserType.S64 => 8,
        ObjectParserType.S32 => 4,
        ObjectParserType.S16 => 2,
        ObjectParserType.S8 => 1,
        ObjectParserType.F64 => 8,
        ObjectParserType.F32 => 4,
        ObjectParserType.Bool => 1,
        ObjectParserType.Char => 1,
        _ => 0
    };

    public static IRelocatableMemoryRegion[] CreateRelocatableMemoryRegions(
        this AssetBundle bundle)
    {
        AssetBundleBlock[] blocks = bundle.Manifest.Blocks;
        IRelocatableMemoryRegion[] regionsMem = new IRelocatableMemoryRegion[blocks.Length];

        for (int i = 0; i < blocks.Length; ++i)
        {
            ref AssetBundleBlock block = ref blocks[i];
            ref AssetBundleBlockRegion blockRegion = ref bundle.Regions[i];

            regionsMem[i] = MemoryCache.Register(
                new AssetBundleBlockLoader(bundle.Info, block, blockRegion),
                (int)block.UncompressedSize, (int)blockRegion.MemoryOffset);
        }

        return regionsMem;
    }

    public static SerializedAssetInfo CreateAssetInfoForNode(
        this AssetBundle bundle,
        AssetBundleNode node,
        IReadOnlyList<IRelocatableMemoryRegion> nodeMemory)
    {
        IRelocatableMemoryRegion[] overlapMem = [.. bundle.Regions
            .WithIndex()
            .Where(x => x.item.Overlaps(node))
            .Select(x =>
            {
                AssetBundleBlockRegion region = x.item;
                IRelocatableMemoryRegion regionMem = nodeMemory[x.index];

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

        SerializedAssetInfo info = new(
            parent: bundle,
            identifier: node.Path.ToString(),
            size: node.Size,
            fnOpen: (offset, length) =>
            {
                MultiMemoryStream mms = new(overlapMem);
                if (offset != 0) return mms.Slice(offset, length == 0 ? overlapMem.Sum(x => x.Length) - offset : length);
                if (length != 0) return mms.Slice(0, length);
                return mms;
            });

        if (Debugger.IsAttached)
        {
            info.UserData = overlapMem;
        }

        return info;
    }
}
