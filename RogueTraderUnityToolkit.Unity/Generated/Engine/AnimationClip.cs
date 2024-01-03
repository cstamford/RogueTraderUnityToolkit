namespace RogueTraderUnityToolkit.Unity.Generated.Engine;

using Core;

/* $AnimationClip (20 fields) (IsEngineType) */
public record class AnimationClip(
    AsciiString m_Name,
    bool m_Legacy,
    bool m_Compressed,
    bool m_UseHighQualityCurve,
    QuaternionCurve[] m_RotationCurves,
    CompressedAnimationCurve[] m_CompressedRotationCurves,
    Vector3Curve[] m_EulerCurves,
    Vector3Curve[] m_PositionCurves,
    Vector3Curve[] m_ScaleCurves,
    FloatCurve[] m_FloatCurves,
    PPtrCurve[] m_PPtrCurves,
    float m_SampleRate,
    int m_WrapMode,
    AABB m_Bounds,
    uint m_MuscleClipSize,
    ClipMuscleConstant m_MuscleClip,
    AnimationClipBindingConstant m_ClipBindingConstant,
    bool m_HasGenericRootTransform,
    bool m_HasMotionFloatCurves,
    AnimationEvent[] m_Events)
{
    public static AnimationClip Read(EndianBinaryReader reader)
    {
        AsciiString m_Name = String.Read(reader);
        bool m_Legacy = reader.ReadBool();
        bool m_Compressed = reader.ReadBool();
        bool m_UseHighQualityCurve = reader.ReadBool();
        QuaternionCurve[] m_RotationCurves = Array<QuaternionCurve>.Read(reader);
        CompressedAnimationCurve[] m_CompressedRotationCurves = Array<CompressedAnimationCurve>.Read(reader);
        Vector3Curve[] m_EulerCurves = Array<Vector3Curve>.Read(reader);
        Vector3Curve[] m_PositionCurves = Array<Vector3Curve>.Read(reader);
        Vector3Curve[] m_ScaleCurves = Array<Vector3Curve>.Read(reader);
        FloatCurve[] m_FloatCurves = Array<FloatCurve>.Read(reader);
        PPtrCurve[] m_PPtrCurves = Array<PPtrCurve>.Read(reader);
        float m_SampleRate = reader.ReadF32();
        int m_WrapMode = reader.ReadS32();
        AABB m_Bounds = AABB.Read(reader);
        uint m_MuscleClipSize = reader.ReadU32();
        ClipMuscleConstant m_MuscleClip = ClipMuscleConstant.Read(reader);
        AnimationClipBindingConstant m_ClipBindingConstant = AnimationClipBindingConstant.Read(reader);
        bool m_HasGenericRootTransform = reader.ReadBool();
        bool m_HasMotionFloatCurves = reader.ReadBool();
        AnimationEvent[] m_Events = Array<AnimationEvent>.Read(reader);
        
        return new(m_Name,
            m_Legacy,
            m_Compressed,
            m_UseHighQualityCurve,
            m_RotationCurves,
            m_CompressedRotationCurves,
            m_EulerCurves,
            m_PositionCurves,
            m_ScaleCurves,
            m_FloatCurves,
            m_PPtrCurves,
            m_SampleRate,
            m_WrapMode,
            m_Bounds,
            m_MuscleClipSize,
            m_MuscleClip,
            m_ClipBindingConstant,
            m_HasGenericRootTransform,
            m_HasMotionFloatCurves,
            m_Events);
    }
}

