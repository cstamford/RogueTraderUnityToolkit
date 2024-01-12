namespace RogueTraderUnityToolkit.UnityGenerated.Types;

using Core;
using System.Text;
using Unity;
using Engine;

/* $StreamedResource (3 fields) */
public record class StreamedResource (
    AsciiString m_Source,
    ulong m_Offset,
    ulong m_Size) : IUnityStructure
{
    public static StreamedResource Read(EndianBinaryReader reader)
    {
        AsciiString m_Source_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Source */
        ulong m_Offset_ = reader.ReadU64();
        ulong m_Size_ = reader.ReadU64();
        
        return new(m_Source_,
            m_Offset_,
            m_Size_);
    }

    public override string ToString() => $"StreamedResource\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Source: \"{m_Source}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Offset: {m_Offset}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Size: {m_Size}");
    }
}

/* $Vector4f (4 fields) */
public readonly record struct Vector4f (
    float x,
    float y,
    float z,
    float w) : IUnityStructure
{
    public static Vector4f Read(EndianBinaryReader reader)
    {
        float x_ = reader.ReadF32();
        float y_ = reader.ReadF32();
        float z_ = reader.ReadF32();
        float w_ = reader.ReadF32();
        
        return new(x_,
            y_,
            z_,
            w_);
    }

    public override string ToString() => $"Vector4f\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}x: {x}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}y: {y}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}z: {z}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}w: {w}");
    }
}

/* $StaticBatchInfo (2 fields) */
public readonly record struct StaticBatchInfo (
    ushort firstSubMesh,
    ushort subMeshCount) : IUnityStructure
{
    public static StaticBatchInfo Read(EndianBinaryReader reader)
    {
        ushort firstSubMesh_ = reader.ReadU16();
        ushort subMeshCount_ = reader.ReadU16();
        
        return new(firstSubMesh_,
            subMeshCount_);
    }

    public override string ToString() => $"StaticBatchInfo\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}firstSubMesh: {firstSubMesh}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}subMeshCount: {subMeshCount}");
    }
}

/* $Quaternionf (4 fields) */
public readonly record struct Quaternionf (
    float x,
    float y,
    float z,
    float w) : IUnityStructure
{
    public static Quaternionf Read(EndianBinaryReader reader)
    {
        float x_ = reader.ReadF32();
        float y_ = reader.ReadF32();
        float z_ = reader.ReadF32();
        float w_ = reader.ReadF32();
        
        return new(x_,
            y_,
            z_,
            w_);
    }

    public override string ToString() => $"Quaternionf\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}x: {x}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}y: {y}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}z: {z}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}w: {w}");
    }
}

/* $Vector3f (3 fields) */
public readonly record struct Vector3f (
    float x,
    float y,
    float z) : IUnityStructure
{
    public static Vector3f Read(EndianBinaryReader reader)
    {
        float x_ = reader.ReadF32();
        float y_ = reader.ReadF32();
        float z_ = reader.ReadF32();
        
        return new(x_,
            y_,
            z_);
    }

    public override string ToString() => $"Vector3f\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}x: {x}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}y: {y}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}z: {z}");
    }
}

/* $ResourceManager_Dependency (2 fields) */
public record class ResourceManager_Dependency (
    PPtr<Object> m_Object,
    PPtr<Object>[] m_Dependencies) : IUnityStructure
{
    public static ResourceManager_Dependency Read(EndianBinaryReader reader)
    {
        PPtr<Object> m_Object_ = PPtr<Object>.Read(reader);
        PPtr<Object>[] m_Dependencies_ = BuiltInArray<PPtr<Object>>.Read(reader);
        reader.AlignTo(4); /* m_Dependencies */
        
        return new(m_Object_,
            m_Dependencies_);
    }

    public override string ToString() => $"ResourceManager_Dependency\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Object: {m_Object}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Dependencies[{m_Dependencies.Length}] = {{");
        if (m_Dependencies.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtr<Object> _4 in m_Dependencies)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_Dependencies.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $AnimationClipOverride (2 fields) */
public record class AnimationClipOverride (
    PPtr<AnimationClip> m_OriginalClip,
    PPtr<AnimationClip> m_OverrideClip) : IUnityStructure
{
    public static AnimationClipOverride Read(EndianBinaryReader reader)
    {
        PPtr<AnimationClip> m_OriginalClip_ = PPtr<AnimationClip>.Read(reader);
        PPtr<AnimationClip> m_OverrideClip_ = PPtr<AnimationClip>.Read(reader);
        
        return new(m_OriginalClip_,
            m_OverrideClip_);
    }

    public override string ToString() => $"AnimationClipOverride\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_OriginalClip: {m_OriginalClip}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_OverrideClip: {m_OverrideClip}");
    }
}

/* $LOD (3 fields) */
public record class LOD (
    float screenRelativeHeight,
    float fadeTransitionWidth,
    LODRenderer[] renderers) : IUnityStructure
{
    public static LOD Read(EndianBinaryReader reader)
    {
        float screenRelativeHeight_ = reader.ReadF32();
        float fadeTransitionWidth_ = reader.ReadF32();
        LODRenderer[] renderers_ = BuiltInArray<LODRenderer>.Read(reader);
        reader.AlignTo(4); /* renderers */
        
        return new(screenRelativeHeight_,
            fadeTransitionWidth_,
            renderers_);
    }

    public override string ToString() => $"LOD\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}screenRelativeHeight: {screenRelativeHeight}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}fadeTransitionWidth: {fadeTransitionWidth}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}renderers[{renderers.Length}] = {{");
        if (renderers.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (LODRenderer _4 in renderers)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (renderers.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $LODRenderer (1 fields) */
public record class LODRenderer (
    PPtr<Renderer> renderer) : IUnityStructure
{
    public static LODRenderer Read(EndianBinaryReader reader)
    {
        PPtr<Renderer> renderer_ = PPtr<Renderer>.Read(reader);
        
        return new(renderer_);
    }

    public override string ToString() => $"LODRenderer\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}renderer: {renderer}");
    }
}

/* $CharacterInfo (5 fields) */
public record class CharacterInfo (
    uint index,
    Rectf uv,
    Rectf vert,
    float advance,
    bool flipped) : IUnityStructure
{
    public static CharacterInfo Read(EndianBinaryReader reader)
    {
        uint index_ = reader.ReadU32();
        Rectf uv_ = Rectf.Read(reader);
        Rectf vert_ = Rectf.Read(reader);
        float advance_ = reader.ReadF32();
        bool flipped_ = reader.ReadBool();
        reader.AlignTo(4); /* flipped */
        
        return new(index_,
            uv_,
            vert_,
            advance_,
            flipped_);
    }

    public override string ToString() => $"CharacterInfo\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}index: {index}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}uv: {{ x: {uv.x}, y: {uv.y}, width: {uv.width}, height: {uv.height} }}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}vert: {{ x: {vert.x}, y: {vert.y}, width: {vert.width}, height: {vert.height} }}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}advance: {advance}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}flipped: {flipped}");
    }
}

/* $Rectf (4 fields) */
public readonly record struct Rectf (
    float x,
    float y,
    float width,
    float height) : IUnityStructure
{
    public static Rectf Read(EndianBinaryReader reader)
    {
        float x_ = reader.ReadF32();
        float y_ = reader.ReadF32();
        float width_ = reader.ReadF32();
        float height_ = reader.ReadF32();
        
        return new(x_,
            y_,
            width_,
            height_);
    }

    public override string ToString() => $"Rectf\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}x: {x}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}y: {y}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}width: {width}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}height: {height}");
    }
}

/* $pair (2 fields) */
public readonly record struct pair (
    ushort first,
    ushort second) : IUnityStructure
{
    public static pair Read(EndianBinaryReader reader)
    {
        ushort first_ = reader.ReadU16();
        ushort second_ = reader.ReadU16();
        
        return new(first_,
            second_);
    }

    public override string ToString() => $"pair\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}first: {first}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}second: {second}");
    }
}

/* $BitField (1 fields) */
public readonly record struct BitField (
    uint m_Bits) : IUnityStructure
{
    public static BitField Read(EndianBinaryReader reader)
    {
        uint m_Bits_ = reader.ReadU32();
        
        return new(m_Bits_);
    }

    public override string ToString() => $"BitField\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Bits: {m_Bits}");
    }
}

/* $SubMesh (7 fields) */
public record class SubMesh (
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
        uint firstByte_ = reader.ReadU32();
        uint indexCount_ = reader.ReadU32();
        int topology_ = reader.ReadS32();
        uint baseVertex_ = reader.ReadU32();
        uint firstVertex_ = reader.ReadU32();
        uint vertexCount_ = reader.ReadU32();
        AABB localAABB_ = AABB.Read(reader);
        
        return new(firstByte_,
            indexCount_,
            topology_,
            baseVertex_,
            firstVertex_,
            vertexCount_,
            localAABB_);
    }

    public override string ToString() => $"SubMesh\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}firstByte: {firstByte}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}indexCount: {indexCount}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}topology: {topology}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}baseVertex: {baseVertex}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}firstVertex: {firstVertex}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}vertexCount: {vertexCount}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}localAABB: {{ \n{localAABB.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $AABB (2 fields) */
public record class AABB (
    Vector3f m_Center,
    Vector3f m_Extent) : IUnityStructure
{
    public static AABB Read(EndianBinaryReader reader)
    {
        Vector3f m_Center_ = Vector3f.Read(reader);
        Vector3f m_Extent_ = Vector3f.Read(reader);
        
        return new(m_Center_,
            m_Extent_);
    }

    public override string ToString() => $"AABB\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Center: {{ x: {m_Center.x}, y: {m_Center.y}, z: {m_Center.z} }}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Extent: {{ x: {m_Extent.x}, y: {m_Extent.y}, z: {m_Extent.z} }}\n");
    }
}

/* $BlendShapeData (4 fields) */
public record class BlendShapeData (
    BlendShapeVertex[] vertices,
    MeshBlendShape[] shapes,
    MeshBlendShapeChannel[] channels,
    float[] fullWeights) : IUnityStructure
{
    public static BlendShapeData Read(EndianBinaryReader reader)
    {
        BlendShapeVertex[] vertices_ = BuiltInArray<BlendShapeVertex>.Read(reader);
        reader.AlignTo(4); /* vertices */
        MeshBlendShape[] shapes_ = BuiltInArray<MeshBlendShape>.Read(reader);
        reader.AlignTo(4); /* shapes */
        MeshBlendShapeChannel[] channels_ = BuiltInArray<MeshBlendShapeChannel>.Read(reader);
        reader.AlignTo(4); /* channels */
        float[] fullWeights_ = BuiltInArray<float>.Read(reader);
        reader.AlignTo(4); /* fullWeights */
        
        return new(vertices_,
            shapes_,
            channels_,
            fullWeights_);
    }

    public override string ToString() => $"BlendShapeData\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}vertices[{vertices.Length}] = {{");
        if (vertices.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (BlendShapeVertex _4 in vertices)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (vertices.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}shapes[{shapes.Length}] = {{");
        if (shapes.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (MeshBlendShape _4 in shapes)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ firstVertex: {_4.firstVertex}, vertexCount: {_4.vertexCount}, hasNormals: {_4.hasNormals}, hasTangents: {_4.hasTangents} }}\n");
            ++_4i;
        }
        if (shapes.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}channels[{channels.Length}] = {{");
        if (channels.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (MeshBlendShapeChannel _4 in channels)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (channels.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}fullWeights[{fullWeights.Length}] = {{");
        if (fullWeights.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (float _4 in fullWeights)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (fullWeights.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $BlendShapeVertex (4 fields) */
public record class BlendShapeVertex (
    Vector3f vertex,
    Vector3f normal,
    Vector3f tangent,
    uint index) : IUnityStructure
{
    public static BlendShapeVertex Read(EndianBinaryReader reader)
    {
        Vector3f vertex_ = Vector3f.Read(reader);
        Vector3f normal_ = Vector3f.Read(reader);
        Vector3f tangent_ = Vector3f.Read(reader);
        uint index_ = reader.ReadU32();
        
        return new(vertex_,
            normal_,
            tangent_,
            index_);
    }

    public override string ToString() => $"BlendShapeVertex\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}vertex: {{ x: {vertex.x}, y: {vertex.y}, z: {vertex.z} }}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}normal: {{ x: {normal.x}, y: {normal.y}, z: {normal.z} }}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}tangent: {{ x: {tangent.x}, y: {tangent.y}, z: {tangent.z} }}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}index: {index}");
    }
}

/* $MeshBlendShape (4 fields) */
public readonly record struct MeshBlendShape (
    uint firstVertex,
    uint vertexCount,
    bool hasNormals,
    bool hasTangents) : IUnityStructure
{
    public static MeshBlendShape Read(EndianBinaryReader reader)
    {
        uint firstVertex_ = reader.ReadU32();
        uint vertexCount_ = reader.ReadU32();
        bool hasNormals_ = reader.ReadBool();
        bool hasTangents_ = reader.ReadBool();
        reader.AlignTo(4); /* hasTangents */
        
        return new(firstVertex_,
            vertexCount_,
            hasNormals_,
            hasTangents_);
    }

    public override string ToString() => $"MeshBlendShape\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}firstVertex: {firstVertex}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}vertexCount: {vertexCount}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}hasNormals: {hasNormals}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}hasTangents: {hasTangents}");
    }
}

/* $MeshBlendShapeChannel (4 fields) */
public record class MeshBlendShapeChannel (
    AsciiString name,
    uint nameHash,
    int frameIndex,
    int frameCount) : IUnityStructure
{
    public static MeshBlendShapeChannel Read(EndianBinaryReader reader)
    {
        AsciiString name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* name */
        uint nameHash_ = reader.ReadU32();
        int frameIndex_ = reader.ReadS32();
        int frameCount_ = reader.ReadS32();
        
        return new(name_,
            nameHash_,
            frameIndex_,
            frameCount_);
    }

    public override string ToString() => $"MeshBlendShapeChannel\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}name: \"{name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}nameHash: {nameHash}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}frameIndex: {frameIndex}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}frameCount: {frameCount}");
    }
}

/* $Matrix4x4f (16 fields) */
public readonly record struct Matrix4x4f (
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
        float e00_ = reader.ReadF32();
        float e01_ = reader.ReadF32();
        float e02_ = reader.ReadF32();
        float e03_ = reader.ReadF32();
        float e10_ = reader.ReadF32();
        float e11_ = reader.ReadF32();
        float e12_ = reader.ReadF32();
        float e13_ = reader.ReadF32();
        float e20_ = reader.ReadF32();
        float e21_ = reader.ReadF32();
        float e22_ = reader.ReadF32();
        float e23_ = reader.ReadF32();
        float e30_ = reader.ReadF32();
        float e31_ = reader.ReadF32();
        float e32_ = reader.ReadF32();
        float e33_ = reader.ReadF32();
        
        return new(e00_,
            e01_,
            e02_,
            e03_,
            e10_,
            e11_,
            e12_,
            e13_,
            e20_,
            e21_,
            e22_,
            e23_,
            e30_,
            e31_,
            e32_,
            e33_);
    }

    public override string ToString() => $"Matrix4x4f\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);
        ToString_Field15(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}e00: {e00}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}e01: {e01}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}e02: {e02}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}e03: {e03}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}e10: {e10}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}e11: {e11}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}e12: {e12}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}e13: {e13}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}e20: {e20}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}e21: {e21}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}e22: {e22}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}e23: {e23}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}e30: {e30}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}e31: {e31}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}e32: {e32}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}e33: {e33}");
    }
}

/* $MinMaxAABB (2 fields) */
public record class MinMaxAABB (
    Vector3f m_Min,
    Vector3f m_Max) : IUnityStructure
{
    public static MinMaxAABB Read(EndianBinaryReader reader)
    {
        Vector3f m_Min_ = Vector3f.Read(reader);
        Vector3f m_Max_ = Vector3f.Read(reader);
        
        return new(m_Min_,
            m_Max_);
    }

    public override string ToString() => $"MinMaxAABB\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Min: {{ x: {m_Min.x}, y: {m_Min.y}, z: {m_Min.z} }}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Max: {{ x: {m_Max.x}, y: {m_Max.y}, z: {m_Max.z} }}\n");
    }
}

/* $VariableBoneCountWeights (1 fields) */
public record class VariableBoneCountWeights (
    uint[] m_Data) : IUnityStructure
{
    public static VariableBoneCountWeights Read(EndianBinaryReader reader)
    {
        uint[] m_Data_ = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* m_Data */
        
        return new(m_Data_);
    }

    public override string ToString() => $"VariableBoneCountWeights\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Data[{m_Data.Length}] = {{");
        if (m_Data.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint _4 in m_Data)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_Data.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $VertexData (3 fields) */
public record class VertexData (
    uint m_VertexCount,
    ChannelInfo[] m_Channels,
    byte[] m_DataSize) : IUnityStructure
{
    public static VertexData Read(EndianBinaryReader reader)
    {
        uint m_VertexCount_ = reader.ReadU32();
        ChannelInfo[] m_Channels_ = BuiltInArray<ChannelInfo>.Read(reader);
        reader.AlignTo(4); /* m_Channels */
        byte[] m_DataSize_ = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_DataSize */
        
        return new(m_VertexCount_,
            m_Channels_,
            m_DataSize_);
    }

    public override string ToString() => $"VertexData\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_VertexCount: {m_VertexCount}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Channels[{m_Channels.Length}] = {{");
        if (m_Channels.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (ChannelInfo _4 in m_Channels)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ stream: {_4.stream}, offset: {_4.offset}, format: {_4.format}, dimension: {_4.dimension} }}\n");
            ++_4i;
        }
        if (m_Channels.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_DataSize[{m_DataSize.Length}] = {{");
        if (m_DataSize.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (byte _4 in m_DataSize)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_DataSize.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $ChannelInfo (4 fields) */
public readonly record struct ChannelInfo (
    byte stream,
    byte offset,
    byte format,
    byte dimension) : IUnityStructure
{
    public static ChannelInfo Read(EndianBinaryReader reader)
    {
        byte stream_ = reader.ReadU8();
        byte offset_ = reader.ReadU8();
        byte format_ = reader.ReadU8();
        byte dimension_ = reader.ReadU8();
        
        return new(stream_,
            offset_,
            format_,
            dimension_);
    }

    public override string ToString() => $"ChannelInfo\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}stream: {stream}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}offset: {offset}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}format: {format}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}dimension: {dimension}");
    }
}

/* $CompressedMesh (11 fields) */
public record class CompressedMesh (
    PackedBitVector_2 m_Vertices,
    PackedBitVector_2 m_UV,
    PackedBitVector_2 m_Normals,
    PackedBitVector_2 m_Tangents,
    PackedBitVector_1 m_Weights,
    PackedBitVector_1 m_NormalSigns,
    PackedBitVector_1 m_TangentSigns,
    PackedBitVector_2 m_FloatColors,
    PackedBitVector_1 m_BoneIndices,
    PackedBitVector_1 m_Triangles,
    uint m_UVInfo) : IUnityStructure
{
    public static CompressedMesh Read(EndianBinaryReader reader)
    {
        PackedBitVector_2 m_Vertices_ = PackedBitVector_2.Read(reader);
        reader.AlignTo(4); /* m_Vertices */
        PackedBitVector_2 m_UV_ = PackedBitVector_2.Read(reader);
        reader.AlignTo(4); /* m_UV */
        PackedBitVector_2 m_Normals_ = PackedBitVector_2.Read(reader);
        reader.AlignTo(4); /* m_Normals */
        PackedBitVector_2 m_Tangents_ = PackedBitVector_2.Read(reader);
        reader.AlignTo(4); /* m_Tangents */
        PackedBitVector_1 m_Weights_ = PackedBitVector_1.Read(reader);
        reader.AlignTo(4); /* m_Weights */
        PackedBitVector_1 m_NormalSigns_ = PackedBitVector_1.Read(reader);
        reader.AlignTo(4); /* m_NormalSigns */
        PackedBitVector_1 m_TangentSigns_ = PackedBitVector_1.Read(reader);
        reader.AlignTo(4); /* m_TangentSigns */
        PackedBitVector_2 m_FloatColors_ = PackedBitVector_2.Read(reader);
        reader.AlignTo(4); /* m_FloatColors */
        PackedBitVector_1 m_BoneIndices_ = PackedBitVector_1.Read(reader);
        reader.AlignTo(4); /* m_BoneIndices */
        PackedBitVector_1 m_Triangles_ = PackedBitVector_1.Read(reader);
        reader.AlignTo(4); /* m_Triangles */
        uint m_UVInfo_ = reader.ReadU32();
        
        return new(m_Vertices_,
            m_UV_,
            m_Normals_,
            m_Tangents_,
            m_Weights_,
            m_NormalSigns_,
            m_TangentSigns_,
            m_FloatColors_,
            m_BoneIndices_,
            m_Triangles_,
            m_UVInfo_);
    }

    public override string ToString() => $"CompressedMesh\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Vertices: {{ \n{m_Vertices.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_UV: {{ \n{m_UV.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Normals: {{ \n{m_Normals.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Tangents: {{ \n{m_Tangents.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Weights: {{ \n{m_Weights.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_NormalSigns: {{ \n{m_NormalSigns.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_TangentSigns: {{ \n{m_TangentSigns.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_FloatColors: {{ \n{m_FloatColors.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_BoneIndices: {{ \n{m_BoneIndices.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Triangles: {{ \n{m_Triangles.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UVInfo: {m_UVInfo}");
    }
}

/* $PackedBitVector_2 (5 fields) */
public record class PackedBitVector_2 (
    uint m_NumItems,
    float m_Range,
    float m_Start,
    byte[] m_Data,
    byte m_BitSize) : IUnityStructure
{
    public static PackedBitVector_2 Read(EndianBinaryReader reader)
    {
        uint m_NumItems_ = reader.ReadU32();
        float m_Range_ = reader.ReadF32();
        float m_Start_ = reader.ReadF32();
        byte[] m_Data_ = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_Data */
        byte m_BitSize_ = reader.ReadU8();
        reader.AlignTo(4); /* m_BitSize */
        
        return new(m_NumItems_,
            m_Range_,
            m_Start_,
            m_Data_,
            m_BitSize_);
    }

    public override string ToString() => $"PackedBitVector_2\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_NumItems: {m_NumItems}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Range: {m_Range}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Start: {m_Start}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Data[{m_Data.Length}] = {{");
        if (m_Data.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (byte _4 in m_Data)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_Data.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BitSize: {m_BitSize}");
    }
}

/* $PackedBitVector_1 (3 fields) */
public record class PackedBitVector_1 (
    uint m_NumItems,
    byte[] m_Data,
    byte m_BitSize) : IUnityStructure
{
    public static PackedBitVector_1 Read(EndianBinaryReader reader)
    {
        uint m_NumItems_ = reader.ReadU32();
        byte[] m_Data_ = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_Data */
        byte m_BitSize_ = reader.ReadU8();
        reader.AlignTo(4); /* m_BitSize */
        
        return new(m_NumItems_,
            m_Data_,
            m_BitSize_);
    }

    public override string ToString() => $"PackedBitVector_1\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_NumItems: {m_NumItems}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Data[{m_Data.Length}] = {{");
        if (m_Data.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (byte _4 in m_Data)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_Data.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BitSize: {m_BitSize}");
    }
}

/* $StreamingInfo (3 fields) */
public record class StreamingInfo (
    ulong offset,
    uint size,
    AsciiString path) : IUnityStructure
{
    public static StreamingInfo Read(EndianBinaryReader reader)
    {
        ulong offset_ = reader.ReadU64();
        uint size_ = reader.ReadU32();
        AsciiString path_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* path */
        
        return new(offset_,
            size_,
            path_);
    }

    public override string ToString() => $"StreamingInfo\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}offset: {offset}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}size: {size}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}path: \"{path}\"");
    }
}

/* $Vector2f (2 fields) */
public readonly record struct Vector2f (
    float x,
    float y) : IUnityStructure
{
    public static Vector2f Read(EndianBinaryReader reader)
    {
        float x_ = reader.ReadF32();
        float y_ = reader.ReadF32();
        
        return new(x_,
            y_);
    }

    public override string ToString() => $"Vector2f\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}x: {x}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}y: {y}");
    }
}

/* $ColorRGBA_1 (4 fields) */
public readonly record struct ColorRGBA_1 (
    float r,
    float g,
    float b,
    float a) : IUnityStructure
{
    public static ColorRGBA_1 Read(EndianBinaryReader reader)
    {
        float r_ = reader.ReadF32();
        float g_ = reader.ReadF32();
        float b_ = reader.ReadF32();
        float a_ = reader.ReadF32();
        
        return new(r_,
            g_,
            b_,
            a_);
    }

    public override string ToString() => $"ColorRGBA_1\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}r: {r}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}g: {g}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}b: {b}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}a: {a}");
    }
}

/* $EnlightenSceneMapping (5 fields) */
public record class EnlightenSceneMapping (
    EnlightenRendererInformation[] m_Renderers,
    EnlightenSystemInformation[] m_Systems,
    Hash128[] m_Probesets,
    EnlightenSystemAtlasInformation[] m_SystemAtlases,
    EnlightenTerrainChunksInformation[] m_TerrainChunks) : IUnityStructure
{
    public static EnlightenSceneMapping Read(EndianBinaryReader reader)
    {
        EnlightenRendererInformation[] m_Renderers_ = BuiltInArray<EnlightenRendererInformation>.Read(reader);
        reader.AlignTo(4); /* m_Renderers */
        EnlightenSystemInformation[] m_Systems_ = BuiltInArray<EnlightenSystemInformation>.Read(reader);
        reader.AlignTo(4); /* m_Systems */
        Hash128[] m_Probesets_ = BuiltInArray<Hash128>.Read(reader);
        reader.AlignTo(4); /* m_Probesets */
        EnlightenSystemAtlasInformation[] m_SystemAtlases_ = BuiltInArray<EnlightenSystemAtlasInformation>.Read(reader);
        reader.AlignTo(4); /* m_SystemAtlases */
        EnlightenTerrainChunksInformation[] m_TerrainChunks_ = BuiltInArray<EnlightenTerrainChunksInformation>.Read(reader);
        reader.AlignTo(4); /* m_TerrainChunks */
        
        return new(m_Renderers_,
            m_Systems_,
            m_Probesets_,
            m_SystemAtlases_,
            m_TerrainChunks_);
    }

    public override string ToString() => $"EnlightenSceneMapping\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Renderers[{m_Renderers.Length}] = {{");
        if (m_Renderers.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (EnlightenRendererInformation _4 in m_Renderers)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Renderers.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Systems[{m_Systems.Length}] = {{");
        if (m_Systems.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (EnlightenSystemInformation _4 in m_Systems)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Systems.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Probesets[{m_Probesets.Length}] = {{");
        if (m_Probesets.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (Hash128 _4 in m_Probesets)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_Probesets.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_SystemAtlases[{m_SystemAtlases.Length}] = {{");
        if (m_SystemAtlases.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (EnlightenSystemAtlasInformation _4 in m_SystemAtlases)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_SystemAtlases.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_TerrainChunks[{m_TerrainChunks.Length}] = {{");
        if (m_TerrainChunks.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (EnlightenTerrainChunksInformation _4 in m_TerrainChunks)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ firstSystemId: {_4.firstSystemId}, numChunksInX: {_4.numChunksInX}, numChunksInY: {_4.numChunksInY} }}\n");
            ++_4i;
        }
        if (m_TerrainChunks.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $EnlightenRendererInformation (4 fields) */
public record class EnlightenRendererInformation (
    PPtr<Object> renderer,
    Vector4f dynamicLightmapSTInSystem,
    int systemId,
    Hash128 instanceHash) : IUnityStructure
{
    public static EnlightenRendererInformation Read(EndianBinaryReader reader)
    {
        PPtr<Object> renderer_ = PPtr<Object>.Read(reader);
        Vector4f dynamicLightmapSTInSystem_ = Vector4f.Read(reader);
        int systemId_ = reader.ReadS32();
        Hash128 instanceHash_ = Hash128.Read(reader);
        
        return new(renderer_,
            dynamicLightmapSTInSystem_,
            systemId_,
            instanceHash_);
    }

    public override string ToString() => $"EnlightenRendererInformation\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}renderer: {renderer}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}dynamicLightmapSTInSystem: {{ x: {dynamicLightmapSTInSystem.x}, y: {dynamicLightmapSTInSystem.y}, z: {dynamicLightmapSTInSystem.z}, w: {dynamicLightmapSTInSystem.w} }}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}systemId: {systemId}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}instanceHash: {instanceHash}");
    }
}

/* $EnlightenSystemInformation (7 fields) */
public record class EnlightenSystemInformation (
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
        uint rendererIndex_ = reader.ReadU32();
        uint rendererSize_ = reader.ReadU32();
        int atlasIndex_ = reader.ReadS32();
        int atlasOffsetX_ = reader.ReadS32();
        int atlasOffsetY_ = reader.ReadS32();
        Hash128 inputSystemHash_ = Hash128.Read(reader);
        Hash128 radiositySystemHash_ = Hash128.Read(reader);
        
        return new(rendererIndex_,
            rendererSize_,
            atlasIndex_,
            atlasOffsetX_,
            atlasOffsetY_,
            inputSystemHash_,
            radiositySystemHash_);
    }

    public override string ToString() => $"EnlightenSystemInformation\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}rendererIndex: {rendererIndex}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}rendererSize: {rendererSize}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}atlasIndex: {atlasIndex}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}atlasOffsetX: {atlasOffsetX}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}atlasOffsetY: {atlasOffsetY}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}inputSystemHash: {inputSystemHash}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}radiositySystemHash: {radiositySystemHash}");
    }
}

/* $EnlightenSystemAtlasInformation (3 fields) */
public record class EnlightenSystemAtlasInformation (
    int atlasSize,
    Hash128 atlasHash,
    int firstSystemId) : IUnityStructure
{
    public static EnlightenSystemAtlasInformation Read(EndianBinaryReader reader)
    {
        int atlasSize_ = reader.ReadS32();
        Hash128 atlasHash_ = Hash128.Read(reader);
        int firstSystemId_ = reader.ReadS32();
        
        return new(atlasSize_,
            atlasHash_,
            firstSystemId_);
    }

    public override string ToString() => $"EnlightenSystemAtlasInformation\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}atlasSize: {atlasSize}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}atlasHash: {atlasHash}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}firstSystemId: {firstSystemId}");
    }
}

/* $EnlightenTerrainChunksInformation (3 fields) */
public readonly record struct EnlightenTerrainChunksInformation (
    int firstSystemId,
    int numChunksInX,
    int numChunksInY) : IUnityStructure
{
    public static EnlightenTerrainChunksInformation Read(EndianBinaryReader reader)
    {
        int firstSystemId_ = reader.ReadS32();
        int numChunksInX_ = reader.ReadS32();
        int numChunksInY_ = reader.ReadS32();
        
        return new(firstSystemId_,
            numChunksInX_,
            numChunksInY_);
    }

    public override string ToString() => $"EnlightenTerrainChunksInformation\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}firstSystemId: {firstSystemId}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}numChunksInX: {numChunksInX}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}numChunksInY: {numChunksInY}");
    }
}

/* $LightmapData (3 fields) */
public record class LightmapData (
    PPtr<Texture2D> m_Lightmap,
    PPtr<Texture2D> m_DirLightmap,
    PPtr<Texture2D> m_ShadowMask) : IUnityStructure
{
    public static LightmapData Read(EndianBinaryReader reader)
    {
        PPtr<Texture2D> m_Lightmap_ = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> m_DirLightmap_ = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> m_ShadowMask_ = PPtr<Texture2D>.Read(reader);
        
        return new(m_Lightmap_,
            m_DirLightmap_,
            m_ShadowMask_);
    }

    public override string ToString() => $"LightmapData\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Lightmap: {m_Lightmap}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DirLightmap: {m_DirLightmap}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ShadowMask: {m_ShadowMask}");
    }
}

/* $GISettings (6 fields) */
public readonly record struct GISettings (
    float m_BounceScale,
    float m_IndirectOutputScale,
    float m_AlbedoBoost,
    uint m_EnvironmentLightingMode,
    bool m_EnableBakedLightmaps,
    bool m_EnableRealtimeLightmaps) : IUnityStructure
{
    public static GISettings Read(EndianBinaryReader reader)
    {
        float m_BounceScale_ = reader.ReadF32();
        float m_IndirectOutputScale_ = reader.ReadF32();
        float m_AlbedoBoost_ = reader.ReadF32();
        uint m_EnvironmentLightingMode_ = reader.ReadU32();
        bool m_EnableBakedLightmaps_ = reader.ReadBool();
        bool m_EnableRealtimeLightmaps_ = reader.ReadBool();
        reader.AlignTo(4); /* m_EnableRealtimeLightmaps */
        
        return new(m_BounceScale_,
            m_IndirectOutputScale_,
            m_AlbedoBoost_,
            m_EnvironmentLightingMode_,
            m_EnableBakedLightmaps_,
            m_EnableRealtimeLightmaps_);
    }

    public override string ToString() => $"GISettings\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BounceScale: {m_BounceScale}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_IndirectOutputScale: {m_IndirectOutputScale}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_AlbedoBoost: {m_AlbedoBoost}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_EnvironmentLightingMode: {m_EnvironmentLightingMode}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_EnableBakedLightmaps: {m_EnableBakedLightmaps}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_EnableRealtimeLightmaps: {m_EnableRealtimeLightmaps}");
    }
}

/* $PhysicsJobOptions2D (17 fields) */
public readonly record struct PhysicsJobOptions2D (
    bool useMultithreading,
    bool useConsistencySorting,
    int m_InterpolationPosesPerJob,
    int m_NewContactsPerJob,
    int m_CollideContactsPerJob,
    int m_ClearFlagsPerJob,
    int m_ClearBodyForcesPerJob,
    int m_SyncDiscreteFixturesPerJob,
    int m_SyncContinuousFixturesPerJob,
    int m_FindNearestContactsPerJob,
    int m_UpdateTriggerContactsPerJob,
    int m_IslandSolverCostThreshold,
    int m_IslandSolverBodyCostScale,
    int m_IslandSolverContactCostScale,
    int m_IslandSolverJointCostScale,
    int m_IslandSolverBodiesPerJob,
    int m_IslandSolverContactsPerJob) : IUnityStructure
{
    public static PhysicsJobOptions2D Read(EndianBinaryReader reader)
    {
        bool useMultithreading_ = reader.ReadBool();
        bool useConsistencySorting_ = reader.ReadBool();
        reader.AlignTo(4); /* useConsistencySorting */
        int m_InterpolationPosesPerJob_ = reader.ReadS32();
        int m_NewContactsPerJob_ = reader.ReadS32();
        int m_CollideContactsPerJob_ = reader.ReadS32();
        int m_ClearFlagsPerJob_ = reader.ReadS32();
        int m_ClearBodyForcesPerJob_ = reader.ReadS32();
        int m_SyncDiscreteFixturesPerJob_ = reader.ReadS32();
        int m_SyncContinuousFixturesPerJob_ = reader.ReadS32();
        int m_FindNearestContactsPerJob_ = reader.ReadS32();
        int m_UpdateTriggerContactsPerJob_ = reader.ReadS32();
        int m_IslandSolverCostThreshold_ = reader.ReadS32();
        int m_IslandSolverBodyCostScale_ = reader.ReadS32();
        int m_IslandSolverContactCostScale_ = reader.ReadS32();
        int m_IslandSolverJointCostScale_ = reader.ReadS32();
        int m_IslandSolverBodiesPerJob_ = reader.ReadS32();
        int m_IslandSolverContactsPerJob_ = reader.ReadS32();
        
        return new(useMultithreading_,
            useConsistencySorting_,
            m_InterpolationPosesPerJob_,
            m_NewContactsPerJob_,
            m_CollideContactsPerJob_,
            m_ClearFlagsPerJob_,
            m_ClearBodyForcesPerJob_,
            m_SyncDiscreteFixturesPerJob_,
            m_SyncContinuousFixturesPerJob_,
            m_FindNearestContactsPerJob_,
            m_UpdateTriggerContactsPerJob_,
            m_IslandSolverCostThreshold_,
            m_IslandSolverBodyCostScale_,
            m_IslandSolverContactCostScale_,
            m_IslandSolverJointCostScale_,
            m_IslandSolverBodiesPerJob_,
            m_IslandSolverContactsPerJob_);
    }

    public override string ToString() => $"PhysicsJobOptions2D\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);
        ToString_Field15(sb, indent, indent_);
        ToString_Field16(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}useMultithreading: {useMultithreading}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}useConsistencySorting: {useConsistencySorting}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_InterpolationPosesPerJob: {m_InterpolationPosesPerJob}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_NewContactsPerJob: {m_NewContactsPerJob}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CollideContactsPerJob: {m_CollideContactsPerJob}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ClearFlagsPerJob: {m_ClearFlagsPerJob}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ClearBodyForcesPerJob: {m_ClearBodyForcesPerJob}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SyncDiscreteFixturesPerJob: {m_SyncDiscreteFixturesPerJob}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SyncContinuousFixturesPerJob: {m_SyncContinuousFixturesPerJob}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_FindNearestContactsPerJob: {m_FindNearestContactsPerJob}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UpdateTriggerContactsPerJob: {m_UpdateTriggerContactsPerJob}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_IslandSolverCostThreshold: {m_IslandSolverCostThreshold}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_IslandSolverBodyCostScale: {m_IslandSolverBodyCostScale}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_IslandSolverContactCostScale: {m_IslandSolverContactCostScale}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_IslandSolverJointCostScale: {m_IslandSolverJointCostScale}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_IslandSolverBodiesPerJob: {m_IslandSolverBodiesPerJob}");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_IslandSolverContactsPerJob: {m_IslandSolverContactsPerJob}");
    }
}

/* $AssetInfo (3 fields) */
public record class AssetInfo (
    int preloadIndex,
    int preloadSize,
    PPtr<Object> asset) : IUnityStructure
{
    public static AssetInfo Read(EndianBinaryReader reader)
    {
        int preloadIndex_ = reader.ReadS32();
        int preloadSize_ = reader.ReadS32();
        PPtr<Object> asset_ = PPtr<Object>.Read(reader);
        
        return new(preloadIndex_,
            preloadSize_,
            asset_);
    }

    public override string ToString() => $"AssetInfo\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}preloadIndex: {preloadIndex}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}preloadSize: {preloadSize}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}asset: {asset}");
    }
}

/* $VFXPropertySheetSerializedBase (11 fields) */
public record class VFXPropertySheetSerializedBase (
    VFXField m_Float,
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
    public static VFXPropertySheetSerializedBase Read(EndianBinaryReader reader)
    {
        VFXField m_Float_ = VFXField.Read(reader);
        reader.AlignTo(4); /* m_Float */
        VFXField_1 m_Vector2f_ = VFXField_1.Read(reader);
        reader.AlignTo(4); /* m_Vector2f */
        VFXField_2 m_Vector3f_ = VFXField_2.Read(reader);
        reader.AlignTo(4); /* m_Vector3f */
        VFXField_3 m_Vector4f_ = VFXField_3.Read(reader);
        reader.AlignTo(4); /* m_Vector4f */
        VFXField_4 m_Uint_ = VFXField_4.Read(reader);
        reader.AlignTo(4); /* m_Uint */
        VFXField_5 m_Int_ = VFXField_5.Read(reader);
        reader.AlignTo(4); /* m_Int */
        VFXField_6 m_Matrix4x4f_ = VFXField_6.Read(reader);
        reader.AlignTo(4); /* m_Matrix4x4f */
        VFXField_7 m_AnimationCurve_ = VFXField_7.Read(reader);
        reader.AlignTo(4); /* m_AnimationCurve */
        VFXField_8 m_Gradient_ = VFXField_8.Read(reader);
        reader.AlignTo(4); /* m_Gradient */
        VFXField_9 m_NamedObject_ = VFXField_9.Read(reader);
        reader.AlignTo(4); /* m_NamedObject */
        VFXField_10 m_Bool_ = VFXField_10.Read(reader);
        reader.AlignTo(4); /* m_Bool */
        
        return new(m_Float_,
            m_Vector2f_,
            m_Vector3f_,
            m_Vector4f_,
            m_Uint_,
            m_Int_,
            m_Matrix4x4f_,
            m_AnimationCurve_,
            m_Gradient_,
            m_NamedObject_,
            m_Bool_);
    }

    public override string ToString() => $"VFXPropertySheetSerializedBase\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Float: {{ \n{m_Float.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Vector2f: {{ \n{m_Vector2f.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Vector3f: {{ \n{m_Vector3f.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Vector4f: {{ \n{m_Vector4f.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Uint: {{ \n{m_Uint.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Int: {{ \n{m_Int.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Matrix4x4f: {{ \n{m_Matrix4x4f.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_AnimationCurve: {{ \n{m_AnimationCurve.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Gradient: {{ \n{m_Gradient.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_NamedObject: {{ \n{m_NamedObject.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Bool: {{ \n{m_Bool.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $VFXField (1 fields) */
public record class VFXField (
    VFXEntryExposed[] m_Array) : IUnityStructure
{
    public static VFXField Read(EndianBinaryReader reader)
    {
        VFXEntryExposed[] m_Array_ = BuiltInArray<VFXEntryExposed>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(m_Array_);
    }

    public override string ToString() => $"VFXField\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Array[{m_Array.Length}] = {{");
        if (m_Array.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXEntryExposed _4 in m_Array)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Array.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $VFXEntryExposed (3 fields) */
public record class VFXEntryExposed (
    float m_Value,
    AsciiString m_Name,
    bool m_Overridden) : IUnityStructure
{
    public static VFXEntryExposed Read(EndianBinaryReader reader)
    {
        float m_Value_ = reader.ReadF32();
        reader.AlignTo(4); /* m_Value */
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        bool m_Overridden_ = reader.ReadBool();
        reader.AlignTo(4); /* m_Overridden */
        
        return new(m_Value_,
            m_Name_,
            m_Overridden_);
    }

    public override string ToString() => $"VFXEntryExposed\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Value: {m_Value}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Overridden: {m_Overridden}");
    }
}

/* $VFXField_1 (1 fields) */
public record class VFXField_1 (
    VFXEntryExposed_1[] m_Array) : IUnityStructure
{
    public static VFXField_1 Read(EndianBinaryReader reader)
    {
        VFXEntryExposed_1[] m_Array_ = BuiltInArray<VFXEntryExposed_1>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(m_Array_);
    }

    public override string ToString() => $"VFXField_1\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Array[{m_Array.Length}] = {{");
        if (m_Array.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXEntryExposed_1 _4 in m_Array)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Array.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $VFXEntryExposed_1 (3 fields) */
public record class VFXEntryExposed_1 (
    Vector2f m_Value,
    AsciiString m_Name,
    bool m_Overridden) : IUnityStructure
{
    public static VFXEntryExposed_1 Read(EndianBinaryReader reader)
    {
        Vector2f m_Value_ = Vector2f.Read(reader);
        reader.AlignTo(4); /* m_Value */
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        bool m_Overridden_ = reader.ReadBool();
        reader.AlignTo(4); /* m_Overridden */
        
        return new(m_Value_,
            m_Name_,
            m_Overridden_);
    }

    public override string ToString() => $"VFXEntryExposed_1\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Value: {{ x: {m_Value.x}, y: {m_Value.y} }}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Overridden: {m_Overridden}");
    }
}

/* $VFXField_2 (1 fields) */
public record class VFXField_2 (
    VFXEntryExposed_2[] m_Array) : IUnityStructure
{
    public static VFXField_2 Read(EndianBinaryReader reader)
    {
        VFXEntryExposed_2[] m_Array_ = BuiltInArray<VFXEntryExposed_2>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(m_Array_);
    }

    public override string ToString() => $"VFXField_2\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Array[{m_Array.Length}] = {{");
        if (m_Array.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXEntryExposed_2 _4 in m_Array)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Array.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $VFXEntryExposed_2 (3 fields) */
public record class VFXEntryExposed_2 (
    Vector3f m_Value,
    AsciiString m_Name,
    bool m_Overridden) : IUnityStructure
{
    public static VFXEntryExposed_2 Read(EndianBinaryReader reader)
    {
        Vector3f m_Value_ = Vector3f.Read(reader);
        reader.AlignTo(4); /* m_Value */
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        bool m_Overridden_ = reader.ReadBool();
        reader.AlignTo(4); /* m_Overridden */
        
        return new(m_Value_,
            m_Name_,
            m_Overridden_);
    }

    public override string ToString() => $"VFXEntryExposed_2\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Value: {{ x: {m_Value.x}, y: {m_Value.y}, z: {m_Value.z} }}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Overridden: {m_Overridden}");
    }
}

/* $VFXField_3 (1 fields) */
public record class VFXField_3 (
    VFXEntryExposed_3[] m_Array) : IUnityStructure
{
    public static VFXField_3 Read(EndianBinaryReader reader)
    {
        VFXEntryExposed_3[] m_Array_ = BuiltInArray<VFXEntryExposed_3>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(m_Array_);
    }

    public override string ToString() => $"VFXField_3\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Array[{m_Array.Length}] = {{");
        if (m_Array.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXEntryExposed_3 _4 in m_Array)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Array.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $VFXEntryExposed_3 (3 fields) */
public record class VFXEntryExposed_3 (
    Vector4f m_Value,
    AsciiString m_Name,
    bool m_Overridden) : IUnityStructure
{
    public static VFXEntryExposed_3 Read(EndianBinaryReader reader)
    {
        Vector4f m_Value_ = Vector4f.Read(reader);
        reader.AlignTo(4); /* m_Value */
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        bool m_Overridden_ = reader.ReadBool();
        reader.AlignTo(4); /* m_Overridden */
        
        return new(m_Value_,
            m_Name_,
            m_Overridden_);
    }

    public override string ToString() => $"VFXEntryExposed_3\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Value: {{ x: {m_Value.x}, y: {m_Value.y}, z: {m_Value.z}, w: {m_Value.w} }}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Overridden: {m_Overridden}");
    }
}

/* $VFXField_4 (1 fields) */
public record class VFXField_4 (
    VFXEntryExposed_4[] m_Array) : IUnityStructure
{
    public static VFXField_4 Read(EndianBinaryReader reader)
    {
        VFXEntryExposed_4[] m_Array_ = BuiltInArray<VFXEntryExposed_4>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(m_Array_);
    }

    public override string ToString() => $"VFXField_4\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Array[{m_Array.Length}] = {{");
        if (m_Array.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXEntryExposed_4 _4 in m_Array)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Array.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $VFXEntryExposed_4 (3 fields) */
public record class VFXEntryExposed_4 (
    uint m_Value,
    AsciiString m_Name,
    bool m_Overridden) : IUnityStructure
{
    public static VFXEntryExposed_4 Read(EndianBinaryReader reader)
    {
        uint m_Value_ = reader.ReadU32();
        reader.AlignTo(4); /* m_Value */
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        bool m_Overridden_ = reader.ReadBool();
        reader.AlignTo(4); /* m_Overridden */
        
        return new(m_Value_,
            m_Name_,
            m_Overridden_);
    }

    public override string ToString() => $"VFXEntryExposed_4\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Value: {m_Value}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Overridden: {m_Overridden}");
    }
}

/* $VFXField_5 (1 fields) */
public record class VFXField_5 (
    VFXEntryExposed_5[] m_Array) : IUnityStructure
{
    public static VFXField_5 Read(EndianBinaryReader reader)
    {
        VFXEntryExposed_5[] m_Array_ = BuiltInArray<VFXEntryExposed_5>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(m_Array_);
    }

    public override string ToString() => $"VFXField_5\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Array[{m_Array.Length}] = {{");
        if (m_Array.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXEntryExposed_5 _4 in m_Array)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Array.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $VFXEntryExposed_5 (3 fields) */
public record class VFXEntryExposed_5 (
    int m_Value,
    AsciiString m_Name,
    bool m_Overridden) : IUnityStructure
{
    public static VFXEntryExposed_5 Read(EndianBinaryReader reader)
    {
        int m_Value_ = reader.ReadS32();
        reader.AlignTo(4); /* m_Value */
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        bool m_Overridden_ = reader.ReadBool();
        reader.AlignTo(4); /* m_Overridden */
        
        return new(m_Value_,
            m_Name_,
            m_Overridden_);
    }

    public override string ToString() => $"VFXEntryExposed_5\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Value: {m_Value}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Overridden: {m_Overridden}");
    }
}

/* $VFXField_6 (1 fields) */
public record class VFXField_6 (
    VFXEntryExposed_6[] m_Array) : IUnityStructure
{
    public static VFXField_6 Read(EndianBinaryReader reader)
    {
        VFXEntryExposed_6[] m_Array_ = BuiltInArray<VFXEntryExposed_6>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(m_Array_);
    }

    public override string ToString() => $"VFXField_6\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Array[{m_Array.Length}] = {{");
        if (m_Array.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXEntryExposed_6 _4 in m_Array)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Array.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $VFXEntryExposed_6 (3 fields) */
public record class VFXEntryExposed_6 (
    Matrix4x4f m_Value,
    AsciiString m_Name,
    bool m_Overridden) : IUnityStructure
{
    public static VFXEntryExposed_6 Read(EndianBinaryReader reader)
    {
        Matrix4x4f m_Value_ = Matrix4x4f.Read(reader);
        reader.AlignTo(4); /* m_Value */
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        bool m_Overridden_ = reader.ReadBool();
        reader.AlignTo(4); /* m_Overridden */
        
        return new(m_Value_,
            m_Name_,
            m_Overridden_);
    }

    public override string ToString() => $"VFXEntryExposed_6\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Value: {{ \n{m_Value.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Overridden: {m_Overridden}");
    }
}

/* $VFXField_7 (1 fields) */
public record class VFXField_7 (
    VFXEntryExposed_7[] m_Array) : IUnityStructure
{
    public static VFXField_7 Read(EndianBinaryReader reader)
    {
        VFXEntryExposed_7[] m_Array_ = BuiltInArray<VFXEntryExposed_7>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(m_Array_);
    }

    public override string ToString() => $"VFXField_7\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Array[{m_Array.Length}] = {{");
        if (m_Array.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXEntryExposed_7 _4 in m_Array)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Array.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $VFXEntryExposed_7 (3 fields) */
public record class VFXEntryExposed_7 (
    AnimationCurve m_Value,
    AsciiString m_Name,
    bool m_Overridden) : IUnityStructure
{
    public static VFXEntryExposed_7 Read(EndianBinaryReader reader)
    {
        AnimationCurve m_Value_ = AnimationCurve.Read(reader);
        reader.AlignTo(4); /* m_Value */
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        bool m_Overridden_ = reader.ReadBool();
        reader.AlignTo(4); /* m_Overridden */
        
        return new(m_Value_,
            m_Name_,
            m_Overridden_);
    }

    public override string ToString() => $"VFXEntryExposed_7\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Value: {{ \n{m_Value.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Overridden: {m_Overridden}");
    }
}

/* $AnimationCurve (4 fields) */
public record class AnimationCurve (
    Keyframe[] m_Curve,
    int m_PreInfinity,
    int m_PostInfinity,
    int m_RotationOrder) : IUnityStructure
{
    public static AnimationCurve Read(EndianBinaryReader reader)
    {
        Keyframe[] m_Curve_ = BuiltInArray<Keyframe>.Read(reader);
        reader.AlignTo(4); /* m_Curve */
        int m_PreInfinity_ = reader.ReadS32();
        int m_PostInfinity_ = reader.ReadS32();
        int m_RotationOrder_ = reader.ReadS32();
        
        return new(m_Curve_,
            m_PreInfinity_,
            m_PostInfinity_,
            m_RotationOrder_);
    }

    public override string ToString() => $"AnimationCurve\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Curve[{m_Curve.Length}] = {{");
        if (m_Curve.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (Keyframe _4 in m_Curve)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Curve.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PreInfinity: {m_PreInfinity}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PostInfinity: {m_PostInfinity}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RotationOrder: {m_RotationOrder}");
    }
}

/* $Keyframe (7 fields) */
public readonly record struct Keyframe (
    float time,
    float @value,
    float inSlope,
    float outSlope,
    int weightedMode,
    float inWeight,
    float outWeight) : IUnityStructure
{
    public static Keyframe Read(EndianBinaryReader reader)
    {
        float time_ = reader.ReadF32();
        float @value_ = reader.ReadF32();
        float inSlope_ = reader.ReadF32();
        float outSlope_ = reader.ReadF32();
        int weightedMode_ = reader.ReadS32();
        float inWeight_ = reader.ReadF32();
        float outWeight_ = reader.ReadF32();
        
        return new(time_,
            @value_,
            inSlope_,
            outSlope_,
            weightedMode_,
            inWeight_,
            outWeight_);
    }

    public override string ToString() => $"Keyframe\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}time: {time}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}@value: {@value}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}inSlope: {inSlope}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}outSlope: {outSlope}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}weightedMode: {weightedMode}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}inWeight: {inWeight}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}outWeight: {outWeight}");
    }
}

/* $VFXField_8 (1 fields) */
public record class VFXField_8 (
    VFXEntryExposed_8[] m_Array) : IUnityStructure
{
    public static VFXField_8 Read(EndianBinaryReader reader)
    {
        VFXEntryExposed_8[] m_Array_ = BuiltInArray<VFXEntryExposed_8>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(m_Array_);
    }

    public override string ToString() => $"VFXField_8\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Array[{m_Array.Length}] = {{");
        if (m_Array.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXEntryExposed_8 _4 in m_Array)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Array.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $VFXEntryExposed_8 (3 fields) */
public record class VFXEntryExposed_8 (
    Gradient m_Value,
    AsciiString m_Name,
    bool m_Overridden) : IUnityStructure
{
    public static VFXEntryExposed_8 Read(EndianBinaryReader reader)
    {
        Gradient m_Value_ = Gradient.Read(reader);
        reader.AlignTo(4); /* m_Value */
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        bool m_Overridden_ = reader.ReadBool();
        reader.AlignTo(4); /* m_Overridden */
        
        return new(m_Value_,
            m_Name_,
            m_Overridden_);
    }

    public override string ToString() => $"VFXEntryExposed_8\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Value: {{ \n{m_Value.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Overridden: {m_Overridden}");
    }
}

/* $Gradient (28 fields) */
public record class Gradient (
    ColorRGBA_1 key0,
    ColorRGBA_1 key1,
    ColorRGBA_1 key2,
    ColorRGBA_1 key3,
    ColorRGBA_1 key4,
    ColorRGBA_1 key5,
    ColorRGBA_1 key6,
    ColorRGBA_1 key7,
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
        ColorRGBA_1 key0_ = ColorRGBA_1.Read(reader);
        ColorRGBA_1 key1_ = ColorRGBA_1.Read(reader);
        ColorRGBA_1 key2_ = ColorRGBA_1.Read(reader);
        ColorRGBA_1 key3_ = ColorRGBA_1.Read(reader);
        ColorRGBA_1 key4_ = ColorRGBA_1.Read(reader);
        ColorRGBA_1 key5_ = ColorRGBA_1.Read(reader);
        ColorRGBA_1 key6_ = ColorRGBA_1.Read(reader);
        ColorRGBA_1 key7_ = ColorRGBA_1.Read(reader);
        ushort ctime0_ = reader.ReadU16();
        ushort ctime1_ = reader.ReadU16();
        ushort ctime2_ = reader.ReadU16();
        ushort ctime3_ = reader.ReadU16();
        ushort ctime4_ = reader.ReadU16();
        ushort ctime5_ = reader.ReadU16();
        ushort ctime6_ = reader.ReadU16();
        ushort ctime7_ = reader.ReadU16();
        ushort atime0_ = reader.ReadU16();
        ushort atime1_ = reader.ReadU16();
        ushort atime2_ = reader.ReadU16();
        ushort atime3_ = reader.ReadU16();
        ushort atime4_ = reader.ReadU16();
        ushort atime5_ = reader.ReadU16();
        ushort atime6_ = reader.ReadU16();
        ushort atime7_ = reader.ReadU16();
        byte m_Mode_ = reader.ReadU8();
        sbyte m_ColorSpace_ = reader.ReadS8();
        byte m_NumColorKeys_ = reader.ReadU8();
        byte m_NumAlphaKeys_ = reader.ReadU8();
        reader.AlignTo(4); /* m_NumAlphaKeys */
        
        return new(key0_,
            key1_,
            key2_,
            key3_,
            key4_,
            key5_,
            key6_,
            key7_,
            ctime0_,
            ctime1_,
            ctime2_,
            ctime3_,
            ctime4_,
            ctime5_,
            ctime6_,
            ctime7_,
            atime0_,
            atime1_,
            atime2_,
            atime3_,
            atime4_,
            atime5_,
            atime6_,
            atime7_,
            m_Mode_,
            m_ColorSpace_,
            m_NumColorKeys_,
            m_NumAlphaKeys_);
    }

    public override string ToString() => $"Gradient\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);
        ToString_Field15(sb, indent, indent_);
        ToString_Field16(sb, indent, indent_);
        ToString_Field17(sb, indent, indent_);
        ToString_Field18(sb, indent, indent_);
        ToString_Field19(sb, indent, indent_);
        ToString_Field20(sb, indent, indent_);
        ToString_Field21(sb, indent, indent_);
        ToString_Field22(sb, indent, indent_);
        ToString_Field23(sb, indent, indent_);
        ToString_Field24(sb, indent, indent_);
        ToString_Field25(sb, indent, indent_);
        ToString_Field26(sb, indent, indent_);
        ToString_Field27(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}key0: {{ r: {key0.r}, g: {key0.g}, b: {key0.b}, a: {key0.a} }}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}key1: {{ r: {key1.r}, g: {key1.g}, b: {key1.b}, a: {key1.a} }}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}key2: {{ r: {key2.r}, g: {key2.g}, b: {key2.b}, a: {key2.a} }}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}key3: {{ r: {key3.r}, g: {key3.g}, b: {key3.b}, a: {key3.a} }}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}key4: {{ r: {key4.r}, g: {key4.g}, b: {key4.b}, a: {key4.a} }}\n");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}key5: {{ r: {key5.r}, g: {key5.g}, b: {key5.b}, a: {key5.a} }}\n");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}key6: {{ r: {key6.r}, g: {key6.g}, b: {key6.b}, a: {key6.a} }}\n");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}key7: {{ r: {key7.r}, g: {key7.g}, b: {key7.b}, a: {key7.a} }}\n");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}ctime0: {ctime0}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}ctime1: {ctime1}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}ctime2: {ctime2}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}ctime3: {ctime3}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}ctime4: {ctime4}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}ctime5: {ctime5}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}ctime6: {ctime6}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}ctime7: {ctime7}");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}atime0: {atime0}");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}atime1: {atime1}");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}atime2: {atime2}");
    }

    public void ToString_Field19(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}atime3: {atime3}");
    }

    public void ToString_Field20(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}atime4: {atime4}");
    }

    public void ToString_Field21(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}atime5: {atime5}");
    }

    public void ToString_Field22(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}atime6: {atime6}");
    }

    public void ToString_Field23(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}atime7: {atime7}");
    }

    public void ToString_Field24(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Mode: {m_Mode}");
    }

    public void ToString_Field25(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ColorSpace: {m_ColorSpace}");
    }

    public void ToString_Field26(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_NumColorKeys: {m_NumColorKeys}");
    }

    public void ToString_Field27(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_NumAlphaKeys: {m_NumAlphaKeys}");
    }
}

/* $VFXField_9 (1 fields) */
public record class VFXField_9 (
    VFXEntryExposed_9[] m_Array) : IUnityStructure
{
    public static VFXField_9 Read(EndianBinaryReader reader)
    {
        VFXEntryExposed_9[] m_Array_ = BuiltInArray<VFXEntryExposed_9>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(m_Array_);
    }

    public override string ToString() => $"VFXField_9\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Array[{m_Array.Length}] = {{");
        if (m_Array.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXEntryExposed_9 _4 in m_Array)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Array.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $VFXEntryExposed_9 (3 fields) */
public record class VFXEntryExposed_9 (
    PPtr<Object> m_Value,
    AsciiString m_Name,
    bool m_Overridden) : IUnityStructure
{
    public static VFXEntryExposed_9 Read(EndianBinaryReader reader)
    {
        PPtr<Object> m_Value_ = PPtr<Object>.Read(reader);
        reader.AlignTo(4); /* m_Value */
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        bool m_Overridden_ = reader.ReadBool();
        reader.AlignTo(4); /* m_Overridden */
        
        return new(m_Value_,
            m_Name_,
            m_Overridden_);
    }

    public override string ToString() => $"VFXEntryExposed_9\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Value: {m_Value}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Overridden: {m_Overridden}");
    }
}

/* $VFXField_10 (1 fields) */
public record class VFXField_10 (
    VFXEntryExposed_10[] m_Array) : IUnityStructure
{
    public static VFXField_10 Read(EndianBinaryReader reader)
    {
        VFXEntryExposed_10[] m_Array_ = BuiltInArray<VFXEntryExposed_10>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(m_Array_);
    }

    public override string ToString() => $"VFXField_10\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Array[{m_Array.Length}] = {{");
        if (m_Array.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXEntryExposed_10 _4 in m_Array)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Array.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $VFXEntryExposed_10 (3 fields) */
public record class VFXEntryExposed_10 (
    bool m_Value,
    AsciiString m_Name,
    bool m_Overridden) : IUnityStructure
{
    public static VFXEntryExposed_10 Read(EndianBinaryReader reader)
    {
        bool m_Value_ = reader.ReadBool();
        reader.AlignTo(4); /* m_Value */
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        bool m_Overridden_ = reader.ReadBool();
        reader.AlignTo(4); /* m_Overridden */
        
        return new(m_Value_,
            m_Name_,
            m_Overridden_);
    }

    public override string ToString() => $"VFXEntryExposed_10\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Value: {m_Value}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Overridden: {m_Overridden}");
    }
}

/* $pair_1 (2 fields) */
public record class pair_1 (
    GUID first,
    long second) : IUnityStructure
{
    public static pair_1 Read(EndianBinaryReader reader)
    {
        GUID first_ = GUID.Read(reader);
        long second_ = reader.ReadS64();
        
        return new(first_,
            second_);
    }

    public override string ToString() => $"pair_1\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}first: {{ data_0: {first.data_0}, data_1: {first.data_1}, data_2: {first.data_2}, data_3: {first.data_3} }}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}second: {second}");
    }
}

/* $GUID (4 fields) */
public readonly record struct GUID (
    uint data_0,
    uint data_1,
    uint data_2,
    uint data_3) : IUnityStructure
{
    public static GUID Read(EndianBinaryReader reader)
    {
        uint data_0_ = reader.ReadU32();
        uint data_1_ = reader.ReadU32();
        uint data_2_ = reader.ReadU32();
        uint data_3_ = reader.ReadU32();
        
        return new(data_0_,
            data_1_,
            data_2_,
            data_3_);
    }

    public override string ToString() => $"GUID\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}data_0: {data_0}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}data_1: {data_1}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}data_2: {data_2}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}data_3: {data_3}");
    }
}

/* $SpriteAtlasData (9 fields) */
public record class SpriteAtlasData (
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
        PPtr<Texture2D> texture_ = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> alphaTexture_ = PPtr<Texture2D>.Read(reader);
        Rectf textureRect_ = Rectf.Read(reader);
        Vector2f textureRectOffset_ = Vector2f.Read(reader);
        Vector2f atlasRectOffset_ = Vector2f.Read(reader);
        Vector4f uvTransform_ = Vector4f.Read(reader);
        float downscaleMultiplier_ = reader.ReadF32();
        uint settingsRaw_ = reader.ReadU32();
        SecondarySpriteTexture[] secondaryTextures_ = BuiltInArray<SecondarySpriteTexture>.Read(reader);
        reader.AlignTo(4); /* secondaryTextures */
        
        return new(texture_,
            alphaTexture_,
            textureRect_,
            textureRectOffset_,
            atlasRectOffset_,
            uvTransform_,
            downscaleMultiplier_,
            settingsRaw_,
            secondaryTextures_);
    }

    public override string ToString() => $"SpriteAtlasData\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}texture: {texture}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}alphaTexture: {alphaTexture}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}textureRect: {{ x: {textureRect.x}, y: {textureRect.y}, width: {textureRect.width}, height: {textureRect.height} }}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}textureRectOffset: {{ x: {textureRectOffset.x}, y: {textureRectOffset.y} }}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}atlasRectOffset: {{ x: {atlasRectOffset.x}, y: {atlasRectOffset.y} }}\n");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}uvTransform: {{ x: {uvTransform.x}, y: {uvTransform.y}, z: {uvTransform.z}, w: {uvTransform.w} }}\n");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}downscaleMultiplier: {downscaleMultiplier}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}settingsRaw: {settingsRaw}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}secondaryTextures[{secondaryTextures.Length}] = {{");
        if (secondaryTextures.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (SecondarySpriteTexture _4 in secondaryTextures)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (secondaryTextures.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $SecondarySpriteTexture (2 fields) */
public record class SecondarySpriteTexture (
    PPtr<Texture2D> texture,
    AsciiString name) : IUnityStructure
{
    public static SecondarySpriteTexture Read(EndianBinaryReader reader)
    {
        PPtr<Texture2D> texture_ = PPtr<Texture2D>.Read(reader);
        AsciiString name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* name */
        
        return new(texture_,
            name_);
    }

    public override string ToString() => $"SecondarySpriteTexture\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}texture: {texture}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}name: \"{name}\"");
    }
}

/* $InputAxis (15 fields) */
public record class InputAxis (
    AsciiString m_Name,
    AsciiString descriptiveName,
    AsciiString descriptiveNegativeName,
    AsciiString negativeButton,
    AsciiString positiveButton,
    AsciiString altNegativeButton,
    AsciiString altPositiveButton,
    float gravity,
    float dead,
    float sensitivity,
    bool snap,
    bool invert,
    int type,
    int axis,
    int joyNum) : IUnityStructure
{
    public static InputAxis Read(EndianBinaryReader reader)
    {
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        AsciiString descriptiveName_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* descriptiveName */
        AsciiString descriptiveNegativeName_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* descriptiveNegativeName */
        AsciiString negativeButton_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* negativeButton */
        AsciiString positiveButton_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* positiveButton */
        AsciiString altNegativeButton_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* altNegativeButton */
        AsciiString altPositiveButton_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* altPositiveButton */
        float gravity_ = reader.ReadF32();
        float dead_ = reader.ReadF32();
        float sensitivity_ = reader.ReadF32();
        bool snap_ = reader.ReadBool();
        bool invert_ = reader.ReadBool();
        reader.AlignTo(4); /* invert */
        int type_ = reader.ReadS32();
        int axis_ = reader.ReadS32();
        int joyNum_ = reader.ReadS32();
        
        return new(m_Name_,
            descriptiveName_,
            descriptiveNegativeName_,
            negativeButton_,
            positiveButton_,
            altNegativeButton_,
            altPositiveButton_,
            gravity_,
            dead_,
            sensitivity_,
            snap_,
            invert_,
            type_,
            axis_,
            joyNum_);
    }

    public override string ToString() => $"InputAxis\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}descriptiveName: \"{descriptiveName}\"");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}descriptiveNegativeName: \"{descriptiveNegativeName}\"");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}negativeButton: \"{negativeButton}\"");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}positiveButton: \"{positiveButton}\"");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}altNegativeButton: \"{altNegativeButton}\"");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}altPositiveButton: \"{altPositiveButton}\"");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}gravity: {gravity}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}dead: {dead}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sensitivity: {sensitivity}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}snap: {snap}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}invert: {invert}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}type: {type}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}axis: {axis}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}joyNum: {joyNum}");
    }
}

/* $SerializedShader (10 fields) */
public record class SerializedShader (
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
        SerializedProperties m_PropInfo_ = SerializedProperties.Read(reader);
        reader.AlignTo(4); /* m_PropInfo */
        SerializedSubShader[] m_SubShaders_ = BuiltInArray<SerializedSubShader>.Read(reader);
        reader.AlignTo(4); /* m_SubShaders */
        AsciiString[] m_KeywordNames_ = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_KeywordNames */
        byte[] m_KeywordFlags_ = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_KeywordFlags */
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        AsciiString m_CustomEditorName_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CustomEditorName */
        AsciiString m_FallbackName_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FallbackName */
        SerializedShaderDependency[] m_Dependencies_ = BuiltInArray<SerializedShaderDependency>.Read(reader);
        reader.AlignTo(4); /* m_Dependencies */
        SerializedCustomEditorForRenderPipeline[] m_CustomEditorForRenderPipelines_ = BuiltInArray<SerializedCustomEditorForRenderPipeline>.Read(reader);
        reader.AlignTo(4); /* m_CustomEditorForRenderPipelines */
        bool m_DisableNoSubshadersMessage_ = reader.ReadBool();
        reader.AlignTo(4); /* m_DisableNoSubshadersMessage */
        
        return new(m_PropInfo_,
            m_SubShaders_,
            m_KeywordNames_,
            m_KeywordFlags_,
            m_Name_,
            m_CustomEditorName_,
            m_FallbackName_,
            m_Dependencies_,
            m_CustomEditorForRenderPipelines_,
            m_DisableNoSubshadersMessage_);
    }

    public override string ToString() => $"SerializedShader\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_PropInfo: {{ \n{m_PropInfo.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_SubShaders[{m_SubShaders.Length}] = {{");
        if (m_SubShaders.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (SerializedSubShader _4 in m_SubShaders)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_SubShaders.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_KeywordNames[{m_KeywordNames.Length}] = {{");
        if (m_KeywordNames.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (AsciiString _4 in m_KeywordNames)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = \"{_4}\"");
            ++_4i;
        }
        if (m_KeywordNames.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_KeywordFlags[{m_KeywordFlags.Length}] = {{");
        if (m_KeywordFlags.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (byte _4 in m_KeywordFlags)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_KeywordFlags.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CustomEditorName: \"{m_CustomEditorName}\"");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_FallbackName: \"{m_FallbackName}\"");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Dependencies[{m_Dependencies.Length}] = {{");
        if (m_Dependencies.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (SerializedShaderDependency _4 in m_Dependencies)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Dependencies.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_CustomEditorForRenderPipelines[{m_CustomEditorForRenderPipelines.Length}] = {{");
        if (m_CustomEditorForRenderPipelines.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (SerializedCustomEditorForRenderPipeline _4 in m_CustomEditorForRenderPipelines)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_CustomEditorForRenderPipelines.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DisableNoSubshadersMessage: {m_DisableNoSubshadersMessage}");
    }
}

/* $SerializedProperties (1 fields) */
public record class SerializedProperties (
    SerializedProperty[] m_Props) : IUnityStructure
{
    public static SerializedProperties Read(EndianBinaryReader reader)
    {
        SerializedProperty[] m_Props_ = BuiltInArray<SerializedProperty>.Read(reader);
        reader.AlignTo(4); /* m_Props */
        
        return new(m_Props_);
    }

    public override string ToString() => $"SerializedProperties\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Props[{m_Props.Length}] = {{");
        if (m_Props.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (SerializedProperty _4 in m_Props)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Props.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $SerializedProperty (10 fields) */
public record class SerializedProperty (
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
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        AsciiString m_Description_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Description */
        AsciiString[] m_Attributes_ = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_Attributes */
        int m_Type_ = reader.ReadS32();
        uint m_Flags_ = reader.ReadU32();
        float m_DefValue_0_ = reader.ReadF32();
        float m_DefValue_1_ = reader.ReadF32();
        float m_DefValue_2_ = reader.ReadF32();
        float m_DefValue_3_ = reader.ReadF32();
        SerializedTextureProperty m_DefTexture_ = SerializedTextureProperty.Read(reader);
        reader.AlignTo(4); /* m_DefTexture */
        
        return new(m_Name_,
            m_Description_,
            m_Attributes_,
            m_Type_,
            m_Flags_,
            m_DefValue_0_,
            m_DefValue_1_,
            m_DefValue_2_,
            m_DefValue_3_,
            m_DefTexture_);
    }

    public override string ToString() => $"SerializedProperty\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Description: \"{m_Description}\"");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Attributes[{m_Attributes.Length}] = {{");
        if (m_Attributes.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (AsciiString _4 in m_Attributes)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = \"{_4}\"");
            ++_4i;
        }
        if (m_Attributes.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Type: {m_Type}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Flags: {m_Flags}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DefValue_0: {m_DefValue_0}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DefValue_1: {m_DefValue_1}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DefValue_2: {m_DefValue_2}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DefValue_3: {m_DefValue_3}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_DefTexture: {{ \n{m_DefTexture.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $SerializedTextureProperty (2 fields) */
public record class SerializedTextureProperty (
    AsciiString m_DefaultName,
    int m_TexDim) : IUnityStructure
{
    public static SerializedTextureProperty Read(EndianBinaryReader reader)
    {
        AsciiString m_DefaultName_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_DefaultName */
        int m_TexDim_ = reader.ReadS32();
        
        return new(m_DefaultName_,
            m_TexDim_);
    }

    public override string ToString() => $"SerializedTextureProperty\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DefaultName: \"{m_DefaultName}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TexDim: {m_TexDim}");
    }
}

/* $SerializedSubShader (3 fields) */
public record class SerializedSubShader (
    SerializedPass[] m_Passes,
    SerializedTagMap m_Tags,
    int m_LOD) : IUnityStructure
{
    public static SerializedSubShader Read(EndianBinaryReader reader)
    {
        SerializedPass[] m_Passes_ = BuiltInArray<SerializedPass>.Read(reader);
        reader.AlignTo(4); /* m_Passes */
        SerializedTagMap m_Tags_ = SerializedTagMap.Read(reader);
        reader.AlignTo(4); /* m_Tags */
        int m_LOD_ = reader.ReadS32();
        
        return new(m_Passes_,
            m_Tags_,
            m_LOD_);
    }

    public override string ToString() => $"SerializedSubShader\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Passes[{m_Passes.Length}] = {{");
        if (m_Passes.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (SerializedPass _4 in m_Passes)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Passes.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Tags: {{ \n{m_Tags.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LOD: {m_LOD}");
    }
}

/* $SerializedPass (18 fields) */
public record class SerializedPass (
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
        Hash128[] m_EditorDataHash_ = BuiltInArray<Hash128>.Read(reader);
        reader.AlignTo(4); /* m_EditorDataHash */
        byte[] m_Platforms_ = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_Platforms */
        Dictionary<AsciiString, int> m_NameIndices_ = BuiltInMap<AsciiString, int>.Read(reader);
        reader.AlignTo(4); /* m_NameIndices */
        int m_Type_ = reader.ReadS32();
        SerializedShaderState m_State_ = SerializedShaderState.Read(reader);
        reader.AlignTo(4); /* m_State */
        uint m_ProgramMask_ = reader.ReadU32();
        SerializedProgram progVertex_ = SerializedProgram.Read(reader);
        reader.AlignTo(4); /* progVertex */
        SerializedProgram progFragment_ = SerializedProgram.Read(reader);
        reader.AlignTo(4); /* progFragment */
        SerializedProgram progGeometry_ = SerializedProgram.Read(reader);
        reader.AlignTo(4); /* progGeometry */
        SerializedProgram progHull_ = SerializedProgram.Read(reader);
        reader.AlignTo(4); /* progHull */
        SerializedProgram progDomain_ = SerializedProgram.Read(reader);
        reader.AlignTo(4); /* progDomain */
        SerializedProgram progRayTracing_ = SerializedProgram.Read(reader);
        reader.AlignTo(4); /* progRayTracing */
        bool m_HasInstancingVariant_ = reader.ReadBool();
        bool m_HasProceduralInstancingVariant_ = reader.ReadBool();
        reader.AlignTo(4); /* m_HasProceduralInstancingVariant */
        AsciiString m_UseName_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_UseName */
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        AsciiString m_TextureName_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TextureName */
        SerializedTagMap m_Tags_ = SerializedTagMap.Read(reader);
        reader.AlignTo(4); /* m_Tags */
        
        return new(m_EditorDataHash_,
            m_Platforms_,
            m_NameIndices_,
            m_Type_,
            m_State_,
            m_ProgramMask_,
            progVertex_,
            progFragment_,
            progGeometry_,
            progHull_,
            progDomain_,
            progRayTracing_,
            m_HasInstancingVariant_,
            m_HasProceduralInstancingVariant_,
            m_UseName_,
            m_Name_,
            m_TextureName_,
            m_Tags_);
    }

    public override string ToString() => $"SerializedPass\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);
        ToString_Field15(sb, indent, indent_);
        ToString_Field16(sb, indent, indent_);
        ToString_Field17(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_EditorDataHash[{m_EditorDataHash.Length}] = {{");
        if (m_EditorDataHash.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (Hash128 _4 in m_EditorDataHash)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_EditorDataHash.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Platforms[{m_Platforms.Length}] = {{");
        if (m_Platforms.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (byte _4 in m_Platforms)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_Platforms.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_NameIndices[{m_NameIndices.Count}] = {{");
        if (m_NameIndices.Count > 0) sb.AppendLine();
        int _4i = 0;
        foreach (KeyValuePair<AsciiString, int> _4 in m_NameIndices)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[\"{_4.Key}\"] = {_4.Value}");
            ++_4i;
        }
        if (m_NameIndices.Count > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Type: {m_Type}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_State: {{ \n{m_State.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ProgramMask: {m_ProgramMask}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}progVertex: {{ \n{progVertex.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}progFragment: {{ \n{progFragment.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}progGeometry: {{ \n{progGeometry.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}progHull: {{ \n{progHull.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}progDomain: {{ \n{progDomain.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}progRayTracing: {{ \n{progRayTracing.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_HasInstancingVariant: {m_HasInstancingVariant}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_HasProceduralInstancingVariant: {m_HasProceduralInstancingVariant}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UseName: \"{m_UseName}\"");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TextureName: \"{m_TextureName}\"");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Tags: {{ \n{m_Tags.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $SerializedShaderState (33 fields) */
public record class SerializedShaderState (
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
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        SerializedShaderRTBlendState rtBlend0_ = SerializedShaderRTBlendState.Read(reader);
        reader.AlignTo(4); /* rtBlend0 */
        SerializedShaderRTBlendState rtBlend1_ = SerializedShaderRTBlendState.Read(reader);
        reader.AlignTo(4); /* rtBlend1 */
        SerializedShaderRTBlendState rtBlend2_ = SerializedShaderRTBlendState.Read(reader);
        reader.AlignTo(4); /* rtBlend2 */
        SerializedShaderRTBlendState rtBlend3_ = SerializedShaderRTBlendState.Read(reader);
        reader.AlignTo(4); /* rtBlend3 */
        SerializedShaderRTBlendState rtBlend4_ = SerializedShaderRTBlendState.Read(reader);
        reader.AlignTo(4); /* rtBlend4 */
        SerializedShaderRTBlendState rtBlend5_ = SerializedShaderRTBlendState.Read(reader);
        reader.AlignTo(4); /* rtBlend5 */
        SerializedShaderRTBlendState rtBlend6_ = SerializedShaderRTBlendState.Read(reader);
        reader.AlignTo(4); /* rtBlend6 */
        SerializedShaderRTBlendState rtBlend7_ = SerializedShaderRTBlendState.Read(reader);
        reader.AlignTo(4); /* rtBlend7 */
        bool rtSeparateBlend_ = reader.ReadBool();
        reader.AlignTo(4); /* rtSeparateBlend */
        SerializedShaderFloatValue zClip_ = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* zClip */
        SerializedShaderFloatValue zTest_ = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* zTest */
        SerializedShaderFloatValue zWrite_ = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* zWrite */
        SerializedShaderFloatValue culling_ = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* culling */
        SerializedShaderFloatValue conservative_ = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* conservative */
        SerializedShaderFloatValue offsetFactor_ = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* offsetFactor */
        SerializedShaderFloatValue offsetUnits_ = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* offsetUnits */
        SerializedShaderFloatValue alphaToMask_ = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* alphaToMask */
        SerializedStencilOp stencilOp_ = SerializedStencilOp.Read(reader);
        reader.AlignTo(4); /* stencilOp */
        SerializedStencilOp stencilOpFront_ = SerializedStencilOp.Read(reader);
        reader.AlignTo(4); /* stencilOpFront */
        SerializedStencilOp stencilOpBack_ = SerializedStencilOp.Read(reader);
        reader.AlignTo(4); /* stencilOpBack */
        SerializedShaderFloatValue stencilReadMask_ = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* stencilReadMask */
        SerializedShaderFloatValue stencilWriteMask_ = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* stencilWriteMask */
        SerializedShaderFloatValue stencilRef_ = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* stencilRef */
        SerializedShaderFloatValue fogStart_ = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* fogStart */
        SerializedShaderFloatValue fogEnd_ = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* fogEnd */
        SerializedShaderFloatValue fogDensity_ = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* fogDensity */
        SerializedShaderVectorValue fogColor_ = SerializedShaderVectorValue.Read(reader);
        reader.AlignTo(4); /* fogColor */
        int fogMode_ = reader.ReadS32();
        int gpuProgramID_ = reader.ReadS32();
        SerializedTagMap m_Tags_ = SerializedTagMap.Read(reader);
        reader.AlignTo(4); /* m_Tags */
        int m_LOD_ = reader.ReadS32();
        bool lighting_ = reader.ReadBool();
        reader.AlignTo(4); /* lighting */
        
        return new(m_Name_,
            rtBlend0_,
            rtBlend1_,
            rtBlend2_,
            rtBlend3_,
            rtBlend4_,
            rtBlend5_,
            rtBlend6_,
            rtBlend7_,
            rtSeparateBlend_,
            zClip_,
            zTest_,
            zWrite_,
            culling_,
            conservative_,
            offsetFactor_,
            offsetUnits_,
            alphaToMask_,
            stencilOp_,
            stencilOpFront_,
            stencilOpBack_,
            stencilReadMask_,
            stencilWriteMask_,
            stencilRef_,
            fogStart_,
            fogEnd_,
            fogDensity_,
            fogColor_,
            fogMode_,
            gpuProgramID_,
            m_Tags_,
            m_LOD_,
            lighting_);
    }

    public override string ToString() => $"SerializedShaderState\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);
        ToString_Field15(sb, indent, indent_);
        ToString_Field16(sb, indent, indent_);
        ToString_Field17(sb, indent, indent_);
        ToString_Field18(sb, indent, indent_);
        ToString_Field19(sb, indent, indent_);
        ToString_Field20(sb, indent, indent_);
        ToString_Field21(sb, indent, indent_);
        ToString_Field22(sb, indent, indent_);
        ToString_Field23(sb, indent, indent_);
        ToString_Field24(sb, indent, indent_);
        ToString_Field25(sb, indent, indent_);
        ToString_Field26(sb, indent, indent_);
        ToString_Field27(sb, indent, indent_);
        ToString_Field28(sb, indent, indent_);
        ToString_Field29(sb, indent, indent_);
        ToString_Field30(sb, indent, indent_);
        ToString_Field31(sb, indent, indent_);
        ToString_Field32(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}rtBlend0: {{ \n{rtBlend0.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}rtBlend1: {{ \n{rtBlend1.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}rtBlend2: {{ \n{rtBlend2.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}rtBlend3: {{ \n{rtBlend3.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}rtBlend4: {{ \n{rtBlend4.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}rtBlend5: {{ \n{rtBlend5.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}rtBlend6: {{ \n{rtBlend6.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}rtBlend7: {{ \n{rtBlend7.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}rtSeparateBlend: {rtSeparateBlend}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}zClip: {{ \n{zClip.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}zTest: {{ \n{zTest.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}zWrite: {{ \n{zWrite.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}culling: {{ \n{culling.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}conservative: {{ \n{conservative.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}offsetFactor: {{ \n{offsetFactor.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}offsetUnits: {{ \n{offsetUnits.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}alphaToMask: {{ \n{alphaToMask.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}stencilOp: {{ \n{stencilOp.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field19(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}stencilOpFront: {{ \n{stencilOpFront.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field20(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}stencilOpBack: {{ \n{stencilOpBack.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field21(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}stencilReadMask: {{ \n{stencilReadMask.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field22(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}stencilWriteMask: {{ \n{stencilWriteMask.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field23(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}stencilRef: {{ \n{stencilRef.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field24(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}fogStart: {{ \n{fogStart.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field25(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}fogEnd: {{ \n{fogEnd.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field26(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}fogDensity: {{ \n{fogDensity.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field27(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}fogColor: {{ \n{fogColor.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field28(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}fogMode: {fogMode}");
    }

    public void ToString_Field29(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}gpuProgramID: {gpuProgramID}");
    }

    public void ToString_Field30(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Tags: {{ \n{m_Tags.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field31(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LOD: {m_LOD}");
    }

    public void ToString_Field32(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}lighting: {lighting}");
    }
}

/* $SerializedShaderRTBlendState (7 fields) */
public record class SerializedShaderRTBlendState (
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
        SerializedShaderFloatValue srcBlend_ = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* srcBlend */
        SerializedShaderFloatValue destBlend_ = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* destBlend */
        SerializedShaderFloatValue srcBlendAlpha_ = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* srcBlendAlpha */
        SerializedShaderFloatValue destBlendAlpha_ = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* destBlendAlpha */
        SerializedShaderFloatValue blendOp_ = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* blendOp */
        SerializedShaderFloatValue blendOpAlpha_ = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* blendOpAlpha */
        SerializedShaderFloatValue colMask_ = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* colMask */
        
        return new(srcBlend_,
            destBlend_,
            srcBlendAlpha_,
            destBlendAlpha_,
            blendOp_,
            blendOpAlpha_,
            colMask_);
    }

    public override string ToString() => $"SerializedShaderRTBlendState\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}srcBlend: {{ \n{srcBlend.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}destBlend: {{ \n{destBlend.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}srcBlendAlpha: {{ \n{srcBlendAlpha.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}destBlendAlpha: {{ \n{destBlendAlpha.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}blendOp: {{ \n{blendOp.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}blendOpAlpha: {{ \n{blendOpAlpha.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}colMask: {{ \n{colMask.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $SerializedShaderFloatValue (2 fields) */
public record class SerializedShaderFloatValue (
    float val,
    AsciiString name) : IUnityStructure
{
    public static SerializedShaderFloatValue Read(EndianBinaryReader reader)
    {
        float val_ = reader.ReadF32();
        AsciiString name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* name */
        
        return new(val_,
            name_);
    }

    public override string ToString() => $"SerializedShaderFloatValue\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}val: {val}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}name: \"{name}\"");
    }
}

/* $SerializedStencilOp (4 fields) */
public record class SerializedStencilOp (
    SerializedShaderFloatValue pass,
    SerializedShaderFloatValue fail,
    SerializedShaderFloatValue zFail,
    SerializedShaderFloatValue comp) : IUnityStructure
{
    public static SerializedStencilOp Read(EndianBinaryReader reader)
    {
        SerializedShaderFloatValue pass_ = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* pass */
        SerializedShaderFloatValue fail_ = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* fail */
        SerializedShaderFloatValue zFail_ = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* zFail */
        SerializedShaderFloatValue comp_ = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* comp */
        
        return new(pass_,
            fail_,
            zFail_,
            comp_);
    }

    public override string ToString() => $"SerializedStencilOp\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}pass: {{ \n{pass.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}fail: {{ \n{fail.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}zFail: {{ \n{zFail.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}comp: {{ \n{comp.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $SerializedShaderVectorValue (5 fields) */
public record class SerializedShaderVectorValue (
    SerializedShaderFloatValue x,
    SerializedShaderFloatValue y,
    SerializedShaderFloatValue z,
    SerializedShaderFloatValue w,
    AsciiString name) : IUnityStructure
{
    public static SerializedShaderVectorValue Read(EndianBinaryReader reader)
    {
        SerializedShaderFloatValue x_ = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* x */
        SerializedShaderFloatValue y_ = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* y */
        SerializedShaderFloatValue z_ = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* z */
        SerializedShaderFloatValue w_ = SerializedShaderFloatValue.Read(reader);
        reader.AlignTo(4); /* w */
        AsciiString name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* name */
        
        return new(x_,
            y_,
            z_,
            w_,
            name_);
    }

    public override string ToString() => $"SerializedShaderVectorValue\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}x: {{ \n{x.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}y: {{ \n{y.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}z: {{ \n{z.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}w: {{ \n{w.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}name: \"{name}\"");
    }
}

/* $SerializedTagMap (1 fields) */
public record class SerializedTagMap (
    Dictionary<AsciiString, AsciiString> tags) : IUnityStructure
{
    public static SerializedTagMap Read(EndianBinaryReader reader)
    {
        Dictionary<AsciiString, AsciiString> tags_ = BuiltInMap<AsciiString, AsciiString>.Read(reader);
        reader.AlignTo(4); /* tags */
        
        return new(tags_);
    }

    public override string ToString() => $"SerializedTagMap\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}tags[{tags.Count}] = {{");
        if (tags.Count > 0) sb.AppendLine();
        int _4i = 0;
        foreach (KeyValuePair<AsciiString, AsciiString> _4 in tags)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[\"{_4.Key}\"] = \"{_4.Value}\"");
            ++_4i;
        }
        if (tags.Count > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $SerializedProgram (5 fields) */
public record class SerializedProgram (
    SerializedSubProgram[] m_SubPrograms,
    SerializedPlayerSubProgram[][] m_PlayerSubPrograms,
    uint[][] m_ParameterBlobIndices,
    SerializedProgramParameters m_CommonParameters,
    ushort[] m_SerializedKeywordStateMask) : IUnityStructure
{
    public static SerializedProgram Read(EndianBinaryReader reader)
    {
        SerializedSubProgram[] m_SubPrograms_ = BuiltInArray<SerializedSubProgram>.Read(reader);
        reader.AlignTo(4); /* m_SubPrograms */
        SerializedPlayerSubProgram[][] m_PlayerSubPrograms_ = BuiltInArray<SerializedPlayerSubProgram[]>.Read(reader);
        reader.AlignTo(4); /* m_PlayerSubPrograms */
        uint[][] m_ParameterBlobIndices_ = BuiltInArray<uint[]>.Read(reader);
        reader.AlignTo(4); /* m_ParameterBlobIndices */
        SerializedProgramParameters m_CommonParameters_ = SerializedProgramParameters.Read(reader);
        reader.AlignTo(4); /* m_CommonParameters */
        ushort[] m_SerializedKeywordStateMask_ = BuiltInArray<ushort>.Read(reader);
        reader.AlignTo(4); /* m_SerializedKeywordStateMask */
        
        return new(m_SubPrograms_,
            m_PlayerSubPrograms_,
            m_ParameterBlobIndices_,
            m_CommonParameters_,
            m_SerializedKeywordStateMask_);
    }

    public override string ToString() => $"SerializedProgram\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_SubPrograms[{m_SubPrograms.Length}] = {{");
        if (m_SubPrograms.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (SerializedSubProgram _4 in m_SubPrograms)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_SubPrograms.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_PlayerSubPrograms[{m_PlayerSubPrograms.Length}] = {{");
        if (m_PlayerSubPrograms.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (SerializedPlayerSubProgram[] _4 in m_PlayerSubPrograms)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = [{_4.Length}] = {{");
            if (_4.Length > 0) sb.AppendLine();
            int _8i = 0;
            foreach (SerializedPlayerSubProgram _8 in _4)
            {
                sb.Append($"{indent_ + ' '.Repeat(8)}[{_8i}] = {{ \n{_8.ToString(indent+12)}{indent_ + ' '.Repeat(8)}}}\n");
                ++_8i;
            }
            if (_4.Length > 0) sb.Append(indent_ + ' '.Repeat(4));
            sb.AppendLine("}");
            ++_4i;
        }
        if (m_PlayerSubPrograms.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ParameterBlobIndices[{m_ParameterBlobIndices.Length}] = {{");
        if (m_ParameterBlobIndices.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint[] _4 in m_ParameterBlobIndices)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = [{_4.Length}] = {{");
            if (_4.Length > 0) sb.AppendLine();
            int _8i = 0;
            foreach (uint _8 in _4)
            {
                sb.AppendLine($"{indent_ + ' '.Repeat(8)}[{_8i}] = {_8}");
                ++_8i;
            }
            if (_4.Length > 0) sb.Append(indent_ + ' '.Repeat(4));
            sb.AppendLine("}");
            ++_4i;
        }
        if (m_ParameterBlobIndices.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_CommonParameters: {{ \n{m_CommonParameters.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_SerializedKeywordStateMask[{m_SerializedKeywordStateMask.Length}] = {{");
        if (m_SerializedKeywordStateMask.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (ushort _4 in m_SerializedKeywordStateMask)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_SerializedKeywordStateMask.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $SerializedSubProgram (7 fields) */
public record class SerializedSubProgram (
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
        uint m_BlobIndex_ = reader.ReadU32();
        ParserBindChannels m_Channels_ = ParserBindChannels.Read(reader);
        reader.AlignTo(4); /* m_Channels */
        ushort[] m_KeywordIndices_ = BuiltInArray<ushort>.Read(reader);
        reader.AlignTo(4); /* m_KeywordIndices */
        sbyte m_ShaderHardwareTier_ = reader.ReadS8();
        sbyte m_GpuProgramType_ = reader.ReadS8();
        reader.AlignTo(4); /* m_GpuProgramType */
        SerializedProgramParameters m_Parameters_ = SerializedProgramParameters.Read(reader);
        reader.AlignTo(4); /* m_Parameters */
        long m_ShaderRequirements_ = reader.ReadS64();
        
        return new(m_BlobIndex_,
            m_Channels_,
            m_KeywordIndices_,
            m_ShaderHardwareTier_,
            m_GpuProgramType_,
            m_Parameters_,
            m_ShaderRequirements_);
    }

    public override string ToString() => $"SerializedSubProgram\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BlobIndex: {m_BlobIndex}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Channels: {{ \n{m_Channels.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_KeywordIndices[{m_KeywordIndices.Length}] = {{");
        if (m_KeywordIndices.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (ushort _4 in m_KeywordIndices)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_KeywordIndices.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ShaderHardwareTier: {m_ShaderHardwareTier}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_GpuProgramType: {m_GpuProgramType}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Parameters: {{ \n{m_Parameters.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ShaderRequirements: {m_ShaderRequirements}");
    }
}

/* $ParserBindChannels (2 fields) */
public record class ParserBindChannels (
    ShaderBindChannel[] m_Channels,
    int m_SourceMap) : IUnityStructure
{
    public static ParserBindChannels Read(EndianBinaryReader reader)
    {
        ShaderBindChannel[] m_Channels_ = BuiltInArray<ShaderBindChannel>.Read(reader);
        reader.AlignTo(4); /* m_Channels */
        int m_SourceMap_ = reader.ReadS32();
        
        return new(m_Channels_,
            m_SourceMap_);
    }

    public override string ToString() => $"ParserBindChannels\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Channels[{m_Channels.Length}] = {{");
        if (m_Channels.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (ShaderBindChannel _4 in m_Channels)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ source: {_4.source}, target: {_4.target} }}\n");
            ++_4i;
        }
        if (m_Channels.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SourceMap: {m_SourceMap}");
    }
}

/* $ShaderBindChannel (2 fields) */
public readonly record struct ShaderBindChannel (
    sbyte source,
    sbyte target) : IUnityStructure
{
    public static ShaderBindChannel Read(EndianBinaryReader reader)
    {
        sbyte source_ = reader.ReadS8();
        sbyte target_ = reader.ReadS8();
        
        return new(source_,
            target_);
    }

    public override string ToString() => $"ShaderBindChannel\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}source: {source}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}target: {target}");
    }
}

/* $SerializedProgramParameters (8 fields) */
public record class SerializedProgramParameters (
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
        VectorParameter[] m_VectorParams_ = BuiltInArray<VectorParameter>.Read(reader);
        reader.AlignTo(4); /* m_VectorParams */
        MatrixParameter[] m_MatrixParams_ = BuiltInArray<MatrixParameter>.Read(reader);
        reader.AlignTo(4); /* m_MatrixParams */
        TextureParameter[] m_TextureParams_ = BuiltInArray<TextureParameter>.Read(reader);
        reader.AlignTo(4); /* m_TextureParams */
        BufferBinding[] m_BufferParams_ = BuiltInArray<BufferBinding>.Read(reader);
        reader.AlignTo(4); /* m_BufferParams */
        ConstantBuffer[] m_ConstantBuffers_ = BuiltInArray<ConstantBuffer>.Read(reader);
        reader.AlignTo(4); /* m_ConstantBuffers */
        BufferBinding[] m_ConstantBufferBindings_ = BuiltInArray<BufferBinding>.Read(reader);
        reader.AlignTo(4); /* m_ConstantBufferBindings */
        UAVParameter[] m_UAVParams_ = BuiltInArray<UAVParameter>.Read(reader);
        reader.AlignTo(4); /* m_UAVParams */
        SamplerParameter[] m_Samplers_ = BuiltInArray<SamplerParameter>.Read(reader);
        reader.AlignTo(4); /* m_Samplers */
        
        return new(m_VectorParams_,
            m_MatrixParams_,
            m_TextureParams_,
            m_BufferParams_,
            m_ConstantBuffers_,
            m_ConstantBufferBindings_,
            m_UAVParams_,
            m_Samplers_);
    }

    public override string ToString() => $"SerializedProgramParameters\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_VectorParams[{m_VectorParams.Length}] = {{");
        if (m_VectorParams.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VectorParameter _4 in m_VectorParams)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_VectorParams.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_MatrixParams[{m_MatrixParams.Length}] = {{");
        if (m_MatrixParams.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (MatrixParameter _4 in m_MatrixParams)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_MatrixParams.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_TextureParams[{m_TextureParams.Length}] = {{");
        if (m_TextureParams.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (TextureParameter _4 in m_TextureParams)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_TextureParams.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_BufferParams[{m_BufferParams.Length}] = {{");
        if (m_BufferParams.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (BufferBinding _4 in m_BufferParams)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ m_NameIndex: {_4.m_NameIndex}, m_Index: {_4.m_Index}, m_ArraySize: {_4.m_ArraySize} }}\n");
            ++_4i;
        }
        if (m_BufferParams.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ConstantBuffers[{m_ConstantBuffers.Length}] = {{");
        if (m_ConstantBuffers.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (ConstantBuffer _4 in m_ConstantBuffers)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_ConstantBuffers.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ConstantBufferBindings[{m_ConstantBufferBindings.Length}] = {{");
        if (m_ConstantBufferBindings.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (BufferBinding _4 in m_ConstantBufferBindings)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ m_NameIndex: {_4.m_NameIndex}, m_Index: {_4.m_Index}, m_ArraySize: {_4.m_ArraySize} }}\n");
            ++_4i;
        }
        if (m_ConstantBufferBindings.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_UAVParams[{m_UAVParams.Length}] = {{");
        if (m_UAVParams.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (UAVParameter _4 in m_UAVParams)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ m_NameIndex: {_4.m_NameIndex}, m_Index: {_4.m_Index}, m_OriginalIndex: {_4.m_OriginalIndex} }}\n");
            ++_4i;
        }
        if (m_UAVParams.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Samplers[{m_Samplers.Length}] = {{");
        if (m_Samplers.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (SamplerParameter _4 in m_Samplers)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ sampler: {_4.sampler}, bindPoint: {_4.bindPoint} }}\n");
            ++_4i;
        }
        if (m_Samplers.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $VectorParameter (5 fields) */
public readonly record struct VectorParameter (
    int m_NameIndex,
    int m_Index,
    int m_ArraySize,
    sbyte m_Type,
    sbyte m_Dim) : IUnityStructure
{
    public static VectorParameter Read(EndianBinaryReader reader)
    {
        int m_NameIndex_ = reader.ReadS32();
        int m_Index_ = reader.ReadS32();
        int m_ArraySize_ = reader.ReadS32();
        sbyte m_Type_ = reader.ReadS8();
        sbyte m_Dim_ = reader.ReadS8();
        reader.AlignTo(4); /* m_Dim */
        
        return new(m_NameIndex_,
            m_Index_,
            m_ArraySize_,
            m_Type_,
            m_Dim_);
    }

    public override string ToString() => $"VectorParameter\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_NameIndex: {m_NameIndex}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Index: {m_Index}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ArraySize: {m_ArraySize}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Type: {m_Type}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Dim: {m_Dim}");
    }
}

/* $MatrixParameter (5 fields) */
public readonly record struct MatrixParameter (
    int m_NameIndex,
    int m_Index,
    int m_ArraySize,
    sbyte m_Type,
    sbyte m_RowCount) : IUnityStructure
{
    public static MatrixParameter Read(EndianBinaryReader reader)
    {
        int m_NameIndex_ = reader.ReadS32();
        int m_Index_ = reader.ReadS32();
        int m_ArraySize_ = reader.ReadS32();
        sbyte m_Type_ = reader.ReadS8();
        sbyte m_RowCount_ = reader.ReadS8();
        reader.AlignTo(4); /* m_RowCount */
        
        return new(m_NameIndex_,
            m_Index_,
            m_ArraySize_,
            m_Type_,
            m_RowCount_);
    }

    public override string ToString() => $"MatrixParameter\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_NameIndex: {m_NameIndex}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Index: {m_Index}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ArraySize: {m_ArraySize}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Type: {m_Type}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RowCount: {m_RowCount}");
    }
}

/* $TextureParameter (5 fields) */
public readonly record struct TextureParameter (
    int m_NameIndex,
    int m_Index,
    int m_SamplerIndex,
    bool m_MultiSampled,
    sbyte m_Dim) : IUnityStructure
{
    public static TextureParameter Read(EndianBinaryReader reader)
    {
        int m_NameIndex_ = reader.ReadS32();
        int m_Index_ = reader.ReadS32();
        int m_SamplerIndex_ = reader.ReadS32();
        bool m_MultiSampled_ = reader.ReadBool();
        sbyte m_Dim_ = reader.ReadS8();
        reader.AlignTo(4); /* m_Dim */
        
        return new(m_NameIndex_,
            m_Index_,
            m_SamplerIndex_,
            m_MultiSampled_,
            m_Dim_);
    }

    public override string ToString() => $"TextureParameter\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_NameIndex: {m_NameIndex}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Index: {m_Index}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SamplerIndex: {m_SamplerIndex}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MultiSampled: {m_MultiSampled}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Dim: {m_Dim}");
    }
}

/* $BufferBinding (3 fields) */
public readonly record struct BufferBinding (
    int m_NameIndex,
    int m_Index,
    int m_ArraySize) : IUnityStructure
{
    public static BufferBinding Read(EndianBinaryReader reader)
    {
        int m_NameIndex_ = reader.ReadS32();
        int m_Index_ = reader.ReadS32();
        int m_ArraySize_ = reader.ReadS32();
        
        return new(m_NameIndex_,
            m_Index_,
            m_ArraySize_);
    }

    public override string ToString() => $"BufferBinding\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_NameIndex: {m_NameIndex}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Index: {m_Index}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ArraySize: {m_ArraySize}");
    }
}

/* $ConstantBuffer (6 fields) */
public record class ConstantBuffer (
    int m_NameIndex,
    MatrixParameter[] m_MatrixParams,
    VectorParameter[] m_VectorParams,
    StructParameter[] m_StructParams,
    int m_Size,
    bool m_IsPartialCB) : IUnityStructure
{
    public static ConstantBuffer Read(EndianBinaryReader reader)
    {
        int m_NameIndex_ = reader.ReadS32();
        MatrixParameter[] m_MatrixParams_ = BuiltInArray<MatrixParameter>.Read(reader);
        reader.AlignTo(4); /* m_MatrixParams */
        VectorParameter[] m_VectorParams_ = BuiltInArray<VectorParameter>.Read(reader);
        reader.AlignTo(4); /* m_VectorParams */
        StructParameter[] m_StructParams_ = BuiltInArray<StructParameter>.Read(reader);
        reader.AlignTo(4); /* m_StructParams */
        int m_Size_ = reader.ReadS32();
        bool m_IsPartialCB_ = reader.ReadBool();
        reader.AlignTo(4); /* m_IsPartialCB */
        
        return new(m_NameIndex_,
            m_MatrixParams_,
            m_VectorParams_,
            m_StructParams_,
            m_Size_,
            m_IsPartialCB_);
    }

    public override string ToString() => $"ConstantBuffer\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_NameIndex: {m_NameIndex}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_MatrixParams[{m_MatrixParams.Length}] = {{");
        if (m_MatrixParams.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (MatrixParameter _4 in m_MatrixParams)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_MatrixParams.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_VectorParams[{m_VectorParams.Length}] = {{");
        if (m_VectorParams.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VectorParameter _4 in m_VectorParams)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_VectorParams.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_StructParams[{m_StructParams.Length}] = {{");
        if (m_StructParams.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (StructParameter _4 in m_StructParams)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_StructParams.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Size: {m_Size}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_IsPartialCB: {m_IsPartialCB}");
    }
}

/* $StructParameter (6 fields) */
public record class StructParameter (
    int m_NameIndex,
    int m_Index,
    int m_ArraySize,
    int m_StructSize,
    VectorParameter[] m_VectorMembers,
    MatrixParameter[] m_MatrixMembers) : IUnityStructure
{
    public static StructParameter Read(EndianBinaryReader reader)
    {
        int m_NameIndex_ = reader.ReadS32();
        int m_Index_ = reader.ReadS32();
        int m_ArraySize_ = reader.ReadS32();
        int m_StructSize_ = reader.ReadS32();
        VectorParameter[] m_VectorMembers_ = BuiltInArray<VectorParameter>.Read(reader);
        reader.AlignTo(4); /* m_VectorMembers */
        MatrixParameter[] m_MatrixMembers_ = BuiltInArray<MatrixParameter>.Read(reader);
        reader.AlignTo(4); /* m_MatrixMembers */
        
        return new(m_NameIndex_,
            m_Index_,
            m_ArraySize_,
            m_StructSize_,
            m_VectorMembers_,
            m_MatrixMembers_);
    }

    public override string ToString() => $"StructParameter\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_NameIndex: {m_NameIndex}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Index: {m_Index}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ArraySize: {m_ArraySize}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_StructSize: {m_StructSize}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_VectorMembers[{m_VectorMembers.Length}] = {{");
        if (m_VectorMembers.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VectorParameter _4 in m_VectorMembers)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_VectorMembers.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_MatrixMembers[{m_MatrixMembers.Length}] = {{");
        if (m_MatrixMembers.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (MatrixParameter _4 in m_MatrixMembers)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_MatrixMembers.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $UAVParameter (3 fields) */
public readonly record struct UAVParameter (
    int m_NameIndex,
    int m_Index,
    int m_OriginalIndex) : IUnityStructure
{
    public static UAVParameter Read(EndianBinaryReader reader)
    {
        int m_NameIndex_ = reader.ReadS32();
        int m_Index_ = reader.ReadS32();
        int m_OriginalIndex_ = reader.ReadS32();
        
        return new(m_NameIndex_,
            m_Index_,
            m_OriginalIndex_);
    }

    public override string ToString() => $"UAVParameter\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_NameIndex: {m_NameIndex}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Index: {m_Index}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_OriginalIndex: {m_OriginalIndex}");
    }
}

/* $SamplerParameter (2 fields) */
public readonly record struct SamplerParameter (
    uint sampler,
    int bindPoint) : IUnityStructure
{
    public static SamplerParameter Read(EndianBinaryReader reader)
    {
        uint sampler_ = reader.ReadU32();
        int bindPoint_ = reader.ReadS32();
        
        return new(sampler_,
            bindPoint_);
    }

    public override string ToString() => $"SamplerParameter\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sampler: {sampler}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}bindPoint: {bindPoint}");
    }
}

/* $SerializedPlayerSubProgram (4 fields) */
public record class SerializedPlayerSubProgram (
    uint m_BlobIndex,
    ushort[] m_KeywordIndices,
    long m_ShaderRequirements,
    sbyte m_GpuProgramType) : IUnityStructure
{
    public static SerializedPlayerSubProgram Read(EndianBinaryReader reader)
    {
        uint m_BlobIndex_ = reader.ReadU32();
        ushort[] m_KeywordIndices_ = BuiltInArray<ushort>.Read(reader);
        reader.AlignTo(4); /* m_KeywordIndices */
        long m_ShaderRequirements_ = reader.ReadS64();
        sbyte m_GpuProgramType_ = reader.ReadS8();
        reader.AlignTo(4); /* m_GpuProgramType */
        
        return new(m_BlobIndex_,
            m_KeywordIndices_,
            m_ShaderRequirements_,
            m_GpuProgramType_);
    }

    public override string ToString() => $"SerializedPlayerSubProgram\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BlobIndex: {m_BlobIndex}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_KeywordIndices[{m_KeywordIndices.Length}] = {{");
        if (m_KeywordIndices.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (ushort _4 in m_KeywordIndices)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_KeywordIndices.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ShaderRequirements: {m_ShaderRequirements}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_GpuProgramType: {m_GpuProgramType}");
    }
}

/* $SerializedShaderDependency (2 fields) */
public record class SerializedShaderDependency (
    AsciiString @from,
    AsciiString to) : IUnityStructure
{
    public static SerializedShaderDependency Read(EndianBinaryReader reader)
    {
        AsciiString @from_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* @from */
        AsciiString to_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* to */
        
        return new(@from_,
            to_);
    }

    public override string ToString() => $"SerializedShaderDependency\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}@from: \"{@from}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}to: \"{to}\"");
    }
}

/* $SerializedCustomEditorForRenderPipeline (2 fields) */
public record class SerializedCustomEditorForRenderPipeline (
    AsciiString customEditorName,
    AsciiString renderPipelineType) : IUnityStructure
{
    public static SerializedCustomEditorForRenderPipeline Read(EndianBinaryReader reader)
    {
        AsciiString customEditorName_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* customEditorName */
        AsciiString renderPipelineType_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* renderPipelineType */
        
        return new(customEditorName_,
            renderPipelineType_);
    }

    public override string ToString() => $"SerializedCustomEditorForRenderPipeline\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}customEditorName: \"{customEditorName}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}renderPipelineType: \"{renderPipelineType}\"");
    }
}

/* $LightProbeData (4 fields) */
public record class LightProbeData (
    ProbeSetTetrahedralization m_Tetrahedralization,
    ProbeSetIndex[] m_ProbeSets,
    Vector3f[] m_Positions,
    Dictionary<Hash128, int> m_NonTetrahedralizedProbeSetIndexMap) : IUnityStructure
{
    public static LightProbeData Read(EndianBinaryReader reader)
    {
        ProbeSetTetrahedralization m_Tetrahedralization_ = ProbeSetTetrahedralization.Read(reader);
        reader.AlignTo(4); /* m_Tetrahedralization */
        ProbeSetIndex[] m_ProbeSets_ = BuiltInArray<ProbeSetIndex>.Read(reader);
        reader.AlignTo(4); /* m_ProbeSets */
        Vector3f[] m_Positions_ = BuiltInArray<Vector3f>.Read(reader);
        reader.AlignTo(4); /* m_Positions */
        Dictionary<Hash128, int> m_NonTetrahedralizedProbeSetIndexMap_ = BuiltInMap<Hash128, int>.Read(reader);
        
        return new(m_Tetrahedralization_,
            m_ProbeSets_,
            m_Positions_,
            m_NonTetrahedralizedProbeSetIndexMap_);
    }

    public override string ToString() => $"LightProbeData\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Tetrahedralization: {{ \n{m_Tetrahedralization.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ProbeSets[{m_ProbeSets.Length}] = {{");
        if (m_ProbeSets.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (ProbeSetIndex _4 in m_ProbeSets)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_ProbeSets.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Positions[{m_Positions.Length}] = {{");
        if (m_Positions.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (Vector3f _4 in m_Positions)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ x: {_4.x}, y: {_4.y}, z: {_4.z} }}\n");
            ++_4i;
        }
        if (m_Positions.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_NonTetrahedralizedProbeSetIndexMap[{m_NonTetrahedralizedProbeSetIndexMap.Count}] = {{");
        if (m_NonTetrahedralizedProbeSetIndexMap.Count > 0) sb.AppendLine();
        int _4i = 0;
        foreach (KeyValuePair<Hash128, int> _4 in m_NonTetrahedralizedProbeSetIndexMap)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4.Key}] = {_4.Value}");
            ++_4i;
        }
        if (m_NonTetrahedralizedProbeSetIndexMap.Count > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $ProbeSetTetrahedralization (2 fields) */
public record class ProbeSetTetrahedralization (
    Tetrahedron[] m_Tetrahedra,
    Vector3f[] m_HullRays) : IUnityStructure
{
    public static ProbeSetTetrahedralization Read(EndianBinaryReader reader)
    {
        Tetrahedron[] m_Tetrahedra_ = BuiltInArray<Tetrahedron>.Read(reader);
        reader.AlignTo(4); /* m_Tetrahedra */
        Vector3f[] m_HullRays_ = BuiltInArray<Vector3f>.Read(reader);
        reader.AlignTo(4); /* m_HullRays */
        
        return new(m_Tetrahedra_,
            m_HullRays_);
    }

    public override string ToString() => $"ProbeSetTetrahedralization\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Tetrahedra[{m_Tetrahedra.Length}] = {{");
        if (m_Tetrahedra.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (Tetrahedron _4 in m_Tetrahedra)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Tetrahedra.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_HullRays[{m_HullRays.Length}] = {{");
        if (m_HullRays.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (Vector3f _4 in m_HullRays)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ x: {_4.x}, y: {_4.y}, z: {_4.z} }}\n");
            ++_4i;
        }
        if (m_HullRays.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $Tetrahedron (9 fields) */
public record class Tetrahedron (
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
        int indices_0_ = reader.ReadS32();
        int indices_1_ = reader.ReadS32();
        int indices_2_ = reader.ReadS32();
        int indices_3_ = reader.ReadS32();
        int neighbors_0_ = reader.ReadS32();
        int neighbors_1_ = reader.ReadS32();
        int neighbors_2_ = reader.ReadS32();
        int neighbors_3_ = reader.ReadS32();
        Matrix3x4f matrix_ = Matrix3x4f.Read(reader);
        
        return new(indices_0_,
            indices_1_,
            indices_2_,
            indices_3_,
            neighbors_0_,
            neighbors_1_,
            neighbors_2_,
            neighbors_3_,
            matrix_);
    }

    public override string ToString() => $"Tetrahedron\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}indices_0: {indices_0}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}indices_1: {indices_1}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}indices_2: {indices_2}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}indices_3: {indices_3}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}neighbors_0: {neighbors_0}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}neighbors_1: {neighbors_1}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}neighbors_2: {neighbors_2}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}neighbors_3: {neighbors_3}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}matrix: {{ \n{matrix.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $Matrix3x4f (12 fields) */
public readonly record struct Matrix3x4f (
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
        float e00_ = reader.ReadF32();
        float e01_ = reader.ReadF32();
        float e02_ = reader.ReadF32();
        float e03_ = reader.ReadF32();
        float e10_ = reader.ReadF32();
        float e11_ = reader.ReadF32();
        float e12_ = reader.ReadF32();
        float e13_ = reader.ReadF32();
        float e20_ = reader.ReadF32();
        float e21_ = reader.ReadF32();
        float e22_ = reader.ReadF32();
        float e23_ = reader.ReadF32();
        
        return new(e00_,
            e01_,
            e02_,
            e03_,
            e10_,
            e11_,
            e12_,
            e13_,
            e20_,
            e21_,
            e22_,
            e23_);
    }

    public override string ToString() => $"Matrix3x4f\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}e00: {e00}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}e01: {e01}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}e02: {e02}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}e03: {e03}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}e10: {e10}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}e11: {e11}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}e12: {e12}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}e13: {e13}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}e20: {e20}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}e21: {e21}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}e22: {e22}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}e23: {e23}");
    }
}

/* $ProbeSetIndex (3 fields) */
public record class ProbeSetIndex (
    Hash128 m_Hash,
    int m_Offset,
    int m_Size) : IUnityStructure
{
    public static ProbeSetIndex Read(EndianBinaryReader reader)
    {
        Hash128 m_Hash_ = Hash128.Read(reader);
        int m_Offset_ = reader.ReadS32();
        int m_Size_ = reader.ReadS32();
        
        return new(m_Hash_,
            m_Offset_,
            m_Size_);
    }

    public override string ToString() => $"ProbeSetIndex\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Hash: {m_Hash}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Offset: {m_Offset}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Size: {m_Size}");
    }
}

/* $SphericalHarmonicsL2 (27 fields) */
public readonly record struct SphericalHarmonicsL2 (
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
        float sh_0_ = reader.ReadF32();
        float sh_1_ = reader.ReadF32();
        float sh_2_ = reader.ReadF32();
        float sh_3_ = reader.ReadF32();
        float sh_4_ = reader.ReadF32();
        float sh_5_ = reader.ReadF32();
        float sh_6_ = reader.ReadF32();
        float sh_7_ = reader.ReadF32();
        float sh_8_ = reader.ReadF32();
        float sh_9_ = reader.ReadF32();
        float sh_10_ = reader.ReadF32();
        float sh_11_ = reader.ReadF32();
        float sh_12_ = reader.ReadF32();
        float sh_13_ = reader.ReadF32();
        float sh_14_ = reader.ReadF32();
        float sh_15_ = reader.ReadF32();
        float sh_16_ = reader.ReadF32();
        float sh_17_ = reader.ReadF32();
        float sh_18_ = reader.ReadF32();
        float sh_19_ = reader.ReadF32();
        float sh_20_ = reader.ReadF32();
        float sh_21_ = reader.ReadF32();
        float sh_22_ = reader.ReadF32();
        float sh_23_ = reader.ReadF32();
        float sh_24_ = reader.ReadF32();
        float sh_25_ = reader.ReadF32();
        float sh_26_ = reader.ReadF32();
        
        return new(sh_0_,
            sh_1_,
            sh_2_,
            sh_3_,
            sh_4_,
            sh_5_,
            sh_6_,
            sh_7_,
            sh_8_,
            sh_9_,
            sh_10_,
            sh_11_,
            sh_12_,
            sh_13_,
            sh_14_,
            sh_15_,
            sh_16_,
            sh_17_,
            sh_18_,
            sh_19_,
            sh_20_,
            sh_21_,
            sh_22_,
            sh_23_,
            sh_24_,
            sh_25_,
            sh_26_);
    }

    public override string ToString() => $"SphericalHarmonicsL2\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);
        ToString_Field15(sb, indent, indent_);
        ToString_Field16(sb, indent, indent_);
        ToString_Field17(sb, indent, indent_);
        ToString_Field18(sb, indent, indent_);
        ToString_Field19(sb, indent, indent_);
        ToString_Field20(sb, indent, indent_);
        ToString_Field21(sb, indent, indent_);
        ToString_Field22(sb, indent, indent_);
        ToString_Field23(sb, indent, indent_);
        ToString_Field24(sb, indent, indent_);
        ToString_Field25(sb, indent, indent_);
        ToString_Field26(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sh_0: {sh_0}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sh_1: {sh_1}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sh_2: {sh_2}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sh_3: {sh_3}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sh_4: {sh_4}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sh_5: {sh_5}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sh_6: {sh_6}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sh_7: {sh_7}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sh_8: {sh_8}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sh_9: {sh_9}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sh_10: {sh_10}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sh_11: {sh_11}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sh_12: {sh_12}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sh_13: {sh_13}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sh_14: {sh_14}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sh_15: {sh_15}");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sh_16: {sh_16}");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sh_17: {sh_17}");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sh_18: {sh_18}");
    }

    public void ToString_Field19(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sh_19: {sh_19}");
    }

    public void ToString_Field20(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sh_20: {sh_20}");
    }

    public void ToString_Field21(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sh_21: {sh_21}");
    }

    public void ToString_Field22(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sh_22: {sh_22}");
    }

    public void ToString_Field23(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sh_23: {sh_23}");
    }

    public void ToString_Field24(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sh_24: {sh_24}");
    }

    public void ToString_Field25(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sh_25: {sh_25}");
    }

    public void ToString_Field26(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sh_26: {sh_26}");
    }
}

/* $LightProbeOcclusion (3 fields) */
public record class LightProbeOcclusion (
    int[] m_ProbeOcclusionLightIndex,
    float[] m_Occlusion,
    sbyte[] m_OcclusionMaskChannel) : IUnityStructure
{
    public static LightProbeOcclusion Read(EndianBinaryReader reader)
    {
        int[] m_ProbeOcclusionLightIndex_ = BuiltInArray<int>.Read(reader);
        float[] m_Occlusion_ = BuiltInArray<float>.Read(reader);
        sbyte[] m_OcclusionMaskChannel_ = BuiltInArray<sbyte>.Read(reader);
        
        return new(m_ProbeOcclusionLightIndex_,
            m_Occlusion_,
            m_OcclusionMaskChannel_);
    }

    public override string ToString() => $"LightProbeOcclusion\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ProbeOcclusionLightIndex[{m_ProbeOcclusionLightIndex.Length}] = {{");
        if (m_ProbeOcclusionLightIndex.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (int _4 in m_ProbeOcclusionLightIndex)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_ProbeOcclusionLightIndex.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Occlusion[{m_Occlusion.Length}] = {{");
        if (m_Occlusion.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (float _4 in m_Occlusion)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_Occlusion.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_OcclusionMaskChannel[{m_OcclusionMaskChannel.Length}] = {{");
        if (m_OcclusionMaskChannel.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (sbyte _4 in m_OcclusionMaskChannel)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_OcclusionMaskChannel.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $GLTextureSettings (6 fields) */
public readonly record struct GLTextureSettings (
    int m_FilterMode,
    int m_Aniso,
    float m_MipBias,
    int m_WrapU,
    int m_WrapV,
    int m_WrapW) : IUnityStructure
{
    public static GLTextureSettings Read(EndianBinaryReader reader)
    {
        int m_FilterMode_ = reader.ReadS32();
        int m_Aniso_ = reader.ReadS32();
        float m_MipBias_ = reader.ReadF32();
        int m_WrapU_ = reader.ReadS32();
        int m_WrapV_ = reader.ReadS32();
        int m_WrapW_ = reader.ReadS32();
        
        return new(m_FilterMode_,
            m_Aniso_,
            m_MipBias_,
            m_WrapU_,
            m_WrapV_,
            m_WrapW_);
    }

    public override string ToString() => $"GLTextureSettings\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_FilterMode: {m_FilterMode}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Aniso: {m_Aniso}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MipBias: {m_MipBias}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_WrapU: {m_WrapU}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_WrapV: {m_WrapV}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_WrapW: {m_WrapW}");
    }
}

/* $AvatarConstant (12 fields) */
public record class AvatarConstant (
    OffsetPtr m_AvatarSkeleton,
    OffsetPtr_1 m_AvatarSkeletonPose,
    OffsetPtr_1 m_DefaultPose,
    uint[] m_SkeletonNameIDArray,
    OffsetPtr_2 m_Human,
    int[] m_HumanSkeletonIndexArray,
    int[] m_HumanSkeletonReverseIndexArray,
    int m_RootMotionBoneIndex,
    xform m_RootMotionBoneX,
    OffsetPtr m_RootMotionSkeleton,
    OffsetPtr_1 m_RootMotionSkeletonPose,
    int[] m_RootMotionSkeletonIndexArray) : IUnityStructure
{
    public static AvatarConstant Read(EndianBinaryReader reader)
    {
        OffsetPtr m_AvatarSkeleton_ = OffsetPtr.Read(reader);
        OffsetPtr_1 m_AvatarSkeletonPose_ = OffsetPtr_1.Read(reader);
        OffsetPtr_1 m_DefaultPose_ = OffsetPtr_1.Read(reader);
        uint[] m_SkeletonNameIDArray_ = BuiltInArray<uint>.Read(reader);
        OffsetPtr_2 m_Human_ = OffsetPtr_2.Read(reader);
        reader.AlignTo(4); /* m_Human */
        int[] m_HumanSkeletonIndexArray_ = BuiltInArray<int>.Read(reader);
        int[] m_HumanSkeletonReverseIndexArray_ = BuiltInArray<int>.Read(reader);
        int m_RootMotionBoneIndex_ = reader.ReadS32();
        xform m_RootMotionBoneX_ = xform.Read(reader);
        OffsetPtr m_RootMotionSkeleton_ = OffsetPtr.Read(reader);
        OffsetPtr_1 m_RootMotionSkeletonPose_ = OffsetPtr_1.Read(reader);
        int[] m_RootMotionSkeletonIndexArray_ = BuiltInArray<int>.Read(reader);
        reader.AlignTo(4); /* m_RootMotionSkeletonIndexArray */
        
        return new(m_AvatarSkeleton_,
            m_AvatarSkeletonPose_,
            m_DefaultPose_,
            m_SkeletonNameIDArray_,
            m_Human_,
            m_HumanSkeletonIndexArray_,
            m_HumanSkeletonReverseIndexArray_,
            m_RootMotionBoneIndex_,
            m_RootMotionBoneX_,
            m_RootMotionSkeleton_,
            m_RootMotionSkeletonPose_,
            m_RootMotionSkeletonIndexArray_);
    }

    public override string ToString() => $"AvatarConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_AvatarSkeleton: {{ \n{m_AvatarSkeleton.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_AvatarSkeletonPose: {{ \n{m_AvatarSkeletonPose.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_DefaultPose: {{ \n{m_DefaultPose.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_SkeletonNameIDArray[{m_SkeletonNameIDArray.Length}] = {{");
        if (m_SkeletonNameIDArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint _4 in m_SkeletonNameIDArray)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_SkeletonNameIDArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Human: {{ \n{m_Human.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_HumanSkeletonIndexArray[{m_HumanSkeletonIndexArray.Length}] = {{");
        if (m_HumanSkeletonIndexArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (int _4 in m_HumanSkeletonIndexArray)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_HumanSkeletonIndexArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_HumanSkeletonReverseIndexArray[{m_HumanSkeletonReverseIndexArray.Length}] = {{");
        if (m_HumanSkeletonReverseIndexArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (int _4 in m_HumanSkeletonReverseIndexArray)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_HumanSkeletonReverseIndexArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RootMotionBoneIndex: {m_RootMotionBoneIndex}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_RootMotionBoneX: {{ \n{m_RootMotionBoneX.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_RootMotionSkeleton: {{ \n{m_RootMotionSkeleton.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_RootMotionSkeletonPose: {{ \n{m_RootMotionSkeletonPose.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_RootMotionSkeletonIndexArray[{m_RootMotionSkeletonIndexArray.Length}] = {{");
        if (m_RootMotionSkeletonIndexArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (int _4 in m_RootMotionSkeletonIndexArray)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_RootMotionSkeletonIndexArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $OffsetPtr (1 fields) */
public record class OffsetPtr (
    Skeleton data) : IUnityStructure
{
    public static OffsetPtr Read(EndianBinaryReader reader)
    {
        Skeleton data_ = Skeleton.Read(reader);
        
        return new(data_);
    }

    public override string ToString() => $"OffsetPtr\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}data: {{ \n{data.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $Skeleton (3 fields) */
public record class Skeleton (
    Node[] m_Node,
    uint[] m_ID,
    Axes[] m_AxesArray) : IUnityStructure
{
    public static Skeleton Read(EndianBinaryReader reader)
    {
        Node[] m_Node_ = BuiltInArray<Node>.Read(reader);
        uint[] m_ID_ = BuiltInArray<uint>.Read(reader);
        Axes[] m_AxesArray_ = BuiltInArray<Axes>.Read(reader);
        
        return new(m_Node_,
            m_ID_,
            m_AxesArray_);
    }

    public override string ToString() => $"Skeleton\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Node[{m_Node.Length}] = {{");
        if (m_Node.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (Node _4 in m_Node)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ m_ParentId: {_4.m_ParentId}, m_AxesId: {_4.m_AxesId} }}\n");
            ++_4i;
        }
        if (m_Node.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ID[{m_ID.Length}] = {{");
        if (m_ID.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint _4 in m_ID)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_ID.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_AxesArray[{m_AxesArray.Length}] = {{");
        if (m_AxesArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (Axes _4 in m_AxesArray)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_AxesArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $Node (2 fields) */
public readonly record struct Node (
    int m_ParentId,
    int m_AxesId) : IUnityStructure
{
    public static Node Read(EndianBinaryReader reader)
    {
        int m_ParentId_ = reader.ReadS32();
        int m_AxesId_ = reader.ReadS32();
        
        return new(m_ParentId_,
            m_AxesId_);
    }

    public override string ToString() => $"Node\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ParentId: {m_ParentId}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_AxesId: {m_AxesId}");
    }
}

/* $Axes (6 fields) */
public record class Axes (
    float4 m_PreQ,
    float4 m_PostQ,
    float3 m_Sgn,
    Limit m_Limit,
    float m_Length,
    uint m_Type) : IUnityStructure
{
    public static Axes Read(EndianBinaryReader reader)
    {
        float4 m_PreQ_ = float4.Read(reader);
        float4 m_PostQ_ = float4.Read(reader);
        float3 m_Sgn_ = float3.Read(reader);
        Limit m_Limit_ = Limit.Read(reader);
        float m_Length_ = reader.ReadF32();
        uint m_Type_ = reader.ReadU32();
        
        return new(m_PreQ_,
            m_PostQ_,
            m_Sgn_,
            m_Limit_,
            m_Length_,
            m_Type_);
    }

    public override string ToString() => $"Axes\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_PreQ: {{ x: {m_PreQ.x}, y: {m_PreQ.y}, z: {m_PreQ.z}, w: {m_PreQ.w} }}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_PostQ: {{ x: {m_PostQ.x}, y: {m_PostQ.y}, z: {m_PostQ.z}, w: {m_PostQ.w} }}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Sgn: {{ x: {m_Sgn.x}, y: {m_Sgn.y}, z: {m_Sgn.z} }}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Limit: {{ \n{m_Limit.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Length: {m_Length}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Type: {m_Type}");
    }
}

/* $float4 (4 fields) */
public readonly record struct float4 (
    float x,
    float y,
    float z,
    float w) : IUnityStructure
{
    public static float4 Read(EndianBinaryReader reader)
    {
        float x_ = reader.ReadF32();
        float y_ = reader.ReadF32();
        float z_ = reader.ReadF32();
        float w_ = reader.ReadF32();
        
        return new(x_,
            y_,
            z_,
            w_);
    }

    public override string ToString() => $"float4\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}x: {x}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}y: {y}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}z: {z}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}w: {w}");
    }
}

/* $float3 (3 fields) */
public readonly record struct float3 (
    float x,
    float y,
    float z) : IUnityStructure
{
    public static float3 Read(EndianBinaryReader reader)
    {
        float x_ = reader.ReadF32();
        float y_ = reader.ReadF32();
        float z_ = reader.ReadF32();
        
        return new(x_,
            y_,
            z_);
    }

    public override string ToString() => $"float3\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}x: {x}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}y: {y}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}z: {z}");
    }
}

/* $Limit (2 fields) */
public record class Limit (
    float3 m_Min,
    float3 m_Max) : IUnityStructure
{
    public static Limit Read(EndianBinaryReader reader)
    {
        float3 m_Min_ = float3.Read(reader);
        float3 m_Max_ = float3.Read(reader);
        
        return new(m_Min_,
            m_Max_);
    }

    public override string ToString() => $"Limit\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Min: {{ x: {m_Min.x}, y: {m_Min.y}, z: {m_Min.z} }}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Max: {{ x: {m_Max.x}, y: {m_Max.y}, z: {m_Max.z} }}\n");
    }
}

/* $OffsetPtr_1 (1 fields) */
public record class OffsetPtr_1 (
    SkeletonPose data) : IUnityStructure
{
    public static OffsetPtr_1 Read(EndianBinaryReader reader)
    {
        SkeletonPose data_ = SkeletonPose.Read(reader);
        
        return new(data_);
    }

    public override string ToString() => $"OffsetPtr_1\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}data: {{ \n{data.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $SkeletonPose (1 fields) */
public record class SkeletonPose (
    xform[] m_X) : IUnityStructure
{
    public static SkeletonPose Read(EndianBinaryReader reader)
    {
        xform[] m_X_ = BuiltInArray<xform>.Read(reader);
        
        return new(m_X_);
    }

    public override string ToString() => $"SkeletonPose\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_X[{m_X.Length}] = {{");
        if (m_X.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (xform _4 in m_X)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_X.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $xform (3 fields) */
public record class xform (
    float3 t,
    float4 q,
    float3 s) : IUnityStructure
{
    public static xform Read(EndianBinaryReader reader)
    {
        float3 t_ = float3.Read(reader);
        float4 q_ = float4.Read(reader);
        float3 s_ = float3.Read(reader);
        
        return new(t_,
            q_,
            s_);
    }

    public override string ToString() => $"xform\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}t: {{ x: {t.x}, y: {t.y}, z: {t.z} }}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}q: {{ x: {q.x}, y: {q.y}, z: {q.z}, w: {q.w} }}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}s: {{ x: {s.x}, y: {s.y}, z: {s.z} }}\n");
    }
}

/* $OffsetPtr_2 (1 fields) */
public record class OffsetPtr_2 (
    Human data) : IUnityStructure
{
    public static OffsetPtr_2 Read(EndianBinaryReader reader)
    {
        Human data_ = Human.Read(reader);
        reader.AlignTo(4); /* data */
        
        return new(data_);
    }

    public override string ToString() => $"OffsetPtr_2\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}data: {{ \n{data.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $Human (18 fields) */
public record class Human (
    xform m_RootX,
    OffsetPtr m_Skeleton,
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
        xform m_RootX_ = xform.Read(reader);
        OffsetPtr m_Skeleton_ = OffsetPtr.Read(reader);
        OffsetPtr_1 m_SkeletonPose_ = OffsetPtr_1.Read(reader);
        OffsetPtr_3 m_LeftHand_ = OffsetPtr_3.Read(reader);
        OffsetPtr_3 m_RightHand_ = OffsetPtr_3.Read(reader);
        int[] m_HumanBoneIndex_ = BuiltInArray<int>.Read(reader);
        float[] m_HumanBoneMass_ = BuiltInArray<float>.Read(reader);
        float m_Scale_ = reader.ReadF32();
        float m_ArmTwist_ = reader.ReadF32();
        float m_ForeArmTwist_ = reader.ReadF32();
        float m_UpperLegTwist_ = reader.ReadF32();
        float m_LegTwist_ = reader.ReadF32();
        float m_ArmStretch_ = reader.ReadF32();
        float m_LegStretch_ = reader.ReadF32();
        float m_FeetSpacing_ = reader.ReadF32();
        bool m_HasLeftHand_ = reader.ReadBool();
        bool m_HasRightHand_ = reader.ReadBool();
        bool m_HasTDoF_ = reader.ReadBool();
        reader.AlignTo(4); /* m_HasTDoF */
        
        return new(m_RootX_,
            m_Skeleton_,
            m_SkeletonPose_,
            m_LeftHand_,
            m_RightHand_,
            m_HumanBoneIndex_,
            m_HumanBoneMass_,
            m_Scale_,
            m_ArmTwist_,
            m_ForeArmTwist_,
            m_UpperLegTwist_,
            m_LegTwist_,
            m_ArmStretch_,
            m_LegStretch_,
            m_FeetSpacing_,
            m_HasLeftHand_,
            m_HasRightHand_,
            m_HasTDoF_);
    }

    public override string ToString() => $"Human\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);
        ToString_Field15(sb, indent, indent_);
        ToString_Field16(sb, indent, indent_);
        ToString_Field17(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_RootX: {{ \n{m_RootX.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Skeleton: {{ \n{m_Skeleton.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_SkeletonPose: {{ \n{m_SkeletonPose.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_LeftHand: {{ \n{m_LeftHand.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_RightHand: {{ \n{m_RightHand.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_HumanBoneIndex[{m_HumanBoneIndex.Length}] = {{");
        if (m_HumanBoneIndex.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (int _4 in m_HumanBoneIndex)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_HumanBoneIndex.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_HumanBoneMass[{m_HumanBoneMass.Length}] = {{");
        if (m_HumanBoneMass.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (float _4 in m_HumanBoneMass)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_HumanBoneMass.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Scale: {m_Scale}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ArmTwist: {m_ArmTwist}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ForeArmTwist: {m_ForeArmTwist}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UpperLegTwist: {m_UpperLegTwist}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LegTwist: {m_LegTwist}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ArmStretch: {m_ArmStretch}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LegStretch: {m_LegStretch}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_FeetSpacing: {m_FeetSpacing}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_HasLeftHand: {m_HasLeftHand}");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_HasRightHand: {m_HasRightHand}");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_HasTDoF: {m_HasTDoF}");
    }
}

/* $OffsetPtr_3 (1 fields) */
public record class OffsetPtr_3 (
    Hand data) : IUnityStructure
{
    public static OffsetPtr_3 Read(EndianBinaryReader reader)
    {
        Hand data_ = Hand.Read(reader);
        
        return new(data_);
    }

    public override string ToString() => $"OffsetPtr_3\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}data: {{ \n{data.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $Hand (1 fields) */
public record class Hand (
    int[] m_HandBoneIndex) : IUnityStructure
{
    public static Hand Read(EndianBinaryReader reader)
    {
        int[] m_HandBoneIndex_ = BuiltInArray<int>.Read(reader);
        
        return new(m_HandBoneIndex_);
    }

    public override string ToString() => $"Hand\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_HandBoneIndex[{m_HandBoneIndex.Length}] = {{");
        if (m_HandBoneIndex.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (int _4 in m_HandBoneIndex)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_HandBoneIndex.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $HumanDescription (14 fields) */
public record class HumanDescription (
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
        HumanBone[] m_Human_ = BuiltInArray<HumanBone>.Read(reader);
        reader.AlignTo(4); /* m_Human */
        SkeletonBone[] m_Skeleton_ = BuiltInArray<SkeletonBone>.Read(reader);
        reader.AlignTo(4); /* m_Skeleton */
        float m_ArmTwist_ = reader.ReadF32();
        float m_ForeArmTwist_ = reader.ReadF32();
        float m_UpperLegTwist_ = reader.ReadF32();
        float m_LegTwist_ = reader.ReadF32();
        float m_ArmStretch_ = reader.ReadF32();
        float m_LegStretch_ = reader.ReadF32();
        float m_FeetSpacing_ = reader.ReadF32();
        float m_GlobalScale_ = reader.ReadF32();
        AsciiString m_RootMotionBoneName_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_RootMotionBoneName */
        bool m_HasTranslationDoF_ = reader.ReadBool();
        bool m_HasExtraRoot_ = reader.ReadBool();
        bool m_SkeletonHasParents_ = reader.ReadBool();
        reader.AlignTo(4); /* m_SkeletonHasParents */
        
        return new(m_Human_,
            m_Skeleton_,
            m_ArmTwist_,
            m_ForeArmTwist_,
            m_UpperLegTwist_,
            m_LegTwist_,
            m_ArmStretch_,
            m_LegStretch_,
            m_FeetSpacing_,
            m_GlobalScale_,
            m_RootMotionBoneName_,
            m_HasTranslationDoF_,
            m_HasExtraRoot_,
            m_SkeletonHasParents_);
    }

    public override string ToString() => $"HumanDescription\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Human[{m_Human.Length}] = {{");
        if (m_Human.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (HumanBone _4 in m_Human)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Human.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Skeleton[{m_Skeleton.Length}] = {{");
        if (m_Skeleton.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (SkeletonBone _4 in m_Skeleton)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Skeleton.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ArmTwist: {m_ArmTwist}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ForeArmTwist: {m_ForeArmTwist}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UpperLegTwist: {m_UpperLegTwist}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LegTwist: {m_LegTwist}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ArmStretch: {m_ArmStretch}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LegStretch: {m_LegStretch}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_FeetSpacing: {m_FeetSpacing}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_GlobalScale: {m_GlobalScale}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RootMotionBoneName: \"{m_RootMotionBoneName}\"");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_HasTranslationDoF: {m_HasTranslationDoF}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_HasExtraRoot: {m_HasExtraRoot}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SkeletonHasParents: {m_SkeletonHasParents}");
    }
}

/* $HumanBone (3 fields) */
public record class HumanBone (
    AsciiString m_BoneName,
    AsciiString m_HumanName,
    SkeletonBoneLimit m_Limit) : IUnityStructure
{
    public static HumanBone Read(EndianBinaryReader reader)
    {
        AsciiString m_BoneName_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_BoneName */
        AsciiString m_HumanName_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HumanName */
        SkeletonBoneLimit m_Limit_ = SkeletonBoneLimit.Read(reader);
        reader.AlignTo(4); /* m_Limit */
        
        return new(m_BoneName_,
            m_HumanName_,
            m_Limit_);
    }

    public override string ToString() => $"HumanBone\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BoneName: \"{m_BoneName}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_HumanName: \"{m_HumanName}\"");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Limit: {{ \n{m_Limit.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $SkeletonBoneLimit (5 fields) */
public record class SkeletonBoneLimit (
    Vector3f m_Min,
    Vector3f m_Max,
    Vector3f m_Value,
    float m_Length,
    bool m_Modified) : IUnityStructure
{
    public static SkeletonBoneLimit Read(EndianBinaryReader reader)
    {
        Vector3f m_Min_ = Vector3f.Read(reader);
        Vector3f m_Max_ = Vector3f.Read(reader);
        Vector3f m_Value_ = Vector3f.Read(reader);
        float m_Length_ = reader.ReadF32();
        bool m_Modified_ = reader.ReadBool();
        reader.AlignTo(4); /* m_Modified */
        
        return new(m_Min_,
            m_Max_,
            m_Value_,
            m_Length_,
            m_Modified_);
    }

    public override string ToString() => $"SkeletonBoneLimit\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Min: {{ x: {m_Min.x}, y: {m_Min.y}, z: {m_Min.z} }}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Max: {{ x: {m_Max.x}, y: {m_Max.y}, z: {m_Max.z} }}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Value: {{ x: {m_Value.x}, y: {m_Value.y}, z: {m_Value.z} }}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Length: {m_Length}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Modified: {m_Modified}");
    }
}

/* $SkeletonBone (5 fields) */
public record class SkeletonBone (
    AsciiString m_Name,
    AsciiString m_ParentName,
    Vector3f m_Position,
    Quaternionf m_Rotation,
    Vector3f m_Scale) : IUnityStructure
{
    public static SkeletonBone Read(EndianBinaryReader reader)
    {
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        AsciiString m_ParentName_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ParentName */
        Vector3f m_Position_ = Vector3f.Read(reader);
        Quaternionf m_Rotation_ = Quaternionf.Read(reader);
        Vector3f m_Scale_ = Vector3f.Read(reader);
        
        return new(m_Name_,
            m_ParentName_,
            m_Position_,
            m_Rotation_,
            m_Scale_);
    }

    public override string ToString() => $"SkeletonBone\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ParentName: \"{m_ParentName}\"");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Position: {{ x: {m_Position.x}, y: {m_Position.y}, z: {m_Position.z} }}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Rotation: {{ x: {m_Rotation.x}, y: {m_Rotation.y}, z: {m_Rotation.z}, w: {m_Rotation.w} }}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Scale: {{ x: {m_Scale.x}, y: {m_Scale.y}, z: {m_Scale.z} }}\n");
    }
}

/* $BuiltinShaderSettings (2 fields) */
public record class BuiltinShaderSettings (
    int m_Mode,
    PPtr<Shader> m_Shader) : IUnityStructure
{
    public static BuiltinShaderSettings Read(EndianBinaryReader reader)
    {
        int m_Mode_ = reader.ReadS32();
        PPtr<Shader> m_Shader_ = PPtr<Shader>.Read(reader);
        
        return new(m_Mode_,
            m_Shader_);
    }

    public override string ToString() => $"BuiltinShaderSettings\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Mode: {m_Mode}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Shader: {m_Shader}");
    }
}

/* $TierGraphicsSettings (7 fields) */
public readonly record struct TierGraphicsSettings (
    int renderingPath,
    int hdrMode,
    int realtimeGICPUUsage,
    bool useCascadedShadowMaps,
    bool prefer32BitShadowMaps,
    bool enableLPPV,
    bool useHDR) : IUnityStructure
{
    public static TierGraphicsSettings Read(EndianBinaryReader reader)
    {
        int renderingPath_ = reader.ReadS32();
        int hdrMode_ = reader.ReadS32();
        int realtimeGICPUUsage_ = reader.ReadS32();
        bool useCascadedShadowMaps_ = reader.ReadBool();
        bool prefer32BitShadowMaps_ = reader.ReadBool();
        bool enableLPPV_ = reader.ReadBool();
        bool useHDR_ = reader.ReadBool();
        reader.AlignTo(4); /* useHDR */
        
        return new(renderingPath_,
            hdrMode_,
            realtimeGICPUUsage_,
            useCascadedShadowMaps_,
            prefer32BitShadowMaps_,
            enableLPPV_,
            useHDR_);
    }

    public override string ToString() => $"TierGraphicsSettings\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}renderingPath: {renderingPath}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}hdrMode: {hdrMode}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}realtimeGICPUUsage: {realtimeGICPUUsage}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}useCascadedShadowMaps: {useCascadedShadowMaps}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}prefer32BitShadowMaps: {prefer32BitShadowMaps}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enableLPPV: {enableLPPV}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}useHDR: {useHDR}");
    }
}

/* $PlatformShaderDefines (4 fields) */
public record class PlatformShaderDefines (
    int shaderPlatform,
    uint[] defines_Tier1,
    uint[] defines_Tier2,
    uint[] defines_Tier3) : IUnityStructure
{
    public static PlatformShaderDefines Read(EndianBinaryReader reader)
    {
        int shaderPlatform_ = reader.ReadS32();
        uint[] defines_Tier1_ = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* defines_Tier1 */
        uint[] defines_Tier2_ = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* defines_Tier2 */
        uint[] defines_Tier3_ = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* defines_Tier3 */
        
        return new(shaderPlatform_,
            defines_Tier1_,
            defines_Tier2_,
            defines_Tier3_);
    }

    public override string ToString() => $"PlatformShaderDefines\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}shaderPlatform: {shaderPlatform}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}defines_Tier1[{defines_Tier1.Length}] = {{");
        if (defines_Tier1.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint _4 in defines_Tier1)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (defines_Tier1.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}defines_Tier2[{defines_Tier2.Length}] = {{");
        if (defines_Tier2.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint _4 in defines_Tier2)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (defines_Tier2.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}defines_Tier3[{defines_Tier3.Length}] = {{");
        if (defines_Tier3.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint _4 in defines_Tier3)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (defines_Tier3.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $SoftJointLimitSpring (2 fields) */
public readonly record struct SoftJointLimitSpring (
    float spring,
    float damper) : IUnityStructure
{
    public static SoftJointLimitSpring Read(EndianBinaryReader reader)
    {
        float spring_ = reader.ReadF32();
        float damper_ = reader.ReadF32();
        
        return new(spring_,
            damper_);
    }

    public override string ToString() => $"SoftJointLimitSpring\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}spring: {spring}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}damper: {damper}");
    }
}

/* $SoftJointLimit (3 fields) */
public readonly record struct SoftJointLimit (
    float limit,
    float bounciness,
    float contactDistance) : IUnityStructure
{
    public static SoftJointLimit Read(EndianBinaryReader reader)
    {
        float limit_ = reader.ReadF32();
        float bounciness_ = reader.ReadF32();
        float contactDistance_ = reader.ReadF32();
        
        return new(limit_,
            bounciness_,
            contactDistance_);
    }

    public override string ToString() => $"SoftJointLimit\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}limit: {limit}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}bounciness: {bounciness}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}contactDistance: {contactDistance}");
    }
}

/* $ControllerConstant (4 fields) */
public record class ControllerConstant (
    OffsetPtr_4[] m_LayerArray,
    OffsetPtr_6[] m_StateMachineArray,
    OffsetPtr_17 m_Values,
    OffsetPtr_18 m_DefaultValues) : IUnityStructure
{
    public static ControllerConstant Read(EndianBinaryReader reader)
    {
        OffsetPtr_4[] m_LayerArray_ = BuiltInArray<OffsetPtr_4>.Read(reader);
        reader.AlignTo(4); /* m_LayerArray */
        OffsetPtr_6[] m_StateMachineArray_ = BuiltInArray<OffsetPtr_6>.Read(reader);
        reader.AlignTo(4); /* m_StateMachineArray */
        OffsetPtr_17 m_Values_ = OffsetPtr_17.Read(reader);
        OffsetPtr_18 m_DefaultValues_ = OffsetPtr_18.Read(reader);
        reader.AlignTo(4); /* m_DefaultValues */
        
        return new(m_LayerArray_,
            m_StateMachineArray_,
            m_Values_,
            m_DefaultValues_);
    }

    public override string ToString() => $"ControllerConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_LayerArray[{m_LayerArray.Length}] = {{");
        if (m_LayerArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (OffsetPtr_4 _4 in m_LayerArray)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_LayerArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_StateMachineArray[{m_StateMachineArray.Length}] = {{");
        if (m_StateMachineArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (OffsetPtr_6 _4 in m_StateMachineArray)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_StateMachineArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Values: {{ \n{m_Values.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_DefaultValues: {{ \n{m_DefaultValues.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $OffsetPtr_4 (1 fields) */
public record class OffsetPtr_4 (
    LayerConstant data) : IUnityStructure
{
    public static OffsetPtr_4 Read(EndianBinaryReader reader)
    {
        LayerConstant data_ = LayerConstant.Read(reader);
        reader.AlignTo(4); /* data */
        
        return new(data_);
    }

    public override string ToString() => $"OffsetPtr_4\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}data: {{ \n{data.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $LayerConstant (9 fields) */
public record class LayerConstant (
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
        uint m_StateMachineIndex_ = reader.ReadU32();
        uint m_StateMachineSynchronizedLayerIndex_ = reader.ReadU32();
        HumanPoseMask m_BodyMask_ = HumanPoseMask.Read(reader);
        OffsetPtr_5 m_SkeletonMask_ = OffsetPtr_5.Read(reader);
        uint m_Binding_ = reader.ReadU32();
        int _intRef_m_LayerBlendingMode_ = reader.ReadS32();
        float m_DefaultWeight_ = reader.ReadF32();
        bool m_IKPass_ = reader.ReadBool();
        bool m_SyncedLayerAffectsTiming_ = reader.ReadBool();
        reader.AlignTo(4); /* m_SyncedLayerAffectsTiming */
        
        return new(m_StateMachineIndex_,
            m_StateMachineSynchronizedLayerIndex_,
            m_BodyMask_,
            m_SkeletonMask_,
            m_Binding_,
            _intRef_m_LayerBlendingMode_,
            m_DefaultWeight_,
            m_IKPass_,
            m_SyncedLayerAffectsTiming_);
    }

    public override string ToString() => $"LayerConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_StateMachineIndex: {m_StateMachineIndex}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_StateMachineSynchronizedLayerIndex: {m_StateMachineSynchronizedLayerIndex}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_BodyMask: {{ word0: {m_BodyMask.word0}, word1: {m_BodyMask.word1}, word2: {m_BodyMask.word2} }}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_SkeletonMask: {{ \n{m_SkeletonMask.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Binding: {m_Binding}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}_intRef_m_LayerBlendingMode: {_intRef_m_LayerBlendingMode}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DefaultWeight: {m_DefaultWeight}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_IKPass: {m_IKPass}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SyncedLayerAffectsTiming: {m_SyncedLayerAffectsTiming}");
    }
}

/* $HumanPoseMask (3 fields) */
public readonly record struct HumanPoseMask (
    uint word0,
    uint word1,
    uint word2) : IUnityStructure
{
    public static HumanPoseMask Read(EndianBinaryReader reader)
    {
        uint word0_ = reader.ReadU32();
        uint word1_ = reader.ReadU32();
        uint word2_ = reader.ReadU32();
        
        return new(word0_,
            word1_,
            word2_);
    }

    public override string ToString() => $"HumanPoseMask\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}word0: {word0}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}word1: {word1}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}word2: {word2}");
    }
}

/* $OffsetPtr_5 (1 fields) */
public record class OffsetPtr_5 (
    SkeletonMask data) : IUnityStructure
{
    public static OffsetPtr_5 Read(EndianBinaryReader reader)
    {
        SkeletonMask data_ = SkeletonMask.Read(reader);
        
        return new(data_);
    }

    public override string ToString() => $"OffsetPtr_5\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}data: {{ \n{data.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $SkeletonMask (1 fields) */
public record class SkeletonMask (
    SkeletonMaskElement[] m_Data) : IUnityStructure
{
    public static SkeletonMask Read(EndianBinaryReader reader)
    {
        SkeletonMaskElement[] m_Data_ = BuiltInArray<SkeletonMaskElement>.Read(reader);
        
        return new(m_Data_);
    }

    public override string ToString() => $"SkeletonMask\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Data[{m_Data.Length}] = {{");
        if (m_Data.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (SkeletonMaskElement _4 in m_Data)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ m_PathHash: {_4.m_PathHash}, m_Weight: {_4.m_Weight} }}\n");
            ++_4i;
        }
        if (m_Data.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $SkeletonMaskElement (2 fields) */
public readonly record struct SkeletonMaskElement (
    uint m_PathHash,
    float m_Weight) : IUnityStructure
{
    public static SkeletonMaskElement Read(EndianBinaryReader reader)
    {
        uint m_PathHash_ = reader.ReadU32();
        float m_Weight_ = reader.ReadF32();
        
        return new(m_PathHash_,
            m_Weight_);
    }

    public override string ToString() => $"SkeletonMaskElement\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PathHash: {m_PathHash}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Weight: {m_Weight}");
    }
}

/* $OffsetPtr_6 (1 fields) */
public record class OffsetPtr_6 (
    StateMachineConstant data) : IUnityStructure
{
    public static OffsetPtr_6 Read(EndianBinaryReader reader)
    {
        StateMachineConstant data_ = StateMachineConstant.Read(reader);
        reader.AlignTo(4); /* data */
        
        return new(data_);
    }

    public override string ToString() => $"OffsetPtr_6\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}data: {{ \n{data.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $StateMachineConstant (5 fields) */
public record class StateMachineConstant (
    OffsetPtr_7[] m_StateConstantArray,
    OffsetPtr_8[] m_AnyStateTransitionConstantArray,
    OffsetPtr_15[] m_SelectorStateConstantArray,
    uint m_DefaultState,
    uint m_SynchronizedLayerCount) : IUnityStructure
{
    public static StateMachineConstant Read(EndianBinaryReader reader)
    {
        OffsetPtr_7[] m_StateConstantArray_ = BuiltInArray<OffsetPtr_7>.Read(reader);
        reader.AlignTo(4); /* m_StateConstantArray */
        OffsetPtr_8[] m_AnyStateTransitionConstantArray_ = BuiltInArray<OffsetPtr_8>.Read(reader);
        reader.AlignTo(4); /* m_AnyStateTransitionConstantArray */
        OffsetPtr_15[] m_SelectorStateConstantArray_ = BuiltInArray<OffsetPtr_15>.Read(reader);
        reader.AlignTo(4); /* m_SelectorStateConstantArray */
        uint m_DefaultState_ = reader.ReadU32();
        uint m_SynchronizedLayerCount_ = reader.ReadU32();
        
        return new(m_StateConstantArray_,
            m_AnyStateTransitionConstantArray_,
            m_SelectorStateConstantArray_,
            m_DefaultState_,
            m_SynchronizedLayerCount_);
    }

    public override string ToString() => $"StateMachineConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_StateConstantArray[{m_StateConstantArray.Length}] = {{");
        if (m_StateConstantArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (OffsetPtr_7 _4 in m_StateConstantArray)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_StateConstantArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_AnyStateTransitionConstantArray[{m_AnyStateTransitionConstantArray.Length}] = {{");
        if (m_AnyStateTransitionConstantArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (OffsetPtr_8 _4 in m_AnyStateTransitionConstantArray)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_AnyStateTransitionConstantArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_SelectorStateConstantArray[{m_SelectorStateConstantArray.Length}] = {{");
        if (m_SelectorStateConstantArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (OffsetPtr_15 _4 in m_SelectorStateConstantArray)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_SelectorStateConstantArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DefaultState: {m_DefaultState}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SynchronizedLayerCount: {m_SynchronizedLayerCount}");
    }
}

/* $OffsetPtr_7 (1 fields) */
public record class OffsetPtr_7 (
    StateConstant data) : IUnityStructure
{
    public static OffsetPtr_7 Read(EndianBinaryReader reader)
    {
        StateConstant data_ = StateConstant.Read(reader);
        reader.AlignTo(4); /* data */
        
        return new(data_);
    }

    public override string ToString() => $"OffsetPtr_7\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}data: {{ \n{data.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $StateConstant (17 fields) */
public record class StateConstant (
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
        OffsetPtr_8[] m_TransitionConstantArray_ = BuiltInArray<OffsetPtr_8>.Read(reader);
        reader.AlignTo(4); /* m_TransitionConstantArray */
        int[] m_BlendTreeConstantIndexArray_ = BuiltInArray<int>.Read(reader);
        OffsetPtr_10[] m_BlendTreeConstantArray_ = BuiltInArray<OffsetPtr_10>.Read(reader);
        reader.AlignTo(4); /* m_BlendTreeConstantArray */
        uint m_NameID_ = reader.ReadU32();
        uint m_PathID_ = reader.ReadU32();
        uint m_FullPathID_ = reader.ReadU32();
        uint m_TagID_ = reader.ReadU32();
        uint m_SpeedParamID_ = reader.ReadU32();
        uint m_MirrorParamID_ = reader.ReadU32();
        uint m_CycleOffsetParamID_ = reader.ReadU32();
        uint m_TimeParamID_ = reader.ReadU32();
        float m_Speed_ = reader.ReadF32();
        float m_CycleOffset_ = reader.ReadF32();
        bool m_IKOnFeet_ = reader.ReadBool();
        bool m_WriteDefaultValues_ = reader.ReadBool();
        bool m_Loop_ = reader.ReadBool();
        bool m_Mirror_ = reader.ReadBool();
        reader.AlignTo(4); /* m_Mirror */
        
        return new(m_TransitionConstantArray_,
            m_BlendTreeConstantIndexArray_,
            m_BlendTreeConstantArray_,
            m_NameID_,
            m_PathID_,
            m_FullPathID_,
            m_TagID_,
            m_SpeedParamID_,
            m_MirrorParamID_,
            m_CycleOffsetParamID_,
            m_TimeParamID_,
            m_Speed_,
            m_CycleOffset_,
            m_IKOnFeet_,
            m_WriteDefaultValues_,
            m_Loop_,
            m_Mirror_);
    }

    public override string ToString() => $"StateConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);
        ToString_Field15(sb, indent, indent_);
        ToString_Field16(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_TransitionConstantArray[{m_TransitionConstantArray.Length}] = {{");
        if (m_TransitionConstantArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (OffsetPtr_8 _4 in m_TransitionConstantArray)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_TransitionConstantArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_BlendTreeConstantIndexArray[{m_BlendTreeConstantIndexArray.Length}] = {{");
        if (m_BlendTreeConstantIndexArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (int _4 in m_BlendTreeConstantIndexArray)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_BlendTreeConstantIndexArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_BlendTreeConstantArray[{m_BlendTreeConstantArray.Length}] = {{");
        if (m_BlendTreeConstantArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (OffsetPtr_10 _4 in m_BlendTreeConstantArray)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_BlendTreeConstantArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_NameID: {m_NameID}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PathID: {m_PathID}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_FullPathID: {m_FullPathID}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TagID: {m_TagID}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SpeedParamID: {m_SpeedParamID}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MirrorParamID: {m_MirrorParamID}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CycleOffsetParamID: {m_CycleOffsetParamID}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TimeParamID: {m_TimeParamID}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Speed: {m_Speed}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CycleOffset: {m_CycleOffset}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_IKOnFeet: {m_IKOnFeet}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_WriteDefaultValues: {m_WriteDefaultValues}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Loop: {m_Loop}");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Mirror: {m_Mirror}");
    }
}

/* $OffsetPtr_8 (1 fields) */
public record class OffsetPtr_8 (
    TransitionConstant data) : IUnityStructure
{
    public static OffsetPtr_8 Read(EndianBinaryReader reader)
    {
        TransitionConstant data_ = TransitionConstant.Read(reader);
        reader.AlignTo(4); /* data */
        
        return new(data_);
    }

    public override string ToString() => $"OffsetPtr_8\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}data: {{ \n{data.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $TransitionConstant (13 fields) */
public record class TransitionConstant (
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
        OffsetPtr_9[] m_ConditionConstantArray_ = BuiltInArray<OffsetPtr_9>.Read(reader);
        uint m_DestinationState_ = reader.ReadU32();
        uint m_FullPathID_ = reader.ReadU32();
        uint m_ID_ = reader.ReadU32();
        uint m_UserID_ = reader.ReadU32();
        float m_TransitionDuration_ = reader.ReadF32();
        float m_TransitionOffset_ = reader.ReadF32();
        float m_ExitTime_ = reader.ReadF32();
        bool m_HasExitTime_ = reader.ReadBool();
        bool m_HasFixedDuration_ = reader.ReadBool();
        reader.AlignTo(4); /* m_HasFixedDuration */
        int m_InterruptionSource_ = reader.ReadS32();
        bool m_OrderedInterruption_ = reader.ReadBool();
        bool m_CanTransitionToSelf_ = reader.ReadBool();
        reader.AlignTo(4); /* m_CanTransitionToSelf */
        
        return new(m_ConditionConstantArray_,
            m_DestinationState_,
            m_FullPathID_,
            m_ID_,
            m_UserID_,
            m_TransitionDuration_,
            m_TransitionOffset_,
            m_ExitTime_,
            m_HasExitTime_,
            m_HasFixedDuration_,
            m_InterruptionSource_,
            m_OrderedInterruption_,
            m_CanTransitionToSelf_);
    }

    public override string ToString() => $"TransitionConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ConditionConstantArray[{m_ConditionConstantArray.Length}] = {{");
        if (m_ConditionConstantArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (OffsetPtr_9 _4 in m_ConditionConstantArray)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_ConditionConstantArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DestinationState: {m_DestinationState}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_FullPathID: {m_FullPathID}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ID: {m_ID}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UserID: {m_UserID}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TransitionDuration: {m_TransitionDuration}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TransitionOffset: {m_TransitionOffset}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ExitTime: {m_ExitTime}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_HasExitTime: {m_HasExitTime}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_HasFixedDuration: {m_HasFixedDuration}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_InterruptionSource: {m_InterruptionSource}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_OrderedInterruption: {m_OrderedInterruption}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CanTransitionToSelf: {m_CanTransitionToSelf}");
    }
}

/* $OffsetPtr_9 (1 fields) */
public record class OffsetPtr_9 (
    ConditionConstant data) : IUnityStructure
{
    public static OffsetPtr_9 Read(EndianBinaryReader reader)
    {
        ConditionConstant data_ = ConditionConstant.Read(reader);
        
        return new(data_);
    }

    public override string ToString() => $"OffsetPtr_9\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}data: {{ m_ConditionMode: {data.m_ConditionMode}, m_EventID: {data.m_EventID}, m_EventThreshold: {data.m_EventThreshold}, m_ExitTime: {data.m_ExitTime} }}\n");
    }
}

/* $ConditionConstant (4 fields) */
public readonly record struct ConditionConstant (
    uint m_ConditionMode,
    uint m_EventID,
    float m_EventThreshold,
    float m_ExitTime) : IUnityStructure
{
    public static ConditionConstant Read(EndianBinaryReader reader)
    {
        uint m_ConditionMode_ = reader.ReadU32();
        uint m_EventID_ = reader.ReadU32();
        float m_EventThreshold_ = reader.ReadF32();
        float m_ExitTime_ = reader.ReadF32();
        
        return new(m_ConditionMode_,
            m_EventID_,
            m_EventThreshold_,
            m_ExitTime_);
    }

    public override string ToString() => $"ConditionConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ConditionMode: {m_ConditionMode}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_EventID: {m_EventID}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_EventThreshold: {m_EventThreshold}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ExitTime: {m_ExitTime}");
    }
}

/* $OffsetPtr_10 (1 fields) */
public record class OffsetPtr_10 (
    BlendTreeConstant data) : IUnityStructure
{
    public static OffsetPtr_10 Read(EndianBinaryReader reader)
    {
        BlendTreeConstant data_ = BlendTreeConstant.Read(reader);
        reader.AlignTo(4); /* data */
        
        return new(data_);
    }

    public override string ToString() => $"OffsetPtr_10\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}data: {{ \n{data.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $BlendTreeConstant (1 fields) */
public record class BlendTreeConstant (
    OffsetPtr_11[] m_NodeArray) : IUnityStructure
{
    public static BlendTreeConstant Read(EndianBinaryReader reader)
    {
        OffsetPtr_11[] m_NodeArray_ = BuiltInArray<OffsetPtr_11>.Read(reader);
        reader.AlignTo(4); /* m_NodeArray */
        
        return new(m_NodeArray_);
    }

    public override string ToString() => $"BlendTreeConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_NodeArray[{m_NodeArray.Length}] = {{");
        if (m_NodeArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (OffsetPtr_11 _4 in m_NodeArray)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_NodeArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $OffsetPtr_11 (1 fields) */
public record class OffsetPtr_11 (
    BlendTreeNodeConstant data) : IUnityStructure
{
    public static OffsetPtr_11 Read(EndianBinaryReader reader)
    {
        BlendTreeNodeConstant data_ = BlendTreeNodeConstant.Read(reader);
        reader.AlignTo(4); /* data */
        
        return new(data_);
    }

    public override string ToString() => $"OffsetPtr_11\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}data: {{ \n{data.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $BlendTreeNodeConstant (11 fields) */
public record class BlendTreeNodeConstant (
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
        uint m_BlendType_ = reader.ReadU32();
        uint m_BlendEventID_ = reader.ReadU32();
        uint m_BlendEventYID_ = reader.ReadU32();
        uint[] m_ChildIndices_ = BuiltInArray<uint>.Read(reader);
        OffsetPtr_12 m_Blend1dData_ = OffsetPtr_12.Read(reader);
        OffsetPtr_13 m_Blend2dData_ = OffsetPtr_13.Read(reader);
        OffsetPtr_14 m_BlendDirectData_ = OffsetPtr_14.Read(reader);
        reader.AlignTo(4); /* m_BlendDirectData */
        uint m_ClipID_ = reader.ReadU32();
        float m_Duration_ = reader.ReadF32();
        float m_CycleOffset_ = reader.ReadF32();
        bool m_Mirror_ = reader.ReadBool();
        reader.AlignTo(4); /* m_Mirror */
        
        return new(m_BlendType_,
            m_BlendEventID_,
            m_BlendEventYID_,
            m_ChildIndices_,
            m_Blend1dData_,
            m_Blend2dData_,
            m_BlendDirectData_,
            m_ClipID_,
            m_Duration_,
            m_CycleOffset_,
            m_Mirror_);
    }

    public override string ToString() => $"BlendTreeNodeConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BlendType: {m_BlendType}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BlendEventID: {m_BlendEventID}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BlendEventYID: {m_BlendEventYID}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ChildIndices[{m_ChildIndices.Length}] = {{");
        if (m_ChildIndices.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint _4 in m_ChildIndices)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_ChildIndices.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Blend1dData: {{ \n{m_Blend1dData.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Blend2dData: {{ \n{m_Blend2dData.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_BlendDirectData: {{ \n{m_BlendDirectData.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ClipID: {m_ClipID}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Duration: {m_Duration}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CycleOffset: {m_CycleOffset}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Mirror: {m_Mirror}");
    }
}

/* $OffsetPtr_12 (1 fields) */
public record class OffsetPtr_12 (
    Blend1dDataConstant data) : IUnityStructure
{
    public static OffsetPtr_12 Read(EndianBinaryReader reader)
    {
        Blend1dDataConstant data_ = Blend1dDataConstant.Read(reader);
        
        return new(data_);
    }

    public override string ToString() => $"OffsetPtr_12\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}data: {{ \n{data.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $Blend1dDataConstant (1 fields) */
public record class Blend1dDataConstant (
    float[] m_ChildThresholdArray) : IUnityStructure
{
    public static Blend1dDataConstant Read(EndianBinaryReader reader)
    {
        float[] m_ChildThresholdArray_ = BuiltInArray<float>.Read(reader);
        
        return new(m_ChildThresholdArray_);
    }

    public override string ToString() => $"Blend1dDataConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ChildThresholdArray[{m_ChildThresholdArray.Length}] = {{");
        if (m_ChildThresholdArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (float _4 in m_ChildThresholdArray)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_ChildThresholdArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $OffsetPtr_13 (1 fields) */
public record class OffsetPtr_13 (
    Blend2dDataConstant data) : IUnityStructure
{
    public static OffsetPtr_13 Read(EndianBinaryReader reader)
    {
        Blend2dDataConstant data_ = Blend2dDataConstant.Read(reader);
        
        return new(data_);
    }

    public override string ToString() => $"OffsetPtr_13\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}data: {{ \n{data.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $Blend2dDataConstant (5 fields) */
public record class Blend2dDataConstant (
    Vector2f[] m_ChildPositionArray,
    float[] m_ChildMagnitudeArray,
    Vector2f[] m_ChildPairVectorArray,
    float[] m_ChildPairAvgMagInvArray,
    MotionNeighborList[] m_ChildNeighborListArray) : IUnityStructure
{
    public static Blend2dDataConstant Read(EndianBinaryReader reader)
    {
        Vector2f[] m_ChildPositionArray_ = BuiltInArray<Vector2f>.Read(reader);
        float[] m_ChildMagnitudeArray_ = BuiltInArray<float>.Read(reader);
        Vector2f[] m_ChildPairVectorArray_ = BuiltInArray<Vector2f>.Read(reader);
        float[] m_ChildPairAvgMagInvArray_ = BuiltInArray<float>.Read(reader);
        MotionNeighborList[] m_ChildNeighborListArray_ = BuiltInArray<MotionNeighborList>.Read(reader);
        
        return new(m_ChildPositionArray_,
            m_ChildMagnitudeArray_,
            m_ChildPairVectorArray_,
            m_ChildPairAvgMagInvArray_,
            m_ChildNeighborListArray_);
    }

    public override string ToString() => $"Blend2dDataConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ChildPositionArray[{m_ChildPositionArray.Length}] = {{");
        if (m_ChildPositionArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (Vector2f _4 in m_ChildPositionArray)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ x: {_4.x}, y: {_4.y} }}\n");
            ++_4i;
        }
        if (m_ChildPositionArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ChildMagnitudeArray[{m_ChildMagnitudeArray.Length}] = {{");
        if (m_ChildMagnitudeArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (float _4 in m_ChildMagnitudeArray)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_ChildMagnitudeArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ChildPairVectorArray[{m_ChildPairVectorArray.Length}] = {{");
        if (m_ChildPairVectorArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (Vector2f _4 in m_ChildPairVectorArray)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ x: {_4.x}, y: {_4.y} }}\n");
            ++_4i;
        }
        if (m_ChildPairVectorArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ChildPairAvgMagInvArray[{m_ChildPairAvgMagInvArray.Length}] = {{");
        if (m_ChildPairAvgMagInvArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (float _4 in m_ChildPairAvgMagInvArray)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_ChildPairAvgMagInvArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ChildNeighborListArray[{m_ChildNeighborListArray.Length}] = {{");
        if (m_ChildNeighborListArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (MotionNeighborList _4 in m_ChildNeighborListArray)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_ChildNeighborListArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $MotionNeighborList (1 fields) */
public record class MotionNeighborList (
    uint[] m_NeighborArray) : IUnityStructure
{
    public static MotionNeighborList Read(EndianBinaryReader reader)
    {
        uint[] m_NeighborArray_ = BuiltInArray<uint>.Read(reader);
        
        return new(m_NeighborArray_);
    }

    public override string ToString() => $"MotionNeighborList\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_NeighborArray[{m_NeighborArray.Length}] = {{");
        if (m_NeighborArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint _4 in m_NeighborArray)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_NeighborArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $OffsetPtr_14 (1 fields) */
public record class OffsetPtr_14 (
    BlendDirectDataConstant data) : IUnityStructure
{
    public static OffsetPtr_14 Read(EndianBinaryReader reader)
    {
        BlendDirectDataConstant data_ = BlendDirectDataConstant.Read(reader);
        reader.AlignTo(4); /* data */
        
        return new(data_);
    }

    public override string ToString() => $"OffsetPtr_14\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}data: {{ \n{data.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $BlendDirectDataConstant (2 fields) */
public record class BlendDirectDataConstant (
    uint[] m_ChildBlendEventIDArray,
    bool m_NormalizedBlendValues) : IUnityStructure
{
    public static BlendDirectDataConstant Read(EndianBinaryReader reader)
    {
        uint[] m_ChildBlendEventIDArray_ = BuiltInArray<uint>.Read(reader);
        bool m_NormalizedBlendValues_ = reader.ReadBool();
        reader.AlignTo(4); /* m_NormalizedBlendValues */
        
        return new(m_ChildBlendEventIDArray_,
            m_NormalizedBlendValues_);
    }

    public override string ToString() => $"BlendDirectDataConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ChildBlendEventIDArray[{m_ChildBlendEventIDArray.Length}] = {{");
        if (m_ChildBlendEventIDArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint _4 in m_ChildBlendEventIDArray)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_ChildBlendEventIDArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_NormalizedBlendValues: {m_NormalizedBlendValues}");
    }
}

/* $OffsetPtr_15 (1 fields) */
public record class OffsetPtr_15 (
    SelectorStateConstant data) : IUnityStructure
{
    public static OffsetPtr_15 Read(EndianBinaryReader reader)
    {
        SelectorStateConstant data_ = SelectorStateConstant.Read(reader);
        reader.AlignTo(4); /* data */
        
        return new(data_);
    }

    public override string ToString() => $"OffsetPtr_15\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}data: {{ \n{data.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $SelectorStateConstant (3 fields) */
public record class SelectorStateConstant (
    OffsetPtr_16[] m_TransitionConstantArray,
    uint m_FullPathID,
    bool m_IsEntry) : IUnityStructure
{
    public static SelectorStateConstant Read(EndianBinaryReader reader)
    {
        OffsetPtr_16[] m_TransitionConstantArray_ = BuiltInArray<OffsetPtr_16>.Read(reader);
        uint m_FullPathID_ = reader.ReadU32();
        bool m_IsEntry_ = reader.ReadBool();
        reader.AlignTo(4); /* m_IsEntry */
        
        return new(m_TransitionConstantArray_,
            m_FullPathID_,
            m_IsEntry_);
    }

    public override string ToString() => $"SelectorStateConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_TransitionConstantArray[{m_TransitionConstantArray.Length}] = {{");
        if (m_TransitionConstantArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (OffsetPtr_16 _4 in m_TransitionConstantArray)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_TransitionConstantArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_FullPathID: {m_FullPathID}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_IsEntry: {m_IsEntry}");
    }
}

/* $OffsetPtr_16 (1 fields) */
public record class OffsetPtr_16 (
    SelectorTransitionConstant data) : IUnityStructure
{
    public static OffsetPtr_16 Read(EndianBinaryReader reader)
    {
        SelectorTransitionConstant data_ = SelectorTransitionConstant.Read(reader);
        
        return new(data_);
    }

    public override string ToString() => $"OffsetPtr_16\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}data: {{ \n{data.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $SelectorTransitionConstant (2 fields) */
public record class SelectorTransitionConstant (
    uint m_Destination,
    OffsetPtr_9[] m_ConditionConstantArray) : IUnityStructure
{
    public static SelectorTransitionConstant Read(EndianBinaryReader reader)
    {
        uint m_Destination_ = reader.ReadU32();
        OffsetPtr_9[] m_ConditionConstantArray_ = BuiltInArray<OffsetPtr_9>.Read(reader);
        
        return new(m_Destination_,
            m_ConditionConstantArray_);
    }

    public override string ToString() => $"SelectorTransitionConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Destination: {m_Destination}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ConditionConstantArray[{m_ConditionConstantArray.Length}] = {{");
        if (m_ConditionConstantArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (OffsetPtr_9 _4 in m_ConditionConstantArray)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_ConditionConstantArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $OffsetPtr_17 (1 fields) */
public record class OffsetPtr_17 (
    ValueArrayConstant data) : IUnityStructure
{
    public static OffsetPtr_17 Read(EndianBinaryReader reader)
    {
        ValueArrayConstant data_ = ValueArrayConstant.Read(reader);
        
        return new(data_);
    }

    public override string ToString() => $"OffsetPtr_17\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}data: {{ \n{data.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $ValueArrayConstant (1 fields) */
public record class ValueArrayConstant (
    ValueConstant[] m_ValueArray) : IUnityStructure
{
    public static ValueArrayConstant Read(EndianBinaryReader reader)
    {
        ValueConstant[] m_ValueArray_ = BuiltInArray<ValueConstant>.Read(reader);
        
        return new(m_ValueArray_);
    }

    public override string ToString() => $"ValueArrayConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ValueArray[{m_ValueArray.Length}] = {{");
        if (m_ValueArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (ValueConstant _4 in m_ValueArray)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ m_ID: {_4.m_ID}, m_Type: {_4.m_Type}, m_Index: {_4.m_Index} }}\n");
            ++_4i;
        }
        if (m_ValueArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $ValueConstant (3 fields) */
public readonly record struct ValueConstant (
    uint m_ID,
    uint m_Type,
    uint m_Index) : IUnityStructure
{
    public static ValueConstant Read(EndianBinaryReader reader)
    {
        uint m_ID_ = reader.ReadU32();
        uint m_Type_ = reader.ReadU32();
        uint m_Index_ = reader.ReadU32();
        
        return new(m_ID_,
            m_Type_,
            m_Index_);
    }

    public override string ToString() => $"ValueConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ID: {m_ID}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Type: {m_Type}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Index: {m_Index}");
    }
}

/* $OffsetPtr_18 (1 fields) */
public record class OffsetPtr_18 (
    ValueArray data) : IUnityStructure
{
    public static OffsetPtr_18 Read(EndianBinaryReader reader)
    {
        ValueArray data_ = ValueArray.Read(reader);
        reader.AlignTo(4); /* data */
        
        return new(data_);
    }

    public override string ToString() => $"OffsetPtr_18\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}data: {{ \n{data.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $ValueArray (6 fields) */
public record class ValueArray (
    float3[] m_PositionValues,
    float4[] m_QuaternionValues,
    float3[] m_ScaleValues,
    float[] m_FloatValues,
    int[] m_IntValues,
    bool[] m_BoolValues) : IUnityStructure
{
    public static ValueArray Read(EndianBinaryReader reader)
    {
        float3[] m_PositionValues_ = BuiltInArray<float3>.Read(reader);
        float4[] m_QuaternionValues_ = BuiltInArray<float4>.Read(reader);
        float3[] m_ScaleValues_ = BuiltInArray<float3>.Read(reader);
        float[] m_FloatValues_ = BuiltInArray<float>.Read(reader);
        int[] m_IntValues_ = BuiltInArray<int>.Read(reader);
        bool[] m_BoolValues_ = BuiltInArray<bool>.Read(reader);
        reader.AlignTo(4); /* m_BoolValues */
        
        return new(m_PositionValues_,
            m_QuaternionValues_,
            m_ScaleValues_,
            m_FloatValues_,
            m_IntValues_,
            m_BoolValues_);
    }

    public override string ToString() => $"ValueArray\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_PositionValues[{m_PositionValues.Length}] = {{");
        if (m_PositionValues.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (float3 _4 in m_PositionValues)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ x: {_4.x}, y: {_4.y}, z: {_4.z} }}\n");
            ++_4i;
        }
        if (m_PositionValues.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_QuaternionValues[{m_QuaternionValues.Length}] = {{");
        if (m_QuaternionValues.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (float4 _4 in m_QuaternionValues)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ x: {_4.x}, y: {_4.y}, z: {_4.z}, w: {_4.w} }}\n");
            ++_4i;
        }
        if (m_QuaternionValues.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ScaleValues[{m_ScaleValues.Length}] = {{");
        if (m_ScaleValues.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (float3 _4 in m_ScaleValues)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ x: {_4.x}, y: {_4.y}, z: {_4.z} }}\n");
            ++_4i;
        }
        if (m_ScaleValues.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_FloatValues[{m_FloatValues.Length}] = {{");
        if (m_FloatValues.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (float _4 in m_FloatValues)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_FloatValues.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_IntValues[{m_IntValues.Length}] = {{");
        if (m_IntValues.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (int _4 in m_IntValues)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_IntValues.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_BoolValues[{m_BoolValues.Length}] = {{");
        if (m_BoolValues.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (bool _4 in m_BoolValues)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_BoolValues.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $StateMachineBehaviourVectorDescription (2 fields) */
public record class StateMachineBehaviourVectorDescription (
    Dictionary<StateKey, StateRange> m_StateMachineBehaviourRanges,
    uint[] m_StateMachineBehaviourIndices) : IUnityStructure
{
    public static StateMachineBehaviourVectorDescription Read(EndianBinaryReader reader)
    {
        Dictionary<StateKey, StateRange> m_StateMachineBehaviourRanges_ = BuiltInMap<StateKey, StateRange>.Read(reader);
        uint[] m_StateMachineBehaviourIndices_ = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* m_StateMachineBehaviourIndices */
        
        return new(m_StateMachineBehaviourRanges_,
            m_StateMachineBehaviourIndices_);
    }

    public override string ToString() => $"StateMachineBehaviourVectorDescription\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_StateMachineBehaviourRanges[{m_StateMachineBehaviourRanges.Count}] = {{");
        if (m_StateMachineBehaviourRanges.Count > 0) sb.AppendLine();
        int _4i = 0;
        foreach (KeyValuePair<StateKey, StateRange> _4 in m_StateMachineBehaviourRanges)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4.Key}] = {{ m_StartIndex: {_4.Value.m_StartIndex}, m_Count: {_4.Value.m_Count} }}\n");
            ++_4i;
        }
        if (m_StateMachineBehaviourRanges.Count > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_StateMachineBehaviourIndices[{m_StateMachineBehaviourIndices.Length}] = {{");
        if (m_StateMachineBehaviourIndices.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint _4 in m_StateMachineBehaviourIndices)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_StateMachineBehaviourIndices.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $StateKey (2 fields) */
public readonly record struct StateKey (
    uint m_StateID,
    int m_LayerIndex) : IUnityStructure
{
    public static StateKey Read(EndianBinaryReader reader)
    {
        uint m_StateID_ = reader.ReadU32();
        int m_LayerIndex_ = reader.ReadS32();
        
        return new(m_StateID_,
            m_LayerIndex_);
    }

    public override string ToString() => $"StateKey\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_StateID: {m_StateID}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LayerIndex: {m_LayerIndex}");
    }
}

/* $StateRange (2 fields) */
public readonly record struct StateRange (
    uint m_StartIndex,
    uint m_Count) : IUnityStructure
{
    public static StateRange Read(EndianBinaryReader reader)
    {
        uint m_StartIndex_ = reader.ReadU32();
        uint m_Count_ = reader.ReadU32();
        
        return new(m_StartIndex_,
            m_Count_);
    }

    public override string ToString() => $"StateRange\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_StartIndex: {m_StartIndex}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Count: {m_Count}");
    }
}

/* $TransformMaskElement (2 fields) */
public record class TransformMaskElement (
    AsciiString m_Path,
    float m_Weight) : IUnityStructure
{
    public static TransformMaskElement Read(EndianBinaryReader reader)
    {
        AsciiString m_Path_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Path */
        float m_Weight_ = reader.ReadF32();
        
        return new(m_Path_,
            m_Weight_);
    }

    public override string ToString() => $"TransformMaskElement\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Path: \"{m_Path}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Weight: {m_Weight}");
    }
}

/* $VisualEffectInfo (18 fields) */
public record class VisualEffectInfo (
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
        VFXRendererSettings m_RendererSettings_ = VFXRendererSettings.Read(reader);
        reader.AlignTo(4); /* m_RendererSettings */
        int m_CullingFlags_ = reader.ReadS32();
        int m_UpdateMode_ = reader.ReadS32();
        float m_PreWarmDeltaTime_ = reader.ReadF32();
        uint m_PreWarmStepCount_ = reader.ReadU32();
        AsciiString m_InitialEventName_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_InitialEventName */
        int m_InstancingMode_ = reader.ReadS32();
        uint m_InstancingCapacity_ = reader.ReadU32();
        VFXExpressionContainer m_Expressions_ = VFXExpressionContainer.Read(reader);
        reader.AlignTo(4); /* m_Expressions */
        VFXPropertySheetSerializedBase_1 m_PropertySheet_ = VFXPropertySheetSerializedBase_1.Read(reader);
        reader.AlignTo(4); /* m_PropertySheet */
        VFXMapping[] m_ExposedExpressions_ = BuiltInArray<VFXMapping>.Read(reader);
        reader.AlignTo(4); /* m_ExposedExpressions */
        VFXGPUBufferDesc[] m_Buffers_ = BuiltInArray<VFXGPUBufferDesc>.Read(reader);
        reader.AlignTo(4); /* m_Buffers */
        VFXTemporaryGPUBufferDesc[] m_TemporaryBuffers_ = BuiltInArray<VFXTemporaryGPUBufferDesc>.Read(reader);
        reader.AlignTo(4); /* m_TemporaryBuffers */
        VFXCPUBufferDesc[] m_CPUBuffers_ = BuiltInArray<VFXCPUBufferDesc>.Read(reader);
        reader.AlignTo(4); /* m_CPUBuffers */
        VFXEventDesc[] m_Events_ = BuiltInArray<VFXEventDesc>.Read(reader);
        reader.AlignTo(4); /* m_Events */
        int m_InstancingDisabledReason_ = reader.ReadS32();
        uint m_RuntimeVersion_ = reader.ReadU32();
        uint m_CompilationVersion_ = reader.ReadU32();
        
        return new(m_RendererSettings_,
            m_CullingFlags_,
            m_UpdateMode_,
            m_PreWarmDeltaTime_,
            m_PreWarmStepCount_,
            m_InitialEventName_,
            m_InstancingMode_,
            m_InstancingCapacity_,
            m_Expressions_,
            m_PropertySheet_,
            m_ExposedExpressions_,
            m_Buffers_,
            m_TemporaryBuffers_,
            m_CPUBuffers_,
            m_Events_,
            m_InstancingDisabledReason_,
            m_RuntimeVersion_,
            m_CompilationVersion_);
    }

    public override string ToString() => $"VisualEffectInfo\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);
        ToString_Field15(sb, indent, indent_);
        ToString_Field16(sb, indent, indent_);
        ToString_Field17(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_RendererSettings: {{ \n{m_RendererSettings.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CullingFlags: {m_CullingFlags}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UpdateMode: {m_UpdateMode}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PreWarmDeltaTime: {m_PreWarmDeltaTime}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PreWarmStepCount: {m_PreWarmStepCount}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_InitialEventName: \"{m_InitialEventName}\"");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_InstancingMode: {m_InstancingMode}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_InstancingCapacity: {m_InstancingCapacity}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Expressions: {{ \n{m_Expressions.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_PropertySheet: {{ \n{m_PropertySheet.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ExposedExpressions[{m_ExposedExpressions.Length}] = {{");
        if (m_ExposedExpressions.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXMapping _4 in m_ExposedExpressions)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_ExposedExpressions.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Buffers[{m_Buffers.Length}] = {{");
        if (m_Buffers.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXGPUBufferDesc _4 in m_Buffers)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Buffers.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_TemporaryBuffers[{m_TemporaryBuffers.Length}] = {{");
        if (m_TemporaryBuffers.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXTemporaryGPUBufferDesc _4 in m_TemporaryBuffers)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_TemporaryBuffers.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_CPUBuffers[{m_CPUBuffers.Length}] = {{");
        if (m_CPUBuffers.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXCPUBufferDesc _4 in m_CPUBuffers)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_CPUBuffers.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Events[{m_Events.Length}] = {{");
        if (m_Events.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXEventDesc _4 in m_Events)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Events.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_InstancingDisabledReason: {m_InstancingDisabledReason}");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RuntimeVersion: {m_RuntimeVersion}");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CompilationVersion: {m_CompilationVersion}");
    }
}

/* $VFXRendererSettings (5 fields) */
public readonly record struct VFXRendererSettings (
    int motionVectorGenerationMode,
    int shadowCastingMode,
    bool receiveShadows,
    int reflectionProbeUsage,
    int lightProbeUsage) : IUnityStructure
{
    public static VFXRendererSettings Read(EndianBinaryReader reader)
    {
        int motionVectorGenerationMode_ = reader.ReadS32();
        int shadowCastingMode_ = reader.ReadS32();
        bool receiveShadows_ = reader.ReadBool();
        reader.AlignTo(4); /* receiveShadows */
        int reflectionProbeUsage_ = reader.ReadS32();
        int lightProbeUsage_ = reader.ReadS32();
        
        return new(motionVectorGenerationMode_,
            shadowCastingMode_,
            receiveShadows_,
            reflectionProbeUsage_,
            lightProbeUsage_);
    }

    public override string ToString() => $"VFXRendererSettings\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}motionVectorGenerationMode: {motionVectorGenerationMode}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}shadowCastingMode: {shadowCastingMode}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}receiveShadows: {receiveShadows}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}reflectionProbeUsage: {reflectionProbeUsage}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}lightProbeUsage: {lightProbeUsage}");
    }
}

/* $VFXExpressionContainer (10 fields) */
public record class VFXExpressionContainer (
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
        Expression[] m_Expressions_ = BuiltInArray<Expression>.Read(reader);
        reader.AlignTo(4); /* m_Expressions */
        uint m_MaxCommonExpressionsIndex_ = reader.ReadU32();
        uint m_ConstantBakeCurveCount_ = reader.ReadU32();
        uint m_ConstantBakeGradientCount_ = reader.ReadU32();
        uint m_DynamicBakeCurveCount_ = reader.ReadU32();
        uint m_DynamicBakeGradientCount_ = reader.ReadU32();
        bool m_NeedsLocalToWorld_ = reader.ReadBool();
        bool m_NeedsWorldToLocal_ = reader.ReadBool();
        bool m_NeedsMainCamera_ = reader.ReadBool();
        reader.AlignTo(4); /* m_NeedsMainCamera */
        int m_NeededMainCameraBuffers_ = reader.ReadS32();
        
        return new(m_Expressions_,
            m_MaxCommonExpressionsIndex_,
            m_ConstantBakeCurveCount_,
            m_ConstantBakeGradientCount_,
            m_DynamicBakeCurveCount_,
            m_DynamicBakeGradientCount_,
            m_NeedsLocalToWorld_,
            m_NeedsWorldToLocal_,
            m_NeedsMainCamera_,
            m_NeededMainCameraBuffers_);
    }

    public override string ToString() => $"VFXExpressionContainer\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Expressions[{m_Expressions.Length}] = {{");
        if (m_Expressions.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (Expression _4 in m_Expressions)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Expressions.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MaxCommonExpressionsIndex: {m_MaxCommonExpressionsIndex}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ConstantBakeCurveCount: {m_ConstantBakeCurveCount}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ConstantBakeGradientCount: {m_ConstantBakeGradientCount}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DynamicBakeCurveCount: {m_DynamicBakeCurveCount}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DynamicBakeGradientCount: {m_DynamicBakeGradientCount}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_NeedsLocalToWorld: {m_NeedsLocalToWorld}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_NeedsWorldToLocal: {m_NeedsWorldToLocal}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_NeedsMainCamera: {m_NeedsMainCamera}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_NeededMainCameraBuffers: {m_NeededMainCameraBuffers}");
    }
}

/* $Expression (6 fields) */
public readonly record struct Expression (
    int op,
    int valueIndex,
    int data_0,
    int data_1,
    int data_2,
    int data_3) : IUnityStructure
{
    public static Expression Read(EndianBinaryReader reader)
    {
        int op_ = reader.ReadS32();
        int valueIndex_ = reader.ReadS32();
        int data_0_ = reader.ReadS32();
        int data_1_ = reader.ReadS32();
        int data_2_ = reader.ReadS32();
        int data_3_ = reader.ReadS32();
        
        return new(op_,
            valueIndex_,
            data_0_,
            data_1_,
            data_2_,
            data_3_);
    }

    public override string ToString() => $"Expression\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}op: {op}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}valueIndex: {valueIndex}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}data_0: {data_0}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}data_1: {data_1}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}data_2: {data_2}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}data_3: {data_3}");
    }
}

/* $VFXPropertySheetSerializedBase_1 (11 fields) */
public record class VFXPropertySheetSerializedBase_1 (
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
        VFXField_11 m_Float_ = VFXField_11.Read(reader);
        reader.AlignTo(4); /* m_Float */
        VFXField_12 m_Vector2f_ = VFXField_12.Read(reader);
        reader.AlignTo(4); /* m_Vector2f */
        VFXField_13 m_Vector3f_ = VFXField_13.Read(reader);
        reader.AlignTo(4); /* m_Vector3f */
        VFXField_14 m_Vector4f_ = VFXField_14.Read(reader);
        reader.AlignTo(4); /* m_Vector4f */
        VFXField_15 m_Uint_ = VFXField_15.Read(reader);
        reader.AlignTo(4); /* m_Uint */
        VFXField_16 m_Int_ = VFXField_16.Read(reader);
        reader.AlignTo(4); /* m_Int */
        VFXField_17 m_Matrix4x4f_ = VFXField_17.Read(reader);
        reader.AlignTo(4); /* m_Matrix4x4f */
        VFXField_18 m_AnimationCurve_ = VFXField_18.Read(reader);
        reader.AlignTo(4); /* m_AnimationCurve */
        VFXField_19 m_Gradient_ = VFXField_19.Read(reader);
        reader.AlignTo(4); /* m_Gradient */
        VFXField_20 m_NamedObject_ = VFXField_20.Read(reader);
        reader.AlignTo(4); /* m_NamedObject */
        VFXField_21 m_Bool_ = VFXField_21.Read(reader);
        reader.AlignTo(4); /* m_Bool */
        
        return new(m_Float_,
            m_Vector2f_,
            m_Vector3f_,
            m_Vector4f_,
            m_Uint_,
            m_Int_,
            m_Matrix4x4f_,
            m_AnimationCurve_,
            m_Gradient_,
            m_NamedObject_,
            m_Bool_);
    }

    public override string ToString() => $"VFXPropertySheetSerializedBase_1\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Float: {{ \n{m_Float.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Vector2f: {{ \n{m_Vector2f.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Vector3f: {{ \n{m_Vector3f.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Vector4f: {{ \n{m_Vector4f.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Uint: {{ \n{m_Uint.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Int: {{ \n{m_Int.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Matrix4x4f: {{ \n{m_Matrix4x4f.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_AnimationCurve: {{ \n{m_AnimationCurve.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Gradient: {{ \n{m_Gradient.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_NamedObject: {{ \n{m_NamedObject.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Bool: {{ \n{m_Bool.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $VFXField_11 (1 fields) */
public record class VFXField_11 (
    VFXEntryExpressionValue[] m_Array) : IUnityStructure
{
    public static VFXField_11 Read(EndianBinaryReader reader)
    {
        VFXEntryExpressionValue[] m_Array_ = BuiltInArray<VFXEntryExpressionValue>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(m_Array_);
    }

    public override string ToString() => $"VFXField_11\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Array[{m_Array.Length}] = {{");
        if (m_Array.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXEntryExpressionValue _4 in m_Array)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ m_ExpressionIndex: {_4.m_ExpressionIndex}, m_Value: {_4.m_Value} }}\n");
            ++_4i;
        }
        if (m_Array.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $VFXEntryExpressionValue (2 fields) */
public readonly record struct VFXEntryExpressionValue (
    uint m_ExpressionIndex,
    float m_Value) : IUnityStructure
{
    public static VFXEntryExpressionValue Read(EndianBinaryReader reader)
    {
        uint m_ExpressionIndex_ = reader.ReadU32();
        float m_Value_ = reader.ReadF32();
        reader.AlignTo(4); /* m_Value */
        
        return new(m_ExpressionIndex_,
            m_Value_);
    }

    public override string ToString() => $"VFXEntryExpressionValue\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ExpressionIndex: {m_ExpressionIndex}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Value: {m_Value}");
    }
}

/* $VFXField_12 (1 fields) */
public record class VFXField_12 (
    VFXEntryExpressionValue_1[] m_Array) : IUnityStructure
{
    public static VFXField_12 Read(EndianBinaryReader reader)
    {
        VFXEntryExpressionValue_1[] m_Array_ = BuiltInArray<VFXEntryExpressionValue_1>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(m_Array_);
    }

    public override string ToString() => $"VFXField_12\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Array[{m_Array.Length}] = {{");
        if (m_Array.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXEntryExpressionValue_1 _4 in m_Array)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Array.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $VFXEntryExpressionValue_1 (2 fields) */
public record class VFXEntryExpressionValue_1 (
    uint m_ExpressionIndex,
    Vector2f m_Value) : IUnityStructure
{
    public static VFXEntryExpressionValue_1 Read(EndianBinaryReader reader)
    {
        uint m_ExpressionIndex_ = reader.ReadU32();
        Vector2f m_Value_ = Vector2f.Read(reader);
        reader.AlignTo(4); /* m_Value */
        
        return new(m_ExpressionIndex_,
            m_Value_);
    }

    public override string ToString() => $"VFXEntryExpressionValue_1\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ExpressionIndex: {m_ExpressionIndex}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Value: {{ x: {m_Value.x}, y: {m_Value.y} }}\n");
    }
}

/* $VFXField_13 (1 fields) */
public record class VFXField_13 (
    VFXEntryExpressionValue_2[] m_Array) : IUnityStructure
{
    public static VFXField_13 Read(EndianBinaryReader reader)
    {
        VFXEntryExpressionValue_2[] m_Array_ = BuiltInArray<VFXEntryExpressionValue_2>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(m_Array_);
    }

    public override string ToString() => $"VFXField_13\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Array[{m_Array.Length}] = {{");
        if (m_Array.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXEntryExpressionValue_2 _4 in m_Array)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Array.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $VFXEntryExpressionValue_2 (2 fields) */
public record class VFXEntryExpressionValue_2 (
    uint m_ExpressionIndex,
    Vector3f m_Value) : IUnityStructure
{
    public static VFXEntryExpressionValue_2 Read(EndianBinaryReader reader)
    {
        uint m_ExpressionIndex_ = reader.ReadU32();
        Vector3f m_Value_ = Vector3f.Read(reader);
        reader.AlignTo(4); /* m_Value */
        
        return new(m_ExpressionIndex_,
            m_Value_);
    }

    public override string ToString() => $"VFXEntryExpressionValue_2\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ExpressionIndex: {m_ExpressionIndex}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Value: {{ x: {m_Value.x}, y: {m_Value.y}, z: {m_Value.z} }}\n");
    }
}

/* $VFXField_14 (1 fields) */
public record class VFXField_14 (
    VFXEntryExpressionValue_3[] m_Array) : IUnityStructure
{
    public static VFXField_14 Read(EndianBinaryReader reader)
    {
        VFXEntryExpressionValue_3[] m_Array_ = BuiltInArray<VFXEntryExpressionValue_3>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(m_Array_);
    }

    public override string ToString() => $"VFXField_14\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Array[{m_Array.Length}] = {{");
        if (m_Array.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXEntryExpressionValue_3 _4 in m_Array)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Array.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $VFXEntryExpressionValue_3 (2 fields) */
public record class VFXEntryExpressionValue_3 (
    uint m_ExpressionIndex,
    Vector4f m_Value) : IUnityStructure
{
    public static VFXEntryExpressionValue_3 Read(EndianBinaryReader reader)
    {
        uint m_ExpressionIndex_ = reader.ReadU32();
        Vector4f m_Value_ = Vector4f.Read(reader);
        reader.AlignTo(4); /* m_Value */
        
        return new(m_ExpressionIndex_,
            m_Value_);
    }

    public override string ToString() => $"VFXEntryExpressionValue_3\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ExpressionIndex: {m_ExpressionIndex}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Value: {{ x: {m_Value.x}, y: {m_Value.y}, z: {m_Value.z}, w: {m_Value.w} }}\n");
    }
}

/* $VFXField_15 (1 fields) */
public record class VFXField_15 (
    VFXEntryExpressionValue_4[] m_Array) : IUnityStructure
{
    public static VFXField_15 Read(EndianBinaryReader reader)
    {
        VFXEntryExpressionValue_4[] m_Array_ = BuiltInArray<VFXEntryExpressionValue_4>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(m_Array_);
    }

    public override string ToString() => $"VFXField_15\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Array[{m_Array.Length}] = {{");
        if (m_Array.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXEntryExpressionValue_4 _4 in m_Array)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ m_ExpressionIndex: {_4.m_ExpressionIndex}, m_Value: {_4.m_Value} }}\n");
            ++_4i;
        }
        if (m_Array.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $VFXEntryExpressionValue_4 (2 fields) */
public readonly record struct VFXEntryExpressionValue_4 (
    uint m_ExpressionIndex,
    uint m_Value) : IUnityStructure
{
    public static VFXEntryExpressionValue_4 Read(EndianBinaryReader reader)
    {
        uint m_ExpressionIndex_ = reader.ReadU32();
        uint m_Value_ = reader.ReadU32();
        reader.AlignTo(4); /* m_Value */
        
        return new(m_ExpressionIndex_,
            m_Value_);
    }

    public override string ToString() => $"VFXEntryExpressionValue_4\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ExpressionIndex: {m_ExpressionIndex}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Value: {m_Value}");
    }
}

/* $VFXField_16 (1 fields) */
public record class VFXField_16 (
    VFXEntryExpressionValue_5[] m_Array) : IUnityStructure
{
    public static VFXField_16 Read(EndianBinaryReader reader)
    {
        VFXEntryExpressionValue_5[] m_Array_ = BuiltInArray<VFXEntryExpressionValue_5>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(m_Array_);
    }

    public override string ToString() => $"VFXField_16\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Array[{m_Array.Length}] = {{");
        if (m_Array.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXEntryExpressionValue_5 _4 in m_Array)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ m_ExpressionIndex: {_4.m_ExpressionIndex}, m_Value: {_4.m_Value} }}\n");
            ++_4i;
        }
        if (m_Array.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $VFXEntryExpressionValue_5 (2 fields) */
public readonly record struct VFXEntryExpressionValue_5 (
    uint m_ExpressionIndex,
    int m_Value) : IUnityStructure
{
    public static VFXEntryExpressionValue_5 Read(EndianBinaryReader reader)
    {
        uint m_ExpressionIndex_ = reader.ReadU32();
        int m_Value_ = reader.ReadS32();
        reader.AlignTo(4); /* m_Value */
        
        return new(m_ExpressionIndex_,
            m_Value_);
    }

    public override string ToString() => $"VFXEntryExpressionValue_5\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ExpressionIndex: {m_ExpressionIndex}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Value: {m_Value}");
    }
}

/* $VFXField_17 (1 fields) */
public record class VFXField_17 (
    VFXEntryExpressionValue_6[] m_Array) : IUnityStructure
{
    public static VFXField_17 Read(EndianBinaryReader reader)
    {
        VFXEntryExpressionValue_6[] m_Array_ = BuiltInArray<VFXEntryExpressionValue_6>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(m_Array_);
    }

    public override string ToString() => $"VFXField_17\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Array[{m_Array.Length}] = {{");
        if (m_Array.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXEntryExpressionValue_6 _4 in m_Array)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Array.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $VFXEntryExpressionValue_6 (2 fields) */
public record class VFXEntryExpressionValue_6 (
    uint m_ExpressionIndex,
    Matrix4x4f m_Value) : IUnityStructure
{
    public static VFXEntryExpressionValue_6 Read(EndianBinaryReader reader)
    {
        uint m_ExpressionIndex_ = reader.ReadU32();
        Matrix4x4f m_Value_ = Matrix4x4f.Read(reader);
        reader.AlignTo(4); /* m_Value */
        
        return new(m_ExpressionIndex_,
            m_Value_);
    }

    public override string ToString() => $"VFXEntryExpressionValue_6\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ExpressionIndex: {m_ExpressionIndex}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Value: {{ \n{m_Value.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $VFXField_18 (1 fields) */
public record class VFXField_18 (
    VFXEntryExpressionValue_7[] m_Array) : IUnityStructure
{
    public static VFXField_18 Read(EndianBinaryReader reader)
    {
        VFXEntryExpressionValue_7[] m_Array_ = BuiltInArray<VFXEntryExpressionValue_7>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(m_Array_);
    }

    public override string ToString() => $"VFXField_18\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Array[{m_Array.Length}] = {{");
        if (m_Array.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXEntryExpressionValue_7 _4 in m_Array)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Array.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $VFXEntryExpressionValue_7 (2 fields) */
public record class VFXEntryExpressionValue_7 (
    uint m_ExpressionIndex,
    AnimationCurve m_Value) : IUnityStructure
{
    public static VFXEntryExpressionValue_7 Read(EndianBinaryReader reader)
    {
        uint m_ExpressionIndex_ = reader.ReadU32();
        AnimationCurve m_Value_ = AnimationCurve.Read(reader);
        reader.AlignTo(4); /* m_Value */
        
        return new(m_ExpressionIndex_,
            m_Value_);
    }

    public override string ToString() => $"VFXEntryExpressionValue_7\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ExpressionIndex: {m_ExpressionIndex}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Value: {{ \n{m_Value.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $VFXField_19 (1 fields) */
public record class VFXField_19 (
    VFXEntryExpressionValue_8[] m_Array) : IUnityStructure
{
    public static VFXField_19 Read(EndianBinaryReader reader)
    {
        VFXEntryExpressionValue_8[] m_Array_ = BuiltInArray<VFXEntryExpressionValue_8>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(m_Array_);
    }

    public override string ToString() => $"VFXField_19\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Array[{m_Array.Length}] = {{");
        if (m_Array.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXEntryExpressionValue_8 _4 in m_Array)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Array.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $VFXEntryExpressionValue_8 (2 fields) */
public record class VFXEntryExpressionValue_8 (
    uint m_ExpressionIndex,
    Gradient m_Value) : IUnityStructure
{
    public static VFXEntryExpressionValue_8 Read(EndianBinaryReader reader)
    {
        uint m_ExpressionIndex_ = reader.ReadU32();
        Gradient m_Value_ = Gradient.Read(reader);
        reader.AlignTo(4); /* m_Value */
        
        return new(m_ExpressionIndex_,
            m_Value_);
    }

    public override string ToString() => $"VFXEntryExpressionValue_8\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ExpressionIndex: {m_ExpressionIndex}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Value: {{ \n{m_Value.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $VFXField_20 (1 fields) */
public record class VFXField_20 (
    VFXEntryExpressionValue_9[] m_Array) : IUnityStructure
{
    public static VFXField_20 Read(EndianBinaryReader reader)
    {
        VFXEntryExpressionValue_9[] m_Array_ = BuiltInArray<VFXEntryExpressionValue_9>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(m_Array_);
    }

    public override string ToString() => $"VFXField_20\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Array[{m_Array.Length}] = {{");
        if (m_Array.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXEntryExpressionValue_9 _4 in m_Array)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Array.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $VFXEntryExpressionValue_9 (2 fields) */
public record class VFXEntryExpressionValue_9 (
    uint m_ExpressionIndex,
    PPtr<Object> m_Value) : IUnityStructure
{
    public static VFXEntryExpressionValue_9 Read(EndianBinaryReader reader)
    {
        uint m_ExpressionIndex_ = reader.ReadU32();
        PPtr<Object> m_Value_ = PPtr<Object>.Read(reader);
        reader.AlignTo(4); /* m_Value */
        
        return new(m_ExpressionIndex_,
            m_Value_);
    }

    public override string ToString() => $"VFXEntryExpressionValue_9\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ExpressionIndex: {m_ExpressionIndex}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Value: {m_Value}");
    }
}

/* $VFXField_21 (1 fields) */
public record class VFXField_21 (
    VFXEntryExpressionValue_10[] m_Array) : IUnityStructure
{
    public static VFXField_21 Read(EndianBinaryReader reader)
    {
        VFXEntryExpressionValue_10[] m_Array_ = BuiltInArray<VFXEntryExpressionValue_10>.Read(reader);
        reader.AlignTo(4); /* m_Array */
        
        return new(m_Array_);
    }

    public override string ToString() => $"VFXField_21\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Array[{m_Array.Length}] = {{");
        if (m_Array.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXEntryExpressionValue_10 _4 in m_Array)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ m_ExpressionIndex: {_4.m_ExpressionIndex}, m_Value: {_4.m_Value} }}\n");
            ++_4i;
        }
        if (m_Array.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $VFXEntryExpressionValue_10 (2 fields) */
public readonly record struct VFXEntryExpressionValue_10 (
    uint m_ExpressionIndex,
    bool m_Value) : IUnityStructure
{
    public static VFXEntryExpressionValue_10 Read(EndianBinaryReader reader)
    {
        uint m_ExpressionIndex_ = reader.ReadU32();
        bool m_Value_ = reader.ReadBool();
        reader.AlignTo(4); /* m_Value */
        
        return new(m_ExpressionIndex_,
            m_Value_);
    }

    public override string ToString() => $"VFXEntryExpressionValue_10\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ExpressionIndex: {m_ExpressionIndex}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Value: {m_Value}");
    }
}

/* $VFXMapping (2 fields) */
public record class VFXMapping (
    AsciiString nameId,
    int index) : IUnityStructure
{
    public static VFXMapping Read(EndianBinaryReader reader)
    {
        AsciiString nameId_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* nameId */
        int index_ = reader.ReadS32();
        
        return new(nameId_,
            index_);
    }

    public override string ToString() => $"VFXMapping\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}nameId: \"{nameId}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}index: {index}");
    }
}

/* $VFXGPUBufferDesc (5 fields) */
public record class VFXGPUBufferDesc (
    int type,
    uint size,
    VFXLayoutElementDesc[] layout,
    uint capacity,
    uint stride) : IUnityStructure
{
    public static VFXGPUBufferDesc Read(EndianBinaryReader reader)
    {
        int type_ = reader.ReadS32();
        uint size_ = reader.ReadU32();
        VFXLayoutElementDesc[] layout_ = BuiltInArray<VFXLayoutElementDesc>.Read(reader);
        reader.AlignTo(4); /* layout */
        uint capacity_ = reader.ReadU32();
        uint stride_ = reader.ReadU32();
        
        return new(type_,
            size_,
            layout_,
            capacity_,
            stride_);
    }

    public override string ToString() => $"VFXGPUBufferDesc\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}type: {type}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}size: {size}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}layout[{layout.Length}] = {{");
        if (layout.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXLayoutElementDesc _4 in layout)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (layout.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}capacity: {capacity}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}stride: {stride}");
    }
}

/* $VFXLayoutElementDesc (3 fields) */
public record class VFXLayoutElementDesc (
    AsciiString name,
    int type,
    VFXLayoutOffset offset) : IUnityStructure
{
    public static VFXLayoutElementDesc Read(EndianBinaryReader reader)
    {
        AsciiString name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* name */
        int type_ = reader.ReadS32();
        VFXLayoutOffset offset_ = VFXLayoutOffset.Read(reader);
        
        return new(name_,
            type_,
            offset_);
    }

    public override string ToString() => $"VFXLayoutElementDesc\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}name: \"{name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}type: {type}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}offset: {{ bucket: {offset.bucket}, structure: {offset.structure}, element: {offset.element} }}\n");
    }
}

/* $VFXLayoutOffset (3 fields) */
public readonly record struct VFXLayoutOffset (
    uint bucket,
    uint structure,
    uint element) : IUnityStructure
{
    public static VFXLayoutOffset Read(EndianBinaryReader reader)
    {
        uint bucket_ = reader.ReadU32();
        uint structure_ = reader.ReadU32();
        uint element_ = reader.ReadU32();
        
        return new(bucket_,
            structure_,
            element_);
    }

    public override string ToString() => $"VFXLayoutOffset\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}bucket: {bucket}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}structure: {structure}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}element: {element}");
    }
}

/* $VFXTemporaryGPUBufferDesc (2 fields) */
public record class VFXTemporaryGPUBufferDesc (
    VFXGPUBufferDesc desc,
    uint frameCount) : IUnityStructure
{
    public static VFXTemporaryGPUBufferDesc Read(EndianBinaryReader reader)
    {
        VFXGPUBufferDesc desc_ = VFXGPUBufferDesc.Read(reader);
        reader.AlignTo(4); /* desc */
        uint frameCount_ = reader.ReadU32();
        
        return new(desc_,
            frameCount_);
    }

    public override string ToString() => $"VFXTemporaryGPUBufferDesc\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}desc: {{ \n{desc.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}frameCount: {frameCount}");
    }
}

/* $VFXCPUBufferDesc (4 fields) */
public record class VFXCPUBufferDesc (
    uint capacity,
    uint stride,
    VFXLayoutElementDesc[] layout,
    VFXCPUBufferData initialData) : IUnityStructure
{
    public static VFXCPUBufferDesc Read(EndianBinaryReader reader)
    {
        uint capacity_ = reader.ReadU32();
        uint stride_ = reader.ReadU32();
        VFXLayoutElementDesc[] layout_ = BuiltInArray<VFXLayoutElementDesc>.Read(reader);
        reader.AlignTo(4); /* layout */
        VFXCPUBufferData initialData_ = VFXCPUBufferData.Read(reader);
        reader.AlignTo(4); /* initialData */
        
        return new(capacity_,
            stride_,
            layout_,
            initialData_);
    }

    public override string ToString() => $"VFXCPUBufferDesc\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}capacity: {capacity}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}stride: {stride}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}layout[{layout.Length}] = {{");
        if (layout.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXLayoutElementDesc _4 in layout)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (layout.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}initialData: {{ \n{initialData.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $VFXCPUBufferData (1 fields) */
public record class VFXCPUBufferData (
    uint[] data) : IUnityStructure
{
    public static VFXCPUBufferData Read(EndianBinaryReader reader)
    {
        uint[] data_ = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* data */
        
        return new(data_);
    }

    public override string ToString() => $"VFXCPUBufferData\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}data[{data.Length}] = {{");
        if (data.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint _4 in data)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (data.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $VFXEventDesc (4 fields) */
public record class VFXEventDesc (
    AsciiString name,
    uint[] playSystems,
    uint[] stopSystems,
    uint[] initSystems) : IUnityStructure
{
    public static VFXEventDesc Read(EndianBinaryReader reader)
    {
        AsciiString name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* name */
        uint[] playSystems_ = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* playSystems */
        uint[] stopSystems_ = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* stopSystems */
        uint[] initSystems_ = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* initSystems */
        
        return new(name_,
            playSystems_,
            stopSystems_,
            initSystems_);
    }

    public override string ToString() => $"VFXEventDesc\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}name: \"{name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}playSystems[{playSystems.Length}] = {{");
        if (playSystems.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint _4 in playSystems)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (playSystems.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}stopSystems[{stopSystems.Length}] = {{");
        if (stopSystems.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint _4 in stopSystems)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (stopSystems.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}initSystems[{initSystems.Length}] = {{");
        if (initSystems.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint _4 in initSystems)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (initSystems.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $VFXSystemDesc (9 fields) */
public record class VFXSystemDesc (
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
        int type_ = reader.ReadS32();
        int flags_ = reader.ReadS32();
        uint capacity_ = reader.ReadU32();
        uint layer_ = reader.ReadU32();
        AsciiString name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* name */
        VFXMapping[] buffers_ = BuiltInArray<VFXMapping>.Read(reader);
        reader.AlignTo(4); /* buffers */
        VFXMapping[] values_ = BuiltInArray<VFXMapping>.Read(reader);
        reader.AlignTo(4); /* values */
        VFXTaskDesc[] tasks_ = BuiltInArray<VFXTaskDesc>.Read(reader);
        reader.AlignTo(4); /* tasks */
        VFXInstanceSplitDesc[] instanceSplitDescs_ = BuiltInArray<VFXInstanceSplitDesc>.Read(reader);
        reader.AlignTo(4); /* instanceSplitDescs */
        
        return new(type_,
            flags_,
            capacity_,
            layer_,
            name_,
            buffers_,
            values_,
            tasks_,
            instanceSplitDescs_);
    }

    public override string ToString() => $"VFXSystemDesc\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}type: {type}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}flags: {flags}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}capacity: {capacity}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}layer: {layer}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}name: \"{name}\"");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}buffers[{buffers.Length}] = {{");
        if (buffers.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXMapping _4 in buffers)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (buffers.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}values[{values.Length}] = {{");
        if (values.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXMapping _4 in values)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (values.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}tasks[{tasks.Length}] = {{");
        if (tasks.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXTaskDesc _4 in tasks)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (tasks.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}instanceSplitDescs[{instanceSplitDescs.Length}] = {{");
        if (instanceSplitDescs.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXInstanceSplitDesc _4 in instanceSplitDescs)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (instanceSplitDescs.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $VFXTaskDesc (7 fields) */
public record class VFXTaskDesc (
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
        int type_ = reader.ReadS32();
        VFXMapping[] buffers_ = BuiltInArray<VFXMapping>.Read(reader);
        reader.AlignTo(4); /* buffers */
        VFXMappingTemporary[] temporaryBuffers_ = BuiltInArray<VFXMappingTemporary>.Read(reader);
        reader.AlignTo(4); /* temporaryBuffers */
        VFXMapping[] values_ = BuiltInArray<VFXMapping>.Read(reader);
        reader.AlignTo(4); /* values */
        VFXMapping[] @params_ = BuiltInArray<VFXMapping>.Read(reader);
        reader.AlignTo(4); /* @params */
        PPtr<NamedObject> processor_ = PPtr<NamedObject>.Read(reader);
        uint instanceSplitIndex_ = reader.ReadU32();
        
        return new(type_,
            buffers_,
            temporaryBuffers_,
            values_,
            @params_,
            processor_,
            instanceSplitIndex_);
    }

    public override string ToString() => $"VFXTaskDesc\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}type: {type}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}buffers[{buffers.Length}] = {{");
        if (buffers.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXMapping _4 in buffers)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (buffers.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}temporaryBuffers[{temporaryBuffers.Length}] = {{");
        if (temporaryBuffers.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXMappingTemporary _4 in temporaryBuffers)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (temporaryBuffers.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}values[{values.Length}] = {{");
        if (values.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXMapping _4 in values)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (values.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}@params[{@params.Length}] = {{");
        if (@params.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXMapping _4 in @params)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (@params.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}processor: {processor}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}instanceSplitIndex: {instanceSplitIndex}");
    }
}

/* $VFXMappingTemporary (3 fields) */
public record class VFXMappingTemporary (
    VFXMapping mapping,
    uint pastFrameIndex,
    bool perCameraBuffer) : IUnityStructure
{
    public static VFXMappingTemporary Read(EndianBinaryReader reader)
    {
        VFXMapping mapping_ = VFXMapping.Read(reader);
        reader.AlignTo(4); /* mapping */
        uint pastFrameIndex_ = reader.ReadU32();
        bool perCameraBuffer_ = reader.ReadBool();
        reader.AlignTo(4); /* perCameraBuffer */
        
        return new(mapping_,
            pastFrameIndex_,
            perCameraBuffer_);
    }

    public override string ToString() => $"VFXMappingTemporary\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}mapping: {{ \n{mapping.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}pastFrameIndex: {pastFrameIndex}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}perCameraBuffer: {perCameraBuffer}");
    }
}

/* $VFXInstanceSplitDesc (1 fields) */
public record class VFXInstanceSplitDesc (
    uint[] values) : IUnityStructure
{
    public static VFXInstanceSplitDesc Read(EndianBinaryReader reader)
    {
        uint[] values_ = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* values */
        
        return new(values_);
    }

    public override string ToString() => $"VFXInstanceSplitDesc\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}values[{values.Length}] = {{");
        if (values.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint _4 in values)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (values.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $LineParameters (10 fields) */
public record class LineParameters (
    float widthMultiplier,
    AnimationCurve widthCurve,
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
        float widthMultiplier_ = reader.ReadF32();
        AnimationCurve widthCurve_ = AnimationCurve.Read(reader);
        reader.AlignTo(4); /* widthCurve */
        Gradient colorGradient_ = Gradient.Read(reader);
        reader.AlignTo(4); /* colorGradient */
        int numCornerVertices_ = reader.ReadS32();
        int numCapVertices_ = reader.ReadS32();
        int alignment_ = reader.ReadS32();
        int textureMode_ = reader.ReadS32();
        Vector2f textureScale_ = Vector2f.Read(reader);
        float shadowBias_ = reader.ReadF32();
        bool generateLightingData_ = reader.ReadBool();
        reader.AlignTo(4); /* generateLightingData */
        
        return new(widthMultiplier_,
            widthCurve_,
            colorGradient_,
            numCornerVertices_,
            numCapVertices_,
            alignment_,
            textureMode_,
            textureScale_,
            shadowBias_,
            generateLightingData_);
    }

    public override string ToString() => $"LineParameters\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}widthMultiplier: {widthMultiplier}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}widthCurve: {{ \n{widthCurve.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}colorGradient: {{ \n{colorGradient.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}numCornerVertices: {numCornerVertices}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}numCapVertices: {numCapVertices}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}alignment: {alignment}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}textureMode: {textureMode}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}textureScale: {{ x: {textureScale.x}, y: {textureScale.y} }}\n");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}shadowBias: {shadowBias}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}generateLightingData: {generateLightingData}");
    }
}

/* $ComputeShaderPlatformVariant (5 fields) */
public record class ComputeShaderPlatformVariant (
    int targetRenderer,
    int targetLevel,
    ComputeShaderKernelParent[] kernels,
    ComputeShaderCB[] constantBuffers,
    bool resourcesResolved) : IUnityStructure
{
    public static ComputeShaderPlatformVariant Read(EndianBinaryReader reader)
    {
        int targetRenderer_ = reader.ReadS32();
        int targetLevel_ = reader.ReadS32();
        ComputeShaderKernelParent[] kernels_ = BuiltInArray<ComputeShaderKernelParent>.Read(reader);
        reader.AlignTo(4); /* kernels */
        ComputeShaderCB[] constantBuffers_ = BuiltInArray<ComputeShaderCB>.Read(reader);
        reader.AlignTo(4); /* constantBuffers */
        bool resourcesResolved_ = reader.ReadBool();
        reader.AlignTo(4); /* resourcesResolved */
        
        return new(targetRenderer_,
            targetLevel_,
            kernels_,
            constantBuffers_,
            resourcesResolved_);
    }

    public override string ToString() => $"ComputeShaderPlatformVariant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}targetRenderer: {targetRenderer}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}targetLevel: {targetLevel}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}kernels[{kernels.Length}] = {{");
        if (kernels.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (ComputeShaderKernelParent _4 in kernels)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (kernels.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}constantBuffers[{constantBuffers.Length}] = {{");
        if (constantBuffers.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (ComputeShaderCB _4 in constantBuffers)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (constantBuffers.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}resourcesResolved: {resourcesResolved}");
    }
}

/* $ComputeShaderKernelParent (6 fields) */
public record class ComputeShaderKernelParent (
    AsciiString name,
    ComputeShaderKernel[] uniqueVariants,
    pair_2[] variantIndices,
    AsciiString[] globalKeywords,
    AsciiString[] localKeywords,
    AsciiString[] dynamicKeywords) : IUnityStructure
{
    public static ComputeShaderKernelParent Read(EndianBinaryReader reader)
    {
        AsciiString name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* name */
        ComputeShaderKernel[] uniqueVariants_ = BuiltInArray<ComputeShaderKernel>.Read(reader);
        reader.AlignTo(4); /* uniqueVariants */
        pair_2[] variantIndices_ = BuiltInArray<pair_2>.Read(reader);
        reader.AlignTo(4); /* variantIndices */
        AsciiString[] globalKeywords_ = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* globalKeywords */
        AsciiString[] localKeywords_ = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* localKeywords */
        AsciiString[] dynamicKeywords_ = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* dynamicKeywords */
        
        return new(name_,
            uniqueVariants_,
            variantIndices_,
            globalKeywords_,
            localKeywords_,
            dynamicKeywords_);
    }

    public override string ToString() => $"ComputeShaderKernelParent\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}name: \"{name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}uniqueVariants[{uniqueVariants.Length}] = {{");
        if (uniqueVariants.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (ComputeShaderKernel _4 in uniqueVariants)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (uniqueVariants.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}variantIndices[{variantIndices.Length}] = {{");
        if (variantIndices.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (pair_2 _4 in variantIndices)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (variantIndices.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}globalKeywords[{globalKeywords.Length}] = {{");
        if (globalKeywords.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (AsciiString _4 in globalKeywords)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = \"{_4}\"");
            ++_4i;
        }
        if (globalKeywords.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}localKeywords[{localKeywords.Length}] = {{");
        if (localKeywords.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (AsciiString _4 in localKeywords)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = \"{_4}\"");
            ++_4i;
        }
        if (localKeywords.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}dynamicKeywords[{dynamicKeywords.Length}] = {{");
        if (dynamicKeywords.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (AsciiString _4 in dynamicKeywords)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = \"{_4}\"");
            ++_4i;
        }
        if (dynamicKeywords.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $ComputeShaderKernel (9 fields) */
public record class ComputeShaderKernel (
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
        uint[] cbVariantIndices_ = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* cbVariantIndices */
        ComputeShaderResource[] cbs_ = BuiltInArray<ComputeShaderResource>.Read(reader);
        reader.AlignTo(4); /* cbs */
        ComputeShaderResource[] textures_ = BuiltInArray<ComputeShaderResource>.Read(reader);
        reader.AlignTo(4); /* textures */
        ComputeShaderBuiltinSampler[] builtinSamplers_ = BuiltInArray<ComputeShaderBuiltinSampler>.Read(reader);
        reader.AlignTo(4); /* builtinSamplers */
        ComputeShaderResource[] inBuffers_ = BuiltInArray<ComputeShaderResource>.Read(reader);
        reader.AlignTo(4); /* inBuffers */
        ComputeShaderResource[] outBuffers_ = BuiltInArray<ComputeShaderResource>.Read(reader);
        reader.AlignTo(4); /* outBuffers */
        byte[] code_ = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* code */
        uint[] threadGroupSize_ = BuiltInArray<uint>.Read(reader);
        long requirements_ = reader.ReadS64();
        
        return new(cbVariantIndices_,
            cbs_,
            textures_,
            builtinSamplers_,
            inBuffers_,
            outBuffers_,
            code_,
            threadGroupSize_,
            requirements_);
    }

    public override string ToString() => $"ComputeShaderKernel\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}cbVariantIndices[{cbVariantIndices.Length}] = {{");
        if (cbVariantIndices.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint _4 in cbVariantIndices)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (cbVariantIndices.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}cbs[{cbs.Length}] = {{");
        if (cbs.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (ComputeShaderResource _4 in cbs)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (cbs.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}textures[{textures.Length}] = {{");
        if (textures.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (ComputeShaderResource _4 in textures)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (textures.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}builtinSamplers[{builtinSamplers.Length}] = {{");
        if (builtinSamplers.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (ComputeShaderBuiltinSampler _4 in builtinSamplers)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ sampler: {_4.sampler}, bindPoint: {_4.bindPoint} }}\n");
            ++_4i;
        }
        if (builtinSamplers.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}inBuffers[{inBuffers.Length}] = {{");
        if (inBuffers.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (ComputeShaderResource _4 in inBuffers)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (inBuffers.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}outBuffers[{outBuffers.Length}] = {{");
        if (outBuffers.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (ComputeShaderResource _4 in outBuffers)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (outBuffers.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}code[{code.Length}] = {{");
        if (code.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (byte _4 in code)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (code.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}threadGroupSize[{threadGroupSize.Length}] = {{");
        if (threadGroupSize.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint _4 in threadGroupSize)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (threadGroupSize.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}requirements: {requirements}");
    }
}

/* $ComputeShaderResource (5 fields) */
public record class ComputeShaderResource (
    AsciiString name,
    AsciiString generatedName,
    int bindPoint,
    int samplerBindPoint,
    int texDimension) : IUnityStructure
{
    public static ComputeShaderResource Read(EndianBinaryReader reader)
    {
        AsciiString name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* name */
        AsciiString generatedName_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* generatedName */
        int bindPoint_ = reader.ReadS32();
        int samplerBindPoint_ = reader.ReadS32();
        int texDimension_ = reader.ReadS32();
        
        return new(name_,
            generatedName_,
            bindPoint_,
            samplerBindPoint_,
            texDimension_);
    }

    public override string ToString() => $"ComputeShaderResource\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}name: \"{name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}generatedName: \"{generatedName}\"");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}bindPoint: {bindPoint}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}samplerBindPoint: {samplerBindPoint}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}texDimension: {texDimension}");
    }
}

/* $ComputeShaderBuiltinSampler (2 fields) */
public readonly record struct ComputeShaderBuiltinSampler (
    uint sampler,
    int bindPoint) : IUnityStructure
{
    public static ComputeShaderBuiltinSampler Read(EndianBinaryReader reader)
    {
        uint sampler_ = reader.ReadU32();
        int bindPoint_ = reader.ReadS32();
        
        return new(sampler_,
            bindPoint_);
    }

    public override string ToString() => $"ComputeShaderBuiltinSampler\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sampler: {sampler}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}bindPoint: {bindPoint}");
    }
}

/* $pair_2 (2 fields) */
public record class pair_2 (
    AsciiString first,
    uint second) : IUnityStructure
{
    public static pair_2 Read(EndianBinaryReader reader)
    {
        AsciiString first_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* first */
        uint second_ = reader.ReadU32();
        
        return new(first_,
            second_);
    }

    public override string ToString() => $"pair_2\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}first: \"{first}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}second: {second}");
    }
}

/* $ComputeShaderCB (3 fields) */
public record class ComputeShaderCB (
    AsciiString name,
    int byteSize,
    ComputeShaderParam[] @params) : IUnityStructure
{
    public static ComputeShaderCB Read(EndianBinaryReader reader)
    {
        AsciiString name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* name */
        int byteSize_ = reader.ReadS32();
        ComputeShaderParam[] @params_ = BuiltInArray<ComputeShaderParam>.Read(reader);
        reader.AlignTo(4); /* @params */
        
        return new(name_,
            byteSize_,
            @params_);
    }

    public override string ToString() => $"ComputeShaderCB\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}name: \"{name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}byteSize: {byteSize}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}@params[{@params.Length}] = {{");
        if (@params.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (ComputeShaderParam _4 in @params)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (@params.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $ComputeShaderParam (6 fields) */
public record class ComputeShaderParam (
    AsciiString name,
    int type,
    uint offset,
    uint arraySize,
    uint rowCount,
    uint colCount) : IUnityStructure
{
    public static ComputeShaderParam Read(EndianBinaryReader reader)
    {
        AsciiString name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* name */
        int type_ = reader.ReadS32();
        uint offset_ = reader.ReadU32();
        uint arraySize_ = reader.ReadU32();
        uint rowCount_ = reader.ReadU32();
        uint colCount_ = reader.ReadU32();
        
        return new(name_,
            type_,
            offset_,
            arraySize_,
            rowCount_,
            colCount_);
    }

    public override string ToString() => $"ComputeShaderParam\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}name: \"{name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}type: {type}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}offset: {offset}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}arraySize: {arraySize}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}rowCount: {rowCount}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}colCount: {colCount}");
    }
}

/* $UnityPropertySheet (4 fields) */
public record class UnityPropertySheet (
    Dictionary<AsciiString, UnityTexEnv> m_TexEnvs,
    Dictionary<AsciiString, int> m_Ints,
    Dictionary<AsciiString, float> m_Floats,
    Dictionary<AsciiString, ColorRGBA_1> m_Colors) : IUnityStructure
{
    public static UnityPropertySheet Read(EndianBinaryReader reader)
    {
        Dictionary<AsciiString, UnityTexEnv> m_TexEnvs_ = BuiltInMap<AsciiString, UnityTexEnv>.Read(reader);
        reader.AlignTo(4); /* m_TexEnvs */
        Dictionary<AsciiString, int> m_Ints_ = BuiltInMap<AsciiString, int>.Read(reader);
        reader.AlignTo(4); /* m_Ints */
        Dictionary<AsciiString, float> m_Floats_ = BuiltInMap<AsciiString, float>.Read(reader);
        reader.AlignTo(4); /* m_Floats */
        Dictionary<AsciiString, ColorRGBA_1> m_Colors_ = BuiltInMap<AsciiString, ColorRGBA_1>.Read(reader);
        reader.AlignTo(4); /* m_Colors */
        
        return new(m_TexEnvs_,
            m_Ints_,
            m_Floats_,
            m_Colors_);
    }

    public override string ToString() => $"UnityPropertySheet\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_TexEnvs[{m_TexEnvs.Count}] = {{");
        if (m_TexEnvs.Count > 0) sb.AppendLine();
        int _4i = 0;
        foreach (KeyValuePair<AsciiString, UnityTexEnv> _4 in m_TexEnvs)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[\"{_4.Key}\"] = {{ \n{_4.Value.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_TexEnvs.Count > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Ints[{m_Ints.Count}] = {{");
        if (m_Ints.Count > 0) sb.AppendLine();
        int _4i = 0;
        foreach (KeyValuePair<AsciiString, int> _4 in m_Ints)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[\"{_4.Key}\"] = {_4.Value}");
            ++_4i;
        }
        if (m_Ints.Count > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Floats[{m_Floats.Count}] = {{");
        if (m_Floats.Count > 0) sb.AppendLine();
        int _4i = 0;
        foreach (KeyValuePair<AsciiString, float> _4 in m_Floats)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[\"{_4.Key}\"] = {_4.Value}");
            ++_4i;
        }
        if (m_Floats.Count > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Colors[{m_Colors.Count}] = {{");
        if (m_Colors.Count > 0) sb.AppendLine();
        int _4i = 0;
        foreach (KeyValuePair<AsciiString, ColorRGBA_1> _4 in m_Colors)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[\"{_4.Key}\"] = {{ r: {_4.Value.r}, g: {_4.Value.g}, b: {_4.Value.b}, a: {_4.Value.a} }}\n");
            ++_4i;
        }
        if (m_Colors.Count > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $UnityTexEnv (3 fields) */
public record class UnityTexEnv (
    PPtr<Texture> m_Texture,
    Vector2f m_Scale,
    Vector2f m_Offset) : IUnityStructure
{
    public static UnityTexEnv Read(EndianBinaryReader reader)
    {
        PPtr<Texture> m_Texture_ = PPtr<Texture>.Read(reader);
        Vector2f m_Scale_ = Vector2f.Read(reader);
        Vector2f m_Offset_ = Vector2f.Read(reader);
        
        return new(m_Texture_,
            m_Scale_,
            m_Offset_);
    }

    public override string ToString() => $"UnityTexEnv\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Texture: {m_Texture}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Scale: {{ x: {m_Scale.x}, y: {m_Scale.y} }}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Offset: {{ x: {m_Offset.x}, y: {m_Offset.y} }}\n");
    }
}

/* $BuildTextureStackReference (2 fields) */
public record class BuildTextureStackReference (
    AsciiString groupName,
    AsciiString itemName) : IUnityStructure
{
    public static BuildTextureStackReference Read(EndianBinaryReader reader)
    {
        AsciiString groupName_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* groupName */
        AsciiString itemName_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* itemName */
        
        return new(groupName_,
            itemName_);
    }

    public override string ToString() => $"BuildTextureStackReference\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}groupName: \"{groupName}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}itemName: \"{itemName}\"");
    }
}

/* $ComponentPair (1 fields) */
public record class ComponentPair (
    PPtr<Component> component) : IUnityStructure
{
    public static ComponentPair Read(EndianBinaryReader reader)
    {
        PPtr<Component> component_ = PPtr<Component>.Read(reader);
        
        return new(component_);
    }

    public override string ToString() => $"ComponentPair\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}component: {component}");
    }
}

/* $QualitySetting (47 fields) */
public record class QualitySetting (
    AsciiString name,
    int pixelLightCount,
    int shadows,
    int shadowResolution,
    int shadowProjection,
    int shadowCascades,
    float shadowDistance,
    float shadowNearPlaneOffset,
    float shadowCascade2Split,
    Vector3f shadowCascade4Split,
    int shadowmaskMode,
    int skinWeights,
    int globalTextureMipmapLimit,
    MipmapLimitSettings[] textureMipmapLimitSettings,
    int anisotropicTextures,
    int antiAliasing,
    bool softParticles,
    bool softVegetation,
    bool realtimeReflectionProbes,
    bool billboardsFaceCameraPosition,
    bool useLegacyDetailDistribution,
    int vSyncCount,
    int realtimeGICPUUsage,
    float lodBias,
    int maximumLODLevel,
    bool enableLODCrossFade,
    bool streamingMipmapsActive,
    bool streamingMipmapsAddAllCameras,
    float streamingMipmapsMemoryBudget,
    int streamingMipmapsRenderersPerFrame,
    int streamingMipmapsMaxLevelReduction,
    int streamingMipmapsMaxFileIORequests,
    int particleRaycastBudget,
    int asyncUploadTimeSlice,
    int asyncUploadBufferSize,
    bool asyncUploadPersistentBuffer,
    float resolutionScalingFixedDPIFactor,
    PPtr<MonoBehaviour> customRenderPipeline,
    int terrainQualityOverrides,
    float terrainPixelError,
    float terrainDetailDensityScale,
    float terrainBasemapDistance,
    float terrainDetailDistance,
    float terrainTreeDistance,
    float terrainBillboardStart,
    float terrainFadeLength,
    int terrainMaxTrees) : IUnityStructure
{
    public static QualitySetting Read(EndianBinaryReader reader)
    {
        AsciiString name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* name */
        int pixelLightCount_ = reader.ReadS32();
        int shadows_ = reader.ReadS32();
        int shadowResolution_ = reader.ReadS32();
        int shadowProjection_ = reader.ReadS32();
        int shadowCascades_ = reader.ReadS32();
        float shadowDistance_ = reader.ReadF32();
        float shadowNearPlaneOffset_ = reader.ReadF32();
        float shadowCascade2Split_ = reader.ReadF32();
        Vector3f shadowCascade4Split_ = Vector3f.Read(reader);
        int shadowmaskMode_ = reader.ReadS32();
        int skinWeights_ = reader.ReadS32();
        int globalTextureMipmapLimit_ = reader.ReadS32();
        MipmapLimitSettings[] textureMipmapLimitSettings_ = BuiltInArray<MipmapLimitSettings>.Read(reader);
        reader.AlignTo(4); /* textureMipmapLimitSettings */
        int anisotropicTextures_ = reader.ReadS32();
        int antiAliasing_ = reader.ReadS32();
        bool softParticles_ = reader.ReadBool();
        bool softVegetation_ = reader.ReadBool();
        bool realtimeReflectionProbes_ = reader.ReadBool();
        bool billboardsFaceCameraPosition_ = reader.ReadBool();
        bool useLegacyDetailDistribution_ = reader.ReadBool();
        reader.AlignTo(4); /* useLegacyDetailDistribution */
        int vSyncCount_ = reader.ReadS32();
        int realtimeGICPUUsage_ = reader.ReadS32();
        float lodBias_ = reader.ReadF32();
        int maximumLODLevel_ = reader.ReadS32();
        bool enableLODCrossFade_ = reader.ReadBool();
        bool streamingMipmapsActive_ = reader.ReadBool();
        bool streamingMipmapsAddAllCameras_ = reader.ReadBool();
        reader.AlignTo(4); /* streamingMipmapsAddAllCameras */
        float streamingMipmapsMemoryBudget_ = reader.ReadF32();
        int streamingMipmapsRenderersPerFrame_ = reader.ReadS32();
        int streamingMipmapsMaxLevelReduction_ = reader.ReadS32();
        int streamingMipmapsMaxFileIORequests_ = reader.ReadS32();
        int particleRaycastBudget_ = reader.ReadS32();
        int asyncUploadTimeSlice_ = reader.ReadS32();
        int asyncUploadBufferSize_ = reader.ReadS32();
        bool asyncUploadPersistentBuffer_ = reader.ReadBool();
        reader.AlignTo(4); /* asyncUploadPersistentBuffer */
        float resolutionScalingFixedDPIFactor_ = reader.ReadF32();
        PPtr<MonoBehaviour> customRenderPipeline_ = PPtr<MonoBehaviour>.Read(reader);
        reader.AlignTo(4); /* customRenderPipeline */
        int terrainQualityOverrides_ = reader.ReadS32();
        float terrainPixelError_ = reader.ReadF32();
        float terrainDetailDensityScale_ = reader.ReadF32();
        float terrainBasemapDistance_ = reader.ReadF32();
        float terrainDetailDistance_ = reader.ReadF32();
        float terrainTreeDistance_ = reader.ReadF32();
        float terrainBillboardStart_ = reader.ReadF32();
        float terrainFadeLength_ = reader.ReadF32();
        int terrainMaxTrees_ = reader.ReadS32();
        reader.AlignTo(4); /* terrainMaxTrees */
        
        return new(name_,
            pixelLightCount_,
            shadows_,
            shadowResolution_,
            shadowProjection_,
            shadowCascades_,
            shadowDistance_,
            shadowNearPlaneOffset_,
            shadowCascade2Split_,
            shadowCascade4Split_,
            shadowmaskMode_,
            skinWeights_,
            globalTextureMipmapLimit_,
            textureMipmapLimitSettings_,
            anisotropicTextures_,
            antiAliasing_,
            softParticles_,
            softVegetation_,
            realtimeReflectionProbes_,
            billboardsFaceCameraPosition_,
            useLegacyDetailDistribution_,
            vSyncCount_,
            realtimeGICPUUsage_,
            lodBias_,
            maximumLODLevel_,
            enableLODCrossFade_,
            streamingMipmapsActive_,
            streamingMipmapsAddAllCameras_,
            streamingMipmapsMemoryBudget_,
            streamingMipmapsRenderersPerFrame_,
            streamingMipmapsMaxLevelReduction_,
            streamingMipmapsMaxFileIORequests_,
            particleRaycastBudget_,
            asyncUploadTimeSlice_,
            asyncUploadBufferSize_,
            asyncUploadPersistentBuffer_,
            resolutionScalingFixedDPIFactor_,
            customRenderPipeline_,
            terrainQualityOverrides_,
            terrainPixelError_,
            terrainDetailDensityScale_,
            terrainBasemapDistance_,
            terrainDetailDistance_,
            terrainTreeDistance_,
            terrainBillboardStart_,
            terrainFadeLength_,
            terrainMaxTrees_);
    }

    public override string ToString() => $"QualitySetting\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);
        ToString_Field15(sb, indent, indent_);
        ToString_Field16(sb, indent, indent_);
        ToString_Field17(sb, indent, indent_);
        ToString_Field18(sb, indent, indent_);
        ToString_Field19(sb, indent, indent_);
        ToString_Field20(sb, indent, indent_);
        ToString_Field21(sb, indent, indent_);
        ToString_Field22(sb, indent, indent_);
        ToString_Field23(sb, indent, indent_);
        ToString_Field24(sb, indent, indent_);
        ToString_Field25(sb, indent, indent_);
        ToString_Field26(sb, indent, indent_);
        ToString_Field27(sb, indent, indent_);
        ToString_Field28(sb, indent, indent_);
        ToString_Field29(sb, indent, indent_);
        ToString_Field30(sb, indent, indent_);
        ToString_Field31(sb, indent, indent_);
        ToString_Field32(sb, indent, indent_);
        ToString_Field33(sb, indent, indent_);
        ToString_Field34(sb, indent, indent_);
        ToString_Field35(sb, indent, indent_);
        ToString_Field36(sb, indent, indent_);
        ToString_Field37(sb, indent, indent_);
        ToString_Field38(sb, indent, indent_);
        ToString_Field39(sb, indent, indent_);
        ToString_Field40(sb, indent, indent_);
        ToString_Field41(sb, indent, indent_);
        ToString_Field42(sb, indent, indent_);
        ToString_Field43(sb, indent, indent_);
        ToString_Field44(sb, indent, indent_);
        ToString_Field45(sb, indent, indent_);
        ToString_Field46(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}name: \"{name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}pixelLightCount: {pixelLightCount}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}shadows: {shadows}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}shadowResolution: {shadowResolution}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}shadowProjection: {shadowProjection}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}shadowCascades: {shadowCascades}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}shadowDistance: {shadowDistance}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}shadowNearPlaneOffset: {shadowNearPlaneOffset}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}shadowCascade2Split: {shadowCascade2Split}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}shadowCascade4Split: {{ x: {shadowCascade4Split.x}, y: {shadowCascade4Split.y}, z: {shadowCascade4Split.z} }}\n");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}shadowmaskMode: {shadowmaskMode}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}skinWeights: {skinWeights}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}globalTextureMipmapLimit: {globalTextureMipmapLimit}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}textureMipmapLimitSettings[{textureMipmapLimitSettings.Length}] = {{");
        if (textureMipmapLimitSettings.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (MipmapLimitSettings _4 in textureMipmapLimitSettings)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ limitBiasMode: {_4.limitBiasMode}, limitBias: {_4.limitBias} }}\n");
            ++_4i;
        }
        if (textureMipmapLimitSettings.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}anisotropicTextures: {anisotropicTextures}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}antiAliasing: {antiAliasing}");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}softParticles: {softParticles}");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}softVegetation: {softVegetation}");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}realtimeReflectionProbes: {realtimeReflectionProbes}");
    }

    public void ToString_Field19(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}billboardsFaceCameraPosition: {billboardsFaceCameraPosition}");
    }

    public void ToString_Field20(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}useLegacyDetailDistribution: {useLegacyDetailDistribution}");
    }

    public void ToString_Field21(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}vSyncCount: {vSyncCount}");
    }

    public void ToString_Field22(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}realtimeGICPUUsage: {realtimeGICPUUsage}");
    }

    public void ToString_Field23(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}lodBias: {lodBias}");
    }

    public void ToString_Field24(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}maximumLODLevel: {maximumLODLevel}");
    }

    public void ToString_Field25(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enableLODCrossFade: {enableLODCrossFade}");
    }

    public void ToString_Field26(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}streamingMipmapsActive: {streamingMipmapsActive}");
    }

    public void ToString_Field27(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}streamingMipmapsAddAllCameras: {streamingMipmapsAddAllCameras}");
    }

    public void ToString_Field28(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}streamingMipmapsMemoryBudget: {streamingMipmapsMemoryBudget}");
    }

    public void ToString_Field29(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}streamingMipmapsRenderersPerFrame: {streamingMipmapsRenderersPerFrame}");
    }

    public void ToString_Field30(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}streamingMipmapsMaxLevelReduction: {streamingMipmapsMaxLevelReduction}");
    }

    public void ToString_Field31(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}streamingMipmapsMaxFileIORequests: {streamingMipmapsMaxFileIORequests}");
    }

    public void ToString_Field32(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}particleRaycastBudget: {particleRaycastBudget}");
    }

    public void ToString_Field33(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}asyncUploadTimeSlice: {asyncUploadTimeSlice}");
    }

    public void ToString_Field34(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}asyncUploadBufferSize: {asyncUploadBufferSize}");
    }

    public void ToString_Field35(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}asyncUploadPersistentBuffer: {asyncUploadPersistentBuffer}");
    }

    public void ToString_Field36(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}resolutionScalingFixedDPIFactor: {resolutionScalingFixedDPIFactor}");
    }

    public void ToString_Field37(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}customRenderPipeline: {customRenderPipeline}");
    }

    public void ToString_Field38(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}terrainQualityOverrides: {terrainQualityOverrides}");
    }

    public void ToString_Field39(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}terrainPixelError: {terrainPixelError}");
    }

    public void ToString_Field40(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}terrainDetailDensityScale: {terrainDetailDensityScale}");
    }

    public void ToString_Field41(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}terrainBasemapDistance: {terrainBasemapDistance}");
    }

    public void ToString_Field42(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}terrainDetailDistance: {terrainDetailDistance}");
    }

    public void ToString_Field43(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}terrainTreeDistance: {terrainTreeDistance}");
    }

    public void ToString_Field44(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}terrainBillboardStart: {terrainBillboardStart}");
    }

    public void ToString_Field45(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}terrainFadeLength: {terrainFadeLength}");
    }

    public void ToString_Field46(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}terrainMaxTrees: {terrainMaxTrees}");
    }
}

/* $MipmapLimitSettings (2 fields) */
public readonly record struct MipmapLimitSettings (
    int limitBiasMode,
    int limitBias) : IUnityStructure
{
    public static MipmapLimitSettings Read(EndianBinaryReader reader)
    {
        int limitBiasMode_ = reader.ReadS32();
        int limitBias_ = reader.ReadS32();
        
        return new(limitBiasMode_,
            limitBias_);
    }

    public override string ToString() => $"MipmapLimitSettings\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}limitBiasMode: {limitBiasMode}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}limitBias: {limitBias}");
    }
}

/* $ShadowSettings (9 fields) */
public record class ShadowSettings (
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
        int m_Type_ = reader.ReadS32();
        int m_Resolution_ = reader.ReadS32();
        int m_CustomResolution_ = reader.ReadS32();
        float m_Strength_ = reader.ReadF32();
        float m_Bias_ = reader.ReadF32();
        float m_NormalBias_ = reader.ReadF32();
        float m_NearPlane_ = reader.ReadF32();
        Matrix4x4f m_CullingMatrixOverride_ = Matrix4x4f.Read(reader);
        bool m_UseCullingMatrixOverride_ = reader.ReadBool();
        reader.AlignTo(4); /* m_UseCullingMatrixOverride */
        
        return new(m_Type_,
            m_Resolution_,
            m_CustomResolution_,
            m_Strength_,
            m_Bias_,
            m_NormalBias_,
            m_NearPlane_,
            m_CullingMatrixOverride_,
            m_UseCullingMatrixOverride_);
    }

    public override string ToString() => $"ShadowSettings\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Type: {m_Type}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Resolution: {m_Resolution}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CustomResolution: {m_CustomResolution}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Strength: {m_Strength}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Bias: {m_Bias}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_NormalBias: {m_NormalBias}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_NearPlane: {m_NearPlane}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_CullingMatrixOverride: {{ \n{m_CullingMatrixOverride.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UseCullingMatrixOverride: {m_UseCullingMatrixOverride}");
    }
}

/* $LightBakingOutput (4 fields) */
public record class LightBakingOutput (
    int probeOcclusionLightIndex,
    int occlusionMaskChannel,
    LightmapBakeMode lightmapBakeMode,
    bool isBaked) : IUnityStructure
{
    public static LightBakingOutput Read(EndianBinaryReader reader)
    {
        int probeOcclusionLightIndex_ = reader.ReadS32();
        int occlusionMaskChannel_ = reader.ReadS32();
        LightmapBakeMode lightmapBakeMode_ = LightmapBakeMode.Read(reader);
        bool isBaked_ = reader.ReadBool();
        reader.AlignTo(4); /* isBaked */
        
        return new(probeOcclusionLightIndex_,
            occlusionMaskChannel_,
            lightmapBakeMode_,
            isBaked_);
    }

    public override string ToString() => $"LightBakingOutput\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}probeOcclusionLightIndex: {probeOcclusionLightIndex}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}occlusionMaskChannel: {occlusionMaskChannel}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}lightmapBakeMode: {{ lightmapBakeType: {lightmapBakeMode.lightmapBakeType}, mixedLightingMode: {lightmapBakeMode.mixedLightingMode} }}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}isBaked: {isBaked}");
    }
}

/* $LightmapBakeMode (2 fields) */
public readonly record struct LightmapBakeMode (
    int lightmapBakeType,
    int mixedLightingMode) : IUnityStructure
{
    public static LightmapBakeMode Read(EndianBinaryReader reader)
    {
        int lightmapBakeType_ = reader.ReadS32();
        int mixedLightingMode_ = reader.ReadS32();
        
        return new(lightmapBakeType_,
            mixedLightingMode_);
    }

    public override string ToString() => $"LightmapBakeMode\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}lightmapBakeType: {lightmapBakeType}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}mixedLightingMode: {mixedLightingMode}");
    }
}

/* $QuaternionCurve (2 fields) */
public record class QuaternionCurve (
    AnimationCurve_1 curve,
    AsciiString path) : IUnityStructure
{
    public static QuaternionCurve Read(EndianBinaryReader reader)
    {
        AnimationCurve_1 curve_ = AnimationCurve_1.Read(reader);
        reader.AlignTo(4); /* curve */
        AsciiString path_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* path */
        
        return new(curve_,
            path_);
    }

    public override string ToString() => $"QuaternionCurve\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}curve: {{ \n{curve.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}path: \"{path}\"");
    }
}

/* $AnimationCurve_1 (4 fields) */
public record class AnimationCurve_1 (
    Keyframe_1[] m_Curve,
    int m_PreInfinity,
    int m_PostInfinity,
    int m_RotationOrder) : IUnityStructure
{
    public static AnimationCurve_1 Read(EndianBinaryReader reader)
    {
        Keyframe_1[] m_Curve_ = BuiltInArray<Keyframe_1>.Read(reader);
        reader.AlignTo(4); /* m_Curve */
        int m_PreInfinity_ = reader.ReadS32();
        int m_PostInfinity_ = reader.ReadS32();
        int m_RotationOrder_ = reader.ReadS32();
        
        return new(m_Curve_,
            m_PreInfinity_,
            m_PostInfinity_,
            m_RotationOrder_);
    }

    public override string ToString() => $"AnimationCurve_1\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Curve[{m_Curve.Length}] = {{");
        if (m_Curve.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (Keyframe_1 _4 in m_Curve)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Curve.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PreInfinity: {m_PreInfinity}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PostInfinity: {m_PostInfinity}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RotationOrder: {m_RotationOrder}");
    }
}

/* $Keyframe_1 (7 fields) */
public record class Keyframe_1 (
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
        float time_ = reader.ReadF32();
        Quaternionf @value_ = Quaternionf.Read(reader);
        Quaternionf inSlope_ = Quaternionf.Read(reader);
        Quaternionf outSlope_ = Quaternionf.Read(reader);
        int weightedMode_ = reader.ReadS32();
        Quaternionf inWeight_ = Quaternionf.Read(reader);
        Quaternionf outWeight_ = Quaternionf.Read(reader);
        
        return new(time_,
            @value_,
            inSlope_,
            outSlope_,
            weightedMode_,
            inWeight_,
            outWeight_);
    }

    public override string ToString() => $"Keyframe_1\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}time: {time}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}@value: {{ x: {@value.x}, y: {@value.y}, z: {@value.z}, w: {@value.w} }}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}inSlope: {{ x: {inSlope.x}, y: {inSlope.y}, z: {inSlope.z}, w: {inSlope.w} }}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}outSlope: {{ x: {outSlope.x}, y: {outSlope.y}, z: {outSlope.z}, w: {outSlope.w} }}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}weightedMode: {weightedMode}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}inWeight: {{ x: {inWeight.x}, y: {inWeight.y}, z: {inWeight.z}, w: {inWeight.w} }}\n");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}outWeight: {{ x: {outWeight.x}, y: {outWeight.y}, z: {outWeight.z}, w: {outWeight.w} }}\n");
    }
}

/* $CompressedAnimationCurve (6 fields) */
public record class CompressedAnimationCurve (
    AsciiString m_Path,
    PackedBitVector_1 m_Times,
    PackedBitVector m_Values,
    PackedBitVector_2 m_Slopes,
    int m_PreInfinity,
    int m_PostInfinity) : IUnityStructure
{
    public static CompressedAnimationCurve Read(EndianBinaryReader reader)
    {
        AsciiString m_Path_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Path */
        PackedBitVector_1 m_Times_ = PackedBitVector_1.Read(reader);
        reader.AlignTo(4); /* m_Times */
        PackedBitVector m_Values_ = PackedBitVector.Read(reader);
        reader.AlignTo(4); /* m_Values */
        PackedBitVector_2 m_Slopes_ = PackedBitVector_2.Read(reader);
        reader.AlignTo(4); /* m_Slopes */
        int m_PreInfinity_ = reader.ReadS32();
        int m_PostInfinity_ = reader.ReadS32();
        
        return new(m_Path_,
            m_Times_,
            m_Values_,
            m_Slopes_,
            m_PreInfinity_,
            m_PostInfinity_);
    }

    public override string ToString() => $"CompressedAnimationCurve\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Path: \"{m_Path}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Times: {{ \n{m_Times.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Values: {{ \n{m_Values.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Slopes: {{ \n{m_Slopes.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PreInfinity: {m_PreInfinity}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PostInfinity: {m_PostInfinity}");
    }
}

/* $PackedBitVector (2 fields) */
public record class PackedBitVector (
    uint m_NumItems,
    byte[] m_Data) : IUnityStructure
{
    public static PackedBitVector Read(EndianBinaryReader reader)
    {
        uint m_NumItems_ = reader.ReadU32();
        byte[] m_Data_ = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_Data */
        
        return new(m_NumItems_,
            m_Data_);
    }

    public override string ToString() => $"PackedBitVector\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_NumItems: {m_NumItems}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Data[{m_Data.Length}] = {{");
        if (m_Data.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (byte _4 in m_Data)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_Data.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $Vector3Curve (2 fields) */
public record class Vector3Curve (
    AnimationCurve_2 curve,
    AsciiString path) : IUnityStructure
{
    public static Vector3Curve Read(EndianBinaryReader reader)
    {
        AnimationCurve_2 curve_ = AnimationCurve_2.Read(reader);
        reader.AlignTo(4); /* curve */
        AsciiString path_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* path */
        
        return new(curve_,
            path_);
    }

    public override string ToString() => $"Vector3Curve\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}curve: {{ \n{curve.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}path: \"{path}\"");
    }
}

/* $AnimationCurve_2 (4 fields) */
public record class AnimationCurve_2 (
    Keyframe_2[] m_Curve,
    int m_PreInfinity,
    int m_PostInfinity,
    int m_RotationOrder) : IUnityStructure
{
    public static AnimationCurve_2 Read(EndianBinaryReader reader)
    {
        Keyframe_2[] m_Curve_ = BuiltInArray<Keyframe_2>.Read(reader);
        reader.AlignTo(4); /* m_Curve */
        int m_PreInfinity_ = reader.ReadS32();
        int m_PostInfinity_ = reader.ReadS32();
        int m_RotationOrder_ = reader.ReadS32();
        
        return new(m_Curve_,
            m_PreInfinity_,
            m_PostInfinity_,
            m_RotationOrder_);
    }

    public override string ToString() => $"AnimationCurve_2\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Curve[{m_Curve.Length}] = {{");
        if (m_Curve.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (Keyframe_2 _4 in m_Curve)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Curve.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PreInfinity: {m_PreInfinity}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PostInfinity: {m_PostInfinity}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RotationOrder: {m_RotationOrder}");
    }
}

/* $Keyframe_2 (7 fields) */
public record class Keyframe_2 (
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
        float time_ = reader.ReadF32();
        Vector3f @value_ = Vector3f.Read(reader);
        Vector3f inSlope_ = Vector3f.Read(reader);
        Vector3f outSlope_ = Vector3f.Read(reader);
        int weightedMode_ = reader.ReadS32();
        Vector3f inWeight_ = Vector3f.Read(reader);
        Vector3f outWeight_ = Vector3f.Read(reader);
        
        return new(time_,
            @value_,
            inSlope_,
            outSlope_,
            weightedMode_,
            inWeight_,
            outWeight_);
    }

    public override string ToString() => $"Keyframe_2\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}time: {time}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}@value: {{ x: {@value.x}, y: {@value.y}, z: {@value.z} }}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}inSlope: {{ x: {inSlope.x}, y: {inSlope.y}, z: {inSlope.z} }}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}outSlope: {{ x: {outSlope.x}, y: {outSlope.y}, z: {outSlope.z} }}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}weightedMode: {weightedMode}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}inWeight: {{ x: {inWeight.x}, y: {inWeight.y}, z: {inWeight.z} }}\n");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}outWeight: {{ x: {outWeight.x}, y: {outWeight.y}, z: {outWeight.z} }}\n");
    }
}

/* $FloatCurve (6 fields) */
public record class FloatCurve (
    AnimationCurve curve,
    AsciiString attribute,
    AsciiString path,
    int classID,
    PPtr<MonoScript> script,
    int flags) : IUnityStructure
{
    public static FloatCurve Read(EndianBinaryReader reader)
    {
        AnimationCurve curve_ = AnimationCurve.Read(reader);
        reader.AlignTo(4); /* curve */
        AsciiString attribute_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* attribute */
        AsciiString path_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* path */
        int classID_ = reader.ReadS32();
        PPtr<MonoScript> script_ = PPtr<MonoScript>.Read(reader);
        int flags_ = reader.ReadS32();
        
        return new(curve_,
            attribute_,
            path_,
            classID_,
            script_,
            flags_);
    }

    public override string ToString() => $"FloatCurve\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}curve: {{ \n{curve.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}attribute: \"{attribute}\"");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}path: \"{path}\"");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}classID: {classID}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}script: {script}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}flags: {flags}");
    }
}

/* $PPtrCurve (6 fields) */
public record class PPtrCurve (
    PPtrKeyframe[] curve,
    AsciiString attribute,
    AsciiString path,
    int classID,
    PPtr<MonoScript> script,
    int flags) : IUnityStructure
{
    public static PPtrCurve Read(EndianBinaryReader reader)
    {
        PPtrKeyframe[] curve_ = BuiltInArray<PPtrKeyframe>.Read(reader);
        reader.AlignTo(4); /* curve */
        AsciiString attribute_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* attribute */
        AsciiString path_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* path */
        int classID_ = reader.ReadS32();
        PPtr<MonoScript> script_ = PPtr<MonoScript>.Read(reader);
        int flags_ = reader.ReadS32();
        
        return new(curve_,
            attribute_,
            path_,
            classID_,
            script_,
            flags_);
    }

    public override string ToString() => $"PPtrCurve\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}curve[{curve.Length}] = {{");
        if (curve.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtrKeyframe _4 in curve)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (curve.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}attribute: \"{attribute}\"");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}path: \"{path}\"");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}classID: {classID}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}script: {script}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}flags: {flags}");
    }
}

/* $PPtrKeyframe (2 fields) */
public record class PPtrKeyframe (
    float time,
    PPtr<Object> @value) : IUnityStructure
{
    public static PPtrKeyframe Read(EndianBinaryReader reader)
    {
        float time_ = reader.ReadF32();
        PPtr<Object> @value_ = PPtr<Object>.Read(reader);
        
        return new(time_,
            @value_);
    }

    public override string ToString() => $"PPtrKeyframe\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}time: {time}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}@value: {@value}");
    }
}

/* $ClipMuscleConstant (27 fields) */
public record class ClipMuscleConstant (
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
        HumanPose m_DeltaPose_ = HumanPose.Read(reader);
        xform m_StartX_ = xform.Read(reader);
        xform m_StopX_ = xform.Read(reader);
        xform m_LeftFootStartX_ = xform.Read(reader);
        xform m_RightFootStartX_ = xform.Read(reader);
        float3 m_AverageSpeed_ = float3.Read(reader);
        OffsetPtr_19 m_Clip_ = OffsetPtr_19.Read(reader);
        float m_StartTime_ = reader.ReadF32();
        float m_StopTime_ = reader.ReadF32();
        float m_OrientationOffsetY_ = reader.ReadF32();
        float m_Level_ = reader.ReadF32();
        float m_CycleOffset_ = reader.ReadF32();
        float m_AverageAngularSpeed_ = reader.ReadF32();
        int[] m_IndexArray_ = BuiltInArray<int>.Read(reader);
        ValueDelta[] m_ValueArrayDelta_ = BuiltInArray<ValueDelta>.Read(reader);
        float[] m_ValueArrayReferencePose_ = BuiltInArray<float>.Read(reader);
        bool m_Mirror_ = reader.ReadBool();
        bool m_LoopTime_ = reader.ReadBool();
        bool m_LoopBlend_ = reader.ReadBool();
        bool m_LoopBlendOrientation_ = reader.ReadBool();
        bool m_LoopBlendPositionY_ = reader.ReadBool();
        bool m_LoopBlendPositionXZ_ = reader.ReadBool();
        bool m_StartAtOrigin_ = reader.ReadBool();
        bool m_KeepOriginalOrientation_ = reader.ReadBool();
        bool m_KeepOriginalPositionY_ = reader.ReadBool();
        bool m_KeepOriginalPositionXZ_ = reader.ReadBool();
        bool m_HeightFromFeet_ = reader.ReadBool();
        reader.AlignTo(4); /* m_HeightFromFeet */
        
        return new(m_DeltaPose_,
            m_StartX_,
            m_StopX_,
            m_LeftFootStartX_,
            m_RightFootStartX_,
            m_AverageSpeed_,
            m_Clip_,
            m_StartTime_,
            m_StopTime_,
            m_OrientationOffsetY_,
            m_Level_,
            m_CycleOffset_,
            m_AverageAngularSpeed_,
            m_IndexArray_,
            m_ValueArrayDelta_,
            m_ValueArrayReferencePose_,
            m_Mirror_,
            m_LoopTime_,
            m_LoopBlend_,
            m_LoopBlendOrientation_,
            m_LoopBlendPositionY_,
            m_LoopBlendPositionXZ_,
            m_StartAtOrigin_,
            m_KeepOriginalOrientation_,
            m_KeepOriginalPositionY_,
            m_KeepOriginalPositionXZ_,
            m_HeightFromFeet_);
    }

    public override string ToString() => $"ClipMuscleConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);
        ToString_Field15(sb, indent, indent_);
        ToString_Field16(sb, indent, indent_);
        ToString_Field17(sb, indent, indent_);
        ToString_Field18(sb, indent, indent_);
        ToString_Field19(sb, indent, indent_);
        ToString_Field20(sb, indent, indent_);
        ToString_Field21(sb, indent, indent_);
        ToString_Field22(sb, indent, indent_);
        ToString_Field23(sb, indent, indent_);
        ToString_Field24(sb, indent, indent_);
        ToString_Field25(sb, indent, indent_);
        ToString_Field26(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_DeltaPose: {{ \n{m_DeltaPose.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_StartX: {{ \n{m_StartX.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_StopX: {{ \n{m_StopX.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_LeftFootStartX: {{ \n{m_LeftFootStartX.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_RightFootStartX: {{ \n{m_RightFootStartX.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_AverageSpeed: {{ x: {m_AverageSpeed.x}, y: {m_AverageSpeed.y}, z: {m_AverageSpeed.z} }}\n");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Clip: {{ \n{m_Clip.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_StartTime: {m_StartTime}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_StopTime: {m_StopTime}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_OrientationOffsetY: {m_OrientationOffsetY}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Level: {m_Level}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CycleOffset: {m_CycleOffset}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_AverageAngularSpeed: {m_AverageAngularSpeed}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_IndexArray[{m_IndexArray.Length}] = {{");
        if (m_IndexArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (int _4 in m_IndexArray)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_IndexArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ValueArrayDelta[{m_ValueArrayDelta.Length}] = {{");
        if (m_ValueArrayDelta.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (ValueDelta _4 in m_ValueArrayDelta)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ m_Start: {_4.m_Start}, m_Stop: {_4.m_Stop} }}\n");
            ++_4i;
        }
        if (m_ValueArrayDelta.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ValueArrayReferencePose[{m_ValueArrayReferencePose.Length}] = {{");
        if (m_ValueArrayReferencePose.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (float _4 in m_ValueArrayReferencePose)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_ValueArrayReferencePose.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Mirror: {m_Mirror}");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LoopTime: {m_LoopTime}");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LoopBlend: {m_LoopBlend}");
    }

    public void ToString_Field19(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LoopBlendOrientation: {m_LoopBlendOrientation}");
    }

    public void ToString_Field20(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LoopBlendPositionY: {m_LoopBlendPositionY}");
    }

    public void ToString_Field21(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LoopBlendPositionXZ: {m_LoopBlendPositionXZ}");
    }

    public void ToString_Field22(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_StartAtOrigin: {m_StartAtOrigin}");
    }

    public void ToString_Field23(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_KeepOriginalOrientation: {m_KeepOriginalOrientation}");
    }

    public void ToString_Field24(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_KeepOriginalPositionY: {m_KeepOriginalPositionY}");
    }

    public void ToString_Field25(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_KeepOriginalPositionXZ: {m_KeepOriginalPositionXZ}");
    }

    public void ToString_Field26(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_HeightFromFeet: {m_HeightFromFeet}");
    }
}

/* $HumanPose (8 fields) */
public record class HumanPose (
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
        xform m_RootX_ = xform.Read(reader);
        float3 m_LookAtPosition_ = float3.Read(reader);
        float4 m_LookAtWeight_ = float4.Read(reader);
        HumanGoal[] m_GoalArray_ = BuiltInArray<HumanGoal>.Read(reader);
        HandPose m_LeftHandPose_ = HandPose.Read(reader);
        HandPose m_RightHandPose_ = HandPose.Read(reader);
        float[] m_DoFArray_ = BuiltInArray<float>.Read(reader);
        float3[] m_TDoFArray_ = BuiltInArray<float3>.Read(reader);
        
        return new(m_RootX_,
            m_LookAtPosition_,
            m_LookAtWeight_,
            m_GoalArray_,
            m_LeftHandPose_,
            m_RightHandPose_,
            m_DoFArray_,
            m_TDoFArray_);
    }

    public override string ToString() => $"HumanPose\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_RootX: {{ \n{m_RootX.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_LookAtPosition: {{ x: {m_LookAtPosition.x}, y: {m_LookAtPosition.y}, z: {m_LookAtPosition.z} }}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_LookAtWeight: {{ x: {m_LookAtWeight.x}, y: {m_LookAtWeight.y}, z: {m_LookAtWeight.z}, w: {m_LookAtWeight.w} }}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_GoalArray[{m_GoalArray.Length}] = {{");
        if (m_GoalArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (HumanGoal _4 in m_GoalArray)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_GoalArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_LeftHandPose: {{ \n{m_LeftHandPose.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_RightHandPose: {{ \n{m_RightHandPose.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_DoFArray[{m_DoFArray.Length}] = {{");
        if (m_DoFArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (float _4 in m_DoFArray)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_DoFArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_TDoFArray[{m_TDoFArray.Length}] = {{");
        if (m_TDoFArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (float3 _4 in m_TDoFArray)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ x: {_4.x}, y: {_4.y}, z: {_4.z} }}\n");
            ++_4i;
        }
        if (m_TDoFArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $HumanGoal (5 fields) */
public record class HumanGoal (
    xform m_X,
    float m_WeightT,
    float m_WeightR,
    float3 m_HintT,
    float m_HintWeightT) : IUnityStructure
{
    public static HumanGoal Read(EndianBinaryReader reader)
    {
        xform m_X_ = xform.Read(reader);
        float m_WeightT_ = reader.ReadF32();
        float m_WeightR_ = reader.ReadF32();
        float3 m_HintT_ = float3.Read(reader);
        float m_HintWeightT_ = reader.ReadF32();
        
        return new(m_X_,
            m_WeightT_,
            m_WeightR_,
            m_HintT_,
            m_HintWeightT_);
    }

    public override string ToString() => $"HumanGoal\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_X: {{ \n{m_X.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_WeightT: {m_WeightT}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_WeightR: {m_WeightR}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_HintT: {{ x: {m_HintT.x}, y: {m_HintT.y}, z: {m_HintT.z} }}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_HintWeightT: {m_HintWeightT}");
    }
}

/* $HandPose (6 fields) */
public record class HandPose (
    xform m_GrabX,
    float[] m_DoFArray,
    float m_Override,
    float m_CloseOpen,
    float m_InOut,
    float m_Grab) : IUnityStructure
{
    public static HandPose Read(EndianBinaryReader reader)
    {
        xform m_GrabX_ = xform.Read(reader);
        float[] m_DoFArray_ = BuiltInArray<float>.Read(reader);
        float m_Override_ = reader.ReadF32();
        float m_CloseOpen_ = reader.ReadF32();
        float m_InOut_ = reader.ReadF32();
        float m_Grab_ = reader.ReadF32();
        
        return new(m_GrabX_,
            m_DoFArray_,
            m_Override_,
            m_CloseOpen_,
            m_InOut_,
            m_Grab_);
    }

    public override string ToString() => $"HandPose\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_GrabX: {{ \n{m_GrabX.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_DoFArray[{m_DoFArray.Length}] = {{");
        if (m_DoFArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (float _4 in m_DoFArray)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_DoFArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Override: {m_Override}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CloseOpen: {m_CloseOpen}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_InOut: {m_InOut}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Grab: {m_Grab}");
    }
}

/* $OffsetPtr_19 (1 fields) */
public record class OffsetPtr_19 (
    Clip data) : IUnityStructure
{
    public static OffsetPtr_19 Read(EndianBinaryReader reader)
    {
        Clip data_ = Clip.Read(reader);
        
        return new(data_);
    }

    public override string ToString() => $"OffsetPtr_19\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}data: {{ \n{data.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $Clip (3 fields) */
public record class Clip (
    StreamedClip m_StreamedClip,
    DenseClip m_DenseClip,
    ConstantClip m_ConstantClip) : IUnityStructure
{
    public static Clip Read(EndianBinaryReader reader)
    {
        StreamedClip m_StreamedClip_ = StreamedClip.Read(reader);
        DenseClip m_DenseClip_ = DenseClip.Read(reader);
        ConstantClip m_ConstantClip_ = ConstantClip.Read(reader);
        
        return new(m_StreamedClip_,
            m_DenseClip_,
            m_ConstantClip_);
    }

    public override string ToString() => $"Clip\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_StreamedClip: {{ \n{m_StreamedClip.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_DenseClip: {{ \n{m_DenseClip.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ConstantClip: {{ \n{m_ConstantClip.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $StreamedClip (2 fields) */
public record class StreamedClip (
    uint[] data,
    uint curveCount) : IUnityStructure
{
    public static StreamedClip Read(EndianBinaryReader reader)
    {
        uint[] data_ = BuiltInArray<uint>.Read(reader);
        uint curveCount_ = reader.ReadU32();
        
        return new(data_,
            curveCount_);
    }

    public override string ToString() => $"StreamedClip\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}data[{data.Length}] = {{");
        if (data.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint _4 in data)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (data.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}curveCount: {curveCount}");
    }
}

/* $DenseClip (5 fields) */
public record class DenseClip (
    int m_FrameCount,
    uint m_CurveCount,
    float m_SampleRate,
    float m_BeginTime,
    float[] m_SampleArray) : IUnityStructure
{
    public static DenseClip Read(EndianBinaryReader reader)
    {
        int m_FrameCount_ = reader.ReadS32();
        uint m_CurveCount_ = reader.ReadU32();
        float m_SampleRate_ = reader.ReadF32();
        float m_BeginTime_ = reader.ReadF32();
        float[] m_SampleArray_ = BuiltInArray<float>.Read(reader);
        
        return new(m_FrameCount_,
            m_CurveCount_,
            m_SampleRate_,
            m_BeginTime_,
            m_SampleArray_);
    }

    public override string ToString() => $"DenseClip\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_FrameCount: {m_FrameCount}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CurveCount: {m_CurveCount}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SampleRate: {m_SampleRate}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BeginTime: {m_BeginTime}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_SampleArray[{m_SampleArray.Length}] = {{");
        if (m_SampleArray.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (float _4 in m_SampleArray)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_SampleArray.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $ConstantClip (1 fields) */
public record class ConstantClip (
    float[] data) : IUnityStructure
{
    public static ConstantClip Read(EndianBinaryReader reader)
    {
        float[] data_ = BuiltInArray<float>.Read(reader);
        
        return new(data_);
    }

    public override string ToString() => $"ConstantClip\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}data[{data.Length}] = {{");
        if (data.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (float _4 in data)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (data.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $ValueDelta (2 fields) */
public readonly record struct ValueDelta (
    float m_Start,
    float m_Stop) : IUnityStructure
{
    public static ValueDelta Read(EndianBinaryReader reader)
    {
        float m_Start_ = reader.ReadF32();
        float m_Stop_ = reader.ReadF32();
        
        return new(m_Start_,
            m_Stop_);
    }

    public override string ToString() => $"ValueDelta\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Start: {m_Start}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Stop: {m_Stop}");
    }
}

/* $AnimationClipBindingConstant (2 fields) */
public record class AnimationClipBindingConstant (
    GenericBinding[] genericBindings,
    PPtr<Object>[] pptrCurveMapping) : IUnityStructure
{
    public static AnimationClipBindingConstant Read(EndianBinaryReader reader)
    {
        GenericBinding[] genericBindings_ = BuiltInArray<GenericBinding>.Read(reader);
        reader.AlignTo(4); /* genericBindings */
        PPtr<Object>[] pptrCurveMapping_ = BuiltInArray<PPtr<Object>>.Read(reader);
        reader.AlignTo(4); /* pptrCurveMapping */
        
        return new(genericBindings_,
            pptrCurveMapping_);
    }

    public override string ToString() => $"AnimationClipBindingConstant\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}genericBindings[{genericBindings.Length}] = {{");
        if (genericBindings.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (GenericBinding _4 in genericBindings)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (genericBindings.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}pptrCurveMapping[{pptrCurveMapping.Length}] = {{");
        if (pptrCurveMapping.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtr<Object> _4 in pptrCurveMapping)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (pptrCurveMapping.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $GenericBinding (8 fields) */
public record class GenericBinding (
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
        uint path_ = reader.ReadU32();
        uint attribute_ = reader.ReadU32();
        PPtr<Object> script_ = PPtr<Object>.Read(reader);
        int typeID_ = reader.ReadS32();
        byte customType_ = reader.ReadU8();
        byte isPPtrCurve_ = reader.ReadU8();
        byte isIntCurve_ = reader.ReadU8();
        byte isSerializeReferenceCurve_ = reader.ReadU8();
        reader.AlignTo(4); /* isSerializeReferenceCurve */
        
        return new(path_,
            attribute_,
            script_,
            typeID_,
            customType_,
            isPPtrCurve_,
            isIntCurve_,
            isSerializeReferenceCurve_);
    }

    public override string ToString() => $"GenericBinding\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}path: {path}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}attribute: {attribute}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}script: {script}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}typeID: {typeID}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}customType: {customType}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}isPPtrCurve: {isPPtrCurve}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}isIntCurve: {isIntCurve}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}isSerializeReferenceCurve: {isSerializeReferenceCurve}");
    }
}

/* $AnimationEvent (7 fields) */
public record class AnimationEvent (
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
        float time_ = reader.ReadF32();
        AsciiString functionName_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* functionName */
        AsciiString data_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* data */
        PPtr<Object> objectReferenceParameter_ = PPtr<Object>.Read(reader);
        float floatParameter_ = reader.ReadF32();
        int intParameter_ = reader.ReadS32();
        int messageOptions_ = reader.ReadS32();
        
        return new(time_,
            functionName_,
            data_,
            objectReferenceParameter_,
            floatParameter_,
            intParameter_,
            messageOptions_);
    }

    public override string ToString() => $"AnimationEvent\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}time: {time}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}functionName: \"{functionName}\"");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}data: \"{data}\"");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}objectReferenceParameter: {objectReferenceParameter}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}floatParameter: {floatParameter}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}intParameter: {intParameter}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}messageOptions: {messageOptions}");
    }
}

/* $SortingLayerEntry (2 fields) */
public record class SortingLayerEntry (
    AsciiString name,
    uint uniqueID) : IUnityStructure
{
    public static SortingLayerEntry Read(EndianBinaryReader reader)
    {
        AsciiString name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* name */
        uint uniqueID_ = reader.ReadU32();
        reader.AlignTo(4); /* uniqueID */
        
        return new(name_,
            uniqueID_);
    }

    public override string ToString() => $"SortingLayerEntry\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}name: \"{name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}uniqueID: {uniqueID}");
    }
}

/* $DirectorGenericBinding (2 fields) */
public record class DirectorGenericBinding (
    PPtr<Object> key,
    PPtr<Object> @value) : IUnityStructure
{
    public static DirectorGenericBinding Read(EndianBinaryReader reader)
    {
        PPtr<Object> key_ = PPtr<Object>.Read(reader);
        PPtr<Object> @value_ = PPtr<Object>.Read(reader);
        
        return new(key_,
            @value_);
    }

    public override string ToString() => $"DirectorGenericBinding\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}key: {key}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}@value: {@value}");
    }
}

/* $ExposedReferenceTable (1 fields) */
public record class ExposedReferenceTable (
    Dictionary<AsciiString, PPtr<Object>> m_References) : IUnityStructure
{
    public static ExposedReferenceTable Read(EndianBinaryReader reader)
    {
        Dictionary<AsciiString, PPtr<Object>> m_References_ = BuiltInMap<AsciiString, PPtr<Object>>.Read(reader);
        reader.AlignTo(4); /* m_References */
        
        return new(m_References_);
    }

    public override string ToString() => $"ExposedReferenceTable\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_References[{m_References.Count}] = {{");
        if (m_References.Count > 0) sb.AppendLine();
        int _4i = 0;
        foreach (KeyValuePair<AsciiString, PPtr<Object>> _4 in m_References)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[\"{_4.Key}\"] = {_4.Value}");
            ++_4i;
        }
        if (m_References.Count > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $CrashReportingSettings (3 fields) */
public record class CrashReportingSettings (
    AsciiString m_EventUrl,
    bool m_Enabled,
    uint m_LogBufferSize) : IUnityStructure
{
    public static CrashReportingSettings Read(EndianBinaryReader reader)
    {
        AsciiString m_EventUrl_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_EventUrl */
        bool m_Enabled_ = reader.ReadBool();
        reader.AlignTo(4); /* m_Enabled */
        uint m_LogBufferSize_ = reader.ReadU32();
        reader.AlignTo(4); /* m_LogBufferSize */
        
        return new(m_EventUrl_,
            m_Enabled_,
            m_LogBufferSize_);
    }

    public override string ToString() => $"CrashReportingSettings\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_EventUrl: \"{m_EventUrl}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Enabled: {m_Enabled}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LogBufferSize: {m_LogBufferSize}");
    }
}

/* $UnityPurchasingSettings (2 fields) */
public readonly record struct UnityPurchasingSettings (
    bool m_Enabled,
    bool m_TestMode) : IUnityStructure
{
    public static UnityPurchasingSettings Read(EndianBinaryReader reader)
    {
        bool m_Enabled_ = reader.ReadBool();
        bool m_TestMode_ = reader.ReadBool();
        reader.AlignTo(4); /* m_TestMode */
        
        return new(m_Enabled_,
            m_TestMode_);
    }

    public override string ToString() => $"UnityPurchasingSettings\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Enabled: {m_Enabled}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TestMode: {m_TestMode}");
    }
}

/* $UnityAnalyticsSettings (4 fields) */
public readonly record struct UnityAnalyticsSettings (
    bool m_Enabled,
    bool m_TestMode,
    bool m_InitializeOnStartup,
    bool m_PackageRequiringCoreStatsPresent) : IUnityStructure
{
    public static UnityAnalyticsSettings Read(EndianBinaryReader reader)
    {
        bool m_Enabled_ = reader.ReadBool();
        bool m_TestMode_ = reader.ReadBool();
        bool m_InitializeOnStartup_ = reader.ReadBool();
        bool m_PackageRequiringCoreStatsPresent_ = reader.ReadBool();
        reader.AlignTo(4); /* m_PackageRequiringCoreStatsPresent */
        
        return new(m_Enabled_,
            m_TestMode_,
            m_InitializeOnStartup_,
            m_PackageRequiringCoreStatsPresent_);
    }

    public override string ToString() => $"UnityAnalyticsSettings\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Enabled: {m_Enabled}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TestMode: {m_TestMode}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_InitializeOnStartup: {m_InitializeOnStartup}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PackageRequiringCoreStatsPresent: {m_PackageRequiringCoreStatsPresent}");
    }
}

/* $UnityAdsSettings (4 fields) */
public record class UnityAdsSettings (
    bool m_Enabled,
    bool m_InitializeOnStartup,
    bool m_TestMode,
    AsciiString m_GameId) : IUnityStructure
{
    public static UnityAdsSettings Read(EndianBinaryReader reader)
    {
        bool m_Enabled_ = reader.ReadBool();
        bool m_InitializeOnStartup_ = reader.ReadBool();
        bool m_TestMode_ = reader.ReadBool();
        reader.AlignTo(4); /* m_TestMode */
        AsciiString m_GameId_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_GameId */
        
        return new(m_Enabled_,
            m_InitializeOnStartup_,
            m_TestMode_,
            m_GameId_);
    }

    public override string ToString() => $"UnityAdsSettings\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Enabled: {m_Enabled}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_InitializeOnStartup: {m_InitializeOnStartup}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TestMode: {m_TestMode}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_GameId: \"{m_GameId}\"");
    }
}

/* $PerformanceReportingSettings (1 fields) */
public readonly record struct PerformanceReportingSettings (
    bool m_Enabled) : IUnityStructure
{
    public static PerformanceReportingSettings Read(EndianBinaryReader reader)
    {
        bool m_Enabled_ = reader.ReadBool();
        reader.AlignTo(4); /* m_Enabled */
        
        return new(m_Enabled_);
    }

    public override string ToString() => $"PerformanceReportingSettings\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Enabled: {m_Enabled}");
    }
}

/* $NameToObjectMap (1 fields) */
public record class NameToObjectMap (
    Dictionary<PPtr<Shader>, AsciiString> m_ObjectToName) : IUnityStructure
{
    public static NameToObjectMap Read(EndianBinaryReader reader)
    {
        Dictionary<PPtr<Shader>, AsciiString> m_ObjectToName_ = BuiltInMap<PPtr<Shader>, AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_ObjectToName */
        
        return new(m_ObjectToName_);
    }

    public override string ToString() => $"NameToObjectMap\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ObjectToName[{m_ObjectToName.Count}] = {{");
        if (m_ObjectToName.Count > 0) sb.AppendLine();
        int _4i = 0;
        foreach (KeyValuePair<PPtr<Shader>, AsciiString> _4 in m_ObjectToName)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4.Key}] = \"{_4.Value}\"");
            ++_4i;
        }
        if (m_ObjectToName.Count > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $SplashScreenLogo (2 fields) */
public record class SplashScreenLogo (
    PPtr<Sprite> logo,
    float duration) : IUnityStructure
{
    public static SplashScreenLogo Read(EndianBinaryReader reader)
    {
        PPtr<Sprite> logo_ = PPtr<Sprite>.Read(reader);
        float duration_ = reader.ReadF32();
        reader.AlignTo(4); /* duration */
        
        return new(logo_,
            duration_);
    }

    public override string ToString() => $"SplashScreenLogo\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}logo: {logo}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}duration: {duration}");
    }
}

/* $VRSettings (1 fields) */
public readonly record struct VRSettings (
    bool enable360StereoCapture) : IUnityStructure
{
    public static VRSettings Read(EndianBinaryReader reader)
    {
        bool enable360StereoCapture_ = reader.ReadBool();
        reader.AlignTo(4); /* enable360StereoCapture */
        
        return new(enable360StereoCapture_);
    }

    public override string ToString() => $"VRSettings\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enable360StereoCapture: {enable360StereoCapture}");
    }
}

/* $SpriteRenderData (13 fields) */
public record class SpriteRenderData (
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
        PPtr<Texture2D> texture_ = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> alphaTexture_ = PPtr<Texture2D>.Read(reader);
        SecondarySpriteTexture[] secondaryTextures_ = BuiltInArray<SecondarySpriteTexture>.Read(reader);
        reader.AlignTo(4); /* secondaryTextures */
        SubMesh[] m_SubMeshes_ = BuiltInArray<SubMesh>.Read(reader);
        reader.AlignTo(4); /* m_SubMeshes */
        byte[] m_IndexBuffer_ = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_IndexBuffer */
        VertexData m_VertexData_ = VertexData.Read(reader);
        reader.AlignTo(4); /* m_VertexData */
        Matrix4x4f[] m_Bindpose_ = BuiltInArray<Matrix4x4f>.Read(reader);
        reader.AlignTo(4); /* m_Bindpose */
        Rectf textureRect_ = Rectf.Read(reader);
        Vector2f textureRectOffset_ = Vector2f.Read(reader);
        Vector2f atlasRectOffset_ = Vector2f.Read(reader);
        uint settingsRaw_ = reader.ReadU32();
        Vector4f uvTransform_ = Vector4f.Read(reader);
        float downscaleMultiplier_ = reader.ReadF32();
        
        return new(texture_,
            alphaTexture_,
            secondaryTextures_,
            m_SubMeshes_,
            m_IndexBuffer_,
            m_VertexData_,
            m_Bindpose_,
            textureRect_,
            textureRectOffset_,
            atlasRectOffset_,
            settingsRaw_,
            uvTransform_,
            downscaleMultiplier_);
    }

    public override string ToString() => $"SpriteRenderData\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}texture: {texture}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}alphaTexture: {alphaTexture}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}secondaryTextures[{secondaryTextures.Length}] = {{");
        if (secondaryTextures.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (SecondarySpriteTexture _4 in secondaryTextures)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (secondaryTextures.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_SubMeshes[{m_SubMeshes.Length}] = {{");
        if (m_SubMeshes.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (SubMesh _4 in m_SubMeshes)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_SubMeshes.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_IndexBuffer[{m_IndexBuffer.Length}] = {{");
        if (m_IndexBuffer.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (byte _4 in m_IndexBuffer)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_IndexBuffer.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_VertexData: {{ \n{m_VertexData.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Bindpose[{m_Bindpose.Length}] = {{");
        if (m_Bindpose.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (Matrix4x4f _4 in m_Bindpose)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Bindpose.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}textureRect: {{ x: {textureRect.x}, y: {textureRect.y}, width: {textureRect.width}, height: {textureRect.height} }}\n");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}textureRectOffset: {{ x: {textureRectOffset.x}, y: {textureRectOffset.y} }}\n");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}atlasRectOffset: {{ x: {atlasRectOffset.x}, y: {atlasRectOffset.y} }}\n");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}settingsRaw: {settingsRaw}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}uvTransform: {{ x: {uvTransform.x}, y: {uvTransform.y}, z: {uvTransform.z}, w: {uvTransform.w} }}\n");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}downscaleMultiplier: {downscaleMultiplier}");
    }
}

/* $SpriteBone (7 fields) */
public record class SpriteBone (
    AsciiString name,
    AsciiString guid,
    Vector3f position,
    Quaternionf rotation,
    float length,
    int parentId,
    ColorRGBA color) : IUnityStructure
{
    public static SpriteBone Read(EndianBinaryReader reader)
    {
        AsciiString name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* name */
        AsciiString guid_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* guid */
        Vector3f position_ = Vector3f.Read(reader);
        Quaternionf rotation_ = Quaternionf.Read(reader);
        float length_ = reader.ReadF32();
        int parentId_ = reader.ReadS32();
        ColorRGBA color_ = ColorRGBA.Read(reader);
        
        return new(name_,
            guid_,
            position_,
            rotation_,
            length_,
            parentId_,
            color_);
    }

    public override string ToString() => $"SpriteBone\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}name: \"{name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}guid: \"{guid}\"");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}position: {{ x: {position.x}, y: {position.y}, z: {position.z} }}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}rotation: {{ x: {rotation.x}, y: {rotation.y}, z: {rotation.z}, w: {rotation.w} }}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}length: {length}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}parentId: {parentId}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}color: {{ rgba: {color.rgba} }}\n");
    }
}

/* $ColorRGBA (1 fields) */
public readonly record struct ColorRGBA (
    uint rgba) : IUnityStructure
{
    public static ColorRGBA Read(EndianBinaryReader reader)
    {
        uint rgba_ = reader.ReadU32();
        
        return new(rgba_);
    }

    public override string ToString() => $"ColorRGBA\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}rgba: {rgba}");
    }
}

/* $SplatDatabase (4 fields) */
public record class SplatDatabase (
    PPtr<TerrainLayer>[] m_TerrainLayers,
    PPtr<Texture2D>[] m_AlphaTextures,
    int m_AlphamapResolution,
    int m_BaseMapResolution) : IUnityStructure
{
    public static SplatDatabase Read(EndianBinaryReader reader)
    {
        PPtr<TerrainLayer>[] m_TerrainLayers_ = BuiltInArray<PPtr<TerrainLayer>>.Read(reader);
        reader.AlignTo(4); /* m_TerrainLayers */
        PPtr<Texture2D>[] m_AlphaTextures_ = BuiltInArray<PPtr<Texture2D>>.Read(reader);
        reader.AlignTo(4); /* m_AlphaTextures */
        int m_AlphamapResolution_ = reader.ReadS32();
        int m_BaseMapResolution_ = reader.ReadS32();
        
        return new(m_TerrainLayers_,
            m_AlphaTextures_,
            m_AlphamapResolution_,
            m_BaseMapResolution_);
    }

    public override string ToString() => $"SplatDatabase\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_TerrainLayers[{m_TerrainLayers.Length}] = {{");
        if (m_TerrainLayers.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtr<TerrainLayer> _4 in m_TerrainLayers)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_TerrainLayers.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_AlphaTextures[{m_AlphaTextures.Length}] = {{");
        if (m_AlphaTextures.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtr<Texture2D> _4 in m_AlphaTextures)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_AlphaTextures.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_AlphamapResolution: {m_AlphamapResolution}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BaseMapResolution: {m_BaseMapResolution}");
    }
}

/* $DetailDatabase (15 fields) */
public record class DetailDatabase (
    DetailPatch[] m_Patches,
    DetailPrototype[] m_DetailPrototypes,
    int m_PatchCount,
    int m_PatchSamples,
    ColorRGBA_1 WavingGrassTint,
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
        DetailPatch[] m_Patches_ = BuiltInArray<DetailPatch>.Read(reader);
        reader.AlignTo(4); /* m_Patches */
        DetailPrototype[] m_DetailPrototypes_ = BuiltInArray<DetailPrototype>.Read(reader);
        reader.AlignTo(4); /* m_DetailPrototypes */
        int m_PatchCount_ = reader.ReadS32();
        int m_PatchSamples_ = reader.ReadS32();
        ColorRGBA_1 WavingGrassTint_ = ColorRGBA_1.Read(reader);
        float m_WavingGrassStrength_ = reader.ReadF32();
        float m_WavingGrassAmount_ = reader.ReadF32();
        float m_WavingGrassSpeed_ = reader.ReadF32();
        int m_DetailScatterMode_ = reader.ReadS32();
        TreeInstance[] m_TreeInstances_ = BuiltInArray<TreeInstance>.Read(reader);
        reader.AlignTo(4); /* m_TreeInstances */
        TreePrototype[] m_TreePrototypes_ = BuiltInArray<TreePrototype>.Read(reader);
        reader.AlignTo(4); /* m_TreePrototypes */
        PPtr<Texture2D>[] m_PreloadTextureAtlasData_ = BuiltInArray<PPtr<Texture2D>>.Read(reader);
        reader.AlignTo(4); /* m_PreloadTextureAtlasData */
        PPtr<Shader> m_DefaultShaders_0_ = PPtr<Shader>.Read(reader);
        PPtr<Shader> m_DefaultShaders_1_ = PPtr<Shader>.Read(reader);
        PPtr<Shader> m_DefaultShaders_2_ = PPtr<Shader>.Read(reader);
        
        return new(m_Patches_,
            m_DetailPrototypes_,
            m_PatchCount_,
            m_PatchSamples_,
            WavingGrassTint_,
            m_WavingGrassStrength_,
            m_WavingGrassAmount_,
            m_WavingGrassSpeed_,
            m_DetailScatterMode_,
            m_TreeInstances_,
            m_TreePrototypes_,
            m_PreloadTextureAtlasData_,
            m_DefaultShaders_0_,
            m_DefaultShaders_1_,
            m_DefaultShaders_2_);
    }

    public override string ToString() => $"DetailDatabase\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Patches[{m_Patches.Length}] = {{");
        if (m_Patches.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (DetailPatch _4 in m_Patches)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Patches.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_DetailPrototypes[{m_DetailPrototypes.Length}] = {{");
        if (m_DetailPrototypes.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (DetailPrototype _4 in m_DetailPrototypes)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_DetailPrototypes.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PatchCount: {m_PatchCount}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PatchSamples: {m_PatchSamples}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}WavingGrassTint: {{ r: {WavingGrassTint.r}, g: {WavingGrassTint.g}, b: {WavingGrassTint.b}, a: {WavingGrassTint.a} }}\n");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_WavingGrassStrength: {m_WavingGrassStrength}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_WavingGrassAmount: {m_WavingGrassAmount}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_WavingGrassSpeed: {m_WavingGrassSpeed}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DetailScatterMode: {m_DetailScatterMode}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_TreeInstances[{m_TreeInstances.Length}] = {{");
        if (m_TreeInstances.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (TreeInstance _4 in m_TreeInstances)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_TreeInstances.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_TreePrototypes[{m_TreePrototypes.Length}] = {{");
        if (m_TreePrototypes.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (TreePrototype _4 in m_TreePrototypes)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_TreePrototypes.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_PreloadTextureAtlasData[{m_PreloadTextureAtlasData.Length}] = {{");
        if (m_PreloadTextureAtlasData.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtr<Texture2D> _4 in m_PreloadTextureAtlasData)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_PreloadTextureAtlasData.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DefaultShaders_0: {m_DefaultShaders_0}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DefaultShaders_1: {m_DefaultShaders_1}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DefaultShaders_2: {m_DefaultShaders_2}");
    }
}

/* $DetailPatch (2 fields) */
public record class DetailPatch (
    byte[] layerIndices,
    byte[] coverage) : IUnityStructure
{
    public static DetailPatch Read(EndianBinaryReader reader)
    {
        byte[] layerIndices_ = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* layerIndices */
        byte[] coverage_ = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* coverage */
        
        return new(layerIndices_,
            coverage_);
    }

    public override string ToString() => $"DetailPatch\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}layerIndices[{layerIndices.Length}] = {{");
        if (layerIndices.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (byte _4 in layerIndices)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (layerIndices.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}coverage[{coverage.Length}] = {{");
        if (coverage.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (byte _4 in coverage)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (coverage.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $DetailPrototype (19 fields) */
public record class DetailPrototype (
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
    ColorRGBA_1 healthyColor,
    ColorRGBA_1 dryColor,
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
        PPtr<GameObject> prototype_ = PPtr<GameObject>.Read(reader);
        PPtr<Texture2D> prototypeTexture_ = PPtr<Texture2D>.Read(reader);
        float minWidth_ = reader.ReadF32();
        float maxWidth_ = reader.ReadF32();
        float minHeight_ = reader.ReadF32();
        float maxHeight_ = reader.ReadF32();
        int noiseSeed_ = reader.ReadS32();
        float noiseSpread_ = reader.ReadF32();
        float holeTestRadius_ = reader.ReadF32();
        float density_ = reader.ReadF32();
        ColorRGBA_1 healthyColor_ = ColorRGBA_1.Read(reader);
        ColorRGBA_1 dryColor_ = ColorRGBA_1.Read(reader);
        int renderMode_ = reader.ReadS32();
        int usePrototypeMesh_ = reader.ReadS32();
        int useInstancing_ = reader.ReadS32();
        int useDensityScaling_ = reader.ReadS32();
        float alignToGround_ = reader.ReadF32();
        float positionJitter_ = reader.ReadF32();
        float targetCoverage_ = reader.ReadF32();
        
        return new(prototype_,
            prototypeTexture_,
            minWidth_,
            maxWidth_,
            minHeight_,
            maxHeight_,
            noiseSeed_,
            noiseSpread_,
            holeTestRadius_,
            density_,
            healthyColor_,
            dryColor_,
            renderMode_,
            usePrototypeMesh_,
            useInstancing_,
            useDensityScaling_,
            alignToGround_,
            positionJitter_,
            targetCoverage_);
    }

    public override string ToString() => $"DetailPrototype\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);
        ToString_Field15(sb, indent, indent_);
        ToString_Field16(sb, indent, indent_);
        ToString_Field17(sb, indent, indent_);
        ToString_Field18(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}prototype: {prototype}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}prototypeTexture: {prototypeTexture}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}minWidth: {minWidth}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}maxWidth: {maxWidth}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}minHeight: {minHeight}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}maxHeight: {maxHeight}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}noiseSeed: {noiseSeed}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}noiseSpread: {noiseSpread}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}holeTestRadius: {holeTestRadius}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}density: {density}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}healthyColor: {{ r: {healthyColor.r}, g: {healthyColor.g}, b: {healthyColor.b}, a: {healthyColor.a} }}\n");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}dryColor: {{ r: {dryColor.r}, g: {dryColor.g}, b: {dryColor.b}, a: {dryColor.a} }}\n");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}renderMode: {renderMode}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}usePrototypeMesh: {usePrototypeMesh}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}useInstancing: {useInstancing}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}useDensityScaling: {useDensityScaling}");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}alignToGround: {alignToGround}");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}positionJitter: {positionJitter}");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}targetCoverage: {targetCoverage}");
    }
}

/* $TreeInstance (7 fields) */
public record class TreeInstance (
    Vector3f position,
    float widthScale,
    float heightScale,
    float rotation,
    ColorRGBA color,
    ColorRGBA lightmapColor,
    int index) : IUnityStructure
{
    public static TreeInstance Read(EndianBinaryReader reader)
    {
        Vector3f position_ = Vector3f.Read(reader);
        float widthScale_ = reader.ReadF32();
        float heightScale_ = reader.ReadF32();
        float rotation_ = reader.ReadF32();
        ColorRGBA color_ = ColorRGBA.Read(reader);
        ColorRGBA lightmapColor_ = ColorRGBA.Read(reader);
        int index_ = reader.ReadS32();
        
        return new(position_,
            widthScale_,
            heightScale_,
            rotation_,
            color_,
            lightmapColor_,
            index_);
    }

    public override string ToString() => $"TreeInstance\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}position: {{ x: {position.x}, y: {position.y}, z: {position.z} }}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}widthScale: {widthScale}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}heightScale: {heightScale}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}rotation: {rotation}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}color: {{ rgba: {color.rgba} }}\n");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}lightmapColor: {{ rgba: {lightmapColor.rgba} }}\n");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}index: {index}");
    }
}

/* $TreePrototype (3 fields) */
public record class TreePrototype (
    PPtr<GameObject> prefab,
    float bendFactor,
    int navMeshLod) : IUnityStructure
{
    public static TreePrototype Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> prefab_ = PPtr<GameObject>.Read(reader);
        float bendFactor_ = reader.ReadF32();
        int navMeshLod_ = reader.ReadS32();
        
        return new(prefab_,
            bendFactor_,
            navMeshLod_);
    }

    public override string ToString() => $"TreePrototype\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}prefab: {prefab}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}bendFactor: {bendFactor}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}navMeshLod: {navMeshLod}");
    }
}

/* $Heightmap (9 fields) */
public record class Heightmap (
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
        short[] m_Heights_ = BuiltInArray<short>.Read(reader);
        reader.AlignTo(4); /* m_Heights */
        byte[] m_Holes_ = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_Holes */
        byte[] m_HolesLOD_ = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_HolesLOD */
        bool m_EnableHolesTextureCompression_ = reader.ReadBool();
        reader.AlignTo(4); /* m_EnableHolesTextureCompression */
        float[] m_PrecomputedError_ = BuiltInArray<float>.Read(reader);
        reader.AlignTo(4); /* m_PrecomputedError */
        float[] m_MinMaxPatchHeights_ = BuiltInArray<float>.Read(reader);
        reader.AlignTo(4); /* m_MinMaxPatchHeights */
        int m_Resolution_ = reader.ReadS32();
        int m_Levels_ = reader.ReadS32();
        Vector3f m_Scale_ = Vector3f.Read(reader);
        
        return new(m_Heights_,
            m_Holes_,
            m_HolesLOD_,
            m_EnableHolesTextureCompression_,
            m_PrecomputedError_,
            m_MinMaxPatchHeights_,
            m_Resolution_,
            m_Levels_,
            m_Scale_);
    }

    public override string ToString() => $"Heightmap\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Heights[{m_Heights.Length}] = {{");
        if (m_Heights.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (short _4 in m_Heights)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_Heights.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Holes[{m_Holes.Length}] = {{");
        if (m_Holes.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (byte _4 in m_Holes)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_Holes.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_HolesLOD[{m_HolesLOD.Length}] = {{");
        if (m_HolesLOD.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (byte _4 in m_HolesLOD)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_HolesLOD.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_EnableHolesTextureCompression: {m_EnableHolesTextureCompression}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_PrecomputedError[{m_PrecomputedError.Length}] = {{");
        if (m_PrecomputedError.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (float _4 in m_PrecomputedError)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_PrecomputedError.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_MinMaxPatchHeights[{m_MinMaxPatchHeights.Length}] = {{");
        if (m_MinMaxPatchHeights.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (float _4 in m_MinMaxPatchHeights)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_MinMaxPatchHeights.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Resolution: {m_Resolution}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Levels: {m_Levels}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Scale: {{ x: {m_Scale.x}, y: {m_Scale.y}, z: {m_Scale.z} }}\n");
    }
}

/* $NavMeshAreaData (2 fields) */
public record class NavMeshAreaData (
    AsciiString name,
    float cost) : IUnityStructure
{
    public static NavMeshAreaData Read(EndianBinaryReader reader)
    {
        AsciiString name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* name */
        float cost_ = reader.ReadF32();
        
        return new(name_,
            cost_);
    }

    public override string ToString() => $"NavMeshAreaData\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}name: \"{name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}cost: {cost}");
    }
}

/* $NavMeshBuildSettings (16 fields) */
public record class NavMeshBuildSettings (
    int agentTypeID,
    float agentRadius,
    float agentHeight,
    float agentSlope,
    float agentClimb,
    float ledgeDropHeight,
    float maxJumpAcrossDistance,
    float minRegionArea,
    int manualCellSize,
    float cellSize,
    int manualTileSize,
    int tileSize,
    int buildHeightMesh,
    uint maxJobWorkers,
    int preserveTilesOutsideBounds,
    NavMeshBuildDebugSettings debug) : IUnityStructure
{
    public static NavMeshBuildSettings Read(EndianBinaryReader reader)
    {
        int agentTypeID_ = reader.ReadS32();
        float agentRadius_ = reader.ReadF32();
        float agentHeight_ = reader.ReadF32();
        float agentSlope_ = reader.ReadF32();
        float agentClimb_ = reader.ReadF32();
        float ledgeDropHeight_ = reader.ReadF32();
        float maxJumpAcrossDistance_ = reader.ReadF32();
        float minRegionArea_ = reader.ReadF32();
        int manualCellSize_ = reader.ReadS32();
        float cellSize_ = reader.ReadF32();
        int manualTileSize_ = reader.ReadS32();
        int tileSize_ = reader.ReadS32();
        int buildHeightMesh_ = reader.ReadS32();
        uint maxJobWorkers_ = reader.ReadU32();
        int preserveTilesOutsideBounds_ = reader.ReadS32();
        NavMeshBuildDebugSettings debug_ = NavMeshBuildDebugSettings.Read(reader);
        reader.AlignTo(4); /* debug */
        
        return new(agentTypeID_,
            agentRadius_,
            agentHeight_,
            agentSlope_,
            agentClimb_,
            ledgeDropHeight_,
            maxJumpAcrossDistance_,
            minRegionArea_,
            manualCellSize_,
            cellSize_,
            manualTileSize_,
            tileSize_,
            buildHeightMesh_,
            maxJobWorkers_,
            preserveTilesOutsideBounds_,
            debug_);
    }

    public override string ToString() => $"NavMeshBuildSettings\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);
        ToString_Field15(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}agentTypeID: {agentTypeID}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}agentRadius: {agentRadius}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}agentHeight: {agentHeight}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}agentSlope: {agentSlope}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}agentClimb: {agentClimb}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}ledgeDropHeight: {ledgeDropHeight}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}maxJumpAcrossDistance: {maxJumpAcrossDistance}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}minRegionArea: {minRegionArea}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}manualCellSize: {manualCellSize}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}cellSize: {cellSize}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}manualTileSize: {manualTileSize}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}tileSize: {tileSize}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}buildHeightMesh: {buildHeightMesh}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}maxJobWorkers: {maxJobWorkers}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}preserveTilesOutsideBounds: {preserveTilesOutsideBounds}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}debug: {{ m_Flags: {debug.m_Flags} }}\n");
    }
}

/* $NavMeshBuildDebugSettings (1 fields) */
public readonly record struct NavMeshBuildDebugSettings (
    byte m_Flags) : IUnityStructure
{
    public static NavMeshBuildDebugSettings Read(EndianBinaryReader reader)
    {
        byte m_Flags_ = reader.ReadU8();
        reader.AlignTo(4); /* m_Flags */
        
        return new(m_Flags_);
    }

    public override string ToString() => $"NavMeshBuildDebugSettings\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Flags: {m_Flags}");
    }
}

/* $MinMaxCurve (5 fields) */
public record class MinMaxCurve (
    ushort minMaxState,
    float scalar,
    float minScalar,
    AnimationCurve maxCurve,
    AnimationCurve minCurve) : IUnityStructure
{
    public static MinMaxCurve Read(EndianBinaryReader reader)
    {
        ushort minMaxState_ = reader.ReadU16();
        reader.AlignTo(4); /* minMaxState */
        float scalar_ = reader.ReadF32();
        float minScalar_ = reader.ReadF32();
        AnimationCurve maxCurve_ = AnimationCurve.Read(reader);
        reader.AlignTo(4); /* maxCurve */
        AnimationCurve minCurve_ = AnimationCurve.Read(reader);
        reader.AlignTo(4); /* minCurve */
        
        return new(minMaxState_,
            scalar_,
            minScalar_,
            maxCurve_,
            minCurve_);
    }

    public override string ToString() => $"MinMaxCurve\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}minMaxState: {minMaxState}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}scalar: {scalar}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}minScalar: {minScalar}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}maxCurve: {{ \n{maxCurve.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}minCurve: {{ \n{minCurve.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $InitialModule (17 fields) */
public record class InitialModule (
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
        bool enabled_ = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        MinMaxCurve startLifetime_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* startLifetime */
        MinMaxCurve startSpeed_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* startSpeed */
        MinMaxGradient startColor_ = MinMaxGradient.Read(reader);
        reader.AlignTo(4); /* startColor */
        MinMaxCurve startSize_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* startSize */
        MinMaxCurve startSizeY_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* startSizeY */
        MinMaxCurve startSizeZ_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* startSizeZ */
        MinMaxCurve startRotationX_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* startRotationX */
        MinMaxCurve startRotationY_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* startRotationY */
        MinMaxCurve startRotation_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* startRotation */
        float randomizeRotationDirection_ = reader.ReadF32();
        int gravitySource_ = reader.ReadS32();
        int maxNumParticles_ = reader.ReadS32();
        Vector3f customEmitterVelocity_ = Vector3f.Read(reader);
        bool size3D_ = reader.ReadBool();
        bool rotation3D_ = reader.ReadBool();
        reader.AlignTo(4); /* rotation3D */
        MinMaxCurve gravityModifier_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* gravityModifier */
        
        return new(enabled_,
            startLifetime_,
            startSpeed_,
            startColor_,
            startSize_,
            startSizeY_,
            startSizeZ_,
            startRotationX_,
            startRotationY_,
            startRotation_,
            randomizeRotationDirection_,
            gravitySource_,
            maxNumParticles_,
            customEmitterVelocity_,
            size3D_,
            rotation3D_,
            gravityModifier_);
    }

    public override string ToString() => $"InitialModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);
        ToString_Field15(sb, indent, indent_);
        ToString_Field16(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enabled: {enabled}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}startLifetime: {{ \n{startLifetime.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}startSpeed: {{ \n{startSpeed.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}startColor: {{ \n{startColor.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}startSize: {{ \n{startSize.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}startSizeY: {{ \n{startSizeY.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}startSizeZ: {{ \n{startSizeZ.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}startRotationX: {{ \n{startRotationX.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}startRotationY: {{ \n{startRotationY.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}startRotation: {{ \n{startRotation.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}randomizeRotationDirection: {randomizeRotationDirection}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}gravitySource: {gravitySource}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}maxNumParticles: {maxNumParticles}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}customEmitterVelocity: {{ x: {customEmitterVelocity.x}, y: {customEmitterVelocity.y}, z: {customEmitterVelocity.z} }}\n");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}size3D: {size3D}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}rotation3D: {rotation3D}");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}gravityModifier: {{ \n{gravityModifier.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $MinMaxGradient (5 fields) */
public record class MinMaxGradient (
    ushort minMaxState,
    ColorRGBA_1 minColor,
    ColorRGBA_1 maxColor,
    Gradient maxGradient,
    Gradient minGradient) : IUnityStructure
{
    public static MinMaxGradient Read(EndianBinaryReader reader)
    {
        ushort minMaxState_ = reader.ReadU16();
        reader.AlignTo(4); /* minMaxState */
        ColorRGBA_1 minColor_ = ColorRGBA_1.Read(reader);
        ColorRGBA_1 maxColor_ = ColorRGBA_1.Read(reader);
        Gradient maxGradient_ = Gradient.Read(reader);
        reader.AlignTo(4); /* maxGradient */
        Gradient minGradient_ = Gradient.Read(reader);
        reader.AlignTo(4); /* minGradient */
        
        return new(minMaxState_,
            minColor_,
            maxColor_,
            maxGradient_,
            minGradient_);
    }

    public override string ToString() => $"MinMaxGradient\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}minMaxState: {minMaxState}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}minColor: {{ r: {minColor.r}, g: {minColor.g}, b: {minColor.b}, a: {minColor.a} }}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}maxColor: {{ r: {maxColor.r}, g: {maxColor.g}, b: {maxColor.b}, a: {maxColor.a} }}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}maxGradient: {{ \n{maxGradient.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}minGradient: {{ \n{minGradient.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $ShapeModule (34 fields) */
public record class ShapeModule (
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
    MultiModeParameter m_MeshSpawn,
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
        bool enabled_ = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        int type_ = reader.ReadS32();
        float angle_ = reader.ReadF32();
        float length_ = reader.ReadF32();
        Vector3f boxThickness_ = Vector3f.Read(reader);
        float radiusThickness_ = reader.ReadF32();
        float donutRadius_ = reader.ReadF32();
        Vector3f m_Position_ = Vector3f.Read(reader);
        Vector3f m_Rotation_ = Vector3f.Read(reader);
        Vector3f m_Scale_ = Vector3f.Read(reader);
        int placementMode_ = reader.ReadS32();
        int m_MeshMaterialIndex_ = reader.ReadS32();
        float m_MeshNormalOffset_ = reader.ReadF32();
        MultiModeParameter m_MeshSpawn_ = MultiModeParameter.Read(reader);
        reader.AlignTo(4); /* m_MeshSpawn */
        PPtr<Mesh> m_Mesh_ = PPtr<Mesh>.Read(reader);
        PPtr<MeshRenderer> m_MeshRenderer_ = PPtr<MeshRenderer>.Read(reader);
        PPtr<SkinnedMeshRenderer> m_SkinnedMeshRenderer_ = PPtr<SkinnedMeshRenderer>.Read(reader);
        PPtr<Sprite> m_Sprite_ = PPtr<Sprite>.Read(reader);
        PPtr<SpriteRenderer> m_SpriteRenderer_ = PPtr<SpriteRenderer>.Read(reader);
        bool m_UseMeshMaterialIndex_ = reader.ReadBool();
        bool m_UseMeshColors_ = reader.ReadBool();
        bool alignToDirection_ = reader.ReadBool();
        reader.AlignTo(4); /* alignToDirection */
        PPtr<Texture2D> m_Texture_ = PPtr<Texture2D>.Read(reader);
        int m_TextureClipChannel_ = reader.ReadS32();
        float m_TextureClipThreshold_ = reader.ReadF32();
        int m_TextureUVChannel_ = reader.ReadS32();
        bool m_TextureColorAffectsParticles_ = reader.ReadBool();
        bool m_TextureAlphaAffectsParticles_ = reader.ReadBool();
        bool m_TextureBilinearFiltering_ = reader.ReadBool();
        reader.AlignTo(4); /* m_TextureBilinearFiltering */
        float randomDirectionAmount_ = reader.ReadF32();
        float sphericalDirectionAmount_ = reader.ReadF32();
        float randomPositionAmount_ = reader.ReadF32();
        MultiModeParameter_1 radius_ = MultiModeParameter_1.Read(reader);
        reader.AlignTo(4); /* radius */
        MultiModeParameter_1 arc_ = MultiModeParameter_1.Read(reader);
        reader.AlignTo(4); /* arc */
        
        return new(enabled_,
            type_,
            angle_,
            length_,
            boxThickness_,
            radiusThickness_,
            donutRadius_,
            m_Position_,
            m_Rotation_,
            m_Scale_,
            placementMode_,
            m_MeshMaterialIndex_,
            m_MeshNormalOffset_,
            m_MeshSpawn_,
            m_Mesh_,
            m_MeshRenderer_,
            m_SkinnedMeshRenderer_,
            m_Sprite_,
            m_SpriteRenderer_,
            m_UseMeshMaterialIndex_,
            m_UseMeshColors_,
            alignToDirection_,
            m_Texture_,
            m_TextureClipChannel_,
            m_TextureClipThreshold_,
            m_TextureUVChannel_,
            m_TextureColorAffectsParticles_,
            m_TextureAlphaAffectsParticles_,
            m_TextureBilinearFiltering_,
            randomDirectionAmount_,
            sphericalDirectionAmount_,
            randomPositionAmount_,
            radius_,
            arc_);
    }

    public override string ToString() => $"ShapeModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);
        ToString_Field15(sb, indent, indent_);
        ToString_Field16(sb, indent, indent_);
        ToString_Field17(sb, indent, indent_);
        ToString_Field18(sb, indent, indent_);
        ToString_Field19(sb, indent, indent_);
        ToString_Field20(sb, indent, indent_);
        ToString_Field21(sb, indent, indent_);
        ToString_Field22(sb, indent, indent_);
        ToString_Field23(sb, indent, indent_);
        ToString_Field24(sb, indent, indent_);
        ToString_Field25(sb, indent, indent_);
        ToString_Field26(sb, indent, indent_);
        ToString_Field27(sb, indent, indent_);
        ToString_Field28(sb, indent, indent_);
        ToString_Field29(sb, indent, indent_);
        ToString_Field30(sb, indent, indent_);
        ToString_Field31(sb, indent, indent_);
        ToString_Field32(sb, indent, indent_);
        ToString_Field33(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enabled: {enabled}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}type: {type}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}angle: {angle}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}length: {length}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}boxThickness: {{ x: {boxThickness.x}, y: {boxThickness.y}, z: {boxThickness.z} }}\n");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}radiusThickness: {radiusThickness}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}donutRadius: {donutRadius}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Position: {{ x: {m_Position.x}, y: {m_Position.y}, z: {m_Position.z} }}\n");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Rotation: {{ x: {m_Rotation.x}, y: {m_Rotation.y}, z: {m_Rotation.z} }}\n");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Scale: {{ x: {m_Scale.x}, y: {m_Scale.y}, z: {m_Scale.z} }}\n");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}placementMode: {placementMode}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MeshMaterialIndex: {m_MeshMaterialIndex}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MeshNormalOffset: {m_MeshNormalOffset}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_MeshSpawn: {{ \n{m_MeshSpawn.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Mesh: {m_Mesh}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MeshRenderer: {m_MeshRenderer}");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SkinnedMeshRenderer: {m_SkinnedMeshRenderer}");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Sprite: {m_Sprite}");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SpriteRenderer: {m_SpriteRenderer}");
    }

    public void ToString_Field19(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UseMeshMaterialIndex: {m_UseMeshMaterialIndex}");
    }

    public void ToString_Field20(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UseMeshColors: {m_UseMeshColors}");
    }

    public void ToString_Field21(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}alignToDirection: {alignToDirection}");
    }

    public void ToString_Field22(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Texture: {m_Texture}");
    }

    public void ToString_Field23(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TextureClipChannel: {m_TextureClipChannel}");
    }

    public void ToString_Field24(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TextureClipThreshold: {m_TextureClipThreshold}");
    }

    public void ToString_Field25(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TextureUVChannel: {m_TextureUVChannel}");
    }

    public void ToString_Field26(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TextureColorAffectsParticles: {m_TextureColorAffectsParticles}");
    }

    public void ToString_Field27(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TextureAlphaAffectsParticles: {m_TextureAlphaAffectsParticles}");
    }

    public void ToString_Field28(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TextureBilinearFiltering: {m_TextureBilinearFiltering}");
    }

    public void ToString_Field29(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}randomDirectionAmount: {randomDirectionAmount}");
    }

    public void ToString_Field30(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sphericalDirectionAmount: {sphericalDirectionAmount}");
    }

    public void ToString_Field31(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}randomPositionAmount: {randomPositionAmount}");
    }

    public void ToString_Field32(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}radius: {{ \n{radius.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field33(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}arc: {{ \n{arc.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $MultiModeParameter (3 fields) */
public record class MultiModeParameter (
    int mode,
    float spread,
    MinMaxCurve speed) : IUnityStructure
{
    public static MultiModeParameter Read(EndianBinaryReader reader)
    {
        int mode_ = reader.ReadS32();
        float spread_ = reader.ReadF32();
        MinMaxCurve speed_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* speed */
        
        return new(mode_,
            spread_,
            speed_);
    }

    public override string ToString() => $"MultiModeParameter\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}mode: {mode}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}spread: {spread}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}speed: {{ \n{speed.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $MultiModeParameter_1 (4 fields) */
public record class MultiModeParameter_1 (
    float @value,
    int mode,
    float spread,
    MinMaxCurve speed) : IUnityStructure
{
    public static MultiModeParameter_1 Read(EndianBinaryReader reader)
    {
        float @value_ = reader.ReadF32();
        int mode_ = reader.ReadS32();
        float spread_ = reader.ReadF32();
        MinMaxCurve speed_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* speed */
        
        return new(@value_,
            mode_,
            spread_,
            speed_);
    }

    public override string ToString() => $"MultiModeParameter_1\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}@value: {@value}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}mode: {mode}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}spread: {spread}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}speed: {{ \n{speed.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $EmissionModule (5 fields) */
public record class EmissionModule (
    bool enabled,
    MinMaxCurve rateOverTime,
    MinMaxCurve rateOverDistance,
    int m_BurstCount,
    ParticleSystemEmissionBurst[] m_Bursts) : IUnityStructure
{
    public static EmissionModule Read(EndianBinaryReader reader)
    {
        bool enabled_ = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        MinMaxCurve rateOverTime_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* rateOverTime */
        MinMaxCurve rateOverDistance_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* rateOverDistance */
        int m_BurstCount_ = reader.ReadS32();
        reader.AlignTo(4); /* m_BurstCount */
        ParticleSystemEmissionBurst[] m_Bursts_ = BuiltInArray<ParticleSystemEmissionBurst>.Read(reader);
        reader.AlignTo(4); /* m_Bursts */
        
        return new(enabled_,
            rateOverTime_,
            rateOverDistance_,
            m_BurstCount_,
            m_Bursts_);
    }

    public override string ToString() => $"EmissionModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enabled: {enabled}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}rateOverTime: {{ \n{rateOverTime.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}rateOverDistance: {{ \n{rateOverDistance.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BurstCount: {m_BurstCount}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Bursts[{m_Bursts.Length}] = {{");
        if (m_Bursts.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (ParticleSystemEmissionBurst _4 in m_Bursts)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Bursts.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $ParticleSystemEmissionBurst (5 fields) */
public record class ParticleSystemEmissionBurst (
    float time,
    MinMaxCurve countCurve,
    int cycleCount,
    float repeatInterval,
    float probability) : IUnityStructure
{
    public static ParticleSystemEmissionBurst Read(EndianBinaryReader reader)
    {
        float time_ = reader.ReadF32();
        MinMaxCurve countCurve_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* countCurve */
        int cycleCount_ = reader.ReadS32();
        float repeatInterval_ = reader.ReadF32();
        float probability_ = reader.ReadF32();
        
        return new(time_,
            countCurve_,
            cycleCount_,
            repeatInterval_,
            probability_);
    }

    public override string ToString() => $"ParticleSystemEmissionBurst\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}time: {time}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}countCurve: {{ \n{countCurve.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}cycleCount: {cycleCount}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}repeatInterval: {repeatInterval}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}probability: {probability}");
    }
}

/* $SizeModule (5 fields) */
public record class SizeModule (
    bool enabled,
    MinMaxCurve curve,
    MinMaxCurve y,
    MinMaxCurve z,
    bool separateAxes) : IUnityStructure
{
    public static SizeModule Read(EndianBinaryReader reader)
    {
        bool enabled_ = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        MinMaxCurve curve_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* curve */
        MinMaxCurve y_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* y */
        MinMaxCurve z_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* z */
        bool separateAxes_ = reader.ReadBool();
        reader.AlignTo(4); /* separateAxes */
        
        return new(enabled_,
            curve_,
            y_,
            z_,
            separateAxes_);
    }

    public override string ToString() => $"SizeModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enabled: {enabled}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}curve: {{ \n{curve.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}y: {{ \n{y.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}z: {{ \n{z.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}separateAxes: {separateAxes}");
    }
}

/* $RotationModule (5 fields) */
public record class RotationModule (
    bool enabled,
    MinMaxCurve x,
    MinMaxCurve y,
    MinMaxCurve curve,
    bool separateAxes) : IUnityStructure
{
    public static RotationModule Read(EndianBinaryReader reader)
    {
        bool enabled_ = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        MinMaxCurve x_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* x */
        MinMaxCurve y_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* y */
        MinMaxCurve curve_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* curve */
        bool separateAxes_ = reader.ReadBool();
        reader.AlignTo(4); /* separateAxes */
        
        return new(enabled_,
            x_,
            y_,
            curve_,
            separateAxes_);
    }

    public override string ToString() => $"RotationModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enabled: {enabled}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}x: {{ \n{x.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}y: {{ \n{y.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}curve: {{ \n{curve.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}separateAxes: {separateAxes}");
    }
}

/* $ColorModule (2 fields) */
public record class ColorModule (
    bool enabled,
    MinMaxGradient gradient) : IUnityStructure
{
    public static ColorModule Read(EndianBinaryReader reader)
    {
        bool enabled_ = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        MinMaxGradient gradient_ = MinMaxGradient.Read(reader);
        reader.AlignTo(4); /* gradient */
        
        return new(enabled_,
            gradient_);
    }

    public override string ToString() => $"ColorModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enabled: {enabled}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}gradient: {{ \n{gradient.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $UVModule (17 fields) */
public record class UVModule (
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
        bool enabled_ = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        int mode_ = reader.ReadS32();
        int timeMode_ = reader.ReadS32();
        float fps_ = reader.ReadF32();
        MinMaxCurve frameOverTime_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* frameOverTime */
        MinMaxCurve startFrame_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* startFrame */
        Vector2f speedRange_ = Vector2f.Read(reader);
        int tilesX_ = reader.ReadS32();
        int tilesY_ = reader.ReadS32();
        int animationType_ = reader.ReadS32();
        int rowIndex_ = reader.ReadS32();
        float cycles_ = reader.ReadF32();
        int uvChannelMask_ = reader.ReadS32();
        int rowMode_ = reader.ReadS32();
        SpriteData[] sprites_ = BuiltInArray<SpriteData>.Read(reader);
        reader.AlignTo(4); /* sprites */
        float flipU_ = reader.ReadF32();
        float flipV_ = reader.ReadF32();
        
        return new(enabled_,
            mode_,
            timeMode_,
            fps_,
            frameOverTime_,
            startFrame_,
            speedRange_,
            tilesX_,
            tilesY_,
            animationType_,
            rowIndex_,
            cycles_,
            uvChannelMask_,
            rowMode_,
            sprites_,
            flipU_,
            flipV_);
    }

    public override string ToString() => $"UVModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);
        ToString_Field15(sb, indent, indent_);
        ToString_Field16(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enabled: {enabled}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}mode: {mode}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}timeMode: {timeMode}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}fps: {fps}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}frameOverTime: {{ \n{frameOverTime.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}startFrame: {{ \n{startFrame.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}speedRange: {{ x: {speedRange.x}, y: {speedRange.y} }}\n");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}tilesX: {tilesX}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}tilesY: {tilesY}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}animationType: {animationType}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}rowIndex: {rowIndex}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}cycles: {cycles}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}uvChannelMask: {uvChannelMask}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}rowMode: {rowMode}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}sprites[{sprites.Length}] = {{");
        if (sprites.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (SpriteData _4 in sprites)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (sprites.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}flipU: {flipU}");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}flipV: {flipV}");
    }
}

/* $SpriteData (1 fields) */
public record class SpriteData (
    PPtr<Object> sprite) : IUnityStructure
{
    public static SpriteData Read(EndianBinaryReader reader)
    {
        PPtr<Object> sprite_ = PPtr<Object>.Read(reader);
        
        return new(sprite_);
    }

    public override string ToString() => $"SpriteData\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sprite: {sprite}");
    }
}

/* $VelocityModule (13 fields) */
public record class VelocityModule (
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
        bool enabled_ = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        MinMaxCurve x_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* x */
        MinMaxCurve y_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* y */
        MinMaxCurve z_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* z */
        MinMaxCurve orbitalX_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* orbitalX */
        MinMaxCurve orbitalY_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* orbitalY */
        MinMaxCurve orbitalZ_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* orbitalZ */
        MinMaxCurve orbitalOffsetX_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* orbitalOffsetX */
        MinMaxCurve orbitalOffsetY_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* orbitalOffsetY */
        MinMaxCurve orbitalOffsetZ_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* orbitalOffsetZ */
        MinMaxCurve radial_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* radial */
        MinMaxCurve speedModifier_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* speedModifier */
        bool inWorldSpace_ = reader.ReadBool();
        reader.AlignTo(4); /* inWorldSpace */
        
        return new(enabled_,
            x_,
            y_,
            z_,
            orbitalX_,
            orbitalY_,
            orbitalZ_,
            orbitalOffsetX_,
            orbitalOffsetY_,
            orbitalOffsetZ_,
            radial_,
            speedModifier_,
            inWorldSpace_);
    }

    public override string ToString() => $"VelocityModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enabled: {enabled}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}x: {{ \n{x.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}y: {{ \n{y.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}z: {{ \n{z.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}orbitalX: {{ \n{orbitalX.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}orbitalY: {{ \n{orbitalY.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}orbitalZ: {{ \n{orbitalZ.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}orbitalOffsetX: {{ \n{orbitalOffsetX.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}orbitalOffsetY: {{ \n{orbitalOffsetY.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}orbitalOffsetZ: {{ \n{orbitalOffsetZ.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}radial: {{ \n{radial.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}speedModifier: {{ \n{speedModifier.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}inWorldSpace: {inWorldSpace}");
    }
}

/* $InheritVelocityModule (3 fields) */
public record class InheritVelocityModule (
    bool enabled,
    int m_Mode,
    MinMaxCurve m_Curve) : IUnityStructure
{
    public static InheritVelocityModule Read(EndianBinaryReader reader)
    {
        bool enabled_ = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        int m_Mode_ = reader.ReadS32();
        MinMaxCurve m_Curve_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* m_Curve */
        
        return new(enabled_,
            m_Mode_,
            m_Curve_);
    }

    public override string ToString() => $"InheritVelocityModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enabled: {enabled}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Mode: {m_Mode}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Curve: {{ \n{m_Curve.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $LifetimeByEmitterSpeedModule (3 fields) */
public record class LifetimeByEmitterSpeedModule (
    bool enabled,
    MinMaxCurve m_Curve,
    Vector2f m_Range) : IUnityStructure
{
    public static LifetimeByEmitterSpeedModule Read(EndianBinaryReader reader)
    {
        bool enabled_ = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        MinMaxCurve m_Curve_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* m_Curve */
        Vector2f m_Range_ = Vector2f.Read(reader);
        
        return new(enabled_,
            m_Curve_,
            m_Range_);
    }

    public override string ToString() => $"LifetimeByEmitterSpeedModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enabled: {enabled}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Curve: {{ \n{m_Curve.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Range: {{ x: {m_Range.x}, y: {m_Range.y} }}\n");
    }
}

/* $ForceModule (6 fields) */
public record class ForceModule (
    bool enabled,
    MinMaxCurve x,
    MinMaxCurve y,
    MinMaxCurve z,
    bool inWorldSpace,
    bool randomizePerFrame) : IUnityStructure
{
    public static ForceModule Read(EndianBinaryReader reader)
    {
        bool enabled_ = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        MinMaxCurve x_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* x */
        MinMaxCurve y_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* y */
        MinMaxCurve z_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* z */
        bool inWorldSpace_ = reader.ReadBool();
        bool randomizePerFrame_ = reader.ReadBool();
        reader.AlignTo(4); /* randomizePerFrame */
        
        return new(enabled_,
            x_,
            y_,
            z_,
            inWorldSpace_,
            randomizePerFrame_);
    }

    public override string ToString() => $"ForceModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enabled: {enabled}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}x: {{ \n{x.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}y: {{ \n{y.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}z: {{ \n{z.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}inWorldSpace: {inWorldSpace}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}randomizePerFrame: {randomizePerFrame}");
    }
}

/* $ExternalForcesModule (5 fields) */
public record class ExternalForcesModule (
    bool enabled,
    MinMaxCurve multiplierCurve,
    int influenceFilter,
    BitField influenceMask,
    PPtr<ParticleSystemForceField>[] influenceList) : IUnityStructure
{
    public static ExternalForcesModule Read(EndianBinaryReader reader)
    {
        bool enabled_ = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        MinMaxCurve multiplierCurve_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* multiplierCurve */
        int influenceFilter_ = reader.ReadS32();
        BitField influenceMask_ = BitField.Read(reader);
        PPtr<ParticleSystemForceField>[] influenceList_ = BuiltInArray<PPtr<ParticleSystemForceField>>.Read(reader);
        reader.AlignTo(4); /* influenceList */
        
        return new(enabled_,
            multiplierCurve_,
            influenceFilter_,
            influenceMask_,
            influenceList_);
    }

    public override string ToString() => $"ExternalForcesModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enabled: {enabled}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}multiplierCurve: {{ \n{multiplierCurve.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}influenceFilter: {influenceFilter}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}influenceMask: {{ m_Bits: {influenceMask.m_Bits} }}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}influenceList[{influenceList.Length}] = {{");
        if (influenceList.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtr<ParticleSystemForceField> _4 in influenceList)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (influenceList.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $ClampVelocityModule (11 fields) */
public record class ClampVelocityModule (
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
        bool enabled_ = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        MinMaxCurve x_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* x */
        MinMaxCurve y_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* y */
        MinMaxCurve z_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* z */
        MinMaxCurve magnitude_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* magnitude */
        bool separateAxis_ = reader.ReadBool();
        bool inWorldSpace_ = reader.ReadBool();
        bool multiplyDragByParticleSize_ = reader.ReadBool();
        bool multiplyDragByParticleVelocity_ = reader.ReadBool();
        reader.AlignTo(4); /* multiplyDragByParticleVelocity */
        float dampen_ = reader.ReadF32();
        MinMaxCurve drag_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* drag */
        
        return new(enabled_,
            x_,
            y_,
            z_,
            magnitude_,
            separateAxis_,
            inWorldSpace_,
            multiplyDragByParticleSize_,
            multiplyDragByParticleVelocity_,
            dampen_,
            drag_);
    }

    public override string ToString() => $"ClampVelocityModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enabled: {enabled}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}x: {{ \n{x.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}y: {{ \n{y.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}z: {{ \n{z.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}magnitude: {{ \n{magnitude.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}separateAxis: {separateAxis}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}inWorldSpace: {inWorldSpace}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}multiplyDragByParticleSize: {multiplyDragByParticleSize}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}multiplyDragByParticleVelocity: {multiplyDragByParticleVelocity}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}dampen: {dampen}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}drag: {{ \n{drag.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $NoiseModule (19 fields) */
public record class NoiseModule (
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
        bool enabled_ = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        MinMaxCurve strength_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* strength */
        MinMaxCurve strengthY_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* strengthY */
        MinMaxCurve strengthZ_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* strengthZ */
        bool separateAxes_ = reader.ReadBool();
        reader.AlignTo(4); /* separateAxes */
        float frequency_ = reader.ReadF32();
        bool damping_ = reader.ReadBool();
        reader.AlignTo(4); /* damping */
        int octaves_ = reader.ReadS32();
        float octaveMultiplier_ = reader.ReadF32();
        float octaveScale_ = reader.ReadF32();
        int quality_ = reader.ReadS32();
        MinMaxCurve scrollSpeed_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* scrollSpeed */
        MinMaxCurve remap_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* remap */
        MinMaxCurve remapY_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* remapY */
        MinMaxCurve remapZ_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* remapZ */
        bool remapEnabled_ = reader.ReadBool();
        reader.AlignTo(4); /* remapEnabled */
        MinMaxCurve positionAmount_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* positionAmount */
        MinMaxCurve rotationAmount_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* rotationAmount */
        MinMaxCurve sizeAmount_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* sizeAmount */
        
        return new(enabled_,
            strength_,
            strengthY_,
            strengthZ_,
            separateAxes_,
            frequency_,
            damping_,
            octaves_,
            octaveMultiplier_,
            octaveScale_,
            quality_,
            scrollSpeed_,
            remap_,
            remapY_,
            remapZ_,
            remapEnabled_,
            positionAmount_,
            rotationAmount_,
            sizeAmount_);
    }

    public override string ToString() => $"NoiseModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);
        ToString_Field15(sb, indent, indent_);
        ToString_Field16(sb, indent, indent_);
        ToString_Field17(sb, indent, indent_);
        ToString_Field18(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enabled: {enabled}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}strength: {{ \n{strength.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}strengthY: {{ \n{strengthY.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}strengthZ: {{ \n{strengthZ.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}separateAxes: {separateAxes}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}frequency: {frequency}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}damping: {damping}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}octaves: {octaves}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}octaveMultiplier: {octaveMultiplier}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}octaveScale: {octaveScale}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}quality: {quality}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}scrollSpeed: {{ \n{scrollSpeed.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}remap: {{ \n{remap.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}remapY: {{ \n{remapY.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}remapZ: {{ \n{remapZ.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}remapEnabled: {remapEnabled}");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}positionAmount: {{ \n{positionAmount.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}rotationAmount: {{ \n{rotationAmount.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}sizeAmount: {{ \n{sizeAmount.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $SizeBySpeedModule (6 fields) */
public record class SizeBySpeedModule (
    bool enabled,
    MinMaxCurve curve,
    MinMaxCurve y,
    MinMaxCurve z,
    Vector2f range,
    bool separateAxes) : IUnityStructure
{
    public static SizeBySpeedModule Read(EndianBinaryReader reader)
    {
        bool enabled_ = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        MinMaxCurve curve_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* curve */
        MinMaxCurve y_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* y */
        MinMaxCurve z_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* z */
        Vector2f range_ = Vector2f.Read(reader);
        bool separateAxes_ = reader.ReadBool();
        reader.AlignTo(4); /* separateAxes */
        
        return new(enabled_,
            curve_,
            y_,
            z_,
            range_,
            separateAxes_);
    }

    public override string ToString() => $"SizeBySpeedModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enabled: {enabled}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}curve: {{ \n{curve.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}y: {{ \n{y.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}z: {{ \n{z.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}range: {{ x: {range.x}, y: {range.y} }}\n");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}separateAxes: {separateAxes}");
    }
}

/* $RotationBySpeedModule (6 fields) */
public record class RotationBySpeedModule (
    bool enabled,
    MinMaxCurve x,
    MinMaxCurve y,
    MinMaxCurve curve,
    bool separateAxes,
    Vector2f range) : IUnityStructure
{
    public static RotationBySpeedModule Read(EndianBinaryReader reader)
    {
        bool enabled_ = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        MinMaxCurve x_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* x */
        MinMaxCurve y_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* y */
        MinMaxCurve curve_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* curve */
        bool separateAxes_ = reader.ReadBool();
        reader.AlignTo(4); /* separateAxes */
        Vector2f range_ = Vector2f.Read(reader);
        
        return new(enabled_,
            x_,
            y_,
            curve_,
            separateAxes_,
            range_);
    }

    public override string ToString() => $"RotationBySpeedModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enabled: {enabled}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}x: {{ \n{x.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}y: {{ \n{y.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}curve: {{ \n{curve.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}separateAxes: {separateAxes}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}range: {{ x: {range.x}, y: {range.y} }}\n");
    }
}

/* $ColorBySpeedModule (3 fields) */
public record class ColorBySpeedModule (
    bool enabled,
    MinMaxGradient gradient,
    Vector2f range) : IUnityStructure
{
    public static ColorBySpeedModule Read(EndianBinaryReader reader)
    {
        bool enabled_ = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        MinMaxGradient gradient_ = MinMaxGradient.Read(reader);
        reader.AlignTo(4); /* gradient */
        Vector2f range_ = Vector2f.Read(reader);
        
        return new(enabled_,
            gradient_,
            range_);
    }

    public override string ToString() => $"ColorBySpeedModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enabled: {enabled}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}gradient: {{ \n{gradient.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}range: {{ x: {range.x}, y: {range.y} }}\n");
    }
}

/* $CollisionModule (21 fields) */
public record class CollisionModule (
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
        bool enabled_ = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        int type_ = reader.ReadS32();
        int collisionMode_ = reader.ReadS32();
        float colliderForce_ = reader.ReadF32();
        bool multiplyColliderForceByParticleSize_ = reader.ReadBool();
        bool multiplyColliderForceByParticleSpeed_ = reader.ReadBool();
        bool multiplyColliderForceByCollisionAngle_ = reader.ReadBool();
        reader.AlignTo(4); /* multiplyColliderForceByCollisionAngle */
        PPtr<Transform>[] m_Planes_ = BuiltInArray<PPtr<Transform>>.Read(reader);
        reader.AlignTo(4); /* m_Planes */
        MinMaxCurve m_Dampen_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* m_Dampen */
        MinMaxCurve m_Bounce_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* m_Bounce */
        MinMaxCurve m_EnergyLossOnCollision_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* m_EnergyLossOnCollision */
        float minKillSpeed_ = reader.ReadF32();
        float maxKillSpeed_ = reader.ReadF32();
        float radiusScale_ = reader.ReadF32();
        BitField collidesWith_ = BitField.Read(reader);
        int maxCollisionShapes_ = reader.ReadS32();
        int quality_ = reader.ReadS32();
        float voxelSize_ = reader.ReadF32();
        bool collisionMessages_ = reader.ReadBool();
        bool collidesWithDynamic_ = reader.ReadBool();
        bool interiorCollisions_ = reader.ReadBool();
        reader.AlignTo(4); /* interiorCollisions */
        
        return new(enabled_,
            type_,
            collisionMode_,
            colliderForce_,
            multiplyColliderForceByParticleSize_,
            multiplyColliderForceByParticleSpeed_,
            multiplyColliderForceByCollisionAngle_,
            m_Planes_,
            m_Dampen_,
            m_Bounce_,
            m_EnergyLossOnCollision_,
            minKillSpeed_,
            maxKillSpeed_,
            radiusScale_,
            collidesWith_,
            maxCollisionShapes_,
            quality_,
            voxelSize_,
            collisionMessages_,
            collidesWithDynamic_,
            interiorCollisions_);
    }

    public override string ToString() => $"CollisionModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);
        ToString_Field15(sb, indent, indent_);
        ToString_Field16(sb, indent, indent_);
        ToString_Field17(sb, indent, indent_);
        ToString_Field18(sb, indent, indent_);
        ToString_Field19(sb, indent, indent_);
        ToString_Field20(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enabled: {enabled}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}type: {type}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}collisionMode: {collisionMode}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}colliderForce: {colliderForce}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}multiplyColliderForceByParticleSize: {multiplyColliderForceByParticleSize}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}multiplyColliderForceByParticleSpeed: {multiplyColliderForceByParticleSpeed}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}multiplyColliderForceByCollisionAngle: {multiplyColliderForceByCollisionAngle}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Planes[{m_Planes.Length}] = {{");
        if (m_Planes.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtr<Transform> _4 in m_Planes)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_Planes.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Dampen: {{ \n{m_Dampen.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Bounce: {{ \n{m_Bounce.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_EnergyLossOnCollision: {{ \n{m_EnergyLossOnCollision.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}minKillSpeed: {minKillSpeed}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}maxKillSpeed: {maxKillSpeed}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}radiusScale: {radiusScale}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}collidesWith: {{ m_Bits: {collidesWith.m_Bits} }}\n");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}maxCollisionShapes: {maxCollisionShapes}");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}quality: {quality}");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}voxelSize: {voxelSize}");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}collisionMessages: {collisionMessages}");
    }

    public void ToString_Field19(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}collidesWithDynamic: {collidesWithDynamic}");
    }

    public void ToString_Field20(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}interiorCollisions: {interiorCollisions}");
    }
}

/* $TriggerModule (8 fields) */
public record class TriggerModule (
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
        bool enabled_ = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        int inside_ = reader.ReadS32();
        int outside_ = reader.ReadS32();
        int enter_ = reader.ReadS32();
        int exit_ = reader.ReadS32();
        int colliderQueryMode_ = reader.ReadS32();
        float radiusScale_ = reader.ReadF32();
        PPtr<Component>[] primitives_ = BuiltInArray<PPtr<Component>>.Read(reader);
        reader.AlignTo(4); /* primitives */
        
        return new(enabled_,
            inside_,
            outside_,
            enter_,
            exit_,
            colliderQueryMode_,
            radiusScale_,
            primitives_);
    }

    public override string ToString() => $"TriggerModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enabled: {enabled}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}inside: {inside}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}outside: {outside}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enter: {enter}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}exit: {exit}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}colliderQueryMode: {colliderQueryMode}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}radiusScale: {radiusScale}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}primitives[{primitives.Length}] = {{");
        if (primitives.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtr<Component> _4 in primitives)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (primitives.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $SubModule (2 fields) */
public record class SubModule (
    bool enabled,
    SubEmitterData[] subEmitters) : IUnityStructure
{
    public static SubModule Read(EndianBinaryReader reader)
    {
        bool enabled_ = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        SubEmitterData[] subEmitters_ = BuiltInArray<SubEmitterData>.Read(reader);
        reader.AlignTo(4); /* subEmitters */
        
        return new(enabled_,
            subEmitters_);
    }

    public override string ToString() => $"SubModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enabled: {enabled}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}subEmitters[{subEmitters.Length}] = {{");
        if (subEmitters.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (SubEmitterData _4 in subEmitters)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (subEmitters.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

/* $SubEmitterData (4 fields) */
public record class SubEmitterData (
    PPtr<ParticleSystem> emitter,
    int type,
    int properties,
    float emitProbability) : IUnityStructure
{
    public static SubEmitterData Read(EndianBinaryReader reader)
    {
        PPtr<ParticleSystem> emitter_ = PPtr<ParticleSystem>.Read(reader);
        int type_ = reader.ReadS32();
        int properties_ = reader.ReadS32();
        float emitProbability_ = reader.ReadF32();
        
        return new(emitter_,
            type_,
            properties_,
            emitProbability_);
    }

    public override string ToString() => $"SubEmitterData\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}emitter: {emitter}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}type: {type}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}properties: {properties}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}emitProbability: {emitProbability}");
    }
}

/* $LightsModule (10 fields) */
public record class LightsModule (
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
        bool enabled_ = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        float ratio_ = reader.ReadF32();
        PPtr<Light> light_ = PPtr<Light>.Read(reader);
        bool randomDistribution_ = reader.ReadBool();
        bool color_ = reader.ReadBool();
        bool range_ = reader.ReadBool();
        bool intensity_ = reader.ReadBool();
        MinMaxCurve rangeCurve_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* rangeCurve */
        MinMaxCurve intensityCurve_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* intensityCurve */
        int maxLights_ = reader.ReadS32();
        
        return new(enabled_,
            ratio_,
            light_,
            randomDistribution_,
            color_,
            range_,
            intensity_,
            rangeCurve_,
            intensityCurve_,
            maxLights_);
    }

    public override string ToString() => $"LightsModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enabled: {enabled}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}ratio: {ratio}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}light: {light}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}randomDistribution: {randomDistribution}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}color: {color}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}range: {range}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}intensity: {intensity}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}rangeCurve: {{ \n{rangeCurve.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}intensityCurve: {{ \n{intensityCurve.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}maxLights: {maxLights}");
    }
}

/* $TrailModule (20 fields) */
public record class TrailModule (
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
        bool enabled_ = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        int mode_ = reader.ReadS32();
        float ratio_ = reader.ReadF32();
        MinMaxCurve lifetime_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* lifetime */
        float minVertexDistance_ = reader.ReadF32();
        int textureMode_ = reader.ReadS32();
        Vector2f textureScale_ = Vector2f.Read(reader);
        int ribbonCount_ = reader.ReadS32();
        float shadowBias_ = reader.ReadF32();
        bool worldSpace_ = reader.ReadBool();
        bool dieWithParticles_ = reader.ReadBool();
        bool sizeAffectsWidth_ = reader.ReadBool();
        bool sizeAffectsLifetime_ = reader.ReadBool();
        bool inheritParticleColor_ = reader.ReadBool();
        bool generateLightingData_ = reader.ReadBool();
        bool splitSubEmitterRibbons_ = reader.ReadBool();
        bool attachRibbonsToTransform_ = reader.ReadBool();
        reader.AlignTo(4); /* attachRibbonsToTransform */
        MinMaxGradient colorOverLifetime_ = MinMaxGradient.Read(reader);
        reader.AlignTo(4); /* colorOverLifetime */
        MinMaxCurve widthOverTrail_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* widthOverTrail */
        MinMaxGradient colorOverTrail_ = MinMaxGradient.Read(reader);
        reader.AlignTo(4); /* colorOverTrail */
        
        return new(enabled_,
            mode_,
            ratio_,
            lifetime_,
            minVertexDistance_,
            textureMode_,
            textureScale_,
            ribbonCount_,
            shadowBias_,
            worldSpace_,
            dieWithParticles_,
            sizeAffectsWidth_,
            sizeAffectsLifetime_,
            inheritParticleColor_,
            generateLightingData_,
            splitSubEmitterRibbons_,
            attachRibbonsToTransform_,
            colorOverLifetime_,
            widthOverTrail_,
            colorOverTrail_);
    }

    public override string ToString() => $"TrailModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);
        ToString_Field15(sb, indent, indent_);
        ToString_Field16(sb, indent, indent_);
        ToString_Field17(sb, indent, indent_);
        ToString_Field18(sb, indent, indent_);
        ToString_Field19(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enabled: {enabled}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}mode: {mode}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}ratio: {ratio}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}lifetime: {{ \n{lifetime.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}minVertexDistance: {minVertexDistance}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}textureMode: {textureMode}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}textureScale: {{ x: {textureScale.x}, y: {textureScale.y} }}\n");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}ribbonCount: {ribbonCount}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}shadowBias: {shadowBias}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}worldSpace: {worldSpace}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}dieWithParticles: {dieWithParticles}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sizeAffectsWidth: {sizeAffectsWidth}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}sizeAffectsLifetime: {sizeAffectsLifetime}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}inheritParticleColor: {inheritParticleColor}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}generateLightingData: {generateLightingData}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}splitSubEmitterRibbons: {splitSubEmitterRibbons}");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}attachRibbonsToTransform: {attachRibbonsToTransform}");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}colorOverLifetime: {{ \n{colorOverLifetime.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}widthOverTrail: {{ \n{widthOverTrail.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field19(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}colorOverTrail: {{ \n{colorOverTrail.ToString(indent+4)}{indent_}}}\n");
    }
}

/* $CustomDataModule (15 fields) */
public record class CustomDataModule (
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
        bool enabled_ = reader.ReadBool();
        reader.AlignTo(4); /* enabled */
        int mode0_ = reader.ReadS32();
        int vectorComponentCount0_ = reader.ReadS32();
        MinMaxGradient color0_ = MinMaxGradient.Read(reader);
        reader.AlignTo(4); /* color0 */
        MinMaxCurve vector0_0_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* vector0_0 */
        MinMaxCurve vector0_1_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* vector0_1 */
        MinMaxCurve vector0_2_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* vector0_2 */
        MinMaxCurve vector0_3_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* vector0_3 */
        int mode1_ = reader.ReadS32();
        int vectorComponentCount1_ = reader.ReadS32();
        MinMaxGradient color1_ = MinMaxGradient.Read(reader);
        reader.AlignTo(4); /* color1 */
        MinMaxCurve vector1_0_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* vector1_0 */
        MinMaxCurve vector1_1_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* vector1_1 */
        MinMaxCurve vector1_2_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* vector1_2 */
        MinMaxCurve vector1_3_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* vector1_3 */
        
        return new(enabled_,
            mode0_,
            vectorComponentCount0_,
            color0_,
            vector0_0_,
            vector0_1_,
            vector0_2_,
            vector0_3_,
            mode1_,
            vectorComponentCount1_,
            color1_,
            vector1_0_,
            vector1_1_,
            vector1_2_,
            vector1_3_);
    }

    public override string ToString() => $"CustomDataModule\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enabled: {enabled}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}mode0: {mode0}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}vectorComponentCount0: {vectorComponentCount0}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}color0: {{ \n{color0.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}vector0_0: {{ \n{vector0_0.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}vector0_1: {{ \n{vector0_1.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}vector0_2: {{ \n{vector0_2.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}vector0_3: {{ \n{vector0_3.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}mode1: {mode1}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}vectorComponentCount1: {vectorComponentCount1}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}color1: {{ \n{color1.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}vector1_0: {{ \n{vector1_0.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}vector1_1: {{ \n{vector1_1.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}vector1_2: {{ \n{vector1_2.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}vector1_3: {{ \n{vector1_3.ToString(indent+4)}{indent_}}}\n");
    }
}

/* forward decl ?Object (no type info) */
public record struct Object;
/* forward decl ?RuntimeAnimatorController (no type info) */
public record struct RuntimeAnimatorController;
/* forward decl ?Renderer (no type info) */
public record struct Renderer;
/* forward decl ?Texture (no type info) */
public record struct Texture;
/* forward decl ?NavMeshData (no type info) */
public record struct NavMeshData;
/* forward decl ?PhysicsMaterial2D (no type info) */
public record struct PhysicsMaterial2D;
/* forward decl ?ShaderVariantCollection (no type info) */
public record struct ShaderVariantCollection;
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
