using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity.File;
using RogueTraderUnityToolkit.UnityGenerated.Types;
using RogueTraderUnityToolkit.UnityGenerated.Types.Engine;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace AssetServer;

public readonly record struct AssetDatabaseMesh(
    MeshSubMesh[] SubMeshes,
    IndexFormat IndicesFormat,
    uint[] Indices,
    MeshVertexData[] Vertices)
{
    public MeshVertexData GetAttributes(VertexAttribute attr)
    {
        bool hasPosition = TryGetAttributes(VertexAttribute.Position, out MeshVertexData positionData);
        Debug.Assert(hasPosition);
        return positionData;
    }

    public bool TryGetAttributes(VertexAttribute attr, out MeshVertexData data)
    {
        data = Vertices.FirstOrDefault(x => attr == x.Attribute);
        return data != default;
    }

    public static AssetDatabaseMesh Read(AssetDatabasePtr<Mesh> ptr)
    {
        Mesh mesh = ptr.Fetch();

        Debug.Assert(mesh.m_MeshCompression == 0,
            "We don't support compressed meshes yet.");

        EndianBinaryReader reader = new(new MemoryStream(mesh.m_IndexBuffer), ptr.File.Header.IsBigEndian);
        IndexFormat indexFormat = (IndexFormat)mesh.m_IndexFormat;
        int indexSize = indexFormat.Size();

        uint[] indices = new uint[mesh.m_IndexBuffer.Length / indexSize];

        for (int i = 0; i < mesh.m_IndexBuffer.Length; i += indexSize)
        {
            indices[i / indexSize] = indexFormat == IndexFormat.UInt16 ? reader.ReadU16() : reader.ReadU32();
        }

        Debug.Assert(mesh.m_SubMeshes.All(x => x.topology == 0),
            "Non triangle topology, ruh-row!");

        MeshSubMesh[] subMeshes = mesh.m_SubMeshes.Select(x => new MeshSubMesh((int)(x.firstByte / indexSize), (int)x.indexCount)).ToArray();

        Debug.Assert(mesh.m_VertexData.m_DataSize.Length == 0 || mesh.m_StreamData.size == 0,
            "We had both m_DataSize and m_StreamSize set?");

        Stream stream;

        if (mesh.m_StreamData.path != "")
        {
            string path = mesh.m_StreamData.path.ToString().Split('/').Last();
            ResourceFile file = (ResourceFile)AssetDatabaseStorage.Assets[path];
            stream = file.Info.Open((long)mesh.m_StreamData.offset, mesh.m_StreamData.size);
            reader = new(stream, ptr.File.Header.IsBigEndian);
        }
        else
        {
            stream = new MemoryStream(mesh.m_VertexData.m_DataSize);
            reader = new(stream, ptr.File.Header.IsBigEndian);
        }

        IEnumerable<(ChannelInfo, VertexAttribute, int)> activeChannels = mesh.m_VertexData.m_Channels
            .Select((x, i) => (x, (VertexAttribute)i, x.dimension & 0xF)).Where(x => x.x.dimension > 0);

        MeshVertexData[] vertices = activeChannels
            .Select(x => new MeshVertexData(
                x.Item2,
                (VertexAttributeFormat)x.Item1.format,
                x.Item3,
                new MeshVertex[mesh.m_VertexData.m_VertexCount * x.Item3]))
            .ToArray();

        Span<byte> conversionBuffer = stackalloc byte[4];

        for (int i = 0; i < mesh.m_VertexData.m_VertexCount; ++i)
        {
            foreach (MeshVertexData data in vertices)
            {
                Debug.Assert(i != 0 || reader.Position == activeChannels.First(x => x.Item2 == data.Attribute).Item1.offset,
                    "The offsets in the channels are weird, so we're going to read out of order.");

                VertexAttributeFormat format = data.Format;
                int size = format.Size();

                for (int j = i * data.Stride; j < i * data.Stride + data.Stride; ++j)
                {
                    if (format == VertexAttributeFormat.Float16)
                    {
                        reader.ReadSwap16(conversionBuffer[..2]);
                        Half f16 = MemoryMarshal.Read<Half>(conversionBuffer[..2]);
                        data.Vertices[j] = new() { f32 = (float)f16 };
                        continue;
                    }

                    if (format == VertexAttributeFormat.Float32)
                    {
                        data.Vertices[j] = new() { f32 = reader.ReadF32() };
                        continue;
                    }

                    reader.Seek(size);
                }
            }
        }

        Debug.Assert(reader.Remaining == 0);

        stream.Dispose();
        return new(subMeshes, indexFormat, indices, vertices);
    }
}

public readonly record struct MeshSubMesh(int IndexOffset, int IndexCount);

public readonly record struct MeshVertexData(
    VertexAttribute Attribute,
    VertexAttributeFormat Format,
    int Stride,
    MeshVertex[] Vertices)
{
    public override string ToString() => $"{Attribute} {Format} [{Stride}] {Vertices.Length}";
}

[StructLayout(LayoutKind.Explicit)]
public struct MeshVertex
{
    [FieldOffset(0)] public float f32;
    public override string ToString() => $"{f32:F8}";
}

// ref: https://docs.unity3d.com/ScriptReference/Rendering.IndexFormat.html
public enum IndexFormat
{
    UInt16,
    UInt32
}

// ref: https://docs.unity3d.com/ScriptReference/Rendering.VertexAttribute.html
public enum VertexAttribute
{
    Position,
    Normal,
    Tangent,
    Color,
    TexCoord0,
    TexCoord1,
    TexCoord2,
    TexCoord3,
    TexCoord4,
    TexCoord5,
    TexCoord6,
    TexCoord7,
    BlendWeight,
    BlendIndices
}

// ref: https://docs.unity3d.com/ScriptReference/Rendering.VertexAttributeFormat.html
public enum VertexAttributeFormat
{
    Float32,
    Float16,
    UNorm8,
    SNorm8,
    UNorm16,
    SNorm16,
    UInt8,
    SInt8,
    UInt16,
    SInt16,
    UInt32,
    SInt32,
}
