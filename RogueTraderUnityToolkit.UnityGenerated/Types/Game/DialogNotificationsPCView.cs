namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DialogNotificationsPCView (23 fields) F74FD714A37A6AF4C0571DBDE483C871/88C3D6CA8424C90D0E386E5A682BE6A4 */
public record class DialogNotificationsPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_NotificationPhraseLocations /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_NotificationPhraseItemsReceived /* None */,
    PPtr<TextMeshProUGUI> m_NotificationPhraseItemsLost /* None */,
    PPtr<TextMeshProUGUI> m_NotificationProfitFactorChanged /* None */,
    PPtr<TextMeshProUGUI> m_NotificationXpGained /* None */,
    PPtr<TextMeshProUGUI> m_NotificationCargoAdded /* None */,
    PPtr<TextMeshProUGUI> m_NotificationCargoLost /* None */,
    PPtr<TextMeshProUGUI> m_NotificationDamageDealt /* None */,
    PPtr<TextMeshProUGUI> m_NotificationNavigatorResourceAdded /* None */,
    PPtr<TextMeshProUGUI> m_NotificationFactionReputationReceived /* None */,
    PPtr<TextMeshProUGUI> m_NotificationFactionReputationLost /* None */,
    PPtr<TextMeshProUGUI> m_NotificationFactionVendorDiscountReceived /* None */,
    PPtr<TextMeshProUGUI> m_NotificationFactionVendorDiscountLost /* None */,
    PPtr<TextMeshProUGUI> m_NotificationAbilityAdded /* None */,
    PPtr<TextMeshProUGUI> m_NotificationBuffAdded /* None */,
    PPtr<TextMeshProUGUI> m_NotificatoinSoulMarksShift /* None */,
    byte m_IsSpaceEvent /* None */,
    float m_DefaultFontSize /* NeedsAlign */,
    float m_DefaultConsoleFontSize /* None */)
{
    public static DialogNotificationsPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_NotificationPhraseLocations */
        PPtr<TextMeshProUGUI> _m_NotificationPhraseLocations = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NotificationPhraseItemsReceived = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NotificationPhraseItemsLost = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NotificationProfitFactorChanged = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NotificationXpGained = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NotificationCargoAdded = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NotificationCargoLost = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NotificationDamageDealt = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NotificationNavigatorResourceAdded = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NotificationFactionReputationReceived = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NotificationFactionReputationLost = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NotificationFactionVendorDiscountReceived = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NotificationFactionVendorDiscountLost = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NotificationAbilityAdded = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NotificationBuffAdded = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NotificatoinSoulMarksShift = PPtr<TextMeshProUGUI>.Read(reader);
        byte _m_IsSpaceEvent = reader.ReadU8();
        reader.AlignTo(4); /* m_DefaultFontSize */
        float _m_DefaultFontSize = reader.ReadF32();
        float _m_DefaultConsoleFontSize = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_NotificationPhraseLocations,
            _m_NotificationPhraseItemsReceived,
            _m_NotificationPhraseItemsLost,
            _m_NotificationProfitFactorChanged,
            _m_NotificationXpGained,
            _m_NotificationCargoAdded,
            _m_NotificationCargoLost,
            _m_NotificationDamageDealt,
            _m_NotificationNavigatorResourceAdded,
            _m_NotificationFactionReputationReceived,
            _m_NotificationFactionReputationLost,
            _m_NotificationFactionVendorDiscountReceived,
            _m_NotificationFactionVendorDiscountLost,
            _m_NotificationAbilityAdded,
            _m_NotificationBuffAdded,
            _m_NotificatoinSoulMarksShift,
            _m_IsSpaceEvent,
            _m_DefaultFontSize,
            _m_DefaultConsoleFontSize);
    }
}

