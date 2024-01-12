namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $AnimatorController (8 fields) AnimatorController 8AE382FCA491ECA479D3EA2BA8D38A3B */
public record class AnimatorController (
    AsciiString m_Name,
    uint m_ControllerSize,
    ControllerConstant m_Controller,
    Dictionary<uint, AsciiString> m_TOS,
    PPtr<AnimationClip>[] m_AnimationClips,
    StateMachineBehaviourVectorDescription m_StateMachineBehaviourVectorDescription,
    PPtr<MonoBehaviour>[] m_StateMachineBehaviours,
    bool m_MultiThreadedStateMachine) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.AnimatorController;
    public static Hash128 Hash => new("8AE382FCA491ECA479D3EA2BA8D38A3B");
    public static AnimatorController Read(EndianBinaryReader reader)
    {
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        uint m_ControllerSize_ = reader.ReadU32();
        ControllerConstant m_Controller_ = ControllerConstant.Read(reader);
        reader.AlignTo(4); /* m_Controller */
        Dictionary<uint, AsciiString> m_TOS_ = BuiltInMap<uint, AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_TOS */
        PPtr<AnimationClip>[] m_AnimationClips_ = BuiltInArray<PPtr<AnimationClip>>.Read(reader);
        reader.AlignTo(4); /* m_AnimationClips */
        StateMachineBehaviourVectorDescription m_StateMachineBehaviourVectorDescription_ = StateMachineBehaviourVectorDescription.Read(reader);
        reader.AlignTo(4); /* m_StateMachineBehaviourVectorDescription */
        PPtr<MonoBehaviour>[] m_StateMachineBehaviours_ = BuiltInArray<PPtr<MonoBehaviour>>.Read(reader);
        reader.AlignTo(4); /* m_StateMachineBehaviours */
        bool m_MultiThreadedStateMachine_ = reader.ReadBool();
        reader.AlignTo(4); /* m_MultiThreadedStateMachine */
        
        return new(m_Name_,
            m_ControllerSize_,
            m_Controller_,
            m_TOS_,
            m_AnimationClips_,
            m_StateMachineBehaviourVectorDescription_,
            m_StateMachineBehaviours_,
            m_MultiThreadedStateMachine_);
    }

    public override string ToString() => $"AnimatorController\n{ToString(4)}";

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
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ControllerSize: {m_ControllerSize}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Controller: {{ \n{m_Controller.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_TOS[{m_TOS.Count}] = {{");
        if (m_TOS.Count > 0) sb.AppendLine();
        int _4i = 0;
        foreach (KeyValuePair<uint, AsciiString> _4 in m_TOS)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4.Key}] = \"{_4.Value}\"");
            ++_4i;
        }
        if (m_TOS.Count > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_AnimationClips[{m_AnimationClips.Length}] = {{");
        if (m_AnimationClips.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtr<AnimationClip> _4 in m_AnimationClips)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_AnimationClips.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_StateMachineBehaviourVectorDescription: {{ \n{m_StateMachineBehaviourVectorDescription.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_StateMachineBehaviours[{m_StateMachineBehaviours.Length}] = {{");
        if (m_StateMachineBehaviours.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtr<MonoBehaviour> _4 in m_StateMachineBehaviours)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_StateMachineBehaviours.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MultiThreadedStateMachine: {m_MultiThreadedStateMachine}");
    }
}

