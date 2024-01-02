namespace RogueTraderUnityToolkit.Unity.File;

public sealed record ResourceFile(
    SerializedAssetInfo Info)
    : ISerializedAsset
{
    public static bool CanRead(SerializedAssetInfo _) => true;
    public static ResourceFile Read(SerializedAssetInfo info) => new(info);

    public override string ToString() => $"{Info} {Info.Size} bytes";
}
