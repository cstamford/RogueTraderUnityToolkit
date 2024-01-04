namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $ReflectionProbe (25 fields) 63E8651709EB2F3D976DBC38841BB4DC */
public record class ReflectionProbe(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    int m_Type /* NeedsAlign */,
    int m_Mode /* None */,
    int m_RefreshMode /* None */,
    int m_TimeSlicingMode /* None */,
    int m_Resolution /* None */,
    int m_UpdateFrequency /* None */,
    Vector3f m_BoxSize /* None */,
    Vector3f m_BoxOffset /* None */,
    float m_NearClip /* None */,
    float m_FarClip /* None */,
    float m_ShadowDistance /* None */,
    uint m_ClearFlags /* None */,
    ColorRGBA m_BackGroundColor /* None */,
    BitField m_CullingMask /* None */,
    float m_IntensityMultiplier /* None */,
    float m_BlendDistance /* None */,
    bool m_HDR /* None */,
    bool m_BoxProjection /* None */,
    bool m_RenderDynamicObjects /* None */,
    bool m_UseOcclusionCulling /* None */,
    short m_Importance /* None */,
    PPtr<Texture> m_CustomBakedTexture /* NeedsAlign */,
    PPtr<Texture> m_BakedTexture /* None */) : IUnityObject
{
    public static Hash128 Hash => new(1676174615, 166407997, 2540551224, 2216408284);
    public static ReflectionProbe Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Type */
        int _m_Type = reader.ReadS32();
        int _m_Mode = reader.ReadS32();
        int _m_RefreshMode = reader.ReadS32();
        int _m_TimeSlicingMode = reader.ReadS32();
        int _m_Resolution = reader.ReadS32();
        int _m_UpdateFrequency = reader.ReadS32();
        Vector3f _m_BoxSize = Vector3f.Read(reader);
        Vector3f _m_BoxOffset = Vector3f.Read(reader);
        float _m_NearClip = reader.ReadF32();
        float _m_FarClip = reader.ReadF32();
        float _m_ShadowDistance = reader.ReadF32();
        uint _m_ClearFlags = reader.ReadU32();
        ColorRGBA _m_BackGroundColor = ColorRGBA.Read(reader);
        BitField _m_CullingMask = BitField.Read(reader);
        float _m_IntensityMultiplier = reader.ReadF32();
        float _m_BlendDistance = reader.ReadF32();
        bool _m_HDR = reader.ReadBool();
        bool _m_BoxProjection = reader.ReadBool();
        bool _m_RenderDynamicObjects = reader.ReadBool();
        bool _m_UseOcclusionCulling = reader.ReadBool();
        short _m_Importance = reader.ReadS16();
        reader.AlignTo(4); /* m_CustomBakedTexture */
        PPtr<Texture> _m_CustomBakedTexture = PPtr<Texture>.Read(reader);
        PPtr<Texture> _m_BakedTexture = PPtr<Texture>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Type,
            _m_Mode,
            _m_RefreshMode,
            _m_TimeSlicingMode,
            _m_Resolution,
            _m_UpdateFrequency,
            _m_BoxSize,
            _m_BoxOffset,
            _m_NearClip,
            _m_FarClip,
            _m_ShadowDistance,
            _m_ClearFlags,
            _m_BackGroundColor,
            _m_CullingMask,
            _m_IntensityMultiplier,
            _m_BlendDistance,
            _m_HDR,
            _m_BoxProjection,
            _m_RenderDynamicObjects,
            _m_UseOcclusionCulling,
            _m_Importance,
            _m_CustomBakedTexture,
            _m_BakedTexture);
    }
}

