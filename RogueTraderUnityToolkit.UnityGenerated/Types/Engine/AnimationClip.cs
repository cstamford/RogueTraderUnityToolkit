namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $AnimationClip (20 fields) AnimationClip C993F02E1B44698504D469FE44275C6A */
public record class AnimationClip (
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
    public static UnityObjectType ObjectType => UnityObjectType.AnimationClip;
    public static Hash128 Hash => new("C993F02E1B44698504D469FE44275C6A");
    public static AnimationClip Read(EndianBinaryReader reader)
    {
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        bool m_Legacy_ = reader.ReadBool();
        bool m_Compressed_ = reader.ReadBool();
        bool m_UseHighQualityCurve_ = reader.ReadBool();
        reader.AlignTo(4); /* m_UseHighQualityCurve */
        QuaternionCurve[] m_RotationCurves_ = BuiltInArray<QuaternionCurve>.Read(reader);
        reader.AlignTo(4); /* m_RotationCurves */
        CompressedAnimationCurve[] m_CompressedRotationCurves_ = BuiltInArray<CompressedAnimationCurve>.Read(reader);
        reader.AlignTo(4); /* m_CompressedRotationCurves */
        Vector3Curve[] m_EulerCurves_ = BuiltInArray<Vector3Curve>.Read(reader);
        reader.AlignTo(4); /* m_EulerCurves */
        Vector3Curve[] m_PositionCurves_ = BuiltInArray<Vector3Curve>.Read(reader);
        reader.AlignTo(4); /* m_PositionCurves */
        Vector3Curve[] m_ScaleCurves_ = BuiltInArray<Vector3Curve>.Read(reader);
        reader.AlignTo(4); /* m_ScaleCurves */
        FloatCurve[] m_FloatCurves_ = BuiltInArray<FloatCurve>.Read(reader);
        reader.AlignTo(4); /* m_FloatCurves */
        PPtrCurve[] m_PPtrCurves_ = BuiltInArray<PPtrCurve>.Read(reader);
        reader.AlignTo(4); /* m_PPtrCurves */
        float m_SampleRate_ = reader.ReadF32();
        int m_WrapMode_ = reader.ReadS32();
        AABB m_Bounds_ = AABB.Read(reader);
        uint m_MuscleClipSize_ = reader.ReadU32();
        ClipMuscleConstant m_MuscleClip_ = ClipMuscleConstant.Read(reader);
        reader.AlignTo(4); /* m_MuscleClip */
        AnimationClipBindingConstant m_ClipBindingConstant_ = AnimationClipBindingConstant.Read(reader);
        reader.AlignTo(4); /* m_ClipBindingConstant */
        bool m_HasGenericRootTransform_ = reader.ReadBool();
        bool m_HasMotionFloatCurves_ = reader.ReadBool();
        reader.AlignTo(4); /* m_HasMotionFloatCurves */
        AnimationEvent[] m_Events_ = BuiltInArray<AnimationEvent>.Read(reader);
        reader.AlignTo(4); /* m_Events */
        
        return new(m_Name_,
            m_Legacy_,
            m_Compressed_,
            m_UseHighQualityCurve_,
            m_RotationCurves_,
            m_CompressedRotationCurves_,
            m_EulerCurves_,
            m_PositionCurves_,
            m_ScaleCurves_,
            m_FloatCurves_,
            m_PPtrCurves_,
            m_SampleRate_,
            m_WrapMode_,
            m_Bounds_,
            m_MuscleClipSize_,
            m_MuscleClip_,
            m_ClipBindingConstant_,
            m_HasGenericRootTransform_,
            m_HasMotionFloatCurves_,
            m_Events_);
    }

    public override string ToString() => $"AnimationClip\n{ToString(4)}";

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

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Legacy: {m_Legacy}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Compressed: {m_Compressed}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UseHighQualityCurve: {m_UseHighQualityCurve}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_RotationCurves[{m_RotationCurves.Length}] = {{");
        if (m_RotationCurves.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (QuaternionCurve _4 in m_RotationCurves)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_RotationCurves.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_CompressedRotationCurves[{m_CompressedRotationCurves.Length}] = {{");
        if (m_CompressedRotationCurves.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (CompressedAnimationCurve _4 in m_CompressedRotationCurves)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_CompressedRotationCurves.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_EulerCurves[{m_EulerCurves.Length}] = {{");
        if (m_EulerCurves.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (Vector3Curve _4 in m_EulerCurves)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_EulerCurves.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_PositionCurves[{m_PositionCurves.Length}] = {{");
        if (m_PositionCurves.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (Vector3Curve _4 in m_PositionCurves)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_PositionCurves.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ScaleCurves[{m_ScaleCurves.Length}] = {{");
        if (m_ScaleCurves.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (Vector3Curve _4 in m_ScaleCurves)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_ScaleCurves.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_FloatCurves[{m_FloatCurves.Length}] = {{");
        if (m_FloatCurves.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (FloatCurve _4 in m_FloatCurves)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_FloatCurves.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_PPtrCurves[{m_PPtrCurves.Length}] = {{");
        if (m_PPtrCurves.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtrCurve _4 in m_PPtrCurves)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_PPtrCurves.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SampleRate: {m_SampleRate}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_WrapMode: {m_WrapMode}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Bounds: {{ \n{m_Bounds.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MuscleClipSize: {m_MuscleClipSize}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_MuscleClip: {{ \n{m_MuscleClip.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ClipBindingConstant: {{ \n{m_ClipBindingConstant.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_HasGenericRootTransform: {m_HasGenericRootTransform}");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_HasMotionFloatCurves: {m_HasMotionFloatCurves}");
    }

    public void ToString_Field19(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Events[{m_Events.Length}] = {{");
        if (m_Events.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (AnimationEvent _4 in m_Events)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Events.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

