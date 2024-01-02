using RogueTraderUnityToolkit.Unity.File;

namespace RogueTraderUnityToolkit.Processors;

public interface IAssetProcessor
{
    public void Process(
        Args args,
        AssetBundle bundle,
        ISerializedAsset asset,
        out int assetCountProcessed,
        out int assetCountSkipped,
        out int assetCountFailed);

    public void End(Args args, ISerializedAsset[] assets);
}
