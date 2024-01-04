namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $RankEntryStatItemCommonView (11 fields) 2DBB6DEF7C2C3B2FC091402B04AFC3ED/96EC4C8410B44A803743BC83E300217E */
public record class RankEntryStatItemCommonView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_StatDisplayName /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_StatIncreaseText /* None */,
    PPtr<Image> m_RecommendMark /* None */,
    PPtr<GameObject> m_FocusedMark /* None */,
    PPtr<GameObject> m_ShortNameBlock /* None */,
    PPtr<TextMeshProUGUI> m_ShortName /* None */,
    PPtr<OwlcatMultiButton> m_MainButton /* None */)
{
    public static RankEntryStatItemCommonView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_StatDisplayName */
        PPtr<TextMeshProUGUI> _m_StatDisplayName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_StatIncreaseText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_RecommendMark = PPtr<Image>.Read(reader);
        PPtr<GameObject> _m_FocusedMark = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_ShortNameBlock = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ShortName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_MainButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_StatDisplayName,
            _m_StatIncreaseText,
            _m_RecommendMark,
            _m_FocusedMark,
            _m_ShortNameBlock,
            _m_ShortName,
            _m_MainButton);
    }
}

