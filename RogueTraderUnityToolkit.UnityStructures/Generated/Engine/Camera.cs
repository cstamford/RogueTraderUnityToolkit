namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $Camera (36 fields) (IsEngineType) */
public record class Camera(
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    uint m_ClearFlags,
    ColorRGBA m_BackGroundColor,
    int m_projectionMatrixMode,
    int m_GateFitMode,
    int m_Iso,
    float m_ShutterSpeed,
    float m_Aperture,
    float m_FocusDistance,
    float m_FocalLength,
    int m_BladeCount,
    Vector2f m_Curvature,
    float m_BarrelClipping,
    float m_Anamorphism,
    Vector2f m_SensorSize,
    Vector2f m_LensShift,
    Rectf m_NormalizedViewPortRect,
    float near_clip_plane,
    float far_clip_plane,
    float field_of_view,
    bool orthographic,
    float orthographic_size,
    float m_Depth,
    BitField m_CullingMask,
    int m_RenderingPath,
    PPtr<RenderTexture> m_TargetTexture,
    int m_TargetDisplay,
    int m_TargetEye,
    bool m_HDR,
    bool m_AllowMSAA,
    bool m_AllowDynamicResolution,
    bool m_ForceIntoRT,
    bool m_OcclusionCulling,
    float m_StereoConvergence,
    float m_StereoSeparation)
{
    public static Camera Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        byte m_Enabled = reader.ReadU8();
        uint m_ClearFlags = reader.ReadU32();
        ColorRGBA m_BackGroundColor = ColorRGBA.Read(reader);
        int m_projectionMatrixMode = reader.ReadS32();
        int m_GateFitMode = reader.ReadS32();
        int m_Iso = reader.ReadS32();
        float m_ShutterSpeed = reader.ReadF32();
        float m_Aperture = reader.ReadF32();
        float m_FocusDistance = reader.ReadF32();
        float m_FocalLength = reader.ReadF32();
        int m_BladeCount = reader.ReadS32();
        Vector2f m_Curvature = Vector2f.Read(reader);
        float m_BarrelClipping = reader.ReadF32();
        float m_Anamorphism = reader.ReadF32();
        Vector2f m_SensorSize = Vector2f.Read(reader);
        Vector2f m_LensShift = Vector2f.Read(reader);
        Rectf m_NormalizedViewPortRect = Rectf.Read(reader);
        float near_clip_plane = reader.ReadF32();
        float far_clip_plane = reader.ReadF32();
        float field_of_view = reader.ReadF32();
        bool orthographic = reader.ReadBool();
        float orthographic_size = reader.ReadF32();
        float m_Depth = reader.ReadF32();
        BitField m_CullingMask = BitField.Read(reader);
        int m_RenderingPath = reader.ReadS32();
        PPtr<RenderTexture> m_TargetTexture = PPtr<RenderTexture>.Read(reader);
        int m_TargetDisplay = reader.ReadS32();
        int m_TargetEye = reader.ReadS32();
        bool m_HDR = reader.ReadBool();
        bool m_AllowMSAA = reader.ReadBool();
        bool m_AllowDynamicResolution = reader.ReadBool();
        bool m_ForceIntoRT = reader.ReadBool();
        bool m_OcclusionCulling = reader.ReadBool();
        float m_StereoConvergence = reader.ReadF32();
        float m_StereoSeparation = reader.ReadF32();
        
        return new(m_GameObject,
            m_Enabled,
            m_ClearFlags,
            m_BackGroundColor,
            m_projectionMatrixMode,
            m_GateFitMode,
            m_Iso,
            m_ShutterSpeed,
            m_Aperture,
            m_FocusDistance,
            m_FocalLength,
            m_BladeCount,
            m_Curvature,
            m_BarrelClipping,
            m_Anamorphism,
            m_SensorSize,
            m_LensShift,
            m_NormalizedViewPortRect,
            near_clip_plane,
            far_clip_plane,
            field_of_view,
            orthographic,
            orthographic_size,
            m_Depth,
            m_CullingMask,
            m_RenderingPath,
            m_TargetTexture,
            m_TargetDisplay,
            m_TargetEye,
            m_HDR,
            m_AllowMSAA,
            m_AllowDynamicResolution,
            m_ForceIntoRT,
            m_OcclusionCulling,
            m_StereoConvergence,
            m_StereoSeparation);
    }
}

