namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $EncyclopediaConsoleView (14 fields) 2D2E29379F3D121F78ED08A8D4AE3F61/A7BCDBCC32DD03B6D94EDDA34337180F */
public record class EncyclopediaConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<PantographView> m_PantographView /* NeedsAlign */,
    PPtr<EncyclopediaNavigationBaseView> m_Navigation /* None */,
    PPtr<EncyclopediaPageBaseView> m_Page /* None */,
    PPtr<TextMeshProUGUI> m_Title /* None */,
    PPtr<ConsoleHintsWidget> m_ConsoleHintsWidget /* None */,
    PPtr<CanvasSortingComponent> m_CanvasSortingComponent /* None */,
    NavigationParameters m_NavigationParameters /* None */,
    PPtr<OwlcatMultiButton> m_FirstGlossaryFocus /* NeedsAlign */,
    PPtr<OwlcatMultiButton> m_SecondGlossaryFocus /* None */,
    PPtr<RectTransform> m_TooltipPlace /* None */)
{
    public static EncyclopediaConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_PantographView */
        PPtr<PantographView> _m_PantographView = PPtr<PantographView>.Read(reader);
        PPtr<EncyclopediaNavigationBaseView> _m_Navigation = PPtr<EncyclopediaNavigationBaseView>.Read(reader);
        PPtr<EncyclopediaPageBaseView> _m_Page = PPtr<EncyclopediaPageBaseView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_ConsoleHintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        PPtr<CanvasSortingComponent> _m_CanvasSortingComponent = PPtr<CanvasSortingComponent>.Read(reader);
        NavigationParameters _m_NavigationParameters = NavigationParameters.Read(reader);
        reader.AlignTo(4); /* m_FirstGlossaryFocus */
        PPtr<OwlcatMultiButton> _m_FirstGlossaryFocus = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_SecondGlossaryFocus = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<RectTransform> _m_TooltipPlace = PPtr<RectTransform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PantographView,
            _m_Navigation,
            _m_Page,
            _m_Title,
            _m_ConsoleHintsWidget,
            _m_CanvasSortingComponent,
            _m_NavigationParameters,
            _m_FirstGlossaryFocus,
            _m_SecondGlossaryFocus,
            _m_TooltipPlace);
    }
}

