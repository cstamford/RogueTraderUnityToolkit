namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AudioZoneTriggerableSwitch (7 fields) 6D49CDF8C4CF0EA2978E8008E5DCB08B/D17543142ED68233D7A420466A7F3E66 */
public record class AudioZoneTriggerableSwitch(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_SelectedEvents /* NeedsAlign */,
    AABB m_Bounds /* NeedsAlign */,
    AkSwitchReference m_Switch /* None */)
{
    public static AudioZoneTriggerableSwitch Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SelectedEvents */
        byte _m_SelectedEvents = reader.ReadU8();
        reader.AlignTo(4); /* m_Bounds */
        AABB _m_Bounds = AABB.Read(reader);
        AkSwitchReference _m_Switch = AkSwitchReference.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SelectedEvents,
            _m_Bounds,
            _m_Switch);
    }
}

