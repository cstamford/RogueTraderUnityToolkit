using RogueTraderUnityToolkit.Unity.File;

namespace RogueTraderUnityToolkit.Processors;

public interface IAssetProcessor
{
    public void Begin(
        Args args,
        IReadOnlyList<FileInfo> files);

    public void Process(
        Args args,
        ISerializedAsset asset,
        out int assetCountProcessed,
        out int assetCountSkipped,
        out int assetCountFailed);

    public void End(
        Args args,
        ISerializedAsset[] assets);
}
