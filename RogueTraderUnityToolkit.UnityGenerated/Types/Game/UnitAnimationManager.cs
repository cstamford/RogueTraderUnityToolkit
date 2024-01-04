namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UnitAnimationManager (6 fields) 4C5657844CB3D51BC654BB4EBDB618A8/A7432343F0D54BACA5C453F4EC51886E */
public record class UnitAnimationManager(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<AnimationSet> m_AnimationSet /* NeedsAlign */,
    byte m_FireEvents /* None */)
{
    public static UnitAnimationManager Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_AnimationSet */
        PPtr<AnimationSet> _m_AnimationSet = PPtr<AnimationSet>.Read(reader);
        byte _m_FireEvents = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_AnimationSet,
            _m_FireEvents);
    }
}

