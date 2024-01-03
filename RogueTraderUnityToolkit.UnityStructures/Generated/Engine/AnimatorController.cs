namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $AnimatorController (8 fields) (IsEngineType) */
public record class AnimatorController(
    AsciiString m_Name,
    uint m_ControllerSize,
    ControllerConstant m_Controller,
    Dictionary<uint, AsciiString> m_TOS,
    PPtr<AnimationClip>[] m_AnimationClips,
    StateMachineBehaviourVectorDescription m_StateMachineBehaviourVectorDescription,
    PPtr<MonoBehaviour>[] m_StateMachineBehaviours,
    bool m_MultiThreadedStateMachine)
{
    public static AnimatorController Read(EndianBinaryReader reader)
    {
        AsciiString m_Name = String.Read(reader);
        uint m_ControllerSize = reader.ReadU32();
        ControllerConstant m_Controller = ControllerConstant.Read(reader);
        Dictionary<uint, AsciiString> m_TOS = Map<uint, AsciiString>.Read(reader);
        PPtr<AnimationClip>[] m_AnimationClips = Array<PPtr<AnimationClip>>.Read(reader);
        StateMachineBehaviourVectorDescription m_StateMachineBehaviourVectorDescription = StateMachineBehaviourVectorDescription.Read(reader);
        PPtr<MonoBehaviour>[] m_StateMachineBehaviours = Array<PPtr<MonoBehaviour>>.Read(reader);
        bool m_MultiThreadedStateMachine = reader.ReadBool();
        
        return new(m_Name,
            m_ControllerSize,
            m_Controller,
            m_TOS,
            m_AnimationClips,
            m_StateMachineBehaviourVectorDescription,
            m_StateMachineBehaviours,
            m_MultiThreadedStateMachine);
    }
}

