namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VendorSelectingWindowPCView (9 fields) 222F6C1ED0BFC6C3A9C4E6DA94432DF8/16870834FFFE161CDB8DE7A0E2F65D7B */
public record class VendorSelectingWindowPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<CharInfoFactionReputationItemPCView> m_FactionReputationItemPCView /* None */,
    PPtr<TextMeshProUGUI> m_Header /* None */,
    PPtr<OwlcatButton> CloseButton /* None */)
{
    public static VendorSelectingWindowPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<CharInfoFactionReputationItemPCView> _m_FactionReputationItemPCView = PPtr<CharInfoFactionReputationItemPCView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Header = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _CloseButton = PPtr<OwlcatButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_WidgetList,
            _m_FactionReputationItemPCView,
            _m_Header,
            _CloseButton);
    }
}

