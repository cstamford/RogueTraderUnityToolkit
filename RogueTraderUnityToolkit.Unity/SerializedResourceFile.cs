namespace RogueTraderUnityToolkit.Unity;

public sealed record SerializedResourceFile(
    SerializedAssetInfo Info)
    : ISerializedAsset
{
    public static bool CanRead(SerializedAssetInfo _) => true;
    public static SerializedResourceFile Read(SerializedAssetInfo info) => new(info);
}
