namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $AnimatorController (8 fields) 8AE382FCA491ECA479D3EA2BA8D38A3B */
public record class AnimatorController(
    AsciiString m_Name,
    uint m_ControllerSize,
    ControllerConstant m_Controller,
    Dictionary<uint, AsciiString> m_TOS,
    PPtr<AnimationClip>[] m_AnimationClips,
    StateMachineBehaviourVectorDescription m_StateMachineBehaviourVectorDescription,
    PPtr<MonoBehaviour>[] m_StateMachineBehaviours,
    bool m_MultiThreadedStateMachine) : IUnityEngineStructure
{
    public static Hash128 Hash => new(2330166012, 2761026724, 2043931179, 2832435771);

    public static AnimatorController Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        uint _m_ControllerSize = reader.ReadU32();
        ControllerConstant _m_Controller = ControllerConstant.Read(reader);
        reader.AlignTo(4); /* m_Controller */
        Dictionary<uint, AsciiString> _m_TOS = BuiltInMap<uint, AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_TOS */
        PPtr<AnimationClip>[] _m_AnimationClips = BuiltInArray<PPtr<AnimationClip>>.Read(reader);
        reader.AlignTo(4); /* m_AnimationClips */
        StateMachineBehaviourVectorDescription _m_StateMachineBehaviourVectorDescription = StateMachineBehaviourVectorDescription.Read(reader);
        reader.AlignTo(4); /* m_StateMachineBehaviourVectorDescription */
        PPtr<MonoBehaviour>[] _m_StateMachineBehaviours = BuiltInArray<PPtr<MonoBehaviour>>.Read(reader);
        reader.AlignTo(4); /* m_StateMachineBehaviours */
        bool _m_MultiThreadedStateMachine = reader.ReadBool();
        reader.AlignTo(4); /* m_MultiThreadedStateMachine */
        
        return new(_m_Name,
            _m_ControllerSize,
            _m_Controller,
            _m_TOS,
            _m_AnimationClips,
            _m_StateMachineBehaviourVectorDescription,
            _m_StateMachineBehaviours,
            _m_MultiThreadedStateMachine);
    }

    public override string ToString() => $"AnimatorController\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ControllerSize: ");
        sb.AppendLine(m_ControllerSize.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Controller: ");
        sb.AppendLine();
        sb.Append(m_Controller.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TOS: ");
        sb.AppendLine(m_TOS.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AnimationClips: ");
        sb.AppendLine(m_AnimationClips.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StateMachineBehaviourVectorDescription: ");
        sb.AppendLine();
        sb.Append(m_StateMachineBehaviourVectorDescription.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StateMachineBehaviours: ");
        sb.AppendLine(m_StateMachineBehaviours.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MultiThreadedStateMachine: ");
        sb.AppendLine(m_MultiThreadedStateMachine.ToString());

        return sb.ToString();
    }
}

