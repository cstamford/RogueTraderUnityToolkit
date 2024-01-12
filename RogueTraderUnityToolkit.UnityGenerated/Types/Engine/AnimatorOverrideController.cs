namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $AnimatorOverrideController (3 fields) AnimatorOverrideController 1DAD7181B9D85FFC4DD49722B3175F4C */
public record class AnimatorOverrideController (
    AsciiString m_Name,
    PPtr<RuntimeAnimatorController> m_Controller,
    AnimationClipOverride[] m_Clips) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.AnimatorOverrideController;
    public static Hash128 Hash => new("1DAD7181B9D85FFC4DD49722B3175F4C");
    public static AnimatorOverrideController Read(EndianBinaryReader reader)
    {
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        PPtr<RuntimeAnimatorController> m_Controller_ = PPtr<RuntimeAnimatorController>.Read(reader);
        AnimationClipOverride[] m_Clips_ = BuiltInArray<AnimationClipOverride>.Read(reader);
        reader.AlignTo(4); /* m_Clips */
        
        return new(m_Name_,
            m_Controller_,
            m_Clips_);
    }

    public override string ToString() => $"AnimatorOverrideController\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Controller: {m_Controller}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Clips[{m_Clips.Length}] = {{");
        if (m_Clips.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (AnimationClipOverride _4 in m_Clips)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Clips.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

