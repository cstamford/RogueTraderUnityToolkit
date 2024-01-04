namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $AnimationClip (20 fields) C993F02E1B44698504D469FE44275C6A */
public record class AnimationClip(
    AsciiString m_Name /* None */,
    bool m_Legacy /* NeedsAlign */,
    bool m_Compressed /* None */,
    bool m_UseHighQualityCurve /* None */,
    QuaternionCurve[] m_RotationCurves /* NeedsAlign */,
    CompressedAnimationCurve[] m_CompressedRotationCurves /* NeedsAlign */,
    Vector3Curve[] m_EulerCurves /* NeedsAlign */,
    Vector3Curve[] m_PositionCurves /* NeedsAlign */,
    Vector3Curve[] m_ScaleCurves /* NeedsAlign */,
    FloatCurve[] m_FloatCurves /* NeedsAlign */,
    PPtrCurve[] m_PPtrCurves /* NeedsAlign */,
    float m_SampleRate /* NeedsAlign */,
    int m_WrapMode /* None */,
    AABB m_Bounds /* None */,
    uint m_MuscleClipSize /* None */,
    ClipMuscleConstant m_MuscleClip /* None */,
    AnimationClipBindingConstant m_ClipBindingConstant /* NeedsAlign */,
    bool m_HasGenericRootTransform /* NeedsAlign */,
    bool m_HasMotionFloatCurves /* None */,
    AnimationEvent[] m_Events /* NeedsAlign */) : IUnityObject
{
    public static Hash128 Hash => new(3381915694, 457468293, 81029630, 1143430250);
    public static AnimationClip Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Legacy */
        bool _m_Legacy = reader.ReadBool();
        bool _m_Compressed = reader.ReadBool();
        bool _m_UseHighQualityCurve = reader.ReadBool();
        reader.AlignTo(4); /* m_RotationCurves */
        QuaternionCurve[] _m_RotationCurves = BuiltInArray<QuaternionCurve>.Read(reader);
        reader.AlignTo(4); /* m_CompressedRotationCurves */
        CompressedAnimationCurve[] _m_CompressedRotationCurves = BuiltInArray<CompressedAnimationCurve>.Read(reader);
        reader.AlignTo(4); /* m_EulerCurves */
        Vector3Curve[] _m_EulerCurves = BuiltInArray<Vector3Curve>.Read(reader);
        reader.AlignTo(4); /* m_PositionCurves */
        Vector3Curve[] _m_PositionCurves = BuiltInArray<Vector3Curve>.Read(reader);
        reader.AlignTo(4); /* m_ScaleCurves */
        Vector3Curve[] _m_ScaleCurves = BuiltInArray<Vector3Curve>.Read(reader);
        reader.AlignTo(4); /* m_FloatCurves */
        FloatCurve[] _m_FloatCurves = BuiltInArray<FloatCurve>.Read(reader);
        reader.AlignTo(4); /* m_PPtrCurves */
        PPtrCurve[] _m_PPtrCurves = BuiltInArray<PPtrCurve>.Read(reader);
        reader.AlignTo(4); /* m_SampleRate */
        float _m_SampleRate = reader.ReadF32();
        int _m_WrapMode = reader.ReadS32();
        AABB _m_Bounds = AABB.Read(reader);
        uint _m_MuscleClipSize = reader.ReadU32();
        ClipMuscleConstant _m_MuscleClip = ClipMuscleConstant.Read(reader);
        reader.AlignTo(4); /* m_ClipBindingConstant */
        AnimationClipBindingConstant _m_ClipBindingConstant = AnimationClipBindingConstant.Read(reader);
        reader.AlignTo(4); /* m_HasGenericRootTransform */
        bool _m_HasGenericRootTransform = reader.ReadBool();
        bool _m_HasMotionFloatCurves = reader.ReadBool();
        reader.AlignTo(4); /* m_Events */
        AnimationEvent[] _m_Events = BuiltInArray<AnimationEvent>.Read(reader);
        
        return new(_m_Name,
            _m_Legacy,
            _m_Compressed,
            _m_UseHighQualityCurve,
            _m_RotationCurves,
            _m_CompressedRotationCurves,
            _m_EulerCurves,
            _m_PositionCurves,
            _m_ScaleCurves,
            _m_FloatCurves,
            _m_PPtrCurves,
            _m_SampleRate,
            _m_WrapMode,
            _m_Bounds,
            _m_MuscleClipSize,
            _m_MuscleClip,
            _m_ClipBindingConstant,
            _m_HasGenericRootTransform,
            _m_HasMotionFloatCurves,
            _m_Events);
    }
}

