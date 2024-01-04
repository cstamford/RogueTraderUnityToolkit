namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyProjectsNavigationConsoleView (8 fields) 03044C725529C362C88743C5D0755C07/C593619D6C06EF55D95C5AFB1A9F43F1 */
public record class ColonyProjectsNavigationConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    ColonyProjectsNavigationBlock[] m_ColonyProjectsNavigationBlocks /* NeedsAlign */,
    PPtr<ColonyProjectRankView>[] m_ColonyProjectsRankItems /* None */,
    PPtr<ScrollRectExtended> m_ScrollRect /* None */,
    PPtr<ColonyProjectConsoleView> m_ColonyProjectViewPrefab /* None */)
{
    public static ColonyProjectsNavigationConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ColonyProjectsNavigationBlocks */
        ColonyProjectsNavigationBlock[] _m_ColonyProjectsNavigationBlocks = BuiltInArray<ColonyProjectsNavigationBlock>.Read(reader);
        PPtr<ColonyProjectRankView>[] _m_ColonyProjectsRankItems = BuiltInArray<PPtr<ColonyProjectRankView>>.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<ColonyProjectConsoleView> _m_ColonyProjectViewPrefab = PPtr<ColonyProjectConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ColonyProjectsNavigationBlocks,
            _m_ColonyProjectsRankItems,
            _m_ScrollRect,
            _m_ColonyProjectViewPrefab);
    }
}

