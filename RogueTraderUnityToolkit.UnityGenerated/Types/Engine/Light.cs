namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Light (27 fields) C83A6C8C3B1832DB5F481F4EB754832A */
public record class Light(
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    int m_Type,
    int m_Shape,
    ColorRGBA_0 m_Color,
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
    public static Hash128 Hash => new(3359272076, 991441627, 1598562126, 3075769130);

    public static Light Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        int _m_Type = reader.ReadS32();
        int _m_Shape = reader.ReadS32();
        ColorRGBA_0 _m_Color = ColorRGBA_0.Read(reader);
        float _m_Intensity = reader.ReadF32();
        float _m_Range = reader.ReadF32();
        float _m_SpotAngle = reader.ReadF32();
        float _m_InnerSpotAngle = reader.ReadF32();
        float _m_CookieSize = reader.ReadF32();
        ShadowSettings _m_Shadows = ShadowSettings.Read(reader);
        reader.AlignTo(4); /* m_Shadows */
        PPtr<Texture> _m_Cookie = PPtr<Texture>.Read(reader);
        bool _m_DrawHalo = reader.ReadBool();
        reader.AlignTo(4); /* m_DrawHalo */
        LightBakingOutput _m_BakingOutput = LightBakingOutput.Read(reader);
        reader.AlignTo(4); /* m_BakingOutput */
        PPtr<Flare> _m_Flare = PPtr<Flare>.Read(reader);
        int _m_RenderMode = reader.ReadS32();
        BitField _m_CullingMask = BitField.Read(reader);
        uint _m_RenderingLayerMask = reader.ReadU32();
        int _m_Lightmapping = reader.ReadS32();
        int _m_LightShadowCasterMode = reader.ReadS32();
        Vector2f _m_AreaSize = Vector2f.Read(reader);
        float _m_BounceIntensity = reader.ReadF32();
        float _m_ColorTemperature = reader.ReadF32();
        bool _m_UseColorTemperature = reader.ReadBool();
        reader.AlignTo(4); /* m_UseColorTemperature */
        Vector4f _m_BoundingSphereOverride = Vector4f.Read(reader);
        bool _m_UseBoundingSphereOverride = reader.ReadBool();
        bool _m_UseViewFrustumForShadowCasterCull = reader.ReadBool();
        reader.AlignTo(4); /* m_UseViewFrustumForShadowCasterCull */
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Type,
            _m_Shape,
            _m_Color,
            _m_Intensity,
            _m_Range,
            _m_SpotAngle,
            _m_InnerSpotAngle,
            _m_CookieSize,
            _m_Shadows,
            _m_Cookie,
            _m_DrawHalo,
            _m_BakingOutput,
            _m_Flare,
            _m_RenderMode,
            _m_CullingMask,
            _m_RenderingLayerMask,
            _m_Lightmapping,
            _m_LightShadowCasterMode,
            _m_AreaSize,
            _m_BounceIntensity,
            _m_ColorTemperature,
            _m_UseColorTemperature,
            _m_BoundingSphereOverride,
            _m_UseBoundingSphereOverride,
            _m_UseViewFrustumForShadowCasterCull);
    }

    public override string ToString() => $"Light\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GameObject: ");
        sb.AppendLine(m_GameObject.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Enabled: ");
        sb.AppendLine(m_Enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Type: ");
        sb.AppendLine(m_Type.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Shape: ");
        sb.AppendLine(m_Shape.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Color: ");
        sb.AppendLine();
        sb.Append(m_Color.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Intensity: ");
        sb.AppendLine(m_Intensity.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Range: ");
        sb.AppendLine(m_Range.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SpotAngle: ");
        sb.AppendLine(m_SpotAngle.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_InnerSpotAngle: ");
        sb.AppendLine(m_InnerSpotAngle.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CookieSize: ");
        sb.AppendLine(m_CookieSize.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Shadows: ");
        sb.AppendLine();
        sb.Append(m_Shadows.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Cookie: ");
        sb.AppendLine(m_Cookie.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DrawHalo: ");
        sb.AppendLine(m_DrawHalo.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BakingOutput: ");
        sb.AppendLine();
        sb.Append(m_BakingOutput.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Flare: ");
        sb.AppendLine(m_Flare.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RenderMode: ");
        sb.AppendLine(m_RenderMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CullingMask: ");
        sb.AppendLine();
        sb.Append(m_CullingMask.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RenderingLayerMask: ");
        sb.AppendLine(m_RenderingLayerMask.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Lightmapping: ");
        sb.AppendLine(m_Lightmapping.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LightShadowCasterMode: ");
        sb.AppendLine(m_LightShadowCasterMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AreaSize: ");
        sb.AppendLine();
        sb.Append(m_AreaSize.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BounceIntensity: ");
        sb.AppendLine(m_BounceIntensity.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ColorTemperature: ");
        sb.AppendLine(m_ColorTemperature.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_UseColorTemperature: ");
        sb.AppendLine(m_UseColorTemperature.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BoundingSphereOverride: ");
        sb.AppendLine();
        sb.Append(m_BoundingSphereOverride.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_UseBoundingSphereOverride: ");
        sb.AppendLine(m_UseBoundingSphereOverride.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_UseViewFrustumForShadowCasterCull: ");
        sb.AppendLine(m_UseViewFrustumForShadowCasterCull.ToString());

        return sb.ToString();
    }
}

