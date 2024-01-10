using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace AssetServer;

public static class DebugMeshDisplay
{
    public static void DrawMesh(MeshVertexData vertices, uint[] indices)
    {
        using GameWindow game = new();

        game.Width = 1920;
        game.Height = 1080;

        indices = GenerateLineIndices(indices);

        game.Load += (_, _) =>
        {
            game.VSync = VSyncMode.On;
            GL.Enable(EnableCap.DepthTest);

            int vbo = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo);
            GL.BufferData(BufferTarget.ArrayBuffer, (IntPtr)(vertices.Vertices.Length * vertices.Stride * 4), vertices.Vertices, BufferUsageHint.StaticDraw);

            int ibo = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ibo);
            GL.BufferData(BufferTarget.ElementArrayBuffer, (IntPtr)(indices.Length * sizeof(int)), indices, BufferUsageHint.StaticDraw);

            GL.EnableClientState(ArrayCap.VertexArray);
            GL.VertexPointer(vertices.Stride, VertexPointerType.Float, 0, 0);
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

            Matrix4 mv = Matrix4.LookAt(_cam, _cam + GetCameraDirection(), Vector3.UnitY);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref mv);

            GL.DrawElements(BeginMode.Lines, indices.Length, DrawElementsType.UnsignedInt, 0);
            game.SwapBuffers();
        };

        game.UpdateFrame += (_, _) =>
        {
            KeyboardState keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Key.W))
            {
                _cam += GetCameraDirection();
                return;
            }

            if (keyboardState.IsKeyDown(Key.S))
            {
                _cam -= GetCameraDirection();
                return;
            }
            if (keyboardState.IsKeyDown(Key.A))
            {
                _cam -= Vector3.Normalize(Vector3.Cross(GetCameraDirection(), Vector3.UnitY));
                return;
            }

            if (keyboardState.IsKeyDown(Key.D))
            {
                _cam += Vector3.Normalize(Vector3.Cross(GetCameraDirection(), Vector3.UnitY));
                return;
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

                if (_camPitch > 89.0f)
                    _camPitch = 89.0f;
                if (_camPitch < -89.0f)
                    _camPitch = -89.0f;
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

    private static Vector3 GetCameraDirection()
    {
        Vector3 direction;
        direction.X = (float)Math.Cos(MathHelper.DegreesToRadians(_camYaw)) * (float)Math.Cos(MathHelper.DegreesToRadians(_camPitch));
        direction.Y = (float)Math.Sin(MathHelper.DegreesToRadians(_camPitch));
        direction.Z = (float)Math.Sin(MathHelper.DegreesToRadians(_camYaw)) * (float)Math.Cos(MathHelper.DegreesToRadians(_camPitch));
        return Vector3.Normalize(direction);
    }

    private static uint[] GenerateLineIndices(IReadOnlyList<uint> triangleIndices)
    {
        HashSet<(uint, uint)> lines = [];
        for (int i = 0; i < triangleIndices.Count; i += 3)
        {
            uint v1 = triangleIndices[i];
            uint v2 = triangleIndices[i + 1];
            uint v3 = triangleIndices[i + 2];

            lines.Add(v1 < v2 ? (v1, v2) : (v2, v1));
            lines.Add(v2 < v3 ? (v2, v3) : (v3, v2));
            lines.Add(v3 < v1 ? (v3, v1) : (v1, v3));
        }

        uint[] lineIndices = new uint[lines.Count * 2];
        int index = 0;

        foreach (var line in lines)
        {
            lineIndices[index++] = line.Item1;
            lineIndices[index++] = line.Item2;
        }

        return lineIndices;
    }

}
