using RogueTraderUnityToolkit.Helper;

namespace RogueTraderUnityToolkit.Unity;

public sealed class SerializedResourceFile(AssetDatabaseLoader loader) : ISerializedAsset
{
    public static AssetDatabaseImporter Importer => new(CanRead, Read);
    public AssetDatabaseLoader Loader => loader;

    public static bool CanRead(AssetDatabaseLoader loader) => true;
    public static SerializedResourceFile Read(AssetDatabaseLoader loader) => new(loader);

    public string Identifier => loader.Identifier;
    public long Size => loader.Size;
    public Stream OpenStream() => loader.OpenStream();
}
