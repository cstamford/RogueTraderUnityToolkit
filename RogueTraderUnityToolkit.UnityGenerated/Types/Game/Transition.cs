namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $Transition (9 fields) 6ACE2B2416FE2D23FBE6D93F69E768DE/749D2C1D13AED50FD3A452D4D2FB8760 */
public record class Transition(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<AnimationActionBase> FromAction /* NeedsAlign */,
    PPtr<AnimationClip> FromClip /* None */,
    PPtr<AnimationActionBase> ToAction /* None */,
    PPtr<AnimationClip> ToClip /* None */,
    float Duration /* None */)
{
    public static Transition Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* FromAction */
        PPtr<AnimationActionBase> _FromAction = PPtr<AnimationActionBase>.Read(reader);
        PPtr<AnimationClip> _FromClip = PPtr<AnimationClip>.Read(reader);
        PPtr<AnimationActionBase> _ToAction = PPtr<AnimationActionBase>.Read(reader);
        PPtr<AnimationClip> _ToClip = PPtr<AnimationClip>.Read(reader);
        float _Duration = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _FromAction,
            _FromClip,
            _ToAction,
            _ToClip,
            _Duration);
    }
}

