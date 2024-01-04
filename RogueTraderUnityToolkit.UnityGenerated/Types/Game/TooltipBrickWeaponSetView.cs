namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickWeaponSetView (16 fields) F5A787779826161A0F1AA7031C9EE134/6708E80561BBDF09DB197C2ABF55F0DA */
public record class TooltipBrickWeaponSetView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<HandSlotView> m_HandSlotView /* NeedsAlign */,
    PPtr<GameObject> m_BulletsBlock /* None */,
    PPtr<GameObject> m_RateOfFireBlock /* None */,
    PPtr<CharInfoWeaponSetAbilityPCView> m_WeaponSetAbilityViewPrefab /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<TextMeshProUGUI> m_Title /* None */,
    PPtr<TextMeshProUGUI> m_DamageLabel /* None */,
    PPtr<TextMeshProUGUI> m_BulletsLabel /* None */,
    PPtr<TextMeshProUGUI> m_PenetrationLabel /* None */,
    PPtr<TextMeshProUGUI> m_DistanceLabel /* None */,
    PPtr<TextMeshProUGUI> m_RateOfFireLabel /* None */,
    ColorRGBA m_templateTextColor /* None */)
{
    public static TooltipBrickWeaponSetView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HandSlotView */
        PPtr<HandSlotView> _m_HandSlotView = PPtr<HandSlotView>.Read(reader);
        PPtr<GameObject> _m_BulletsBlock = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_RateOfFireBlock = PPtr<GameObject>.Read(reader);
        PPtr<CharInfoWeaponSetAbilityPCView> _m_WeaponSetAbilityViewPrefab = PPtr<CharInfoWeaponSetAbilityPCView>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DamageLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_BulletsLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PenetrationLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DistanceLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RateOfFireLabel = PPtr<TextMeshProUGUI>.Read(reader);
        ColorRGBA _m_templateTextColor = ColorRGBA.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HandSlotView,
            _m_BulletsBlock,
            _m_RateOfFireBlock,
            _m_WeaponSetAbilityViewPrefab,
            _m_WidgetList,
            _m_Title,
            _m_DamageLabel,
            _m_BulletsLabel,
            _m_PenetrationLabel,
            _m_DistanceLabel,
            _m_RateOfFireLabel,
            _m_templateTextColor);
    }
}

