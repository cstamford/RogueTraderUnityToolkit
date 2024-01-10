using AssetServer;
using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.UnityGenerated;
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
AssetDatabaseScene testScene = db.LoadScene(AsciiString.From("VoidshipBridge_RTCabin_StaticForArt"));

AssetDatabaseSceneObject obj = testScene.RootObjects
    .MaxBy(x => x.Children.Length).Children
    .Where(x => x.Mesh.HasValue)
    .MaxBy(x => x.Mesh!.Value.Indices.Indices.Length);

AssetDatabaseMesh mesh = obj.Mesh.Value!;
int start = mesh.SubMeshes[0].IndexOffset;
int end = start + mesh.SubMeshes[0].IndexCount;
mesh.TryGetAttributes(VertexAttribute.Position, out MeshVertexData data);
DebugMeshDisplay.DrawMesh(data, mesh.Indices.Indices[start..end]);

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

            /*
            db.LoadScene(
                sceneName,
                out List<GameObject> roots,
                out Dictionary<GameObject, List<GameObject>> scene,
                out Dictionary<GameObject, IUnityObject[]> sceneComponents);

            Log.Write($"Sending {scene.Count} objects, roots are {string.Join(", ", roots.Select(x => x.m_Name))}");

            buffer.Span[0] = (byte)request;
            await stream.WriteAsync(buffer[..1]);

            BinaryPrimitives.WriteInt32BigEndian(buffer[..4].Span, scene.Count);
            await stream.WriteAsync(buffer[..4]);

            foreach (GameObject root in roots)
            {
                await SendAllObjects(stream, buffer, scene, sceneComponents, root);
            }
            */
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

async Task SendAllObjects(
    Stream stream,
    Memory<byte> buffer,
    IReadOnlyDictionary<GameObject, List<GameObject>> scene,
    IReadOnlyDictionary<GameObject, IUnityObject[]> sceneComponents,
    GameObject obj)
{
    BinaryPrimitives.WriteInt32BigEndian(buffer[..4].Span, obj.m_Name.Length);

    await stream.WriteAsync(buffer[..4]);
    await stream.WriteAsync(obj.m_Name.Memory);

    Transform transform = sceneComponents[obj].OfType<Transform>().First();

    BinaryPrimitives.WriteSingleBigEndian(buffer[..4].Span, transform.m_LocalPosition.x);
    await stream.WriteAsync(buffer[..4]);

    BinaryPrimitives.WriteSingleBigEndian(buffer[..4].Span, transform.m_LocalPosition.y);
    await stream.WriteAsync(buffer[..4]);

    BinaryPrimitives.WriteSingleBigEndian(buffer[..4].Span, transform.m_LocalPosition.z);
    await stream.WriteAsync(buffer[..4]);

    List<GameObject> children = scene[obj];

    BinaryPrimitives.WriteInt32BigEndian(buffer[..4].Span, children.Count);
    await stream.WriteAsync(buffer[..4]);

    foreach (GameObject child in scene[obj])
    {
        await SendAllObjects(stream, buffer, scene, sceneComponents, child);
    }
}

enum AssetDatabaseRequestType : byte
{
    Scene
};
