namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoFeatureGroupConsoleView (8 fields) 75452DEFE675BFC5282353FC100ABA51/3D5E0C457F1B64D23FA7BF43AEA4DF25 */
public record class CharInfoFeatureGroupConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Label /* NeedsAlign */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<CharInfoFeatureBaseView> m_WidgetEntityView /* None */,
    PPtr<ExpandableCollapseMultiButtonPC> m_ExpandableElement /* None */)
{
    public static CharInfoFeatureGroupConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Label */
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<CharInfoFeatureBaseView> _m_WidgetEntityView = PPtr<CharInfoFeatureBaseView>.Read(reader);
        PPtr<ExpandableCollapseMultiButtonPC> _m_ExpandableElement = PPtr<ExpandableCollapseMultiButtonPC>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Label,
            _m_WidgetList,
            _m_WidgetEntityView,
            _m_ExpandableElement);
    }
}

