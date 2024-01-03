namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $Light (27 fields) (IsEngineType) */
public record class Light(
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    int m_Type,
    int m_Shape,
    ColorRGBA m_Color,
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
    bool m_UseViewFrustumForShadowCasterCull)
{
    public static Light Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        byte m_Enabled = reader.ReadU8();
        int m_Type = reader.ReadS32();
        int m_Shape = reader.ReadS32();
        ColorRGBA m_Color = ColorRGBA.Read(reader);
        float m_Intensity = reader.ReadF32();
        float m_Range = reader.ReadF32();
        float m_SpotAngle = reader.ReadF32();
        float m_InnerSpotAngle = reader.ReadF32();
        float m_CookieSize = reader.ReadF32();
        ShadowSettings m_Shadows = ShadowSettings.Read(reader);
        PPtr<Texture> m_Cookie = PPtr<Texture>.Read(reader);
        bool m_DrawHalo = reader.ReadBool();
        LightBakingOutput m_BakingOutput = LightBakingOutput.Read(reader);
        PPtr<Flare> m_Flare = PPtr<Flare>.Read(reader);
        int m_RenderMode = reader.ReadS32();
        BitField m_CullingMask = BitField.Read(reader);
        uint m_RenderingLayerMask = reader.ReadU32();
        int m_Lightmapping = reader.ReadS32();
        int m_LightShadowCasterMode = reader.ReadS32();
        Vector2f m_AreaSize = Vector2f.Read(reader);
        float m_BounceIntensity = reader.ReadF32();
        float m_ColorTemperature = reader.ReadF32();
        bool m_UseColorTemperature = reader.ReadBool();
        Vector4f m_BoundingSphereOverride = Vector4f.Read(reader);
        bool m_UseBoundingSphereOverride = reader.ReadBool();
        bool m_UseViewFrustumForShadowCasterCull = reader.ReadBool();
        
        return new(m_GameObject,
            m_Enabled,
            m_Type,
            m_Shape,
            m_Color,
            m_Intensity,
            m_Range,
            m_SpotAngle,
            m_InnerSpotAngle,
            m_CookieSize,
            m_Shadows,
            m_Cookie,
            m_DrawHalo,
            m_BakingOutput,
            m_Flare,
            m_RenderMode,
            m_CullingMask,
            m_RenderingLayerMask,
            m_Lightmapping,
            m_LightShadowCasterMode,
            m_AreaSize,
            m_BounceIntensity,
            m_ColorTemperature,
            m_UseColorTemperature,
            m_BoundingSphereOverride,
            m_UseBoundingSphereOverride,
            m_UseViewFrustumForShadowCasterCull);
    }
}

