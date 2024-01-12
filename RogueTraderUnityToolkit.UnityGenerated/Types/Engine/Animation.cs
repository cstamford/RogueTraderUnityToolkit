namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Animation (8 fields) Animation 6EACAB9E81FE6FC68388008E1BCC8F72 */
public record class Animation (
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    PPtr<AnimationClip> m_Animation,
    PPtr<AnimationClip>[] m_Animations,
    int m_WrapMode,
    bool m_PlayAutomatically,
    bool m_AnimatePhysics,
    int m_CullingType) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.Animation;
    public static Hash128 Hash => new("6EACAB9E81FE6FC68388008E1BCC8F72");
    public static Animation Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject_ = PPtr<GameObject>.Read(reader);
        byte m_Enabled_ = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        PPtr<AnimationClip> m_Animation_ = PPtr<AnimationClip>.Read(reader);
        PPtr<AnimationClip>[] m_Animations_ = BuiltInArray<PPtr<AnimationClip>>.Read(reader);
        reader.AlignTo(4); /* m_Animations */
        int m_WrapMode_ = reader.ReadS32();
        bool m_PlayAutomatically_ = reader.ReadBool();
        bool m_AnimatePhysics_ = reader.ReadBool();
        reader.AlignTo(4); /* m_AnimatePhysics */
        int m_CullingType_ = reader.ReadS32();
        
        return new(m_GameObject_,
            m_Enabled_,
            m_Animation_,
            m_Animations_,
            m_WrapMode_,
            m_PlayAutomatically_,
            m_AnimatePhysics_,
            m_CullingType_);
    }

    public override string ToString() => $"Animation\n{ToString(4)}";

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
        sb.AppendLine($"{indent_}m_Animation: {m_Animation}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Animations[{m_Animations.Length}] = {{");
        if (m_Animations.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtr<AnimationClip> _4 in m_Animations)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_Animations.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_WrapMode: {m_WrapMode}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PlayAutomatically: {m_PlayAutomatically}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_AnimatePhysics: {m_AnimatePhysics}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CullingType: {m_CullingType}");
    }
}

