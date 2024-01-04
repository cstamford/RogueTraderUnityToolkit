namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyProjectsNavigationPCView (8 fields) 96D6816F346B1F5A12001EB8D22A7D65/26A9B82820A3D269AEB3799B125656CF */
public record class ColonyProjectsNavigationPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    ColonyProjectsNavigationBlock m_ColonyProjectsNavigationBlocks /* NeedsAlign */,
    PPtr<ColonyProjectRankView>[] m_ColonyProjectsRankItems /* None */,
    PPtr<ScrollRectExtended> m_ScrollRect /* None */,
    PPtr<ColonyProjectPCView> m_ColonyProjectViewPrefab /* None */)
{
    public static ColonyProjectsNavigationPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ColonyProjectsNavigationBlocks */
        ColonyProjectsNavigationBlock _m_ColonyProjectsNavigationBlocks = ColonyProjectsNavigationBlock.Read(reader);
        PPtr<ColonyProjectRankView>[] _m_ColonyProjectsRankItems = BuiltInArray<PPtr<ColonyProjectRankView>>.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<ColonyProjectPCView> _m_ColonyProjectViewPrefab = PPtr<ColonyProjectPCView>.Read(reader);
        
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

