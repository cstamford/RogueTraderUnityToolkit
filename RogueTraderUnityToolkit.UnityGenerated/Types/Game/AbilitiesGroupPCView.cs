namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AbilitiesGroupPCView (5 fields) 6DBE206A48EBA436C6E13486A0B40CEB/ABF30E1CC4FBEE5B5F2E2414501EF40B */
public record class AbilitiesGroupPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ActionBarBaseSlotView>[] m_AbilitySlots /* NeedsAlign */)
{
    public static AbilitiesGroupPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_AbilitySlots */
        PPtr<ActionBarBaseSlotView>[] _m_AbilitySlots = BuiltInArray<PPtr<ActionBarBaseSlotView>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_AbilitySlots);
    }
}

