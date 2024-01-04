namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpaceOvertipsPCView (7 fields) F8C82B63C45C04C37565EC0CB2FC4528/16A08EDDDD6349B76A491FD5A8A56841 */
public record class SpaceOvertipsPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<SystemMapOvertipsPCView> m_SystemMapOvertipsPCView /* NeedsAlign */,
    PPtr<SectorMapOvertipsPCView> m_SectorMapOvertipsPCView /* None */,
    PPtr<UnitOvertipsView> m_UnitOvertipsPCView /* None */)
{
    public static SpaceOvertipsPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SystemMapOvertipsPCView */
        PPtr<SystemMapOvertipsPCView> _m_SystemMapOvertipsPCView = PPtr<SystemMapOvertipsPCView>.Read(reader);
        PPtr<SectorMapOvertipsPCView> _m_SectorMapOvertipsPCView = PPtr<SectorMapOvertipsPCView>.Read(reader);
        PPtr<UnitOvertipsView> _m_UnitOvertipsPCView = PPtr<UnitOvertipsView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SystemMapOvertipsPCView,
            _m_SectorMapOvertipsPCView,
            _m_UnitOvertipsPCView);
    }
}

