namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Camera (36 fields) EA7A2404E878F638436311F83940CB96 */
public record class Camera(
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    uint m_ClearFlags,
    ColorRGBA_0 m_BackGroundColor,
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
    float m_StereoSeparation) : IUnityEngineStructure
{
    public static Hash128 Hash => new(3933873156, 3900241464, 1130566136, 960547734);

    public static Camera Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        uint _m_ClearFlags = reader.ReadU32();
        ColorRGBA_0 _m_BackGroundColor = ColorRGBA_0.Read(reader);
        int _m_projectionMatrixMode = reader.ReadS32();
        int _m_GateFitMode = reader.ReadS32();
        reader.AlignTo(4); /* m_GateFitMode */
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
        reader.AlignTo(4); /* orthographic */
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
        reader.AlignTo(4); /* m_OcclusionCulling */
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

    public override string ToString() => $"Camera\n{ToString(4)}";

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
        sb.Append("m_ClearFlags: ");
        sb.AppendLine(m_ClearFlags.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BackGroundColor: ");
        sb.AppendLine();
        sb.Append(m_BackGroundColor.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_projectionMatrixMode: ");
        sb.AppendLine(m_projectionMatrixMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GateFitMode: ");
        sb.AppendLine(m_GateFitMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Iso: ");
        sb.AppendLine(m_Iso.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ShutterSpeed: ");
        sb.AppendLine(m_ShutterSpeed.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Aperture: ");
        sb.AppendLine(m_Aperture.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FocusDistance: ");
        sb.AppendLine(m_FocusDistance.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FocalLength: ");
        sb.AppendLine(m_FocalLength.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BladeCount: ");
        sb.AppendLine(m_BladeCount.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Curvature: ");
        sb.AppendLine();
        sb.Append(m_Curvature.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BarrelClipping: ");
        sb.AppendLine(m_BarrelClipping.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Anamorphism: ");
        sb.AppendLine(m_Anamorphism.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SensorSize: ");
        sb.AppendLine();
        sb.Append(m_SensorSize.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LensShift: ");
        sb.AppendLine();
        sb.Append(m_LensShift.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NormalizedViewPortRect: ");
        sb.AppendLine();
        sb.Append(m_NormalizedViewPortRect.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("near_clip_plane: ");
        sb.AppendLine(near_clip_plane.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("far_clip_plane: ");
        sb.AppendLine(far_clip_plane.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("field_of_view: ");
        sb.AppendLine(field_of_view.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("orthographic: ");
        sb.AppendLine(orthographic.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("orthographic_size: ");
        sb.AppendLine(orthographic_size.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Depth: ");
        sb.AppendLine(m_Depth.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CullingMask: ");
        sb.AppendLine();
        sb.Append(m_CullingMask.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RenderingPath: ");
        sb.AppendLine(m_RenderingPath.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TargetTexture: ");
        sb.AppendLine(m_TargetTexture.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TargetDisplay: ");
        sb.AppendLine(m_TargetDisplay.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TargetEye: ");
        sb.AppendLine(m_TargetEye.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HDR: ");
        sb.AppendLine(m_HDR.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AllowMSAA: ");
        sb.AppendLine(m_AllowMSAA.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AllowDynamicResolution: ");
        sb.AppendLine(m_AllowDynamicResolution.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ForceIntoRT: ");
        sb.AppendLine(m_ForceIntoRT.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_OcclusionCulling: ");
        sb.AppendLine(m_OcclusionCulling.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StereoConvergence: ");
        sb.AppendLine(m_StereoConvergence.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StereoSeparation: ");
        sb.AppendLine(m_StereoSeparation.ToString());

        return sb.ToString();
    }
}

