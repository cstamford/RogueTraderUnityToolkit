namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpaceOvertipsConsoleView (7 fields) DF2F109144938EF93849358DADD197E6/040F45AC7641A69B004F0437A75A034E */
public record class SpaceOvertipsConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<SystemMapOvertipsConsoleView> m_SystemMapOvertipsConsoleView /* NeedsAlign */,
    PPtr<SectorMapOvertipsConsoleView> m_SectorMapOvertipsConsoleView /* None */,
    PPtr<UnitOvertipsView> m_UnitOvertipsView /* None */)
{
    public static SpaceOvertipsConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SystemMapOvertipsConsoleView */
        PPtr<SystemMapOvertipsConsoleView> _m_SystemMapOvertipsConsoleView = PPtr<SystemMapOvertipsConsoleView>.Read(reader);
        PPtr<SectorMapOvertipsConsoleView> _m_SectorMapOvertipsConsoleView = PPtr<SectorMapOvertipsConsoleView>.Read(reader);
        PPtr<UnitOvertipsView> _m_UnitOvertipsView = PPtr<UnitOvertipsView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SystemMapOvertipsConsoleView,
            _m_SectorMapOvertipsConsoleView,
            _m_UnitOvertipsView);
    }
}

