namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AllSystemsInformationWindowPCView (11 fields) EEDB4998FAF5B36E20D96F4B3B6FF9A3/D810E0BAC63C5C5F003A2A2C98793F76 */
public record class AllSystemsInformationWindowPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_AllSystemsLabel /* NeedsAlign */,
    PPtr<WidgetListMVVM> m_SystemsWidgetList /* None */,
    float m_ShowPosX /* None */,
    float m_HidePosX /* None */,
    PPtr<ScrollRectExtended> m_ScrollRectExtended /* None */,
    PPtr<OwlcatButton> m_CloseButton /* None */,
    PPtr<SystemInfoAllSystemsInformationWindowPCView> m_SystemInfoAllSystemsInformationWindowPCViewPrefab /* None */)
{
    public static AllSystemsInformationWindowPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_AllSystemsLabel */
        PPtr<TextMeshProUGUI> _m_AllSystemsLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<WidgetListMVVM> _m_SystemsWidgetList = PPtr<WidgetListMVVM>.Read(reader);
        float _m_ShowPosX = reader.ReadF32();
        float _m_HidePosX = reader.ReadF32();
        PPtr<ScrollRectExtended> _m_ScrollRectExtended = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<OwlcatButton> _m_CloseButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<SystemInfoAllSystemsInformationWindowPCView> _m_SystemInfoAllSystemsInformationWindowPCViewPrefab = PPtr<SystemInfoAllSystemsInformationWindowPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_AllSystemsLabel,
            _m_SystemsWidgetList,
            _m_ShowPosX,
            _m_HidePosX,
            _m_ScrollRectExtended,
            _m_CloseButton,
            _m_SystemInfoAllSystemsInformationWindowPCViewPrefab);
    }
}

