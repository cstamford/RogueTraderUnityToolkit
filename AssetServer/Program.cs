using AssetServer;
using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.UnityGenerated.Types;
using RogueTraderUnityToolkit.UnityGenerated.Types.Engine;
using System.Buffers.Binary;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

List<FileInfo> files = Directory
    .EnumerateFiles(@"C:\Program Files (x86)\Steam\steamapps\common\Warhammer 40,000 Rogue Trader", "*", SearchOption.AllDirectories)
    .Select(x => new FileInfo(x))
    .Where(x => x.Length > 0)
    .OrderByDescending(x => x.Length)
    .ToList();

AssetDatabase db = new(files);
TcpListener tcpListener = new (IPAddress.Loopback, 16253);
tcpListener.Start();

while (true)
{
    Console.WriteLine("Waiting for a connection...");
    TcpClient client = await tcpListener.AcceptTcpClientAsync();
    Console.WriteLine("Connected!");
    _ = Task.Run(() => HandleClientAsync(client));
}

async Task HandleClientAsync(TcpClient client)
{
    using TcpClient _ = client;
    await using NetworkStream stream = client.GetStream();

    Memory<byte> buffer = new byte[4096];
    await SendManifest(stream, buffer);

    try
    {
        while (client.Connected)
        {
            int bytes = await stream.ReadAsync(buffer[..1]);
            if (bytes != 1) break;

            RequestType request = (RequestType)buffer.Span[0];

            if (request == RequestType.Scene)
            {
                bytes = await stream.ReadAsync(buffer[..4]);
                Debug.Assert(bytes == 4);

                int sceneLength = BinaryPrimitives.ReadInt32BigEndian(buffer[..4].Span);
                bytes = await stream.ReadAsync(buffer[..sceneLength]);
                Debug.Assert(bytes == sceneLength);

                AsciiString sceneName = AsciiString.From(buffer[..sceneLength].Span);
                Log.Write($"Received {request} for {sceneName}");
                AssetDatabaseScene scene = db.LoadScene(sceneName);

                buffer.Span[0] = (byte)request;
                await stream.WriteAsync(buffer[..1]);

                BinaryPrimitives.WriteInt32BigEndian(buffer[..4].Span, scene.RootObjects.Length);
                await stream.WriteAsync(buffer[..4]);

                BufferedStream bufferedStream = new(stream, 1024 * 128);

                foreach (AssetDatabaseSceneObject root in scene.RootObjects)
                {
                    await SendObject(bufferedStream, buffer, root);
                    await bufferedStream.FlushAsync();
                }

                await bufferedStream.FlushAsync();
            }
        }
    }
    catch (Exception ex)
    {
        Log.Write($"Network {ex}", ConsoleColor.Red);
    }
}

async Task SendManifest(
    Stream stream,
    Memory<byte> buffer)
{
    await stream.WriteAsync(buffer, db.Scenes.Count());

    foreach (AsciiString scene in db.Scenes)
    {
        await stream.WriteAsync(buffer, scene);
    }
}

async Task SendObject(Stream stream, Memory<byte> buffer, AssetDatabaseSceneObject obj)
{
    await stream.WriteAsync(buffer, obj.Name);
    await stream.WriteAsync(buffer, obj.Transform);
    await stream.WriteAsync(buffer, obj.Mesh.HasValue);

    if (obj.Mesh.HasValue)
    {
        await stream.WriteAsync(buffer, obj.Mesh.Value);
    }

    await stream.WriteAsync(buffer, obj.MeshMaterials.Length);

    foreach (AssetDatabaseMaterial material in obj.MeshMaterials)
    {
        await stream.WriteAsync(buffer, material);
    }

    await stream.WriteAsync(buffer, obj.Children.Length);

    foreach (AssetDatabaseSceneObject child in obj.Children)
    {
        await SendObject(stream, buffer, child);
    }
}

internal static class Extensions
{
    public static async Task WriteAsync(this Stream stream, Memory<byte> buffer, int i32)
    {
        BinaryPrimitives.WriteInt32BigEndian(buffer[..4].Span, i32);
        await stream.WriteAsync(buffer[..4]);
    }

    public static async Task WriteAsync(this Stream stream, Memory<byte> buffer, uint u32)
    {
        BinaryPrimitives.WriteUInt32BigEndian(buffer[..4].Span, u32);
        await stream.WriteAsync(buffer[..4]);
    }

    public static async Task WriteAsync(this Stream stream, Memory<byte> buffer, float f32)
    {
        BinaryPrimitives.WriteSingleBigEndian(buffer[..4].Span, f32);
        await stream.WriteAsync(buffer[..4]);
    }

    public static async Task WriteAsync(this Stream stream, Memory<byte> buffer, bool b)
    {
        buffer.Span[0] = (byte)(b ? 1 : 0);
        await stream.WriteAsync(buffer[..1]);
    }

    public static async Task WriteAsync(this Stream stream, Memory<byte> buffer, AsciiString str)
    {
        await stream.WriteAsync(buffer, str.Length);
        await stream.WriteAsync(str.Memory);
    }

    public static async Task WriteAsync(this Stream stream, Memory<byte> buffer, Transform transform)
    {
        await stream.WriteAsync(buffer, transform.m_LocalPosition.x);
        await stream.WriteAsync(buffer, transform.m_LocalPosition.y);
        await stream.WriteAsync(buffer, transform.m_LocalPosition.z);

        await stream.WriteAsync(buffer, transform.m_LocalRotation.x);
        await stream.WriteAsync(buffer, transform.m_LocalRotation.y);
        await stream.WriteAsync(buffer, transform.m_LocalRotation.z);
        await stream.WriteAsync(buffer, transform.m_LocalRotation.w);

        await stream.WriteAsync(buffer, transform.m_LocalScale.x);
        await stream.WriteAsync(buffer, transform.m_LocalScale.y);
        await stream.WriteAsync(buffer, transform.m_LocalScale.z);
    }

    public static async Task WriteAsync(this Stream stream, Memory<byte> buffer, AssetDatabaseMesh mesh)
    {
        await stream.WriteAsync(buffer, mesh.Name);
        await stream.WriteAsync(buffer, mesh.SubMeshes.Length);

        foreach (SubMesh submesh in mesh.SubMeshes)
        {
            await stream.WriteAsync(buffer, (int)submesh.firstByte / (mesh.IndexFormat == 0 ? 2 : 4));
            await stream.WriteAsync(buffer, (int)submesh.indexCount);
            await stream.WriteAsync(buffer, submesh.topology);
            await stream.WriteAsync(buffer, submesh.localAABB.m_Center.x);
            await stream.WriteAsync(buffer, submesh.localAABB.m_Center.y);
            await stream.WriteAsync(buffer, submesh.localAABB.m_Center.z);
            await stream.WriteAsync(buffer, submesh.localAABB.m_Extent.x);
            await stream.WriteAsync(buffer, submesh.localAABB.m_Center.y);
            await stream.WriteAsync(buffer, submesh.localAABB.m_Center.z);
            await stream.WriteAsync(buffer, (int)submesh.baseVertex);
            await stream.WriteAsync(buffer, (int)submesh.firstVertex);
            await stream.WriteAsync(buffer, (int)submesh.vertexCount);
        }

        await stream.WriteAsync(buffer, mesh.IndexCount);
        await stream.WriteAsync(buffer, mesh.IndexFormat);
        await stream.WriteAsync(mesh.IndexData);

        await stream.WriteAsync(buffer, mesh.VertexCount);
        await stream.WriteAsync(buffer, mesh.VertexSize);
        await stream.WriteAsync(buffer, mesh.VertexChannels.Length);

        foreach ((int attr, ChannelInfo channel) in mesh.VertexChannels)
        {
            await stream.WriteAsync(buffer, attr);
            await stream.WriteAsync(buffer, channel.format);
            await stream.WriteAsync(buffer, channel.dimension & 0xF);
        }

        await stream.WriteAsync(buffer, mesh.VertexStreamData.Length);
        await stream.WriteAsync(mesh.VertexStreamData);
    }

    public static async Task WriteAsync(this Stream stream, Memory<byte> buffer, AssetDatabaseMaterial mat)
    {
        await stream.WriteAsync(buffer, mat.Name);
        await stream.WriteAsync(buffer, mat.Textures.Count);

        foreach ((AsciiString name, AssetDatabaseTexture texture) in mat.Textures)
        {
            await stream.WriteAsync(buffer, name);
            await stream.WriteAsync(buffer, texture);
        }
    }

    public static async Task WriteAsync(this Stream stream, Memory<byte> buffer, AssetDatabaseTexture tex)
    {
        await stream.WriteAsync(buffer, tex.Name);
        await stream.WriteAsync(buffer, tex.Width);
        await stream.WriteAsync(buffer, tex.Height);
        await stream.WriteAsync(buffer, (int)tex.Format);
        await stream.WriteAsync(buffer, tex.Settings.m_FilterMode);
        await stream.WriteAsync(buffer, tex.Settings.m_Aniso);
        await stream.WriteAsync(buffer, tex.Settings.m_MipBias);
        await stream.WriteAsync(buffer, tex.Settings.m_WrapU);
        await stream.WriteAsync(buffer, tex.Settings.m_WrapV);
        await stream.WriteAsync(buffer, tex.Settings.m_WrapW);
        await stream.WriteAsync(buffer, tex.Data.Length);
        await stream.WriteAsync(tex.Data);
    }
}

enum RequestType : byte
{
    Scene
};
