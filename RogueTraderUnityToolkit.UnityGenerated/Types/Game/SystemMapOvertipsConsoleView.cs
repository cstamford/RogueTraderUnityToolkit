namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SystemMapOvertipsConsoleView (8 fields) 1E485B2838A91B824DCF659741488982/671200239FB6387A184BE49325EA75B8 */
public record class SystemMapOvertipsConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_SystemObjectsContainer /* NeedsAlign */,
    PPtr<OvertipSystemObjectConsoleView> m_OvertipSystemObjectPCView /* None */,
    PPtr<OvertipPlanetConsoleView> m_OvertipPlanetPCView /* None */,
    PPtr<OvertipAnomalyConsoleView> m_OvertipAnomalyPCView /* None */)
{
    public static SystemMapOvertipsConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SystemObjectsContainer */
        PPtr<RectTransform> _m_SystemObjectsContainer = PPtr<RectTransform>.Read(reader);
        PPtr<OvertipSystemObjectConsoleView> _m_OvertipSystemObjectPCView = PPtr<OvertipSystemObjectConsoleView>.Read(reader);
        PPtr<OvertipPlanetConsoleView> _m_OvertipPlanetPCView = PPtr<OvertipPlanetConsoleView>.Read(reader);
        PPtr<OvertipAnomalyConsoleView> _m_OvertipAnomalyPCView = PPtr<OvertipAnomalyConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SystemObjectsContainer,
            _m_OvertipSystemObjectPCView,
            _m_OvertipPlanetPCView,
            _m_OvertipAnomalyPCView);
    }
}

