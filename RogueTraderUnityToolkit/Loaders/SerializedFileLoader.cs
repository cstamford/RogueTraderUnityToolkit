using RogueTraderUnityToolkit.Unity;

namespace RogueTraderUnityToolkit.Loaders;

public readonly struct SerializedFileLoader : IAssetLoader
{
    public bool CanRead(SerializedAssetInfo info) => SerializedFile.CanRead(info);
    public ISerializedAsset Read(SerializedAssetInfo info) => SerializedFile.Read(info);
}
