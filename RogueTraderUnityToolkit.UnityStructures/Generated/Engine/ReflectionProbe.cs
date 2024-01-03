namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $ReflectionProbe (25 fields) (IsEngineType) */
public record class ReflectionProbe(
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
    ColorRGBA m_BackGroundColor,
    BitField m_CullingMask,
    float m_IntensityMultiplier,
    float m_BlendDistance,
    bool m_HDR,
    bool m_BoxProjection,
    bool m_RenderDynamicObjects,
    bool m_UseOcclusionCulling,
    short m_Importance,
    PPtr<Texture> m_CustomBakedTexture,
    PPtr<Texture> m_BakedTexture)
{
    public static ReflectionProbe Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        byte m_Enabled = reader.ReadU8();
        int m_Type = reader.ReadS32();
        int m_Mode = reader.ReadS32();
        int m_RefreshMode = reader.ReadS32();
        int m_TimeSlicingMode = reader.ReadS32();
        int m_Resolution = reader.ReadS32();
        int m_UpdateFrequency = reader.ReadS32();
        Vector3f m_BoxSize = Vector3f.Read(reader);
        Vector3f m_BoxOffset = Vector3f.Read(reader);
        float m_NearClip = reader.ReadF32();
        float m_FarClip = reader.ReadF32();
        float m_ShadowDistance = reader.ReadF32();
        uint m_ClearFlags = reader.ReadU32();
        ColorRGBA m_BackGroundColor = ColorRGBA.Read(reader);
        BitField m_CullingMask = BitField.Read(reader);
        float m_IntensityMultiplier = reader.ReadF32();
        float m_BlendDistance = reader.ReadF32();
        bool m_HDR = reader.ReadBool();
        bool m_BoxProjection = reader.ReadBool();
        bool m_RenderDynamicObjects = reader.ReadBool();
        bool m_UseOcclusionCulling = reader.ReadBool();
        short m_Importance = reader.ReadS16();
        PPtr<Texture> m_CustomBakedTexture = PPtr<Texture>.Read(reader);
        PPtr<Texture> m_BakedTexture = PPtr<Texture>.Read(reader);
        
        return new(m_GameObject,
            m_Enabled,
            m_Type,
            m_Mode,
            m_RefreshMode,
            m_TimeSlicingMode,
            m_Resolution,
            m_UpdateFrequency,
            m_BoxSize,
            m_BoxOffset,
            m_NearClip,
            m_FarClip,
            m_ShadowDistance,
            m_ClearFlags,
            m_BackGroundColor,
            m_CullingMask,
            m_IntensityMultiplier,
            m_BlendDistance,
            m_HDR,
            m_BoxProjection,
            m_RenderDynamicObjects,
            m_UseOcclusionCulling,
            m_Importance,
            m_CustomBakedTexture,
            m_BakedTexture);
    }
}

