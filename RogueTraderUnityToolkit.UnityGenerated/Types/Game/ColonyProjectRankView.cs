namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyProjectRankView (7 fields) 6F9F0A92786B0B25D0C811E26909A3F6/8A42F59D30BE47CCC9EDE35A18BE6C0C */
public record class ColonyProjectRankView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_RankTitle /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_RankValue /* None */,
    PPtr<RectTransform> m_Container /* None */)
{
    public static ColonyProjectRankView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_RankTitle */
        PPtr<TextMeshProUGUI> _m_RankTitle = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RankValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<RectTransform> _m_Container = PPtr<RectTransform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_RankTitle,
            _m_RankValue,
            _m_Container);
    }
}

