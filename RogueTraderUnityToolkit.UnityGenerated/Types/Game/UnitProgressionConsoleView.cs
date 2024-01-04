namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UnitProgressionConsoleView (10 fields) 614A2D9F1AAC839DB69965CCA4B26636/0A9CB148E0CC63B5ACED9536A78B83A0 */
public record class UnitProgressionConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<GameObject> m_BreadcrumbsSlashes /* None */,
    PPtr<ProgressionBreadcrumbsItemCommonView> m_ProgressionBreadcrumbsItemCommonView /* None */,
    PPtr<CareerPathsListsCommonView> m_CareerPathsListsCommonView /* None */,
    PPtr<CareerPathProgressionCommonView> m_CareerPathProgressionCommonView /* None */)
{
    public static UnitProgressionConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<GameObject> _m_BreadcrumbsSlashes = PPtr<GameObject>.Read(reader);
        PPtr<ProgressionBreadcrumbsItemCommonView> _m_ProgressionBreadcrumbsItemCommonView = PPtr<ProgressionBreadcrumbsItemCommonView>.Read(reader);
        PPtr<CareerPathsListsCommonView> _m_CareerPathsListsCommonView = PPtr<CareerPathsListsCommonView>.Read(reader);
        PPtr<CareerPathProgressionCommonView> _m_CareerPathProgressionCommonView = PPtr<CareerPathProgressionCommonView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_WidgetList,
            _m_BreadcrumbsSlashes,
            _m_ProgressionBreadcrumbsItemCommonView,
            _m_CareerPathsListsCommonView,
            _m_CareerPathProgressionCommonView);
    }
}

