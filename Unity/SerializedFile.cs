using RogueTraderUnityToolkit.Helper;

namespace RogueTraderUnityToolkit.Unity;

public record class SerializedFile(
    SerializedFileHeader Header,
    SerializedFileTarget Target,
    SerializedObjectType[] ObjectTypes,
    SerializedFileObjectManifest[] ObjectManifests,
    SerializedFileObjectFileRef[] ObjectFileRefs,
    SerializedFileReferences[] References,
    SerializedFileTypeReference[] TypeReferences,
    string Comment) : ISerializedAsset
{
    public static AssetDatabaseImporter Importer => new(CanRead, Read);
    public AssetDatabaseLoader Loader => _loader;

    public static bool CanRead(AssetDatabaseLoader loader)
    {
        using Stream stream = loader.OpenStream(0, _headerEndOffset);
        EndianBinaryReader reader = new(stream, 0, _headerEndOffset);
        return SerializedFileHeader.Read(reader).TotalSize == loader.Size;
    }

    public static SerializedFile Read(AssetDatabaseLoader loader)
    {
        using Stream stream = loader.OpenStream();

        SerializedFileHeader header = SerializedFileHeader.Read(new(stream));
        EndianBinaryReader reader = new(stream, header.IsBigEndian);

        SerializedFileTarget target = SerializedFileTarget.Read(reader);
        SerializedObjectType[] objectTypes = reader.ReadArray(SerializedObjectType.Read);
        SerializedFileObjectManifest[] objectManifests = reader.ReadArray(SerializedFileObjectManifest.Read);
        SerializedFileObjectFileRef[] objectFileRefs = reader.ReadArray(SerializedFileObjectFileRef.Read);
        SerializedFileReferences[] references = reader.ReadArray(SerializedFileReferences.Read);
        SerializedFileTypeReference[] typeReferences = reader.ReadArray(SerializedFileTypeReference.Read);
        string comment = reader.ReadStringUntilNull();

        return new(
            Header: header,
            Target: target,
            ObjectTypes: objectTypes,
            ObjectManifests: objectManifests,
            ObjectFileRefs: objectFileRefs,
            References: references,
            TypeReferences: typeReferences,
            Comment: comment)
        {
            _loader = loader
        };
    }

    public void ReadObjectRange(int startIdx, int endIdx, ISerializedObjectReader? extReader)
    {
        using var _ = Util.PerfScopeDatabase("SerializedFile/ReadObjectRange");

        long offsetStart = _loader!.Size;
        long offsetEnd = 0;

        for (int i = startIdx; i < endIdx; ++i)
        {
            ref SerializedFileObjectManifest manifest = ref ObjectManifests[i];
            offsetStart = Math.Min(offsetStart, manifest.Offset);
            offsetEnd = Math.Max(offsetEnd, manifest.Offset + manifest.Size);
        }

        using Stream stream = _loader.OpenStream(Header.DataOffset + offsetStart, offsetEnd - offsetStart);
        EndianBinaryReader reader = new(stream, Header.IsBigEndian);

        SerializedObjectParser parser = new();

        extReader ??= new SerializedObjectNullReader();

#if DEBUG
        extReader = new SerializedObjectMultiReader([
            new SerializedObjectConditionalDebugReader(() => parser.Offset),
            extReader]);
#endif

        for (int i = startIdx; i < endIdx; ++i)
        {
            ref SerializedFileObjectManifest manifest = ref ObjectManifests[i];
            int objectBase = (int)(manifest.Offset - offsetStart);

            reader.Position = objectBase;
            parser.Read(ObjectTypes[manifest.TypeIdx], manifest, TypeReferences, reader, extReader);
 
            if (parser.Offset != manifest.Size)
            {
                throw new Exception($"SerializedFile: Expected {manifest.Size} bytes but read {parser.Offset}.");
            }
        }
    }

    private AssetDatabaseLoader _loader = default!;
    private const byte _headerEndOffset = 48;
}

public record struct SerializedFileHeader(
    int Version,
    bool IsBigEndian,
    uint ManifestSize,
    long TotalSize,
    long DataOffset)
{
    public static SerializedFileHeader Read(EndianBinaryReader reader)
    {
        reader.UnknownData(8);
        int version = reader.ReadS32();
        reader.UnknownData(4);
        bool isBigEndian = reader.ReadB32();
        uint manifestSize = reader.ReadU32();
        long totalSize = reader.ReadS64();
        long dataOffset = reader.ReadS64();
        reader.UnknownData(8);

        if (version != _version)
        {
            throw new Exception($"SerializedFileHeader: Expected version {_version} but got {version}.");
        }

        return new(
            Version: version,
            IsBigEndian: isBigEndian,
            ManifestSize: manifestSize,
            TotalSize: totalSize,
            DataOffset: dataOffset);
    }

    private const int _version = 22;
}

public record struct SerializedFileTarget(
    string Version,
    uint Platform,
    bool WithTypeInfo)
{
    public static SerializedFileTarget Read(EndianBinaryReader reader)
    {
        string version = reader.ReadStringUntilNull();
        uint platform = reader.ReadU32();
        bool withTypeInfo = reader.ReadB8();

        if (version != _version)
        {
            throw new Exception($"SerializedFileTarget: Expected version {_version} but got {version}.");
        }

        if (platform != _platform)
        {
            throw new Exception($"SerializedFileTarget: Expected unityVersion {_platform} but got {platform}.");
        }

        if (!withTypeInfo)
        {
            throw new Exception($"SerializedFileTarget: Serialized file without type info, cannot read.");
        }

        return new(
            Version: version,
            Platform: platform,
            WithTypeInfo: withTypeInfo);
    }

    private const string _version = SerializedConstants.AssetVersion;
    private const uint _platform = 19;
}

public record struct SerializedFileObjectManifest(
    long Id,
    long Offset,
    int Size,
    int TypeIdx)
{
    public static SerializedFileObjectManifest Read(EndianBinaryReader reader)
    {
        reader.AlignTo(4); // idk why, but this needs to be aligned to 4 here or sometimes we read dummy data

        long id = reader.ReadS64();
        long offset = reader.ReadS64();
        int size = reader.ReadS32();
        int typeIdx = reader.ReadS32();

        return new(
            Id: id,
            Offset: offset,
            Size: size,
            TypeIdx: typeIdx);
    }
}

public record struct SerializedFileObjectFileRef(
    int FileIdx,
    long ObjectId)
{
    public static SerializedFileObjectFileRef Read(EndianBinaryReader reader)
    {
        int fileIdx = reader.ReadS32();
        long objectId = reader.ReadS64();

        return new(
            FileIdx: fileIdx,
            ObjectId: objectId);
    }
}

public record struct SerializedFileReferences(
    string Path,
    Guid Guid,
    int Format,
    string PathUnity)
{
    public static SerializedFileReferences Read(EndianBinaryReader reader)
    {
        string path = reader.ReadStringUntilNull();
        Guid guid = reader.ReadGuid();
        int format = reader.ReadS32();
        string pathUnity = reader.ReadStringUntilNull();

        return new(
            Path: path,
            Guid: guid,
            Format: format,
            PathUnity: pathUnity);
    }
}

public record struct SerializedFileTypeReference(
    SerializedObjectTypeInfo Info,
    SerializedObjectTypeTree Tree,
    string Class,
    string Namespace,
    string Assembly)
{
    public static SerializedFileTypeReference Read(EndianBinaryReader reader)
    {
        SerializedObjectTypeInfo info = SerializedObjectTypeInfo.Read(reader);
        SerializedObjectTypeTree tree = SerializedObjectTypeTree.Read(reader);
        string cls = reader.ReadStringUntilNull();
        string ns = reader.ReadStringUntilNull();
        string asm = reader.ReadStringUntilNull();

        return new(
            Info: info,
            Tree: tree,
            Class: cls,
            Namespace: ns,
            Assembly: asm);
    }
}
