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
        AsciiString Comment) 
        : ISerializedAsset
    {
        public SerializedAssetInfo Info => _info;
    
        public static bool CanRead(SerializedAssetInfo info)
        {
            if (info.Size < 32) return false;
            using Stream stream = info.Open(0, 32);
            EndianBinaryReader reader = new(stream, 0, 32);
            return SerializedFileHeader.CheckLengthAndVersionMatches(reader, info.Size);
        }

        public static SerializedFile Read(SerializedAssetInfo info)
        {
            using Stream stream = info.Open();

            SerializedFileHeader header = SerializedFileHeader.Read(new(stream));
            EndianBinaryReader reader = new(stream, header.IsBigEndian);

            SerializedFileTarget target = SerializedFileTarget.Read(reader);
            
            int objectLen = reader.ReadS32();
            SerializedFileObject[] objectTypes = new SerializedFileObject[objectLen];

            for (int i = 0; i < objectLen; ++i)
            {
                objectTypes[i] = SerializedFileObject.Read(reader, target.WithTypeTree);
            }
            
            SerializedFileObjectInstance[] objectInstances = reader.ReadArray(SerializedFileObjectInstance.Read);
            SerializedFileObjectFileRef[] objectFileRefs = reader.ReadArray(SerializedFileObjectFileRef.Read);
            SerializedFileReferences[] references = reader.ReadArray(SerializedFileReferences.Read);
            SerializedFileTypeReference[] typeReferences = reader.ReadArray(SerializedFileTypeReference.Read);
            AsciiString comment = reader.ReadStringUntilNull();

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
        
        public override string ToString() => $"{_info} ({ObjectInstances.Length} objects)";
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

        public static bool CheckLengthAndVersionMatches(EndianBinaryReader reader, long fileLength)
        {
            reader.Seek(8);
            int version = reader.ReadS32();
            reader.Seek(12);
            long length = reader.ReadS64();

            return version == _version && length == fileLength;
        }

        private const int _version = 22;
    }

    public readonly record struct SerializedFileTarget(
        AsciiString Version,
        uint Platform,
        bool WithTypeTree)
    {
        public static SerializedFileTarget Read(EndianBinaryReader reader)
        {
            AsciiString version = reader.ReadStringUntilNull();
            uint platform = reader.ReadU32();
            bool withTypeTree = reader.ReadB8();

            if (!_supportedVersions.Contains(version))
            {
                throw new($"Got unexpected version {version}. It might still work but it hasn't been tested!");
            }

            if (!_supportedPlatforms.Contains(platform))
            {
                throw new($"Got unexpected platform {platform}. It might still work but it hasn't been tested!");
            }

            return new(
                Version: version,
                Platform: platform,
                WithTypeTree: withTypeTree);
        }

        private static readonly HashSet<AsciiString> _supportedVersions = 
        [ 
            AsciiStringPool.Fetch("2022.3.7f1"u8.ToArray()),
            AsciiStringPool.Fetch("2022.3.6f1"u8.ToArray())
        ];

        private static readonly HashSet<uint> _supportedPlatforms = [5, 19];
    }

    public readonly record struct SerializedFileObject(
        SerializedFileObjectInfo Info,
        ObjectTypeTree? Tree,
        int[] Dependencies)
    {
        public static SerializedFileObject Read(EndianBinaryReader reader, bool withTypeTree)
        {
            SerializedFileObjectInfo info = SerializedFileObjectInfo.Read(reader);
            ObjectTypeTree? tree = null;
            int[] dependencies = Array.Empty<int>();

            if (withTypeTree)
            {
                tree = ObjectTypeTree.Read(reader);
                dependencies = reader.ReadArray(x => x.ReadS32());
            }

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
        AsciiString Path,
        Guid Guid,
        int Format,
        AsciiString PathUnity)
    {
        public static SerializedFileReferences Read(EndianBinaryReader reader)
        {
            AsciiString path = reader.ReadStringUntilNull();
            Guid guid = reader.ReadGuid();
            int format = reader.ReadS32();
            AsciiString pathUnity = reader.ReadStringUntilNull();

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
        AsciiString Class,
        AsciiString Namespace,
        AsciiString Assembly)
    {
        public static SerializedFileTypeReference Read(EndianBinaryReader reader)
        {
            SerializedFileObjectInfo info = SerializedFileObjectInfo.Read(reader);
            ObjectTypeTree tree = ObjectTypeTree.Read(reader);
            AsciiString cls = reader.ReadStringUntilNull();
            AsciiString ns = reader.ReadStringUntilNull();
            AsciiString asm = reader.ReadStringUntilNull();

            return new(
                Info: info,
                Tree: tree,
                Class: cls,
                Namespace: ns,
                Assembly: asm);
        }
    }
}
