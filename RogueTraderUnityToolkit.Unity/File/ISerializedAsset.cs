namespace RogueTraderUnityToolkit.Unity.File;

public interface ISerializedAsset
{
    public SerializedAssetInfo Info { get; }
}

public sealed class SerializedAssetInfo(
    ISerializedAsset? parent,
    string identifier,
    long size,
    Func<long, long, Stream> fnOpen)
{
    public ISerializedAsset? Parent => parent;
    public string Identifier => identifier;
    public long Size => size;

    public object? UserData { get; set; }

    public Stream Open(long offset = 0, long length = 0) => fnOpen(offset, length);

    public override string ToString() => $"{parent?.Info}/{identifier}".TrimStart('/');
}
