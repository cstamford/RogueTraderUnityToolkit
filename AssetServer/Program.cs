using AssetServer;
using RogueTraderUnityToolkit.Core;
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
DebugSceneDisplay.DrawScene(db.LoadScene(AsciiString.From("CassiaRoom_StaticForArt")));

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

    while (client.Connected)
    {
        int bytes = await stream.ReadAsync(buffer[..1]);
        if (bytes != 1) break;

        AssetDatabaseRequestType request = (AssetDatabaseRequestType)buffer.Span[0];

        if (request == AssetDatabaseRequestType.Scene)
        {
            bytes = await stream.ReadAsync(buffer[..4]);
            Debug.Assert(bytes == 4);

            int sceneLength = BinaryPrimitives.ReadInt32BigEndian(buffer[..4].Span);
            bytes = await stream.ReadAsync(buffer[..sceneLength]);
            Debug.Assert(bytes == sceneLength);

            AsciiString sceneName = AsciiString.From(buffer[..sceneLength].Span);

            Log.Write($"Received {request} for {sceneName}");

            AssetDatabaseScene scene = db.LoadScene(sceneName);

            Log.Write($"Sending {scene.RootObjects} objects, roots are {string.Join(", ", scene.RootObjects.Select(x => x.Name))}");

            buffer.Span[0] = (byte)request;
            await stream.WriteAsync(buffer[..1]);

            BinaryPrimitives.WriteInt32BigEndian(buffer[..4].Span, scene.RootObjects.Length);
            await stream.WriteAsync(buffer[..4]);

            foreach (AssetDatabaseSceneObject root in scene.RootObjects)
            {
                await SendObject(stream, buffer, root);
            }
        }

        Thread.Sleep(100);
    }
}

async Task SendManifest(
    Stream stream,
    Memory<byte> buffer)
{
    IEnumerable<AsciiString> scenes = db.Scenes;

    BinaryPrimitives.WriteInt32BigEndian(buffer[..4].Span, scenes.Count());
    await stream.WriteAsync(buffer[..4]);

    foreach (AsciiString scene in scenes)
    {
        BinaryPrimitives.WriteInt32BigEndian(buffer[..4].Span, scene.Length);
        await stream.WriteAsync(buffer[..4]);
        await stream.WriteAsync(scene.Memory);
    }
}

async Task SendObject(Stream stream, Memory<byte> buffer, AssetDatabaseSceneObject obj)
{
    BinaryPrimitives.WriteInt32BigEndian(buffer[..4].Span, obj.Name.Length);

    await stream.WriteAsync(buffer[..4]);
    await stream.WriteAsync(obj.Name.Memory);

    BinaryPrimitives.WriteSingleBigEndian(buffer[..4].Span, obj.Transform.m_LocalPosition.x);
    await stream.WriteAsync(buffer[..4]);

    BinaryPrimitives.WriteSingleBigEndian(buffer[..4].Span, obj.Transform.m_LocalPosition.y);
    await stream.WriteAsync(buffer[..4]);

    BinaryPrimitives.WriteSingleBigEndian(buffer[..4].Span, obj.Transform.m_LocalPosition.z);
    await stream.WriteAsync(buffer[..4]);

    BinaryPrimitives.WriteSingleBigEndian(buffer[..4].Span, obj.Transform.m_LocalRotation.x);
    await stream.WriteAsync(buffer[..4]);

    BinaryPrimitives.WriteSingleBigEndian(buffer[..4].Span, obj.Transform.m_LocalRotation.y);
    await stream.WriteAsync(buffer[..4]);

    BinaryPrimitives.WriteSingleBigEndian(buffer[..4].Span, obj.Transform.m_LocalRotation.z);
    await stream.WriteAsync(buffer[..4]);

    BinaryPrimitives.WriteSingleBigEndian(buffer[..4].Span, obj.Transform.m_LocalRotation.w);
    await stream.WriteAsync(buffer[..4]);

    BinaryPrimitives.WriteSingleBigEndian(buffer[..4].Span, obj.Transform.m_LocalScale.x);
    await stream.WriteAsync(buffer[..4]);

    BinaryPrimitives.WriteSingleBigEndian(buffer[..4].Span, obj.Transform.m_LocalScale.y);
    await stream.WriteAsync(buffer[..4]);

    BinaryPrimitives.WriteSingleBigEndian(buffer[..4].Span, obj.Transform.m_LocalScale.z);
    await stream.WriteAsync(buffer[..4]);

    bool hasMesh = obj.Mesh.HasValue;
    buffer.Span[0] = (byte)(hasMesh ? 1 : 0);
    await stream.WriteAsync(buffer[..1]);

    if (hasMesh)
    {
        AssetDatabaseMesh mesh = obj.Mesh!.Value;

        // TODO: Send int16 indices if available

        BinaryPrimitives.WriteInt32BigEndian(buffer[..4].Span, mesh.Indices.Length);
        await stream.WriteAsync(buffer[..4]);

        foreach (uint idx in mesh.Indices)
        {
            BinaryPrimitives.WriteUInt32BigEndian(buffer[..4].Span, idx);
            await stream.WriteAsync(buffer[..4]);
        }

        bool hasPosition = mesh.TryGetAttributes(VertexAttribute.Position, out MeshVertexData positionData);
        Debug.Assert(hasPosition);
        Debug.Assert(positionData.Stride == 3);

        int vertCount = positionData.Vertices.Length / positionData.Stride;
        BinaryPrimitives.WriteInt32BigEndian(buffer[..4].Span, vertCount);
        await stream.WriteAsync(buffer[..4]);

        foreach (MeshVertex vtx in positionData.Vertices)
        {
            BinaryPrimitives.WriteSingleBigEndian(buffer[..4].Span, vtx.f32);
            await stream.WriteAsync(buffer[..4]);
        }

        // TODO: send submeshes
    }

    BinaryPrimitives.WriteInt32BigEndian(buffer[..4].Span, obj.Children.Length);
    await stream.WriteAsync(buffer[..4]);

    foreach (AssetDatabaseSceneObject child in obj.Children)
    {
        await SendObject(stream, buffer, child);
    }
}

enum AssetDatabaseRequestType : byte
{
    Scene
};
