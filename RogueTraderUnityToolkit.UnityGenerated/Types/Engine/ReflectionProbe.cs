namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $ReflectionProbe (25 fields) ReflectionProbe 63E8651709EB2F3D976DBC38841BB4DC */
public record class ReflectionProbe (
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    int m_Type,
    int m_Mode,
    int m_RefreshMode,
    int m_TimeSlicingMode,
    int m_Resolution,
    int m_UpdateFrequency,
    Vector3f m_BoxSize,
    Vector3f m_BoxOffset,
    float m_NearClip,
    float m_FarClip,
    float m_ShadowDistance,
    uint m_ClearFlags,
    ColorRGBA_1 m_BackGroundColor,
    BitField m_CullingMask,
    float m_IntensityMultiplier,
    float m_BlendDistance,
    bool m_HDR,
    bool m_BoxProjection,
    bool m_RenderDynamicObjects,
    bool m_UseOcclusionCulling,
    short m_Importance,
    PPtr<Texture> m_CustomBakedTexture,
    PPtr<Texture> m_BakedTexture) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.ReflectionProbe;
    public static Hash128 Hash => new("63E8651709EB2F3D976DBC38841BB4DC");
    public static ReflectionProbe Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject_ = PPtr<GameObject>.Read(reader);
        byte m_Enabled_ = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        int m_Type_ = reader.ReadS32();
        int m_Mode_ = reader.ReadS32();
        int m_RefreshMode_ = reader.ReadS32();
        int m_TimeSlicingMode_ = reader.ReadS32();
        int m_Resolution_ = reader.ReadS32();
        int m_UpdateFrequency_ = reader.ReadS32();
        Vector3f m_BoxSize_ = Vector3f.Read(reader);
        Vector3f m_BoxOffset_ = Vector3f.Read(reader);
        float m_NearClip_ = reader.ReadF32();
        float m_FarClip_ = reader.ReadF32();
        float m_ShadowDistance_ = reader.ReadF32();
        uint m_ClearFlags_ = reader.ReadU32();
        ColorRGBA_1 m_BackGroundColor_ = ColorRGBA_1.Read(reader);
        BitField m_CullingMask_ = BitField.Read(reader);
        float m_IntensityMultiplier_ = reader.ReadF32();
        float m_BlendDistance_ = reader.ReadF32();
        bool m_HDR_ = reader.ReadBool();
        bool m_BoxProjection_ = reader.ReadBool();
        bool m_RenderDynamicObjects_ = reader.ReadBool();
        bool m_UseOcclusionCulling_ = reader.ReadBool();
        short m_Importance_ = reader.ReadS16();
        reader.AlignTo(4); /* m_Importance */
        PPtr<Texture> m_CustomBakedTexture_ = PPtr<Texture>.Read(reader);
        PPtr<Texture> m_BakedTexture_ = PPtr<Texture>.Read(reader);
        
        return new(m_GameObject_,
            m_Enabled_,
            m_Type_,
            m_Mode_,
            m_RefreshMode_,
            m_TimeSlicingMode_,
            m_Resolution_,
            m_UpdateFrequency_,
            m_BoxSize_,
            m_BoxOffset_,
            m_NearClip_,
            m_FarClip_,
            m_ShadowDistance_,
            m_ClearFlags_,
            m_BackGroundColor_,
            m_CullingMask_,
            m_IntensityMultiplier_,
            m_BlendDistance_,
            m_HDR_,
            m_BoxProjection_,
            m_RenderDynamicObjects_,
            m_UseOcclusionCulling_,
            m_Importance_,
            m_CustomBakedTexture_,
            m_BakedTexture_);
    }

    public override string ToString() => $"ReflectionProbe\n{ToString(4)}";

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

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_GameObject: {m_GameObject}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Enabled: {m_Enabled}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Type: {m_Type}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Mode: {m_Mode}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RefreshMode: {m_RefreshMode}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TimeSlicingMode: {m_TimeSlicingMode}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Resolution: {m_Resolution}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UpdateFrequency: {m_UpdateFrequency}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_BoxSize: {{ x: {m_BoxSize.x}, y: {m_BoxSize.y}, z: {m_BoxSize.z} }}\n");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_BoxOffset: {{ x: {m_BoxOffset.x}, y: {m_BoxOffset.y}, z: {m_BoxOffset.z} }}\n");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_NearClip: {m_NearClip}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_FarClip: {m_FarClip}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ShadowDistance: {m_ShadowDistance}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ClearFlags: {m_ClearFlags}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_BackGroundColor: {{ r: {m_BackGroundColor.r}, g: {m_BackGroundColor.g}, b: {m_BackGroundColor.b}, a: {m_BackGroundColor.a} }}\n");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_CullingMask: {{ m_Bits: {m_CullingMask.m_Bits} }}\n");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_IntensityMultiplier: {m_IntensityMultiplier}");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BlendDistance: {m_BlendDistance}");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_HDR: {m_HDR}");
    }

    public void ToString_Field19(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BoxProjection: {m_BoxProjection}");
    }

    public void ToString_Field20(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RenderDynamicObjects: {m_RenderDynamicObjects}");
    }

    public void ToString_Field21(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UseOcclusionCulling: {m_UseOcclusionCulling}");
    }

    public void ToString_Field22(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Importance: {m_Importance}");
    }

    public void ToString_Field23(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CustomBakedTexture: {m_CustomBakedTexture}");
    }

    public void ToString_Field24(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BakedTexture: {m_BakedTexture}");
    }
}

