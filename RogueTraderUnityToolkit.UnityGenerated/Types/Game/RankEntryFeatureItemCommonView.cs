namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $RankEntryFeatureItemCommonView (12 fields) 3A38A1A22E0C733F7C8071987997C3A8/6D040D1092A29790FBF51C9D2E79D6FA */
public record class RankEntryFeatureItemCommonView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CharInfoFeatureSimpleBaseView> m_CharInfoRankEntryView /* NeedsAlign */,
    PPtr<OwlcatMultiButton> m_MainButton /* None */,
    byte m_IsListEntry /* None */,
    PPtr<GameObject> m_FocusedMark /* NeedsAlign */,
    PPtr<GameObject> m_SelectedMark /* None */,
    PPtr<Image> m_RecommendMark /* None */,
    PPtr<OwlcatToggle> m_FavoritesToggle /* None */,
    PPtr<CanvasGroup> m_FavoritesCanvasGroup /* None */)
{
    public static RankEntryFeatureItemCommonView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CharInfoRankEntryView */
        PPtr<CharInfoFeatureSimpleBaseView> _m_CharInfoRankEntryView = PPtr<CharInfoFeatureSimpleBaseView>.Read(reader);
        PPtr<OwlcatMultiButton> _m_MainButton = PPtr<OwlcatMultiButton>.Read(reader);
        byte _m_IsListEntry = reader.ReadU8();
        reader.AlignTo(4); /* m_FocusedMark */
        PPtr<GameObject> _m_FocusedMark = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_SelectedMark = PPtr<GameObject>.Read(reader);
        PPtr<Image> _m_RecommendMark = PPtr<Image>.Read(reader);
        PPtr<OwlcatToggle> _m_FavoritesToggle = PPtr<OwlcatToggle>.Read(reader);
        PPtr<CanvasGroup> _m_FavoritesCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CharInfoRankEntryView,
            _m_MainButton,
            _m_IsListEntry,
            _m_FocusedMark,
            _m_SelectedMark,
            _m_RecommendMark,
            _m_FavoritesToggle,
            _m_FavoritesCanvasGroup);
    }
}

