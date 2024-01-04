namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyProjectsBuiltListPCView (6 fields) 88D5FE6FAB1A873DD29F9E0745E8F230/73282A8600843B86F3865C5E2CBF5BB0 */
public record class ColonyProjectsBuiltListPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ColonyProjectsBuiltListAddElemPCView> m_ColonyProjectsBuiltListAddElemPCView /* NeedsAlign */,
    PPtr<ColonyProjectsBuiltListElemPCView>[] m_ColonyProjects /* None */)
{
    public static ColonyProjectsBuiltListPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ColonyProjectsBuiltListAddElemPCView */
        PPtr<ColonyProjectsBuiltListAddElemPCView> _m_ColonyProjectsBuiltListAddElemPCView = PPtr<ColonyProjectsBuiltListAddElemPCView>.Read(reader);
        PPtr<ColonyProjectsBuiltListElemPCView>[] _m_ColonyProjects = BuiltInArray<PPtr<ColonyProjectsBuiltListElemPCView>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ColonyProjectsBuiltListAddElemPCView,
            _m_ColonyProjects);
    }
}

