using AssetServer;
using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.UnityGenerated.Types;
using RogueTraderUnityToolkit.UnityGenerated.Types.Engine;
using System.Buffers.Binary;
using System.Diagnostics;
using System.IO.Pipes;
using System.Net;
using System.Net.Sockets;

List<FileInfo> files = Directory
    .EnumerateFiles(@"C:\Program Files (x86)\Steam\steamapps\common\Warhammer 40,000 Rogue Trader", "*", SearchOption.AllDirectories)
    .Select(x => new FileInfo(x))
    .Where(x => x.Length > 0)
    .OrderByDescending(x => x.Length)
    .ToList();

AssetDatabase db = new(files);

const bool useTcp = false;

if (useTcp)
{
    DoTcpServer();
}
else
{
    DoNamedPipeServer();
}

return;

void DoTcpServer()
{
    TcpListener tcpListener = new (IPAddress.Loopback, 16253);
    tcpListener.Start();

    while (true)
    {
        Console.WriteLine("Waiting for a connection (TCP) ...");
        TcpClient client = tcpListener.AcceptTcpClient();
        Console.WriteLine("Connected!");

        _ = Task.Run(() =>
        {
            try
            {
                MainLoop(readStream: client.GetStream(), writeStream: new BufferedStream(client.GetStream()));
            }
            catch (Exception ex)
            {
                Log.Write(ex.ToString(), ConsoleColor.Red);
            }
            finally
            {
                client.Dispose();
            }
        });
    }
}

void DoNamedPipeServer()
{
    while (true)
    {
        NamedPipeServerStream stream = new("RogueTraderPipe",
            PipeDirection.InOut,
            1,
            PipeTransmissionMode.Byte,
            PipeOptions.Asynchronous,
            inBufferSize: 0,
            outBufferSize: 1024*1024*512);

        try
        {
            Console.WriteLine("Waiting for a connection (Pipes) ...");
            stream.WaitForConnection();
            Console.WriteLine("Connected!");
            MainLoop(readStream: stream, writeStream: new BufferedStream(stream));
        }
        catch (Exception ex)
        {
            Log.Write(ex.ToString(), ConsoleColor.Red);
        }
        finally
        {
            stream.Dispose();
        }
    }
}

void MainLoop(Stream readStream, Stream writeStream)
{
    Span<byte> buffer = stackalloc byte[1024];
    SendManifest(writeStream, buffer);
    writeStream.Flush();

    while (true)
    {
        readStream.ReadExactly(buffer[..1]);
        RequestType request = (RequestType)buffer[0];

        if (request == RequestType.Scene)
        {
            int bytes = readStream.Read(buffer[..4]);
            Debug.Assert(bytes == 4);

            int sceneLength = BinaryPrimitives.ReadInt32BigEndian(buffer[..4]);
            bytes = readStream.Read(buffer[..sceneLength]);
            Debug.Assert(bytes == sceneLength);

            AsciiString sceneName = AsciiString.From(buffer[..sceneLength]);
            Log.Write($"Received RequestType {request} for {sceneName}");

            Stopwatch sw = Stopwatch.StartNew();
            AssetDatabaseScene scene = db.LoadScene(sceneName);
            Log.Write($"Scene {sceneName} loaded in {sw.Elapsed.TotalSeconds:F2} seconds");

            sw.Restart();

            List<AssetDatabaseSceneObject> allObjects = scene.GetAllObjects();

            Dictionary<AssetDatabaseMesh, int> meshes = allObjects
                .Where(x => x.Mesh.HasValue)
                .Select(x => x.Mesh!.Value)
                .Distinct()
                .Select((x, i) => (x, i))
                .ToDictionary(x => x.x, x => x.i);

            Dictionary<AssetDatabaseMaterial, int> materials = allObjects
                .SelectMany(x => x.MeshMaterials)
                .Distinct()
                .Select((x, i) => (x, i))
                .ToDictionary(x => x.x, x => x.i);

            Dictionary<AssetDatabaseTexture, int> textures = allObjects
                .SelectMany(x => x.MeshMaterials)
                .SelectMany(x => x.Textures)
                .Select(x => x.Value)
                .Distinct()
                .Select((x, i) => (x, i))
                .ToDictionary(x => x.x, x => x.i);

            writeStream.WriteByte((byte)RequestType.Scene);
            writeStream.Write(buffer, scene.RootObjects.Length);

            foreach (AssetDatabaseSceneObject root in scene.RootObjects)
            {
                SendObject(writeStream, buffer, root, meshes, materials);
            }

            writeStream.Write(buffer, meshes.Count);
            foreach (AssetDatabaseMesh mesh in meshes.Keys)
            {
                writeStream.Write(buffer, mesh);
            }

            writeStream.Write(buffer, materials.Count);
            foreach (AssetDatabaseMaterial material in materials.Keys)
            {
                writeStream.Write(buffer, textures, material);
            }

            writeStream.Write(buffer, textures.Count);
            foreach (AssetDatabaseTexture texture in textures.Keys)
            {
                writeStream.Write(buffer, texture);
            }

            Log.Write($"Scene {sceneName} sent in {sw.Elapsed.TotalSeconds:F2} seconds");
            writeStream.Flush();
        }
    }
}

void SendManifest(Stream stream, Span<byte> buffer)
{
    stream.Write(buffer, db.Scenes.Count());

    foreach (AsciiString scene in db.Scenes)
    {
        stream.Write(buffer, scene);
    }
}

void SendObject(Stream stream,
    Span<byte> buffer,
    AssetDatabaseSceneObject obj,
    Dictionary<AssetDatabaseMesh, int> meshes,
    Dictionary<AssetDatabaseMaterial, int> materials)
{
    stream.Write(buffer, obj.Name);
    stream.Write(buffer, obj.Transform);
    stream.Write(buffer, obj.Mesh.HasValue);

    if (obj.Mesh.HasValue)
    {
        stream.Write(buffer, meshes[obj.Mesh.Value]);
    }

    stream.Write(buffer, obj.MeshMaterials.Length);

    foreach (AssetDatabaseMaterial material in obj.MeshMaterials)
    {
        stream.Write(buffer, materials[material]);
    }

    stream.Write(buffer, obj.Children.Length);

    foreach (AssetDatabaseSceneObject child in obj.Children)
    {
        SendObject(stream, buffer, child, meshes, materials);
    }
}

internal static class Extensions
{
    public static void Write(this Stream stream, Span<byte> buffer, int i32)
    {
        BinaryPrimitives.WriteInt32BigEndian(buffer[..4], i32);
        stream.Write(buffer[..4]);
    }

    public static void Write(this Stream stream, Span<byte> buffer, uint u32)
    {
        BinaryPrimitives.WriteUInt32BigEndian(buffer[..4], u32);
        stream.Write(buffer[..4]);
    }

    public static void Write(this Stream stream, Span<byte> buffer, float f32)
    {
        BinaryPrimitives.WriteSingleBigEndian(buffer[..4], f32);
        stream.Write(buffer[..4]);
    }

    public static void Write(this Stream stream, Span<byte> buffer, bool b)
    {
        buffer[0] = (byte)(b ? 1 : 0);
        stream.Write(buffer[..1]);
    }

    public static void Write(this Stream stream, Span<byte> buffer, AsciiString str)
    {
        stream.Write(buffer, str.Length);
        stream.Write(str.Bytes);
    }

    public static void Write(this Stream stream, Span<byte> buffer, Transform transform)
    {
        stream.Write(buffer, transform.m_LocalPosition.x);
        stream.Write(buffer, transform.m_LocalPosition.y);
        stream.Write(buffer, transform.m_LocalPosition.z);

        stream.Write(buffer, transform.m_LocalRotation.x);
        stream.Write(buffer, transform.m_LocalRotation.y);
        stream.Write(buffer, transform.m_LocalRotation.z);
        stream.Write(buffer, transform.m_LocalRotation.w);

        stream.Write(buffer, transform.m_LocalScale.x);
        stream.Write(buffer, transform.m_LocalScale.y);
        stream.Write(buffer, transform.m_LocalScale.z);
    }

    public static void Write(this Stream stream, Span<byte> buffer, AssetDatabaseMesh mesh)
    {
        stream.Write(buffer, mesh.Name);
        stream.Write(buffer, mesh.SubMeshes.Length);

        foreach (SubMesh submesh in mesh.SubMeshes)
        {
            stream.Write(buffer, (int)submesh.firstByte / (mesh.IndexFormat == 0 ? 2 : 4));
            stream.Write(buffer, (int)submesh.indexCount);
            stream.Write(buffer, submesh.topology);
            stream.Write(buffer, submesh.localAABB.m_Center.x);
            stream.Write(buffer, submesh.localAABB.m_Center.y);
            stream.Write(buffer, submesh.localAABB.m_Center.z);
            stream.Write(buffer, submesh.localAABB.m_Extent.x);
            stream.Write(buffer, submesh.localAABB.m_Center.y);
            stream.Write(buffer, submesh.localAABB.m_Center.z);
            stream.Write(buffer, (int)submesh.baseVertex);
            stream.Write(buffer, (int)submesh.firstVertex);
            stream.Write(buffer, (int)submesh.vertexCount);
        }

        stream.Write(buffer, mesh.IndexCount);
        stream.Write(buffer, mesh.IndexFormat);
        stream.Write(mesh.IndexData);

        stream.Write(buffer, mesh.VertexCount);
        stream.Write(buffer, mesh.VertexSize);
        stream.Write(buffer, mesh.VertexChannels.Length);

        foreach ((int attr, ChannelInfo channel) in mesh.VertexChannels)
        {
            stream.Write(buffer, attr);
            stream.Write(buffer, channel.format);
            stream.Write(buffer, channel.dimension & 0xF);
        }

        stream.Write(buffer, mesh.VertexStreamData.Length);
        stream.Write(mesh.VertexStreamData);
    }

    public static void Write( this Stream stream, Span<byte> buffer, Dictionary<AssetDatabaseTexture, int> textures, AssetDatabaseMaterial mat)
    {
        stream.Write(buffer, mat.Name);
        stream.Write(buffer, mat.ShaderName);
        stream.Write(buffer, mat.CustomRenderQueue);
        stream.Write(buffer, mat.DoubleSidedGI);
        stream.Write(buffer, mat.EnableInstancingVariants);

        stream.Write(buffer, mat.Colors.Count);
        foreach ((AsciiString name, ColorRGBA_1 color) in mat.Colors)
        {
            stream.Write(buffer, name);
            stream.Write(buffer, color.r);
            stream.Write(buffer, color.g);
            stream.Write(buffer, color.b);
            stream.Write(buffer, color.a);
        }

        stream.Write(buffer, mat.Floats.Count);
        foreach ((AsciiString name, float flt) in mat.Floats)
        {
            stream.Write(buffer, name);
            stream.Write(buffer, flt);
        }

        stream.Write(buffer, mat.Ints.Count);
        foreach ((AsciiString name, int integer) in mat.Ints)
        {
            stream.Write(buffer, name);
            stream.Write(buffer, integer);
        }

        stream.Write(buffer, mat.Textures.Count);
        foreach ((AsciiString name, AssetDatabaseTexture texture) in mat.Textures)
        {
            stream.Write(buffer, name);
            stream.Write(buffer, textures[texture]);
        }

        stream.Write(buffer, mat.DisabledShaderPasses.Length);
        foreach (AsciiString name in mat.DisabledShaderPasses)
        {
            stream.Write(buffer, name);
        }

        stream.Write(buffer, mat.InvalidKeywords.Length);
        foreach (AsciiString name in mat.InvalidKeywords)
        {
            stream.Write(buffer, name);
        }

        stream.Write(buffer, mat.ValidKeywords.Length);
        foreach (AsciiString name in mat.ValidKeywords)
        {
            stream.Write(buffer, name);
        }

        stream.Write(buffer, mat.StringTagMap.Count);
        foreach ((AsciiString name, AsciiString tag) in mat.StringTagMap)
        {
            stream.Write(buffer, name);
            stream.Write(buffer, tag);
        }
    }

    public static void Write(this Stream stream, Span<byte> buffer, AssetDatabaseTexture tex)
    {
        stream.Write(buffer, tex.Name);
        stream.Write(buffer, tex.Width);
        stream.Write(buffer, tex.Height);
        stream.Write(buffer, (int)tex.Format);
        stream.Write(buffer, tex.Settings.m_FilterMode);
        stream.Write(buffer, tex.Settings.m_Aniso);
        stream.Write(buffer, tex.Settings.m_MipBias);
        stream.Write(buffer, tex.Settings.m_WrapU);
        stream.Write(buffer, tex.Settings.m_WrapV);
        stream.Write(buffer, tex.Settings.m_WrapW);
        stream.Write(buffer, tex.Data.Length);
        stream.Write(tex.Data);
    }
}

enum RequestType : byte
{
    Scene
};
