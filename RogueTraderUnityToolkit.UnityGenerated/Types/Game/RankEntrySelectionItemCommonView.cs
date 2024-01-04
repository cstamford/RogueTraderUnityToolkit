namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $RankEntrySelectionItemCommonView (12 fields) 4C6CA79A9073CE362E3023A7F10BD4D9/B2A9351DFEA06A44CC9F2E547CEBAB35 */
public record class RankEntrySelectionItemCommonView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CharInfoFeatureSimpleBaseView> m_CharInfoRankEntryView /* NeedsAlign */,
    PPtr<OwlcatMultiButton> m_MainButton /* None */,
    PPtr<Image> m_MainButtonImage /* None */,
    RankEntrySelectionStateSprites m_StateSprites /* None */,
    PPtr<UIHighlighter> m_UIHighlighter /* None */,
    byte m_IsListEntry /* None */,
    PPtr<TextMeshProUGUI> m_SelectionLabel /* NeedsAlign */,
    PPtr<GameObject> m_SelectedMark /* None */)
{
    public static RankEntrySelectionItemCommonView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CharInfoRankEntryView */
        PPtr<CharInfoFeatureSimpleBaseView> _m_CharInfoRankEntryView = PPtr<CharInfoFeatureSimpleBaseView>.Read(reader);
        PPtr<OwlcatMultiButton> _m_MainButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<Image> _m_MainButtonImage = PPtr<Image>.Read(reader);
        RankEntrySelectionStateSprites _m_StateSprites = RankEntrySelectionStateSprites.Read(reader);
        PPtr<UIHighlighter> _m_UIHighlighter = PPtr<UIHighlighter>.Read(reader);
        byte _m_IsListEntry = reader.ReadU8();
        reader.AlignTo(4); /* m_SelectionLabel */
        PPtr<TextMeshProUGUI> _m_SelectionLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_SelectedMark = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CharInfoRankEntryView,
            _m_MainButton,
            _m_MainButtonImage,
            _m_StateSprites,
            _m_UIHighlighter,
            _m_IsListEntry,
            _m_SelectionLabel,
            _m_SelectedMark);
    }
}

