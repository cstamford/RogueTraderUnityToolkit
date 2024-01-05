namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $AnimationClip (20 fields) C993F02E1B44698504D469FE44275C6A */
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
    AnimationEvent[] m_Events) : IUnityEngineStructure
{
    public static Hash128 Hash => new(3381915694, 457468293, 81029630, 1143430250);

    public static AnimationClip Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        bool _m_Legacy = reader.ReadBool();
        bool _m_Compressed = reader.ReadBool();
        bool _m_UseHighQualityCurve = reader.ReadBool();
        reader.AlignTo(4); /* m_UseHighQualityCurve */
        QuaternionCurve[] _m_RotationCurves = BuiltInArray<QuaternionCurve>.Read(reader);
        reader.AlignTo(4); /* m_RotationCurves */
        CompressedAnimationCurve[] _m_CompressedRotationCurves = BuiltInArray<CompressedAnimationCurve>.Read(reader);
        reader.AlignTo(4); /* m_CompressedRotationCurves */
        Vector3Curve[] _m_EulerCurves = BuiltInArray<Vector3Curve>.Read(reader);
        reader.AlignTo(4); /* m_EulerCurves */
        Vector3Curve[] _m_PositionCurves = BuiltInArray<Vector3Curve>.Read(reader);
        reader.AlignTo(4); /* m_PositionCurves */
        Vector3Curve[] _m_ScaleCurves = BuiltInArray<Vector3Curve>.Read(reader);
        reader.AlignTo(4); /* m_ScaleCurves */
        FloatCurve[] _m_FloatCurves = BuiltInArray<FloatCurve>.Read(reader);
        reader.AlignTo(4); /* m_FloatCurves */
        PPtrCurve[] _m_PPtrCurves = BuiltInArray<PPtrCurve>.Read(reader);
        reader.AlignTo(4); /* m_PPtrCurves */
        float _m_SampleRate = reader.ReadF32();
        int _m_WrapMode = reader.ReadS32();
        AABB _m_Bounds = AABB.Read(reader);
        uint _m_MuscleClipSize = reader.ReadU32();
        ClipMuscleConstant _m_MuscleClip = ClipMuscleConstant.Read(reader);
        reader.AlignTo(4); /* m_MuscleClip */
        AnimationClipBindingConstant _m_ClipBindingConstant = AnimationClipBindingConstant.Read(reader);
        reader.AlignTo(4); /* m_ClipBindingConstant */
        bool _m_HasGenericRootTransform = reader.ReadBool();
        bool _m_HasMotionFloatCurves = reader.ReadBool();
        reader.AlignTo(4); /* m_HasMotionFloatCurves */
        AnimationEvent[] _m_Events = BuiltInArray<AnimationEvent>.Read(reader);
        reader.AlignTo(4); /* m_Events */
        
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

    public override string ToString() => $"AnimationClip\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Legacy: ");
        sb.AppendLine(m_Legacy.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Compressed: ");
        sb.AppendLine(m_Compressed.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_UseHighQualityCurve: ");
        sb.AppendLine(m_UseHighQualityCurve.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RotationCurves: ");
        sb.AppendLine(m_RotationCurves.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CompressedRotationCurves: ");
        sb.AppendLine(m_CompressedRotationCurves.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_EulerCurves: ");
        sb.AppendLine(m_EulerCurves.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PositionCurves: ");
        sb.AppendLine(m_PositionCurves.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ScaleCurves: ");
        sb.AppendLine(m_ScaleCurves.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FloatCurves: ");
        sb.AppendLine(m_FloatCurves.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PPtrCurves: ");
        sb.AppendLine(m_PPtrCurves.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SampleRate: ");
        sb.AppendLine(m_SampleRate.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_WrapMode: ");
        sb.AppendLine(m_WrapMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Bounds: ");
        sb.AppendLine();
        sb.Append(m_Bounds.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MuscleClipSize: ");
        sb.AppendLine(m_MuscleClipSize.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MuscleClip: ");
        sb.AppendLine();
        sb.Append(m_MuscleClip.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ClipBindingConstant: ");
        sb.AppendLine();
        sb.Append(m_ClipBindingConstant.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HasGenericRootTransform: ");
        sb.AppendLine(m_HasGenericRootTransform.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HasMotionFloatCurves: ");
        sb.AppendLine(m_HasMotionFloatCurves.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Events: ");
        sb.AppendLine(m_Events.ToString());

        return sb.ToString();
    }
}

