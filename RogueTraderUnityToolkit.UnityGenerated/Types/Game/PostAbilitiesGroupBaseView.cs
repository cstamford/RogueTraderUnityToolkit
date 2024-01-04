namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PostAbilitiesGroupBaseView (5 fields) 0547C6BB9C39811F335996444E2331FB/1644B5AE7AD47E575DBE0C1CB52246C4 */
public record class PostAbilitiesGroupBaseView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<PostAbilityView>[] m_AbilitySlots /* NeedsAlign */)
{
    public static PostAbilitiesGroupBaseView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_AbilitySlots */
        PPtr<PostAbilityView>[] _m_AbilitySlots = BuiltInArray<PPtr<PostAbilityView>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_AbilitySlots);
    }
}

