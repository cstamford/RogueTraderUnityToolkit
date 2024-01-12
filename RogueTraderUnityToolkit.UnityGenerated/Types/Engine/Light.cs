namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Light (27 fields) Light C83A6C8C3B1832DB5F481F4EB754832A */
public record class Light (
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    int m_Type,
    int m_Shape,
    ColorRGBA_1 m_Color,
    float m_Intensity,
    float m_Range,
    float m_SpotAngle,
    float m_InnerSpotAngle,
    float m_CookieSize,
    ShadowSettings m_Shadows,
    PPtr<Texture> m_Cookie,
    bool m_DrawHalo,
    LightBakingOutput m_BakingOutput,
    PPtr<Flare> m_Flare,
    int m_RenderMode,
    BitField m_CullingMask,
    uint m_RenderingLayerMask,
    int m_Lightmapping,
    int m_LightShadowCasterMode,
    Vector2f m_AreaSize,
    float m_BounceIntensity,
    float m_ColorTemperature,
    bool m_UseColorTemperature,
    Vector4f m_BoundingSphereOverride,
    bool m_UseBoundingSphereOverride,
    bool m_UseViewFrustumForShadowCasterCull) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.Light;
    public static Hash128 Hash => new("C83A6C8C3B1832DB5F481F4EB754832A");
    public static Light Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject_ = PPtr<GameObject>.Read(reader);
        byte m_Enabled_ = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        int m_Type_ = reader.ReadS32();
        int m_Shape_ = reader.ReadS32();
        ColorRGBA_1 m_Color_ = ColorRGBA_1.Read(reader);
        float m_Intensity_ = reader.ReadF32();
        float m_Range_ = reader.ReadF32();
        float m_SpotAngle_ = reader.ReadF32();
        float m_InnerSpotAngle_ = reader.ReadF32();
        float m_CookieSize_ = reader.ReadF32();
        ShadowSettings m_Shadows_ = ShadowSettings.Read(reader);
        reader.AlignTo(4); /* m_Shadows */
        PPtr<Texture> m_Cookie_ = PPtr<Texture>.Read(reader);
        bool m_DrawHalo_ = reader.ReadBool();
        reader.AlignTo(4); /* m_DrawHalo */
        LightBakingOutput m_BakingOutput_ = LightBakingOutput.Read(reader);
        reader.AlignTo(4); /* m_BakingOutput */
        PPtr<Flare> m_Flare_ = PPtr<Flare>.Read(reader);
        int m_RenderMode_ = reader.ReadS32();
        BitField m_CullingMask_ = BitField.Read(reader);
        uint m_RenderingLayerMask_ = reader.ReadU32();
        int m_Lightmapping_ = reader.ReadS32();
        int m_LightShadowCasterMode_ = reader.ReadS32();
        Vector2f m_AreaSize_ = Vector2f.Read(reader);
        float m_BounceIntensity_ = reader.ReadF32();
        float m_ColorTemperature_ = reader.ReadF32();
        bool m_UseColorTemperature_ = reader.ReadBool();
        reader.AlignTo(4); /* m_UseColorTemperature */
        Vector4f m_BoundingSphereOverride_ = Vector4f.Read(reader);
        bool m_UseBoundingSphereOverride_ = reader.ReadBool();
        bool m_UseViewFrustumForShadowCasterCull_ = reader.ReadBool();
        reader.AlignTo(4); /* m_UseViewFrustumForShadowCasterCull */
        
        return new(m_GameObject_,
            m_Enabled_,
            m_Type_,
            m_Shape_,
            m_Color_,
            m_Intensity_,
            m_Range_,
            m_SpotAngle_,
            m_InnerSpotAngle_,
            m_CookieSize_,
            m_Shadows_,
            m_Cookie_,
            m_DrawHalo_,
            m_BakingOutput_,
            m_Flare_,
            m_RenderMode_,
            m_CullingMask_,
            m_RenderingLayerMask_,
            m_Lightmapping_,
            m_LightShadowCasterMode_,
            m_AreaSize_,
            m_BounceIntensity_,
            m_ColorTemperature_,
            m_UseColorTemperature_,
            m_BoundingSphereOverride_,
            m_UseBoundingSphereOverride_,
            m_UseViewFrustumForShadowCasterCull_);
    }

    public override string ToString() => $"Light\n{ToString(4)}";

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
        sb.AppendLine($"{indent_}m_Shape: {m_Shape}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Color: {{ r: {m_Color.r}, g: {m_Color.g}, b: {m_Color.b}, a: {m_Color.a} }}\n");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Intensity: {m_Intensity}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Range: {m_Range}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SpotAngle: {m_SpotAngle}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_InnerSpotAngle: {m_InnerSpotAngle}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CookieSize: {m_CookieSize}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Shadows: {{ \n{m_Shadows.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Cookie: {m_Cookie}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DrawHalo: {m_DrawHalo}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_BakingOutput: {{ \n{m_BakingOutput.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Flare: {m_Flare}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RenderMode: {m_RenderMode}");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_CullingMask: {{ m_Bits: {m_CullingMask.m_Bits} }}\n");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RenderingLayerMask: {m_RenderingLayerMask}");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Lightmapping: {m_Lightmapping}");
    }

    public void ToString_Field19(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LightShadowCasterMode: {m_LightShadowCasterMode}");
    }

    public void ToString_Field20(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_AreaSize: {{ x: {m_AreaSize.x}, y: {m_AreaSize.y} }}\n");
    }

    public void ToString_Field21(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BounceIntensity: {m_BounceIntensity}");
    }

    public void ToString_Field22(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ColorTemperature: {m_ColorTemperature}");
    }

    public void ToString_Field23(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UseColorTemperature: {m_UseColorTemperature}");
    }

    public void ToString_Field24(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_BoundingSphereOverride: {{ x: {m_BoundingSphereOverride.x}, y: {m_BoundingSphereOverride.y}, z: {m_BoundingSphereOverride.z}, w: {m_BoundingSphereOverride.w} }}\n");
    }

    public void ToString_Field25(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UseBoundingSphereOverride: {m_UseBoundingSphereOverride}");
    }

    public void ToString_Field26(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UseViewFrustumForShadowCasterCull: {m_UseViewFrustumForShadowCasterCull}");
    }
}

