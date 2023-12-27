using RogueTraderUnityToolkit.Unity;

namespace RogueTraderUnityToolkit.Loaders;

public readonly struct AssetBundleLoader : IAssetLoader
{
    public bool CanRead(SerializedAssetInfo info) => AssetBundle.CanRead(info);
    public ISerializedAsset Read(SerializedAssetInfo info) => AssetBundle.Read(info);
}
