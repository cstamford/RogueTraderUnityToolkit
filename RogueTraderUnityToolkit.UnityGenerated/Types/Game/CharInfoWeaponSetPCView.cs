namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoWeaponSetPCView (15 fields) E3274D85D656B6FE11170FF0A92BF500/3A7F7628269E1F3029970B7BC62BF639 */
public record class CharInfoWeaponSetPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Title /* NeedsAlign */,
    PPtr<HandSlotView> m_PrimaryHandView /* None */,
    PPtr<HandSlotView> m_SecondaryHandView /* None */,
    PPtr<TextMeshProUGUI> m_DamageLabel /* None */,
    PPtr<TextMeshProUGUI> m_BulletsLabel /* None */,
    PPtr<TextMeshProUGUI> m_DistanceLabel /* None */,
    PPtr<TextMeshProUGUI> m_PenetrationLabel /* None */,
    PPtr<GameObject> m_BulletsBlock /* None */,
    PPtr<CharInfoWeaponSetAbilityPCView> m_WeaponSetAbilityViewPrefab /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    ColorRGBA m_templateTextColor /* None */)
{
    public static CharInfoWeaponSetPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Title */
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<HandSlotView> _m_PrimaryHandView = PPtr<HandSlotView>.Read(reader);
        PPtr<HandSlotView> _m_SecondaryHandView = PPtr<HandSlotView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DamageLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_BulletsLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DistanceLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PenetrationLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_BulletsBlock = PPtr<GameObject>.Read(reader);
        PPtr<CharInfoWeaponSetAbilityPCView> _m_WeaponSetAbilityViewPrefab = PPtr<CharInfoWeaponSetAbilityPCView>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        ColorRGBA _m_templateTextColor = ColorRGBA.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Title,
            _m_PrimaryHandView,
            _m_SecondaryHandView,
            _m_DamageLabel,
            _m_BulletsLabel,
            _m_DistanceLabel,
            _m_PenetrationLabel,
            _m_BulletsBlock,
            _m_WeaponSetAbilityViewPrefab,
            _m_WidgetList,
            _m_templateTextColor);
    }
}

