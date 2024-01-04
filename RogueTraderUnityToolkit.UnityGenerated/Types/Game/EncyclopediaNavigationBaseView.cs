namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $EncyclopediaNavigationBaseView (11 fields) D4239CEF75D9ABB9D4D650B79F8A7800/78BC7121DD814A8FD0D28D3D651E8497 */
public record class EncyclopediaNavigationBaseView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<WidgetListMVVM> m_ChaptersWidgetList /* NeedsAlign */,
    PPtr<EncyclopediaNavigationElementBaseView> m_ChaptersNavigationViewPrefab /* None */,
    PPtr<WidgetListMVVM> m_PagesWidgetList /* None */,
    PPtr<EncyclopediaNavigationElementBaseView> m_PagesNavigationViewPrefab /* None */,
    PPtr<RectTransform> m_PaperTransform /* None */,
    PPtr<ScrollRectExtended> m_ScrollRectChapters /* None */,
    PPtr<ScrollRectExtended> m_ScrollRectPages /* None */)
{
    public static EncyclopediaNavigationBaseView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ChaptersWidgetList */
        PPtr<WidgetListMVVM> _m_ChaptersWidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<EncyclopediaNavigationElementBaseView> _m_ChaptersNavigationViewPrefab = PPtr<EncyclopediaNavigationElementBaseView>.Read(reader);
        PPtr<WidgetListMVVM> _m_PagesWidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<EncyclopediaNavigationElementBaseView> _m_PagesNavigationViewPrefab = PPtr<EncyclopediaNavigationElementBaseView>.Read(reader);
        PPtr<RectTransform> _m_PaperTransform = PPtr<RectTransform>.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollRectChapters = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollRectPages = PPtr<ScrollRectExtended>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ChaptersWidgetList,
            _m_ChaptersNavigationViewPrefab,
            _m_PagesWidgetList,
            _m_PagesNavigationViewPrefab,
            _m_PaperTransform,
            _m_ScrollRectChapters,
            _m_ScrollRectPages);
    }
}

