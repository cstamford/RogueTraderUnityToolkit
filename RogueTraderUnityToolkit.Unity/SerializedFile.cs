using RogueTraderUnityToolkit.Core;

namespace RogueTraderUnityToolkit.Unity
{
    public sealed record SerializedFile(
        SerializedFileHeader Header,
        SerializedFileTarget Target,
        SerializedFileObject[] Objects,
        SerializedFileObjectInstance[] ObjectInstances,
        SerializedFileObjectFileRef[] ObjectFileRefs,
        SerializedFileReferences[] References,
        SerializedFileTypeReference[] TypeReferences,
        string Comment) 
        : ISerializedAsset
    {
        public SerializedAssetInfo Info => _info;
    
        public static bool CanRead(SerializedAssetInfo info)
        {
            using Stream stream = info.Open(0, 48);
            EndianBinaryReader reader = new(stream, 0, 48);
            return SerializedFileHeader.Read(reader).TotalSize == info.Size;
        }

        public static SerializedFile Read(SerializedAssetInfo info)
        {
            using Stream stream = info.Open();

            SerializedFileHeader header = SerializedFileHeader.Read(new(stream));
            EndianBinaryReader reader = new(stream, header.IsBigEndian);

            SerializedFileTarget target = SerializedFileTarget.Read(reader);
            SerializedFileObject[] objectTypes = reader.ReadArray(SerializedFileObject.Read);
            SerializedFileObjectInstance[] objectInstances = reader.ReadArray(SerializedFileObjectInstance.Read);
            SerializedFileObjectFileRef[] objectFileRefs = reader.ReadArray(SerializedFileObjectFileRef.Read);
            SerializedFileReferences[] references = reader.ReadArray(SerializedFileReferences.Read);
            SerializedFileTypeReference[] typeReferences = reader.ReadArray(SerializedFileTypeReference.Read);
            string comment = reader.ReadStringUntilNull();

            return new(
                Header: header,
                Target: target,
                Objects: objectTypes,
                ObjectInstances: objectInstances,
                ObjectFileRefs: objectFileRefs,
                References: references,
                TypeReferences: typeReferences,
                Comment: comment)
            {
                _info = info
            };
        }
    
        private SerializedAssetInfo _info = default!;
    }

    public readonly record struct SerializedFileHeader(
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
                throw new($"Expected version {_version} but got {version}.");
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

    public readonly record struct SerializedFileTarget(
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
                throw new($"Expected version {_version} but got {version}.");
            }

            if (platform != _platform)
            {
                throw new($"Expected unityVersion {_platform} but got {platform}.");
            }

            if (!withTypeInfo)
            {
                throw new($"Serialized file without type info, cannot read.");
            }

            return new(
                Version: version,
                Platform: platform,
                WithTypeInfo: withTypeInfo);
        }

        private const string _version = "2022.3.7f1";
        private const uint _platform = 19;
    }

    public readonly record struct SerializedFileObject(
        SerializedFileObjectInfo Info,
        ObjectTypeTree Tree,
        int[] Dependencies)
    {
        public static SerializedFileObject Read(EndianBinaryReader reader)
        {
            SerializedFileObjectInfo info = SerializedFileObjectInfo.Read(reader);
            ObjectTypeTree tree = ObjectTypeTree.Read(reader);
            int[] dependencies = reader.ReadArray(x => x.ReadS32());

            return new(
                Info: info,
                Tree: tree,
                Dependencies: dependencies);
        }
    }

    public readonly record struct SerializedFileObjectInfo(
        UnityObjectType Type,
        bool IsStripped,
        ushort ScriptTypeIdx,
        Hash128? ScriptHash,
        Hash128 Hash)
    {
        public static SerializedFileObjectInfo Read(EndianBinaryReader reader)
        {
            UnityObjectType type = (UnityObjectType)reader.ReadS32();
            bool isStripped = reader.ReadB8();
            ushort scriptTypeIdx = reader.ReadU16();

            bool hasScriptType = type is UnityObjectType.TypeRef or UnityObjectType.MonoBehaviour;
            bool hasScriptTypeIdx = scriptTypeIdx != 0xFFFF;

            if (!hasScriptType && hasScriptTypeIdx)
            {
                throw new($"Unexpected custom scriptTypeIdx {scriptTypeIdx} with type {type}.");
            }

            Hash128? scriptHash = hasScriptType ? Hash128.Read(reader) : default;
            Hash128 hash = Hash128.Read(reader);

            return new(
                Type: type,
                IsStripped: isStripped,
                ScriptTypeIdx: scriptTypeIdx,
                ScriptHash: scriptHash,
                Hash: hash);
        }
    }

    public readonly record struct SerializedFileObjectInstance(
        long Id,
        long Offset,
        int Size,
        int TypeIdx)
    {
        public static SerializedFileObjectInstance Read(EndianBinaryReader reader)
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

    public readonly record struct SerializedFileObjectFileRef(
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

    public readonly record struct SerializedFileReferences(
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

    public readonly record struct SerializedFileTypeReference(
        SerializedFileObjectInfo Info,
        ObjectTypeTree Tree,
        string Class,
        string Namespace,
        string Assembly)
    {
        public static SerializedFileTypeReference Read(EndianBinaryReader reader)
        {
            SerializedFileObjectInfo info = SerializedFileObjectInfo.Read(reader);
            ObjectTypeTree tree = ObjectTypeTree.Read(reader);
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
}
