namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CargoRewardsPCView (10 fields) 3AF66C008D9FA63A08E132D0882718C6/F8EE5D442F68535C63CD49251EC2074B */
public record class CargoRewardsPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_HeaderLabel /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_LootRewardsLabel /* None */,
    PPtr<WidgetListMVVM> m_WidgetListCargoes /* None */,
    PPtr<CargoRewardSlotView> m_CargoRewardSlotPrefab /* None */,
    PPtr<OwlcatButton> m_CompleteButton /* None */,
    PPtr<TextMeshProUGUI> m_CompleteButtonLabel /* None */)
{
    public static CargoRewardsPCView Read(EndianBinaryReader reader)
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
        PPtr<OwlcatButton> _m_CompleteButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CompleteButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HeaderLabel,
            _m_LootRewardsLabel,
            _m_WidgetListCargoes,
            _m_CargoRewardSlotPrefab,
            _m_CompleteButton,
            _m_CompleteButtonLabel);
    }
}

