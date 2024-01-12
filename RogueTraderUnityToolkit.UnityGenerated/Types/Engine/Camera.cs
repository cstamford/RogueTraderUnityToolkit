namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Camera (36 fields) Camera EA7A2404E878F638436311F83940CB96 */
public record class Camera (
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    uint m_ClearFlags,
    ColorRGBA_1 m_BackGroundColor,
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
    public static UnityObjectType ObjectType => UnityObjectType.Camera;
    public static Hash128 Hash => new("EA7A2404E878F638436311F83940CB96");
    public static Camera Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject_ = PPtr<GameObject>.Read(reader);
        byte m_Enabled_ = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        uint m_ClearFlags_ = reader.ReadU32();
        ColorRGBA_1 m_BackGroundColor_ = ColorRGBA_1.Read(reader);
        int m_projectionMatrixMode_ = reader.ReadS32();
        int m_GateFitMode_ = reader.ReadS32();
        reader.AlignTo(4); /* m_GateFitMode */
        int m_Iso_ = reader.ReadS32();
        float m_ShutterSpeed_ = reader.ReadF32();
        float m_Aperture_ = reader.ReadF32();
        float m_FocusDistance_ = reader.ReadF32();
        float m_FocalLength_ = reader.ReadF32();
        int m_BladeCount_ = reader.ReadS32();
        Vector2f m_Curvature_ = Vector2f.Read(reader);
        float m_BarrelClipping_ = reader.ReadF32();
        float m_Anamorphism_ = reader.ReadF32();
        Vector2f m_SensorSize_ = Vector2f.Read(reader);
        Vector2f m_LensShift_ = Vector2f.Read(reader);
        Rectf m_NormalizedViewPortRect_ = Rectf.Read(reader);
        float near_clip_plane_ = reader.ReadF32();
        float far_clip_plane_ = reader.ReadF32();
        float field_of_view_ = reader.ReadF32();
        bool orthographic_ = reader.ReadBool();
        reader.AlignTo(4); /* orthographic */
        float orthographic_size_ = reader.ReadF32();
        float m_Depth_ = reader.ReadF32();
        BitField m_CullingMask_ = BitField.Read(reader);
        int m_RenderingPath_ = reader.ReadS32();
        PPtr<RenderTexture> m_TargetTexture_ = PPtr<RenderTexture>.Read(reader);
        int m_TargetDisplay_ = reader.ReadS32();
        int m_TargetEye_ = reader.ReadS32();
        bool m_HDR_ = reader.ReadBool();
        bool m_AllowMSAA_ = reader.ReadBool();
        bool m_AllowDynamicResolution_ = reader.ReadBool();
        bool m_ForceIntoRT_ = reader.ReadBool();
        bool m_OcclusionCulling_ = reader.ReadBool();
        reader.AlignTo(4); /* m_OcclusionCulling */
        float m_StereoConvergence_ = reader.ReadF32();
        float m_StereoSeparation_ = reader.ReadF32();
        
        return new(m_GameObject_,
            m_Enabled_,
            m_ClearFlags_,
            m_BackGroundColor_,
            m_projectionMatrixMode_,
            m_GateFitMode_,
            m_Iso_,
            m_ShutterSpeed_,
            m_Aperture_,
            m_FocusDistance_,
            m_FocalLength_,
            m_BladeCount_,
            m_Curvature_,
            m_BarrelClipping_,
            m_Anamorphism_,
            m_SensorSize_,
            m_LensShift_,
            m_NormalizedViewPortRect_,
            near_clip_plane_,
            far_clip_plane_,
            field_of_view_,
            orthographic_,
            orthographic_size_,
            m_Depth_,
            m_CullingMask_,
            m_RenderingPath_,
            m_TargetTexture_,
            m_TargetDisplay_,
            m_TargetEye_,
            m_HDR_,
            m_AllowMSAA_,
            m_AllowDynamicResolution_,
            m_ForceIntoRT_,
            m_OcclusionCulling_,
            m_StereoConvergence_,
            m_StereoSeparation_);
    }

    public override string ToString() => $"Camera\n{ToString(4)}";

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
        ToString_Field27(sb, indent, indent_);
        ToString_Field28(sb, indent, indent_);
        ToString_Field29(sb, indent, indent_);
        ToString_Field30(sb, indent, indent_);
        ToString_Field31(sb, indent, indent_);
        ToString_Field32(sb, indent, indent_);
        ToString_Field33(sb, indent, indent_);
        ToString_Field34(sb, indent, indent_);
        ToString_Field35(sb, indent, indent_);

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
        sb.AppendLine($"{indent_}m_ClearFlags: {m_ClearFlags}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_BackGroundColor: {{ r: {m_BackGroundColor.r}, g: {m_BackGroundColor.g}, b: {m_BackGroundColor.b}, a: {m_BackGroundColor.a} }}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_projectionMatrixMode: {m_projectionMatrixMode}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_GateFitMode: {m_GateFitMode}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Iso: {m_Iso}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ShutterSpeed: {m_ShutterSpeed}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Aperture: {m_Aperture}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_FocusDistance: {m_FocusDistance}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_FocalLength: {m_FocalLength}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BladeCount: {m_BladeCount}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Curvature: {{ x: {m_Curvature.x}, y: {m_Curvature.y} }}\n");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BarrelClipping: {m_BarrelClipping}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Anamorphism: {m_Anamorphism}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_SensorSize: {{ x: {m_SensorSize.x}, y: {m_SensorSize.y} }}\n");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_LensShift: {{ x: {m_LensShift.x}, y: {m_LensShift.y} }}\n");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_NormalizedViewPortRect: {{ x: {m_NormalizedViewPortRect.x}, y: {m_NormalizedViewPortRect.y}, width: {m_NormalizedViewPortRect.width}, height: {m_NormalizedViewPortRect.height} }}\n");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}near_clip_plane: {near_clip_plane}");
    }

    public void ToString_Field19(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}far_clip_plane: {far_clip_plane}");
    }

    public void ToString_Field20(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}field_of_view: {field_of_view}");
    }

    public void ToString_Field21(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}orthographic: {orthographic}");
    }

    public void ToString_Field22(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}orthographic_size: {orthographic_size}");
    }

    public void ToString_Field23(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Depth: {m_Depth}");
    }

    public void ToString_Field24(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_CullingMask: {{ m_Bits: {m_CullingMask.m_Bits} }}\n");
    }

    public void ToString_Field25(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RenderingPath: {m_RenderingPath}");
    }

    public void ToString_Field26(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TargetTexture: {m_TargetTexture}");
    }

    public void ToString_Field27(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TargetDisplay: {m_TargetDisplay}");
    }

    public void ToString_Field28(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TargetEye: {m_TargetEye}");
    }

    public void ToString_Field29(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_HDR: {m_HDR}");
    }

    public void ToString_Field30(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_AllowMSAA: {m_AllowMSAA}");
    }

    public void ToString_Field31(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_AllowDynamicResolution: {m_AllowDynamicResolution}");
    }

    public void ToString_Field32(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ForceIntoRT: {m_ForceIntoRT}");
    }

    public void ToString_Field33(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_OcclusionCulling: {m_OcclusionCulling}");
    }

    public void ToString_Field34(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_StereoConvergence: {m_StereoConvergence}");
    }

    public void ToString_Field35(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_StereoSeparation: {m_StereoSeparation}");
    }
}

