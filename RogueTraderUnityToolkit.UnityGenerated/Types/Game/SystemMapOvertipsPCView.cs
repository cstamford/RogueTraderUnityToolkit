namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SystemMapOvertipsPCView (8 fields) F606D09E999DF1439C1A281F9097FEE6/F84342BEBEFBEC1010A0D578F080D0C9 */
public record class SystemMapOvertipsPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_SystemObjectsContainer /* NeedsAlign */,
    PPtr<OvertipSystemObjectPCView> m_OvertipSystemObjectPCView /* None */,
    PPtr<OvertipPlanetPCView> m_OvertipPlanetPCView /* None */,
    PPtr<OvertipAnomalyPCView> m_OvertipAnomalyPCView /* None */)
{
    public static SystemMapOvertipsPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SystemObjectsContainer */
        PPtr<RectTransform> _m_SystemObjectsContainer = PPtr<RectTransform>.Read(reader);
        PPtr<OvertipSystemObjectPCView> _m_OvertipSystemObjectPCView = PPtr<OvertipSystemObjectPCView>.Read(reader);
        PPtr<OvertipPlanetPCView> _m_OvertipPlanetPCView = PPtr<OvertipPlanetPCView>.Read(reader);
        PPtr<OvertipAnomalyPCView> _m_OvertipAnomalyPCView = PPtr<OvertipAnomalyPCView>.Read(reader);
        
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

