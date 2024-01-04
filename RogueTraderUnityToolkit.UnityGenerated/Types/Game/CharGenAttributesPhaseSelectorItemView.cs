namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenAttributesPhaseSelectorItemView (12 fields) 4B30C0D43BAFAF027088B48812B24B0B/9F9AA969AA5D3F30A77156F76A4160EB */
public record class CharGenAttributesPhaseSelectorItemView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_Button /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_DisplayName /* None */,
    PPtr<TextMeshProUGUI> m_StatValue /* None */,
    PPtr<OwlcatMultiSelectable> m_StatValueSelectable /* None */,
    PPtr<TextMeshProUGUI> m_ShortLabel /* None */,
    PPtr<CharGenAttributesPhasePantographItemView> m_PantographItemView /* None */,
    PPtr<OwlcatMultiButton> m_RanksButton /* None */,
    PPtr<GameObject>[] m_FullRanks /* None */)
{
    public static CharGenAttributesPhaseSelectorItemView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Button */
        PPtr<OwlcatMultiButton> _m_Button = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DisplayName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_StatValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiSelectable> _m_StatValueSelectable = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ShortLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CharGenAttributesPhasePantographItemView> _m_PantographItemView = PPtr<CharGenAttributesPhasePantographItemView>.Read(reader);
        PPtr<OwlcatMultiButton> _m_RanksButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<GameObject>[] _m_FullRanks = BuiltInArray<PPtr<GameObject>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Button,
            _m_DisplayName,
            _m_StatValue,
            _m_StatValueSelectable,
            _m_ShortLabel,
            _m_PantographItemView,
            _m_RanksButton,
            _m_FullRanks);
    }
}

