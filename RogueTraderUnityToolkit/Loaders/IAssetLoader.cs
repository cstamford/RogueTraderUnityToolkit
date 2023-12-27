using RogueTraderUnityToolkit.Unity;

namespace RogueTraderUnityToolkit.Loaders;

public interface IAssetLoader
{
    public bool CanRead(SerializedAssetInfo info);
    public ISerializedAsset Read(SerializedAssetInfo info);
}
