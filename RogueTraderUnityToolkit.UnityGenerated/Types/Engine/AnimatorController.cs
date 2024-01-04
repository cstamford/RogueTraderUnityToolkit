namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $AnimatorController (8 fields) 8AE382FCA491ECA479D3EA2BA8D38A3B */
public record class AnimatorController(
    AsciiString m_Name /* None */,
    uint m_ControllerSize /* NeedsAlign */,
    ControllerConstant m_Controller /* None */,
    Dictionary<uint, AsciiString> m_TOS /* NeedsAlign */,
    PPtr<AnimationClip>[] m_AnimationClips /* NeedsAlign */,
    StateMachineBehaviourVectorDescription m_StateMachineBehaviourVectorDescription /* NeedsAlign */,
    PPtr<MonoBehaviour>[] m_StateMachineBehaviours /* NeedsAlign */,
    bool m_MultiThreadedStateMachine /* NeedsAlign */) : IUnityObject
{
    public static Hash128 Hash => new(2330166012, 2761026724, 2043931179, 2832435771);
    public static AnimatorController Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ControllerSize */
        uint _m_ControllerSize = reader.ReadU32();
        ControllerConstant _m_Controller = ControllerConstant.Read(reader);
        reader.AlignTo(4); /* m_TOS */
        Dictionary<uint, AsciiString> _m_TOS = BuiltInMap<uint, AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_AnimationClips */
        PPtr<AnimationClip>[] _m_AnimationClips = BuiltInArray<PPtr<AnimationClip>>.Read(reader);
        reader.AlignTo(4); /* m_StateMachineBehaviourVectorDescription */
        StateMachineBehaviourVectorDescription _m_StateMachineBehaviourVectorDescription = StateMachineBehaviourVectorDescription.Read(reader);
        reader.AlignTo(4); /* m_StateMachineBehaviours */
        PPtr<MonoBehaviour>[] _m_StateMachineBehaviours = BuiltInArray<PPtr<MonoBehaviour>>.Read(reader);
        reader.AlignTo(4); /* m_MultiThreadedStateMachine */
        bool _m_MultiThreadedStateMachine = reader.ReadBool();
        
        return new(_m_Name,
            _m_ControllerSize,
            _m_Controller,
            _m_TOS,
            _m_AnimationClips,
            _m_StateMachineBehaviourVectorDescription,
            _m_StateMachineBehaviours,
            _m_MultiThreadedStateMachine);
    }
}

