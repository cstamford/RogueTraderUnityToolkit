namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $Light (27 fields) C83A6C8C3B1832DB5F481F4EB754832A */
public record class Light(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    int m_Type /* NeedsAlign */,
    int m_Shape /* None */,
    ColorRGBA m_Color /* None */,
    float m_Intensity /* None */,
    float m_Range /* None */,
    float m_SpotAngle /* None */,
    float m_InnerSpotAngle /* None */,
    float m_CookieSize /* None */,
    ShadowSettings m_Shadows /* None */,
    PPtr<Texture> m_Cookie /* NeedsAlign */,
    bool m_DrawHalo /* None */,
    LightBakingOutput m_BakingOutput /* NeedsAlign */,
    PPtr<Flare> m_Flare /* NeedsAlign */,
    int m_RenderMode /* None */,
    BitField m_CullingMask /* None */,
    uint m_RenderingLayerMask /* None */,
    int m_Lightmapping /* None */,
    int m_LightShadowCasterMode /* None */,
    Vector2f m_AreaSize /* None */,
    float m_BounceIntensity /* None */,
    float m_ColorTemperature /* None */,
    bool m_UseColorTemperature /* None */,
    Vector4f m_BoundingSphereOverride /* NeedsAlign */,
    bool m_UseBoundingSphereOverride /* None */,
    bool m_UseViewFrustumForShadowCasterCull /* None */) : IUnityObject
{
    public static Hash128 Hash => new(3359272076, 991441627, 1598562126, 3075769130);
    public static Light Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Type */
        int _m_Type = reader.ReadS32();
        int _m_Shape = reader.ReadS32();
        ColorRGBA _m_Color = ColorRGBA.Read(reader);
        float _m_Intensity = reader.ReadF32();
        float _m_Range = reader.ReadF32();
        float _m_SpotAngle = reader.ReadF32();
        float _m_InnerSpotAngle = reader.ReadF32();
        float _m_CookieSize = reader.ReadF32();
        ShadowSettings _m_Shadows = ShadowSettings.Read(reader);
        reader.AlignTo(4); /* m_Cookie */
        PPtr<Texture> _m_Cookie = PPtr<Texture>.Read(reader);
        bool _m_DrawHalo = reader.ReadBool();
        reader.AlignTo(4); /* m_BakingOutput */
        LightBakingOutput _m_BakingOutput = LightBakingOutput.Read(reader);
        reader.AlignTo(4); /* m_Flare */
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
        reader.AlignTo(4); /* m_BoundingSphereOverride */
        Vector4f _m_BoundingSphereOverride = Vector4f.Read(reader);
        bool _m_UseBoundingSphereOverride = reader.ReadBool();
        bool _m_UseViewFrustumForShadowCasterCull = reader.ReadBool();
        
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
}

