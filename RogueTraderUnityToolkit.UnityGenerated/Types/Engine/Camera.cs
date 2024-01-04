namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $Camera (36 fields) EA7A2404E878F638436311F83940CB96 */
public record class Camera(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    uint m_ClearFlags /* NeedsAlign */,
    ColorRGBA m_BackGroundColor /* None */,
    int m_projectionMatrixMode /* None */,
    int m_GateFitMode /* None */,
    int m_Iso /* NeedsAlign */,
    float m_ShutterSpeed /* None */,
    float m_Aperture /* None */,
    float m_FocusDistance /* None */,
    float m_FocalLength /* None */,
    int m_BladeCount /* None */,
    Vector2f m_Curvature /* None */,
    float m_BarrelClipping /* None */,
    float m_Anamorphism /* None */,
    Vector2f m_SensorSize /* None */,
    Vector2f m_LensShift /* None */,
    Rectf m_NormalizedViewPortRect /* None */,
    float near_clip_plane /* None */,
    float far_clip_plane /* None */,
    float field_of_view /* None */,
    bool orthographic /* None */,
    float orthographic_size /* NeedsAlign */,
    float m_Depth /* None */,
    BitField m_CullingMask /* None */,
    int m_RenderingPath /* None */,
    PPtr<RenderTexture> m_TargetTexture /* None */,
    int m_TargetDisplay /* None */,
    int m_TargetEye /* None */,
    bool m_HDR /* None */,
    bool m_AllowMSAA /* None */,
    bool m_AllowDynamicResolution /* None */,
    bool m_ForceIntoRT /* None */,
    bool m_OcclusionCulling /* None */,
    float m_StereoConvergence /* NeedsAlign */,
    float m_StereoSeparation /* None */) : IUnityObject
{
    public static Hash128 Hash => new(3933873156, 3900241464, 1130566136, 960547734);
    public static Camera Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_ClearFlags */
        uint _m_ClearFlags = reader.ReadU32();
        ColorRGBA _m_BackGroundColor = ColorRGBA.Read(reader);
        int _m_projectionMatrixMode = reader.ReadS32();
        int _m_GateFitMode = reader.ReadS32();
        reader.AlignTo(4); /* m_Iso */
        int _m_Iso = reader.ReadS32();
        float _m_ShutterSpeed = reader.ReadF32();
        float _m_Aperture = reader.ReadF32();
        float _m_FocusDistance = reader.ReadF32();
        float _m_FocalLength = reader.ReadF32();
        int _m_BladeCount = reader.ReadS32();
        Vector2f _m_Curvature = Vector2f.Read(reader);
        float _m_BarrelClipping = reader.ReadF32();
        float _m_Anamorphism = reader.ReadF32();
        Vector2f _m_SensorSize = Vector2f.Read(reader);
        Vector2f _m_LensShift = Vector2f.Read(reader);
        Rectf _m_NormalizedViewPortRect = Rectf.Read(reader);
        float _near_clip_plane = reader.ReadF32();
        float _far_clip_plane = reader.ReadF32();
        float _field_of_view = reader.ReadF32();
        bool _orthographic = reader.ReadBool();
        reader.AlignTo(4); /* orthographic_size */
        float _orthographic_size = reader.ReadF32();
        float _m_Depth = reader.ReadF32();
        BitField _m_CullingMask = BitField.Read(reader);
        int _m_RenderingPath = reader.ReadS32();
        PPtr<RenderTexture> _m_TargetTexture = PPtr<RenderTexture>.Read(reader);
        int _m_TargetDisplay = reader.ReadS32();
        int _m_TargetEye = reader.ReadS32();
        bool _m_HDR = reader.ReadBool();
        bool _m_AllowMSAA = reader.ReadBool();
        bool _m_AllowDynamicResolution = reader.ReadBool();
        bool _m_ForceIntoRT = reader.ReadBool();
        bool _m_OcclusionCulling = reader.ReadBool();
        reader.AlignTo(4); /* m_StereoConvergence */
        float _m_StereoConvergence = reader.ReadF32();
        float _m_StereoSeparation = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_ClearFlags,
            _m_BackGroundColor,
            _m_projectionMatrixMode,
            _m_GateFitMode,
            _m_Iso,
            _m_ShutterSpeed,
            _m_Aperture,
            _m_FocusDistance,
            _m_FocalLength,
            _m_BladeCount,
            _m_Curvature,
            _m_BarrelClipping,
            _m_Anamorphism,
            _m_SensorSize,
            _m_LensShift,
            _m_NormalizedViewPortRect,
            _near_clip_plane,
            _far_clip_plane,
            _field_of_view,
            _orthographic,
            _orthographic_size,
            _m_Depth,
            _m_CullingMask,
            _m_RenderingPath,
            _m_TargetTexture,
            _m_TargetDisplay,
            _m_TargetEye,
            _m_HDR,
            _m_AllowMSAA,
            _m_AllowDynamicResolution,
            _m_ForceIntoRT,
            _m_OcclusionCulling,
            _m_StereoConvergence,
            _m_StereoSeparation);
    }
}

