namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $RankExpCounterCommonView (14 fields) C8E23D9EAC9E4F4CEEE2F971A1552965/3D09E561A1C72B304D5FFE6B36D28EF0 */
public record class RankExpCounterCommonView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_LayoutRect /* NeedsAlign */,
    byte n_HasNewRanks /* None */,
    PPtr<GameObject> m_RanksContainer /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_RanksDesc /* None */,
    PPtr<TextMeshProUGUI> m_RanksCount /* None */,
    byte n_HasExp /* None */,
    PPtr<TextMeshProUGUI> m_ExpLabel /* NeedsAlign */,
    PPtr<Image> m_ExpProgressBar /* None */,
    byte n_HasLevel /* None */,
    PPtr<TextMeshProUGUI> m_CurrentLevelLabel /* NeedsAlign */)
{
    public static RankExpCounterCommonView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_LayoutRect */
        PPtr<RectTransform> _m_LayoutRect = PPtr<RectTransform>.Read(reader);
        byte _n_HasNewRanks = reader.ReadU8();
        reader.AlignTo(4); /* m_RanksContainer */
        PPtr<GameObject> _m_RanksContainer = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RanksDesc = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RanksCount = PPtr<TextMeshProUGUI>.Read(reader);
        byte _n_HasExp = reader.ReadU8();
        reader.AlignTo(4); /* m_ExpLabel */
        PPtr<TextMeshProUGUI> _m_ExpLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_ExpProgressBar = PPtr<Image>.Read(reader);
        byte _n_HasLevel = reader.ReadU8();
        reader.AlignTo(4); /* m_CurrentLevelLabel */
        PPtr<TextMeshProUGUI> _m_CurrentLevelLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_LayoutRect,
            _n_HasNewRanks,
            _m_RanksContainer,
            _m_RanksDesc,
            _m_RanksCount,
            _n_HasExp,
            _m_ExpLabel,
            _m_ExpProgressBar,
            _n_HasLevel,
            _m_CurrentLevelLabel);
    }
}

