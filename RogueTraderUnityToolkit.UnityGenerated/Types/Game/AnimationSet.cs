namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AnimationSet (9 fields) 484F22F8EA0EA12BE3D4B660854FB84B/96E87CEA596DB3AA1FDDAFD650F6BC8B */
public record class AnimationSet(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<AnimationActionBase> m_StartupAction /* NeedsAlign */,
    PPtr<AnimationActionBase>[] m_Actions /* None */,
    PPtr<Transition>[] m_Transitions /* None */,
    AnimationSequence[] m_Sequences /* None */,
    PPtr<UnitAnimationSetSpecialAttacks> m_SpecialAttacks /* None */)
{
    public static AnimationSet Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_StartupAction */
        PPtr<AnimationActionBase> _m_StartupAction = PPtr<AnimationActionBase>.Read(reader);
        PPtr<AnimationActionBase>[] _m_Actions = BuiltInArray<PPtr<AnimationActionBase>>.Read(reader);
        PPtr<Transition>[] _m_Transitions = BuiltInArray<PPtr<Transition>>.Read(reader);
        AnimationSequence[] _m_Sequences = BuiltInArray<AnimationSequence>.Read(reader);
        PPtr<UnitAnimationSetSpecialAttacks> _m_SpecialAttacks = PPtr<UnitAnimationSetSpecialAttacks>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_StartupAction,
            _m_Actions,
            _m_Transitions,
            _m_Sequences,
            _m_SpecialAttacks);
    }
}

