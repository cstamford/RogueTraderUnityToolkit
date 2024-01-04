namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FeedbackPopupPCView (8 fields) 38DA61913DCE74B00B4D373207ADF8B3/7AFF19C089057305AEB96FC043B1E9F7 */
public record class FeedbackPopupPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Title /* NeedsAlign */,
    PPtr<OwlcatButton> m_CloseButton /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<FeedbackPopupItemPCView> m_ItemPCView /* None */)
{
    public static FeedbackPopupPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Title */
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_CloseButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<FeedbackPopupItemPCView> _m_ItemPCView = PPtr<FeedbackPopupItemPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Title,
            _m_CloseButton,
            _m_WidgetList,
            _m_ItemPCView);
    }
}

