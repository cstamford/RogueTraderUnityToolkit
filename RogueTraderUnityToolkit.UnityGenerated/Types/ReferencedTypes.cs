namespace RogueTraderUnityToolkit.UnityGenerated.Types;

using Core;
using System.Text;
using Unity;
using Engine;

/* $StreamedResource (3 fields) */
public record class StreamedResource(
    AsciiString m_Source,
    ulong m_Offset,
    ulong m_Size) : IUnityStructure
{
    public static StreamedResource Read(EndianBinaryReader reader)
    {
        AsciiString _m_Source = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Source */
        ulong _m_Offset = reader.ReadU64();
        ulong _m_Size = reader.ReadU64();
        
        return new(_m_Source,
            _m_Offset,
            _m_Size);
    }

    public override string ToString() => $"StreamedResource\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Source: ");
        sb.AppendLine(m_Source.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Offset: ");
        sb.AppendLine(m_Offset.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Size: ");
        sb.AppendLine(m_Size.ToString());

        return sb.ToString();
    }
}

/* $Vector4f (4 fields) */
public readonly record struct Vector4f(
    float x,
    float y,
    float z,
    float w) : IUnityStructure
{
    public static Vector4f Read(EndianBinaryReader reader)
    {
        float _x = reader.ReadF32();
        float _y = reader.ReadF32();
        float _z = reader.ReadF32();
        float _w = reader.ReadF32();
        
        return new(_x,
            _y,
            _z,
            _w);
    }

    public override string ToString() => $"Vector4f\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("x: ");
        sb.AppendLine(x.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("y: ");
        sb.AppendLine(y.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("z: ");
        sb.AppendLine(z.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("w: ");
        sb.AppendLine(w.ToString());

        return sb.ToString();
    }
}

/* $StaticBatchInfo (2 fields) */
public readonly record struct StaticBatchInfo(
    ushort firstSubMesh,
    ushort subMeshCount) : IUnityStructure
{
    public static StaticBatchInfo Read(EndianBinaryReader reader)
    {
        ushort _firstSubMesh = reader.ReadU16();
        ushort _subMeshCount = reader.ReadU16();
        
        return new(_firstSubMesh,
            _subMeshCount);
    }

    public override string ToString() => $"StaticBatchInfo\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("firstSubMesh: ");
        sb.AppendLine(firstSubMesh.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("subMeshCount: ");
        sb.AppendLine(subMeshCount.ToString());

        return sb.ToString();
    }
}

/* $Quaternionf (4 fields) */
public readonly record struct Quaternionf(
    float x,
    float y,
    float z,
    float w) : IUnityStructure
{
    public static Quaternionf Read(EndianBinaryReader reader)
    {
        float _x = reader.ReadF32();
        float _y = reader.ReadF32();
        float _z = reader.ReadF32();
        float _w = reader.ReadF32();
        
        return new(_x,
            _y,
            _z,
            _w);
    }

    public override string ToString() => $"Quaternionf\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("x: ");
        sb.AppendLine(x.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("y: ");
        sb.AppendLine(y.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("z: ");
        sb.AppendLine(z.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("w: ");
        sb.AppendLine(w.ToString());

        return sb.ToString();
    }
}

/* $Vector3f (3 fields) */
public readonly record struct Vector3f(
    float x,
    float y,
    float z) : IUnityStructure
{
    public static Vector3f Read(EndianBinaryReader reader)
    {
        float _x = reader.ReadF32();
        float _y = reader.ReadF32();
        float _z = reader.ReadF32();
        
        return new(_x,
            _y,
            _z);
    }

    public override string ToString() => $"Vector3f\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("x: ");
        sb.AppendLine(x.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("y: ");
        sb.AppendLine(y.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("z: ");
        sb.AppendLine(z.ToString());

        return sb.ToString();
    }
}

/* $AnimationClipOverride (2 fields) */
public record class AnimationClipOverride(
    PPtr<AnimationClip> m_OriginalClip,
    PPtr<AnimationClip> m_OverrideClip) : IUnityStructure
{
    public static AnimationClipOverride Read(EndianBinaryReader reader)
    {
        PPtr<AnimationClip> _m_OriginalClip = PPtr<AnimationClip>.Read(reader);
        PPtr<AnimationClip> _m_OverrideClip = PPtr<AnimationClip>.Read(reader);
        
        return new(_m_OriginalClip,
            _m_OverrideClip);
    }

    public override string ToString() => $"AnimationClipOverride\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_OriginalClip: ");
        sb.AppendLine(m_OriginalClip.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_OverrideClip: ");
        sb.AppendLine(m_OverrideClip.ToString());

        return sb.ToString();
    }
}

/* $LOD (3 fields) */
public record class LOD(
    float screenRelativeHeight,
    float fadeTransitionWidth,
    LODRenderer[] renderers) : IUnityStructure
{
    public static LOD Read(EndianBinaryReader reader)
    {
        float _screenRelativeHeight = reader.ReadF32();
        float _fadeTransitionWidth = reader.ReadF32();
        LODRenderer[] _renderers = BuiltInArray<LODRenderer>.Read(reader);
        reader.AlignTo(4); /* renderers */
        
        return new(_screenRelativeHeight,
            _fadeTransitionWidth,
            _renderers);
    }

    public override string ToString() => $"LOD\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("screenRelativeHeight: ");
        sb.AppendLine(screenRelativeHeight.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("fadeTransitionWidth: ");
        sb.AppendLine(fadeTransitionWidth.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("renderers: ");
        sb.AppendLine(renderers.ToString());

        return sb.ToString();
    }
}

/* $LODRenderer (1 fields) */
public record class LODRenderer(
    PPtr<Renderer> renderer) : IUnityStructure
{
    public static LODRenderer Read(EndianBinaryReader reader)
    {
        PPtr<Renderer> _renderer = PPtr<Renderer>.Read(reader);
        
        return new(_renderer);
    }

    public override string ToString() => $"LODRenderer\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("renderer: ");
        sb.AppendLine(renderer.ToString());

        return sb.ToString();
    }
}

/* $CharacterInfo (5 fields) */
public record class CharacterInfo(
    uint index,
    Rectf uv,
    Rectf vert,
    float advance,
    bool flipped) : IUnityStructure
{
    public static CharacterInfo Read(EndianBinaryReader reader)
    {
        uint _index = reader.ReadU32();
        Rectf _uv = Rectf.Read(reader);
        Rectf _vert = Rectf.Read(reader);
        float _advance = reader.ReadF32();
        bool _flipped = reader.ReadBool();
        reader.AlignTo(4); /* flipped */
        
        return new(_index,
            _uv,
            _vert,
            _advance,
            _flipped);
    }

    public override string ToString() => $"CharacterInfo\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("index: ");
        sb.AppendLine(index.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("uv: ");
        sb.AppendLine();
        sb.Append(uv.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("vert: ");
        sb.AppendLine();
        sb.Append(vert.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("advance: ");
        sb.AppendLine(advance.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("flipped: ");
        sb.AppendLine(flipped.ToString());

        return sb.ToString();
    }
}

/* $Rectf (4 fields) */
public readonly record struct Rectf(
    float x,
    float y,
    float width,
    float height) : IUnityStructure
{
    public static Rectf Read(EndianBinaryReader reader)
    {
        float _x = reader.ReadF32();
        float _y = reader.ReadF32();
        float _width = reader.ReadF32();
        float _height = reader.ReadF32();
        
        return new(_x,
            _y,
            _width,
            _height);
    }

    public override string ToString() => $"Rectf\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("x: ");
        sb.AppendLine(x.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("y: ");
        sb.AppendLine(y.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("width: ");
        sb.AppendLine(width.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("height: ");
        sb.AppendLine(height.ToString());

        return sb.ToString();
    }
}

/* $pair_0 (2 fields) */
public readonly record struct pair_0(
    ushort first,
    ushort second) : IUnityStructure
{
    public static pair_0 Read(EndianBinaryReader reader)
    {
        ushort _first = reader.ReadU16();
        ushort _second = reader.ReadU16();
        
        return new(_first,
            _second);
    }

    public override string ToString() => $"pair_0\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("first: ");
        sb.AppendLine(first.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("second: ");
        sb.AppendLine(second.ToString());

        return sb.ToString();
    }
}

/* $BitField (1 fields) */
public readonly record struct BitField(
    uint m_Bits) : IUnityStructure
{
    public static BitField Read(EndianBinaryReader reader)
    {
        uint _m_Bits = reader.ReadU32();
        
        return new(_m_Bits);
    }

    public override string ToString() => $"BitField\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Bits: ");
        sb.AppendLine(m_Bits.ToString());

        return sb.ToString();
    }
}

/* $SubMesh (7 fields) */
public record class SubMesh(
    uint firstByte,
    uint indexCount,
    int topology,
    uint baseVertex,
    uint firstVertex,
    uint vertexCount,
    AABB localAABB) : IUnityStructure
{
    public static SubMesh Read(EndianBinaryReader reader)
    {
        uint _firstByte = reader.ReadU32();
        uint _indexCount = reader.ReadU32();
        int _topology = reader.ReadS32();
        uint _baseVertex = reader.ReadU32();
        uint _firstVertex = reader.ReadU32();
        uint _vertexCount = reader.ReadU32();
        AABB _localAABB = AABB.Read(reader);
        
        return new(_firstByte,
            _indexCount,
            _topology,
            _baseVertex,
            _firstVertex,
            _vertexCount,
            _localAABB);
    }

    public override string ToString() => $"SubMesh\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("firstByte: ");
        sb.AppendLine(firstByte.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("indexCount: ");
        sb.AppendLine(indexCount.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("topology: ");
        sb.AppendLine(topology.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("baseVertex: ");
        sb.AppendLine(baseVertex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("firstVertex: ");
        sb.AppendLine(firstVertex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("vertexCount: ");
        sb.AppendLine(vertexCount.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("localAABB: ");
        sb.AppendLine();
        sb.Append(localAABB.ToString(indent+4));

        return sb.ToString();
    }
}

/* $AABB (2 fields) */
public record class AABB(
    Vector3f m_Center,
    Vector3f m_Extent) : IUnityStructure
{
    public static AABB Read(EndianBinaryReader reader)
    {
        Vector3f _m_Center = Vector3f.Read(reader);
        Vector3f _m_Extent = Vector3f.Read(reader);
        
        return new(_m_Center,
            _m_Extent);
    }

    public override string ToString() => $"AABB\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Center: ");
        sb.AppendLine();
        sb.Append(m_Center.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Extent: ");
        sb.AppendLine();
        sb.Append(m_Extent.ToString(indent+4));

        return sb.ToString();
    }
}

/* $BlendShapeData (4 fields) */
public record class BlendShapeData(
    BlendShapeVertex[] vertices,
    MeshBlendShape[] shapes,
    MeshBlendShapeChannel[] channels,
    float[] fullWeights) : IUnityStructure
{
    public static BlendShapeData Read(EndianBinaryReader reader)
    {
        BlendShapeVertex[] _vertices = BuiltInArray<BlendShapeVertex>.Read(reader);
        reader.AlignTo(4); /* vertices */
        MeshBlendShape[] _shapes = BuiltInArray<MeshBlendShape>.Read(reader);
        reader.AlignTo(4); /* shapes */
        MeshBlendShapeChannel[] _channels = BuiltInArray<MeshBlendShapeChannel>.Read(reader);
        reader.AlignTo(4); /* channels */
        float[] _fullWeights = BuiltInArray<float>.Read(reader);
        reader.AlignTo(4); /* fullWeights */
        
        return new(_vertices,
            _shapes,
            _channels,
            _fullWeights);
    }

    public override string ToString() => $"BlendShapeData\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("vertices: ");
        sb.AppendLine(vertices.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("shapes: ");
        sb.AppendLine(shapes.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("channels: ");
        sb.AppendLine(channels.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("fullWeights: ");
        sb.AppendLine(fullWeights.ToString());

        return sb.ToString();
    }
}

/* $BlendShapeVertex (4 fields) */
public record class BlendShapeVertex(
    Vector3f vertex,
    Vector3f normal,
    Vector3f tangent,
    uint index) : IUnityStructure
{
    public static BlendShapeVertex Read(EndianBinaryReader reader)
    {
        Vector3f _vertex = Vector3f.Read(reader);
        Vector3f _normal = Vector3f.Read(reader);
        Vector3f _tangent = Vector3f.Read(reader);
        uint _index = reader.ReadU32();
        
        return new(_vertex,
            _normal,
            _tangent,
            _index);
    }

    public override string ToString() => $"BlendShapeVertex\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("vertex: ");
        sb.AppendLine();
        sb.Append(vertex.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("normal: ");
        sb.AppendLine();
        sb.Append(normal.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("tangent: ");
        sb.AppendLine();
        sb.Append(tangent.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("index: ");
        sb.AppendLine(index.ToString());

        return sb.ToString();
    }
}

/* $MeshBlendShape (4 fields) */
public readonly record struct MeshBlendShape(
    uint firstVertex,
    uint vertexCount,
    bool hasNormals,
    bool hasTangents) : IUnityStructure
{
    public static MeshBlendShape Read(EndianBinaryReader reader)
    {
        uint _firstVertex = reader.ReadU32();
        uint _vertexCount = reader.ReadU32();
        bool _hasNormals = reader.ReadBool();
        bool _hasTangents = reader.ReadBool();
        reader.AlignTo(4); /* hasTangents */
        
        return new(_firstVertex,
            _vertexCount,
            _hasNormals,
            _hasTangents);
    }

    public override string ToString() => $"MeshBlendShape\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("firstVertex: ");
        sb.AppendLine(firstVertex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("vertexCount: ");
        sb.AppendLine(vertexCount.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("hasNormals: ");
        sb.AppendLine(hasNormals.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("hasTangents: ");
        sb.AppendLine(hasTangents.ToString());

        return sb.ToString();
    }
}

/* $MeshBlendShapeChannel (4 fields) */
public record class MeshBlendShapeChannel(
    AsciiString name,
    uint nameHash,
    int frameIndex,
    int frameCount) : IUnityStructure
{
    public static MeshBlendShapeChannel Read(EndianBinaryReader reader)
    {
        AsciiString _name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* name */
        uint _nameHash = reader.ReadU32();
        int _frameIndex = reader.ReadS32();
        int _frameCount = reader.ReadS32();
        
        return new(_name,
            _nameHash,
            _frameIndex,
            _frameCount);
    }

    public override string ToString() => $"MeshBlendShapeChannel\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("name: ");
        sb.AppendLine(name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("nameHash: ");
        sb.AppendLine(nameHash.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("frameIndex: ");
        sb.AppendLine(frameIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("frameCount: ");
        sb.AppendLine(frameCount.ToString());

        return sb.ToString();
    }
}

/* $Matrix4x4f (16 fields) */
public readonly record struct Matrix4x4f(
    float e00,
    float e01,
    float e02,
    float e03,
    float e10,
    float e11,
    float e12,
    float e13,
    float e20,
    float e21,
    float e22,
    float e23,
    float e30,
    float e31,
    float e32,
    float e33) : IUnityStructure
{
    public static Matrix4x4f Read(EndianBinaryReader reader)
    {
        float _e00 = reader.ReadF32();
        float _e01 = reader.ReadF32();
        float _e02 = reader.ReadF32();
        float _e03 = reader.ReadF32();
        float _e10 = reader.ReadF32();
        float _e11 = reader.ReadF32();
        float _e12 = reader.ReadF32();
        float _e13 = reader.ReadF32();
        float _e20 = reader.ReadF32();
        float _e21 = reader.ReadF32();
        float _e22 = reader.ReadF32();
        float _e23 = reader.ReadF32();
        float _e30 = reader.ReadF32();
        float _e31 = reader.ReadF32();
        float _e32 = reader.ReadF32();
        float _e33 = reader.ReadF32();
        
        return new(_e00,
            _e01,
            _e02,
            _e03,
            _e10,
            _e11,
            _e12,
            _e13,
            _e20,
            _e21,
            _e22,
            _e23,
            _e30,
            _e31,
            _e32,
            _e33);
    }

    public override string ToString() => $"Matrix4x4f\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("e00: ");
        sb.AppendLine(e00.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("e01: ");
        sb.AppendLine(e01.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("e02: ");
        sb.AppendLine(e02.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("e03: ");
        sb.AppendLine(e03.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("e10: ");
        sb.AppendLine(e10.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("e11: ");
        sb.AppendLine(e11.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("e12: ");
        sb.AppendLine(e12.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("e13: ");
        sb.AppendLine(e13.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("e20: ");
        sb.AppendLine(e20.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("e21: ");
        sb.AppendLine(e21.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("e22: ");
        sb.AppendLine(e22.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("e23: ");
        sb.AppendLine(e23.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("e30: ");
        sb.AppendLine(e30.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("e31: ");
        sb.AppendLine(e31.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("e32: ");
        sb.AppendLine(e32.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("e33: ");
        sb.AppendLine(e33.ToString());

        return sb.ToString();
    }
}

/* $MinMaxAABB (2 fields) */
public record class MinMaxAABB(
    Vector3f m_Min,
    Vector3f m_Max) : IUnityStructure
{
    public static MinMaxAABB Read(EndianBinaryReader reader)
    {
        Vector3f _m_Min = Vector3f.Read(reader);
        Vector3f _m_Max = Vector3f.Read(reader);
        
        return new(_m_Min,
            _m_Max);
    }

    public override string ToString() => $"MinMaxAABB\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Min: ");
        sb.AppendLine();
        sb.Append(m_Min.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Max: ");
        sb.AppendLine();
        sb.Append(m_Max.ToString(indent+4));

        return sb.ToString();
    }
}

/* $VariableBoneCountWeights (1 fields) */
public record class VariableBoneCountWeights(
    uint[] m_Data) : IUnityStructure
{
    public static VariableBoneCountWeights Read(EndianBinaryReader reader)
    {
        uint[] _m_Data = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* m_Data */
        
        return new(_m_Data);
    }

    public override string ToString() => $"VariableBoneCountWeights\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Data: ");
        sb.AppendLine(m_Data.ToString());

        return sb.ToString();
    }
}

/* $VertexData (3 fields) */
public record class VertexData(
    uint m_VertexCount,
    ChannelInfo[] m_Channels,
    byte[] m_DataSize) : IUnityStructure
{
    public static VertexData Read(EndianBinaryReader reader)
    {
        uint _m_VertexCount = reader.ReadU32();
        ChannelInfo[] _m_Channels = BuiltInArray<ChannelInfo>.Read(reader);
        reader.AlignTo(4); /* m_Channels */
        byte[] _m_DataSize = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_DataSize */
        
        return new(_m_VertexCount,
            _m_Channels,
            _m_DataSize);
    }

    public override string ToString() => $"VertexData\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_VertexCount: ");
        sb.AppendLine(m_VertexCount.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Channels: ");
        sb.AppendLine(m_Channels.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DataSize: ");
        sb.AppendLine(m_DataSize.ToString());

        return sb.ToString();
    }
}

/* $ChannelInfo (4 fields) */
public readonly record struct ChannelInfo(
    byte stream,
    byte offset,
    byte format,
    byte dimension) : IUnityStructure
{
    public static ChannelInfo Read(EndianBinaryReader reader)
    {
        byte _stream = reader.ReadU8();
        byte _offset = reader.ReadU8();
        byte _format = reader.ReadU8();
        byte _dimension = reader.ReadU8();
        
        return new(_stream,
            _offset,
            _format,
            _dimension);
    }

    public override string ToString() => $"ChannelInfo\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("stream: ");
        sb.AppendLine(stream.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("offset: ");
        sb.AppendLine(offset.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("format: ");
        sb.AppendLine(format.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("dimension: ");
        sb.AppendLine(dimension.ToString());

        return sb.ToString();
    }
}

/* $CompressedMesh (11 fields) */
public record class CompressedMesh(
    PackedBitVector_0 m_Vertices,
    PackedBitVector_0 m_UV,
    PackedBitVector_0 m_Normals,
    PackedBitVector_0 m_Tangents,
    PackedBitVector_1 m_Weights,
    PackedBitVector_1 m_NormalSigns,
    PackedBitVector_1 m_TangentSigns,
    PackedBitVector_0 m_FloatColors,
    PackedBitVector_1 m_BoneIndices,
    PackedBitVector_1 m_Triangles,
    uint m_UVInfo) : IUnityStructure
{
    public static CompressedMesh Read(EndianBinaryReader reader)
    {
        PackedBitVector_0 _m_Vertices = PackedBitVector_0.Read(reader);
        reader.AlignTo(4); /* m_Vertices */
        PackedBitVector_0 _m_UV = PackedBitVector_0.Read(reader);
        reader.AlignTo(4); /* m_UV */
        PackedBitVector_0 _m_Normals = PackedBitVector_0.Read(reader);
        reader.AlignTo(4); /* m_Normals */
        PackedBitVector_0 _m_Tangents = PackedBitVector_0.Read(reader);
        reader.AlignTo(4); /* m_Tangents */
        PackedBitVector_1 _m_Weights = PackedBitVector_1.Read(reader);
        reader.AlignTo(4); /* m_Weights */
        PackedBitVector_1 _m_NormalSigns = PackedBitVector_1.Read(reader);
        reader.AlignTo(4); /* m_NormalSigns */
        PackedBitVector_1 _m_TangentSigns = PackedBitVector_1.Read(reader);
        reader.AlignTo(4); /* m_TangentSigns */
        PackedBitVector_0 _m_FloatColors = PackedBitVector_0.Read(reader);
        reader.AlignTo(4); /* m_FloatColors */
        PackedBitVector_1 _m_BoneIndices = PackedBitVector_1.Read(reader);
        reader.AlignTo(4); /* m_BoneIndices */
        PackedBitVector_1 _m_Triangles = PackedBitVector_1.Read(reader);
        reader.AlignTo(4); /* m_Triangles */
        uint _m_UVInfo = reader.ReadU32();
        
        return new(_m_Vertices,
            _m_UV,
            _m_Normals,
            _m_Tangents,
            _m_Weights,
            _m_NormalSigns,
            _m_TangentSigns,
            _m_FloatColors,
            _m_BoneIndices,
            _m_Triangles,
            _m_UVInfo);
    }

    public override string ToString() => $"CompressedMesh\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Vertices: ");
        sb.AppendLine();
        sb.Append(m_Vertices.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_UV: ");
        sb.AppendLine();
        sb.Append(m_UV.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Normals: ");
        sb.AppendLine();
        sb.Append(m_Normals.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Tangents: ");
        sb.AppendLine();
        sb.Append(m_Tangents.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Weights: ");
        sb.AppendLine();
        sb.Append(m_Weights.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NormalSigns: ");
        sb.AppendLine();
        sb.Append(m_NormalSigns.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TangentSigns: ");
        sb.AppendLine();
        sb.Append(m_TangentSigns.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FloatColors: ");
        sb.AppendLine();
        sb.Append(m_FloatColors.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BoneIndices: ");
        sb.AppendLine();
        sb.Append(m_BoneIndices.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Triangles: ");
        sb.AppendLine();
        sb.Append(m_Triangles.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_UVInfo: ");
        sb.AppendLine(m_UVInfo.ToString());

        return sb.ToString();
    }
}

/* $PackedBitVector_0 (5 fields) */
public record class PackedBitVector_0(
    uint m_NumItems,
    float m_Range,
    float m_Start,
    byte[] m_Data,
    byte m_BitSize) : IUnityStructure
{
    public static PackedBitVector_0 Read(EndianBinaryReader reader)
    {
        uint _m_NumItems = reader.ReadU32();
        float _m_Range = reader.ReadF32();
        float _m_Start = reader.ReadF32();
        byte[] _m_Data = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_Data */
        byte _m_BitSize = reader.ReadU8();
        reader.AlignTo(4); /* m_BitSize */
        
        return new(_m_NumItems,
            _m_Range,
            _m_Start,
            _m_Data,
            _m_BitSize);
    }

    public override string ToString() => $"PackedBitVector_0\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NumItems: ");
        sb.AppendLine(m_NumItems.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Range: ");
        sb.AppendLine(m_Range.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Start: ");
        sb.AppendLine(m_Start.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Data: ");
        sb.AppendLine(m_Data.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BitSize: ");
        sb.AppendLine(m_BitSize.ToString());

        return sb.ToString();
    }
}

/* $PackedBitVector_1 (3 fields) */
public record class PackedBitVector_1(
    uint m_NumItems,
    byte[] m_Data,
    byte m_BitSize) : IUnityStructure
{
    public static PackedBitVector_1 Read(EndianBinaryReader reader)
    {
        uint _m_NumItems = reader.ReadU32();
        byte[] _m_Data = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_Data */
        byte _m_BitSize = reader.ReadU8();
        reader.AlignTo(4); /* m_BitSize */
        
        return new(_m_NumItems,
            _m_Data,
            _m_BitSize);
    }

    public override string ToString() => $"PackedBitVector_1\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NumItems: ");
        sb.AppendLine(m_NumItems.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Data: ");
        sb.AppendLine(m_Data.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BitSize: ");
        sb.AppendLine(m_BitSize.ToString());

        return sb.ToString();
    }
}

/* $StreamingInfo (3 fields) */
public record class StreamingInfo(
    ulong offset,
    uint size,
    AsciiString path) : IUnityStructure
{
    public static StreamingInfo Read(EndianBinaryReader reader)
    {
        ulong _offset = reader.ReadU64();
        uint _size = reader.ReadU32();
        AsciiString _path = BuiltInString.Read(reader);
        reader.AlignTo(4); /* path */
        
        return new(_offset,
            _size,
            _path);
    }

    public override string ToString() => $"StreamingInfo\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("offset: ");
        sb.AppendLine(offset.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("size: ");
        sb.AppendLine(size.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("path: ");
        sb.AppendLine(path.ToString());

        return sb.ToString();
    }
}

/* $Vector2f (2 fields) */
public readonly record struct Vector2f(
    float x,
    float y) : IUnityStructure
{
    public static Vector2f Read(EndianBinaryReader reader)
    {
        float _x = reader.ReadF32();
        float _y = reader.ReadF32();
        
        return new(_x,
            _y);
    }

    public override string ToString() => $"Vector2f\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("x: ");
        sb.AppendLine(x.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("y: ");
        sb.AppendLine(y.ToString());

        return sb.ToString();
    }
}

/* $ColorRGBA_0 (4 fields) */
public readonly record struct ColorRGBA_0(
    float r,
    float g,
    float b,
    float a) : IUnityStructure
{
    public static ColorRGBA_0 Read(EndianBinaryReader reader)
    {
        float _r = reader.ReadF32();
        float _g = reader.ReadF32();
        float _b = reader.ReadF32();
        float _a = reader.ReadF32();
        
        return new(_r,
            _g,
            _b,
            _a);
    }

    public override string ToString() => $"ColorRGBA_0\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("r: ");
        sb.AppendLine(r.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("g: ");
        sb.AppendLine(g.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("b: ");
        sb.AppendLine(b.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("a: ");
        sb.AppendLine(a.ToString());

        return sb.ToString();
    }
}

/* $EnlightenSceneMapping (5 fields) */
public record class EnlightenSceneMapping(
    EnlightenRendererInformation[] m_Renderers,
    EnlightenSystemInformation[] m_Systems,
    Hash128[] m_Probesets,
    EnlightenSystemAtlasInformation[] m_SystemAtlases,
    EnlightenTerrainChunksInformation[] m_TerrainChunks) : IUnityStructure
{
    public static EnlightenSceneMapping Read(EndianBinaryReader reader)
    {
        EnlightenRendererInformation[] _m_Renderers = BuiltInArray<EnlightenRendererInformation>.Read(reader);
        reader.AlignTo(4); /* m_Renderers */
        EnlightenSystemInformation[] _m_Systems = BuiltInArray<EnlightenSystemInformation>.Read(reader);
        reader.AlignTo(4); /* m_Systems */
        Hash128[] _m_Probesets = BuiltInArray<Hash128>.Read(reader);
        reader.AlignTo(4); /* m_Probesets */
        EnlightenSystemAtlasInformation[] _m_SystemAtlases = BuiltInArray<EnlightenSystemAtlasInformation>.Read(reader);
        reader.AlignTo(4); /* m_SystemAtlases */
        EnlightenTerrainChunksInformation[] _m_TerrainChunks = BuiltInArray<EnlightenTerrainChunksInformation>.Read(reader);
        reader.AlignTo(4); /* m_TerrainChunks */
        
        return new(_m_Renderers,
            _m_Systems,
            _m_Probesets,
            _m_SystemAtlases,
            _m_TerrainChunks);
    }

    public override string ToString() => $"EnlightenSceneMapping\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Renderers: ");
        sb.AppendLine(m_Renderers.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Systems: ");
        sb.AppendLine(m_Systems.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Probesets: ");
        sb.AppendLine(m_Probesets.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SystemAtlases: ");
        sb.AppendLine(m_SystemAtlases.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TerrainChunks: ");
        sb.AppendLine(m_TerrainChunks.ToString());

        return sb.ToString();
    }
}

/* $EnlightenRendererInformation (4 fields) */
public record class EnlightenRendererInformation(
    PPtr<Object> renderer,
    Vector4f dynamicLightmapSTInSystem,
    int systemId,
    Hash128 instanceHash) : IUnityStructure
{
    public static EnlightenRendererInformation Read(EndianBinaryReader reader)
    {
        PPtr<Object> _renderer = PPtr<Object>.Read(reader);
        Vector4f _dynamicLightmapSTInSystem = Vector4f.Read(reader);
        int _systemId = reader.ReadS32();
        Hash128 _instanceHash = Hash128.Read(reader);
        
        return new(_renderer,
            _dynamicLightmapSTInSystem,
            _systemId,
            _instanceHash);
    }

    public override string ToString() => $"EnlightenRendererInformation\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("renderer: ");
        sb.AppendLine(renderer.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("dynamicLightmapSTInSystem: ");
        sb.AppendLine();
        sb.Append(dynamicLightmapSTInSystem.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("systemId: ");
        sb.AppendLine(systemId.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("instanceHash: ");
        sb.AppendLine(instanceHash.ToString());

        return sb.ToString();
    }
}

/* $EnlightenSystemInformation (7 fields) */
public record class EnlightenSystemInformation(
    uint rendererIndex,
    uint rendererSize,
    int atlasIndex,
    int atlasOffsetX,
    int atlasOffsetY,
    Hash128 inputSystemHash,
    Hash128 radiositySystemHash) : IUnityStructure
{
    public static EnlightenSystemInformation Read(EndianBinaryReader reader)
    {
        uint _rendererIndex = reader.ReadU32();
        uint _rendererSize = reader.ReadU32();
        int _atlasIndex = reader.ReadS32();
        int _atlasOffsetX = reader.ReadS32();
        int _atlasOffsetY = reader.ReadS32();
        Hash128 _inputSystemHash = Hash128.Read(reader);
        Hash128 _radiositySystemHash = Hash128.Read(reader);
        
        return new(_rendererIndex,
            _rendererSize,
            _atlasIndex,
            _atlasOffsetX,
            _atlasOffsetY,
            _inputSystemHash,
            _radiositySystemHash);
    }

    public override string ToString() => $"EnlightenSystemInformation\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("rendererIndex: ");
        sb.AppendLine(rendererIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("rendererSize: ");
        sb.AppendLine(rendererSize.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("atlasIndex: ");
        sb.AppendLine(atlasIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("atlasOffsetX: ");
        sb.AppendLine(atlasOffsetX.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("atlasOffsetY: ");
        sb.AppendLine(atlasOffsetY.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("inputSystemHash: ");
        sb.AppendLine(inputSystemHash.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("radiositySystemHash: ");
        sb.AppendLine(radiositySystemHash.ToString());

        return sb.ToString();
    }
}

/* $EnlightenSystemAtlasInformation (3 fields) */
public record class EnlightenSystemAtlasInformation(
    int atlasSize,
    Hash128 atlasHash,
    int firstSystemId) : IUnityStructure
{
    public static EnlightenSystemAtlasInformation Read(EndianBinaryReader reader)
    {
        int _atlasSize = reader.ReadS32();
        Hash128 _atlasHash = Hash128.Read(reader);
        int _firstSystemId = reader.ReadS32();
        
        return new(_atlasSize,
            _atlasHash,
            _firstSystemId);
    }

    public override string ToString() => $"EnlightenSystemAtlasInformation\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("atlasSize: ");
        sb.AppendLine(atlasSize.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("atlasHash: ");
        sb.AppendLine(atlasHash.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("firstSystemId: ");
        sb.AppendLine(firstSystemId.ToString());

        return sb.ToString();
    }
}

/* $EnlightenTerrainChunksInformation (3 fields) */
public readonly record struct EnlightenTerrainChunksInformation(
    int firstSystemId,
    int numChunksInX,
    int numChunksInY) : IUnityStructure
{
    public static EnlightenTerrainChunksInformation Read(EndianBinaryReader reader)
    {
        int _firstSystemId = reader.ReadS32();
        int _numChunksInX = reader.ReadS32();
        int _numChunksInY = reader.ReadS32();
        
        return new(_firstSystemId,
            _numChunksInX,
            _numChunksInY);
    }

    public override string ToString() => $"EnlightenTerrainChunksInformation\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("firstSystemId: ");
        sb.AppendLine(firstSystemId.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("numChunksInX: ");
        sb.AppendLine(numChunksInX.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("numChunksInY: ");
        sb.AppendLine(numChunksInY.ToString());

        return sb.ToString();
    }
}

/* $LightmapData (3 fields) */
public record class LightmapData(
    PPtr<Texture2D> m_Lightmap,
    PPtr<Texture2D> m_DirLightmap,
    PPtr<Texture2D> m_ShadowMask) : IUnityStructure
{
    public static LightmapData Read(EndianBinaryReader reader)
    {
        PPtr<Texture2D> _m_Lightmap = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> _m_DirLightmap = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> _m_ShadowMask = PPtr<Texture2D>.Read(reader);
        
        return new(_m_Lightmap,
            _m_DirLightmap,
            _m_ShadowMask);
    }

    public override string ToString() => $"LightmapData\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Lightmap: ");
        sb.AppendLine(m_Lightmap.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DirLightmap: ");
        sb.AppendLine(m_DirLightmap.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ShadowMask: ");
        sb.AppendLine(m_ShadowMask.ToString());

        return sb.ToString();
    }
}

/* $GISettings (6 fields) */
public readonly record struct GISettings(
    float m_BounceScale,
    float m_IndirectOutputScale,
    float m_AlbedoBoost,
    uint m_EnvironmentLightingMode,
    bool m_EnableBakedLightmaps,
    bool m_EnableRealtimeLightmaps) : IUnityStructure
{
    public static GISettings Read(EndianBinaryReader reader)
    {
        float _m_BounceScale = reader.ReadF32();
        float _m_IndirectOutputScale = reader.ReadF32();
        float _m_AlbedoBoost = reader.ReadF32();
        uint _m_EnvironmentLightingMode = reader.ReadU32();
        bool _m_EnableBakedLightmaps = reader.ReadBool();
        bool _m_EnableRealtimeLightmaps = reader.ReadBool();
        reader.AlignTo(4); /* m_EnableRealtimeLightmaps */
        
        return new(_m_BounceScale,
            _m_IndirectOutputScale,
            _m_AlbedoBoost,
            _m_EnvironmentLightingMode,
            _m_EnableBakedLightmaps,
            _m_EnableRealtimeLightmaps);
    }

    public override string ToString() => $"GISettings\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BounceScale: ");
        sb.AppendLine(m_BounceScale.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IndirectOutputScale: ");
        sb.AppendLine(m_IndirectOutputScale.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AlbedoBoost: ");
        sb.AppendLine(m_AlbedoBoost.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_EnvironmentLightingMode: ");
        sb.AppendLine(m_EnvironmentLightingMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_EnableBakedLightmaps: ");
        sb.AppendLine(m_EnableBakedLightmaps.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_EnableRealtimeLightmaps: ");
        sb.AppendLine(m_EnableRealtimeLightmaps.ToString());

        return sb.ToString();
    }
}

/* $AssetInfo (3 fields) */
public record class AssetInfo(
    int preloadIndex,
    int preloadSize,
    PPtr<Object> asset) : IUnityStructure
{
    public static AssetInfo Read(EndianBinaryReader reader)
    {
        int _preloadIndex = reader.ReadS32();
        int _preloadSize = reader.ReadS32();
        PPtr<Object> _asset = PPtr<Object>.Read(reader);
        
        return new(_preloadIndex,
            _preloadSize,
            _asset);
    }

    public override string ToString() => $"AssetInfo\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("preloadIndex: ");
        sb.AppendLine(preloadIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("preloadSize: ");
        sb.AppendLine(preloadSize.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("asset: ");
        sb.AppendLine(asset.ToString());

        return sb.ToString();
    }
}

/* $VFXPropertySheetSerializedBase_0 (11 fields) */
public record class VFXPropertySheetSerializedBase_0(
    VFXField_0 m_Float,
    VFXField_1 m_Vector2f,
    VFXField_2 m_Vector3f,
    VFXField_3 m_Vector4f,
    VFXField_4 m_Uint,
    VFXField_5 m_Int,
    VFXField_6 m_Matrix4x4f,
    VFXField_7 m_AnimationCurve,
    VFXField_8 m_Gradient,
    VFXField_9 m_NamedObject,
    VFXField_10 m_Bool) : IUnityStructure
{
    public static VFXPropertySheetSerializedBase_0 Read(EndianBinaryReader reader)
    {
        VFXField_0 _m_Float = VFXField_0.Read(reader);
        reader.AlignTo(4); /* m_Float */
        VFXField_1 _m_Vector2f = VFXField_1.Read(reader);
        reader.AlignTo(4); /* m_Vector2f */
        VFXField_2 _m_Vector3f = VFXField_2.Read(reader);
        reader.AlignTo(4); /* m_Vector3f */
        VFXField_3 _m_Vector4f = VFXField_3.Read(reader);
        reader.AlignTo(4); /* m_Vector4f */
        VFXField_4 _m_Uint = VFXField_4.Read(reader);
        reader.AlignTo(4); /* m_Uint */
        VFXField_5 _m_Int = VFXField_5.Read(reader);
        reader.AlignTo(4); /* m_Int */
        VFXField_6 _m_Matrix4x4f = VFXField_6.Read(reader);
        reader.AlignTo(4); /* m_Matrix4x4f */
        VFXField_7 _m_AnimationCurve = VFXField_7.Read(reader);
        reader.AlignTo(4); /* m_AnimationCurve */
        VFXField_8 _m_Gradient = VFXField_8.Read(reader);
        reader.AlignTo(4); /* m_Gradient */
        VFXField_9 _m_NamedObject = VFXField_9.Read(reader);
        reader.AlignTo(4); /* m_NamedObject */
        VFXField_10 _m_Bool = VFXField_10.Read(reader);
        reader.AlignTo(4); /* m_Bool */
        
        return new(_m_Float,
            _m_Vector2f,
            _m_Vector3f,
            _m_Vector4f,
            _m_Uint,
            _m_Int,
            _m_Matrix4x4f,
            _m_AnimationCurve,
            _m_Gradient,
            _m_NamedObject,
            _m_Bool);
    }

    public override string ToString() => $"VFXPropertySheetSerializedBase_0\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Float: ");
        sb.AppendLine();
        sb.Append(m_Float.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Vector2f: ");
        sb.AppendLine();
        sb.Append(m_Vector2f.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Vector3f: ");
        sb.AppendLine();
        sb.Append(m_Vector3f.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Vector4f: ");
        sb.AppendLine();
        sb.Append(m_Vector4f.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Uint: ");
        sb.AppendLine();
        sb.Append(m_Uint.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Int: ");
        sb.AppendLine();
        sb.Append(m_Int.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Matrix4x4f: ");
        sb.AppendLine();
        sb.Append(m_Matrix4x4f.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AnimationCurve: ");
        sb.AppendLine();
        sb.Append(m_AnimationCurve.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Gradient: ");
        sb.AppendLine();
        sb.Append(m_Gradient.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NamedObject: ");
        sb.AppendLine();
        sb.Append(m_NamedObject.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Bool: ");
        sb.AppendLine();
        sb.Append(m_Bool.ToString(indent+4));

        return sb.ToString();
    }
}

/* $VFXField_0 (1 fields) */
public record class VFXField_0(
    VFXEntryExposed_0[] m_Array) : IUnityStructure
{
    public static VFXField_0 Read(EndianBinaryReader reader)
    {
        VFXEntryExposed_0[] _m_Array = BuiltInArray<VFXEntryExposed_0>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(_m_Array);
    }

    public override string ToString() => $"VFXField_0\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Array: ");
        sb.AppendLine(m_Array.ToString());

        return sb.ToString();
    }
}

/* $VFXEntryExposed_0 (3 fields) */
public record class VFXEntryExposed_0(
    float m_Value,
    AsciiString m_Name,
    bool m_Overridden) : IUnityStructure
{
    public static VFXEntryExposed_0 Read(EndianBinaryReader reader)
    {
        float _m_Value = reader.ReadF32();
        reader.AlignTo(4); /* m_Value */
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        bool _m_Overridden = reader.ReadBool();
        reader.AlignTo(4); /* m_Overridden */
        
        return new(_m_Value,
            _m_Name,
            _m_Overridden);
    }

    public override string ToString() => $"VFXEntryExposed_0\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Value: ");
        sb.AppendLine(m_Value.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Overridden: ");
        sb.AppendLine(m_Overridden.ToString());

        return sb.ToString();
    }
}

/* $VFXField_1 (1 fields) */
public record class VFXField_1(
    VFXEntryExposed_1[] m_Array) : IUnityStructure
{
    public static VFXField_1 Read(EndianBinaryReader reader)
    {
        VFXEntryExposed_1[] _m_Array = BuiltInArray<VFXEntryExposed_1>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(_m_Array);
    }

    public override string ToString() => $"VFXField_1\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Array: ");
        sb.AppendLine(m_Array.ToString());

        return sb.ToString();
    }
}

/* $VFXEntryExposed_1 (3 fields) */
public record class VFXEntryExposed_1(
    Vector2f m_Value,
    AsciiString m_Name,
    bool m_Overridden) : IUnityStructure
{
    public static VFXEntryExposed_1 Read(EndianBinaryReader reader)
    {
        Vector2f _m_Value = Vector2f.Read(reader);
        reader.AlignTo(4); /* m_Value */
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        bool _m_Overridden = reader.ReadBool();
        reader.AlignTo(4); /* m_Overridden */
        
        return new(_m_Value,
            _m_Name,
            _m_Overridden);
    }

    public override string ToString() => $"VFXEntryExposed_1\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Value: ");
        sb.AppendLine();
        sb.Append(m_Value.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Overridden: ");
        sb.AppendLine(m_Overridden.ToString());

        return sb.ToString();
    }
}

/* $VFXField_2 (1 fields) */
public record class VFXField_2(
    VFXEntryExposed_2[] m_Array) : IUnityStructure
{
    public static VFXField_2 Read(EndianBinaryReader reader)
    {
        VFXEntryExposed_2[] _m_Array = BuiltInArray<VFXEntryExposed_2>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(_m_Array);
    }

    public override string ToString() => $"VFXField_2\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Array: ");
        sb.AppendLine(m_Array.ToString());

        return sb.ToString();
    }
}

/* $VFXEntryExposed_2 (3 fields) */
public record class VFXEntryExposed_2(
    Vector3f m_Value,
    AsciiString m_Name,
    bool m_Overridden) : IUnityStructure
{
    public static VFXEntryExposed_2 Read(EndianBinaryReader reader)
    {
        Vector3f _m_Value = Vector3f.Read(reader);
        reader.AlignTo(4); /* m_Value */
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        bool _m_Overridden = reader.ReadBool();
        reader.AlignTo(4); /* m_Overridden */
        
        return new(_m_Value,
            _m_Name,
            _m_Overridden);
    }

    public override string ToString() => $"VFXEntryExposed_2\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Value: ");
        sb.AppendLine();
        sb.Append(m_Value.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Overridden: ");
        sb.AppendLine(m_Overridden.ToString());

        return sb.ToString();
    }
}

/* $VFXField_3 (1 fields) */
public record class VFXField_3(
    VFXEntryExposed_3[] m_Array) : IUnityStructure
{
    public static VFXField_3 Read(EndianBinaryReader reader)
    {
        VFXEntryExposed_3[] _m_Array = BuiltInArray<VFXEntryExposed_3>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(_m_Array);
    }

    public override string ToString() => $"VFXField_3\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Array: ");
        sb.AppendLine(m_Array.ToString());

        return sb.ToString();
    }
}

/* $VFXEntryExposed_3 (3 fields) */
public record class VFXEntryExposed_3(
    Vector4f m_Value,
    AsciiString m_Name,
    bool m_Overridden) : IUnityStructure
{
    public static VFXEntryExposed_3 Read(EndianBinaryReader reader)
    {
        Vector4f _m_Value = Vector4f.Read(reader);
        reader.AlignTo(4); /* m_Value */
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        bool _m_Overridden = reader.ReadBool();
        reader.AlignTo(4); /* m_Overridden */
        
        return new(_m_Value,
            _m_Name,
            _m_Overridden);
    }

    public override string ToString() => $"VFXEntryExposed_3\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Value: ");
        sb.AppendLine();
        sb.Append(m_Value.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Overridden: ");
        sb.AppendLine(m_Overridden.ToString());

        return sb.ToString();
    }
}

/* $VFXField_4 (1 fields) */
public record class VFXField_4(
    VFXEntryExposed_4[] m_Array) : IUnityStructure
{
    public static VFXField_4 Read(EndianBinaryReader reader)
    {
        VFXEntryExposed_4[] _m_Array = BuiltInArray<VFXEntryExposed_4>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(_m_Array);
    }

    public override string ToString() => $"VFXField_4\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Array: ");
        sb.AppendLine(m_Array.ToString());

        return sb.ToString();
    }
}

/* $VFXEntryExposed_4 (3 fields) */
public record class VFXEntryExposed_4(
    uint m_Value,
    AsciiString m_Name,
    bool m_Overridden) : IUnityStructure
{
    public static VFXEntryExposed_4 Read(EndianBinaryReader reader)
    {
        uint _m_Value = reader.ReadU32();
        reader.AlignTo(4); /* m_Value */
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        bool _m_Overridden = reader.ReadBool();
        reader.AlignTo(4); /* m_Overridden */
        
        return new(_m_Value,
            _m_Name,
            _m_Overridden);
    }

    public override string ToString() => $"VFXEntryExposed_4\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Value: ");
        sb.AppendLine(m_Value.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Overridden: ");
        sb.AppendLine(m_Overridden.ToString());

        return sb.ToString();
    }
}

/* $VFXField_5 (1 fields) */
public record class VFXField_5(
    VFXEntryExposed_5[] m_Array) : IUnityStructure
{
    public static VFXField_5 Read(EndianBinaryReader reader)
    {
        VFXEntryExposed_5[] _m_Array = BuiltInArray<VFXEntryExposed_5>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(_m_Array);
    }

    public override string ToString() => $"VFXField_5\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Array: ");
        sb.AppendLine(m_Array.ToString());

        return sb.ToString();
    }
}

/* $VFXEntryExposed_5 (3 fields) */
public record class VFXEntryExposed_5(
    int m_Value,
    AsciiString m_Name,
    bool m_Overridden) : IUnityStructure
{
    public static VFXEntryExposed_5 Read(EndianBinaryReader reader)
    {
        int _m_Value = reader.ReadS32();
        reader.AlignTo(4); /* m_Value */
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        bool _m_Overridden = reader.ReadBool();
        reader.AlignTo(4); /* m_Overridden */
        
        return new(_m_Value,
            _m_Name,
            _m_Overridden);
    }

    public override string ToString() => $"VFXEntryExposed_5\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Value: ");
        sb.AppendLine(m_Value.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Overridden: ");
        sb.AppendLine(m_Overridden.ToString());

        return sb.ToString();
    }
}

/* $VFXField_6 (1 fields) */
public record class VFXField_6(
    VFXEntryExposed_6[] m_Array) : IUnityStructure
{
    public static VFXField_6 Read(EndianBinaryReader reader)
    {
        VFXEntryExposed_6[] _m_Array = BuiltInArray<VFXEntryExposed_6>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(_m_Array);
    }

    public override string ToString() => $"VFXField_6\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Array: ");
        sb.AppendLine(m_Array.ToString());

        return sb.ToString();
    }
}

/* $VFXEntryExposed_6 (3 fields) */
public record class VFXEntryExposed_6(
    Matrix4x4f m_Value,
    AsciiString m_Name,
    bool m_Overridden) : IUnityStructure
{
    public static VFXEntryExposed_6 Read(EndianBinaryReader reader)
    {
        Matrix4x4f _m_Value = Matrix4x4f.Read(reader);
        reader.AlignTo(4); /* m_Value */
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        bool _m_Overridden = reader.ReadBool();
        reader.AlignTo(4); /* m_Overridden */
        
        return new(_m_Value,
            _m_Name,
            _m_Overridden);
    }

    public override string ToString() => $"VFXEntryExposed_6\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Value: ");
        sb.AppendLine();
        sb.Append(m_Value.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Overridden: ");
        sb.AppendLine(m_Overridden.ToString());

        return sb.ToString();
    }
}

/* $VFXField_7 (1 fields) */
public record class VFXField_7(
    VFXEntryExposed_7[] m_Array) : IUnityStructure
{
    public static VFXField_7 Read(EndianBinaryReader reader)
    {
        VFXEntryExposed_7[] _m_Array = BuiltInArray<VFXEntryExposed_7>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(_m_Array);
    }

    public override string ToString() => $"VFXField_7\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Array: ");
        sb.AppendLine(m_Array.ToString());

        return sb.ToString();
    }
}

/* $VFXEntryExposed_7 (3 fields) */
public record class VFXEntryExposed_7(
    AnimationCurve_0 m_Value,
    AsciiString m_Name,
    bool m_Overridden) : IUnityStructure
{
    public static VFXEntryExposed_7 Read(EndianBinaryReader reader)
    {
        AnimationCurve_0 _m_Value = AnimationCurve_0.Read(reader);
        reader.AlignTo(4); /* m_Value */
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        bool _m_Overridden = reader.ReadBool();
        reader.AlignTo(4); /* m_Overridden */
        
        return new(_m_Value,
            _m_Name,
            _m_Overridden);
    }

    public override string ToString() => $"VFXEntryExposed_7\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Value: ");
        sb.AppendLine();
        sb.Append(m_Value.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Overridden: ");
        sb.AppendLine(m_Overridden.ToString());

        return sb.ToString();
    }
}

/* $AnimationCurve_0 (4 fields) */
public record class AnimationCurve_0(
    Keyframe_0[] m_Curve,
    int m_PreInfinity,
    int m_PostInfinity,
    int m_RotationOrder) : IUnityStructure
{
    public static AnimationCurve_0 Read(EndianBinaryReader reader)
    {
        Keyframe_0[] _m_Curve = BuiltInArray<Keyframe_0>.Read(reader);
        reader.AlignTo(4); /* m_Curve */
        int _m_PreInfinity = reader.ReadS32();
        int _m_PostInfinity = reader.ReadS32();
        int _m_RotationOrder = reader.ReadS32();
        
        return new(_m_Curve,
            _m_PreInfinity,
            _m_PostInfinity,
            _m_RotationOrder);
    }

    public override string ToString() => $"AnimationCurve_0\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Curve: ");
        sb.AppendLine(m_Curve.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PreInfinity: ");
        sb.AppendLine(m_PreInfinity.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PostInfinity: ");
        sb.AppendLine(m_PostInfinity.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RotationOrder: ");
        sb.AppendLine(m_RotationOrder.ToString());

        return sb.ToString();
    }
}

/* $Keyframe_0 (7 fields) */
public readonly record struct Keyframe_0(
    float time,
    float @value,
    float inSlope,
    float outSlope,
    int weightedMode,
    float inWeight,
    float outWeight) : IUnityStructure
{
    public static Keyframe_0 Read(EndianBinaryReader reader)
    {
        float _time = reader.ReadF32();
        float _value = reader.ReadF32();
        float _inSlope = reader.ReadF32();
        float _outSlope = reader.ReadF32();
        int _weightedMode = reader.ReadS32();
        float _inWeight = reader.ReadF32();
        float _outWeight = reader.ReadF32();
        
        return new(_time,
            _value,
            _inSlope,
            _outSlope,
            _weightedMode,
            _inWeight,
            _outWeight);
    }

    public override string ToString() => $"Keyframe_0\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("time: ");
        sb.AppendLine(time.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("@value: ");
        sb.AppendLine(@value.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("inSlope: ");
        sb.AppendLine(inSlope.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("outSlope: ");
        sb.AppendLine(outSlope.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("weightedMode: ");
        sb.AppendLine(weightedMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("inWeight: ");
        sb.AppendLine(inWeight.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("outWeight: ");
        sb.AppendLine(outWeight.ToString());

        return sb.ToString();
    }
}

/* $VFXField_8 (1 fields) */
public record class VFXField_8(
    VFXEntryExposed_8[] m_Array) : IUnityStructure
{
    public static VFXField_8 Read(EndianBinaryReader reader)
    {
        VFXEntryExposed_8[] _m_Array = BuiltInArray<VFXEntryExposed_8>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(_m_Array);
    }

    public override string ToString() => $"VFXField_8\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Array: ");
        sb.AppendLine(m_Array.ToString());

        return sb.ToString();
    }
}

/* $VFXEntryExposed_8 (3 fields) */
public record class VFXEntryExposed_8(
    Gradient m_Value,
    AsciiString m_Name,
    bool m_Overridden) : IUnityStructure
{
    public static VFXEntryExposed_8 Read(EndianBinaryReader reader)
    {
        Gradient _m_Value = Gradient.Read(reader);
        reader.AlignTo(4); /* m_Value */
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        bool _m_Overridden = reader.ReadBool();
        reader.AlignTo(4); /* m_Overridden */
        
        return new(_m_Value,
            _m_Name,
            _m_Overridden);
    }

    public override string ToString() => $"VFXEntryExposed_8\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Value: ");
        sb.AppendLine();
        sb.Append(m_Value.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Overridden: ");
        sb.AppendLine(m_Overridden.ToString());

        return sb.ToString();
    }
}

/* $Gradient (28 fields) */
public record class Gradient(
    ColorRGBA_0 key0,
    ColorRGBA_0 key1,
    ColorRGBA_0 key2,
    ColorRGBA_0 key3,
    ColorRGBA_0 key4,
    ColorRGBA_0 key5,
    ColorRGBA_0 key6,
    ColorRGBA_0 key7,
    ushort ctime0,
    ushort ctime1,
    ushort ctime2,
    ushort ctime3,
    ushort ctime4,
    ushort ctime5,
    ushort ctime6,
    ushort ctime7,
    ushort atime0,
    ushort atime1,
    ushort atime2,
    ushort atime3,
    ushort atime4,
    ushort atime5,
    ushort atime6,
    ushort atime7,
    byte m_Mode,
    sbyte m_ColorSpace,
    byte m_NumColorKeys,
    byte m_NumAlphaKeys) : IUnityStructure
{
    public static Gradient Read(EndianBinaryReader reader)
    {
        ColorRGBA_0 _key0 = ColorRGBA_0.Read(reader);
        ColorRGBA_0 _key1 = ColorRGBA_0.Read(reader);
        ColorRGBA_0 _key2 = ColorRGBA_0.Read(reader);
        ColorRGBA_0 _key3 = ColorRGBA_0.Read(reader);
        ColorRGBA_0 _key4 = ColorRGBA_0.Read(reader);
        ColorRGBA_0 _key5 = ColorRGBA_0.Read(reader);
        ColorRGBA_0 _key6 = ColorRGBA_0.Read(reader);
        ColorRGBA_0 _key7 = ColorRGBA_0.Read(reader);
        ushort _ctime0 = reader.ReadU16();
        ushort _ctime1 = reader.ReadU16();
        ushort _ctime2 = reader.ReadU16();
        ushort _ctime3 = reader.ReadU16();
        ushort _ctime4 = reader.ReadU16();
        ushort _ctime5 = reader.ReadU16();
        ushort _ctime6 = reader.ReadU16();
        ushort _ctime7 = reader.ReadU16();
        ushort _atime0 = reader.ReadU16();
        ushort _atime1 = reader.ReadU16();
        ushort _atime2 = reader.ReadU16();
        ushort _atime3 = reader.ReadU16();
        ushort _atime4 = reader.ReadU16();
        ushort _atime5 = reader.ReadU16();
        ushort _atime6 = reader.ReadU16();
        ushort _atime7 = reader.ReadU16();
        byte _m_Mode = reader.ReadU8();
        sbyte _m_ColorSpace = reader.ReadS8();
        byte _m_NumColorKeys = reader.ReadU8();
        byte _m_NumAlphaKeys = reader.ReadU8();
        reader.AlignTo(4); /* m_NumAlphaKeys */
        
        return new(_key0,
            _key1,
            _key2,
            _key3,
            _key4,
            _key5,
            _key6,
            _key7,
            _ctime0,
            _ctime1,
            _ctime2,
            _ctime3,
            _ctime4,
            _ctime5,
            _ctime6,
            _ctime7,
            _atime0,
            _atime1,
            _atime2,
            _atime3,
            _atime4,
            _atime5,
            _atime6,
            _atime7,
            _m_Mode,
            _m_ColorSpace,
            _m_NumColorKeys,
            _m_NumAlphaKeys);
    }

    public override string ToString() => $"Gradient\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("key0: ");
        sb.AppendLine();
        sb.Append(key0.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("key1: ");
        sb.AppendLine();
        sb.Append(key1.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("key2: ");
        sb.AppendLine();
        sb.Append(key2.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("key3: ");
        sb.AppendLine();
        sb.Append(key3.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("key4: ");
        sb.AppendLine();
        sb.Append(key4.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("key5: ");
        sb.AppendLine();
        sb.Append(key5.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("key6: ");
        sb.AppendLine();
        sb.Append(key6.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("key7: ");
        sb.AppendLine();
        sb.Append(key7.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("ctime0: ");
        sb.AppendLine(ctime0.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("ctime1: ");
        sb.AppendLine(ctime1.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("ctime2: ");
        sb.AppendLine(ctime2.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("ctime3: ");
        sb.AppendLine(ctime3.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("ctime4: ");
        sb.AppendLine(ctime4.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("ctime5: ");
        sb.AppendLine(ctime5.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("ctime6: ");
        sb.AppendLine(ctime6.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("ctime7: ");
        sb.AppendLine(ctime7.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("atime0: ");
        sb.AppendLine(atime0.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("atime1: ");
        sb.AppendLine(atime1.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("atime2: ");
        sb.AppendLine(atime2.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("atime3: ");
        sb.AppendLine(atime3.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("atime4: ");
        sb.AppendLine(atime4.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("atime5: ");
        sb.AppendLine(atime5.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("atime6: ");
        sb.AppendLine(atime6.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("atime7: ");
        sb.AppendLine(atime7.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Mode: ");
        sb.AppendLine(m_Mode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ColorSpace: ");
        sb.AppendLine(m_ColorSpace.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NumColorKeys: ");
        sb.AppendLine(m_NumColorKeys.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NumAlphaKeys: ");
        sb.AppendLine(m_NumAlphaKeys.ToString());

        return sb.ToString();
    }
}

/* $VFXField_9 (1 fields) */
public record class VFXField_9(
    VFXEntryExposed_9[] m_Array) : IUnityStructure
{
    public static VFXField_9 Read(EndianBinaryReader reader)
    {
        VFXEntryExposed_9[] _m_Array = BuiltInArray<VFXEntryExposed_9>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(_m_Array);
    }

    public override string ToString() => $"VFXField_9\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Array: ");
        sb.AppendLine(m_Array.ToString());

        return sb.ToString();
    }
}

/* $VFXEntryExposed_9 (3 fields) */
public record class VFXEntryExposed_9(
    PPtr<Object> m_Value,
    AsciiString m_Name,
    bool m_Overridden) : IUnityStructure
{
    public static VFXEntryExposed_9 Read(EndianBinaryReader reader)
    {
        PPtr<Object> _m_Value = PPtr<Object>.Read(reader);
        reader.AlignTo(4); /* m_Value */
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        bool _m_Overridden = reader.ReadBool();
        reader.AlignTo(4); /* m_Overridden */
        
        return new(_m_Value,
            _m_Name,
            _m_Overridden);
    }

    public override string ToString() => $"VFXEntryExposed_9\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Value: ");
        sb.AppendLine(m_Value.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Overridden: ");
        sb.AppendLine(m_Overridden.ToString());

        return sb.ToString();
    }
}

/* $VFXField_10 (1 fields) */
public record class VFXField_10(
    VFXEntryExposed_10[] m_Array) : IUnityStructure
{
    public static VFXField_10 Read(EndianBinaryReader reader)
    {
        VFXEntryExposed_10[] _m_Array = BuiltInArray<VFXEntryExposed_10>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(_m_Array);
    }

    public override string ToString() => $"VFXField_10\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Array: ");
        sb.AppendLine(m_Array.ToString());

        return sb.ToString();
    }
}

/* $VFXEntryExposed_10 (3 fields) */
public record class VFXEntryExposed_10(
    bool m_Value,
    AsciiString m_Name,
    bool m_Overridden) : IUnityStructure
{
    public static VFXEntryExposed_10 Read(EndianBinaryReader reader)
    {
        bool _m_Value = reader.ReadBool();
        reader.AlignTo(4); /* m_Value */
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        bool _m_Overridden = reader.ReadBool();
        reader.AlignTo(4); /* m_Overridden */
        
        return new(_m_Value,
            _m_Name,
            _m_Overridden);
    }

    public override string ToString() => $"VFXEntryExposed_10\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Value: ");
        sb.AppendLine(m_Value.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Overridden: ");
        sb.AppendLine(m_Overridden.ToString());

        return sb.ToString();
    }
}

/* $pair_1 (2 fields) */
public record class pair_1(
    GUID first,
    long second) : IUnityStructure
{
    public static pair_1 Read(EndianBinaryReader reader)
    {
        GUID _first = GUID.Read(reader);
        long _second = reader.ReadS64();
        
        return new(_first,
            _second);
    }

    public override string ToString() => $"pair_1\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("first: ");
        sb.AppendLine();
        sb.Append(first.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("second: ");
        sb.AppendLine(second.ToString());

        return sb.ToString();
    }
}

/* $GUID (4 fields) */
public readonly record struct GUID(
    uint data_0,
    uint data_1,
    uint data_2,
    uint data_3) : IUnityStructure
{
    public static GUID Read(EndianBinaryReader reader)
    {
        uint _data_0 = reader.ReadU32();
        uint _data_1 = reader.ReadU32();
        uint _data_2 = reader.ReadU32();
        uint _data_3 = reader.ReadU32();
        
        return new(_data_0,
            _data_1,
            _data_2,
            _data_3);
    }

    public override string ToString() => $"GUID\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data_0: ");
        sb.AppendLine(data_0.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data_1: ");
        sb.AppendLine(data_1.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data_2: ");
        sb.AppendLine(data_2.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data_3: ");
        sb.AppendLine(data_3.ToString());

        return sb.ToString();
    }
}

/* $SpriteAtlasData (9 fields) */
public record class SpriteAtlasData(
    PPtr<Texture2D> texture,
    PPtr<Texture2D> alphaTexture,
    Rectf textureRect,
    Vector2f textureRectOffset,
    Vector2f atlasRectOffset,
    Vector4f uvTransform,
    float downscaleMultiplier,
    uint settingsRaw,
    SecondarySpriteTexture[] secondaryTextures) : IUnityStructure
{
    public static SpriteAtlasData Read(EndianBinaryReader reader)
    {
        PPtr<Texture2D> _texture = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> _alphaTexture = PPtr<Texture2D>.Read(reader);
        Rectf _textureRect = Rectf.Read(reader);
        Vector2f _textureRectOffset = Vector2f.Read(reader);
        Vector2f _atlasRectOffset = Vector2f.Read(reader);
        Vector4f _uvTransform = Vector4f.Read(reader);
        float _downscaleMultiplier = reader.ReadF32();
        uint _settingsRaw = reader.ReadU32();
        SecondarySpriteTexture[] _secondaryTextures = BuiltInArray<SecondarySpriteTexture>.Read(reader);
        reader.AlignTo(4); /* secondaryTextures */
        
        return new(_texture,
            _alphaTexture,
            _textureRect,
            _textureRectOffset,
            _atlasRectOffset,
            _uvTransform,
            _downscaleMultiplier,
            _settingsRaw,
            _secondaryTextures);
    }

    public override string ToString() => $"SpriteAtlasData\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("texture: ");
        sb.AppendLine(texture.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("alphaTexture: ");
        sb.AppendLine(alphaTexture.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("textureRect: ");
        sb.AppendLine();
        sb.Append(textureRect.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("textureRectOffset: ");
        sb.AppendLine();
        sb.Append(textureRectOffset.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("atlasRectOffset: ");
        sb.AppendLine();
        sb.Append(atlasRectOffset.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("uvTransform: ");
        sb.AppendLine();
        sb.Append(uvTransform.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("downscaleMultiplier: ");
        sb.AppendLine(downscaleMultiplier.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("settingsRaw: ");
        sb.AppendLine(settingsRaw.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("secondaryTextures: ");
        sb.AppendLine(secondaryTextures.ToString());

        return sb.ToString();
    }
}

/* $SecondarySpriteTexture (2 fields) */
public record class SecondarySpriteTexture(
    PPtr<Texture2D> texture,
    AsciiString name) : IUnityStructure
{
    public static SecondarySpriteTexture Read(EndianBinaryReader reader)
    {
        PPtr<Texture2D> _texture = PPtr<Texture2D>.Read(reader);
        AsciiString _name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* name */
        
        return new(_texture,
            _name);
    }

    public override string ToString() => $"SecondarySpriteTexture\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("texture: ");
        sb.AppendLine(texture.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("name: ");
        sb.AppendLine(name.ToString());

        return sb.ToString();
    }
}

/* $SerializedShader (10 fields) */
public record class SerializedShader(
    SerializedProperties m_PropInfo,
    SerializedSubShader[] m_SubShaders,
    AsciiString[] m_KeywordNames,
    byte[] m_KeywordFlags,
    AsciiString m_Name,
    AsciiString m_CustomEditorName,
    AsciiString m_FallbackName,
    SerializedShaderDependency[] m_Dependencies,
    SerializedCustomEditorForRenderPipeline[] m_CustomEditorForRenderPipelines,
    bool m_DisableNoSubshadersMessage) : IUnityStructure
{
    public static SerializedShader Read(EndianBinaryReader reader)
    {
        SerializedProperties _m_PropInfo = SerializedProperties.Read(reader);
        reader.AlignTo(4); /* m_PropInfo */
        SerializedSubShader[] _m_SubShaders = BuiltInArray<SerializedSubShader>.Read(reader);
        reader.AlignTo(4); /* m_SubShaders */
        AsciiString[] _m_KeywordNames = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_KeywordNames */
        byte[] _m_KeywordFlags = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_KeywordFlags */
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        AsciiString _m_CustomEditorName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CustomEditorName */
        AsciiString _m_FallbackName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FallbackName */
        SerializedShaderDependency[] _m_Dependencies = BuiltInArray<SerializedShaderDependency>.Read(reader);
        reader.AlignTo(4); /* m_Dependencies */
        SerializedCustomEditorForRenderPipeline[] _m_CustomEditorForRenderPipelines = BuiltInArray<SerializedCustomEditorForRenderPipeline>.Read(reader);
        reader.AlignTo(4); /* m_CustomEditorForRenderPipelines */
        bool _m_DisableNoSubshadersMessage = reader.ReadBool();
        reader.AlignTo(4); /* m_DisableNoSubshadersMessage */
        
        return new(_m_PropInfo,
            _m_SubShaders,
            _m_KeywordNames,
            _m_KeywordFlags,
            _m_Name,
            _m_CustomEditorName,
            _m_FallbackName,
            _m_Dependencies,
            _m_CustomEditorForRenderPipelines,
            _m_DisableNoSubshadersMessage);
    }

    public override string ToString() => $"SerializedShader\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PropInfo: ");
        sb.AppendLine();
        sb.Append(m_PropInfo.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SubShaders: ");
        sb.AppendLine(m_SubShaders.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_KeywordNames: ");
        sb.AppendLine(m_KeywordNames.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_KeywordFlags: ");
        sb.AppendLine(m_KeywordFlags.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CustomEditorName: ");
        sb.AppendLine(m_CustomEditorName.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FallbackName: ");
        sb.AppendLine(m_FallbackName.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Dependencies: ");
        sb.AppendLine(m_Dependencies.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CustomEditorForRenderPipelines: ");
        sb.AppendLine(m_CustomEditorForRenderPipelines.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DisableNoSubshadersMessage: ");
        sb.AppendLine(m_DisableNoSubshadersMessage.ToString());

        return sb.ToString();
    }
}

/* $SerializedProperties (1 fields) */
public record class SerializedProperties(
    SerializedProperty[] m_Props) : IUnityStructure
{
    public static SerializedProperties Read(EndianBinaryReader reader)
    {
        SerializedProperty[] _m_Props = BuiltInArray<SerializedProperty>.Read(reader);
        reader.AlignTo(4); /* m_Props */
        
        return new(_m_Props);
    }

    public override string ToString() => $"SerializedProperties\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Props: ");
        sb.AppendLine(m_Props.ToString());

        return sb.ToString();
    }
}

/* $SerializedProperty (10 fields) */
public record class SerializedProperty(
    AsciiString m_Name,
    AsciiString m_Description,
    AsciiString[] m_Attributes,
    int m_Type,
    uint m_Flags,
    float m_DefValue_0,
    float m_DefValue_1,
    float m_DefValue_2,
    float m_DefValue_3,
    SerializedTextureProperty m_DefTexture) : IUnityStructure
{
    public static SerializedProperty Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        AsciiString _m_Description = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Description */
        AsciiString[] _m_Attributes = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_Attributes */
        int _m_Type = reader.ReadS32();
        uint _m_Flags = reader.ReadU32();
        float _m_DefValue_0 = reader.ReadF32();
        float _m_DefValue_1 = reader.ReadF32();
        float _m_DefValue_2 = reader.ReadF32();
        float _m_DefValue_3 = reader.ReadF32();
        SerializedTextureProperty _m_DefTexture = SerializedTextureProperty.Read(reader);
        reader.AlignTo(4); /* m_DefTexture */
        
        return new(_m_Name,
            _m_Description,
            _m_Attributes,
            _m_Type,
            _m_Flags,
            _m_DefValue_0,
            _m_DefValue_1,
            _m_DefValue_2,
            _m_DefValue_3,
            _m_DefTexture);
    }

    public override string ToString() => $"SerializedProperty\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Description: ");
        sb.AppendLine(m_Description.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Attributes: ");
        sb.AppendLine(m_Attributes.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Type: ");
        sb.AppendLine(m_Type.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Flags: ");
        sb.AppendLine(m_Flags.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DefValue_0: ");
        sb.AppendLine(m_DefValue_0.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DefValue_1: ");
        sb.AppendLine(m_DefValue_1.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DefValue_2: ");
        sb.AppendLine(m_DefValue_2.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DefValue_3: ");
        sb.AppendLine(m_DefValue_3.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DefTexture: ");
        sb.AppendLine();
        sb.Append(m_DefTexture.ToString(indent+4));

        return sb.ToString();
    }
}

/* $SerializedTextureProperty (2 fields) */
public record class SerializedTextureProperty(
    AsciiString m_DefaultName,
    int m_TexDim) : IUnityStructure
{
    public static SerializedTextureProperty Read(EndianBinaryReader reader)
    {
        AsciiString _m_DefaultName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_DefaultName */
        int _m_TexDim = reader.ReadS32();
        
        return new(_m_DefaultName,
            _m_TexDim);
    }

    public override string ToString() => $"SerializedTextureProperty\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DefaultName: ");
        sb.AppendLine(m_DefaultName.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TexDim: ");
        sb.AppendLine(m_TexDim.ToString());

        return sb.ToString();
    }
}

/* $SerializedSubShader (3 fields) */
public record class SerializedSubShader(
    SerializedPass[] m_Passes,
    SerializedTagMap m_Tags,
    int m_LOD) : IUnityStructure
{
    public static SerializedSubShader Read(EndianBinaryReader reader)
    {
        SerializedPass[] _m_Passes = BuiltInArray<SerializedPass>.Read(reader);
        reader.AlignTo(4); /* m_Passes */
        SerializedTagMap _m_Tags = SerializedTagMap.Read(reader);
        reader.AlignTo(4); /* m_Tags */
        int _m_LOD = reader.ReadS32();
        
        return new(_m_Passes,
            _m_Tags,
            _m_LOD);
    }

    public override string ToString() => $"SerializedSubShader\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Passes: ");
        sb.AppendLine(m_Passes.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Tags: ");
        sb.AppendLine();
        sb.Append(m_Tags.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LOD: ");
        sb.AppendLine(m_LOD.ToString());

        return sb.ToString();
    }
}

/* $SerializedPass (18 fields) */
public record class SerializedPass(
    Hash128[] m_EditorDataHash,
    byte[] m_Platforms,
    Dictionary<AsciiString, int> m_NameIndices,
    int m_Type,
    SerializedShaderState m_State,
    uint m_ProgramMask,
    SerializedProgram progVertex,
    SerializedProgram progFragment,
    SerializedProgram progGeometry,
    SerializedProgram progHull,
    SerializedProgram progDomain,
    SerializedProgram progRayTracing,
    bool m_HasInstancingVariant,
    bool m_HasProceduralInstancingVariant,
    AsciiString m_UseName,
    AsciiString m_Name,
    AsciiString m_TextureName,
    SerializedTagMap m_Tags) : IUnityStructure
{
    public static SerializedPass Read(EndianBinaryReader reader)
    {
        Hash128[] _m_EditorDataHash = BuiltInArray<Hash128>.Read(reader);
        reader.AlignTo(4); /* m_EditorDataHash */
        byte[] _m_Platforms = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_Platforms */
        Dictionary<AsciiString, int> _m_NameIndices = BuiltInMap<AsciiString, int>.Read(reader);
        reader.AlignTo(4); /* m_NameIndices */
        int _m_Type = reader.ReadS32();
        SerializedShaderState _m_State = SerializedShaderState.Read(reader);
        reader.AlignTo(4); /* m_State */
        uint _m_ProgramMask = reader.ReadU32();
        SerializedProgram _progVertex = SerializedProgram.Read(reader);
        reader.AlignTo(4); /* progVertex */
        SerializedProgram _progFragment = SerializedProgram.Read(reader);
        reader.AlignTo(4); /* progFragment */
        SerializedProgram _progGeometry = SerializedProgram.Read(reader);
        reader.AlignTo(4); /* progGeometry */
        SerializedProgram _progHull = SerializedProgram.Read(reader);
        reader.AlignTo(4); /* progHull */
        SerializedProgram _progDomain = SerializedProgram.Read(reader);
        reader.AlignTo(4); /* progDomain */
        SerializedProgram _progRayTracing = SerializedProgram.Read(reader);
        reader.AlignTo(4); /* progRayTracing */
        bool _m_HasInstancingVariant = reader.ReadBool();
        bool _m_HasProceduralInstancingVariant = reader.ReadBool();
        reader.AlignTo(4); /* m_HasProceduralInstancingVariant */
        AsciiString _m_UseName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_UseName */
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        AsciiString _m_TextureName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TextureName */
        SerializedTagMap _m_Tags = SerializedTagMap.Read(reader);
        reader.AlignTo(4); /* m_Tags */
        
        return new(_m_EditorDataHash,
            _m_Platforms,
            _m_NameIndices,
            _m_Type,
            _m_State,
            _m_ProgramMask,
            _progVertex,
            _progFragment,
            _progGeometry,
            _progHull,
            _progDomain,
            _progRayTracing,
            _m_HasInstancingVariant,
            _m_HasProceduralInstancingVariant,
            _m_UseName,
            _m_Name,
            _m_TextureName,
            _m_Tags);
    }

    public override string ToString() => $"SerializedPass\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_EditorDataHash: ");
        sb.AppendLine(m_EditorDataHash.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Platforms: ");
        sb.AppendLine(m_Platforms.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NameIndices: ");
        sb.AppendLine(m_NameIndices.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Type: ");
        sb.AppendLine(m_Type.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_State: ");
        sb.AppendLine();
        sb.Append(m_State.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ProgramMask: ");
        sb.AppendLine(m_ProgramMask.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("progVertex: ");
        sb.AppendLine();
        sb.Append(progVertex.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("progFragment: ");
        sb.AppendLine();
        sb.Append(progFragment.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("progGeometry: ");
        sb.AppendLine();
        sb.Append(progGeometry.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("progHull: ");
        sb.AppendLine();
        sb.Append(progHull.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("progDomain: ");
        sb.AppendLine();
        sb.Append(progDomain.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("progRayTracing: ");
        sb.AppendLine();
        sb.Append(progRayTracing.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HasInstancingVariant: ");
        sb.AppendLine(m_HasInstancingVariant.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HasProceduralInstancingVariant: ");
        sb.AppendLine(m_HasProceduralInstancingVariant.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_UseName: ");
        sb.AppendLine(m_UseName.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TextureName: ");
        sb.AppendLine(m_TextureName.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Tags: ");
        sb.AppendLine();
        sb.Append(m_Tags.ToString(indent+4));

        return sb.ToString();
    }
}

/* $SerializedShaderState (33 fields) */
public record class SerializedShaderState(
    AsciiString m_Name,
    SerializedShaderRTBlendState rtBlend0,
    SerializedShaderRTBlendState rtBlend1,
    SerializedShaderRTBlendState rtBlend2,
    SerializedShaderRTBlendState rtBlend3,
    SerializedShaderRTBlendState rtBlend4,
    SerializedShaderRTBlendState rtBlend5,
    SerializedShaderRTBlendState rtBlend6,
    SerializedShaderRTBlendState rtBlend7,
    bool rtSeparateBlend,
    SerializedShaderFloatValue zClip,
    SerializedShaderFloatValue zTest,
    SerializedShaderFloatValue zWrite,
    SerializedShaderFloatValue culling,
    SerializedShaderFloatValue conservative,
    SerializedShaderFloatValue offsetFactor,
    SerializedShaderFloatValue offsetUnits,
    SerializedShaderFloatValue alphaToMask,
    SerializedStencilOp stencilOp,
    SerializedStencilOp stencilOpFront,
    SerializedStencilOp stencilOpBack,
    SerializedShaderFloatValue stencilReadMask,
    SerializedShaderFloatValue stencilWriteMask,
    SerializedShaderFloatValue stencilRef,
    SerializedShaderFloatValue fogStart,
    SerializedShaderFloatValue fogEnd,
    SerializedShaderFloatValue fogDensity,
    SerializedShaderVectorValue fogColor,
    int fogMode,
    int gpuProgramID,
    SerializedTagMap m_Tags,
    int m_LOD,
    bool lighting) : IUnityStructure
{
    public static SerializedShaderState Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        SerializedShaderRTBlendState _rtBlend0 = SerializedShaderRTBlendState.Read(reader);
        reader.AlignTo(4); /* rtBlend0 */
        SerializedShaderRTBlendState _rtBlend1 = SerializedShaderRTBlendState.Read(reader);
        reader.AlignTo(4); /* rtBlend1 */
        SerializedShaderRTBlendState _rtBlend2 = SerializedShaderRTBlendState.Read(reader);
        reader.AlignTo(4); /* rtBlend2 */
        SerializedShaderRTBlendState _rtBlend3 = SerializedShaderRTBlendState.Read(reader);
        reader.AlignTo(4); /* rtBlend3 */
        SerializedShaderRTBlendState _rtBlend4 = SerializedShaderRTBlendState.Read(reader);
        reader.AlignTo(4); /* rtBlend4 */
        SerializedShaderRTBlendState _rtBlend5 = SerializedShaderRTBlendState.Read(reader);
        reader.AlignTo(4); /* rtBlend5 */
        SerializedShaderRTBlendState _rtBlend6 = SerializedShaderRTBlendState.Read(reader);
        reader.AlignTo(4); /* rtBlend6 */
        SerializedShaderRTBlendState _rtBlend7 = SerializedShaderRTBlendState.Read(reader);
        reader.AlignTo(4); /* rtBlend7 */
        bool _rtSeparateBlend = reader.ReadBool();
        reader.AlignTo(4); /* rtSeparateBlend */
        SerializedShaderFloatValue _zClip = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* zClip */
        SerializedShaderFloatValue _zTest = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* zTest */
        SerializedShaderFloatValue _zWrite = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* zWrite */
        SerializedShaderFloatValue _culling = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* culling */
        SerializedShaderFloatValue _conservative = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* conservative */
        SerializedShaderFloatValue _offsetFactor = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* offsetFactor */
        SerializedShaderFloatValue _offsetUnits = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* offsetUnits */
        SerializedShaderFloatValue _alphaToMask = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* alphaToMask */
        SerializedStencilOp _stencilOp = SerializedStencilOp.Read(reader);
        reader.AlignTo(4); /* stencilOp */
        SerializedStencilOp _stencilOpFront = SerializedStencilOp.Read(reader);
        reader.AlignTo(4); /* stencilOpFront */
        SerializedStencilOp _stencilOpBack = SerializedStencilOp.Read(reader);
        reader.AlignTo(4); /* stencilOpBack */
        SerializedShaderFloatValue _stencilReadMask = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* stencilReadMask */
        SerializedShaderFloatValue _stencilWriteMask = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* stencilWriteMask */
        SerializedShaderFloatValue _stencilRef = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* stencilRef */
        SerializedShaderFloatValue _fogStart = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* fogStart */
        SerializedShaderFloatValue _fogEnd = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* fogEnd */
        SerializedShaderFloatValue _fogDensity = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* fogDensity */
        SerializedShaderVectorValue _fogColor = SerializedShaderVectorValue.Read(reader);
        reader.AlignTo(4); /* fogColor */
        int _fogMode = reader.ReadS32();
        int _gpuProgramID = reader.ReadS32();
        SerializedTagMap _m_Tags = SerializedTagMap.Read(reader);
        reader.AlignTo(4); /* m_Tags */
        int _m_LOD = reader.ReadS32();
        bool _lighting = reader.ReadBool();
        reader.AlignTo(4); /* lighting */
        
        return new(_m_Name,
            _rtBlend0,
            _rtBlend1,
            _rtBlend2,
            _rtBlend3,
            _rtBlend4,
            _rtBlend5,
            _rtBlend6,
            _rtBlend7,
            _rtSeparateBlend,
            _zClip,
            _zTest,
            _zWrite,
            _culling,
            _conservative,
            _offsetFactor,
            _offsetUnits,
            _alphaToMask,
            _stencilOp,
            _stencilOpFront,
            _stencilOpBack,
            _stencilReadMask,
            _stencilWriteMask,
            _stencilRef,
            _fogStart,
            _fogEnd,
            _fogDensity,
            _fogColor,
            _fogMode,
            _gpuProgramID,
            _m_Tags,
            _m_LOD,
            _lighting);
    }

    public override string ToString() => $"SerializedShaderState\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("rtBlend0: ");
        sb.AppendLine();
        sb.Append(rtBlend0.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("rtBlend1: ");
        sb.AppendLine();
        sb.Append(rtBlend1.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("rtBlend2: ");
        sb.AppendLine();
        sb.Append(rtBlend2.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("rtBlend3: ");
        sb.AppendLine();
        sb.Append(rtBlend3.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("rtBlend4: ");
        sb.AppendLine();
        sb.Append(rtBlend4.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("rtBlend5: ");
        sb.AppendLine();
        sb.Append(rtBlend5.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("rtBlend6: ");
        sb.AppendLine();
        sb.Append(rtBlend6.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("rtBlend7: ");
        sb.AppendLine();
        sb.Append(rtBlend7.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("rtSeparateBlend: ");
        sb.AppendLine(rtSeparateBlend.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("zClip: ");
        sb.AppendLine();
        sb.Append(zClip.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("zTest: ");
        sb.AppendLine();
        sb.Append(zTest.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("zWrite: ");
        sb.AppendLine();
        sb.Append(zWrite.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("culling: ");
        sb.AppendLine();
        sb.Append(culling.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("conservative: ");
        sb.AppendLine();
        sb.Append(conservative.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("offsetFactor: ");
        sb.AppendLine();
        sb.Append(offsetFactor.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("offsetUnits: ");
        sb.AppendLine();
        sb.Append(offsetUnits.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("alphaToMask: ");
        sb.AppendLine();
        sb.Append(alphaToMask.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("stencilOp: ");
        sb.AppendLine();
        sb.Append(stencilOp.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("stencilOpFront: ");
        sb.AppendLine();
        sb.Append(stencilOpFront.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("stencilOpBack: ");
        sb.AppendLine();
        sb.Append(stencilOpBack.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("stencilReadMask: ");
        sb.AppendLine();
        sb.Append(stencilReadMask.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("stencilWriteMask: ");
        sb.AppendLine();
        sb.Append(stencilWriteMask.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("stencilRef: ");
        sb.AppendLine();
        sb.Append(stencilRef.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("fogStart: ");
        sb.AppendLine();
        sb.Append(fogStart.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("fogEnd: ");
        sb.AppendLine();
        sb.Append(fogEnd.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("fogDensity: ");
        sb.AppendLine();
        sb.Append(fogDensity.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("fogColor: ");
        sb.AppendLine();
        sb.Append(fogColor.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("fogMode: ");
        sb.AppendLine(fogMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("gpuProgramID: ");
        sb.AppendLine(gpuProgramID.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Tags: ");
        sb.AppendLine();
        sb.Append(m_Tags.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LOD: ");
        sb.AppendLine(m_LOD.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("lighting: ");
        sb.AppendLine(lighting.ToString());

        return sb.ToString();
    }
}

/* $SerializedShaderRTBlendState (7 fields) */
public record class SerializedShaderRTBlendState(
    SerializedShaderFloatValue srcBlend,
    SerializedShaderFloatValue destBlend,
    SerializedShaderFloatValue srcBlendAlpha,
    SerializedShaderFloatValue destBlendAlpha,
    SerializedShaderFloatValue blendOp,
    SerializedShaderFloatValue blendOpAlpha,
    SerializedShaderFloatValue colMask) : IUnityStructure
{
    public static SerializedShaderRTBlendState Read(EndianBinaryReader reader)
    {
        SerializedShaderFloatValue _srcBlend = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* srcBlend */
        SerializedShaderFloatValue _destBlend = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* destBlend */
        SerializedShaderFloatValue _srcBlendAlpha = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* srcBlendAlpha */
        SerializedShaderFloatValue _destBlendAlpha = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* destBlendAlpha */
        SerializedShaderFloatValue _blendOp = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* blendOp */
        SerializedShaderFloatValue _blendOpAlpha = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* blendOpAlpha */
        SerializedShaderFloatValue _colMask = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* colMask */
        
        return new(_srcBlend,
            _destBlend,
            _srcBlendAlpha,
            _destBlendAlpha,
            _blendOp,
            _blendOpAlpha,
            _colMask);
    }

    public override string ToString() => $"SerializedShaderRTBlendState\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("srcBlend: ");
        sb.AppendLine();
        sb.Append(srcBlend.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("destBlend: ");
        sb.AppendLine();
        sb.Append(destBlend.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("srcBlendAlpha: ");
        sb.AppendLine();
        sb.Append(srcBlendAlpha.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("destBlendAlpha: ");
        sb.AppendLine();
        sb.Append(destBlendAlpha.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("blendOp: ");
        sb.AppendLine();
        sb.Append(blendOp.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("blendOpAlpha: ");
        sb.AppendLine();
        sb.Append(blendOpAlpha.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("colMask: ");
        sb.AppendLine();
        sb.Append(colMask.ToString(indent+4));

        return sb.ToString();
    }
}

/* $SerializedShaderFloatValue (2 fields) */
public record class SerializedShaderFloatValue(
    float val,
    AsciiString name) : IUnityStructure
{
    public static SerializedShaderFloatValue Read(EndianBinaryReader reader)
    {
        float _val = reader.ReadF32();
        AsciiString _name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* name */
        
        return new(_val,
            _name);
    }

    public override string ToString() => $"SerializedShaderFloatValue\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("val: ");
        sb.AppendLine(val.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("name: ");
        sb.AppendLine(name.ToString());

        return sb.ToString();
    }
}

/* $SerializedStencilOp (4 fields) */
public record class SerializedStencilOp(
    SerializedShaderFloatValue pass,
    SerializedShaderFloatValue fail,
    SerializedShaderFloatValue zFail,
    SerializedShaderFloatValue comp) : IUnityStructure
{
    public static SerializedStencilOp Read(EndianBinaryReader reader)
    {
        SerializedShaderFloatValue _pass = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* pass */
        SerializedShaderFloatValue _fail = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* fail */
        SerializedShaderFloatValue _zFail = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* zFail */
        SerializedShaderFloatValue _comp = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* comp */
        
        return new(_pass,
            _fail,
            _zFail,
            _comp);
    }

    public override string ToString() => $"SerializedStencilOp\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("pass: ");
        sb.AppendLine();
        sb.Append(pass.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("fail: ");
        sb.AppendLine();
        sb.Append(fail.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("zFail: ");
        sb.AppendLine();
        sb.Append(zFail.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("comp: ");
        sb.AppendLine();
        sb.Append(comp.ToString(indent+4));

        return sb.ToString();
    }
}

/* $SerializedShaderVectorValue (5 fields) */
public record class SerializedShaderVectorValue(
    SerializedShaderFloatValue x,
    SerializedShaderFloatValue y,
    SerializedShaderFloatValue z,
    SerializedShaderFloatValue w,
    AsciiString name) : IUnityStructure
{
    public static SerializedShaderVectorValue Read(EndianBinaryReader reader)
    {
        SerializedShaderFloatValue _x = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* x */
        SerializedShaderFloatValue _y = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* y */
        SerializedShaderFloatValue _z = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* z */
        SerializedShaderFloatValue _w = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* w */
        AsciiString _name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* name */
        
        return new(_x,
            _y,
            _z,
            _w,
            _name);
    }

    public override string ToString() => $"SerializedShaderVectorValue\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("x: ");
        sb.AppendLine();
        sb.Append(x.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("y: ");
        sb.AppendLine();
        sb.Append(y.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("z: ");
        sb.AppendLine();
        sb.Append(z.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("w: ");
        sb.AppendLine();
        sb.Append(w.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("name: ");
        sb.AppendLine(name.ToString());

        return sb.ToString();
    }
}

/* $SerializedTagMap (1 fields) */
public record class SerializedTagMap(
    Dictionary<AsciiString, AsciiString> tags) : IUnityStructure
{
    public static SerializedTagMap Read(EndianBinaryReader reader)
    {
        Dictionary<AsciiString, AsciiString> _tags = BuiltInMap<AsciiString, AsciiString>.Read(reader);
        reader.AlignTo(4); /* tags */
        
        return new(_tags);
    }

    public override string ToString() => $"SerializedTagMap\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("tags: ");
        sb.AppendLine(tags.ToString());

        return sb.ToString();
    }
}

/* $SerializedProgram (5 fields) */
public record class SerializedProgram(
    SerializedSubProgram[] m_SubPrograms,
    SerializedPlayerSubProgram[][] m_PlayerSubPrograms,
    uint[][] m_ParameterBlobIndices,
    SerializedProgramParameters m_CommonParameters,
    ushort[] m_SerializedKeywordStateMask) : IUnityStructure
{
    public static SerializedProgram Read(EndianBinaryReader reader)
    {
        SerializedSubProgram[] _m_SubPrograms = BuiltInArray<SerializedSubProgram>.Read(reader);
        reader.AlignTo(4); /* m_SubPrograms */
        SerializedPlayerSubProgram[][] _m_PlayerSubPrograms = BuiltInArray<SerializedPlayerSubProgram[]>.Read(reader);
        reader.AlignTo(4); /* m_PlayerSubPrograms */
        uint[][] _m_ParameterBlobIndices = BuiltInArray<uint[]>.Read(reader);
        reader.AlignTo(4); /* m_ParameterBlobIndices */
        SerializedProgramParameters _m_CommonParameters = SerializedProgramParameters.Read(reader);
        reader.AlignTo(4); /* m_CommonParameters */
        ushort[] _m_SerializedKeywordStateMask = BuiltInArray<ushort>.Read(reader);
        reader.AlignTo(4); /* m_SerializedKeywordStateMask */
        
        return new(_m_SubPrograms,
            _m_PlayerSubPrograms,
            _m_ParameterBlobIndices,
            _m_CommonParameters,
            _m_SerializedKeywordStateMask);
    }

    public override string ToString() => $"SerializedProgram\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SubPrograms: ");
        sb.AppendLine(m_SubPrograms.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PlayerSubPrograms: ");
        sb.AppendLine(m_PlayerSubPrograms.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ParameterBlobIndices: ");
        sb.AppendLine(m_ParameterBlobIndices.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CommonParameters: ");
        sb.AppendLine();
        sb.Append(m_CommonParameters.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SerializedKeywordStateMask: ");
        sb.AppendLine(m_SerializedKeywordStateMask.ToString());

        return sb.ToString();
    }
}

/* $SerializedSubProgram (7 fields) */
public record class SerializedSubProgram(
    uint m_BlobIndex,
    ParserBindChannels m_Channels,
    ushort[] m_KeywordIndices,
    sbyte m_ShaderHardwareTier,
    sbyte m_GpuProgramType,
    SerializedProgramParameters m_Parameters,
    long m_ShaderRequirements) : IUnityStructure
{
    public static SerializedSubProgram Read(EndianBinaryReader reader)
    {
        uint _m_BlobIndex = reader.ReadU32();
        ParserBindChannels _m_Channels = ParserBindChannels.Read(reader);
        reader.AlignTo(4); /* m_Channels */
        ushort[] _m_KeywordIndices = BuiltInArray<ushort>.Read(reader);
        reader.AlignTo(4); /* m_KeywordIndices */
        sbyte _m_ShaderHardwareTier = reader.ReadS8();
        sbyte _m_GpuProgramType = reader.ReadS8();
        reader.AlignTo(4); /* m_GpuProgramType */
        SerializedProgramParameters _m_Parameters = SerializedProgramParameters.Read(reader);
        reader.AlignTo(4); /* m_Parameters */
        long _m_ShaderRequirements = reader.ReadS64();
        
        return new(_m_BlobIndex,
            _m_Channels,
            _m_KeywordIndices,
            _m_ShaderHardwareTier,
            _m_GpuProgramType,
            _m_Parameters,
            _m_ShaderRequirements);
    }

    public override string ToString() => $"SerializedSubProgram\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BlobIndex: ");
        sb.AppendLine(m_BlobIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Channels: ");
        sb.AppendLine();
        sb.Append(m_Channels.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_KeywordIndices: ");
        sb.AppendLine(m_KeywordIndices.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ShaderHardwareTier: ");
        sb.AppendLine(m_ShaderHardwareTier.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GpuProgramType: ");
        sb.AppendLine(m_GpuProgramType.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Parameters: ");
        sb.AppendLine();
        sb.Append(m_Parameters.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ShaderRequirements: ");
        sb.AppendLine(m_ShaderRequirements.ToString());

        return sb.ToString();
    }
}

/* $ParserBindChannels (2 fields) */
public record class ParserBindChannels(
    ShaderBindChannel[] m_Channels,
    int m_SourceMap) : IUnityStructure
{
    public static ParserBindChannels Read(EndianBinaryReader reader)
    {
        ShaderBindChannel[] _m_Channels = BuiltInArray<ShaderBindChannel>.Read(reader);
        reader.AlignTo(4); /* m_Channels */
        int _m_SourceMap = reader.ReadS32();
        
        return new(_m_Channels,
            _m_SourceMap);
    }

    public override string ToString() => $"ParserBindChannels\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Channels: ");
        sb.AppendLine(m_Channels.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SourceMap: ");
        sb.AppendLine(m_SourceMap.ToString());

        return sb.ToString();
    }
}

/* $ShaderBindChannel (2 fields) */
public readonly record struct ShaderBindChannel(
    sbyte source,
    sbyte target) : IUnityStructure
{
    public static ShaderBindChannel Read(EndianBinaryReader reader)
    {
        sbyte _source = reader.ReadS8();
        sbyte _target = reader.ReadS8();
        
        return new(_source,
            _target);
    }

    public override string ToString() => $"ShaderBindChannel\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("source: ");
        sb.AppendLine(source.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("target: ");
        sb.AppendLine(target.ToString());

        return sb.ToString();
    }
}

/* $SerializedProgramParameters (8 fields) */
public record class SerializedProgramParameters(
    VectorParameter[] m_VectorParams,
    MatrixParameter[] m_MatrixParams,
    TextureParameter[] m_TextureParams,
    BufferBinding[] m_BufferParams,
    ConstantBuffer[] m_ConstantBuffers,
    BufferBinding[] m_ConstantBufferBindings,
    UAVParameter[] m_UAVParams,
    SamplerParameter[] m_Samplers) : IUnityStructure
{
    public static SerializedProgramParameters Read(EndianBinaryReader reader)
    {
        VectorParameter[] _m_VectorParams = BuiltInArray<VectorParameter>.Read(reader);
        reader.AlignTo(4); /* m_VectorParams */
        MatrixParameter[] _m_MatrixParams = BuiltInArray<MatrixParameter>.Read(reader);
        reader.AlignTo(4); /* m_MatrixParams */
        TextureParameter[] _m_TextureParams = BuiltInArray<TextureParameter>.Read(reader);
        reader.AlignTo(4); /* m_TextureParams */
        BufferBinding[] _m_BufferParams = BuiltInArray<BufferBinding>.Read(reader);
        reader.AlignTo(4); /* m_BufferParams */
        ConstantBuffer[] _m_ConstantBuffers = BuiltInArray<ConstantBuffer>.Read(reader);
        reader.AlignTo(4); /* m_ConstantBuffers */
        BufferBinding[] _m_ConstantBufferBindings = BuiltInArray<BufferBinding>.Read(reader);
        reader.AlignTo(4); /* m_ConstantBufferBindings */
        UAVParameter[] _m_UAVParams = BuiltInArray<UAVParameter>.Read(reader);
        reader.AlignTo(4); /* m_UAVParams */
        SamplerParameter[] _m_Samplers = BuiltInArray<SamplerParameter>.Read(reader);
        reader.AlignTo(4); /* m_Samplers */
        
        return new(_m_VectorParams,
            _m_MatrixParams,
            _m_TextureParams,
            _m_BufferParams,
            _m_ConstantBuffers,
            _m_ConstantBufferBindings,
            _m_UAVParams,
            _m_Samplers);
    }

    public override string ToString() => $"SerializedProgramParameters\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_VectorParams: ");
        sb.AppendLine(m_VectorParams.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MatrixParams: ");
        sb.AppendLine(m_MatrixParams.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TextureParams: ");
        sb.AppendLine(m_TextureParams.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BufferParams: ");
        sb.AppendLine(m_BufferParams.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ConstantBuffers: ");
        sb.AppendLine(m_ConstantBuffers.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ConstantBufferBindings: ");
        sb.AppendLine(m_ConstantBufferBindings.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_UAVParams: ");
        sb.AppendLine(m_UAVParams.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Samplers: ");
        sb.AppendLine(m_Samplers.ToString());

        return sb.ToString();
    }
}

/* $VectorParameter (5 fields) */
public readonly record struct VectorParameter(
    int m_NameIndex,
    int m_Index,
    int m_ArraySize,
    sbyte m_Type,
    sbyte m_Dim) : IUnityStructure
{
    public static VectorParameter Read(EndianBinaryReader reader)
    {
        int _m_NameIndex = reader.ReadS32();
        int _m_Index = reader.ReadS32();
        int _m_ArraySize = reader.ReadS32();
        sbyte _m_Type = reader.ReadS8();
        sbyte _m_Dim = reader.ReadS8();
        reader.AlignTo(4); /* m_Dim */
        
        return new(_m_NameIndex,
            _m_Index,
            _m_ArraySize,
            _m_Type,
            _m_Dim);
    }

    public override string ToString() => $"VectorParameter\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NameIndex: ");
        sb.AppendLine(m_NameIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Index: ");
        sb.AppendLine(m_Index.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ArraySize: ");
        sb.AppendLine(m_ArraySize.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Type: ");
        sb.AppendLine(m_Type.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Dim: ");
        sb.AppendLine(m_Dim.ToString());

        return sb.ToString();
    }
}

/* $MatrixParameter (5 fields) */
public readonly record struct MatrixParameter(
    int m_NameIndex,
    int m_Index,
    int m_ArraySize,
    sbyte m_Type,
    sbyte m_RowCount) : IUnityStructure
{
    public static MatrixParameter Read(EndianBinaryReader reader)
    {
        int _m_NameIndex = reader.ReadS32();
        int _m_Index = reader.ReadS32();
        int _m_ArraySize = reader.ReadS32();
        sbyte _m_Type = reader.ReadS8();
        sbyte _m_RowCount = reader.ReadS8();
        reader.AlignTo(4); /* m_RowCount */
        
        return new(_m_NameIndex,
            _m_Index,
            _m_ArraySize,
            _m_Type,
            _m_RowCount);
    }

    public override string ToString() => $"MatrixParameter\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NameIndex: ");
        sb.AppendLine(m_NameIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Index: ");
        sb.AppendLine(m_Index.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ArraySize: ");
        sb.AppendLine(m_ArraySize.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Type: ");
        sb.AppendLine(m_Type.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RowCount: ");
        sb.AppendLine(m_RowCount.ToString());

        return sb.ToString();
    }
}

/* $TextureParameter (5 fields) */
public readonly record struct TextureParameter(
    int m_NameIndex,
    int m_Index,
    int m_SamplerIndex,
    bool m_MultiSampled,
    sbyte m_Dim) : IUnityStructure
{
    public static TextureParameter Read(EndianBinaryReader reader)
    {
        int _m_NameIndex = reader.ReadS32();
        int _m_Index = reader.ReadS32();
        int _m_SamplerIndex = reader.ReadS32();
        bool _m_MultiSampled = reader.ReadBool();
        sbyte _m_Dim = reader.ReadS8();
        reader.AlignTo(4); /* m_Dim */
        
        return new(_m_NameIndex,
            _m_Index,
            _m_SamplerIndex,
            _m_MultiSampled,
            _m_Dim);
    }

    public override string ToString() => $"TextureParameter\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NameIndex: ");
        sb.AppendLine(m_NameIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Index: ");
        sb.AppendLine(m_Index.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SamplerIndex: ");
        sb.AppendLine(m_SamplerIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MultiSampled: ");
        sb.AppendLine(m_MultiSampled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Dim: ");
        sb.AppendLine(m_Dim.ToString());

        return sb.ToString();
    }
}

/* $BufferBinding (3 fields) */
public readonly record struct BufferBinding(
    int m_NameIndex,
    int m_Index,
    int m_ArraySize) : IUnityStructure
{
    public static BufferBinding Read(EndianBinaryReader reader)
    {
        int _m_NameIndex = reader.ReadS32();
        int _m_Index = reader.ReadS32();
        int _m_ArraySize = reader.ReadS32();
        
        return new(_m_NameIndex,
            _m_Index,
            _m_ArraySize);
    }

    public override string ToString() => $"BufferBinding\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NameIndex: ");
        sb.AppendLine(m_NameIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Index: ");
        sb.AppendLine(m_Index.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ArraySize: ");
        sb.AppendLine(m_ArraySize.ToString());

        return sb.ToString();
    }
}

/* $ConstantBuffer (6 fields) */
public record class ConstantBuffer(
    int m_NameIndex,
    MatrixParameter[] m_MatrixParams,
    VectorParameter[] m_VectorParams,
    StructParameter[] m_StructParams,
    int m_Size,
    bool m_IsPartialCB) : IUnityStructure
{
    public static ConstantBuffer Read(EndianBinaryReader reader)
    {
        int _m_NameIndex = reader.ReadS32();
        MatrixParameter[] _m_MatrixParams = BuiltInArray<MatrixParameter>.Read(reader);
        reader.AlignTo(4); /* m_MatrixParams */
        VectorParameter[] _m_VectorParams = BuiltInArray<VectorParameter>.Read(reader);
        reader.AlignTo(4); /* m_VectorParams */
        StructParameter[] _m_StructParams = BuiltInArray<StructParameter>.Read(reader);
        reader.AlignTo(4); /* m_StructParams */
        int _m_Size = reader.ReadS32();
        bool _m_IsPartialCB = reader.ReadBool();
        reader.AlignTo(4); /* m_IsPartialCB */
        
        return new(_m_NameIndex,
            _m_MatrixParams,
            _m_VectorParams,
            _m_StructParams,
            _m_Size,
            _m_IsPartialCB);
    }

    public override string ToString() => $"ConstantBuffer\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NameIndex: ");
        sb.AppendLine(m_NameIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MatrixParams: ");
        sb.AppendLine(m_MatrixParams.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_VectorParams: ");
        sb.AppendLine(m_VectorParams.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StructParams: ");
        sb.AppendLine(m_StructParams.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Size: ");
        sb.AppendLine(m_Size.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IsPartialCB: ");
        sb.AppendLine(m_IsPartialCB.ToString());

        return sb.ToString();
    }
}

/* $StructParameter (6 fields) */
public record class StructParameter(
    int m_NameIndex,
    int m_Index,
    int m_ArraySize,
    int m_StructSize,
    VectorParameter[] m_VectorMembers,
    MatrixParameter[] m_MatrixMembers) : IUnityStructure
{
    public static StructParameter Read(EndianBinaryReader reader)
    {
        int _m_NameIndex = reader.ReadS32();
        int _m_Index = reader.ReadS32();
        int _m_ArraySize = reader.ReadS32();
        int _m_StructSize = reader.ReadS32();
        VectorParameter[] _m_VectorMembers = BuiltInArray<VectorParameter>.Read(reader);
        reader.AlignTo(4); /* m_VectorMembers */
        MatrixParameter[] _m_MatrixMembers = BuiltInArray<MatrixParameter>.Read(reader);
        reader.AlignTo(4); /* m_MatrixMembers */
        
        return new(_m_NameIndex,
            _m_Index,
            _m_ArraySize,
            _m_StructSize,
            _m_VectorMembers,
            _m_MatrixMembers);
    }

    public override string ToString() => $"StructParameter\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NameIndex: ");
        sb.AppendLine(m_NameIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Index: ");
        sb.AppendLine(m_Index.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ArraySize: ");
        sb.AppendLine(m_ArraySize.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StructSize: ");
        sb.AppendLine(m_StructSize.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_VectorMembers: ");
        sb.AppendLine(m_VectorMembers.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MatrixMembers: ");
        sb.AppendLine(m_MatrixMembers.ToString());

        return sb.ToString();
    }
}

/* $UAVParameter (3 fields) */
public readonly record struct UAVParameter(
    int m_NameIndex,
    int m_Index,
    int m_OriginalIndex) : IUnityStructure
{
    public static UAVParameter Read(EndianBinaryReader reader)
    {
        int _m_NameIndex = reader.ReadS32();
        int _m_Index = reader.ReadS32();
        int _m_OriginalIndex = reader.ReadS32();
        
        return new(_m_NameIndex,
            _m_Index,
            _m_OriginalIndex);
    }

    public override string ToString() => $"UAVParameter\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NameIndex: ");
        sb.AppendLine(m_NameIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Index: ");
        sb.AppendLine(m_Index.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_OriginalIndex: ");
        sb.AppendLine(m_OriginalIndex.ToString());

        return sb.ToString();
    }
}

/* $SamplerParameter (2 fields) */
public readonly record struct SamplerParameter(
    uint sampler,
    int bindPoint) : IUnityStructure
{
    public static SamplerParameter Read(EndianBinaryReader reader)
    {
        uint _sampler = reader.ReadU32();
        int _bindPoint = reader.ReadS32();
        
        return new(_sampler,
            _bindPoint);
    }

    public override string ToString() => $"SamplerParameter\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sampler: ");
        sb.AppendLine(sampler.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("bindPoint: ");
        sb.AppendLine(bindPoint.ToString());

        return sb.ToString();
    }
}

/* $SerializedPlayerSubProgram (4 fields) */
public record class SerializedPlayerSubProgram(
    uint m_BlobIndex,
    ushort[] m_KeywordIndices,
    long m_ShaderRequirements,
    sbyte m_GpuProgramType) : IUnityStructure
{
    public static SerializedPlayerSubProgram Read(EndianBinaryReader reader)
    {
        uint _m_BlobIndex = reader.ReadU32();
        ushort[] _m_KeywordIndices = BuiltInArray<ushort>.Read(reader);
        reader.AlignTo(4); /* m_KeywordIndices */
        long _m_ShaderRequirements = reader.ReadS64();
        sbyte _m_GpuProgramType = reader.ReadS8();
        reader.AlignTo(4); /* m_GpuProgramType */
        
        return new(_m_BlobIndex,
            _m_KeywordIndices,
            _m_ShaderRequirements,
            _m_GpuProgramType);
    }

    public override string ToString() => $"SerializedPlayerSubProgram\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BlobIndex: ");
        sb.AppendLine(m_BlobIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_KeywordIndices: ");
        sb.AppendLine(m_KeywordIndices.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ShaderRequirements: ");
        sb.AppendLine(m_ShaderRequirements.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GpuProgramType: ");
        sb.AppendLine(m_GpuProgramType.ToString());

        return sb.ToString();
    }
}

/* $SerializedShaderDependency (2 fields) */
public record class SerializedShaderDependency(
    AsciiString @from,
    AsciiString to) : IUnityStructure
{
    public static SerializedShaderDependency Read(EndianBinaryReader reader)
    {
        AsciiString _from = BuiltInString.Read(reader);
        reader.AlignTo(4); /* @from */
        AsciiString _to = BuiltInString.Read(reader);
        reader.AlignTo(4); /* to */
        
        return new(_from,
            _to);
    }

    public override string ToString() => $"SerializedShaderDependency\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("@from: ");
        sb.AppendLine(@from.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("to: ");
        sb.AppendLine(to.ToString());

        return sb.ToString();
    }
}

/* $SerializedCustomEditorForRenderPipeline (2 fields) */
public record class SerializedCustomEditorForRenderPipeline(
    AsciiString customEditorName,
    AsciiString renderPipelineType) : IUnityStructure
{
    public static SerializedCustomEditorForRenderPipeline Read(EndianBinaryReader reader)
    {
        AsciiString _customEditorName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* customEditorName */
        AsciiString _renderPipelineType = BuiltInString.Read(reader);
        reader.AlignTo(4); /* renderPipelineType */
        
        return new(_customEditorName,
            _renderPipelineType);
    }

    public override string ToString() => $"SerializedCustomEditorForRenderPipeline\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("customEditorName: ");
        sb.AppendLine(customEditorName.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("renderPipelineType: ");
        sb.AppendLine(renderPipelineType.ToString());

        return sb.ToString();
    }
}

/* $LightProbeData (4 fields) */
public record class LightProbeData(
    ProbeSetTetrahedralization m_Tetrahedralization,
    ProbeSetIndex[] m_ProbeSets,
    Vector3f[] m_Positions,
    Dictionary<Hash128, int> m_NonTetrahedralizedProbeSetIndexMap) : IUnityStructure
{
    public static LightProbeData Read(EndianBinaryReader reader)
    {
        ProbeSetTetrahedralization _m_Tetrahedralization = ProbeSetTetrahedralization.Read(reader);
        reader.AlignTo(4); /* m_Tetrahedralization */
        ProbeSetIndex[] _m_ProbeSets = BuiltInArray<ProbeSetIndex>.Read(reader);
        reader.AlignTo(4); /* m_ProbeSets */
        Vector3f[] _m_Positions = BuiltInArray<Vector3f>.Read(reader);
        reader.AlignTo(4); /* m_Positions */
        Dictionary<Hash128, int> _m_NonTetrahedralizedProbeSetIndexMap = BuiltInMap<Hash128, int>.Read(reader);
        
        return new(_m_Tetrahedralization,
            _m_ProbeSets,
            _m_Positions,
            _m_NonTetrahedralizedProbeSetIndexMap);
    }

    public override string ToString() => $"LightProbeData\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Tetrahedralization: ");
        sb.AppendLine();
        sb.Append(m_Tetrahedralization.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ProbeSets: ");
        sb.AppendLine(m_ProbeSets.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Positions: ");
        sb.AppendLine(m_Positions.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NonTetrahedralizedProbeSetIndexMap: ");
        sb.AppendLine(m_NonTetrahedralizedProbeSetIndexMap.ToString());

        return sb.ToString();
    }
}

/* $ProbeSetTetrahedralization (2 fields) */
public record class ProbeSetTetrahedralization(
    Tetrahedron[] m_Tetrahedra,
    Vector3f[] m_HullRays) : IUnityStructure
{
    public static ProbeSetTetrahedralization Read(EndianBinaryReader reader)
    {
        Tetrahedron[] _m_Tetrahedra = BuiltInArray<Tetrahedron>.Read(reader);
        reader.AlignTo(4); /* m_Tetrahedra */
        Vector3f[] _m_HullRays = BuiltInArray<Vector3f>.Read(reader);
        reader.AlignTo(4); /* m_HullRays */
        
        return new(_m_Tetrahedra,
            _m_HullRays);
    }

    public override string ToString() => $"ProbeSetTetrahedralization\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Tetrahedra: ");
        sb.AppendLine(m_Tetrahedra.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HullRays: ");
        sb.AppendLine(m_HullRays.ToString());

        return sb.ToString();
    }
}

/* $Tetrahedron (9 fields) */
public record class Tetrahedron(
    int indices_0,
    int indices_1,
    int indices_2,
    int indices_3,
    int neighbors_0,
    int neighbors_1,
    int neighbors_2,
    int neighbors_3,
    Matrix3x4f matrix) : IUnityStructure
{
    public static Tetrahedron Read(EndianBinaryReader reader)
    {
        int _indices_0 = reader.ReadS32();
        int _indices_1 = reader.ReadS32();
        int _indices_2 = reader.ReadS32();
        int _indices_3 = reader.ReadS32();
        int _neighbors_0 = reader.ReadS32();
        int _neighbors_1 = reader.ReadS32();
        int _neighbors_2 = reader.ReadS32();
        int _neighbors_3 = reader.ReadS32();
        Matrix3x4f _matrix = Matrix3x4f.Read(reader);
        
        return new(_indices_0,
            _indices_1,
            _indices_2,
            _indices_3,
            _neighbors_0,
            _neighbors_1,
            _neighbors_2,
            _neighbors_3,
            _matrix);
    }

    public override string ToString() => $"Tetrahedron\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("indices_0: ");
        sb.AppendLine(indices_0.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("indices_1: ");
        sb.AppendLine(indices_1.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("indices_2: ");
        sb.AppendLine(indices_2.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("indices_3: ");
        sb.AppendLine(indices_3.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("neighbors_0: ");
        sb.AppendLine(neighbors_0.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("neighbors_1: ");
        sb.AppendLine(neighbors_1.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("neighbors_2: ");
        sb.AppendLine(neighbors_2.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("neighbors_3: ");
        sb.AppendLine(neighbors_3.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("matrix: ");
        sb.AppendLine();
        sb.Append(matrix.ToString(indent+4));

        return sb.ToString();
    }
}

/* $Matrix3x4f (12 fields) */
public readonly record struct Matrix3x4f(
    float e00,
    float e01,
    float e02,
    float e03,
    float e10,
    float e11,
    float e12,
    float e13,
    float e20,
    float e21,
    float e22,
    float e23) : IUnityStructure
{
    public static Matrix3x4f Read(EndianBinaryReader reader)
    {
        float _e00 = reader.ReadF32();
        float _e01 = reader.ReadF32();
        float _e02 = reader.ReadF32();
        float _e03 = reader.ReadF32();
        float _e10 = reader.ReadF32();
        float _e11 = reader.ReadF32();
        float _e12 = reader.ReadF32();
        float _e13 = reader.ReadF32();
        float _e20 = reader.ReadF32();
        float _e21 = reader.ReadF32();
        float _e22 = reader.ReadF32();
        float _e23 = reader.ReadF32();
        
        return new(_e00,
            _e01,
            _e02,
            _e03,
            _e10,
            _e11,
            _e12,
            _e13,
            _e20,
            _e21,
            _e22,
            _e23);
    }

    public override string ToString() => $"Matrix3x4f\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("e00: ");
        sb.AppendLine(e00.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("e01: ");
        sb.AppendLine(e01.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("e02: ");
        sb.AppendLine(e02.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("e03: ");
        sb.AppendLine(e03.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("e10: ");
        sb.AppendLine(e10.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("e11: ");
        sb.AppendLine(e11.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("e12: ");
        sb.AppendLine(e12.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("e13: ");
        sb.AppendLine(e13.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("e20: ");
        sb.AppendLine(e20.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("e21: ");
        sb.AppendLine(e21.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("e22: ");
        sb.AppendLine(e22.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("e23: ");
        sb.AppendLine(e23.ToString());

        return sb.ToString();
    }
}

/* $ProbeSetIndex (3 fields) */
public record class ProbeSetIndex(
    Hash128 m_Hash,
    int m_Offset,
    int m_Size) : IUnityStructure
{
    public static ProbeSetIndex Read(EndianBinaryReader reader)
    {
        Hash128 _m_Hash = Hash128.Read(reader);
        int _m_Offset = reader.ReadS32();
        int _m_Size = reader.ReadS32();
        
        return new(_m_Hash,
            _m_Offset,
            _m_Size);
    }

    public override string ToString() => $"ProbeSetIndex\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Hash: ");
        sb.AppendLine(m_Hash.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Offset: ");
        sb.AppendLine(m_Offset.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Size: ");
        sb.AppendLine(m_Size.ToString());

        return sb.ToString();
    }
}

/* $SphericalHarmonicsL2 (27 fields) */
public readonly record struct SphericalHarmonicsL2(
    float sh_0,
    float sh_1,
    float sh_2,
    float sh_3,
    float sh_4,
    float sh_5,
    float sh_6,
    float sh_7,
    float sh_8,
    float sh_9,
    float sh_10,
    float sh_11,
    float sh_12,
    float sh_13,
    float sh_14,
    float sh_15,
    float sh_16,
    float sh_17,
    float sh_18,
    float sh_19,
    float sh_20,
    float sh_21,
    float sh_22,
    float sh_23,
    float sh_24,
    float sh_25,
    float sh_26) : IUnityStructure
{
    public static SphericalHarmonicsL2 Read(EndianBinaryReader reader)
    {
        float _sh_0 = reader.ReadF32();
        float _sh_1 = reader.ReadF32();
        float _sh_2 = reader.ReadF32();
        float _sh_3 = reader.ReadF32();
        float _sh_4 = reader.ReadF32();
        float _sh_5 = reader.ReadF32();
        float _sh_6 = reader.ReadF32();
        float _sh_7 = reader.ReadF32();
        float _sh_8 = reader.ReadF32();
        float _sh_9 = reader.ReadF32();
        float _sh_10 = reader.ReadF32();
        float _sh_11 = reader.ReadF32();
        float _sh_12 = reader.ReadF32();
        float _sh_13 = reader.ReadF32();
        float _sh_14 = reader.ReadF32();
        float _sh_15 = reader.ReadF32();
        float _sh_16 = reader.ReadF32();
        float _sh_17 = reader.ReadF32();
        float _sh_18 = reader.ReadF32();
        float _sh_19 = reader.ReadF32();
        float _sh_20 = reader.ReadF32();
        float _sh_21 = reader.ReadF32();
        float _sh_22 = reader.ReadF32();
        float _sh_23 = reader.ReadF32();
        float _sh_24 = reader.ReadF32();
        float _sh_25 = reader.ReadF32();
        float _sh_26 = reader.ReadF32();
        
        return new(_sh_0,
            _sh_1,
            _sh_2,
            _sh_3,
            _sh_4,
            _sh_5,
            _sh_6,
            _sh_7,
            _sh_8,
            _sh_9,
            _sh_10,
            _sh_11,
            _sh_12,
            _sh_13,
            _sh_14,
            _sh_15,
            _sh_16,
            _sh_17,
            _sh_18,
            _sh_19,
            _sh_20,
            _sh_21,
            _sh_22,
            _sh_23,
            _sh_24,
            _sh_25,
            _sh_26);
    }

    public override string ToString() => $"SphericalHarmonicsL2\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sh_0: ");
        sb.AppendLine(sh_0.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sh_1: ");
        sb.AppendLine(sh_1.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sh_2: ");
        sb.AppendLine(sh_2.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sh_3: ");
        sb.AppendLine(sh_3.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sh_4: ");
        sb.AppendLine(sh_4.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sh_5: ");
        sb.AppendLine(sh_5.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sh_6: ");
        sb.AppendLine(sh_6.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sh_7: ");
        sb.AppendLine(sh_7.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sh_8: ");
        sb.AppendLine(sh_8.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sh_9: ");
        sb.AppendLine(sh_9.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sh_10: ");
        sb.AppendLine(sh_10.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sh_11: ");
        sb.AppendLine(sh_11.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sh_12: ");
        sb.AppendLine(sh_12.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sh_13: ");
        sb.AppendLine(sh_13.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sh_14: ");
        sb.AppendLine(sh_14.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sh_15: ");
        sb.AppendLine(sh_15.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sh_16: ");
        sb.AppendLine(sh_16.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sh_17: ");
        sb.AppendLine(sh_17.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sh_18: ");
        sb.AppendLine(sh_18.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sh_19: ");
        sb.AppendLine(sh_19.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sh_20: ");
        sb.AppendLine(sh_20.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sh_21: ");
        sb.AppendLine(sh_21.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sh_22: ");
        sb.AppendLine(sh_22.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sh_23: ");
        sb.AppendLine(sh_23.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sh_24: ");
        sb.AppendLine(sh_24.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sh_25: ");
        sb.AppendLine(sh_25.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sh_26: ");
        sb.AppendLine(sh_26.ToString());

        return sb.ToString();
    }
}

/* $LightProbeOcclusion (3 fields) */
public record class LightProbeOcclusion(
    int[] m_ProbeOcclusionLightIndex,
    float[] m_Occlusion,
    sbyte[] m_OcclusionMaskChannel) : IUnityStructure
{
    public static LightProbeOcclusion Read(EndianBinaryReader reader)
    {
        int[] _m_ProbeOcclusionLightIndex = BuiltInArray<int>.Read(reader);
        float[] _m_Occlusion = BuiltInArray<float>.Read(reader);
        sbyte[] _m_OcclusionMaskChannel = BuiltInArray<sbyte>.Read(reader);
        
        return new(_m_ProbeOcclusionLightIndex,
            _m_Occlusion,
            _m_OcclusionMaskChannel);
    }

    public override string ToString() => $"LightProbeOcclusion\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ProbeOcclusionLightIndex: ");
        sb.AppendLine(m_ProbeOcclusionLightIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Occlusion: ");
        sb.AppendLine(m_Occlusion.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_OcclusionMaskChannel: ");
        sb.AppendLine(m_OcclusionMaskChannel.ToString());

        return sb.ToString();
    }
}

/* $GLTextureSettings (6 fields) */
public readonly record struct GLTextureSettings(
    int m_FilterMode,
    int m_Aniso,
    float m_MipBias,
    int m_WrapU,
    int m_WrapV,
    int m_WrapW) : IUnityStructure
{
    public static GLTextureSettings Read(EndianBinaryReader reader)
    {
        int _m_FilterMode = reader.ReadS32();
        int _m_Aniso = reader.ReadS32();
        float _m_MipBias = reader.ReadF32();
        int _m_WrapU = reader.ReadS32();
        int _m_WrapV = reader.ReadS32();
        int _m_WrapW = reader.ReadS32();
        
        return new(_m_FilterMode,
            _m_Aniso,
            _m_MipBias,
            _m_WrapU,
            _m_WrapV,
            _m_WrapW);
    }

    public override string ToString() => $"GLTextureSettings\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FilterMode: ");
        sb.AppendLine(m_FilterMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Aniso: ");
        sb.AppendLine(m_Aniso.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MipBias: ");
        sb.AppendLine(m_MipBias.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_WrapU: ");
        sb.AppendLine(m_WrapU.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_WrapV: ");
        sb.AppendLine(m_WrapV.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_WrapW: ");
        sb.AppendLine(m_WrapW.ToString());

        return sb.ToString();
    }
}

/* $AvatarConstant (12 fields) */
public record class AvatarConstant(
    OffsetPtr_0 m_AvatarSkeleton,
    OffsetPtr_1 m_AvatarSkeletonPose,
    OffsetPtr_1 m_DefaultPose,
    uint[] m_SkeletonNameIDArray,
    OffsetPtr_2 m_Human,
    int[] m_HumanSkeletonIndexArray,
    int[] m_HumanSkeletonReverseIndexArray,
    int m_RootMotionBoneIndex,
    xform m_RootMotionBoneX,
    OffsetPtr_0 m_RootMotionSkeleton,
    OffsetPtr_1 m_RootMotionSkeletonPose,
    int[] m_RootMotionSkeletonIndexArray) : IUnityStructure
{
    public static AvatarConstant Read(EndianBinaryReader reader)
    {
        OffsetPtr_0 _m_AvatarSkeleton = OffsetPtr_0.Read(reader);
        OffsetPtr_1 _m_AvatarSkeletonPose = OffsetPtr_1.Read(reader);
        OffsetPtr_1 _m_DefaultPose = OffsetPtr_1.Read(reader);
        uint[] _m_SkeletonNameIDArray = BuiltInArray<uint>.Read(reader);
        OffsetPtr_2 _m_Human = OffsetPtr_2.Read(reader);
        reader.AlignTo(4); /* m_Human */
        int[] _m_HumanSkeletonIndexArray = BuiltInArray<int>.Read(reader);
        int[] _m_HumanSkeletonReverseIndexArray = BuiltInArray<int>.Read(reader);
        int _m_RootMotionBoneIndex = reader.ReadS32();
        xform _m_RootMotionBoneX = xform.Read(reader);
        OffsetPtr_0 _m_RootMotionSkeleton = OffsetPtr_0.Read(reader);
        OffsetPtr_1 _m_RootMotionSkeletonPose = OffsetPtr_1.Read(reader);
        int[] _m_RootMotionSkeletonIndexArray = BuiltInArray<int>.Read(reader);
        reader.AlignTo(4); /* m_RootMotionSkeletonIndexArray */
        
        return new(_m_AvatarSkeleton,
            _m_AvatarSkeletonPose,
            _m_DefaultPose,
            _m_SkeletonNameIDArray,
            _m_Human,
            _m_HumanSkeletonIndexArray,
            _m_HumanSkeletonReverseIndexArray,
            _m_RootMotionBoneIndex,
            _m_RootMotionBoneX,
            _m_RootMotionSkeleton,
            _m_RootMotionSkeletonPose,
            _m_RootMotionSkeletonIndexArray);
    }

    public override string ToString() => $"AvatarConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AvatarSkeleton: ");
        sb.AppendLine();
        sb.Append(m_AvatarSkeleton.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AvatarSkeletonPose: ");
        sb.AppendLine();
        sb.Append(m_AvatarSkeletonPose.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DefaultPose: ");
        sb.AppendLine();
        sb.Append(m_DefaultPose.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SkeletonNameIDArray: ");
        sb.AppendLine(m_SkeletonNameIDArray.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Human: ");
        sb.AppendLine();
        sb.Append(m_Human.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HumanSkeletonIndexArray: ");
        sb.AppendLine(m_HumanSkeletonIndexArray.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HumanSkeletonReverseIndexArray: ");
        sb.AppendLine(m_HumanSkeletonReverseIndexArray.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RootMotionBoneIndex: ");
        sb.AppendLine(m_RootMotionBoneIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RootMotionBoneX: ");
        sb.AppendLine();
        sb.Append(m_RootMotionBoneX.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RootMotionSkeleton: ");
        sb.AppendLine();
        sb.Append(m_RootMotionSkeleton.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RootMotionSkeletonPose: ");
        sb.AppendLine();
        sb.Append(m_RootMotionSkeletonPose.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RootMotionSkeletonIndexArray: ");
        sb.AppendLine(m_RootMotionSkeletonIndexArray.ToString());

        return sb.ToString();
    }
}

/* $OffsetPtr_0 (1 fields) */
public record class OffsetPtr_0(
    Skeleton data) : IUnityStructure
{
    public static OffsetPtr_0 Read(EndianBinaryReader reader)
    {
        Skeleton _data = Skeleton.Read(reader);
        
        return new(_data);
    }

    public override string ToString() => $"OffsetPtr_0\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data: ");
        sb.AppendLine();
        sb.Append(data.ToString(indent+4));

        return sb.ToString();
    }
}

/* $Skeleton (3 fields) */
public record class Skeleton(
    Node[] m_Node,
    uint[] m_ID,
    Axes[] m_AxesArray) : IUnityStructure
{
    public static Skeleton Read(EndianBinaryReader reader)
    {
        Node[] _m_Node = BuiltInArray<Node>.Read(reader);
        uint[] _m_ID = BuiltInArray<uint>.Read(reader);
        Axes[] _m_AxesArray = BuiltInArray<Axes>.Read(reader);
        
        return new(_m_Node,
            _m_ID,
            _m_AxesArray);
    }

    public override string ToString() => $"Skeleton\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Node: ");
        sb.AppendLine(m_Node.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ID: ");
        sb.AppendLine(m_ID.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AxesArray: ");
        sb.AppendLine(m_AxesArray.ToString());

        return sb.ToString();
    }
}

/* $Node (2 fields) */
public readonly record struct Node(
    int m_ParentId,
    int m_AxesId) : IUnityStructure
{
    public static Node Read(EndianBinaryReader reader)
    {
        int _m_ParentId = reader.ReadS32();
        int _m_AxesId = reader.ReadS32();
        
        return new(_m_ParentId,
            _m_AxesId);
    }

    public override string ToString() => $"Node\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ParentId: ");
        sb.AppendLine(m_ParentId.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AxesId: ");
        sb.AppendLine(m_AxesId.ToString());

        return sb.ToString();
    }
}

/* $Axes (6 fields) */
public record class Axes(
    float4 m_PreQ,
    float4 m_PostQ,
    float3 m_Sgn,
    Limit m_Limit,
    float m_Length,
    uint m_Type) : IUnityStructure
{
    public static Axes Read(EndianBinaryReader reader)
    {
        float4 _m_PreQ = float4.Read(reader);
        float4 _m_PostQ = float4.Read(reader);
        float3 _m_Sgn = float3.Read(reader);
        Limit _m_Limit = Limit.Read(reader);
        float _m_Length = reader.ReadF32();
        uint _m_Type = reader.ReadU32();
        
        return new(_m_PreQ,
            _m_PostQ,
            _m_Sgn,
            _m_Limit,
            _m_Length,
            _m_Type);
    }

    public override string ToString() => $"Axes\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PreQ: ");
        sb.AppendLine();
        sb.Append(m_PreQ.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PostQ: ");
        sb.AppendLine();
        sb.Append(m_PostQ.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Sgn: ");
        sb.AppendLine();
        sb.Append(m_Sgn.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Limit: ");
        sb.AppendLine();
        sb.Append(m_Limit.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Length: ");
        sb.AppendLine(m_Length.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Type: ");
        sb.AppendLine(m_Type.ToString());

        return sb.ToString();
    }
}

/* $float4 (4 fields) */
public readonly record struct float4(
    float x,
    float y,
    float z,
    float w) : IUnityStructure
{
    public static float4 Read(EndianBinaryReader reader)
    {
        float _x = reader.ReadF32();
        float _y = reader.ReadF32();
        float _z = reader.ReadF32();
        float _w = reader.ReadF32();
        
        return new(_x,
            _y,
            _z,
            _w);
    }

    public override string ToString() => $"float4\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("x: ");
        sb.AppendLine(x.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("y: ");
        sb.AppendLine(y.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("z: ");
        sb.AppendLine(z.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("w: ");
        sb.AppendLine(w.ToString());

        return sb.ToString();
    }
}

/* $float3 (3 fields) */
public readonly record struct float3(
    float x,
    float y,
    float z) : IUnityStructure
{
    public static float3 Read(EndianBinaryReader reader)
    {
        float _x = reader.ReadF32();
        float _y = reader.ReadF32();
        float _z = reader.ReadF32();
        
        return new(_x,
            _y,
            _z);
    }

    public override string ToString() => $"float3\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("x: ");
        sb.AppendLine(x.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("y: ");
        sb.AppendLine(y.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("z: ");
        sb.AppendLine(z.ToString());

        return sb.ToString();
    }
}

/* $Limit (2 fields) */
public record class Limit(
    float3 m_Min,
    float3 m_Max) : IUnityStructure
{
    public static Limit Read(EndianBinaryReader reader)
    {
        float3 _m_Min = float3.Read(reader);
        float3 _m_Max = float3.Read(reader);
        
        return new(_m_Min,
            _m_Max);
    }

    public override string ToString() => $"Limit\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Min: ");
        sb.AppendLine();
        sb.Append(m_Min.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Max: ");
        sb.AppendLine();
        sb.Append(m_Max.ToString(indent+4));

        return sb.ToString();
    }
}

/* $OffsetPtr_1 (1 fields) */
public record class OffsetPtr_1(
    SkeletonPose data) : IUnityStructure
{
    public static OffsetPtr_1 Read(EndianBinaryReader reader)
    {
        SkeletonPose _data = SkeletonPose.Read(reader);
        
        return new(_data);
    }

    public override string ToString() => $"OffsetPtr_1\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data: ");
        sb.AppendLine();
        sb.Append(data.ToString(indent+4));

        return sb.ToString();
    }
}

/* $SkeletonPose (1 fields) */
public record class SkeletonPose(
    xform[] m_X) : IUnityStructure
{
    public static SkeletonPose Read(EndianBinaryReader reader)
    {
        xform[] _m_X = BuiltInArray<xform>.Read(reader);
        
        return new(_m_X);
    }

    public override string ToString() => $"SkeletonPose\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_X: ");
        sb.AppendLine(m_X.ToString());

        return sb.ToString();
    }
}

/* $xform (3 fields) */
public record class xform(
    float3 t,
    float4 q,
    float3 s) : IUnityStructure
{
    public static xform Read(EndianBinaryReader reader)
    {
        float3 _t = float3.Read(reader);
        float4 _q = float4.Read(reader);
        float3 _s = float3.Read(reader);
        
        return new(_t,
            _q,
            _s);
    }

    public override string ToString() => $"xform\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("t: ");
        sb.AppendLine();
        sb.Append(t.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("q: ");
        sb.AppendLine();
        sb.Append(q.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("s: ");
        sb.AppendLine();
        sb.Append(s.ToString(indent+4));

        return sb.ToString();
    }
}

/* $OffsetPtr_2 (1 fields) */
public record class OffsetPtr_2(
    Human data) : IUnityStructure
{
    public static OffsetPtr_2 Read(EndianBinaryReader reader)
    {
        Human _data = Human.Read(reader);
        reader.AlignTo(4); /* data */
        
        return new(_data);
    }

    public override string ToString() => $"OffsetPtr_2\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data: ");
        sb.AppendLine();
        sb.Append(data.ToString(indent+4));

        return sb.ToString();
    }
}

/* $Human (18 fields) */
public record class Human(
    xform m_RootX,
    OffsetPtr_0 m_Skeleton,
    OffsetPtr_1 m_SkeletonPose,
    OffsetPtr_3 m_LeftHand,
    OffsetPtr_3 m_RightHand,
    int[] m_HumanBoneIndex,
    float[] m_HumanBoneMass,
    float m_Scale,
    float m_ArmTwist,
    float m_ForeArmTwist,
    float m_UpperLegTwist,
    float m_LegTwist,
    float m_ArmStretch,
    float m_LegStretch,
    float m_FeetSpacing,
    bool m_HasLeftHand,
    bool m_HasRightHand,
    bool m_HasTDoF) : IUnityStructure
{
    public static Human Read(EndianBinaryReader reader)
    {
        xform _m_RootX = xform.Read(reader);
        OffsetPtr_0 _m_Skeleton = OffsetPtr_0.Read(reader);
        OffsetPtr_1 _m_SkeletonPose = OffsetPtr_1.Read(reader);
        OffsetPtr_3 _m_LeftHand = OffsetPtr_3.Read(reader);
        OffsetPtr_3 _m_RightHand = OffsetPtr_3.Read(reader);
        int[] _m_HumanBoneIndex = BuiltInArray<int>.Read(reader);
        float[] _m_HumanBoneMass = BuiltInArray<float>.Read(reader);
        float _m_Scale = reader.ReadF32();
        float _m_ArmTwist = reader.ReadF32();
        float _m_ForeArmTwist = reader.ReadF32();
        float _m_UpperLegTwist = reader.ReadF32();
        float _m_LegTwist = reader.ReadF32();
        float _m_ArmStretch = reader.ReadF32();
        float _m_LegStretch = reader.ReadF32();
        float _m_FeetSpacing = reader.ReadF32();
        bool _m_HasLeftHand = reader.ReadBool();
        bool _m_HasRightHand = reader.ReadBool();
        bool _m_HasTDoF = reader.ReadBool();
        reader.AlignTo(4); /* m_HasTDoF */
        
        return new(_m_RootX,
            _m_Skeleton,
            _m_SkeletonPose,
            _m_LeftHand,
            _m_RightHand,
            _m_HumanBoneIndex,
            _m_HumanBoneMass,
            _m_Scale,
            _m_ArmTwist,
            _m_ForeArmTwist,
            _m_UpperLegTwist,
            _m_LegTwist,
            _m_ArmStretch,
            _m_LegStretch,
            _m_FeetSpacing,
            _m_HasLeftHand,
            _m_HasRightHand,
            _m_HasTDoF);
    }

    public override string ToString() => $"Human\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RootX: ");
        sb.AppendLine();
        sb.Append(m_RootX.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Skeleton: ");
        sb.AppendLine();
        sb.Append(m_Skeleton.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SkeletonPose: ");
        sb.AppendLine();
        sb.Append(m_SkeletonPose.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LeftHand: ");
        sb.AppendLine();
        sb.Append(m_LeftHand.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RightHand: ");
        sb.AppendLine();
        sb.Append(m_RightHand.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HumanBoneIndex: ");
        sb.AppendLine(m_HumanBoneIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HumanBoneMass: ");
        sb.AppendLine(m_HumanBoneMass.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Scale: ");
        sb.AppendLine(m_Scale.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ArmTwist: ");
        sb.AppendLine(m_ArmTwist.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ForeArmTwist: ");
        sb.AppendLine(m_ForeArmTwist.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_UpperLegTwist: ");
        sb.AppendLine(m_UpperLegTwist.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LegTwist: ");
        sb.AppendLine(m_LegTwist.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ArmStretch: ");
        sb.AppendLine(m_ArmStretch.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LegStretch: ");
        sb.AppendLine(m_LegStretch.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FeetSpacing: ");
        sb.AppendLine(m_FeetSpacing.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HasLeftHand: ");
        sb.AppendLine(m_HasLeftHand.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HasRightHand: ");
        sb.AppendLine(m_HasRightHand.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HasTDoF: ");
        sb.AppendLine(m_HasTDoF.ToString());

        return sb.ToString();
    }
}

/* $OffsetPtr_3 (1 fields) */
public record class OffsetPtr_3(
    Hand data) : IUnityStructure
{
    public static OffsetPtr_3 Read(EndianBinaryReader reader)
    {
        Hand _data = Hand.Read(reader);
        
        return new(_data);
    }

    public override string ToString() => $"OffsetPtr_3\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data: ");
        sb.AppendLine();
        sb.Append(data.ToString(indent+4));

        return sb.ToString();
    }
}

/* $Hand (1 fields) */
public record class Hand(
    int[] m_HandBoneIndex) : IUnityStructure
{
    public static Hand Read(EndianBinaryReader reader)
    {
        int[] _m_HandBoneIndex = BuiltInArray<int>.Read(reader);
        
        return new(_m_HandBoneIndex);
    }

    public override string ToString() => $"Hand\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HandBoneIndex: ");
        sb.AppendLine(m_HandBoneIndex.ToString());

        return sb.ToString();
    }
}

/* $HumanDescription (14 fields) */
public record class HumanDescription(
    HumanBone[] m_Human,
    SkeletonBone[] m_Skeleton,
    float m_ArmTwist,
    float m_ForeArmTwist,
    float m_UpperLegTwist,
    float m_LegTwist,
    float m_ArmStretch,
    float m_LegStretch,
    float m_FeetSpacing,
    float m_GlobalScale,
    AsciiString m_RootMotionBoneName,
    bool m_HasTranslationDoF,
    bool m_HasExtraRoot,
    bool m_SkeletonHasParents) : IUnityStructure
{
    public static HumanDescription Read(EndianBinaryReader reader)
    {
        HumanBone[] _m_Human = BuiltInArray<HumanBone>.Read(reader);
        reader.AlignTo(4); /* m_Human */
        SkeletonBone[] _m_Skeleton = BuiltInArray<SkeletonBone>.Read(reader);
        reader.AlignTo(4); /* m_Skeleton */
        float _m_ArmTwist = reader.ReadF32();
        float _m_ForeArmTwist = reader.ReadF32();
        float _m_UpperLegTwist = reader.ReadF32();
        float _m_LegTwist = reader.ReadF32();
        float _m_ArmStretch = reader.ReadF32();
        float _m_LegStretch = reader.ReadF32();
        float _m_FeetSpacing = reader.ReadF32();
        float _m_GlobalScale = reader.ReadF32();
        AsciiString _m_RootMotionBoneName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_RootMotionBoneName */
        bool _m_HasTranslationDoF = reader.ReadBool();
        bool _m_HasExtraRoot = reader.ReadBool();
        bool _m_SkeletonHasParents = reader.ReadBool();
        reader.AlignTo(4); /* m_SkeletonHasParents */
        
        return new(_m_Human,
            _m_Skeleton,
            _m_ArmTwist,
            _m_ForeArmTwist,
            _m_UpperLegTwist,
            _m_LegTwist,
            _m_ArmStretch,
            _m_LegStretch,
            _m_FeetSpacing,
            _m_GlobalScale,
            _m_RootMotionBoneName,
            _m_HasTranslationDoF,
            _m_HasExtraRoot,
            _m_SkeletonHasParents);
    }

    public override string ToString() => $"HumanDescription\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Human: ");
        sb.AppendLine(m_Human.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Skeleton: ");
        sb.AppendLine(m_Skeleton.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ArmTwist: ");
        sb.AppendLine(m_ArmTwist.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ForeArmTwist: ");
        sb.AppendLine(m_ForeArmTwist.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_UpperLegTwist: ");
        sb.AppendLine(m_UpperLegTwist.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LegTwist: ");
        sb.AppendLine(m_LegTwist.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ArmStretch: ");
        sb.AppendLine(m_ArmStretch.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LegStretch: ");
        sb.AppendLine(m_LegStretch.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FeetSpacing: ");
        sb.AppendLine(m_FeetSpacing.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GlobalScale: ");
        sb.AppendLine(m_GlobalScale.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RootMotionBoneName: ");
        sb.AppendLine(m_RootMotionBoneName.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HasTranslationDoF: ");
        sb.AppendLine(m_HasTranslationDoF.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HasExtraRoot: ");
        sb.AppendLine(m_HasExtraRoot.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SkeletonHasParents: ");
        sb.AppendLine(m_SkeletonHasParents.ToString());

        return sb.ToString();
    }
}

/* $HumanBone (3 fields) */
public record class HumanBone(
    AsciiString m_BoneName,
    AsciiString m_HumanName,
    SkeletonBoneLimit m_Limit) : IUnityStructure
{
    public static HumanBone Read(EndianBinaryReader reader)
    {
        AsciiString _m_BoneName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_BoneName */
        AsciiString _m_HumanName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HumanName */
        SkeletonBoneLimit _m_Limit = SkeletonBoneLimit.Read(reader);
        reader.AlignTo(4); /* m_Limit */
        
        return new(_m_BoneName,
            _m_HumanName,
            _m_Limit);
    }

    public override string ToString() => $"HumanBone\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BoneName: ");
        sb.AppendLine(m_BoneName.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HumanName: ");
        sb.AppendLine(m_HumanName.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Limit: ");
        sb.AppendLine();
        sb.Append(m_Limit.ToString(indent+4));

        return sb.ToString();
    }
}

/* $SkeletonBoneLimit (5 fields) */
public record class SkeletonBoneLimit(
    Vector3f m_Min,
    Vector3f m_Max,
    Vector3f m_Value,
    float m_Length,
    bool m_Modified) : IUnityStructure
{
    public static SkeletonBoneLimit Read(EndianBinaryReader reader)
    {
        Vector3f _m_Min = Vector3f.Read(reader);
        Vector3f _m_Max = Vector3f.Read(reader);
        Vector3f _m_Value = Vector3f.Read(reader);
        float _m_Length = reader.ReadF32();
        bool _m_Modified = reader.ReadBool();
        reader.AlignTo(4); /* m_Modified */
        
        return new(_m_Min,
            _m_Max,
            _m_Value,
            _m_Length,
            _m_Modified);
    }

    public override string ToString() => $"SkeletonBoneLimit\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Min: ");
        sb.AppendLine();
        sb.Append(m_Min.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Max: ");
        sb.AppendLine();
        sb.Append(m_Max.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Value: ");
        sb.AppendLine();
        sb.Append(m_Value.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Length: ");
        sb.AppendLine(m_Length.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Modified: ");
        sb.AppendLine(m_Modified.ToString());

        return sb.ToString();
    }
}

/* $SkeletonBone (5 fields) */
public record class SkeletonBone(
    AsciiString m_Name,
    AsciiString m_ParentName,
    Vector3f m_Position,
    Quaternionf m_Rotation,
    Vector3f m_Scale) : IUnityStructure
{
    public static SkeletonBone Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        AsciiString _m_ParentName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ParentName */
        Vector3f _m_Position = Vector3f.Read(reader);
        Quaternionf _m_Rotation = Quaternionf.Read(reader);
        Vector3f _m_Scale = Vector3f.Read(reader);
        
        return new(_m_Name,
            _m_ParentName,
            _m_Position,
            _m_Rotation,
            _m_Scale);
    }

    public override string ToString() => $"SkeletonBone\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ParentName: ");
        sb.AppendLine(m_ParentName.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Position: ");
        sb.AppendLine();
        sb.Append(m_Position.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Rotation: ");
        sb.AppendLine();
        sb.Append(m_Rotation.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Scale: ");
        sb.AppendLine();
        sb.Append(m_Scale.ToString(indent+4));

        return sb.ToString();
    }
}

/* $SoftJointLimitSpring (2 fields) */
public readonly record struct SoftJointLimitSpring(
    float spring,
    float damper) : IUnityStructure
{
    public static SoftJointLimitSpring Read(EndianBinaryReader reader)
    {
        float _spring = reader.ReadF32();
        float _damper = reader.ReadF32();
        
        return new(_spring,
            _damper);
    }

    public override string ToString() => $"SoftJointLimitSpring\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("spring: ");
        sb.AppendLine(spring.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("damper: ");
        sb.AppendLine(damper.ToString());

        return sb.ToString();
    }
}

/* $SoftJointLimit (3 fields) */
public readonly record struct SoftJointLimit(
    float limit,
    float bounciness,
    float contactDistance) : IUnityStructure
{
    public static SoftJointLimit Read(EndianBinaryReader reader)
    {
        float _limit = reader.ReadF32();
        float _bounciness = reader.ReadF32();
        float _contactDistance = reader.ReadF32();
        
        return new(_limit,
            _bounciness,
            _contactDistance);
    }

    public override string ToString() => $"SoftJointLimit\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("limit: ");
        sb.AppendLine(limit.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("bounciness: ");
        sb.AppendLine(bounciness.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("contactDistance: ");
        sb.AppendLine(contactDistance.ToString());

        return sb.ToString();
    }
}

/* $ControllerConstant (4 fields) */
public record class ControllerConstant(
    OffsetPtr_4[] m_LayerArray,
    OffsetPtr_6[] m_StateMachineArray,
    OffsetPtr_17 m_Values,
    OffsetPtr_18 m_DefaultValues) : IUnityStructure
{
    public static ControllerConstant Read(EndianBinaryReader reader)
    {
        OffsetPtr_4[] _m_LayerArray = BuiltInArray<OffsetPtr_4>.Read(reader);
        reader.AlignTo(4); /* m_LayerArray */
        OffsetPtr_6[] _m_StateMachineArray = BuiltInArray<OffsetPtr_6>.Read(reader);
        reader.AlignTo(4); /* m_StateMachineArray */
        OffsetPtr_17 _m_Values = OffsetPtr_17.Read(reader);
        OffsetPtr_18 _m_DefaultValues = OffsetPtr_18.Read(reader);
        reader.AlignTo(4); /* m_DefaultValues */
        
        return new(_m_LayerArray,
            _m_StateMachineArray,
            _m_Values,
            _m_DefaultValues);
    }

    public override string ToString() => $"ControllerConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LayerArray: ");
        sb.AppendLine(m_LayerArray.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StateMachineArray: ");
        sb.AppendLine(m_StateMachineArray.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Values: ");
        sb.AppendLine();
        sb.Append(m_Values.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DefaultValues: ");
        sb.AppendLine();
        sb.Append(m_DefaultValues.ToString(indent+4));

        return sb.ToString();
    }
}

/* $OffsetPtr_4 (1 fields) */
public record class OffsetPtr_4(
    LayerConstant data) : IUnityStructure
{
    public static OffsetPtr_4 Read(EndianBinaryReader reader)
    {
        LayerConstant _data = LayerConstant.Read(reader);
        reader.AlignTo(4); /* data */
        
        return new(_data);
    }

    public override string ToString() => $"OffsetPtr_4\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data: ");
        sb.AppendLine();
        sb.Append(data.ToString(indent+4));

        return sb.ToString();
    }
}

/* $LayerConstant (9 fields) */
public record class LayerConstant(
    uint m_StateMachineIndex,
    uint m_StateMachineSynchronizedLayerIndex,
    HumanPoseMask m_BodyMask,
    OffsetPtr_5 m_SkeletonMask,
    uint m_Binding,
    int _intRef_m_LayerBlendingMode,
    float m_DefaultWeight,
    bool m_IKPass,
    bool m_SyncedLayerAffectsTiming) : IUnityStructure
{
    public static LayerConstant Read(EndianBinaryReader reader)
    {
        uint _m_StateMachineIndex = reader.ReadU32();
        uint _m_StateMachineSynchronizedLayerIndex = reader.ReadU32();
        HumanPoseMask _m_BodyMask = HumanPoseMask.Read(reader);
        OffsetPtr_5 _m_SkeletonMask = OffsetPtr_5.Read(reader);
        uint _m_Binding = reader.ReadU32();
        int __intRef_m_LayerBlendingMode = reader.ReadS32();
        float _m_DefaultWeight = reader.ReadF32();
        bool _m_IKPass = reader.ReadBool();
        bool _m_SyncedLayerAffectsTiming = reader.ReadBool();
        reader.AlignTo(4); /* m_SyncedLayerAffectsTiming */
        
        return new(_m_StateMachineIndex,
            _m_StateMachineSynchronizedLayerIndex,
            _m_BodyMask,
            _m_SkeletonMask,
            _m_Binding,
            __intRef_m_LayerBlendingMode,
            _m_DefaultWeight,
            _m_IKPass,
            _m_SyncedLayerAffectsTiming);
    }

    public override string ToString() => $"LayerConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StateMachineIndex: ");
        sb.AppendLine(m_StateMachineIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StateMachineSynchronizedLayerIndex: ");
        sb.AppendLine(m_StateMachineSynchronizedLayerIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BodyMask: ");
        sb.AppendLine();
        sb.Append(m_BodyMask.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SkeletonMask: ");
        sb.AppendLine();
        sb.Append(m_SkeletonMask.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Binding: ");
        sb.AppendLine(m_Binding.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("_intRef_m_LayerBlendingMode: ");
        sb.AppendLine(_intRef_m_LayerBlendingMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DefaultWeight: ");
        sb.AppendLine(m_DefaultWeight.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IKPass: ");
        sb.AppendLine(m_IKPass.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SyncedLayerAffectsTiming: ");
        sb.AppendLine(m_SyncedLayerAffectsTiming.ToString());

        return sb.ToString();
    }
}

/* $HumanPoseMask (3 fields) */
public readonly record struct HumanPoseMask(
    uint word0,
    uint word1,
    uint word2) : IUnityStructure
{
    public static HumanPoseMask Read(EndianBinaryReader reader)
    {
        uint _word0 = reader.ReadU32();
        uint _word1 = reader.ReadU32();
        uint _word2 = reader.ReadU32();
        
        return new(_word0,
            _word1,
            _word2);
    }

    public override string ToString() => $"HumanPoseMask\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("word0: ");
        sb.AppendLine(word0.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("word1: ");
        sb.AppendLine(word1.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("word2: ");
        sb.AppendLine(word2.ToString());

        return sb.ToString();
    }
}

/* $OffsetPtr_5 (1 fields) */
public record class OffsetPtr_5(
    SkeletonMask data) : IUnityStructure
{
    public static OffsetPtr_5 Read(EndianBinaryReader reader)
    {
        SkeletonMask _data = SkeletonMask.Read(reader);
        
        return new(_data);
    }

    public override string ToString() => $"OffsetPtr_5\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data: ");
        sb.AppendLine();
        sb.Append(data.ToString(indent+4));

        return sb.ToString();
    }
}

/* $SkeletonMask (1 fields) */
public record class SkeletonMask(
    SkeletonMaskElement[] m_Data) : IUnityStructure
{
    public static SkeletonMask Read(EndianBinaryReader reader)
    {
        SkeletonMaskElement[] _m_Data = BuiltInArray<SkeletonMaskElement>.Read(reader);
        
        return new(_m_Data);
    }

    public override string ToString() => $"SkeletonMask\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Data: ");
        sb.AppendLine(m_Data.ToString());

        return sb.ToString();
    }
}

/* $SkeletonMaskElement (2 fields) */
public readonly record struct SkeletonMaskElement(
    uint m_PathHash,
    float m_Weight) : IUnityStructure
{
    public static SkeletonMaskElement Read(EndianBinaryReader reader)
    {
        uint _m_PathHash = reader.ReadU32();
        float _m_Weight = reader.ReadF32();
        
        return new(_m_PathHash,
            _m_Weight);
    }

    public override string ToString() => $"SkeletonMaskElement\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PathHash: ");
        sb.AppendLine(m_PathHash.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Weight: ");
        sb.AppendLine(m_Weight.ToString());

        return sb.ToString();
    }
}

/* $OffsetPtr_6 (1 fields) */
public record class OffsetPtr_6(
    StateMachineConstant data) : IUnityStructure
{
    public static OffsetPtr_6 Read(EndianBinaryReader reader)
    {
        StateMachineConstant _data = StateMachineConstant.Read(reader);
        reader.AlignTo(4); /* data */
        
        return new(_data);
    }

    public override string ToString() => $"OffsetPtr_6\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data: ");
        sb.AppendLine();
        sb.Append(data.ToString(indent+4));

        return sb.ToString();
    }
}

/* $StateMachineConstant (5 fields) */
public record class StateMachineConstant(
    OffsetPtr_7[] m_StateConstantArray,
    OffsetPtr_8[] m_AnyStateTransitionConstantArray,
    OffsetPtr_15[] m_SelectorStateConstantArray,
    uint m_DefaultState,
    uint m_SynchronizedLayerCount) : IUnityStructure
{
    public static StateMachineConstant Read(EndianBinaryReader reader)
    {
        OffsetPtr_7[] _m_StateConstantArray = BuiltInArray<OffsetPtr_7>.Read(reader);
        reader.AlignTo(4); /* m_StateConstantArray */
        OffsetPtr_8[] _m_AnyStateTransitionConstantArray = BuiltInArray<OffsetPtr_8>.Read(reader);
        reader.AlignTo(4); /* m_AnyStateTransitionConstantArray */
        OffsetPtr_15[] _m_SelectorStateConstantArray = BuiltInArray<OffsetPtr_15>.Read(reader);
        reader.AlignTo(4); /* m_SelectorStateConstantArray */
        uint _m_DefaultState = reader.ReadU32();
        uint _m_SynchronizedLayerCount = reader.ReadU32();
        
        return new(_m_StateConstantArray,
            _m_AnyStateTransitionConstantArray,
            _m_SelectorStateConstantArray,
            _m_DefaultState,
            _m_SynchronizedLayerCount);
    }

    public override string ToString() => $"StateMachineConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StateConstantArray: ");
        sb.AppendLine(m_StateConstantArray.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AnyStateTransitionConstantArray: ");
        sb.AppendLine(m_AnyStateTransitionConstantArray.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SelectorStateConstantArray: ");
        sb.AppendLine(m_SelectorStateConstantArray.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DefaultState: ");
        sb.AppendLine(m_DefaultState.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SynchronizedLayerCount: ");
        sb.AppendLine(m_SynchronizedLayerCount.ToString());

        return sb.ToString();
    }
}

/* $OffsetPtr_7 (1 fields) */
public record class OffsetPtr_7(
    StateConstant data) : IUnityStructure
{
    public static OffsetPtr_7 Read(EndianBinaryReader reader)
    {
        StateConstant _data = StateConstant.Read(reader);
        reader.AlignTo(4); /* data */
        
        return new(_data);
    }

    public override string ToString() => $"OffsetPtr_7\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data: ");
        sb.AppendLine();
        sb.Append(data.ToString(indent+4));

        return sb.ToString();
    }
}

/* $StateConstant (17 fields) */
public record class StateConstant(
    OffsetPtr_8[] m_TransitionConstantArray,
    int[] m_BlendTreeConstantIndexArray,
    OffsetPtr_10[] m_BlendTreeConstantArray,
    uint m_NameID,
    uint m_PathID,
    uint m_FullPathID,
    uint m_TagID,
    uint m_SpeedParamID,
    uint m_MirrorParamID,
    uint m_CycleOffsetParamID,
    uint m_TimeParamID,
    float m_Speed,
    float m_CycleOffset,
    bool m_IKOnFeet,
    bool m_WriteDefaultValues,
    bool m_Loop,
    bool m_Mirror) : IUnityStructure
{
    public static StateConstant Read(EndianBinaryReader reader)
    {
        OffsetPtr_8[] _m_TransitionConstantArray = BuiltInArray<OffsetPtr_8>.Read(reader);
        reader.AlignTo(4); /* m_TransitionConstantArray */
        int[] _m_BlendTreeConstantIndexArray = BuiltInArray<int>.Read(reader);
        OffsetPtr_10[] _m_BlendTreeConstantArray = BuiltInArray<OffsetPtr_10>.Read(reader);
        reader.AlignTo(4); /* m_BlendTreeConstantArray */
        uint _m_NameID = reader.ReadU32();
        uint _m_PathID = reader.ReadU32();
        uint _m_FullPathID = reader.ReadU32();
        uint _m_TagID = reader.ReadU32();
        uint _m_SpeedParamID = reader.ReadU32();
        uint _m_MirrorParamID = reader.ReadU32();
        uint _m_CycleOffsetParamID = reader.ReadU32();
        uint _m_TimeParamID = reader.ReadU32();
        float _m_Speed = reader.ReadF32();
        float _m_CycleOffset = reader.ReadF32();
        bool _m_IKOnFeet = reader.ReadBool();
        bool _m_WriteDefaultValues = reader.ReadBool();
        bool _m_Loop = reader.ReadBool();
        bool _m_Mirror = reader.ReadBool();
        reader.AlignTo(4); /* m_Mirror */
        
        return new(_m_TransitionConstantArray,
            _m_BlendTreeConstantIndexArray,
            _m_BlendTreeConstantArray,
            _m_NameID,
            _m_PathID,
            _m_FullPathID,
            _m_TagID,
            _m_SpeedParamID,
            _m_MirrorParamID,
            _m_CycleOffsetParamID,
            _m_TimeParamID,
            _m_Speed,
            _m_CycleOffset,
            _m_IKOnFeet,
            _m_WriteDefaultValues,
            _m_Loop,
            _m_Mirror);
    }

    public override string ToString() => $"StateConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TransitionConstantArray: ");
        sb.AppendLine(m_TransitionConstantArray.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BlendTreeConstantIndexArray: ");
        sb.AppendLine(m_BlendTreeConstantIndexArray.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BlendTreeConstantArray: ");
        sb.AppendLine(m_BlendTreeConstantArray.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NameID: ");
        sb.AppendLine(m_NameID.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PathID: ");
        sb.AppendLine(m_PathID.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FullPathID: ");
        sb.AppendLine(m_FullPathID.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TagID: ");
        sb.AppendLine(m_TagID.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SpeedParamID: ");
        sb.AppendLine(m_SpeedParamID.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MirrorParamID: ");
        sb.AppendLine(m_MirrorParamID.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CycleOffsetParamID: ");
        sb.AppendLine(m_CycleOffsetParamID.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TimeParamID: ");
        sb.AppendLine(m_TimeParamID.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Speed: ");
        sb.AppendLine(m_Speed.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CycleOffset: ");
        sb.AppendLine(m_CycleOffset.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IKOnFeet: ");
        sb.AppendLine(m_IKOnFeet.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_WriteDefaultValues: ");
        sb.AppendLine(m_WriteDefaultValues.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Loop: ");
        sb.AppendLine(m_Loop.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Mirror: ");
        sb.AppendLine(m_Mirror.ToString());

        return sb.ToString();
    }
}

/* $OffsetPtr_8 (1 fields) */
public record class OffsetPtr_8(
    TransitionConstant data) : IUnityStructure
{
    public static OffsetPtr_8 Read(EndianBinaryReader reader)
    {
        TransitionConstant _data = TransitionConstant.Read(reader);
        reader.AlignTo(4); /* data */
        
        return new(_data);
    }

    public override string ToString() => $"OffsetPtr_8\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data: ");
        sb.AppendLine();
        sb.Append(data.ToString(indent+4));

        return sb.ToString();
    }
}

/* $TransitionConstant (13 fields) */
public record class TransitionConstant(
    OffsetPtr_9[] m_ConditionConstantArray,
    uint m_DestinationState,
    uint m_FullPathID,
    uint m_ID,
    uint m_UserID,
    float m_TransitionDuration,
    float m_TransitionOffset,
    float m_ExitTime,
    bool m_HasExitTime,
    bool m_HasFixedDuration,
    int m_InterruptionSource,
    bool m_OrderedInterruption,
    bool m_CanTransitionToSelf) : IUnityStructure
{
    public static TransitionConstant Read(EndianBinaryReader reader)
    {
        OffsetPtr_9[] _m_ConditionConstantArray = BuiltInArray<OffsetPtr_9>.Read(reader);
        uint _m_DestinationState = reader.ReadU32();
        uint _m_FullPathID = reader.ReadU32();
        uint _m_ID = reader.ReadU32();
        uint _m_UserID = reader.ReadU32();
        float _m_TransitionDuration = reader.ReadF32();
        float _m_TransitionOffset = reader.ReadF32();
        float _m_ExitTime = reader.ReadF32();
        bool _m_HasExitTime = reader.ReadBool();
        bool _m_HasFixedDuration = reader.ReadBool();
        reader.AlignTo(4); /* m_HasFixedDuration */
        int _m_InterruptionSource = reader.ReadS32();
        bool _m_OrderedInterruption = reader.ReadBool();
        bool _m_CanTransitionToSelf = reader.ReadBool();
        reader.AlignTo(4); /* m_CanTransitionToSelf */
        
        return new(_m_ConditionConstantArray,
            _m_DestinationState,
            _m_FullPathID,
            _m_ID,
            _m_UserID,
            _m_TransitionDuration,
            _m_TransitionOffset,
            _m_ExitTime,
            _m_HasExitTime,
            _m_HasFixedDuration,
            _m_InterruptionSource,
            _m_OrderedInterruption,
            _m_CanTransitionToSelf);
    }

    public override string ToString() => $"TransitionConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ConditionConstantArray: ");
        sb.AppendLine(m_ConditionConstantArray.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DestinationState: ");
        sb.AppendLine(m_DestinationState.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FullPathID: ");
        sb.AppendLine(m_FullPathID.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ID: ");
        sb.AppendLine(m_ID.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_UserID: ");
        sb.AppendLine(m_UserID.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TransitionDuration: ");
        sb.AppendLine(m_TransitionDuration.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TransitionOffset: ");
        sb.AppendLine(m_TransitionOffset.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ExitTime: ");
        sb.AppendLine(m_ExitTime.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HasExitTime: ");
        sb.AppendLine(m_HasExitTime.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HasFixedDuration: ");
        sb.AppendLine(m_HasFixedDuration.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_InterruptionSource: ");
        sb.AppendLine(m_InterruptionSource.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_OrderedInterruption: ");
        sb.AppendLine(m_OrderedInterruption.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CanTransitionToSelf: ");
        sb.AppendLine(m_CanTransitionToSelf.ToString());

        return sb.ToString();
    }
}

/* $OffsetPtr_9 (1 fields) */
public record class OffsetPtr_9(
    ConditionConstant data) : IUnityStructure
{
    public static OffsetPtr_9 Read(EndianBinaryReader reader)
    {
        ConditionConstant _data = ConditionConstant.Read(reader);
        
        return new(_data);
    }

    public override string ToString() => $"OffsetPtr_9\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data: ");
        sb.AppendLine();
        sb.Append(data.ToString(indent+4));

        return sb.ToString();
    }
}

/* $ConditionConstant (4 fields) */
public readonly record struct ConditionConstant(
    uint m_ConditionMode,
    uint m_EventID,
    float m_EventThreshold,
    float m_ExitTime) : IUnityStructure
{
    public static ConditionConstant Read(EndianBinaryReader reader)
    {
        uint _m_ConditionMode = reader.ReadU32();
        uint _m_EventID = reader.ReadU32();
        float _m_EventThreshold = reader.ReadF32();
        float _m_ExitTime = reader.ReadF32();
        
        return new(_m_ConditionMode,
            _m_EventID,
            _m_EventThreshold,
            _m_ExitTime);
    }

    public override string ToString() => $"ConditionConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ConditionMode: ");
        sb.AppendLine(m_ConditionMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_EventID: ");
        sb.AppendLine(m_EventID.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_EventThreshold: ");
        sb.AppendLine(m_EventThreshold.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ExitTime: ");
        sb.AppendLine(m_ExitTime.ToString());

        return sb.ToString();
    }
}

/* $OffsetPtr_10 (1 fields) */
public record class OffsetPtr_10(
    BlendTreeConstant data) : IUnityStructure
{
    public static OffsetPtr_10 Read(EndianBinaryReader reader)
    {
        BlendTreeConstant _data = BlendTreeConstant.Read(reader);
        reader.AlignTo(4); /* data */
        
        return new(_data);
    }

    public override string ToString() => $"OffsetPtr_10\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data: ");
        sb.AppendLine();
        sb.Append(data.ToString(indent+4));

        return sb.ToString();
    }
}

/* $BlendTreeConstant (1 fields) */
public record class BlendTreeConstant(
    OffsetPtr_11[] m_NodeArray) : IUnityStructure
{
    public static BlendTreeConstant Read(EndianBinaryReader reader)
    {
        OffsetPtr_11[] _m_NodeArray = BuiltInArray<OffsetPtr_11>.Read(reader);
        reader.AlignTo(4); /* m_NodeArray */
        
        return new(_m_NodeArray);
    }

    public override string ToString() => $"BlendTreeConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NodeArray: ");
        sb.AppendLine(m_NodeArray.ToString());

        return sb.ToString();
    }
}

/* $OffsetPtr_11 (1 fields) */
public record class OffsetPtr_11(
    BlendTreeNodeConstant data) : IUnityStructure
{
    public static OffsetPtr_11 Read(EndianBinaryReader reader)
    {
        BlendTreeNodeConstant _data = BlendTreeNodeConstant.Read(reader);
        reader.AlignTo(4); /* data */
        
        return new(_data);
    }

    public override string ToString() => $"OffsetPtr_11\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data: ");
        sb.AppendLine();
        sb.Append(data.ToString(indent+4));

        return sb.ToString();
    }
}

/* $BlendTreeNodeConstant (11 fields) */
public record class BlendTreeNodeConstant(
    uint m_BlendType,
    uint m_BlendEventID,
    uint m_BlendEventYID,
    uint[] m_ChildIndices,
    OffsetPtr_12 m_Blend1dData,
    OffsetPtr_13 m_Blend2dData,
    OffsetPtr_14 m_BlendDirectData,
    uint m_ClipID,
    float m_Duration,
    float m_CycleOffset,
    bool m_Mirror) : IUnityStructure
{
    public static BlendTreeNodeConstant Read(EndianBinaryReader reader)
    {
        uint _m_BlendType = reader.ReadU32();
        uint _m_BlendEventID = reader.ReadU32();
        uint _m_BlendEventYID = reader.ReadU32();
        uint[] _m_ChildIndices = BuiltInArray<uint>.Read(reader);
        OffsetPtr_12 _m_Blend1dData = OffsetPtr_12.Read(reader);
        OffsetPtr_13 _m_Blend2dData = OffsetPtr_13.Read(reader);
        OffsetPtr_14 _m_BlendDirectData = OffsetPtr_14.Read(reader);
        reader.AlignTo(4); /* m_BlendDirectData */
        uint _m_ClipID = reader.ReadU32();
        float _m_Duration = reader.ReadF32();
        float _m_CycleOffset = reader.ReadF32();
        bool _m_Mirror = reader.ReadBool();
        reader.AlignTo(4); /* m_Mirror */
        
        return new(_m_BlendType,
            _m_BlendEventID,
            _m_BlendEventYID,
            _m_ChildIndices,
            _m_Blend1dData,
            _m_Blend2dData,
            _m_BlendDirectData,
            _m_ClipID,
            _m_Duration,
            _m_CycleOffset,
            _m_Mirror);
    }

    public override string ToString() => $"BlendTreeNodeConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BlendType: ");
        sb.AppendLine(m_BlendType.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BlendEventID: ");
        sb.AppendLine(m_BlendEventID.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BlendEventYID: ");
        sb.AppendLine(m_BlendEventYID.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ChildIndices: ");
        sb.AppendLine(m_ChildIndices.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Blend1dData: ");
        sb.AppendLine();
        sb.Append(m_Blend1dData.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Blend2dData: ");
        sb.AppendLine();
        sb.Append(m_Blend2dData.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BlendDirectData: ");
        sb.AppendLine();
        sb.Append(m_BlendDirectData.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ClipID: ");
        sb.AppendLine(m_ClipID.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Duration: ");
        sb.AppendLine(m_Duration.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CycleOffset: ");
        sb.AppendLine(m_CycleOffset.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Mirror: ");
        sb.AppendLine(m_Mirror.ToString());

        return sb.ToString();
    }
}

/* $OffsetPtr_12 (1 fields) */
public record class OffsetPtr_12(
    Blend1dDataConstant data) : IUnityStructure
{
    public static OffsetPtr_12 Read(EndianBinaryReader reader)
    {
        Blend1dDataConstant _data = Blend1dDataConstant.Read(reader);
        
        return new(_data);
    }

    public override string ToString() => $"OffsetPtr_12\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data: ");
        sb.AppendLine();
        sb.Append(data.ToString(indent+4));

        return sb.ToString();
    }
}

/* $Blend1dDataConstant (1 fields) */
public record class Blend1dDataConstant(
    float[] m_ChildThresholdArray) : IUnityStructure
{
    public static Blend1dDataConstant Read(EndianBinaryReader reader)
    {
        float[] _m_ChildThresholdArray = BuiltInArray<float>.Read(reader);
        
        return new(_m_ChildThresholdArray);
    }

    public override string ToString() => $"Blend1dDataConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ChildThresholdArray: ");
        sb.AppendLine(m_ChildThresholdArray.ToString());

        return sb.ToString();
    }
}

/* $OffsetPtr_13 (1 fields) */
public record class OffsetPtr_13(
    Blend2dDataConstant data) : IUnityStructure
{
    public static OffsetPtr_13 Read(EndianBinaryReader reader)
    {
        Blend2dDataConstant _data = Blend2dDataConstant.Read(reader);
        
        return new(_data);
    }

    public override string ToString() => $"OffsetPtr_13\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data: ");
        sb.AppendLine();
        sb.Append(data.ToString(indent+4));

        return sb.ToString();
    }
}

/* $Blend2dDataConstant (5 fields) */
public record class Blend2dDataConstant(
    Vector2f[] m_ChildPositionArray,
    float[] m_ChildMagnitudeArray,
    Vector2f[] m_ChildPairVectorArray,
    float[] m_ChildPairAvgMagInvArray,
    MotionNeighborList[] m_ChildNeighborListArray) : IUnityStructure
{
    public static Blend2dDataConstant Read(EndianBinaryReader reader)
    {
        Vector2f[] _m_ChildPositionArray = BuiltInArray<Vector2f>.Read(reader);
        float[] _m_ChildMagnitudeArray = BuiltInArray<float>.Read(reader);
        Vector2f[] _m_ChildPairVectorArray = BuiltInArray<Vector2f>.Read(reader);
        float[] _m_ChildPairAvgMagInvArray = BuiltInArray<float>.Read(reader);
        MotionNeighborList[] _m_ChildNeighborListArray = BuiltInArray<MotionNeighborList>.Read(reader);
        
        return new(_m_ChildPositionArray,
            _m_ChildMagnitudeArray,
            _m_ChildPairVectorArray,
            _m_ChildPairAvgMagInvArray,
            _m_ChildNeighborListArray);
    }

    public override string ToString() => $"Blend2dDataConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ChildPositionArray: ");
        sb.AppendLine(m_ChildPositionArray.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ChildMagnitudeArray: ");
        sb.AppendLine(m_ChildMagnitudeArray.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ChildPairVectorArray: ");
        sb.AppendLine(m_ChildPairVectorArray.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ChildPairAvgMagInvArray: ");
        sb.AppendLine(m_ChildPairAvgMagInvArray.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ChildNeighborListArray: ");
        sb.AppendLine(m_ChildNeighborListArray.ToString());

        return sb.ToString();
    }
}

/* $MotionNeighborList (1 fields) */
public record class MotionNeighborList(
    uint[] m_NeighborArray) : IUnityStructure
{
    public static MotionNeighborList Read(EndianBinaryReader reader)
    {
        uint[] _m_NeighborArray = BuiltInArray<uint>.Read(reader);
        
        return new(_m_NeighborArray);
    }

    public override string ToString() => $"MotionNeighborList\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NeighborArray: ");
        sb.AppendLine(m_NeighborArray.ToString());

        return sb.ToString();
    }
}

/* $OffsetPtr_14 (1 fields) */
public record class OffsetPtr_14(
    BlendDirectDataConstant data) : IUnityStructure
{
    public static OffsetPtr_14 Read(EndianBinaryReader reader)
    {
        BlendDirectDataConstant _data = BlendDirectDataConstant.Read(reader);
        reader.AlignTo(4); /* data */
        
        return new(_data);
    }

    public override string ToString() => $"OffsetPtr_14\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data: ");
        sb.AppendLine();
        sb.Append(data.ToString(indent+4));

        return sb.ToString();
    }
}

/* $BlendDirectDataConstant (2 fields) */
public record class BlendDirectDataConstant(
    uint[] m_ChildBlendEventIDArray,
    bool m_NormalizedBlendValues) : IUnityStructure
{
    public static BlendDirectDataConstant Read(EndianBinaryReader reader)
    {
        uint[] _m_ChildBlendEventIDArray = BuiltInArray<uint>.Read(reader);
        bool _m_NormalizedBlendValues = reader.ReadBool();
        reader.AlignTo(4); /* m_NormalizedBlendValues */
        
        return new(_m_ChildBlendEventIDArray,
            _m_NormalizedBlendValues);
    }

    public override string ToString() => $"BlendDirectDataConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ChildBlendEventIDArray: ");
        sb.AppendLine(m_ChildBlendEventIDArray.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NormalizedBlendValues: ");
        sb.AppendLine(m_NormalizedBlendValues.ToString());

        return sb.ToString();
    }
}

/* $OffsetPtr_15 (1 fields) */
public record class OffsetPtr_15(
    SelectorStateConstant data) : IUnityStructure
{
    public static OffsetPtr_15 Read(EndianBinaryReader reader)
    {
        SelectorStateConstant _data = SelectorStateConstant.Read(reader);
        reader.AlignTo(4); /* data */
        
        return new(_data);
    }

    public override string ToString() => $"OffsetPtr_15\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data: ");
        sb.AppendLine();
        sb.Append(data.ToString(indent+4));

        return sb.ToString();
    }
}

/* $SelectorStateConstant (3 fields) */
public record class SelectorStateConstant(
    OffsetPtr_16[] m_TransitionConstantArray,
    uint m_FullPathID,
    bool m_IsEntry) : IUnityStructure
{
    public static SelectorStateConstant Read(EndianBinaryReader reader)
    {
        OffsetPtr_16[] _m_TransitionConstantArray = BuiltInArray<OffsetPtr_16>.Read(reader);
        uint _m_FullPathID = reader.ReadU32();
        bool _m_IsEntry = reader.ReadBool();
        reader.AlignTo(4); /* m_IsEntry */
        
        return new(_m_TransitionConstantArray,
            _m_FullPathID,
            _m_IsEntry);
    }

    public override string ToString() => $"SelectorStateConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TransitionConstantArray: ");
        sb.AppendLine(m_TransitionConstantArray.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FullPathID: ");
        sb.AppendLine(m_FullPathID.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IsEntry: ");
        sb.AppendLine(m_IsEntry.ToString());

        return sb.ToString();
    }
}

/* $OffsetPtr_16 (1 fields) */
public record class OffsetPtr_16(
    SelectorTransitionConstant data) : IUnityStructure
{
    public static OffsetPtr_16 Read(EndianBinaryReader reader)
    {
        SelectorTransitionConstant _data = SelectorTransitionConstant.Read(reader);
        
        return new(_data);
    }

    public override string ToString() => $"OffsetPtr_16\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data: ");
        sb.AppendLine();
        sb.Append(data.ToString(indent+4));

        return sb.ToString();
    }
}

/* $SelectorTransitionConstant (2 fields) */
public record class SelectorTransitionConstant(
    uint m_Destination,
    OffsetPtr_9[] m_ConditionConstantArray) : IUnityStructure
{
    public static SelectorTransitionConstant Read(EndianBinaryReader reader)
    {
        uint _m_Destination = reader.ReadU32();
        OffsetPtr_9[] _m_ConditionConstantArray = BuiltInArray<OffsetPtr_9>.Read(reader);
        
        return new(_m_Destination,
            _m_ConditionConstantArray);
    }

    public override string ToString() => $"SelectorTransitionConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Destination: ");
        sb.AppendLine(m_Destination.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ConditionConstantArray: ");
        sb.AppendLine(m_ConditionConstantArray.ToString());

        return sb.ToString();
    }
}

/* $OffsetPtr_17 (1 fields) */
public record class OffsetPtr_17(
    ValueArrayConstant data) : IUnityStructure
{
    public static OffsetPtr_17 Read(EndianBinaryReader reader)
    {
        ValueArrayConstant _data = ValueArrayConstant.Read(reader);
        
        return new(_data);
    }

    public override string ToString() => $"OffsetPtr_17\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data: ");
        sb.AppendLine();
        sb.Append(data.ToString(indent+4));

        return sb.ToString();
    }
}

/* $ValueArrayConstant (1 fields) */
public record class ValueArrayConstant(
    ValueConstant[] m_ValueArray) : IUnityStructure
{
    public static ValueArrayConstant Read(EndianBinaryReader reader)
    {
        ValueConstant[] _m_ValueArray = BuiltInArray<ValueConstant>.Read(reader);
        
        return new(_m_ValueArray);
    }

    public override string ToString() => $"ValueArrayConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ValueArray: ");
        sb.AppendLine(m_ValueArray.ToString());

        return sb.ToString();
    }
}

/* $ValueConstant (3 fields) */
public readonly record struct ValueConstant(
    uint m_ID,
    uint m_Type,
    uint m_Index) : IUnityStructure
{
    public static ValueConstant Read(EndianBinaryReader reader)
    {
        uint _m_ID = reader.ReadU32();
        uint _m_Type = reader.ReadU32();
        uint _m_Index = reader.ReadU32();
        
        return new(_m_ID,
            _m_Type,
            _m_Index);
    }

    public override string ToString() => $"ValueConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ID: ");
        sb.AppendLine(m_ID.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Type: ");
        sb.AppendLine(m_Type.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Index: ");
        sb.AppendLine(m_Index.ToString());

        return sb.ToString();
    }
}

/* $OffsetPtr_18 (1 fields) */
public record class OffsetPtr_18(
    ValueArray data) : IUnityStructure
{
    public static OffsetPtr_18 Read(EndianBinaryReader reader)
    {
        ValueArray _data = ValueArray.Read(reader);
        reader.AlignTo(4); /* data */
        
        return new(_data);
    }

    public override string ToString() => $"OffsetPtr_18\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data: ");
        sb.AppendLine();
        sb.Append(data.ToString(indent+4));

        return sb.ToString();
    }
}

/* $ValueArray (6 fields) */
public record class ValueArray(
    float3[] m_PositionValues,
    float4[] m_QuaternionValues,
    float3[] m_ScaleValues,
    float[] m_FloatValues,
    int[] m_IntValues,
    bool[] m_BoolValues) : IUnityStructure
{
    public static ValueArray Read(EndianBinaryReader reader)
    {
        float3[] _m_PositionValues = BuiltInArray<float3>.Read(reader);
        float4[] _m_QuaternionValues = BuiltInArray<float4>.Read(reader);
        float3[] _m_ScaleValues = BuiltInArray<float3>.Read(reader);
        float[] _m_FloatValues = BuiltInArray<float>.Read(reader);
        int[] _m_IntValues = BuiltInArray<int>.Read(reader);
        bool[] _m_BoolValues = BuiltInArray<bool>.Read(reader);
        reader.AlignTo(4); /* m_BoolValues */
        
        return new(_m_PositionValues,
            _m_QuaternionValues,
            _m_ScaleValues,
            _m_FloatValues,
            _m_IntValues,
            _m_BoolValues);
    }

    public override string ToString() => $"ValueArray\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PositionValues: ");
        sb.AppendLine(m_PositionValues.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_QuaternionValues: ");
        sb.AppendLine(m_QuaternionValues.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ScaleValues: ");
        sb.AppendLine(m_ScaleValues.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FloatValues: ");
        sb.AppendLine(m_FloatValues.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IntValues: ");
        sb.AppendLine(m_IntValues.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BoolValues: ");
        sb.AppendLine(m_BoolValues.ToString());

        return sb.ToString();
    }
}

/* $StateMachineBehaviourVectorDescription (2 fields) */
public record class StateMachineBehaviourVectorDescription(
    Dictionary<StateKey, StateRange> m_StateMachineBehaviourRanges,
    uint[] m_StateMachineBehaviourIndices) : IUnityStructure
{
    public static StateMachineBehaviourVectorDescription Read(EndianBinaryReader reader)
    {
        Dictionary<StateKey, StateRange> _m_StateMachineBehaviourRanges = BuiltInMap<StateKey, StateRange>.Read(reader);
        uint[] _m_StateMachineBehaviourIndices = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* m_StateMachineBehaviourIndices */
        
        return new(_m_StateMachineBehaviourRanges,
            _m_StateMachineBehaviourIndices);
    }

    public override string ToString() => $"StateMachineBehaviourVectorDescription\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StateMachineBehaviourRanges: ");
        sb.AppendLine(m_StateMachineBehaviourRanges.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StateMachineBehaviourIndices: ");
        sb.AppendLine(m_StateMachineBehaviourIndices.ToString());

        return sb.ToString();
    }
}

/* $StateKey (2 fields) */
public readonly record struct StateKey(
    uint m_StateID,
    int m_LayerIndex) : IUnityStructure
{
    public static StateKey Read(EndianBinaryReader reader)
    {
        uint _m_StateID = reader.ReadU32();
        int _m_LayerIndex = reader.ReadS32();
        
        return new(_m_StateID,
            _m_LayerIndex);
    }

    public override string ToString() => $"StateKey\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StateID: ");
        sb.AppendLine(m_StateID.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LayerIndex: ");
        sb.AppendLine(m_LayerIndex.ToString());

        return sb.ToString();
    }
}

/* $StateRange (2 fields) */
public readonly record struct StateRange(
    uint m_StartIndex,
    uint m_Count) : IUnityStructure
{
    public static StateRange Read(EndianBinaryReader reader)
    {
        uint _m_StartIndex = reader.ReadU32();
        uint _m_Count = reader.ReadU32();
        
        return new(_m_StartIndex,
            _m_Count);
    }

    public override string ToString() => $"StateRange\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StartIndex: ");
        sb.AppendLine(m_StartIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Count: ");
        sb.AppendLine(m_Count.ToString());

        return sb.ToString();
    }
}

/* $TransformMaskElement (2 fields) */
public record class TransformMaskElement(
    AsciiString m_Path,
    float m_Weight) : IUnityStructure
{
    public static TransformMaskElement Read(EndianBinaryReader reader)
    {
        AsciiString _m_Path = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Path */
        float _m_Weight = reader.ReadF32();
        
        return new(_m_Path,
            _m_Weight);
    }

    public override string ToString() => $"TransformMaskElement\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Path: ");
        sb.AppendLine(m_Path.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Weight: ");
        sb.AppendLine(m_Weight.ToString());

        return sb.ToString();
    }
}

/* $VisualEffectInfo (18 fields) */
public record class VisualEffectInfo(
    VFXRendererSettings m_RendererSettings,
    int m_CullingFlags,
    int m_UpdateMode,
    float m_PreWarmDeltaTime,
    uint m_PreWarmStepCount,
    AsciiString m_InitialEventName,
    int m_InstancingMode,
    uint m_InstancingCapacity,
    VFXExpressionContainer m_Expressions,
    VFXPropertySheetSerializedBase_1 m_PropertySheet,
    VFXMapping[] m_ExposedExpressions,
    VFXGPUBufferDesc[] m_Buffers,
    VFXTemporaryGPUBufferDesc[] m_TemporaryBuffers,
    VFXCPUBufferDesc[] m_CPUBuffers,
    VFXEventDesc[] m_Events,
    int m_InstancingDisabledReason,
    uint m_RuntimeVersion,
    uint m_CompilationVersion) : IUnityStructure
{
    public static VisualEffectInfo Read(EndianBinaryReader reader)
    {
        VFXRendererSettings _m_RendererSettings = VFXRendererSettings.Read(reader);
        reader.AlignTo(4); /* m_RendererSettings */
        int _m_CullingFlags = reader.ReadS32();
        int _m_UpdateMode = reader.ReadS32();
        float _m_PreWarmDeltaTime = reader.ReadF32();
        uint _m_PreWarmStepCount = reader.ReadU32();
        AsciiString _m_InitialEventName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_InitialEventName */
        int _m_InstancingMode = reader.ReadS32();
        uint _m_InstancingCapacity = reader.ReadU32();
        VFXExpressionContainer _m_Expressions = VFXExpressionContainer.Read(reader);
        reader.AlignTo(4); /* m_Expressions */
        VFXPropertySheetSerializedBase_1 _m_PropertySheet = VFXPropertySheetSerializedBase_1.Read(reader);
        reader.AlignTo(4); /* m_PropertySheet */
        VFXMapping[] _m_ExposedExpressions = BuiltInArray<VFXMapping>.Read(reader);
        reader.AlignTo(4); /* m_ExposedExpressions */
        VFXGPUBufferDesc[] _m_Buffers = BuiltInArray<VFXGPUBufferDesc>.Read(reader);
        reader.AlignTo(4); /* m_Buffers */
        VFXTemporaryGPUBufferDesc[] _m_TemporaryBuffers = BuiltInArray<VFXTemporaryGPUBufferDesc>.Read(reader);
        reader.AlignTo(4); /* m_TemporaryBuffers */
        VFXCPUBufferDesc[] _m_CPUBuffers = BuiltInArray<VFXCPUBufferDesc>.Read(reader);
        reader.AlignTo(4); /* m_CPUBuffers */
        VFXEventDesc[] _m_Events = BuiltInArray<VFXEventDesc>.Read(reader);
        reader.AlignTo(4); /* m_Events */
        int _m_InstancingDisabledReason = reader.ReadS32();
        uint _m_RuntimeVersion = reader.ReadU32();
        uint _m_CompilationVersion = reader.ReadU32();
        
        return new(_m_RendererSettings,
            _m_CullingFlags,
            _m_UpdateMode,
            _m_PreWarmDeltaTime,
            _m_PreWarmStepCount,
            _m_InitialEventName,
            _m_InstancingMode,
            _m_InstancingCapacity,
            _m_Expressions,
            _m_PropertySheet,
            _m_ExposedExpressions,
            _m_Buffers,
            _m_TemporaryBuffers,
            _m_CPUBuffers,
            _m_Events,
            _m_InstancingDisabledReason,
            _m_RuntimeVersion,
            _m_CompilationVersion);
    }

    public override string ToString() => $"VisualEffectInfo\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RendererSettings: ");
        sb.AppendLine();
        sb.Append(m_RendererSettings.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CullingFlags: ");
        sb.AppendLine(m_CullingFlags.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_UpdateMode: ");
        sb.AppendLine(m_UpdateMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PreWarmDeltaTime: ");
        sb.AppendLine(m_PreWarmDeltaTime.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PreWarmStepCount: ");
        sb.AppendLine(m_PreWarmStepCount.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_InitialEventName: ");
        sb.AppendLine(m_InitialEventName.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_InstancingMode: ");
        sb.AppendLine(m_InstancingMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_InstancingCapacity: ");
        sb.AppendLine(m_InstancingCapacity.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Expressions: ");
        sb.AppendLine();
        sb.Append(m_Expressions.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PropertySheet: ");
        sb.AppendLine();
        sb.Append(m_PropertySheet.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ExposedExpressions: ");
        sb.AppendLine(m_ExposedExpressions.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Buffers: ");
        sb.AppendLine(m_Buffers.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TemporaryBuffers: ");
        sb.AppendLine(m_TemporaryBuffers.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CPUBuffers: ");
        sb.AppendLine(m_CPUBuffers.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Events: ");
        sb.AppendLine(m_Events.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_InstancingDisabledReason: ");
        sb.AppendLine(m_InstancingDisabledReason.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RuntimeVersion: ");
        sb.AppendLine(m_RuntimeVersion.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CompilationVersion: ");
        sb.AppendLine(m_CompilationVersion.ToString());

        return sb.ToString();
    }
}

/* $VFXRendererSettings (5 fields) */
public readonly record struct VFXRendererSettings(
    int motionVectorGenerationMode,
    int shadowCastingMode,
    bool receiveShadows,
    int reflectionProbeUsage,
    int lightProbeUsage) : IUnityStructure
{
    public static VFXRendererSettings Read(EndianBinaryReader reader)
    {
        int _motionVectorGenerationMode = reader.ReadS32();
        int _shadowCastingMode = reader.ReadS32();
        bool _receiveShadows = reader.ReadBool();
        reader.AlignTo(4); /* receiveShadows */
        int _reflectionProbeUsage = reader.ReadS32();
        int _lightProbeUsage = reader.ReadS32();
        
        return new(_motionVectorGenerationMode,
            _shadowCastingMode,
            _receiveShadows,
            _reflectionProbeUsage,
            _lightProbeUsage);
    }

    public override string ToString() => $"VFXRendererSettings\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("motionVectorGenerationMode: ");
        sb.AppendLine(motionVectorGenerationMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("shadowCastingMode: ");
        sb.AppendLine(shadowCastingMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("receiveShadows: ");
        sb.AppendLine(receiveShadows.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("reflectionProbeUsage: ");
        sb.AppendLine(reflectionProbeUsage.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("lightProbeUsage: ");
        sb.AppendLine(lightProbeUsage.ToString());

        return sb.ToString();
    }
}

/* $VFXExpressionContainer (10 fields) */
public record class VFXExpressionContainer(
    Expression[] m_Expressions,
    uint m_MaxCommonExpressionsIndex,
    uint m_ConstantBakeCurveCount,
    uint m_ConstantBakeGradientCount,
    uint m_DynamicBakeCurveCount,
    uint m_DynamicBakeGradientCount,
    bool m_NeedsLocalToWorld,
    bool m_NeedsWorldToLocal,
    bool m_NeedsMainCamera,
    int m_NeededMainCameraBuffers) : IUnityStructure
{
    public static VFXExpressionContainer Read(EndianBinaryReader reader)
    {
        Expression[] _m_Expressions = BuiltInArray<Expression>.Read(reader);
        reader.AlignTo(4); /* m_Expressions */
        uint _m_MaxCommonExpressionsIndex = reader.ReadU32();
        uint _m_ConstantBakeCurveCount = reader.ReadU32();
        uint _m_ConstantBakeGradientCount = reader.ReadU32();
        uint _m_DynamicBakeCurveCount = reader.ReadU32();
        uint _m_DynamicBakeGradientCount = reader.ReadU32();
        bool _m_NeedsLocalToWorld = reader.ReadBool();
        bool _m_NeedsWorldToLocal = reader.ReadBool();
        bool _m_NeedsMainCamera = reader.ReadBool();
        reader.AlignTo(4); /* m_NeedsMainCamera */
        int _m_NeededMainCameraBuffers = reader.ReadS32();
        
        return new(_m_Expressions,
            _m_MaxCommonExpressionsIndex,
            _m_ConstantBakeCurveCount,
            _m_ConstantBakeGradientCount,
            _m_DynamicBakeCurveCount,
            _m_DynamicBakeGradientCount,
            _m_NeedsLocalToWorld,
            _m_NeedsWorldToLocal,
            _m_NeedsMainCamera,
            _m_NeededMainCameraBuffers);
    }

    public override string ToString() => $"VFXExpressionContainer\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Expressions: ");
        sb.AppendLine(m_Expressions.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MaxCommonExpressionsIndex: ");
        sb.AppendLine(m_MaxCommonExpressionsIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ConstantBakeCurveCount: ");
        sb.AppendLine(m_ConstantBakeCurveCount.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ConstantBakeGradientCount: ");
        sb.AppendLine(m_ConstantBakeGradientCount.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DynamicBakeCurveCount: ");
        sb.AppendLine(m_DynamicBakeCurveCount.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DynamicBakeGradientCount: ");
        sb.AppendLine(m_DynamicBakeGradientCount.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NeedsLocalToWorld: ");
        sb.AppendLine(m_NeedsLocalToWorld.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NeedsWorldToLocal: ");
        sb.AppendLine(m_NeedsWorldToLocal.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NeedsMainCamera: ");
        sb.AppendLine(m_NeedsMainCamera.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NeededMainCameraBuffers: ");
        sb.AppendLine(m_NeededMainCameraBuffers.ToString());

        return sb.ToString();
    }
}

/* $Expression (6 fields) */
public readonly record struct Expression(
    int op,
    int valueIndex,
    int data_0,
    int data_1,
    int data_2,
    int data_3) : IUnityStructure
{
    public static Expression Read(EndianBinaryReader reader)
    {
        int _op = reader.ReadS32();
        int _valueIndex = reader.ReadS32();
        int _data_0 = reader.ReadS32();
        int _data_1 = reader.ReadS32();
        int _data_2 = reader.ReadS32();
        int _data_3 = reader.ReadS32();
        
        return new(_op,
            _valueIndex,
            _data_0,
            _data_1,
            _data_2,
            _data_3);
    }

    public override string ToString() => $"Expression\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("op: ");
        sb.AppendLine(op.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("valueIndex: ");
        sb.AppendLine(valueIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data_0: ");
        sb.AppendLine(data_0.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data_1: ");
        sb.AppendLine(data_1.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data_2: ");
        sb.AppendLine(data_2.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data_3: ");
        sb.AppendLine(data_3.ToString());

        return sb.ToString();
    }
}

/* $VFXPropertySheetSerializedBase_1 (11 fields) */
public record class VFXPropertySheetSerializedBase_1(
    VFXField_11 m_Float,
    VFXField_12 m_Vector2f,
    VFXField_13 m_Vector3f,
    VFXField_14 m_Vector4f,
    VFXField_15 m_Uint,
    VFXField_16 m_Int,
    VFXField_17 m_Matrix4x4f,
    VFXField_18 m_AnimationCurve,
    VFXField_19 m_Gradient,
    VFXField_20 m_NamedObject,
    VFXField_21 m_Bool) : IUnityStructure
{
    public static VFXPropertySheetSerializedBase_1 Read(EndianBinaryReader reader)
    {
        VFXField_11 _m_Float = VFXField_11.Read(reader);
        reader.AlignTo(4); /* m_Float */
        VFXField_12 _m_Vector2f = VFXField_12.Read(reader);
        reader.AlignTo(4); /* m_Vector2f */
        VFXField_13 _m_Vector3f = VFXField_13.Read(reader);
        reader.AlignTo(4); /* m_Vector3f */
        VFXField_14 _m_Vector4f = VFXField_14.Read(reader);
        reader.AlignTo(4); /* m_Vector4f */
        VFXField_15 _m_Uint = VFXField_15.Read(reader);
        reader.AlignTo(4); /* m_Uint */
        VFXField_16 _m_Int = VFXField_16.Read(reader);
        reader.AlignTo(4); /* m_Int */
        VFXField_17 _m_Matrix4x4f = VFXField_17.Read(reader);
        reader.AlignTo(4); /* m_Matrix4x4f */
        VFXField_18 _m_AnimationCurve = VFXField_18.Read(reader);
        reader.AlignTo(4); /* m_AnimationCurve */
        VFXField_19 _m_Gradient = VFXField_19.Read(reader);
        reader.AlignTo(4); /* m_Gradient */
        VFXField_20 _m_NamedObject = VFXField_20.Read(reader);
        reader.AlignTo(4); /* m_NamedObject */
        VFXField_21 _m_Bool = VFXField_21.Read(reader);
        reader.AlignTo(4); /* m_Bool */
        
        return new(_m_Float,
            _m_Vector2f,
            _m_Vector3f,
            _m_Vector4f,
            _m_Uint,
            _m_Int,
            _m_Matrix4x4f,
            _m_AnimationCurve,
            _m_Gradient,
            _m_NamedObject,
            _m_Bool);
    }

    public override string ToString() => $"VFXPropertySheetSerializedBase_1\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Float: ");
        sb.AppendLine();
        sb.Append(m_Float.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Vector2f: ");
        sb.AppendLine();
        sb.Append(m_Vector2f.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Vector3f: ");
        sb.AppendLine();
        sb.Append(m_Vector3f.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Vector4f: ");
        sb.AppendLine();
        sb.Append(m_Vector4f.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Uint: ");
        sb.AppendLine();
        sb.Append(m_Uint.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Int: ");
        sb.AppendLine();
        sb.Append(m_Int.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Matrix4x4f: ");
        sb.AppendLine();
        sb.Append(m_Matrix4x4f.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AnimationCurve: ");
        sb.AppendLine();
        sb.Append(m_AnimationCurve.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Gradient: ");
        sb.AppendLine();
        sb.Append(m_Gradient.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NamedObject: ");
        sb.AppendLine();
        sb.Append(m_NamedObject.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Bool: ");
        sb.AppendLine();
        sb.Append(m_Bool.ToString(indent+4));

        return sb.ToString();
    }
}

/* $VFXField_11 (1 fields) */
public record class VFXField_11(
    VFXEntryExpressionValue_0[] m_Array) : IUnityStructure
{
    public static VFXField_11 Read(EndianBinaryReader reader)
    {
        VFXEntryExpressionValue_0[] _m_Array = BuiltInArray<VFXEntryExpressionValue_0>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(_m_Array);
    }

    public override string ToString() => $"VFXField_11\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Array: ");
        sb.AppendLine(m_Array.ToString());

        return sb.ToString();
    }
}

/* $VFXEntryExpressionValue_0 (2 fields) */
public readonly record struct VFXEntryExpressionValue_0(
    uint m_ExpressionIndex,
    float m_Value) : IUnityStructure
{
    public static VFXEntryExpressionValue_0 Read(EndianBinaryReader reader)
    {
        uint _m_ExpressionIndex = reader.ReadU32();
        float _m_Value = reader.ReadF32();
        reader.AlignTo(4); /* m_Value */
        
        return new(_m_ExpressionIndex,
            _m_Value);
    }

    public override string ToString() => $"VFXEntryExpressionValue_0\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ExpressionIndex: ");
        sb.AppendLine(m_ExpressionIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Value: ");
        sb.AppendLine(m_Value.ToString());

        return sb.ToString();
    }
}

/* $VFXField_12 (1 fields) */
public record class VFXField_12(
    VFXEntryExpressionValue_1[] m_Array) : IUnityStructure
{
    public static VFXField_12 Read(EndianBinaryReader reader)
    {
        VFXEntryExpressionValue_1[] _m_Array = BuiltInArray<VFXEntryExpressionValue_1>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(_m_Array);
    }

    public override string ToString() => $"VFXField_12\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Array: ");
        sb.AppendLine(m_Array.ToString());

        return sb.ToString();
    }
}

/* $VFXEntryExpressionValue_1 (2 fields) */
public record class VFXEntryExpressionValue_1(
    uint m_ExpressionIndex,
    Vector2f m_Value) : IUnityStructure
{
    public static VFXEntryExpressionValue_1 Read(EndianBinaryReader reader)
    {
        uint _m_ExpressionIndex = reader.ReadU32();
        Vector2f _m_Value = Vector2f.Read(reader);
        reader.AlignTo(4); /* m_Value */
        
        return new(_m_ExpressionIndex,
            _m_Value);
    }

    public override string ToString() => $"VFXEntryExpressionValue_1\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ExpressionIndex: ");
        sb.AppendLine(m_ExpressionIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Value: ");
        sb.AppendLine();
        sb.Append(m_Value.ToString(indent+4));

        return sb.ToString();
    }
}

/* $VFXField_13 (1 fields) */
public record class VFXField_13(
    VFXEntryExpressionValue_2[] m_Array) : IUnityStructure
{
    public static VFXField_13 Read(EndianBinaryReader reader)
    {
        VFXEntryExpressionValue_2[] _m_Array = BuiltInArray<VFXEntryExpressionValue_2>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(_m_Array);
    }

    public override string ToString() => $"VFXField_13\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Array: ");
        sb.AppendLine(m_Array.ToString());

        return sb.ToString();
    }
}

/* $VFXEntryExpressionValue_2 (2 fields) */
public record class VFXEntryExpressionValue_2(
    uint m_ExpressionIndex,
    Vector3f m_Value) : IUnityStructure
{
    public static VFXEntryExpressionValue_2 Read(EndianBinaryReader reader)
    {
        uint _m_ExpressionIndex = reader.ReadU32();
        Vector3f _m_Value = Vector3f.Read(reader);
        reader.AlignTo(4); /* m_Value */
        
        return new(_m_ExpressionIndex,
            _m_Value);
    }

    public override string ToString() => $"VFXEntryExpressionValue_2\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ExpressionIndex: ");
        sb.AppendLine(m_ExpressionIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Value: ");
        sb.AppendLine();
        sb.Append(m_Value.ToString(indent+4));

        return sb.ToString();
    }
}

/* $VFXField_14 (1 fields) */
public record class VFXField_14(
    VFXEntryExpressionValue_3[] m_Array) : IUnityStructure
{
    public static VFXField_14 Read(EndianBinaryReader reader)
    {
        VFXEntryExpressionValue_3[] _m_Array = BuiltInArray<VFXEntryExpressionValue_3>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(_m_Array);
    }

    public override string ToString() => $"VFXField_14\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Array: ");
        sb.AppendLine(m_Array.ToString());

        return sb.ToString();
    }
}

/* $VFXEntryExpressionValue_3 (2 fields) */
public record class VFXEntryExpressionValue_3(
    uint m_ExpressionIndex,
    Vector4f m_Value) : IUnityStructure
{
    public static VFXEntryExpressionValue_3 Read(EndianBinaryReader reader)
    {
        uint _m_ExpressionIndex = reader.ReadU32();
        Vector4f _m_Value = Vector4f.Read(reader);
        reader.AlignTo(4); /* m_Value */
        
        return new(_m_ExpressionIndex,
            _m_Value);
    }

    public override string ToString() => $"VFXEntryExpressionValue_3\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ExpressionIndex: ");
        sb.AppendLine(m_ExpressionIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Value: ");
        sb.AppendLine();
        sb.Append(m_Value.ToString(indent+4));

        return sb.ToString();
    }
}

/* $VFXField_15 (1 fields) */
public record class VFXField_15(
    VFXEntryExpressionValue_4[] m_Array) : IUnityStructure
{
    public static VFXField_15 Read(EndianBinaryReader reader)
    {
        VFXEntryExpressionValue_4[] _m_Array = BuiltInArray<VFXEntryExpressionValue_4>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(_m_Array);
    }

    public override string ToString() => $"VFXField_15\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Array: ");
        sb.AppendLine(m_Array.ToString());

        return sb.ToString();
    }
}

/* $VFXEntryExpressionValue_4 (2 fields) */
public readonly record struct VFXEntryExpressionValue_4(
    uint m_ExpressionIndex,
    uint m_Value) : IUnityStructure
{
    public static VFXEntryExpressionValue_4 Read(EndianBinaryReader reader)
    {
        uint _m_ExpressionIndex = reader.ReadU32();
        uint _m_Value = reader.ReadU32();
        reader.AlignTo(4); /* m_Value */
        
        return new(_m_ExpressionIndex,
            _m_Value);
    }

    public override string ToString() => $"VFXEntryExpressionValue_4\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ExpressionIndex: ");
        sb.AppendLine(m_ExpressionIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Value: ");
        sb.AppendLine(m_Value.ToString());

        return sb.ToString();
    }
}

/* $VFXField_16 (1 fields) */
public record class VFXField_16(
    VFXEntryExpressionValue_5[] m_Array) : IUnityStructure
{
    public static VFXField_16 Read(EndianBinaryReader reader)
    {
        VFXEntryExpressionValue_5[] _m_Array = BuiltInArray<VFXEntryExpressionValue_5>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(_m_Array);
    }

    public override string ToString() => $"VFXField_16\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Array: ");
        sb.AppendLine(m_Array.ToString());

        return sb.ToString();
    }
}

/* $VFXEntryExpressionValue_5 (2 fields) */
public readonly record struct VFXEntryExpressionValue_5(
    uint m_ExpressionIndex,
    int m_Value) : IUnityStructure
{
    public static VFXEntryExpressionValue_5 Read(EndianBinaryReader reader)
    {
        uint _m_ExpressionIndex = reader.ReadU32();
        int _m_Value = reader.ReadS32();
        reader.AlignTo(4); /* m_Value */
        
        return new(_m_ExpressionIndex,
            _m_Value);
    }

    public override string ToString() => $"VFXEntryExpressionValue_5\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ExpressionIndex: ");
        sb.AppendLine(m_ExpressionIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Value: ");
        sb.AppendLine(m_Value.ToString());

        return sb.ToString();
    }
}

/* $VFXField_17 (1 fields) */
public record class VFXField_17(
    VFXEntryExpressionValue_6[] m_Array) : IUnityStructure
{
    public static VFXField_17 Read(EndianBinaryReader reader)
    {
        VFXEntryExpressionValue_6[] _m_Array = BuiltInArray<VFXEntryExpressionValue_6>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(_m_Array);
    }

    public override string ToString() => $"VFXField_17\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Array: ");
        sb.AppendLine(m_Array.ToString());

        return sb.ToString();
    }
}

/* $VFXEntryExpressionValue_6 (2 fields) */
public record class VFXEntryExpressionValue_6(
    uint m_ExpressionIndex,
    Matrix4x4f m_Value) : IUnityStructure
{
    public static VFXEntryExpressionValue_6 Read(EndianBinaryReader reader)
    {
        uint _m_ExpressionIndex = reader.ReadU32();
        Matrix4x4f _m_Value = Matrix4x4f.Read(reader);
        reader.AlignTo(4); /* m_Value */
        
        return new(_m_ExpressionIndex,
            _m_Value);
    }

    public override string ToString() => $"VFXEntryExpressionValue_6\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ExpressionIndex: ");
        sb.AppendLine(m_ExpressionIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Value: ");
        sb.AppendLine();
        sb.Append(m_Value.ToString(indent+4));

        return sb.ToString();
    }
}

/* $VFXField_18 (1 fields) */
public record class VFXField_18(
    VFXEntryExpressionValue_7[] m_Array) : IUnityStructure
{
    public static VFXField_18 Read(EndianBinaryReader reader)
    {
        VFXEntryExpressionValue_7[] _m_Array = BuiltInArray<VFXEntryExpressionValue_7>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(_m_Array);
    }

    public override string ToString() => $"VFXField_18\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Array: ");
        sb.AppendLine(m_Array.ToString());

        return sb.ToString();
    }
}

/* $VFXEntryExpressionValue_7 (2 fields) */
public record class VFXEntryExpressionValue_7(
    uint m_ExpressionIndex,
    AnimationCurve_0 m_Value) : IUnityStructure
{
    public static VFXEntryExpressionValue_7 Read(EndianBinaryReader reader)
    {
        uint _m_ExpressionIndex = reader.ReadU32();
        AnimationCurve_0 _m_Value = AnimationCurve_0.Read(reader);
        reader.AlignTo(4); /* m_Value */
        
        return new(_m_ExpressionIndex,
            _m_Value);
    }

    public override string ToString() => $"VFXEntryExpressionValue_7\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ExpressionIndex: ");
        sb.AppendLine(m_ExpressionIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Value: ");
        sb.AppendLine();
        sb.Append(m_Value.ToString(indent+4));

        return sb.ToString();
    }
}

/* $VFXField_19 (1 fields) */
public record class VFXField_19(
    VFXEntryExpressionValue_8[] m_Array) : IUnityStructure
{
    public static VFXField_19 Read(EndianBinaryReader reader)
    {
        VFXEntryExpressionValue_8[] _m_Array = BuiltInArray<VFXEntryExpressionValue_8>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(_m_Array);
    }

    public override string ToString() => $"VFXField_19\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Array: ");
        sb.AppendLine(m_Array.ToString());

        return sb.ToString();
    }
}

/* $VFXEntryExpressionValue_8 (2 fields) */
public record class VFXEntryExpressionValue_8(
    uint m_ExpressionIndex,
    Gradient m_Value) : IUnityStructure
{
    public static VFXEntryExpressionValue_8 Read(EndianBinaryReader reader)
    {
        uint _m_ExpressionIndex = reader.ReadU32();
        Gradient _m_Value = Gradient.Read(reader);
        reader.AlignTo(4); /* m_Value */
        
        return new(_m_ExpressionIndex,
            _m_Value);
    }

    public override string ToString() => $"VFXEntryExpressionValue_8\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ExpressionIndex: ");
        sb.AppendLine(m_ExpressionIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Value: ");
        sb.AppendLine();
        sb.Append(m_Value.ToString(indent+4));

        return sb.ToString();
    }
}

/* $VFXField_20 (1 fields) */
public record class VFXField_20(
    VFXEntryExpressionValue_9[] m_Array) : IUnityStructure
{
    public static VFXField_20 Read(EndianBinaryReader reader)
    {
        VFXEntryExpressionValue_9[] _m_Array = BuiltInArray<VFXEntryExpressionValue_9>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(_m_Array);
    }

    public override string ToString() => $"VFXField_20\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Array: ");
        sb.AppendLine(m_Array.ToString());

        return sb.ToString();
    }
}

/* $VFXEntryExpressionValue_9 (2 fields) */
public record class VFXEntryExpressionValue_9(
    uint m_ExpressionIndex,
    PPtr<Object> m_Value) : IUnityStructure
{
    public static VFXEntryExpressionValue_9 Read(EndianBinaryReader reader)
    {
        uint _m_ExpressionIndex = reader.ReadU32();
        PPtr<Object> _m_Value = PPtr<Object>.Read(reader);
        reader.AlignTo(4); /* m_Value */
        
        return new(_m_ExpressionIndex,
            _m_Value);
    }

    public override string ToString() => $"VFXEntryExpressionValue_9\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ExpressionIndex: ");
        sb.AppendLine(m_ExpressionIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Value: ");
        sb.AppendLine(m_Value.ToString());

        return sb.ToString();
    }
}

/* $VFXField_21 (1 fields) */
public record class VFXField_21(
    VFXEntryExpressionValue_10[] m_Array) : IUnityStructure
{
    public static VFXField_21 Read(EndianBinaryReader reader)
    {
        VFXEntryExpressionValue_10[] _m_Array = BuiltInArray<VFXEntryExpressionValue_10>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(_m_Array);
    }

    public override string ToString() => $"VFXField_21\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Array: ");
        sb.AppendLine(m_Array.ToString());

        return sb.ToString();
    }
}

/* $VFXEntryExpressionValue_10 (2 fields) */
public readonly record struct VFXEntryExpressionValue_10(
    uint m_ExpressionIndex,
    bool m_Value) : IUnityStructure
{
    public static VFXEntryExpressionValue_10 Read(EndianBinaryReader reader)
    {
        uint _m_ExpressionIndex = reader.ReadU32();
        bool _m_Value = reader.ReadBool();
        reader.AlignTo(4); /* m_Value */
        
        return new(_m_ExpressionIndex,
            _m_Value);
    }

    public override string ToString() => $"VFXEntryExpressionValue_10\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ExpressionIndex: ");
        sb.AppendLine(m_ExpressionIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Value: ");
        sb.AppendLine(m_Value.ToString());

        return sb.ToString();
    }
}

/* $VFXMapping (2 fields) */
public record class VFXMapping(
    AsciiString nameId,
    int index) : IUnityStructure
{
    public static VFXMapping Read(EndianBinaryReader reader)
    {
        AsciiString _nameId = BuiltInString.Read(reader);
        reader.AlignTo(4); /* nameId */
        int _index = reader.ReadS32();
        
        return new(_nameId,
            _index);
    }

    public override string ToString() => $"VFXMapping\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("nameId: ");
        sb.AppendLine(nameId.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("index: ");
        sb.AppendLine(index.ToString());

        return sb.ToString();
    }
}

/* $VFXGPUBufferDesc (5 fields) */
public record class VFXGPUBufferDesc(
    int type,
    uint size,
    VFXLayoutElementDesc[] layout,
    uint capacity,
    uint stride) : IUnityStructure
{
    public static VFXGPUBufferDesc Read(EndianBinaryReader reader)
    {
        int _type = reader.ReadS32();
        uint _size = reader.ReadU32();
        VFXLayoutElementDesc[] _layout = BuiltInArray<VFXLayoutElementDesc>.Read(reader);
        reader.AlignTo(4); /* layout */
        uint _capacity = reader.ReadU32();
        uint _stride = reader.ReadU32();
        
        return new(_type,
            _size,
            _layout,
            _capacity,
            _stride);
    }

    public override string ToString() => $"VFXGPUBufferDesc\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("type: ");
        sb.AppendLine(type.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("size: ");
        sb.AppendLine(size.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("layout: ");
        sb.AppendLine(layout.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("capacity: ");
        sb.AppendLine(capacity.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("stride: ");
        sb.AppendLine(stride.ToString());

        return sb.ToString();
    }
}

/* $VFXLayoutElementDesc (3 fields) */
public record class VFXLayoutElementDesc(
    AsciiString name,
    int type,
    VFXLayoutOffset offset) : IUnityStructure
{
    public static VFXLayoutElementDesc Read(EndianBinaryReader reader)
    {
        AsciiString _name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* name */
        int _type = reader.ReadS32();
        VFXLayoutOffset _offset = VFXLayoutOffset.Read(reader);
        
        return new(_name,
            _type,
            _offset);
    }

    public override string ToString() => $"VFXLayoutElementDesc\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("name: ");
        sb.AppendLine(name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("type: ");
        sb.AppendLine(type.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("offset: ");
        sb.AppendLine();
        sb.Append(offset.ToString(indent+4));

        return sb.ToString();
    }
}

/* $VFXLayoutOffset (3 fields) */
public readonly record struct VFXLayoutOffset(
    uint bucket,
    uint structure,
    uint element) : IUnityStructure
{
    public static VFXLayoutOffset Read(EndianBinaryReader reader)
    {
        uint _bucket = reader.ReadU32();
        uint _structure = reader.ReadU32();
        uint _element = reader.ReadU32();
        
        return new(_bucket,
            _structure,
            _element);
    }

    public override string ToString() => $"VFXLayoutOffset\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("bucket: ");
        sb.AppendLine(bucket.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("structure: ");
        sb.AppendLine(structure.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("element: ");
        sb.AppendLine(element.ToString());

        return sb.ToString();
    }
}

/* $VFXTemporaryGPUBufferDesc (2 fields) */
public record class VFXTemporaryGPUBufferDesc(
    VFXGPUBufferDesc desc,
    uint frameCount) : IUnityStructure
{
    public static VFXTemporaryGPUBufferDesc Read(EndianBinaryReader reader)
    {
        VFXGPUBufferDesc _desc = VFXGPUBufferDesc.Read(reader);
        reader.AlignTo(4); /* desc */
        uint _frameCount = reader.ReadU32();
        
        return new(_desc,
            _frameCount);
    }

    public override string ToString() => $"VFXTemporaryGPUBufferDesc\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("desc: ");
        sb.AppendLine();
        sb.Append(desc.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("frameCount: ");
        sb.AppendLine(frameCount.ToString());

        return sb.ToString();
    }
}

/* $VFXCPUBufferDesc (4 fields) */
public record class VFXCPUBufferDesc(
    uint capacity,
    uint stride,
    VFXLayoutElementDesc[] layout,
    VFXCPUBufferData initialData) : IUnityStructure
{
    public static VFXCPUBufferDesc Read(EndianBinaryReader reader)
    {
        uint _capacity = reader.ReadU32();
        uint _stride = reader.ReadU32();
        VFXLayoutElementDesc[] _layout = BuiltInArray<VFXLayoutElementDesc>.Read(reader);
        reader.AlignTo(4); /* layout */
        VFXCPUBufferData _initialData = VFXCPUBufferData.Read(reader);
        reader.AlignTo(4); /* initialData */
        
        return new(_capacity,
            _stride,
            _layout,
            _initialData);
    }

    public override string ToString() => $"VFXCPUBufferDesc\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("capacity: ");
        sb.AppendLine(capacity.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("stride: ");
        sb.AppendLine(stride.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("layout: ");
        sb.AppendLine(layout.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("initialData: ");
        sb.AppendLine();
        sb.Append(initialData.ToString(indent+4));

        return sb.ToString();
    }
}

/* $VFXCPUBufferData (1 fields) */
public record class VFXCPUBufferData(
    uint[] data) : IUnityStructure
{
    public static VFXCPUBufferData Read(EndianBinaryReader reader)
    {
        uint[] _data = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* data */
        
        return new(_data);
    }

    public override string ToString() => $"VFXCPUBufferData\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data: ");
        sb.AppendLine(data.ToString());

        return sb.ToString();
    }
}

/* $VFXEventDesc (4 fields) */
public record class VFXEventDesc(
    AsciiString name,
    uint[] playSystems,
    uint[] stopSystems,
    uint[] initSystems) : IUnityStructure
{
    public static VFXEventDesc Read(EndianBinaryReader reader)
    {
        AsciiString _name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* name */
        uint[] _playSystems = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* playSystems */
        uint[] _stopSystems = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* stopSystems */
        uint[] _initSystems = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* initSystems */
        
        return new(_name,
            _playSystems,
            _stopSystems,
            _initSystems);
    }

    public override string ToString() => $"VFXEventDesc\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("name: ");
        sb.AppendLine(name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("playSystems: ");
        sb.AppendLine(playSystems.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("stopSystems: ");
        sb.AppendLine(stopSystems.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("initSystems: ");
        sb.AppendLine(initSystems.ToString());

        return sb.ToString();
    }
}

/* $VFXSystemDesc (9 fields) */
public record class VFXSystemDesc(
    int type,
    int flags,
    uint capacity,
    uint layer,
    AsciiString name,
    VFXMapping[] buffers,
    VFXMapping[] values,
    VFXTaskDesc[] tasks,
    VFXInstanceSplitDesc[] instanceSplitDescs) : IUnityStructure
{
    public static VFXSystemDesc Read(EndianBinaryReader reader)
    {
        int _type = reader.ReadS32();
        int _flags = reader.ReadS32();
        uint _capacity = reader.ReadU32();
        uint _layer = reader.ReadU32();
        AsciiString _name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* name */
        VFXMapping[] _buffers = BuiltInArray<VFXMapping>.Read(reader);
        reader.AlignTo(4); /* buffers */
        VFXMapping[] _values = BuiltInArray<VFXMapping>.Read(reader);
        reader.AlignTo(4); /* values */
        VFXTaskDesc[] _tasks = BuiltInArray<VFXTaskDesc>.Read(reader);
        reader.AlignTo(4); /* tasks */
        VFXInstanceSplitDesc[] _instanceSplitDescs = BuiltInArray<VFXInstanceSplitDesc>.Read(reader);
        reader.AlignTo(4); /* instanceSplitDescs */
        
        return new(_type,
            _flags,
            _capacity,
            _layer,
            _name,
            _buffers,
            _values,
            _tasks,
            _instanceSplitDescs);
    }

    public override string ToString() => $"VFXSystemDesc\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("type: ");
        sb.AppendLine(type.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("flags: ");
        sb.AppendLine(flags.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("capacity: ");
        sb.AppendLine(capacity.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("layer: ");
        sb.AppendLine(layer.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("name: ");
        sb.AppendLine(name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("buffers: ");
        sb.AppendLine(buffers.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("values: ");
        sb.AppendLine(values.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("tasks: ");
        sb.AppendLine(tasks.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("instanceSplitDescs: ");
        sb.AppendLine(instanceSplitDescs.ToString());

        return sb.ToString();
    }
}

/* $VFXTaskDesc (7 fields) */
public record class VFXTaskDesc(
    int type,
    VFXMapping[] buffers,
    VFXMappingTemporary[] temporaryBuffers,
    VFXMapping[] values,
    VFXMapping[] @params,
    PPtr<NamedObject> processor,
    uint instanceSplitIndex) : IUnityStructure
{
    public static VFXTaskDesc Read(EndianBinaryReader reader)
    {
        int _type = reader.ReadS32();
        VFXMapping[] _buffers = BuiltInArray<VFXMapping>.Read(reader);
        reader.AlignTo(4); /* buffers */
        VFXMappingTemporary[] _temporaryBuffers = BuiltInArray<VFXMappingTemporary>.Read(reader);
        reader.AlignTo(4); /* temporaryBuffers */
        VFXMapping[] _values = BuiltInArray<VFXMapping>.Read(reader);
        reader.AlignTo(4); /* values */
        VFXMapping[] _params = BuiltInArray<VFXMapping>.Read(reader);
        reader.AlignTo(4); /* @params */
        PPtr<NamedObject> _processor = PPtr<NamedObject>.Read(reader);
        uint _instanceSplitIndex = reader.ReadU32();
        
        return new(_type,
            _buffers,
            _temporaryBuffers,
            _values,
            _params,
            _processor,
            _instanceSplitIndex);
    }

    public override string ToString() => $"VFXTaskDesc\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("type: ");
        sb.AppendLine(type.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("buffers: ");
        sb.AppendLine(buffers.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("temporaryBuffers: ");
        sb.AppendLine(temporaryBuffers.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("values: ");
        sb.AppendLine(values.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("@params: ");
        sb.AppendLine(@params.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("processor: ");
        sb.AppendLine(processor.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("instanceSplitIndex: ");
        sb.AppendLine(instanceSplitIndex.ToString());

        return sb.ToString();
    }
}

/* $VFXMappingTemporary (3 fields) */
public record class VFXMappingTemporary(
    VFXMapping mapping,
    uint pastFrameIndex,
    bool perCameraBuffer) : IUnityStructure
{
    public static VFXMappingTemporary Read(EndianBinaryReader reader)
    {
        VFXMapping _mapping = VFXMapping.Read(reader);
        reader.AlignTo(4); /* mapping */
        uint _pastFrameIndex = reader.ReadU32();
        bool _perCameraBuffer = reader.ReadBool();
        reader.AlignTo(4); /* perCameraBuffer */
        
        return new(_mapping,
            _pastFrameIndex,
            _perCameraBuffer);
    }

    public override string ToString() => $"VFXMappingTemporary\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("mapping: ");
        sb.AppendLine();
        sb.Append(mapping.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("pastFrameIndex: ");
        sb.AppendLine(pastFrameIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("perCameraBuffer: ");
        sb.AppendLine(perCameraBuffer.ToString());

        return sb.ToString();
    }
}

/* $VFXInstanceSplitDesc (1 fields) */
public record class VFXInstanceSplitDesc(
    uint[] values) : IUnityStructure
{
    public static VFXInstanceSplitDesc Read(EndianBinaryReader reader)
    {
        uint[] _values = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* values */
        
        return new(_values);
    }

    public override string ToString() => $"VFXInstanceSplitDesc\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("values: ");
        sb.AppendLine(values.ToString());

        return sb.ToString();
    }
}

/* $LineParameters (10 fields) */
public record class LineParameters(
    float widthMultiplier,
    AnimationCurve_0 widthCurve,
    Gradient colorGradient,
    int numCornerVertices,
    int numCapVertices,
    int alignment,
    int textureMode,
    Vector2f textureScale,
    float shadowBias,
    bool generateLightingData) : IUnityStructure
{
    public static LineParameters Read(EndianBinaryReader reader)
    {
        float _widthMultiplier = reader.ReadF32();
        AnimationCurve_0 _widthCurve = AnimationCurve_0.Read(reader);
        reader.AlignTo(4); /* widthCurve */
        Gradient _colorGradient = Gradient.Read(reader);
        reader.AlignTo(4); /* colorGradient */
        int _numCornerVertices = reader.ReadS32();
        int _numCapVertices = reader.ReadS32();
        int _alignment = reader.ReadS32();
        int _textureMode = reader.ReadS32();
        Vector2f _textureScale = Vector2f.Read(reader);
        float _shadowBias = reader.ReadF32();
        bool _generateLightingData = reader.ReadBool();
        reader.AlignTo(4); /* generateLightingData */
        
        return new(_widthMultiplier,
            _widthCurve,
            _colorGradient,
            _numCornerVertices,
            _numCapVertices,
            _alignment,
            _textureMode,
            _textureScale,
            _shadowBias,
            _generateLightingData);
    }

    public override string ToString() => $"LineParameters\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("widthMultiplier: ");
        sb.AppendLine(widthMultiplier.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("widthCurve: ");
        sb.AppendLine();
        sb.Append(widthCurve.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("colorGradient: ");
        sb.AppendLine();
        sb.Append(colorGradient.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("numCornerVertices: ");
        sb.AppendLine(numCornerVertices.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("numCapVertices: ");
        sb.AppendLine(numCapVertices.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("alignment: ");
        sb.AppendLine(alignment.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("textureMode: ");
        sb.AppendLine(textureMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("textureScale: ");
        sb.AppendLine();
        sb.Append(textureScale.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("shadowBias: ");
        sb.AppendLine(shadowBias.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("generateLightingData: ");
        sb.AppendLine(generateLightingData.ToString());

        return sb.ToString();
    }
}

/* $ComputeShaderPlatformVariant (5 fields) */
public record class ComputeShaderPlatformVariant(
    int targetRenderer,
    int targetLevel,
    ComputeShaderKernelParent[] kernels,
    ComputeShaderCB[] constantBuffers,
    bool resourcesResolved) : IUnityStructure
{
    public static ComputeShaderPlatformVariant Read(EndianBinaryReader reader)
    {
        int _targetRenderer = reader.ReadS32();
        int _targetLevel = reader.ReadS32();
        ComputeShaderKernelParent[] _kernels = BuiltInArray<ComputeShaderKernelParent>.Read(reader);
        reader.AlignTo(4); /* kernels */
        ComputeShaderCB[] _constantBuffers = BuiltInArray<ComputeShaderCB>.Read(reader);
        reader.AlignTo(4); /* constantBuffers */
        bool _resourcesResolved = reader.ReadBool();
        reader.AlignTo(4); /* resourcesResolved */
        
        return new(_targetRenderer,
            _targetLevel,
            _kernels,
            _constantBuffers,
            _resourcesResolved);
    }

    public override string ToString() => $"ComputeShaderPlatformVariant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("targetRenderer: ");
        sb.AppendLine(targetRenderer.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("targetLevel: ");
        sb.AppendLine(targetLevel.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("kernels: ");
        sb.AppendLine(kernels.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("constantBuffers: ");
        sb.AppendLine(constantBuffers.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("resourcesResolved: ");
        sb.AppendLine(resourcesResolved.ToString());

        return sb.ToString();
    }
}

/* $ComputeShaderKernelParent (6 fields) */
public record class ComputeShaderKernelParent(
    AsciiString name,
    ComputeShaderKernel[] uniqueVariants,
    pair_2[] variantIndices,
    AsciiString[] globalKeywords,
    AsciiString[] localKeywords,
    AsciiString[] dynamicKeywords) : IUnityStructure
{
    public static ComputeShaderKernelParent Read(EndianBinaryReader reader)
    {
        AsciiString _name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* name */
        ComputeShaderKernel[] _uniqueVariants = BuiltInArray<ComputeShaderKernel>.Read(reader);
        reader.AlignTo(4); /* uniqueVariants */
        pair_2[] _variantIndices = BuiltInArray<pair_2>.Read(reader);
        reader.AlignTo(4); /* variantIndices */
        AsciiString[] _globalKeywords = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* globalKeywords */
        AsciiString[] _localKeywords = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* localKeywords */
        AsciiString[] _dynamicKeywords = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* dynamicKeywords */
        
        return new(_name,
            _uniqueVariants,
            _variantIndices,
            _globalKeywords,
            _localKeywords,
            _dynamicKeywords);
    }

    public override string ToString() => $"ComputeShaderKernelParent\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("name: ");
        sb.AppendLine(name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("uniqueVariants: ");
        sb.AppendLine(uniqueVariants.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("variantIndices: ");
        sb.AppendLine(variantIndices.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("globalKeywords: ");
        sb.AppendLine(globalKeywords.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("localKeywords: ");
        sb.AppendLine(localKeywords.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("dynamicKeywords: ");
        sb.AppendLine(dynamicKeywords.ToString());

        return sb.ToString();
    }
}

/* $ComputeShaderKernel (9 fields) */
public record class ComputeShaderKernel(
    uint[] cbVariantIndices,
    ComputeShaderResource[] cbs,
    ComputeShaderResource[] textures,
    ComputeShaderBuiltinSampler[] builtinSamplers,
    ComputeShaderResource[] inBuffers,
    ComputeShaderResource[] outBuffers,
    byte[] code,
    uint[] threadGroupSize,
    long requirements) : IUnityStructure
{
    public static ComputeShaderKernel Read(EndianBinaryReader reader)
    {
        uint[] _cbVariantIndices = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* cbVariantIndices */
        ComputeShaderResource[] _cbs = BuiltInArray<ComputeShaderResource>.Read(reader);
        reader.AlignTo(4); /* cbs */
        ComputeShaderResource[] _textures = BuiltInArray<ComputeShaderResource>.Read(reader);
        reader.AlignTo(4); /* textures */
        ComputeShaderBuiltinSampler[] _builtinSamplers = BuiltInArray<ComputeShaderBuiltinSampler>.Read(reader);
        reader.AlignTo(4); /* builtinSamplers */
        ComputeShaderResource[] _inBuffers = BuiltInArray<ComputeShaderResource>.Read(reader);
        reader.AlignTo(4); /* inBuffers */
        ComputeShaderResource[] _outBuffers = BuiltInArray<ComputeShaderResource>.Read(reader);
        reader.AlignTo(4); /* outBuffers */
        byte[] _code = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* code */
        uint[] _threadGroupSize = BuiltInArray<uint>.Read(reader);
        long _requirements = reader.ReadS64();
        
        return new(_cbVariantIndices,
            _cbs,
            _textures,
            _builtinSamplers,
            _inBuffers,
            _outBuffers,
            _code,
            _threadGroupSize,
            _requirements);
    }

    public override string ToString() => $"ComputeShaderKernel\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("cbVariantIndices: ");
        sb.AppendLine(cbVariantIndices.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("cbs: ");
        sb.AppendLine(cbs.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("textures: ");
        sb.AppendLine(textures.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("builtinSamplers: ");
        sb.AppendLine(builtinSamplers.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("inBuffers: ");
        sb.AppendLine(inBuffers.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("outBuffers: ");
        sb.AppendLine(outBuffers.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("code: ");
        sb.AppendLine(code.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("threadGroupSize: ");
        sb.AppendLine(threadGroupSize.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("requirements: ");
        sb.AppendLine(requirements.ToString());

        return sb.ToString();
    }
}

/* $ComputeShaderResource (5 fields) */
public record class ComputeShaderResource(
    AsciiString name,
    AsciiString generatedName,
    int bindPoint,
    int samplerBindPoint,
    int texDimension) : IUnityStructure
{
    public static ComputeShaderResource Read(EndianBinaryReader reader)
    {
        AsciiString _name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* name */
        AsciiString _generatedName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* generatedName */
        int _bindPoint = reader.ReadS32();
        int _samplerBindPoint = reader.ReadS32();
        int _texDimension = reader.ReadS32();
        
        return new(_name,
            _generatedName,
            _bindPoint,
            _samplerBindPoint,
            _texDimension);
    }

    public override string ToString() => $"ComputeShaderResource\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("name: ");
        sb.AppendLine(name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("generatedName: ");
        sb.AppendLine(generatedName.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("bindPoint: ");
        sb.AppendLine(bindPoint.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("samplerBindPoint: ");
        sb.AppendLine(samplerBindPoint.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("texDimension: ");
        sb.AppendLine(texDimension.ToString());

        return sb.ToString();
    }
}

/* $ComputeShaderBuiltinSampler (2 fields) */
public readonly record struct ComputeShaderBuiltinSampler(
    uint sampler,
    int bindPoint) : IUnityStructure
{
    public static ComputeShaderBuiltinSampler Read(EndianBinaryReader reader)
    {
        uint _sampler = reader.ReadU32();
        int _bindPoint = reader.ReadS32();
        
        return new(_sampler,
            _bindPoint);
    }

    public override string ToString() => $"ComputeShaderBuiltinSampler\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sampler: ");
        sb.AppendLine(sampler.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("bindPoint: ");
        sb.AppendLine(bindPoint.ToString());

        return sb.ToString();
    }
}

/* $pair_2 (2 fields) */
public record class pair_2(
    AsciiString first,
    uint second) : IUnityStructure
{
    public static pair_2 Read(EndianBinaryReader reader)
    {
        AsciiString _first = BuiltInString.Read(reader);
        reader.AlignTo(4); /* first */
        uint _second = reader.ReadU32();
        
        return new(_first,
            _second);
    }

    public override string ToString() => $"pair_2\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("first: ");
        sb.AppendLine(first.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("second: ");
        sb.AppendLine(second.ToString());

        return sb.ToString();
    }
}

/* $ComputeShaderCB (3 fields) */
public record class ComputeShaderCB(
    AsciiString name,
    int byteSize,
    ComputeShaderParam[] @params) : IUnityStructure
{
    public static ComputeShaderCB Read(EndianBinaryReader reader)
    {
        AsciiString _name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* name */
        int _byteSize = reader.ReadS32();
        ComputeShaderParam[] _params = BuiltInArray<ComputeShaderParam>.Read(reader);
        reader.AlignTo(4); /* @params */
        
        return new(_name,
            _byteSize,
            _params);
    }

    public override string ToString() => $"ComputeShaderCB\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("name: ");
        sb.AppendLine(name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("byteSize: ");
        sb.AppendLine(byteSize.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("@params: ");
        sb.AppendLine(@params.ToString());

        return sb.ToString();
    }
}

/* $ComputeShaderParam (6 fields) */
public record class ComputeShaderParam(
    AsciiString name,
    int type,
    uint offset,
    uint arraySize,
    uint rowCount,
    uint colCount) : IUnityStructure
{
    public static ComputeShaderParam Read(EndianBinaryReader reader)
    {
        AsciiString _name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* name */
        int _type = reader.ReadS32();
        uint _offset = reader.ReadU32();
        uint _arraySize = reader.ReadU32();
        uint _rowCount = reader.ReadU32();
        uint _colCount = reader.ReadU32();
        
        return new(_name,
            _type,
            _offset,
            _arraySize,
            _rowCount,
            _colCount);
    }

    public override string ToString() => $"ComputeShaderParam\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("name: ");
        sb.AppendLine(name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("type: ");
        sb.AppendLine(type.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("offset: ");
        sb.AppendLine(offset.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("arraySize: ");
        sb.AppendLine(arraySize.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("rowCount: ");
        sb.AppendLine(rowCount.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("colCount: ");
        sb.AppendLine(colCount.ToString());

        return sb.ToString();
    }
}

/* $UnityPropertySheet (4 fields) */
public record class UnityPropertySheet(
    Dictionary<AsciiString, UnityTexEnv> m_TexEnvs,
    Dictionary<AsciiString, int> m_Ints,
    Dictionary<AsciiString, float> m_Floats,
    Dictionary<AsciiString, ColorRGBA_0> m_Colors) : IUnityStructure
{
    public static UnityPropertySheet Read(EndianBinaryReader reader)
    {
        Dictionary<AsciiString, UnityTexEnv> _m_TexEnvs = BuiltInMap<AsciiString, UnityTexEnv>.Read(reader);
        reader.AlignTo(4); /* m_TexEnvs */
        Dictionary<AsciiString, int> _m_Ints = BuiltInMap<AsciiString, int>.Read(reader);
        reader.AlignTo(4); /* m_Ints */
        Dictionary<AsciiString, float> _m_Floats = BuiltInMap<AsciiString, float>.Read(reader);
        reader.AlignTo(4); /* m_Floats */
        Dictionary<AsciiString, ColorRGBA_0> _m_Colors = BuiltInMap<AsciiString, ColorRGBA_0>.Read(reader);
        reader.AlignTo(4); /* m_Colors */
        
        return new(_m_TexEnvs,
            _m_Ints,
            _m_Floats,
            _m_Colors);
    }

    public override string ToString() => $"UnityPropertySheet\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TexEnvs: ");
        sb.AppendLine(m_TexEnvs.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Ints: ");
        sb.AppendLine(m_Ints.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Floats: ");
        sb.AppendLine(m_Floats.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Colors: ");
        sb.AppendLine(m_Colors.ToString());

        return sb.ToString();
    }
}

/* $UnityTexEnv (3 fields) */
public record class UnityTexEnv(
    PPtr<Texture> m_Texture,
    Vector2f m_Scale,
    Vector2f m_Offset) : IUnityStructure
{
    public static UnityTexEnv Read(EndianBinaryReader reader)
    {
        PPtr<Texture> _m_Texture = PPtr<Texture>.Read(reader);
        Vector2f _m_Scale = Vector2f.Read(reader);
        Vector2f _m_Offset = Vector2f.Read(reader);
        
        return new(_m_Texture,
            _m_Scale,
            _m_Offset);
    }

    public override string ToString() => $"UnityTexEnv\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Texture: ");
        sb.AppendLine(m_Texture.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Scale: ");
        sb.AppendLine();
        sb.Append(m_Scale.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Offset: ");
        sb.AppendLine();
        sb.Append(m_Offset.ToString(indent+4));

        return sb.ToString();
    }
}

/* $BuildTextureStackReference (2 fields) */
public record class BuildTextureStackReference(
    AsciiString groupName,
    AsciiString itemName) : IUnityStructure
{
    public static BuildTextureStackReference Read(EndianBinaryReader reader)
    {
        AsciiString _groupName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* groupName */
        AsciiString _itemName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* itemName */
        
        return new(_groupName,
            _itemName);
    }

    public override string ToString() => $"BuildTextureStackReference\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("groupName: ");
        sb.AppendLine(groupName.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("itemName: ");
        sb.AppendLine(itemName.ToString());

        return sb.ToString();
    }
}

/* $ComponentPair (1 fields) */
public record class ComponentPair(
    PPtr<Component> component) : IUnityStructure
{
    public static ComponentPair Read(EndianBinaryReader reader)
    {
        PPtr<Component> _component = PPtr<Component>.Read(reader);
        
        return new(_component);
    }

    public override string ToString() => $"ComponentPair\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("component: ");
        sb.AppendLine(component.ToString());

        return sb.ToString();
    }
}

/* $ShadowSettings (9 fields) */
public record class ShadowSettings(
    int m_Type,
    int m_Resolution,
    int m_CustomResolution,
    float m_Strength,
    float m_Bias,
    float m_NormalBias,
    float m_NearPlane,
    Matrix4x4f m_CullingMatrixOverride,
    bool m_UseCullingMatrixOverride) : IUnityStructure
{
    public static ShadowSettings Read(EndianBinaryReader reader)
    {
        int _m_Type = reader.ReadS32();
        int _m_Resolution = reader.ReadS32();
        int _m_CustomResolution = reader.ReadS32();
        float _m_Strength = reader.ReadF32();
        float _m_Bias = reader.ReadF32();
        float _m_NormalBias = reader.ReadF32();
        float _m_NearPlane = reader.ReadF32();
        Matrix4x4f _m_CullingMatrixOverride = Matrix4x4f.Read(reader);
        bool _m_UseCullingMatrixOverride = reader.ReadBool();
        reader.AlignTo(4); /* m_UseCullingMatrixOverride */
        
        return new(_m_Type,
            _m_Resolution,
            _m_CustomResolution,
            _m_Strength,
            _m_Bias,
            _m_NormalBias,
            _m_NearPlane,
            _m_CullingMatrixOverride,
            _m_UseCullingMatrixOverride);
    }

    public override string ToString() => $"ShadowSettings\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Type: ");
        sb.AppendLine(m_Type.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Resolution: ");
        sb.AppendLine(m_Resolution.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CustomResolution: ");
        sb.AppendLine(m_CustomResolution.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Strength: ");
        sb.AppendLine(m_Strength.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Bias: ");
        sb.AppendLine(m_Bias.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NormalBias: ");
        sb.AppendLine(m_NormalBias.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NearPlane: ");
        sb.AppendLine(m_NearPlane.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CullingMatrixOverride: ");
        sb.AppendLine();
        sb.Append(m_CullingMatrixOverride.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_UseCullingMatrixOverride: ");
        sb.AppendLine(m_UseCullingMatrixOverride.ToString());

        return sb.ToString();
    }
}

/* $LightBakingOutput (4 fields) */
public record class LightBakingOutput(
    int probeOcclusionLightIndex,
    int occlusionMaskChannel,
    LightmapBakeMode lightmapBakeMode,
    bool isBaked) : IUnityStructure
{
    public static LightBakingOutput Read(EndianBinaryReader reader)
    {
        int _probeOcclusionLightIndex = reader.ReadS32();
        int _occlusionMaskChannel = reader.ReadS32();
        LightmapBakeMode _lightmapBakeMode = LightmapBakeMode.Read(reader);
        bool _isBaked = reader.ReadBool();
        reader.AlignTo(4); /* isBaked */
        
        return new(_probeOcclusionLightIndex,
            _occlusionMaskChannel,
            _lightmapBakeMode,
            _isBaked);
    }

    public override string ToString() => $"LightBakingOutput\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("probeOcclusionLightIndex: ");
        sb.AppendLine(probeOcclusionLightIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("occlusionMaskChannel: ");
        sb.AppendLine(occlusionMaskChannel.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("lightmapBakeMode: ");
        sb.AppendLine();
        sb.Append(lightmapBakeMode.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("isBaked: ");
        sb.AppendLine(isBaked.ToString());

        return sb.ToString();
    }
}

/* $LightmapBakeMode (2 fields) */
public readonly record struct LightmapBakeMode(
    int lightmapBakeType,
    int mixedLightingMode) : IUnityStructure
{
    public static LightmapBakeMode Read(EndianBinaryReader reader)
    {
        int _lightmapBakeType = reader.ReadS32();
        int _mixedLightingMode = reader.ReadS32();
        
        return new(_lightmapBakeType,
            _mixedLightingMode);
    }

    public override string ToString() => $"LightmapBakeMode\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("lightmapBakeType: ");
        sb.AppendLine(lightmapBakeType.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("mixedLightingMode: ");
        sb.AppendLine(mixedLightingMode.ToString());

        return sb.ToString();
    }
}

/* $QuaternionCurve (2 fields) */
public record class QuaternionCurve(
    AnimationCurve_1 curve,
    AsciiString path) : IUnityStructure
{
    public static QuaternionCurve Read(EndianBinaryReader reader)
    {
        AnimationCurve_1 _curve = AnimationCurve_1.Read(reader);
        reader.AlignTo(4); /* curve */
        AsciiString _path = BuiltInString.Read(reader);
        reader.AlignTo(4); /* path */
        
        return new(_curve,
            _path);
    }

    public override string ToString() => $"QuaternionCurve\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("curve: ");
        sb.AppendLine();
        sb.Append(curve.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("path: ");
        sb.AppendLine(path.ToString());

        return sb.ToString();
    }
}

/* $AnimationCurve_1 (4 fields) */
public record class AnimationCurve_1(
    Keyframe_1[] m_Curve,
    int m_PreInfinity,
    int m_PostInfinity,
    int m_RotationOrder) : IUnityStructure
{
    public static AnimationCurve_1 Read(EndianBinaryReader reader)
    {
        Keyframe_1[] _m_Curve = BuiltInArray<Keyframe_1>.Read(reader);
        reader.AlignTo(4); /* m_Curve */
        int _m_PreInfinity = reader.ReadS32();
        int _m_PostInfinity = reader.ReadS32();
        int _m_RotationOrder = reader.ReadS32();
        
        return new(_m_Curve,
            _m_PreInfinity,
            _m_PostInfinity,
            _m_RotationOrder);
    }

    public override string ToString() => $"AnimationCurve_1\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Curve: ");
        sb.AppendLine(m_Curve.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PreInfinity: ");
        sb.AppendLine(m_PreInfinity.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PostInfinity: ");
        sb.AppendLine(m_PostInfinity.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RotationOrder: ");
        sb.AppendLine(m_RotationOrder.ToString());

        return sb.ToString();
    }
}

/* $Keyframe_1 (7 fields) */
public record class Keyframe_1(
    float time,
    Quaternionf @value,
    Quaternionf inSlope,
    Quaternionf outSlope,
    int weightedMode,
    Quaternionf inWeight,
    Quaternionf outWeight) : IUnityStructure
{
    public static Keyframe_1 Read(EndianBinaryReader reader)
    {
        float _time = reader.ReadF32();
        Quaternionf _value = Quaternionf.Read(reader);
        Quaternionf _inSlope = Quaternionf.Read(reader);
        Quaternionf _outSlope = Quaternionf.Read(reader);
        int _weightedMode = reader.ReadS32();
        Quaternionf _inWeight = Quaternionf.Read(reader);
        Quaternionf _outWeight = Quaternionf.Read(reader);
        
        return new(_time,
            _value,
            _inSlope,
            _outSlope,
            _weightedMode,
            _inWeight,
            _outWeight);
    }

    public override string ToString() => $"Keyframe_1\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("time: ");
        sb.AppendLine(time.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("@value: ");
        sb.AppendLine();
        sb.Append(@value.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("inSlope: ");
        sb.AppendLine();
        sb.Append(inSlope.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("outSlope: ");
        sb.AppendLine();
        sb.Append(outSlope.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("weightedMode: ");
        sb.AppendLine(weightedMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("inWeight: ");
        sb.AppendLine();
        sb.Append(inWeight.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("outWeight: ");
        sb.AppendLine();
        sb.Append(outWeight.ToString(indent+4));

        return sb.ToString();
    }
}

/* $CompressedAnimationCurve (6 fields) */
public record class CompressedAnimationCurve(
    AsciiString m_Path,
    PackedBitVector_1 m_Times,
    PackedBitVector_2 m_Values,
    PackedBitVector_0 m_Slopes,
    int m_PreInfinity,
    int m_PostInfinity) : IUnityStructure
{
    public static CompressedAnimationCurve Read(EndianBinaryReader reader)
    {
        AsciiString _m_Path = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Path */
        PackedBitVector_1 _m_Times = PackedBitVector_1.Read(reader);
        reader.AlignTo(4); /* m_Times */
        PackedBitVector_2 _m_Values = PackedBitVector_2.Read(reader);
        reader.AlignTo(4); /* m_Values */
        PackedBitVector_0 _m_Slopes = PackedBitVector_0.Read(reader);
        reader.AlignTo(4); /* m_Slopes */
        int _m_PreInfinity = reader.ReadS32();
        int _m_PostInfinity = reader.ReadS32();
        
        return new(_m_Path,
            _m_Times,
            _m_Values,
            _m_Slopes,
            _m_PreInfinity,
            _m_PostInfinity);
    }

    public override string ToString() => $"CompressedAnimationCurve\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Path: ");
        sb.AppendLine(m_Path.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Times: ");
        sb.AppendLine();
        sb.Append(m_Times.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Values: ");
        sb.AppendLine();
        sb.Append(m_Values.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Slopes: ");
        sb.AppendLine();
        sb.Append(m_Slopes.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PreInfinity: ");
        sb.AppendLine(m_PreInfinity.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PostInfinity: ");
        sb.AppendLine(m_PostInfinity.ToString());

        return sb.ToString();
    }
}

/* $PackedBitVector_2 (2 fields) */
public record class PackedBitVector_2(
    uint m_NumItems,
    byte[] m_Data) : IUnityStructure
{
    public static PackedBitVector_2 Read(EndianBinaryReader reader)
    {
        uint _m_NumItems = reader.ReadU32();
        byte[] _m_Data = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_Data */
        
        return new(_m_NumItems,
            _m_Data);
    }

    public override string ToString() => $"PackedBitVector_2\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NumItems: ");
        sb.AppendLine(m_NumItems.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Data: ");
        sb.AppendLine(m_Data.ToString());

        return sb.ToString();
    }
}

/* $Vector3Curve (2 fields) */
public record class Vector3Curve(
    AnimationCurve_2 curve,
    AsciiString path) : IUnityStructure
{
    public static Vector3Curve Read(EndianBinaryReader reader)
    {
        AnimationCurve_2 _curve = AnimationCurve_2.Read(reader);
        reader.AlignTo(4); /* curve */
        AsciiString _path = BuiltInString.Read(reader);
        reader.AlignTo(4); /* path */
        
        return new(_curve,
            _path);
    }

    public override string ToString() => $"Vector3Curve\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("curve: ");
        sb.AppendLine();
        sb.Append(curve.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("path: ");
        sb.AppendLine(path.ToString());

        return sb.ToString();
    }
}

/* $AnimationCurve_2 (4 fields) */
public record class AnimationCurve_2(
    Keyframe_2[] m_Curve,
    int m_PreInfinity,
    int m_PostInfinity,
    int m_RotationOrder) : IUnityStructure
{
    public static AnimationCurve_2 Read(EndianBinaryReader reader)
    {
        Keyframe_2[] _m_Curve = BuiltInArray<Keyframe_2>.Read(reader);
        reader.AlignTo(4); /* m_Curve */
        int _m_PreInfinity = reader.ReadS32();
        int _m_PostInfinity = reader.ReadS32();
        int _m_RotationOrder = reader.ReadS32();
        
        return new(_m_Curve,
            _m_PreInfinity,
            _m_PostInfinity,
            _m_RotationOrder);
    }

    public override string ToString() => $"AnimationCurve_2\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Curve: ");
        sb.AppendLine(m_Curve.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PreInfinity: ");
        sb.AppendLine(m_PreInfinity.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PostInfinity: ");
        sb.AppendLine(m_PostInfinity.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RotationOrder: ");
        sb.AppendLine(m_RotationOrder.ToString());

        return sb.ToString();
    }
}

/* $Keyframe_2 (7 fields) */
public record class Keyframe_2(
    float time,
    Vector3f @value,
    Vector3f inSlope,
    Vector3f outSlope,
    int weightedMode,
    Vector3f inWeight,
    Vector3f outWeight) : IUnityStructure
{
    public static Keyframe_2 Read(EndianBinaryReader reader)
    {
        float _time = reader.ReadF32();
        Vector3f _value = Vector3f.Read(reader);
        Vector3f _inSlope = Vector3f.Read(reader);
        Vector3f _outSlope = Vector3f.Read(reader);
        int _weightedMode = reader.ReadS32();
        Vector3f _inWeight = Vector3f.Read(reader);
        Vector3f _outWeight = Vector3f.Read(reader);
        
        return new(_time,
            _value,
            _inSlope,
            _outSlope,
            _weightedMode,
            _inWeight,
            _outWeight);
    }

    public override string ToString() => $"Keyframe_2\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("time: ");
        sb.AppendLine(time.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("@value: ");
        sb.AppendLine();
        sb.Append(@value.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("inSlope: ");
        sb.AppendLine();
        sb.Append(inSlope.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("outSlope: ");
        sb.AppendLine();
        sb.Append(outSlope.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("weightedMode: ");
        sb.AppendLine(weightedMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("inWeight: ");
        sb.AppendLine();
        sb.Append(inWeight.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("outWeight: ");
        sb.AppendLine();
        sb.Append(outWeight.ToString(indent+4));

        return sb.ToString();
    }
}

/* $FloatCurve (6 fields) */
public record class FloatCurve(
    AnimationCurve_0 curve,
    AsciiString attribute,
    AsciiString path,
    int classID,
    PPtr<MonoScript> script,
    int flags) : IUnityStructure
{
    public static FloatCurve Read(EndianBinaryReader reader)
    {
        AnimationCurve_0 _curve = AnimationCurve_0.Read(reader);
        reader.AlignTo(4); /* curve */
        AsciiString _attribute = BuiltInString.Read(reader);
        reader.AlignTo(4); /* attribute */
        AsciiString _path = BuiltInString.Read(reader);
        reader.AlignTo(4); /* path */
        int _classID = reader.ReadS32();
        PPtr<MonoScript> _script = PPtr<MonoScript>.Read(reader);
        int _flags = reader.ReadS32();
        
        return new(_curve,
            _attribute,
            _path,
            _classID,
            _script,
            _flags);
    }

    public override string ToString() => $"FloatCurve\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("curve: ");
        sb.AppendLine();
        sb.Append(curve.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("attribute: ");
        sb.AppendLine(attribute.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("path: ");
        sb.AppendLine(path.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("classID: ");
        sb.AppendLine(classID.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("script: ");
        sb.AppendLine(script.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("flags: ");
        sb.AppendLine(flags.ToString());

        return sb.ToString();
    }
}

/* $PPtrCurve (6 fields) */
public record class PPtrCurve(
    PPtrKeyframe[] curve,
    AsciiString attribute,
    AsciiString path,
    int classID,
    PPtr<MonoScript> script,
    int flags) : IUnityStructure
{
    public static PPtrCurve Read(EndianBinaryReader reader)
    {
        PPtrKeyframe[] _curve = BuiltInArray<PPtrKeyframe>.Read(reader);
        reader.AlignTo(4); /* curve */
        AsciiString _attribute = BuiltInString.Read(reader);
        reader.AlignTo(4); /* attribute */
        AsciiString _path = BuiltInString.Read(reader);
        reader.AlignTo(4); /* path */
        int _classID = reader.ReadS32();
        PPtr<MonoScript> _script = PPtr<MonoScript>.Read(reader);
        int _flags = reader.ReadS32();
        
        return new(_curve,
            _attribute,
            _path,
            _classID,
            _script,
            _flags);
    }

    public override string ToString() => $"PPtrCurve\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("curve: ");
        sb.AppendLine(curve.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("attribute: ");
        sb.AppendLine(attribute.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("path: ");
        sb.AppendLine(path.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("classID: ");
        sb.AppendLine(classID.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("script: ");
        sb.AppendLine(script.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("flags: ");
        sb.AppendLine(flags.ToString());

        return sb.ToString();
    }
}

/* $PPtrKeyframe (2 fields) */
public record class PPtrKeyframe(
    float time,
    PPtr<Object> @value) : IUnityStructure
{
    public static PPtrKeyframe Read(EndianBinaryReader reader)
    {
        float _time = reader.ReadF32();
        PPtr<Object> _value = PPtr<Object>.Read(reader);
        
        return new(_time,
            _value);
    }

    public override string ToString() => $"PPtrKeyframe\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("time: ");
        sb.AppendLine(time.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("@value: ");
        sb.AppendLine(@value.ToString());

        return sb.ToString();
    }
}

/* $ClipMuscleConstant (27 fields) */
public record class ClipMuscleConstant(
    HumanPose m_DeltaPose,
    xform m_StartX,
    xform m_StopX,
    xform m_LeftFootStartX,
    xform m_RightFootStartX,
    float3 m_AverageSpeed,
    OffsetPtr_19 m_Clip,
    float m_StartTime,
    float m_StopTime,
    float m_OrientationOffsetY,
    float m_Level,
    float m_CycleOffset,
    float m_AverageAngularSpeed,
    int[] m_IndexArray,
    ValueDelta[] m_ValueArrayDelta,
    float[] m_ValueArrayReferencePose,
    bool m_Mirror,
    bool m_LoopTime,
    bool m_LoopBlend,
    bool m_LoopBlendOrientation,
    bool m_LoopBlendPositionY,
    bool m_LoopBlendPositionXZ,
    bool m_StartAtOrigin,
    bool m_KeepOriginalOrientation,
    bool m_KeepOriginalPositionY,
    bool m_KeepOriginalPositionXZ,
    bool m_HeightFromFeet) : IUnityStructure
{
    public static ClipMuscleConstant Read(EndianBinaryReader reader)
    {
        HumanPose _m_DeltaPose = HumanPose.Read(reader);
        xform _m_StartX = xform.Read(reader);
        xform _m_StopX = xform.Read(reader);
        xform _m_LeftFootStartX = xform.Read(reader);
        xform _m_RightFootStartX = xform.Read(reader);
        float3 _m_AverageSpeed = float3.Read(reader);
        OffsetPtr_19 _m_Clip = OffsetPtr_19.Read(reader);
        float _m_StartTime = reader.ReadF32();
        float _m_StopTime = reader.ReadF32();
        float _m_OrientationOffsetY = reader.ReadF32();
        float _m_Level = reader.ReadF32();
        float _m_CycleOffset = reader.ReadF32();
        float _m_AverageAngularSpeed = reader.ReadF32();
        int[] _m_IndexArray = BuiltInArray<int>.Read(reader);
        ValueDelta[] _m_ValueArrayDelta = BuiltInArray<ValueDelta>.Read(reader);
        float[] _m_ValueArrayReferencePose = BuiltInArray<float>.Read(reader);
        bool _m_Mirror = reader.ReadBool();
        bool _m_LoopTime = reader.ReadBool();
        bool _m_LoopBlend = reader.ReadBool();
        bool _m_LoopBlendOrientation = reader.ReadBool();
        bool _m_LoopBlendPositionY = reader.ReadBool();
        bool _m_LoopBlendPositionXZ = reader.ReadBool();
        bool _m_StartAtOrigin = reader.ReadBool();
        bool _m_KeepOriginalOrientation = reader.ReadBool();
        bool _m_KeepOriginalPositionY = reader.ReadBool();
        bool _m_KeepOriginalPositionXZ = reader.ReadBool();
        bool _m_HeightFromFeet = reader.ReadBool();
        reader.AlignTo(4); /* m_HeightFromFeet */
        
        return new(_m_DeltaPose,
            _m_StartX,
            _m_StopX,
            _m_LeftFootStartX,
            _m_RightFootStartX,
            _m_AverageSpeed,
            _m_Clip,
            _m_StartTime,
            _m_StopTime,
            _m_OrientationOffsetY,
            _m_Level,
            _m_CycleOffset,
            _m_AverageAngularSpeed,
            _m_IndexArray,
            _m_ValueArrayDelta,
            _m_ValueArrayReferencePose,
            _m_Mirror,
            _m_LoopTime,
            _m_LoopBlend,
            _m_LoopBlendOrientation,
            _m_LoopBlendPositionY,
            _m_LoopBlendPositionXZ,
            _m_StartAtOrigin,
            _m_KeepOriginalOrientation,
            _m_KeepOriginalPositionY,
            _m_KeepOriginalPositionXZ,
            _m_HeightFromFeet);
    }

    public override string ToString() => $"ClipMuscleConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DeltaPose: ");
        sb.AppendLine();
        sb.Append(m_DeltaPose.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StartX: ");
        sb.AppendLine();
        sb.Append(m_StartX.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StopX: ");
        sb.AppendLine();
        sb.Append(m_StopX.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LeftFootStartX: ");
        sb.AppendLine();
        sb.Append(m_LeftFootStartX.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RightFootStartX: ");
        sb.AppendLine();
        sb.Append(m_RightFootStartX.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AverageSpeed: ");
        sb.AppendLine();
        sb.Append(m_AverageSpeed.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Clip: ");
        sb.AppendLine();
        sb.Append(m_Clip.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StartTime: ");
        sb.AppendLine(m_StartTime.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StopTime: ");
        sb.AppendLine(m_StopTime.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_OrientationOffsetY: ");
        sb.AppendLine(m_OrientationOffsetY.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Level: ");
        sb.AppendLine(m_Level.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CycleOffset: ");
        sb.AppendLine(m_CycleOffset.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AverageAngularSpeed: ");
        sb.AppendLine(m_AverageAngularSpeed.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IndexArray: ");
        sb.AppendLine(m_IndexArray.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ValueArrayDelta: ");
        sb.AppendLine(m_ValueArrayDelta.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ValueArrayReferencePose: ");
        sb.AppendLine(m_ValueArrayReferencePose.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Mirror: ");
        sb.AppendLine(m_Mirror.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LoopTime: ");
        sb.AppendLine(m_LoopTime.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LoopBlend: ");
        sb.AppendLine(m_LoopBlend.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LoopBlendOrientation: ");
        sb.AppendLine(m_LoopBlendOrientation.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LoopBlendPositionY: ");
        sb.AppendLine(m_LoopBlendPositionY.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LoopBlendPositionXZ: ");
        sb.AppendLine(m_LoopBlendPositionXZ.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StartAtOrigin: ");
        sb.AppendLine(m_StartAtOrigin.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_KeepOriginalOrientation: ");
        sb.AppendLine(m_KeepOriginalOrientation.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_KeepOriginalPositionY: ");
        sb.AppendLine(m_KeepOriginalPositionY.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_KeepOriginalPositionXZ: ");
        sb.AppendLine(m_KeepOriginalPositionXZ.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HeightFromFeet: ");
        sb.AppendLine(m_HeightFromFeet.ToString());

        return sb.ToString();
    }
}

/* $HumanPose (8 fields) */
public record class HumanPose(
    xform m_RootX,
    float3 m_LookAtPosition,
    float4 m_LookAtWeight,
    HumanGoal[] m_GoalArray,
    HandPose m_LeftHandPose,
    HandPose m_RightHandPose,
    float[] m_DoFArray,
    float3[] m_TDoFArray) : IUnityStructure
{
    public static HumanPose Read(EndianBinaryReader reader)
    {
        xform _m_RootX = xform.Read(reader);
        float3 _m_LookAtPosition = float3.Read(reader);
        float4 _m_LookAtWeight = float4.Read(reader);
        HumanGoal[] _m_GoalArray = BuiltInArray<HumanGoal>.Read(reader);
        HandPose _m_LeftHandPose = HandPose.Read(reader);
        HandPose _m_RightHandPose = HandPose.Read(reader);
        float[] _m_DoFArray = BuiltInArray<float>.Read(reader);
        float3[] _m_TDoFArray = BuiltInArray<float3>.Read(reader);
        
        return new(_m_RootX,
            _m_LookAtPosition,
            _m_LookAtWeight,
            _m_GoalArray,
            _m_LeftHandPose,
            _m_RightHandPose,
            _m_DoFArray,
            _m_TDoFArray);
    }

    public override string ToString() => $"HumanPose\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RootX: ");
        sb.AppendLine();
        sb.Append(m_RootX.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LookAtPosition: ");
        sb.AppendLine();
        sb.Append(m_LookAtPosition.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LookAtWeight: ");
        sb.AppendLine();
        sb.Append(m_LookAtWeight.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GoalArray: ");
        sb.AppendLine(m_GoalArray.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LeftHandPose: ");
        sb.AppendLine();
        sb.Append(m_LeftHandPose.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RightHandPose: ");
        sb.AppendLine();
        sb.Append(m_RightHandPose.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DoFArray: ");
        sb.AppendLine(m_DoFArray.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TDoFArray: ");
        sb.AppendLine(m_TDoFArray.ToString());

        return sb.ToString();
    }
}

/* $HumanGoal (5 fields) */
public record class HumanGoal(
    xform m_X,
    float m_WeightT,
    float m_WeightR,
    float3 m_HintT,
    float m_HintWeightT) : IUnityStructure
{
    public static HumanGoal Read(EndianBinaryReader reader)
    {
        xform _m_X = xform.Read(reader);
        float _m_WeightT = reader.ReadF32();
        float _m_WeightR = reader.ReadF32();
        float3 _m_HintT = float3.Read(reader);
        float _m_HintWeightT = reader.ReadF32();
        
        return new(_m_X,
            _m_WeightT,
            _m_WeightR,
            _m_HintT,
            _m_HintWeightT);
    }

    public override string ToString() => $"HumanGoal\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_X: ");
        sb.AppendLine();
        sb.Append(m_X.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_WeightT: ");
        sb.AppendLine(m_WeightT.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_WeightR: ");
        sb.AppendLine(m_WeightR.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HintT: ");
        sb.AppendLine();
        sb.Append(m_HintT.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HintWeightT: ");
        sb.AppendLine(m_HintWeightT.ToString());

        return sb.ToString();
    }
}

/* $HandPose (6 fields) */
public record class HandPose(
    xform m_GrabX,
    float[] m_DoFArray,
    float m_Override,
    float m_CloseOpen,
    float m_InOut,
    float m_Grab) : IUnityStructure
{
    public static HandPose Read(EndianBinaryReader reader)
    {
        xform _m_GrabX = xform.Read(reader);
        float[] _m_DoFArray = BuiltInArray<float>.Read(reader);
        float _m_Override = reader.ReadF32();
        float _m_CloseOpen = reader.ReadF32();
        float _m_InOut = reader.ReadF32();
        float _m_Grab = reader.ReadF32();
        
        return new(_m_GrabX,
            _m_DoFArray,
            _m_Override,
            _m_CloseOpen,
            _m_InOut,
            _m_Grab);
    }

    public override string ToString() => $"HandPose\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GrabX: ");
        sb.AppendLine();
        sb.Append(m_GrabX.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DoFArray: ");
        sb.AppendLine(m_DoFArray.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Override: ");
        sb.AppendLine(m_Override.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CloseOpen: ");
        sb.AppendLine(m_CloseOpen.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_InOut: ");
        sb.AppendLine(m_InOut.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Grab: ");
        sb.AppendLine(m_Grab.ToString());

        return sb.ToString();
    }
}

/* $OffsetPtr_19 (1 fields) */
public record class OffsetPtr_19(
    Clip data) : IUnityStructure
{
    public static OffsetPtr_19 Read(EndianBinaryReader reader)
    {
        Clip _data = Clip.Read(reader);
        
        return new(_data);
    }

    public override string ToString() => $"OffsetPtr_19\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data: ");
        sb.AppendLine();
        sb.Append(data.ToString(indent+4));

        return sb.ToString();
    }
}

/* $Clip (3 fields) */
public record class Clip(
    StreamedClip m_StreamedClip,
    DenseClip m_DenseClip,
    ConstantClip m_ConstantClip) : IUnityStructure
{
    public static Clip Read(EndianBinaryReader reader)
    {
        StreamedClip _m_StreamedClip = StreamedClip.Read(reader);
        DenseClip _m_DenseClip = DenseClip.Read(reader);
        ConstantClip _m_ConstantClip = ConstantClip.Read(reader);
        
        return new(_m_StreamedClip,
            _m_DenseClip,
            _m_ConstantClip);
    }

    public override string ToString() => $"Clip\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StreamedClip: ");
        sb.AppendLine();
        sb.Append(m_StreamedClip.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DenseClip: ");
        sb.AppendLine();
        sb.Append(m_DenseClip.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ConstantClip: ");
        sb.AppendLine();
        sb.Append(m_ConstantClip.ToString(indent+4));

        return sb.ToString();
    }
}

/* $StreamedClip (2 fields) */
public record class StreamedClip(
    uint[] data,
    uint curveCount) : IUnityStructure
{
    public static StreamedClip Read(EndianBinaryReader reader)
    {
        uint[] _data = BuiltInArray<uint>.Read(reader);
        uint _curveCount = reader.ReadU32();
        
        return new(_data,
            _curveCount);
    }

    public override string ToString() => $"StreamedClip\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data: ");
        sb.AppendLine(data.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("curveCount: ");
        sb.AppendLine(curveCount.ToString());

        return sb.ToString();
    }
}

/* $DenseClip (5 fields) */
public record class DenseClip(
    int m_FrameCount,
    uint m_CurveCount,
    float m_SampleRate,
    float m_BeginTime,
    float[] m_SampleArray) : IUnityStructure
{
    public static DenseClip Read(EndianBinaryReader reader)
    {
        int _m_FrameCount = reader.ReadS32();
        uint _m_CurveCount = reader.ReadU32();
        float _m_SampleRate = reader.ReadF32();
        float _m_BeginTime = reader.ReadF32();
        float[] _m_SampleArray = BuiltInArray<float>.Read(reader);
        
        return new(_m_FrameCount,
            _m_CurveCount,
            _m_SampleRate,
            _m_BeginTime,
            _m_SampleArray);
    }

    public override string ToString() => $"DenseClip\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FrameCount: ");
        sb.AppendLine(m_FrameCount.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CurveCount: ");
        sb.AppendLine(m_CurveCount.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SampleRate: ");
        sb.AppendLine(m_SampleRate.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BeginTime: ");
        sb.AppendLine(m_BeginTime.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SampleArray: ");
        sb.AppendLine(m_SampleArray.ToString());

        return sb.ToString();
    }
}

/* $ConstantClip (1 fields) */
public record class ConstantClip(
    float[] data) : IUnityStructure
{
    public static ConstantClip Read(EndianBinaryReader reader)
    {
        float[] _data = BuiltInArray<float>.Read(reader);
        
        return new(_data);
    }

    public override string ToString() => $"ConstantClip\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data: ");
        sb.AppendLine(data.ToString());

        return sb.ToString();
    }
}

/* $ValueDelta (2 fields) */
public readonly record struct ValueDelta(
    float m_Start,
    float m_Stop) : IUnityStructure
{
    public static ValueDelta Read(EndianBinaryReader reader)
    {
        float _m_Start = reader.ReadF32();
        float _m_Stop = reader.ReadF32();
        
        return new(_m_Start,
            _m_Stop);
    }

    public override string ToString() => $"ValueDelta\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Start: ");
        sb.AppendLine(m_Start.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Stop: ");
        sb.AppendLine(m_Stop.ToString());

        return sb.ToString();
    }
}

/* $AnimationClipBindingConstant (2 fields) */
public record class AnimationClipBindingConstant(
    GenericBinding[] genericBindings,
    PPtr<Object>[] pptrCurveMapping) : IUnityStructure
{
    public static AnimationClipBindingConstant Read(EndianBinaryReader reader)
    {
        GenericBinding[] _genericBindings = BuiltInArray<GenericBinding>.Read(reader);
        reader.AlignTo(4); /* genericBindings */
        PPtr<Object>[] _pptrCurveMapping = BuiltInArray<PPtr<Object>>.Read(reader);
        reader.AlignTo(4); /* pptrCurveMapping */
        
        return new(_genericBindings,
            _pptrCurveMapping);
    }

    public override string ToString() => $"AnimationClipBindingConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("genericBindings: ");
        sb.AppendLine(genericBindings.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("pptrCurveMapping: ");
        sb.AppendLine(pptrCurveMapping.ToString());

        return sb.ToString();
    }
}

/* $GenericBinding (8 fields) */
public record class GenericBinding(
    uint path,
    uint attribute,
    PPtr<Object> script,
    int typeID,
    byte customType,
    byte isPPtrCurve,
    byte isIntCurve,
    byte isSerializeReferenceCurve) : IUnityStructure
{
    public static GenericBinding Read(EndianBinaryReader reader)
    {
        uint _path = reader.ReadU32();
        uint _attribute = reader.ReadU32();
        PPtr<Object> _script = PPtr<Object>.Read(reader);
        int _typeID = reader.ReadS32();
        byte _customType = reader.ReadU8();
        byte _isPPtrCurve = reader.ReadU8();
        byte _isIntCurve = reader.ReadU8();
        byte _isSerializeReferenceCurve = reader.ReadU8();
        reader.AlignTo(4); /* isSerializeReferenceCurve */
        
        return new(_path,
            _attribute,
            _script,
            _typeID,
            _customType,
            _isPPtrCurve,
            _isIntCurve,
            _isSerializeReferenceCurve);
    }

    public override string ToString() => $"GenericBinding\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("path: ");
        sb.AppendLine(path.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("attribute: ");
        sb.AppendLine(attribute.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("script: ");
        sb.AppendLine(script.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("typeID: ");
        sb.AppendLine(typeID.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("customType: ");
        sb.AppendLine(customType.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("isPPtrCurve: ");
        sb.AppendLine(isPPtrCurve.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("isIntCurve: ");
        sb.AppendLine(isIntCurve.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("isSerializeReferenceCurve: ");
        sb.AppendLine(isSerializeReferenceCurve.ToString());

        return sb.ToString();
    }
}

/* $AnimationEvent (7 fields) */
public record class AnimationEvent(
    float time,
    AsciiString functionName,
    AsciiString data,
    PPtr<Object> objectReferenceParameter,
    float floatParameter,
    int intParameter,
    int messageOptions) : IUnityStructure
{
    public static AnimationEvent Read(EndianBinaryReader reader)
    {
        float _time = reader.ReadF32();
        AsciiString _functionName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* functionName */
        AsciiString _data = BuiltInString.Read(reader);
        reader.AlignTo(4); /* data */
        PPtr<Object> _objectReferenceParameter = PPtr<Object>.Read(reader);
        float _floatParameter = reader.ReadF32();
        int _intParameter = reader.ReadS32();
        int _messageOptions = reader.ReadS32();
        
        return new(_time,
            _functionName,
            _data,
            _objectReferenceParameter,
            _floatParameter,
            _intParameter,
            _messageOptions);
    }

    public override string ToString() => $"AnimationEvent\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("time: ");
        sb.AppendLine(time.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("functionName: ");
        sb.AppendLine(functionName.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("data: ");
        sb.AppendLine(data.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("objectReferenceParameter: ");
        sb.AppendLine(objectReferenceParameter.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("floatParameter: ");
        sb.AppendLine(floatParameter.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("intParameter: ");
        sb.AppendLine(intParameter.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("messageOptions: ");
        sb.AppendLine(messageOptions.ToString());

        return sb.ToString();
    }
}

/* $DirectorGenericBinding (2 fields) */
public record class DirectorGenericBinding(
    PPtr<Object> key,
    PPtr<Object> @value) : IUnityStructure
{
    public static DirectorGenericBinding Read(EndianBinaryReader reader)
    {
        PPtr<Object> _key = PPtr<Object>.Read(reader);
        PPtr<Object> _value = PPtr<Object>.Read(reader);
        
        return new(_key,
            _value);
    }

    public override string ToString() => $"DirectorGenericBinding\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("key: ");
        sb.AppendLine(key.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("@value: ");
        sb.AppendLine(@value.ToString());

        return sb.ToString();
    }
}

/* $ExposedReferenceTable (1 fields) */
public record class ExposedReferenceTable(
    Dictionary<AsciiString, PPtr<Object>> m_References) : IUnityStructure
{
    public static ExposedReferenceTable Read(EndianBinaryReader reader)
    {
        Dictionary<AsciiString, PPtr<Object>> _m_References = BuiltInMap<AsciiString, PPtr<Object>>.Read(reader);
        reader.AlignTo(4); /* m_References */
        
        return new(_m_References);
    }

    public override string ToString() => $"ExposedReferenceTable\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_References: ");
        sb.AppendLine(m_References.ToString());

        return sb.ToString();
    }
}

/* $SpriteRenderData (13 fields) */
public record class SpriteRenderData(
    PPtr<Texture2D> texture,
    PPtr<Texture2D> alphaTexture,
    SecondarySpriteTexture[] secondaryTextures,
    SubMesh[] m_SubMeshes,
    byte[] m_IndexBuffer,
    VertexData m_VertexData,
    Matrix4x4f[] m_Bindpose,
    Rectf textureRect,
    Vector2f textureRectOffset,
    Vector2f atlasRectOffset,
    uint settingsRaw,
    Vector4f uvTransform,
    float downscaleMultiplier) : IUnityStructure
{
    public static SpriteRenderData Read(EndianBinaryReader reader)
    {
        PPtr<Texture2D> _texture = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> _alphaTexture = PPtr<Texture2D>.Read(reader);
        SecondarySpriteTexture[] _secondaryTextures = BuiltInArray<SecondarySpriteTexture>.Read(reader);
        reader.AlignTo(4); /* secondaryTextures */
        SubMesh[] _m_SubMeshes = BuiltInArray<SubMesh>.Read(reader);
        reader.AlignTo(4); /* m_SubMeshes */
        byte[] _m_IndexBuffer = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_IndexBuffer */
        VertexData _m_VertexData = VertexData.Read(reader);
        reader.AlignTo(4); /* m_VertexData */
        Matrix4x4f[] _m_Bindpose = BuiltInArray<Matrix4x4f>.Read(reader);
        reader.AlignTo(4); /* m_Bindpose */
        Rectf _textureRect = Rectf.Read(reader);
        Vector2f _textureRectOffset = Vector2f.Read(reader);
        Vector2f _atlasRectOffset = Vector2f.Read(reader);
        uint _settingsRaw = reader.ReadU32();
        Vector4f _uvTransform = Vector4f.Read(reader);
        float _downscaleMultiplier = reader.ReadF32();
        
        return new(_texture,
            _alphaTexture,
            _secondaryTextures,
            _m_SubMeshes,
            _m_IndexBuffer,
            _m_VertexData,
            _m_Bindpose,
            _textureRect,
            _textureRectOffset,
            _atlasRectOffset,
            _settingsRaw,
            _uvTransform,
            _downscaleMultiplier);
    }

    public override string ToString() => $"SpriteRenderData\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("texture: ");
        sb.AppendLine(texture.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("alphaTexture: ");
        sb.AppendLine(alphaTexture.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("secondaryTextures: ");
        sb.AppendLine(secondaryTextures.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SubMeshes: ");
        sb.AppendLine(m_SubMeshes.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IndexBuffer: ");
        sb.AppendLine(m_IndexBuffer.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_VertexData: ");
        sb.AppendLine();
        sb.Append(m_VertexData.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Bindpose: ");
        sb.AppendLine(m_Bindpose.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("textureRect: ");
        sb.AppendLine();
        sb.Append(textureRect.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("textureRectOffset: ");
        sb.AppendLine();
        sb.Append(textureRectOffset.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("atlasRectOffset: ");
        sb.AppendLine();
        sb.Append(atlasRectOffset.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("settingsRaw: ");
        sb.AppendLine(settingsRaw.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("uvTransform: ");
        sb.AppendLine();
        sb.Append(uvTransform.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("downscaleMultiplier: ");
        sb.AppendLine(downscaleMultiplier.ToString());

        return sb.ToString();
    }
}

/* $SpriteBone (7 fields) */
public record class SpriteBone(
    AsciiString name,
    AsciiString guid,
    Vector3f position,
    Quaternionf rotation,
    float length,
    int parentId,
    ColorRGBA_1 color) : IUnityStructure
{
    public static SpriteBone Read(EndianBinaryReader reader)
    {
        AsciiString _name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* name */
        AsciiString _guid = BuiltInString.Read(reader);
        reader.AlignTo(4); /* guid */
        Vector3f _position = Vector3f.Read(reader);
        Quaternionf _rotation = Quaternionf.Read(reader);
        float _length = reader.ReadF32();
        int _parentId = reader.ReadS32();
        ColorRGBA_1 _color = ColorRGBA_1.Read(reader);
        
        return new(_name,
            _guid,
            _position,
            _rotation,
            _length,
            _parentId,
            _color);
    }

    public override string ToString() => $"SpriteBone\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("name: ");
        sb.AppendLine(name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("guid: ");
        sb.AppendLine(guid.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("position: ");
        sb.AppendLine();
        sb.Append(position.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("rotation: ");
        sb.AppendLine();
        sb.Append(rotation.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("length: ");
        sb.AppendLine(length.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("parentId: ");
        sb.AppendLine(parentId.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("color: ");
        sb.AppendLine();
        sb.Append(color.ToString(indent+4));

        return sb.ToString();
    }
}

/* $ColorRGBA_1 (1 fields) */
public readonly record struct ColorRGBA_1(
    uint rgba) : IUnityStructure
{
    public static ColorRGBA_1 Read(EndianBinaryReader reader)
    {
        uint _rgba = reader.ReadU32();
        
        return new(_rgba);
    }

    public override string ToString() => $"ColorRGBA_1\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("rgba: ");
        sb.AppendLine(rgba.ToString());

        return sb.ToString();
    }
}

/* $SplatDatabase (4 fields) */
public record class SplatDatabase(
    PPtr<TerrainLayer>[] m_TerrainLayers,
    PPtr<Texture2D>[] m_AlphaTextures,
    int m_AlphamapResolution,
    int m_BaseMapResolution) : IUnityStructure
{
    public static SplatDatabase Read(EndianBinaryReader reader)
    {
        PPtr<TerrainLayer>[] _m_TerrainLayers = BuiltInArray<PPtr<TerrainLayer>>.Read(reader);
        reader.AlignTo(4); /* m_TerrainLayers */
        PPtr<Texture2D>[] _m_AlphaTextures = BuiltInArray<PPtr<Texture2D>>.Read(reader);
        reader.AlignTo(4); /* m_AlphaTextures */
        int _m_AlphamapResolution = reader.ReadS32();
        int _m_BaseMapResolution = reader.ReadS32();
        
        return new(_m_TerrainLayers,
            _m_AlphaTextures,
            _m_AlphamapResolution,
            _m_BaseMapResolution);
    }

    public override string ToString() => $"SplatDatabase\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TerrainLayers: ");
        sb.AppendLine(m_TerrainLayers.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AlphaTextures: ");
        sb.AppendLine(m_AlphaTextures.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AlphamapResolution: ");
        sb.AppendLine(m_AlphamapResolution.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BaseMapResolution: ");
        sb.AppendLine(m_BaseMapResolution.ToString());

        return sb.ToString();
    }
}

/* $DetailDatabase (15 fields) */
public record class DetailDatabase(
    DetailPatch[] m_Patches,
    DetailPrototype[] m_DetailPrototypes,
    int m_PatchCount,
    int m_PatchSamples,
    ColorRGBA_0 WavingGrassTint,
    float m_WavingGrassStrength,
    float m_WavingGrassAmount,
    float m_WavingGrassSpeed,
    int m_DetailScatterMode,
    TreeInstance[] m_TreeInstances,
    TreePrototype[] m_TreePrototypes,
    PPtr<Texture2D>[] m_PreloadTextureAtlasData,
    PPtr<Shader> m_DefaultShaders_0,
    PPtr<Shader> m_DefaultShaders_1,
    PPtr<Shader> m_DefaultShaders_2) : IUnityStructure
{
    public static DetailDatabase Read(EndianBinaryReader reader)
    {
        DetailPatch[] _m_Patches = BuiltInArray<DetailPatch>.Read(reader);
        reader.AlignTo(4); /* m_Patches */
        DetailPrototype[] _m_DetailPrototypes = BuiltInArray<DetailPrototype>.Read(reader);
        reader.AlignTo(4); /* m_DetailPrototypes */
        int _m_PatchCount = reader.ReadS32();
        int _m_PatchSamples = reader.ReadS32();
        ColorRGBA_0 _WavingGrassTint = ColorRGBA_0.Read(reader);
        float _m_WavingGrassStrength = reader.ReadF32();
        float _m_WavingGrassAmount = reader.ReadF32();
        float _m_WavingGrassSpeed = reader.ReadF32();
        int _m_DetailScatterMode = reader.ReadS32();
        TreeInstance[] _m_TreeInstances = BuiltInArray<TreeInstance>.Read(reader);
        reader.AlignTo(4); /* m_TreeInstances */
        TreePrototype[] _m_TreePrototypes = BuiltInArray<TreePrototype>.Read(reader);
        reader.AlignTo(4); /* m_TreePrototypes */
        PPtr<Texture2D>[] _m_PreloadTextureAtlasData = BuiltInArray<PPtr<Texture2D>>.Read(reader);
        reader.AlignTo(4); /* m_PreloadTextureAtlasData */
        PPtr<Shader> _m_DefaultShaders_0 = PPtr<Shader>.Read(reader);
        PPtr<Shader> _m_DefaultShaders_1 = PPtr<Shader>.Read(reader);
        PPtr<Shader> _m_DefaultShaders_2 = PPtr<Shader>.Read(reader);
        
        return new(_m_Patches,
            _m_DetailPrototypes,
            _m_PatchCount,
            _m_PatchSamples,
            _WavingGrassTint,
            _m_WavingGrassStrength,
            _m_WavingGrassAmount,
            _m_WavingGrassSpeed,
            _m_DetailScatterMode,
            _m_TreeInstances,
            _m_TreePrototypes,
            _m_PreloadTextureAtlasData,
            _m_DefaultShaders_0,
            _m_DefaultShaders_1,
            _m_DefaultShaders_2);
    }

    public override string ToString() => $"DetailDatabase\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Patches: ");
        sb.AppendLine(m_Patches.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DetailPrototypes: ");
        sb.AppendLine(m_DetailPrototypes.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PatchCount: ");
        sb.AppendLine(m_PatchCount.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PatchSamples: ");
        sb.AppendLine(m_PatchSamples.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("WavingGrassTint: ");
        sb.AppendLine();
        sb.Append(WavingGrassTint.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_WavingGrassStrength: ");
        sb.AppendLine(m_WavingGrassStrength.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_WavingGrassAmount: ");
        sb.AppendLine(m_WavingGrassAmount.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_WavingGrassSpeed: ");
        sb.AppendLine(m_WavingGrassSpeed.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DetailScatterMode: ");
        sb.AppendLine(m_DetailScatterMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TreeInstances: ");
        sb.AppendLine(m_TreeInstances.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TreePrototypes: ");
        sb.AppendLine(m_TreePrototypes.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PreloadTextureAtlasData: ");
        sb.AppendLine(m_PreloadTextureAtlasData.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DefaultShaders_0: ");
        sb.AppendLine(m_DefaultShaders_0.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DefaultShaders_1: ");
        sb.AppendLine(m_DefaultShaders_1.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DefaultShaders_2: ");
        sb.AppendLine(m_DefaultShaders_2.ToString());

        return sb.ToString();
    }
}

/* $DetailPatch (2 fields) */
public record class DetailPatch(
    byte[] layerIndices,
    byte[] coverage) : IUnityStructure
{
    public static DetailPatch Read(EndianBinaryReader reader)
    {
        byte[] _layerIndices = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* layerIndices */
        byte[] _coverage = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* coverage */
        
        return new(_layerIndices,
            _coverage);
    }

    public override string ToString() => $"DetailPatch\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("layerIndices: ");
        sb.AppendLine(layerIndices.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("coverage: ");
        sb.AppendLine(coverage.ToString());

        return sb.ToString();
    }
}

/* $DetailPrototype (19 fields) */
public record class DetailPrototype(
    PPtr<GameObject> prototype,
    PPtr<Texture2D> prototypeTexture,
    float minWidth,
    float maxWidth,
    float minHeight,
    float maxHeight,
    int noiseSeed,
    float noiseSpread,
    float holeTestRadius,
    float density,
    ColorRGBA_0 healthyColor,
    ColorRGBA_0 dryColor,
    int renderMode,
    int usePrototypeMesh,
    int useInstancing,
    int useDensityScaling,
    float alignToGround,
    float positionJitter,
    float targetCoverage) : IUnityStructure
{
    public static DetailPrototype Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _prototype = PPtr<GameObject>.Read(reader);
        PPtr<Texture2D> _prototypeTexture = PPtr<Texture2D>.Read(reader);
        float _minWidth = reader.ReadF32();
        float _maxWidth = reader.ReadF32();
        float _minHeight = reader.ReadF32();
        float _maxHeight = reader.ReadF32();
        int _noiseSeed = reader.ReadS32();
        float _noiseSpread = reader.ReadF32();
        float _holeTestRadius = reader.ReadF32();
        float _density = reader.ReadF32();
        ColorRGBA_0 _healthyColor = ColorRGBA_0.Read(reader);
        ColorRGBA_0 _dryColor = ColorRGBA_0.Read(reader);
        int _renderMode = reader.ReadS32();
        int _usePrototypeMesh = reader.ReadS32();
        int _useInstancing = reader.ReadS32();
        int _useDensityScaling = reader.ReadS32();
        float _alignToGround = reader.ReadF32();
        float _positionJitter = reader.ReadF32();
        float _targetCoverage = reader.ReadF32();
        
        return new(_prototype,
            _prototypeTexture,
            _minWidth,
            _maxWidth,
            _minHeight,
            _maxHeight,
            _noiseSeed,
            _noiseSpread,
            _holeTestRadius,
            _density,
            _healthyColor,
            _dryColor,
            _renderMode,
            _usePrototypeMesh,
            _useInstancing,
            _useDensityScaling,
            _alignToGround,
            _positionJitter,
            _targetCoverage);
    }

    public override string ToString() => $"DetailPrototype\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("prototype: ");
        sb.AppendLine(prototype.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("prototypeTexture: ");
        sb.AppendLine(prototypeTexture.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("minWidth: ");
        sb.AppendLine(minWidth.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("maxWidth: ");
        sb.AppendLine(maxWidth.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("minHeight: ");
        sb.AppendLine(minHeight.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("maxHeight: ");
        sb.AppendLine(maxHeight.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("noiseSeed: ");
        sb.AppendLine(noiseSeed.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("noiseSpread: ");
        sb.AppendLine(noiseSpread.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("holeTestRadius: ");
        sb.AppendLine(holeTestRadius.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("density: ");
        sb.AppendLine(density.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("healthyColor: ");
        sb.AppendLine();
        sb.Append(healthyColor.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("dryColor: ");
        sb.AppendLine();
        sb.Append(dryColor.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("renderMode: ");
        sb.AppendLine(renderMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("usePrototypeMesh: ");
        sb.AppendLine(usePrototypeMesh.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("useInstancing: ");
        sb.AppendLine(useInstancing.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("useDensityScaling: ");
        sb.AppendLine(useDensityScaling.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("alignToGround: ");
        sb.AppendLine(alignToGround.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("positionJitter: ");
        sb.AppendLine(positionJitter.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("targetCoverage: ");
        sb.AppendLine(targetCoverage.ToString());

        return sb.ToString();
    }
}

/* $TreeInstance (7 fields) */
public record class TreeInstance(
    Vector3f position,
    float widthScale,
    float heightScale,
    float rotation,
    ColorRGBA_1 color,
    ColorRGBA_1 lightmapColor,
    int index) : IUnityStructure
{
    public static TreeInstance Read(EndianBinaryReader reader)
    {
        Vector3f _position = Vector3f.Read(reader);
        float _widthScale = reader.ReadF32();
        float _heightScale = reader.ReadF32();
        float _rotation = reader.ReadF32();
        ColorRGBA_1 _color = ColorRGBA_1.Read(reader);
        ColorRGBA_1 _lightmapColor = ColorRGBA_1.Read(reader);
        int _index = reader.ReadS32();
        
        return new(_position,
            _widthScale,
            _heightScale,
            _rotation,
            _color,
            _lightmapColor,
            _index);
    }

    public override string ToString() => $"TreeInstance\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("position: ");
        sb.AppendLine();
        sb.Append(position.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("widthScale: ");
        sb.AppendLine(widthScale.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("heightScale: ");
        sb.AppendLine(heightScale.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("rotation: ");
        sb.AppendLine(rotation.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("color: ");
        sb.AppendLine();
        sb.Append(color.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("lightmapColor: ");
        sb.AppendLine();
        sb.Append(lightmapColor.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("index: ");
        sb.AppendLine(index.ToString());

        return sb.ToString();
    }
}

/* $TreePrototype (3 fields) */
public record class TreePrototype(
    PPtr<GameObject> prefab,
    float bendFactor,
    int navMeshLod) : IUnityStructure
{
    public static TreePrototype Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _prefab = PPtr<GameObject>.Read(reader);
        float _bendFactor = reader.ReadF32();
        int _navMeshLod = reader.ReadS32();
        
        return new(_prefab,
            _bendFactor,
            _navMeshLod);
    }

    public override string ToString() => $"TreePrototype\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("prefab: ");
        sb.AppendLine(prefab.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("bendFactor: ");
        sb.AppendLine(bendFactor.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("navMeshLod: ");
        sb.AppendLine(navMeshLod.ToString());

        return sb.ToString();
    }
}

/* $Heightmap (9 fields) */
public record class Heightmap(
    short[] m_Heights,
    byte[] m_Holes,
    byte[] m_HolesLOD,
    bool m_EnableHolesTextureCompression,
    float[] m_PrecomputedError,
    float[] m_MinMaxPatchHeights,
    int m_Resolution,
    int m_Levels,
    Vector3f m_Scale) : IUnityStructure
{
    public static Heightmap Read(EndianBinaryReader reader)
    {
        short[] _m_Heights = BuiltInArray<short>.Read(reader);
        reader.AlignTo(4); /* m_Heights */
        byte[] _m_Holes = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_Holes */
        byte[] _m_HolesLOD = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_HolesLOD */
        bool _m_EnableHolesTextureCompression = reader.ReadBool();
        reader.AlignTo(4); /* m_EnableHolesTextureCompression */
        float[] _m_PrecomputedError = BuiltInArray<float>.Read(reader);
        reader.AlignTo(4); /* m_PrecomputedError */
        float[] _m_MinMaxPatchHeights = BuiltInArray<float>.Read(reader);
        reader.AlignTo(4); /* m_MinMaxPatchHeights */
        int _m_Resolution = reader.ReadS32();
        int _m_Levels = reader.ReadS32();
        Vector3f _m_Scale = Vector3f.Read(reader);
        
        return new(_m_Heights,
            _m_Holes,
            _m_HolesLOD,
            _m_EnableHolesTextureCompression,
            _m_PrecomputedError,
            _m_MinMaxPatchHeights,
            _m_Resolution,
            _m_Levels,
            _m_Scale);
    }

    public override string ToString() => $"Heightmap\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Heights: ");
        sb.AppendLine(m_Heights.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Holes: ");
        sb.AppendLine(m_Holes.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HolesLOD: ");
        sb.AppendLine(m_HolesLOD.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_EnableHolesTextureCompression: ");
        sb.AppendLine(m_EnableHolesTextureCompression.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PrecomputedError: ");
        sb.AppendLine(m_PrecomputedError.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MinMaxPatchHeights: ");
        sb.AppendLine(m_MinMaxPatchHeights.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Resolution: ");
        sb.AppendLine(m_Resolution.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Levels: ");
        sb.AppendLine(m_Levels.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Scale: ");
        sb.AppendLine();
        sb.Append(m_Scale.ToString(indent+4));

        return sb.ToString();
    }
}

/* $MinMaxCurve (5 fields) */
public record class MinMaxCurve(
    ushort minMaxState,
    float scalar,
    float minScalar,
    AnimationCurve_0 maxCurve,
    AnimationCurve_0 minCurve) : IUnityStructure
{
    public static MinMaxCurve Read(EndianBinaryReader reader)
    {
        ushort _minMaxState = reader.ReadU16();
        reader.AlignTo(4); /* minMaxState */
        float _scalar = reader.ReadF32();
        float _minScalar = reader.ReadF32();
        AnimationCurve_0 _maxCurve = AnimationCurve_0.Read(reader);
        reader.AlignTo(4); /* maxCurve */
        AnimationCurve_0 _minCurve = AnimationCurve_0.Read(reader);
        reader.AlignTo(4); /* minCurve */
        
        return new(_minMaxState,
            _scalar,
            _minScalar,
            _maxCurve,
            _minCurve);
    }

    public override string ToString() => $"MinMaxCurve\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("minMaxState: ");
        sb.AppendLine(minMaxState.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("scalar: ");
        sb.AppendLine(scalar.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("minScalar: ");
        sb.AppendLine(minScalar.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("maxCurve: ");
        sb.AppendLine();
        sb.Append(maxCurve.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("minCurve: ");
        sb.AppendLine();
        sb.Append(minCurve.ToString(indent+4));

        return sb.ToString();
    }
}

/* $InitialModule (17 fields) */
public record class InitialModule(
    bool enabled,
    MinMaxCurve startLifetime,
    MinMaxCurve startSpeed,
    MinMaxGradient startColor,
    MinMaxCurve startSize,
    MinMaxCurve startSizeY,
    MinMaxCurve startSizeZ,
    MinMaxCurve startRotationX,
    MinMaxCurve startRotationY,
    MinMaxCurve startRotation,
    float randomizeRotationDirection,
    int gravitySource,
    int maxNumParticles,
    Vector3f customEmitterVelocity,
    bool size3D,
    bool rotation3D,
    MinMaxCurve gravityModifier) : IUnityStructure
{
    public static InitialModule Read(EndianBinaryReader reader)
    {
        bool _enabled = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        MinMaxCurve _startLifetime = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* startLifetime */
        MinMaxCurve _startSpeed = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* startSpeed */
        MinMaxGradient _startColor = MinMaxGradient.Read(reader);
        reader.AlignTo(4); /* startColor */
        MinMaxCurve _startSize = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* startSize */
        MinMaxCurve _startSizeY = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* startSizeY */
        MinMaxCurve _startSizeZ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* startSizeZ */
        MinMaxCurve _startRotationX = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* startRotationX */
        MinMaxCurve _startRotationY = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* startRotationY */
        MinMaxCurve _startRotation = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* startRotation */
        float _randomizeRotationDirection = reader.ReadF32();
        int _gravitySource = reader.ReadS32();
        int _maxNumParticles = reader.ReadS32();
        Vector3f _customEmitterVelocity = Vector3f.Read(reader);
        bool _size3D = reader.ReadBool();
        bool _rotation3D = reader.ReadBool();
        reader.AlignTo(4); /* rotation3D */
        MinMaxCurve _gravityModifier = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* gravityModifier */
        
        return new(_enabled,
            _startLifetime,
            _startSpeed,
            _startColor,
            _startSize,
            _startSizeY,
            _startSizeZ,
            _startRotationX,
            _startRotationY,
            _startRotation,
            _randomizeRotationDirection,
            _gravitySource,
            _maxNumParticles,
            _customEmitterVelocity,
            _size3D,
            _rotation3D,
            _gravityModifier);
    }

    public override string ToString() => $"InitialModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("enabled: ");
        sb.AppendLine(enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("startLifetime: ");
        sb.AppendLine();
        sb.Append(startLifetime.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("startSpeed: ");
        sb.AppendLine();
        sb.Append(startSpeed.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("startColor: ");
        sb.AppendLine();
        sb.Append(startColor.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("startSize: ");
        sb.AppendLine();
        sb.Append(startSize.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("startSizeY: ");
        sb.AppendLine();
        sb.Append(startSizeY.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("startSizeZ: ");
        sb.AppendLine();
        sb.Append(startSizeZ.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("startRotationX: ");
        sb.AppendLine();
        sb.Append(startRotationX.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("startRotationY: ");
        sb.AppendLine();
        sb.Append(startRotationY.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("startRotation: ");
        sb.AppendLine();
        sb.Append(startRotation.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("randomizeRotationDirection: ");
        sb.AppendLine(randomizeRotationDirection.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("gravitySource: ");
        sb.AppendLine(gravitySource.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("maxNumParticles: ");
        sb.AppendLine(maxNumParticles.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("customEmitterVelocity: ");
        sb.AppendLine();
        sb.Append(customEmitterVelocity.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("size3D: ");
        sb.AppendLine(size3D.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("rotation3D: ");
        sb.AppendLine(rotation3D.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("gravityModifier: ");
        sb.AppendLine();
        sb.Append(gravityModifier.ToString(indent+4));

        return sb.ToString();
    }
}

/* $MinMaxGradient (5 fields) */
public record class MinMaxGradient(
    ushort minMaxState,
    ColorRGBA_0 minColor,
    ColorRGBA_0 maxColor,
    Gradient maxGradient,
    Gradient minGradient) : IUnityStructure
{
    public static MinMaxGradient Read(EndianBinaryReader reader)
    {
        ushort _minMaxState = reader.ReadU16();
        reader.AlignTo(4); /* minMaxState */
        ColorRGBA_0 _minColor = ColorRGBA_0.Read(reader);
        ColorRGBA_0 _maxColor = ColorRGBA_0.Read(reader);
        Gradient _maxGradient = Gradient.Read(reader);
        reader.AlignTo(4); /* maxGradient */
        Gradient _minGradient = Gradient.Read(reader);
        reader.AlignTo(4); /* minGradient */
        
        return new(_minMaxState,
            _minColor,
            _maxColor,
            _maxGradient,
            _minGradient);
    }

    public override string ToString() => $"MinMaxGradient\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("minMaxState: ");
        sb.AppendLine(minMaxState.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("minColor: ");
        sb.AppendLine();
        sb.Append(minColor.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("maxColor: ");
        sb.AppendLine();
        sb.Append(maxColor.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("maxGradient: ");
        sb.AppendLine();
        sb.Append(maxGradient.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("minGradient: ");
        sb.AppendLine();
        sb.Append(minGradient.ToString(indent+4));

        return sb.ToString();
    }
}

/* $ShapeModule (34 fields) */
public record class ShapeModule(
    bool enabled,
    int type,
    float angle,
    float length,
    Vector3f boxThickness,
    float radiusThickness,
    float donutRadius,
    Vector3f m_Position,
    Vector3f m_Rotation,
    Vector3f m_Scale,
    int placementMode,
    int m_MeshMaterialIndex,
    float m_MeshNormalOffset,
    MultiModeParameter_0 m_MeshSpawn,
    PPtr<Mesh> m_Mesh,
    PPtr<MeshRenderer> m_MeshRenderer,
    PPtr<SkinnedMeshRenderer> m_SkinnedMeshRenderer,
    PPtr<Sprite> m_Sprite,
    PPtr<SpriteRenderer> m_SpriteRenderer,
    bool m_UseMeshMaterialIndex,
    bool m_UseMeshColors,
    bool alignToDirection,
    PPtr<Texture2D> m_Texture,
    int m_TextureClipChannel,
    float m_TextureClipThreshold,
    int m_TextureUVChannel,
    bool m_TextureColorAffectsParticles,
    bool m_TextureAlphaAffectsParticles,
    bool m_TextureBilinearFiltering,
    float randomDirectionAmount,
    float sphericalDirectionAmount,
    float randomPositionAmount,
    MultiModeParameter_1 radius,
    MultiModeParameter_1 arc) : IUnityStructure
{
    public static ShapeModule Read(EndianBinaryReader reader)
    {
        bool _enabled = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        int _type = reader.ReadS32();
        float _angle = reader.ReadF32();
        float _length = reader.ReadF32();
        Vector3f _boxThickness = Vector3f.Read(reader);
        float _radiusThickness = reader.ReadF32();
        float _donutRadius = reader.ReadF32();
        Vector3f _m_Position = Vector3f.Read(reader);
        Vector3f _m_Rotation = Vector3f.Read(reader);
        Vector3f _m_Scale = Vector3f.Read(reader);
        int _placementMode = reader.ReadS32();
        int _m_MeshMaterialIndex = reader.ReadS32();
        float _m_MeshNormalOffset = reader.ReadF32();
        MultiModeParameter_0 _m_MeshSpawn = MultiModeParameter_0.Read(reader);
        reader.AlignTo(4); /* m_MeshSpawn */
        PPtr<Mesh> _m_Mesh = PPtr<Mesh>.Read(reader);
        PPtr<MeshRenderer> _m_MeshRenderer = PPtr<MeshRenderer>.Read(reader);
        PPtr<SkinnedMeshRenderer> _m_SkinnedMeshRenderer = PPtr<SkinnedMeshRenderer>.Read(reader);
        PPtr<Sprite> _m_Sprite = PPtr<Sprite>.Read(reader);
        PPtr<SpriteRenderer> _m_SpriteRenderer = PPtr<SpriteRenderer>.Read(reader);
        bool _m_UseMeshMaterialIndex = reader.ReadBool();
        bool _m_UseMeshColors = reader.ReadBool();
        bool _alignToDirection = reader.ReadBool();
        reader.AlignTo(4); /* alignToDirection */
        PPtr<Texture2D> _m_Texture = PPtr<Texture2D>.Read(reader);
        int _m_TextureClipChannel = reader.ReadS32();
        float _m_TextureClipThreshold = reader.ReadF32();
        int _m_TextureUVChannel = reader.ReadS32();
        bool _m_TextureColorAffectsParticles = reader.ReadBool();
        bool _m_TextureAlphaAffectsParticles = reader.ReadBool();
        bool _m_TextureBilinearFiltering = reader.ReadBool();
        reader.AlignTo(4); /* m_TextureBilinearFiltering */
        float _randomDirectionAmount = reader.ReadF32();
        float _sphericalDirectionAmount = reader.ReadF32();
        float _randomPositionAmount = reader.ReadF32();
        MultiModeParameter_1 _radius = MultiModeParameter_1.Read(reader);
        reader.AlignTo(4); /* radius */
        MultiModeParameter_1 _arc = MultiModeParameter_1.Read(reader);
        reader.AlignTo(4); /* arc */
        
        return new(_enabled,
            _type,
            _angle,
            _length,
            _boxThickness,
            _radiusThickness,
            _donutRadius,
            _m_Position,
            _m_Rotation,
            _m_Scale,
            _placementMode,
            _m_MeshMaterialIndex,
            _m_MeshNormalOffset,
            _m_MeshSpawn,
            _m_Mesh,
            _m_MeshRenderer,
            _m_SkinnedMeshRenderer,
            _m_Sprite,
            _m_SpriteRenderer,
            _m_UseMeshMaterialIndex,
            _m_UseMeshColors,
            _alignToDirection,
            _m_Texture,
            _m_TextureClipChannel,
            _m_TextureClipThreshold,
            _m_TextureUVChannel,
            _m_TextureColorAffectsParticles,
            _m_TextureAlphaAffectsParticles,
            _m_TextureBilinearFiltering,
            _randomDirectionAmount,
            _sphericalDirectionAmount,
            _randomPositionAmount,
            _radius,
            _arc);
    }

    public override string ToString() => $"ShapeModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("enabled: ");
        sb.AppendLine(enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("type: ");
        sb.AppendLine(type.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("angle: ");
        sb.AppendLine(angle.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("length: ");
        sb.AppendLine(length.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("boxThickness: ");
        sb.AppendLine();
        sb.Append(boxThickness.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("radiusThickness: ");
        sb.AppendLine(radiusThickness.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("donutRadius: ");
        sb.AppendLine(donutRadius.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Position: ");
        sb.AppendLine();
        sb.Append(m_Position.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Rotation: ");
        sb.AppendLine();
        sb.Append(m_Rotation.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Scale: ");
        sb.AppendLine();
        sb.Append(m_Scale.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("placementMode: ");
        sb.AppendLine(placementMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MeshMaterialIndex: ");
        sb.AppendLine(m_MeshMaterialIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MeshNormalOffset: ");
        sb.AppendLine(m_MeshNormalOffset.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MeshSpawn: ");
        sb.AppendLine();
        sb.Append(m_MeshSpawn.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Mesh: ");
        sb.AppendLine(m_Mesh.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MeshRenderer: ");
        sb.AppendLine(m_MeshRenderer.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SkinnedMeshRenderer: ");
        sb.AppendLine(m_SkinnedMeshRenderer.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Sprite: ");
        sb.AppendLine(m_Sprite.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SpriteRenderer: ");
        sb.AppendLine(m_SpriteRenderer.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_UseMeshMaterialIndex: ");
        sb.AppendLine(m_UseMeshMaterialIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_UseMeshColors: ");
        sb.AppendLine(m_UseMeshColors.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("alignToDirection: ");
        sb.AppendLine(alignToDirection.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Texture: ");
        sb.AppendLine(m_Texture.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TextureClipChannel: ");
        sb.AppendLine(m_TextureClipChannel.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TextureClipThreshold: ");
        sb.AppendLine(m_TextureClipThreshold.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TextureUVChannel: ");
        sb.AppendLine(m_TextureUVChannel.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TextureColorAffectsParticles: ");
        sb.AppendLine(m_TextureColorAffectsParticles.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TextureAlphaAffectsParticles: ");
        sb.AppendLine(m_TextureAlphaAffectsParticles.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TextureBilinearFiltering: ");
        sb.AppendLine(m_TextureBilinearFiltering.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("randomDirectionAmount: ");
        sb.AppendLine(randomDirectionAmount.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sphericalDirectionAmount: ");
        sb.AppendLine(sphericalDirectionAmount.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("randomPositionAmount: ");
        sb.AppendLine(randomPositionAmount.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("radius: ");
        sb.AppendLine();
        sb.Append(radius.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("arc: ");
        sb.AppendLine();
        sb.Append(arc.ToString(indent+4));

        return sb.ToString();
    }
}

/* $MultiModeParameter_0 (3 fields) */
public record class MultiModeParameter_0(
    int mode,
    float spread,
    MinMaxCurve speed) : IUnityStructure
{
    public static MultiModeParameter_0 Read(EndianBinaryReader reader)
    {
        int _mode = reader.ReadS32();
        float _spread = reader.ReadF32();
        MinMaxCurve _speed = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* speed */
        
        return new(_mode,
            _spread,
            _speed);
    }

    public override string ToString() => $"MultiModeParameter_0\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("mode: ");
        sb.AppendLine(mode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("spread: ");
        sb.AppendLine(spread.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("speed: ");
        sb.AppendLine();
        sb.Append(speed.ToString(indent+4));

        return sb.ToString();
    }
}

/* $MultiModeParameter_1 (4 fields) */
public record class MultiModeParameter_1(
    float @value,
    int mode,
    float spread,
    MinMaxCurve speed) : IUnityStructure
{
    public static MultiModeParameter_1 Read(EndianBinaryReader reader)
    {
        float _value = reader.ReadF32();
        int _mode = reader.ReadS32();
        float _spread = reader.ReadF32();
        MinMaxCurve _speed = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* speed */
        
        return new(_value,
            _mode,
            _spread,
            _speed);
    }

    public override string ToString() => $"MultiModeParameter_1\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("@value: ");
        sb.AppendLine(@value.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("mode: ");
        sb.AppendLine(mode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("spread: ");
        sb.AppendLine(spread.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("speed: ");
        sb.AppendLine();
        sb.Append(speed.ToString(indent+4));

        return sb.ToString();
    }
}

/* $EmissionModule (5 fields) */
public record class EmissionModule(
    bool enabled,
    MinMaxCurve rateOverTime,
    MinMaxCurve rateOverDistance,
    int m_BurstCount,
    ParticleSystemEmissionBurst[] m_Bursts) : IUnityStructure
{
    public static EmissionModule Read(EndianBinaryReader reader)
    {
        bool _enabled = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        MinMaxCurve _rateOverTime = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* rateOverTime */
        MinMaxCurve _rateOverDistance = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* rateOverDistance */
        int _m_BurstCount = reader.ReadS32();
        reader.AlignTo(4); /* m_BurstCount */
        ParticleSystemEmissionBurst[] _m_Bursts = BuiltInArray<ParticleSystemEmissionBurst>.Read(reader);
        reader.AlignTo(4); /* m_Bursts */
        
        return new(_enabled,
            _rateOverTime,
            _rateOverDistance,
            _m_BurstCount,
            _m_Bursts);
    }

    public override string ToString() => $"EmissionModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("enabled: ");
        sb.AppendLine(enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("rateOverTime: ");
        sb.AppendLine();
        sb.Append(rateOverTime.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("rateOverDistance: ");
        sb.AppendLine();
        sb.Append(rateOverDistance.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BurstCount: ");
        sb.AppendLine(m_BurstCount.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Bursts: ");
        sb.AppendLine(m_Bursts.ToString());

        return sb.ToString();
    }
}

/* $ParticleSystemEmissionBurst (5 fields) */
public record class ParticleSystemEmissionBurst(
    float time,
    MinMaxCurve countCurve,
    int cycleCount,
    float repeatInterval,
    float probability) : IUnityStructure
{
    public static ParticleSystemEmissionBurst Read(EndianBinaryReader reader)
    {
        float _time = reader.ReadF32();
        MinMaxCurve _countCurve = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* countCurve */
        int _cycleCount = reader.ReadS32();
        float _repeatInterval = reader.ReadF32();
        float _probability = reader.ReadF32();
        
        return new(_time,
            _countCurve,
            _cycleCount,
            _repeatInterval,
            _probability);
    }

    public override string ToString() => $"ParticleSystemEmissionBurst\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("time: ");
        sb.AppendLine(time.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("countCurve: ");
        sb.AppendLine();
        sb.Append(countCurve.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("cycleCount: ");
        sb.AppendLine(cycleCount.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("repeatInterval: ");
        sb.AppendLine(repeatInterval.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("probability: ");
        sb.AppendLine(probability.ToString());

        return sb.ToString();
    }
}

/* $SizeModule (5 fields) */
public record class SizeModule(
    bool enabled,
    MinMaxCurve curve,
    MinMaxCurve y,
    MinMaxCurve z,
    bool separateAxes) : IUnityStructure
{
    public static SizeModule Read(EndianBinaryReader reader)
    {
        bool _enabled = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        MinMaxCurve _curve = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* curve */
        MinMaxCurve _y = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* y */
        MinMaxCurve _z = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* z */
        bool _separateAxes = reader.ReadBool();
        reader.AlignTo(4); /* separateAxes */
        
        return new(_enabled,
            _curve,
            _y,
            _z,
            _separateAxes);
    }

    public override string ToString() => $"SizeModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("enabled: ");
        sb.AppendLine(enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("curve: ");
        sb.AppendLine();
        sb.Append(curve.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("y: ");
        sb.AppendLine();
        sb.Append(y.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("z: ");
        sb.AppendLine();
        sb.Append(z.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("separateAxes: ");
        sb.AppendLine(separateAxes.ToString());

        return sb.ToString();
    }
}

/* $RotationModule (5 fields) */
public record class RotationModule(
    bool enabled,
    MinMaxCurve x,
    MinMaxCurve y,
    MinMaxCurve curve,
    bool separateAxes) : IUnityStructure
{
    public static RotationModule Read(EndianBinaryReader reader)
    {
        bool _enabled = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        MinMaxCurve _x = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* x */
        MinMaxCurve _y = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* y */
        MinMaxCurve _curve = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* curve */
        bool _separateAxes = reader.ReadBool();
        reader.AlignTo(4); /* separateAxes */
        
        return new(_enabled,
            _x,
            _y,
            _curve,
            _separateAxes);
    }

    public override string ToString() => $"RotationModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("enabled: ");
        sb.AppendLine(enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("x: ");
        sb.AppendLine();
        sb.Append(x.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("y: ");
        sb.AppendLine();
        sb.Append(y.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("curve: ");
        sb.AppendLine();
        sb.Append(curve.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("separateAxes: ");
        sb.AppendLine(separateAxes.ToString());

        return sb.ToString();
    }
}

/* $ColorModule (2 fields) */
public record class ColorModule(
    bool enabled,
    MinMaxGradient gradient) : IUnityStructure
{
    public static ColorModule Read(EndianBinaryReader reader)
    {
        bool _enabled = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        MinMaxGradient _gradient = MinMaxGradient.Read(reader);
        reader.AlignTo(4); /* gradient */
        
        return new(_enabled,
            _gradient);
    }

    public override string ToString() => $"ColorModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("enabled: ");
        sb.AppendLine(enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("gradient: ");
        sb.AppendLine();
        sb.Append(gradient.ToString(indent+4));

        return sb.ToString();
    }
}

/* $UVModule (17 fields) */
public record class UVModule(
    bool enabled,
    int mode,
    int timeMode,
    float fps,
    MinMaxCurve frameOverTime,
    MinMaxCurve startFrame,
    Vector2f speedRange,
    int tilesX,
    int tilesY,
    int animationType,
    int rowIndex,
    float cycles,
    int uvChannelMask,
    int rowMode,
    SpriteData[] sprites,
    float flipU,
    float flipV) : IUnityStructure
{
    public static UVModule Read(EndianBinaryReader reader)
    {
        bool _enabled = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        int _mode = reader.ReadS32();
        int _timeMode = reader.ReadS32();
        float _fps = reader.ReadF32();
        MinMaxCurve _frameOverTime = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* frameOverTime */
        MinMaxCurve _startFrame = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* startFrame */
        Vector2f _speedRange = Vector2f.Read(reader);
        int _tilesX = reader.ReadS32();
        int _tilesY = reader.ReadS32();
        int _animationType = reader.ReadS32();
        int _rowIndex = reader.ReadS32();
        float _cycles = reader.ReadF32();
        int _uvChannelMask = reader.ReadS32();
        int _rowMode = reader.ReadS32();
        SpriteData[] _sprites = BuiltInArray<SpriteData>.Read(reader);
        reader.AlignTo(4); /* sprites */
        float _flipU = reader.ReadF32();
        float _flipV = reader.ReadF32();
        
        return new(_enabled,
            _mode,
            _timeMode,
            _fps,
            _frameOverTime,
            _startFrame,
            _speedRange,
            _tilesX,
            _tilesY,
            _animationType,
            _rowIndex,
            _cycles,
            _uvChannelMask,
            _rowMode,
            _sprites,
            _flipU,
            _flipV);
    }

    public override string ToString() => $"UVModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("enabled: ");
        sb.AppendLine(enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("mode: ");
        sb.AppendLine(mode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("timeMode: ");
        sb.AppendLine(timeMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("fps: ");
        sb.AppendLine(fps.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("frameOverTime: ");
        sb.AppendLine();
        sb.Append(frameOverTime.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("startFrame: ");
        sb.AppendLine();
        sb.Append(startFrame.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("speedRange: ");
        sb.AppendLine();
        sb.Append(speedRange.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("tilesX: ");
        sb.AppendLine(tilesX.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("tilesY: ");
        sb.AppendLine(tilesY.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("animationType: ");
        sb.AppendLine(animationType.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("rowIndex: ");
        sb.AppendLine(rowIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("cycles: ");
        sb.AppendLine(cycles.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("uvChannelMask: ");
        sb.AppendLine(uvChannelMask.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("rowMode: ");
        sb.AppendLine(rowMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sprites: ");
        sb.AppendLine(sprites.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("flipU: ");
        sb.AppendLine(flipU.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("flipV: ");
        sb.AppendLine(flipV.ToString());

        return sb.ToString();
    }
}

/* $SpriteData (1 fields) */
public record class SpriteData(
    PPtr<Object> sprite) : IUnityStructure
{
    public static SpriteData Read(EndianBinaryReader reader)
    {
        PPtr<Object> _sprite = PPtr<Object>.Read(reader);
        
        return new(_sprite);
    }

    public override string ToString() => $"SpriteData\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sprite: ");
        sb.AppendLine(sprite.ToString());

        return sb.ToString();
    }
}

/* $VelocityModule (13 fields) */
public record class VelocityModule(
    bool enabled,
    MinMaxCurve x,
    MinMaxCurve y,
    MinMaxCurve z,
    MinMaxCurve orbitalX,
    MinMaxCurve orbitalY,
    MinMaxCurve orbitalZ,
    MinMaxCurve orbitalOffsetX,
    MinMaxCurve orbitalOffsetY,
    MinMaxCurve orbitalOffsetZ,
    MinMaxCurve radial,
    MinMaxCurve speedModifier,
    bool inWorldSpace) : IUnityStructure
{
    public static VelocityModule Read(EndianBinaryReader reader)
    {
        bool _enabled = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        MinMaxCurve _x = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* x */
        MinMaxCurve _y = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* y */
        MinMaxCurve _z = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* z */
        MinMaxCurve _orbitalX = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* orbitalX */
        MinMaxCurve _orbitalY = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* orbitalY */
        MinMaxCurve _orbitalZ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* orbitalZ */
        MinMaxCurve _orbitalOffsetX = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* orbitalOffsetX */
        MinMaxCurve _orbitalOffsetY = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* orbitalOffsetY */
        MinMaxCurve _orbitalOffsetZ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* orbitalOffsetZ */
        MinMaxCurve _radial = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* radial */
        MinMaxCurve _speedModifier = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* speedModifier */
        bool _inWorldSpace = reader.ReadBool();
        reader.AlignTo(4); /* inWorldSpace */
        
        return new(_enabled,
            _x,
            _y,
            _z,
            _orbitalX,
            _orbitalY,
            _orbitalZ,
            _orbitalOffsetX,
            _orbitalOffsetY,
            _orbitalOffsetZ,
            _radial,
            _speedModifier,
            _inWorldSpace);
    }

    public override string ToString() => $"VelocityModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("enabled: ");
        sb.AppendLine(enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("x: ");
        sb.AppendLine();
        sb.Append(x.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("y: ");
        sb.AppendLine();
        sb.Append(y.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("z: ");
        sb.AppendLine();
        sb.Append(z.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("orbitalX: ");
        sb.AppendLine();
        sb.Append(orbitalX.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("orbitalY: ");
        sb.AppendLine();
        sb.Append(orbitalY.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("orbitalZ: ");
        sb.AppendLine();
        sb.Append(orbitalZ.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("orbitalOffsetX: ");
        sb.AppendLine();
        sb.Append(orbitalOffsetX.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("orbitalOffsetY: ");
        sb.AppendLine();
        sb.Append(orbitalOffsetY.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("orbitalOffsetZ: ");
        sb.AppendLine();
        sb.Append(orbitalOffsetZ.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("radial: ");
        sb.AppendLine();
        sb.Append(radial.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("speedModifier: ");
        sb.AppendLine();
        sb.Append(speedModifier.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("inWorldSpace: ");
        sb.AppendLine(inWorldSpace.ToString());

        return sb.ToString();
    }
}

/* $InheritVelocityModule (3 fields) */
public record class InheritVelocityModule(
    bool enabled,
    int m_Mode,
    MinMaxCurve m_Curve) : IUnityStructure
{
    public static InheritVelocityModule Read(EndianBinaryReader reader)
    {
        bool _enabled = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        int _m_Mode = reader.ReadS32();
        MinMaxCurve _m_Curve = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* m_Curve */
        
        return new(_enabled,
            _m_Mode,
            _m_Curve);
    }

    public override string ToString() => $"InheritVelocityModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("enabled: ");
        sb.AppendLine(enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Mode: ");
        sb.AppendLine(m_Mode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Curve: ");
        sb.AppendLine();
        sb.Append(m_Curve.ToString(indent+4));

        return sb.ToString();
    }
}

/* $LifetimeByEmitterSpeedModule (3 fields) */
public record class LifetimeByEmitterSpeedModule(
    bool enabled,
    MinMaxCurve m_Curve,
    Vector2f m_Range) : IUnityStructure
{
    public static LifetimeByEmitterSpeedModule Read(EndianBinaryReader reader)
    {
        bool _enabled = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        MinMaxCurve _m_Curve = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* m_Curve */
        Vector2f _m_Range = Vector2f.Read(reader);
        
        return new(_enabled,
            _m_Curve,
            _m_Range);
    }

    public override string ToString() => $"LifetimeByEmitterSpeedModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("enabled: ");
        sb.AppendLine(enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Curve: ");
        sb.AppendLine();
        sb.Append(m_Curve.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Range: ");
        sb.AppendLine();
        sb.Append(m_Range.ToString(indent+4));

        return sb.ToString();
    }
}

/* $ForceModule (6 fields) */
public record class ForceModule(
    bool enabled,
    MinMaxCurve x,
    MinMaxCurve y,
    MinMaxCurve z,
    bool inWorldSpace,
    bool randomizePerFrame) : IUnityStructure
{
    public static ForceModule Read(EndianBinaryReader reader)
    {
        bool _enabled = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        MinMaxCurve _x = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* x */
        MinMaxCurve _y = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* y */
        MinMaxCurve _z = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* z */
        bool _inWorldSpace = reader.ReadBool();
        bool _randomizePerFrame = reader.ReadBool();
        reader.AlignTo(4); /* randomizePerFrame */
        
        return new(_enabled,
            _x,
            _y,
            _z,
            _inWorldSpace,
            _randomizePerFrame);
    }

    public override string ToString() => $"ForceModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("enabled: ");
        sb.AppendLine(enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("x: ");
        sb.AppendLine();
        sb.Append(x.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("y: ");
        sb.AppendLine();
        sb.Append(y.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("z: ");
        sb.AppendLine();
        sb.Append(z.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("inWorldSpace: ");
        sb.AppendLine(inWorldSpace.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("randomizePerFrame: ");
        sb.AppendLine(randomizePerFrame.ToString());

        return sb.ToString();
    }
}

/* $ExternalForcesModule (5 fields) */
public record class ExternalForcesModule(
    bool enabled,
    MinMaxCurve multiplierCurve,
    int influenceFilter,
    BitField influenceMask,
    PPtr<ParticleSystemForceField>[] influenceList) : IUnityStructure
{
    public static ExternalForcesModule Read(EndianBinaryReader reader)
    {
        bool _enabled = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        MinMaxCurve _multiplierCurve = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* multiplierCurve */
        int _influenceFilter = reader.ReadS32();
        BitField _influenceMask = BitField.Read(reader);
        PPtr<ParticleSystemForceField>[] _influenceList = BuiltInArray<PPtr<ParticleSystemForceField>>.Read(reader);
        reader.AlignTo(4); /* influenceList */
        
        return new(_enabled,
            _multiplierCurve,
            _influenceFilter,
            _influenceMask,
            _influenceList);
    }

    public override string ToString() => $"ExternalForcesModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("enabled: ");
        sb.AppendLine(enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("multiplierCurve: ");
        sb.AppendLine();
        sb.Append(multiplierCurve.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("influenceFilter: ");
        sb.AppendLine(influenceFilter.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("influenceMask: ");
        sb.AppendLine();
        sb.Append(influenceMask.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("influenceList: ");
        sb.AppendLine(influenceList.ToString());

        return sb.ToString();
    }
}

/* $ClampVelocityModule (11 fields) */
public record class ClampVelocityModule(
    bool enabled,
    MinMaxCurve x,
    MinMaxCurve y,
    MinMaxCurve z,
    MinMaxCurve magnitude,
    bool separateAxis,
    bool inWorldSpace,
    bool multiplyDragByParticleSize,
    bool multiplyDragByParticleVelocity,
    float dampen,
    MinMaxCurve drag) : IUnityStructure
{
    public static ClampVelocityModule Read(EndianBinaryReader reader)
    {
        bool _enabled = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        MinMaxCurve _x = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* x */
        MinMaxCurve _y = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* y */
        MinMaxCurve _z = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* z */
        MinMaxCurve _magnitude = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* magnitude */
        bool _separateAxis = reader.ReadBool();
        bool _inWorldSpace = reader.ReadBool();
        bool _multiplyDragByParticleSize = reader.ReadBool();
        bool _multiplyDragByParticleVelocity = reader.ReadBool();
        reader.AlignTo(4); /* multiplyDragByParticleVelocity */
        float _dampen = reader.ReadF32();
        MinMaxCurve _drag = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* drag */
        
        return new(_enabled,
            _x,
            _y,
            _z,
            _magnitude,
            _separateAxis,
            _inWorldSpace,
            _multiplyDragByParticleSize,
            _multiplyDragByParticleVelocity,
            _dampen,
            _drag);
    }

    public override string ToString() => $"ClampVelocityModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("enabled: ");
        sb.AppendLine(enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("x: ");
        sb.AppendLine();
        sb.Append(x.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("y: ");
        sb.AppendLine();
        sb.Append(y.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("z: ");
        sb.AppendLine();
        sb.Append(z.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("magnitude: ");
        sb.AppendLine();
        sb.Append(magnitude.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("separateAxis: ");
        sb.AppendLine(separateAxis.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("inWorldSpace: ");
        sb.AppendLine(inWorldSpace.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("multiplyDragByParticleSize: ");
        sb.AppendLine(multiplyDragByParticleSize.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("multiplyDragByParticleVelocity: ");
        sb.AppendLine(multiplyDragByParticleVelocity.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("dampen: ");
        sb.AppendLine(dampen.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("drag: ");
        sb.AppendLine();
        sb.Append(drag.ToString(indent+4));

        return sb.ToString();
    }
}

/* $NoiseModule (19 fields) */
public record class NoiseModule(
    bool enabled,
    MinMaxCurve strength,
    MinMaxCurve strengthY,
    MinMaxCurve strengthZ,
    bool separateAxes,
    float frequency,
    bool damping,
    int octaves,
    float octaveMultiplier,
    float octaveScale,
    int quality,
    MinMaxCurve scrollSpeed,
    MinMaxCurve remap,
    MinMaxCurve remapY,
    MinMaxCurve remapZ,
    bool remapEnabled,
    MinMaxCurve positionAmount,
    MinMaxCurve rotationAmount,
    MinMaxCurve sizeAmount) : IUnityStructure
{
    public static NoiseModule Read(EndianBinaryReader reader)
    {
        bool _enabled = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        MinMaxCurve _strength = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* strength */
        MinMaxCurve _strengthY = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* strengthY */
        MinMaxCurve _strengthZ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* strengthZ */
        bool _separateAxes = reader.ReadBool();
        reader.AlignTo(4); /* separateAxes */
        float _frequency = reader.ReadF32();
        bool _damping = reader.ReadBool();
        reader.AlignTo(4); /* damping */
        int _octaves = reader.ReadS32();
        float _octaveMultiplier = reader.ReadF32();
        float _octaveScale = reader.ReadF32();
        int _quality = reader.ReadS32();
        MinMaxCurve _scrollSpeed = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* scrollSpeed */
        MinMaxCurve _remap = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* remap */
        MinMaxCurve _remapY = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* remapY */
        MinMaxCurve _remapZ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* remapZ */
        bool _remapEnabled = reader.ReadBool();
        reader.AlignTo(4); /* remapEnabled */
        MinMaxCurve _positionAmount = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* positionAmount */
        MinMaxCurve _rotationAmount = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* rotationAmount */
        MinMaxCurve _sizeAmount = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* sizeAmount */
        
        return new(_enabled,
            _strength,
            _strengthY,
            _strengthZ,
            _separateAxes,
            _frequency,
            _damping,
            _octaves,
            _octaveMultiplier,
            _octaveScale,
            _quality,
            _scrollSpeed,
            _remap,
            _remapY,
            _remapZ,
            _remapEnabled,
            _positionAmount,
            _rotationAmount,
            _sizeAmount);
    }

    public override string ToString() => $"NoiseModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("enabled: ");
        sb.AppendLine(enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("strength: ");
        sb.AppendLine();
        sb.Append(strength.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("strengthY: ");
        sb.AppendLine();
        sb.Append(strengthY.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("strengthZ: ");
        sb.AppendLine();
        sb.Append(strengthZ.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("separateAxes: ");
        sb.AppendLine(separateAxes.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("frequency: ");
        sb.AppendLine(frequency.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("damping: ");
        sb.AppendLine(damping.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("octaves: ");
        sb.AppendLine(octaves.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("octaveMultiplier: ");
        sb.AppendLine(octaveMultiplier.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("octaveScale: ");
        sb.AppendLine(octaveScale.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("quality: ");
        sb.AppendLine(quality.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("scrollSpeed: ");
        sb.AppendLine();
        sb.Append(scrollSpeed.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("remap: ");
        sb.AppendLine();
        sb.Append(remap.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("remapY: ");
        sb.AppendLine();
        sb.Append(remapY.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("remapZ: ");
        sb.AppendLine();
        sb.Append(remapZ.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("remapEnabled: ");
        sb.AppendLine(remapEnabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("positionAmount: ");
        sb.AppendLine();
        sb.Append(positionAmount.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("rotationAmount: ");
        sb.AppendLine();
        sb.Append(rotationAmount.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sizeAmount: ");
        sb.AppendLine();
        sb.Append(sizeAmount.ToString(indent+4));

        return sb.ToString();
    }
}

/* $SizeBySpeedModule (6 fields) */
public record class SizeBySpeedModule(
    bool enabled,
    MinMaxCurve curve,
    MinMaxCurve y,
    MinMaxCurve z,
    Vector2f range,
    bool separateAxes) : IUnityStructure
{
    public static SizeBySpeedModule Read(EndianBinaryReader reader)
    {
        bool _enabled = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        MinMaxCurve _curve = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* curve */
        MinMaxCurve _y = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* y */
        MinMaxCurve _z = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* z */
        Vector2f _range = Vector2f.Read(reader);
        bool _separateAxes = reader.ReadBool();
        reader.AlignTo(4); /* separateAxes */
        
        return new(_enabled,
            _curve,
            _y,
            _z,
            _range,
            _separateAxes);
    }

    public override string ToString() => $"SizeBySpeedModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("enabled: ");
        sb.AppendLine(enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("curve: ");
        sb.AppendLine();
        sb.Append(curve.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("y: ");
        sb.AppendLine();
        sb.Append(y.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("z: ");
        sb.AppendLine();
        sb.Append(z.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("range: ");
        sb.AppendLine();
        sb.Append(range.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("separateAxes: ");
        sb.AppendLine(separateAxes.ToString());

        return sb.ToString();
    }
}

/* $RotationBySpeedModule (6 fields) */
public record class RotationBySpeedModule(
    bool enabled,
    MinMaxCurve x,
    MinMaxCurve y,
    MinMaxCurve curve,
    bool separateAxes,
    Vector2f range) : IUnityStructure
{
    public static RotationBySpeedModule Read(EndianBinaryReader reader)
    {
        bool _enabled = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        MinMaxCurve _x = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* x */
        MinMaxCurve _y = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* y */
        MinMaxCurve _curve = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* curve */
        bool _separateAxes = reader.ReadBool();
        reader.AlignTo(4); /* separateAxes */
        Vector2f _range = Vector2f.Read(reader);
        
        return new(_enabled,
            _x,
            _y,
            _curve,
            _separateAxes,
            _range);
    }

    public override string ToString() => $"RotationBySpeedModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("enabled: ");
        sb.AppendLine(enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("x: ");
        sb.AppendLine();
        sb.Append(x.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("y: ");
        sb.AppendLine();
        sb.Append(y.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("curve: ");
        sb.AppendLine();
        sb.Append(curve.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("separateAxes: ");
        sb.AppendLine(separateAxes.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("range: ");
        sb.AppendLine();
        sb.Append(range.ToString(indent+4));

        return sb.ToString();
    }
}

/* $ColorBySpeedModule (3 fields) */
public record class ColorBySpeedModule(
    bool enabled,
    MinMaxGradient gradient,
    Vector2f range) : IUnityStructure
{
    public static ColorBySpeedModule Read(EndianBinaryReader reader)
    {
        bool _enabled = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        MinMaxGradient _gradient = MinMaxGradient.Read(reader);
        reader.AlignTo(4); /* gradient */
        Vector2f _range = Vector2f.Read(reader);
        
        return new(_enabled,
            _gradient,
            _range);
    }

    public override string ToString() => $"ColorBySpeedModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("enabled: ");
        sb.AppendLine(enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("gradient: ");
        sb.AppendLine();
        sb.Append(gradient.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("range: ");
        sb.AppendLine();
        sb.Append(range.ToString(indent+4));

        return sb.ToString();
    }
}

/* $CollisionModule (21 fields) */
public record class CollisionModule(
    bool enabled,
    int type,
    int collisionMode,
    float colliderForce,
    bool multiplyColliderForceByParticleSize,
    bool multiplyColliderForceByParticleSpeed,
    bool multiplyColliderForceByCollisionAngle,
    PPtr<Transform>[] m_Planes,
    MinMaxCurve m_Dampen,
    MinMaxCurve m_Bounce,
    MinMaxCurve m_EnergyLossOnCollision,
    float minKillSpeed,
    float maxKillSpeed,
    float radiusScale,
    BitField collidesWith,
    int maxCollisionShapes,
    int quality,
    float voxelSize,
    bool collisionMessages,
    bool collidesWithDynamic,
    bool interiorCollisions) : IUnityStructure
{
    public static CollisionModule Read(EndianBinaryReader reader)
    {
        bool _enabled = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        int _type = reader.ReadS32();
        int _collisionMode = reader.ReadS32();
        float _colliderForce = reader.ReadF32();
        bool _multiplyColliderForceByParticleSize = reader.ReadBool();
        bool _multiplyColliderForceByParticleSpeed = reader.ReadBool();
        bool _multiplyColliderForceByCollisionAngle = reader.ReadBool();
        reader.AlignTo(4); /* multiplyColliderForceByCollisionAngle */
        PPtr<Transform>[] _m_Planes = BuiltInArray<PPtr<Transform>>.Read(reader);
        reader.AlignTo(4); /* m_Planes */
        MinMaxCurve _m_Dampen = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* m_Dampen */
        MinMaxCurve _m_Bounce = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* m_Bounce */
        MinMaxCurve _m_EnergyLossOnCollision = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* m_EnergyLossOnCollision */
        float _minKillSpeed = reader.ReadF32();
        float _maxKillSpeed = reader.ReadF32();
        float _radiusScale = reader.ReadF32();
        BitField _collidesWith = BitField.Read(reader);
        int _maxCollisionShapes = reader.ReadS32();
        int _quality = reader.ReadS32();
        float _voxelSize = reader.ReadF32();
        bool _collisionMessages = reader.ReadBool();
        bool _collidesWithDynamic = reader.ReadBool();
        bool _interiorCollisions = reader.ReadBool();
        reader.AlignTo(4); /* interiorCollisions */
        
        return new(_enabled,
            _type,
            _collisionMode,
            _colliderForce,
            _multiplyColliderForceByParticleSize,
            _multiplyColliderForceByParticleSpeed,
            _multiplyColliderForceByCollisionAngle,
            _m_Planes,
            _m_Dampen,
            _m_Bounce,
            _m_EnergyLossOnCollision,
            _minKillSpeed,
            _maxKillSpeed,
            _radiusScale,
            _collidesWith,
            _maxCollisionShapes,
            _quality,
            _voxelSize,
            _collisionMessages,
            _collidesWithDynamic,
            _interiorCollisions);
    }

    public override string ToString() => $"CollisionModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("enabled: ");
        sb.AppendLine(enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("type: ");
        sb.AppendLine(type.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("collisionMode: ");
        sb.AppendLine(collisionMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("colliderForce: ");
        sb.AppendLine(colliderForce.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("multiplyColliderForceByParticleSize: ");
        sb.AppendLine(multiplyColliderForceByParticleSize.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("multiplyColliderForceByParticleSpeed: ");
        sb.AppendLine(multiplyColliderForceByParticleSpeed.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("multiplyColliderForceByCollisionAngle: ");
        sb.AppendLine(multiplyColliderForceByCollisionAngle.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Planes: ");
        sb.AppendLine(m_Planes.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Dampen: ");
        sb.AppendLine();
        sb.Append(m_Dampen.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Bounce: ");
        sb.AppendLine();
        sb.Append(m_Bounce.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_EnergyLossOnCollision: ");
        sb.AppendLine();
        sb.Append(m_EnergyLossOnCollision.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("minKillSpeed: ");
        sb.AppendLine(minKillSpeed.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("maxKillSpeed: ");
        sb.AppendLine(maxKillSpeed.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("radiusScale: ");
        sb.AppendLine(radiusScale.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("collidesWith: ");
        sb.AppendLine();
        sb.Append(collidesWith.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("maxCollisionShapes: ");
        sb.AppendLine(maxCollisionShapes.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("quality: ");
        sb.AppendLine(quality.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("voxelSize: ");
        sb.AppendLine(voxelSize.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("collisionMessages: ");
        sb.AppendLine(collisionMessages.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("collidesWithDynamic: ");
        sb.AppendLine(collidesWithDynamic.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("interiorCollisions: ");
        sb.AppendLine(interiorCollisions.ToString());

        return sb.ToString();
    }
}

/* $TriggerModule (8 fields) */
public record class TriggerModule(
    bool enabled,
    int inside,
    int outside,
    int enter,
    int exit,
    int colliderQueryMode,
    float radiusScale,
    PPtr<Component>[] primitives) : IUnityStructure
{
    public static TriggerModule Read(EndianBinaryReader reader)
    {
        bool _enabled = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        int _inside = reader.ReadS32();
        int _outside = reader.ReadS32();
        int _enter = reader.ReadS32();
        int _exit = reader.ReadS32();
        int _colliderQueryMode = reader.ReadS32();
        float _radiusScale = reader.ReadF32();
        PPtr<Component>[] _primitives = BuiltInArray<PPtr<Component>>.Read(reader);
        reader.AlignTo(4); /* primitives */
        
        return new(_enabled,
            _inside,
            _outside,
            _enter,
            _exit,
            _colliderQueryMode,
            _radiusScale,
            _primitives);
    }

    public override string ToString() => $"TriggerModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("enabled: ");
        sb.AppendLine(enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("inside: ");
        sb.AppendLine(inside.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("outside: ");
        sb.AppendLine(outside.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("enter: ");
        sb.AppendLine(enter.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("exit: ");
        sb.AppendLine(exit.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("colliderQueryMode: ");
        sb.AppendLine(colliderQueryMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("radiusScale: ");
        sb.AppendLine(radiusScale.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("primitives: ");
        sb.AppendLine(primitives.ToString());

        return sb.ToString();
    }
}

/* $SubModule (2 fields) */
public record class SubModule(
    bool enabled,
    SubEmitterData[] subEmitters) : IUnityStructure
{
    public static SubModule Read(EndianBinaryReader reader)
    {
        bool _enabled = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        SubEmitterData[] _subEmitters = BuiltInArray<SubEmitterData>.Read(reader);
        reader.AlignTo(4); /* subEmitters */
        
        return new(_enabled,
            _subEmitters);
    }

    public override string ToString() => $"SubModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("enabled: ");
        sb.AppendLine(enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("subEmitters: ");
        sb.AppendLine(subEmitters.ToString());

        return sb.ToString();
    }
}

/* $SubEmitterData (4 fields) */
public record class SubEmitterData(
    PPtr<ParticleSystem> emitter,
    int type,
    int properties,
    float emitProbability) : IUnityStructure
{
    public static SubEmitterData Read(EndianBinaryReader reader)
    {
        PPtr<ParticleSystem> _emitter = PPtr<ParticleSystem>.Read(reader);
        int _type = reader.ReadS32();
        int _properties = reader.ReadS32();
        float _emitProbability = reader.ReadF32();
        
        return new(_emitter,
            _type,
            _properties,
            _emitProbability);
    }

    public override string ToString() => $"SubEmitterData\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("emitter: ");
        sb.AppendLine(emitter.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("type: ");
        sb.AppendLine(type.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("properties: ");
        sb.AppendLine(properties.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("emitProbability: ");
        sb.AppendLine(emitProbability.ToString());

        return sb.ToString();
    }
}

/* $LightsModule (10 fields) */
public record class LightsModule(
    bool enabled,
    float ratio,
    PPtr<Light> light,
    bool randomDistribution,
    bool color,
    bool range,
    bool intensity,
    MinMaxCurve rangeCurve,
    MinMaxCurve intensityCurve,
    int maxLights) : IUnityStructure
{
    public static LightsModule Read(EndianBinaryReader reader)
    {
        bool _enabled = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        float _ratio = reader.ReadF32();
        PPtr<Light> _light = PPtr<Light>.Read(reader);
        bool _randomDistribution = reader.ReadBool();
        bool _color = reader.ReadBool();
        bool _range = reader.ReadBool();
        bool _intensity = reader.ReadBool();
        MinMaxCurve _rangeCurve = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* rangeCurve */
        MinMaxCurve _intensityCurve = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* intensityCurve */
        int _maxLights = reader.ReadS32();
        
        return new(_enabled,
            _ratio,
            _light,
            _randomDistribution,
            _color,
            _range,
            _intensity,
            _rangeCurve,
            _intensityCurve,
            _maxLights);
    }

    public override string ToString() => $"LightsModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("enabled: ");
        sb.AppendLine(enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("ratio: ");
        sb.AppendLine(ratio.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("light: ");
        sb.AppendLine(light.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("randomDistribution: ");
        sb.AppendLine(randomDistribution.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("color: ");
        sb.AppendLine(color.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("range: ");
        sb.AppendLine(range.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("intensity: ");
        sb.AppendLine(intensity.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("rangeCurve: ");
        sb.AppendLine();
        sb.Append(rangeCurve.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("intensityCurve: ");
        sb.AppendLine();
        sb.Append(intensityCurve.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("maxLights: ");
        sb.AppendLine(maxLights.ToString());

        return sb.ToString();
    }
}

/* $TrailModule (20 fields) */
public record class TrailModule(
    bool enabled,
    int mode,
    float ratio,
    MinMaxCurve lifetime,
    float minVertexDistance,
    int textureMode,
    Vector2f textureScale,
    int ribbonCount,
    float shadowBias,
    bool worldSpace,
    bool dieWithParticles,
    bool sizeAffectsWidth,
    bool sizeAffectsLifetime,
    bool inheritParticleColor,
    bool generateLightingData,
    bool splitSubEmitterRibbons,
    bool attachRibbonsToTransform,
    MinMaxGradient colorOverLifetime,
    MinMaxCurve widthOverTrail,
    MinMaxGradient colorOverTrail) : IUnityStructure
{
    public static TrailModule Read(EndianBinaryReader reader)
    {
        bool _enabled = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        int _mode = reader.ReadS32();
        float _ratio = reader.ReadF32();
        MinMaxCurve _lifetime = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* lifetime */
        float _minVertexDistance = reader.ReadF32();
        int _textureMode = reader.ReadS32();
        Vector2f _textureScale = Vector2f.Read(reader);
        int _ribbonCount = reader.ReadS32();
        float _shadowBias = reader.ReadF32();
        bool _worldSpace = reader.ReadBool();
        bool _dieWithParticles = reader.ReadBool();
        bool _sizeAffectsWidth = reader.ReadBool();
        bool _sizeAffectsLifetime = reader.ReadBool();
        bool _inheritParticleColor = reader.ReadBool();
        bool _generateLightingData = reader.ReadBool();
        bool _splitSubEmitterRibbons = reader.ReadBool();
        bool _attachRibbonsToTransform = reader.ReadBool();
        reader.AlignTo(4); /* attachRibbonsToTransform */
        MinMaxGradient _colorOverLifetime = MinMaxGradient.Read(reader);
        reader.AlignTo(4); /* colorOverLifetime */
        MinMaxCurve _widthOverTrail = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* widthOverTrail */
        MinMaxGradient _colorOverTrail = MinMaxGradient.Read(reader);
        reader.AlignTo(4); /* colorOverTrail */
        
        return new(_enabled,
            _mode,
            _ratio,
            _lifetime,
            _minVertexDistance,
            _textureMode,
            _textureScale,
            _ribbonCount,
            _shadowBias,
            _worldSpace,
            _dieWithParticles,
            _sizeAffectsWidth,
            _sizeAffectsLifetime,
            _inheritParticleColor,
            _generateLightingData,
            _splitSubEmitterRibbons,
            _attachRibbonsToTransform,
            _colorOverLifetime,
            _widthOverTrail,
            _colorOverTrail);
    }

    public override string ToString() => $"TrailModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("enabled: ");
        sb.AppendLine(enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("mode: ");
        sb.AppendLine(mode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("ratio: ");
        sb.AppendLine(ratio.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("lifetime: ");
        sb.AppendLine();
        sb.Append(lifetime.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("minVertexDistance: ");
        sb.AppendLine(minVertexDistance.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("textureMode: ");
        sb.AppendLine(textureMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("textureScale: ");
        sb.AppendLine();
        sb.Append(textureScale.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("ribbonCount: ");
        sb.AppendLine(ribbonCount.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("shadowBias: ");
        sb.AppendLine(shadowBias.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("worldSpace: ");
        sb.AppendLine(worldSpace.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("dieWithParticles: ");
        sb.AppendLine(dieWithParticles.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sizeAffectsWidth: ");
        sb.AppendLine(sizeAffectsWidth.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("sizeAffectsLifetime: ");
        sb.AppendLine(sizeAffectsLifetime.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("inheritParticleColor: ");
        sb.AppendLine(inheritParticleColor.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("generateLightingData: ");
        sb.AppendLine(generateLightingData.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("splitSubEmitterRibbons: ");
        sb.AppendLine(splitSubEmitterRibbons.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("attachRibbonsToTransform: ");
        sb.AppendLine(attachRibbonsToTransform.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("colorOverLifetime: ");
        sb.AppendLine();
        sb.Append(colorOverLifetime.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("widthOverTrail: ");
        sb.AppendLine();
        sb.Append(widthOverTrail.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("colorOverTrail: ");
        sb.AppendLine();
        sb.Append(colorOverTrail.ToString(indent+4));

        return sb.ToString();
    }
}

/* $CustomDataModule (15 fields) */
public record class CustomDataModule(
    bool enabled,
    int mode0,
    int vectorComponentCount0,
    MinMaxGradient color0,
    MinMaxCurve vector0_0,
    MinMaxCurve vector0_1,
    MinMaxCurve vector0_2,
    MinMaxCurve vector0_3,
    int mode1,
    int vectorComponentCount1,
    MinMaxGradient color1,
    MinMaxCurve vector1_0,
    MinMaxCurve vector1_1,
    MinMaxCurve vector1_2,
    MinMaxCurve vector1_3) : IUnityStructure
{
    public static CustomDataModule Read(EndianBinaryReader reader)
    {
        bool _enabled = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        int _mode0 = reader.ReadS32();
        int _vectorComponentCount0 = reader.ReadS32();
        MinMaxGradient _color0 = MinMaxGradient.Read(reader);
        reader.AlignTo(4); /* color0 */
        MinMaxCurve _vector0_0 = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* vector0_0 */
        MinMaxCurve _vector0_1 = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* vector0_1 */
        MinMaxCurve _vector0_2 = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* vector0_2 */
        MinMaxCurve _vector0_3 = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* vector0_3 */
        int _mode1 = reader.ReadS32();
        int _vectorComponentCount1 = reader.ReadS32();
        MinMaxGradient _color1 = MinMaxGradient.Read(reader);
        reader.AlignTo(4); /* color1 */
        MinMaxCurve _vector1_0 = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* vector1_0 */
        MinMaxCurve _vector1_1 = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* vector1_1 */
        MinMaxCurve _vector1_2 = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* vector1_2 */
        MinMaxCurve _vector1_3 = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* vector1_3 */
        
        return new(_enabled,
            _mode0,
            _vectorComponentCount0,
            _color0,
            _vector0_0,
            _vector0_1,
            _vector0_2,
            _vector0_3,
            _mode1,
            _vectorComponentCount1,
            _color1,
            _vector1_0,
            _vector1_1,
            _vector1_2,
            _vector1_3);
    }

    public override string ToString() => $"CustomDataModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("enabled: ");
        sb.AppendLine(enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("mode0: ");
        sb.AppendLine(mode0.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("vectorComponentCount0: ");
        sb.AppendLine(vectorComponentCount0.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("color0: ");
        sb.AppendLine();
        sb.Append(color0.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("vector0_0: ");
        sb.AppendLine();
        sb.Append(vector0_0.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("vector0_1: ");
        sb.AppendLine();
        sb.Append(vector0_1.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("vector0_2: ");
        sb.AppendLine();
        sb.Append(vector0_2.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("vector0_3: ");
        sb.AppendLine();
        sb.Append(vector0_3.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("mode1: ");
        sb.AppendLine(mode1.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("vectorComponentCount1: ");
        sb.AppendLine(vectorComponentCount1.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("color1: ");
        sb.AppendLine();
        sb.Append(color1.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("vector1_0: ");
        sb.AppendLine();
        sb.Append(vector1_0.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("vector1_1: ");
        sb.AppendLine();
        sb.Append(vector1_1.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("vector1_2: ");
        sb.AppendLine();
        sb.Append(vector1_2.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("vector1_3: ");
        sb.AppendLine();
        sb.Append(vector1_3.ToString(indent+4));

        return sb.ToString();
    }
}

/* forward decl ?RuntimeAnimatorController (no type info) */
public record struct RuntimeAnimatorController;
/* forward decl ?Renderer (no type info) */
public record struct Renderer;
/* forward decl ?Texture (no type info) */
public record struct Texture;
/* forward decl ?NavMeshData (no type info) */
public record struct NavMeshData;
/* forward decl ?Object (no type info) */
public record struct Object;
/* forward decl ?AudioSource (no type info) */
public record struct AudioSource;
/* forward decl ?ArticulationBody (no type info) */
public record struct ArticulationBody;
/* forward decl ?NamedObject (no type info) */
public record struct NamedObject;
/* forward decl ?Component (no type info) */
public record struct Component;
/* forward decl ?Flare (no type info) */
public record struct Flare;
/* forward decl ?ParticleSystemForceField (no type info) */
public record struct ParticleSystemForceField;
