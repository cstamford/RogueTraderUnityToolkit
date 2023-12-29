using RogueTraderUnityToolkit.Unity;

namespace RogueTraderUnityToolkit.Loaders;

public readonly struct SerializedResourceFileLoader : IAssetLoader
{
    public bool CanRead(SerializedAssetInfo info) => SerializedResourceFile.CanRead(info);
    public ISerializedAsset Read(SerializedAssetInfo info) => SerializedResourceFile.Read(info);
}
