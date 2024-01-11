using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using RogueTraderUnityToolkit.UnityGenerated.Types;
using System.Diagnostics;

namespace AssetServer;

public static class DebugSceneDisplay
{
    public static void DrawScene(AssetDatabaseScene scene)
    {
        using GameWindow game = new();

        game.Width = 1920;
        game.Height = 1080;

        List<Draw> draws = [];

        foreach (AssetDatabaseSceneObject obj in scene.RootObjects)
        {
            PopulateDrawList(Matrix4.Identity, obj, draws);
        }

        draws = draws.OrderByDescending(x => x.Mesh.Indices.Length).ToList();

        game.Load += (_, _) =>
        {
            game.VSync = VSyncMode.On;
            GL.Enable(EnableCap.DepthTest);

            foreach (Draw draw in draws)
            {
                bool hasPosition = draw.Mesh.TryGetAttributes(VertexAttribute.Position, out MeshVertexData position);
                bool hasNormal = draw.Mesh.TryGetAttributes(VertexAttribute.Normal, out MeshVertexData normal);

                Debug.Assert(hasPosition);
                Debug.Assert(hasNormal);

                GL.BindBuffer(BufferTarget.ArrayBuffer, draw.Vbo);
                GL.BufferData(BufferTarget.ArrayBuffer, position.Vertices.Length * 4, position.Vertices, BufferUsageHint.StaticDraw);

                GL.BindBuffer(BufferTarget.ArrayBuffer, draw.VboNormal);
                GL.BufferData(BufferTarget.ArrayBuffer, normal.Vertices.Length * 4, normal.Vertices, BufferUsageHint.StaticDraw);

                GL.BindBuffer(BufferTarget.ElementArrayBuffer, draw.Ibo);
                GL.BufferData(BufferTarget.ElementArrayBuffer, draw.Mesh.Indices.Length * 4, draw.Mesh.Indices, BufferUsageHint.StaticDraw);

                GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
                GL.BindBuffer(BufferTarget.ElementArrayBuffer, 0);
            }

            GL.Enable(EnableCap.Lighting);
            GL.Enable(EnableCap.Light0);

            GL.Light(LightName.Light0, LightParameter.Position, [ 0.0f, 30.0f, 0.0f, 1.0f ]);
            GL.Light(LightName.Light0, LightParameter.Ambient, [ 0.2f, 0.2f, 0.2f, 1.0f ]);
            GL.Light(LightName.Light0, LightParameter.Diffuse, [ 0.8f, 0.8f, 0.8f, 1.0f ]);
        };

        game.Resize += (_, _) =>
        {
            GL.Viewport(0, 0, game.Width, game.Height);

            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView((float)Math.PI / 4, game.Width / (float)game.Height, 0.1f, 1000.0f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);
        };

        game.RenderFrame += (_, _) =>
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            Matrix4 viewMatrix = Matrix4.LookAt(_cam, _cam + GetCameraDirection(), Vector3.UnitY);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref viewMatrix);

            GL.Material(MaterialFace.FrontAndBack, MaterialParameter.AmbientAndDiffuse, [ 0.5f, 0.5f, 0.5f, 1.0f ]);
            GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Specular, [ 0.3f, 0.3f, 0.3f, 1.0f ]);
            GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Shininess, 0);

            foreach (Draw draw in draws)
            {
                GL.BindBuffer(BufferTarget.ArrayBuffer, draw.Vbo);
                GL.VertexPointer(3, VertexPointerType.Float, 0, 0);
                GL.EnableClientState(ArrayCap.VertexArray);

                GL.BindBuffer(BufferTarget.ArrayBuffer, draw.VboNormal);
                GL.NormalPointer(NormalPointerType.Float, 16, IntPtr.Zero);
                GL.EnableClientState(ArrayCap.NormalArray);

                GL.BindBuffer(BufferTarget.ElementArrayBuffer, draw.Ibo);

                Matrix4 modelMatrix = draw.Transform;
                Matrix4 modelViewMatrix = modelMatrix * viewMatrix;
                GL.LoadMatrix(ref modelViewMatrix);

                GL.DrawElements(BeginMode.Triangles, draw.Mesh.Indices.Length, DrawElementsType.UnsignedInt, 0);

                GL.DisableClientState(ArrayCap.VertexArray);
                GL.DisableClientState(ArrayCap.NormalArray);

                GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
                GL.BindBuffer(BufferTarget.ElementArrayBuffer, 0);
            }

            game.SwapBuffers();
        };

        game.UpdateFrame += (_, _) =>
        {
            KeyboardState keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Key.W))
            {
                _cam += GetCameraDirection();
            }

            if (keyboardState.IsKeyDown(Key.S))
            {
                _cam -= GetCameraDirection();
            }

            if (keyboardState.IsKeyDown(Key.A))
            {
                _cam -= Vector3.Normalize(Vector3.Cross(GetCameraDirection(), Vector3.UnitY));
            }

            if (keyboardState.IsKeyDown(Key.D))
            {
                _cam += Vector3.Normalize(Vector3.Cross(GetCameraDirection(), Vector3.UnitY));
            }
        };

        game.MouseMove += (_, e) =>
        {
            if (e.Mouse[MouseButton.Left])
            {
                float dx = _mouse.X - e.X;
                float dy = _mouse.Y - e.Y;
                _mouse = new(e.X, e.Y);

                const float sensitivity = 0.2f;
                dx *= -sensitivity;
                dy *= sensitivity;

                _camYaw += dx;
                _camPitch += dy;
            }
            else
            {
                _mouse = new Vector2(e.X, e.Y);
            }
        };

        game.Run(100.0);
    }

    private static Vector3 _cam = new(0, 0, 5);
    private static float _camYaw = -90.0f;
    private static float _camPitch;
    private static Vector2 _mouse;

    private readonly record struct Draw(
        AssetDatabaseSceneObject Object,
        AssetDatabaseMesh Mesh,
        int Vbo,
        int VboNormal,
        int Ibo,
        Matrix4 Transform);

    private static Vector3 GetCameraDirection()
    {
        Vector3 direction;
        direction.X = (float)Math.Cos(MathHelper.DegreesToRadians(_camYaw)) * (float)Math.Cos(MathHelper.DegreesToRadians(_camPitch));
        direction.Y = (float)Math.Sin(MathHelper.DegreesToRadians(_camPitch));
        direction.Z = (float)Math.Sin(MathHelper.DegreesToRadians(_camYaw)) * (float)Math.Cos(MathHelper.DegreesToRadians(_camPitch));
        return Vector3.Normalize(direction);
    }

    private static void PopulateDrawList(
        Matrix4 parentTransform,
        AssetDatabaseSceneObject obj,
        List<Draw> draws)
    {
        Vector3f posUnity = obj.Transform.m_LocalPosition;
        Quaternionf rotUnity = obj.Transform.m_LocalRotation;
        Vector3f scaleUnity = obj.Transform.m_LocalScale;

        Matrix4 transform = Transform(parentTransform,
            new(posUnity.x, posUnity.y, posUnity.z),
            new(rotUnity.x, rotUnity.y, rotUnity.z, rotUnity.w),
            new(scaleUnity.x, scaleUnity.y, scaleUnity.z));

        if (obj.Mesh.HasValue)
        {
            draws.Add(new(
                obj,
                obj.Mesh.Value,
                GL.GenBuffer(),
                GL.GenBuffer(),
                GL.GenBuffer(),
                transform));
        }

        foreach (AssetDatabaseSceneObject child in obj.Children)
        {
            PopulateDrawList(transform, child, draws);
        }
    }

    public static Matrix4 Transform(
        Matrix4 parentTransform,
        Vector3 position,
        Quaternion rotation,
        Vector3 scale)
    {
        Matrix4 positionMatrix = Matrix4.CreateTranslation(position.X, position.Y, position.Z);
        Matrix4 rotationMatrix = Matrix4.CreateFromQuaternion(new Quaternion(rotation.X, rotation.Y, rotation.Z, rotation.W));
        Matrix4 scaleMatrix = Matrix4.CreateScale(scale.X, scale.Y, scale.Z);
        Matrix4 combinedMatrix = scaleMatrix * rotationMatrix * positionMatrix;
        return combinedMatrix * parentTransform;
    }
}
