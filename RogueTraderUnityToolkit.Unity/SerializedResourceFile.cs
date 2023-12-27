using RogueTraderUnityToolkit.Core;

namespace RogueTraderUnityToolkit.Unity;

public sealed record SerializedResourceFile(
    SerializedAssetInfo Info)
    : ISerializedAsset
{
    public static bool CanRead(SerializedResourceFile _) => true;
    public static SerializedResourceFile Read(SerializedResourceFile info) => new(info);
}
