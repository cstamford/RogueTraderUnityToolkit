namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyProjectsBuiltListConsoleView (6 fields) 1728C3296CA277064683D114799473DF/B5764FE555979C96DE85480787ACAD89 */
public record class ColonyProjectsBuiltListConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ColonyProjectsBuiltListAddElemConsoleView> m_ColonyProjectsBuiltListAddElemConsoleView /* NeedsAlign */,
    PPtr<ColonyProjectsBuiltListElemConsoleView>[] m_ColonyProjects /* None */)
{
    public static ColonyProjectsBuiltListConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ColonyProjectsBuiltListAddElemConsoleView */
        PPtr<ColonyProjectsBuiltListAddElemConsoleView> _m_ColonyProjectsBuiltListAddElemConsoleView = PPtr<ColonyProjectsBuiltListAddElemConsoleView>.Read(reader);
        PPtr<ColonyProjectsBuiltListElemConsoleView>[] _m_ColonyProjects = BuiltInArray<PPtr<ColonyProjectsBuiltListElemConsoleView>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ColonyProjectsBuiltListAddElemConsoleView,
            _m_ColonyProjects);
    }
}

