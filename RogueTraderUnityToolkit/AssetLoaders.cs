using RogueTraderUnityToolkit.Unity.File;

namespace RogueTraderUnityToolkit;

public interface IAssetLoader
{
    public bool CanRead(SerializedAssetInfo info);
    public ISerializedAsset Read(SerializedAssetInfo info);
}

public readonly struct AssetBundleLoader : IAssetLoader
{
    public bool CanRead(SerializedAssetInfo info) => AssetBundle.CanRead(info);
    public ISerializedAsset Read(SerializedAssetInfo info) => AssetBundle.Read(info);
}

public readonly struct SerializedFileLoader : IAssetLoader
{
    public bool CanRead(SerializedAssetInfo info) => SerializedFile.CanRead(info);
    public ISerializedAsset Read(SerializedAssetInfo info) => SerializedFile.Read(info);
}

public readonly struct ResourceFileLoader : IAssetLoader
{
    public bool CanRead(SerializedAssetInfo info) => ResourceFile.CanRead(info);
    public ISerializedAsset Read(SerializedAssetInfo info) => ResourceFile.Read(info);
}
