namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $StatCheckLootUnitsPagePCView (11 fields) BCEFCC3B8206D87D71AD18E3BF6FBCC8/E514D9EAB248EAFF1DA0A4E6B8A57624 */
public record class StatCheckLootUnitsPagePCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_SwitchUnitSubHeaderLabel /* NeedsAlign */,
    PPtr<StatCheckLootUnitCardPCView> m_SelectedUnitCardSlot /* None */,
    PPtr<StatCheckLootSmallUnitCardPCView>[] m_SmallUnitSlots /* None */,
    PPtr<OwlcatToggleGroup> m_ToggleGroup /* None */,
    PPtr<OwlcatButton> m_BackWithoutConfirmUnitButton /* None */,
    PPtr<OwlcatButton> m_ConfirmUnitButton /* None */,
    PPtr<TextMeshProUGUI> m_ConfirmUnitButtonLabel /* None */)
{
    public static StatCheckLootUnitsPagePCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SwitchUnitSubHeaderLabel */
        PPtr<TextMeshProUGUI> _m_SwitchUnitSubHeaderLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<StatCheckLootUnitCardPCView> _m_SelectedUnitCardSlot = PPtr<StatCheckLootUnitCardPCView>.Read(reader);
        PPtr<StatCheckLootSmallUnitCardPCView>[] _m_SmallUnitSlots = BuiltInArray<PPtr<StatCheckLootSmallUnitCardPCView>>.Read(reader);
        PPtr<OwlcatToggleGroup> _m_ToggleGroup = PPtr<OwlcatToggleGroup>.Read(reader);
        PPtr<OwlcatButton> _m_BackWithoutConfirmUnitButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_ConfirmUnitButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ConfirmUnitButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SwitchUnitSubHeaderLabel,
            _m_SelectedUnitCardSlot,
            _m_SmallUnitSlots,
            _m_ToggleGroup,
            _m_BackWithoutConfirmUnitButton,
            _m_ConfirmUnitButton,
            _m_ConfirmUnitButtonLabel);
    }
}

