namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CargoRewardsConsoleView (9 fields) 1D2CA600F0E491EDC20CBB979B9C444A/9F1112ABD7F8C81EF0EE94D51A4999FC */
public record class CargoRewardsConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_HeaderLabel /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_LootRewardsLabel /* None */,
    PPtr<WidgetListMVVM> m_WidgetListCargoes /* None */,
    PPtr<CargoRewardSlotView> m_CargoRewardSlotPrefab /* None */,
    PPtr<ConsoleHintsWidget> m_HintsWidget /* None */)
{
    public static CargoRewardsConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HeaderLabel */
        PPtr<TextMeshProUGUI> _m_HeaderLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_LootRewardsLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetListCargoes = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<CargoRewardSlotView> _m_CargoRewardSlotPrefab = PPtr<CargoRewardSlotView>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_HintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HeaderLabel,
            _m_LootRewardsLabel,
            _m_WidgetListCargoes,
            _m_CargoRewardSlotPrefab,
            _m_HintsWidget);
    }
}

