namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AllSystemsInformationWindowConsoleView (13 fields) C66F5568A3FAE985A1D1B24E92CA9CB1/7CEFD1EA3A5FF978FE6A0CCB14F47E84 */
public record class AllSystemsInformationWindowConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_AllSystemsLabel /* NeedsAlign */,
    PPtr<WidgetListMVVM> m_SystemsWidgetList /* None */,
    float m_ShowPosX /* None */,
    float m_HidePosX /* None */,
    PPtr<ScrollRectExtended> m_ScrollRectExtended /* None */,
    PPtr<SystemInfoAllSystemsInformationWindowConsoleView> m_SystemInfoAllSystemsInformationWindowConsoleViewPrefab /* None */,
    float m_ShowPosY /* None */,
    float m_MoveFrontX /* None */,
    float m_MoveFrontY /* None */)
{
    public static AllSystemsInformationWindowConsoleView Read(EndianBinaryReader reader)
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
        PPtr<SystemInfoAllSystemsInformationWindowConsoleView> _m_SystemInfoAllSystemsInformationWindowConsoleViewPrefab = PPtr<SystemInfoAllSystemsInformationWindowConsoleView>.Read(reader);
        float _m_ShowPosY = reader.ReadF32();
        float _m_MoveFrontX = reader.ReadF32();
        float _m_MoveFrontY = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_AllSystemsLabel,
            _m_SystemsWidgetList,
            _m_ShowPosX,
            _m_HidePosX,
            _m_ScrollRectExtended,
            _m_SystemInfoAllSystemsInformationWindowConsoleViewPrefab,
            _m_ShowPosY,
            _m_MoveFrontX,
            _m_MoveFrontY);
    }
}

