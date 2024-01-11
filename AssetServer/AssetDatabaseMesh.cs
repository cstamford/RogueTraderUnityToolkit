using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity.File;
using RogueTraderUnityToolkit.UnityGenerated.Types;
using RogueTraderUnityToolkit.UnityGenerated.Types.Engine;
using System.Diagnostics;

namespace AssetServer;

public readonly record struct AssetDatabaseMesh(
    AsciiString Name,
    SubMesh[] SubMeshes,
    int IndexCount,
    int IndexFormat,
    byte[] IndexData,
    int VertexCount,
    int VertexSize,
    (int, ChannelInfo)[] VertexChannels,
    byte[] VertexStreamData)
{
    public static AssetDatabaseMesh Read(AssetDatabasePtr<Mesh> ptr)
    {
        Mesh mesh = ptr.Fetch();

        Debug.Assert(mesh.m_MeshCompression == 0, "We don't support compressed meshes yet.");

        byte[] vertexData;

        if (mesh.m_StreamData.path != "")
        {
            string path = mesh.m_StreamData.path.ToString().Split('/').Last();
            ResourceFile file = (ResourceFile)AssetDatabaseStorage.Assets[path];
            using Stream stream = file.Info.Open((long)mesh.m_StreamData.offset, mesh.m_StreamData.size);
            vertexData = new byte[mesh.m_StreamData.size];
            _ = stream.Read(vertexData);
        }
        else
        {
            vertexData = mesh.m_VertexData.m_DataSize;
        }

        ChannelInfo lastChannel = mesh.m_VertexData.m_Channels.MaxBy(x => x.offset);

        return new(
            mesh.m_Name,
            mesh.m_SubMeshes,
            mesh.m_IndexBuffer.Length / (mesh.m_IndexFormat == 0 ? 2 : 4),
            mesh.m_IndexFormat,
            mesh.m_IndexBuffer,
            (int)mesh.m_VertexData.m_VertexCount,
            lastChannel.offset + ((VertexAttributeFormat)lastChannel.format).Size() * (lastChannel.dimension & 0xF),
            mesh.m_VertexData.m_Channels.Select((x, i) => (i, x)).Where(x => x.x.dimension != 0).ToArray(),
            vertexData);
    }
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
