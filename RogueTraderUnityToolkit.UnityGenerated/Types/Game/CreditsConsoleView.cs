namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CreditsConsoleView (28 fields) 8923A879870C7EE90CE4B688932F1FF5/E028563789069108C8CCE3F25071EE82 */
public record class CreditsConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_TitleLabel /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_HeadLabel /* None */,
    PPtr<Transform> m_Content /* None */,
    PageGenerator m_PageGenerator /* None */,
    PPtr<CreditsMenuSelectorBaseView> m_MenuSelector /* None */,
    PPtr<FlexibleLensSelectorView> m_SelectorView /* None */,
    PPtr<TextMeshProUGUI> m_MessageLabel /* None */,
    PPtr<Image> m_Logo /* None */,
    PPtr<TextMeshProUGUI> m_PageCounterText /* None */,
    PPtr<OwlcatMultiButton> m_ButtonLeft /* None */,
    PPtr<OwlcatMultiButton> m_ButtonRight /* None */,
    PPtr<OwlcatMultiButton> m_PlayMultiButton /* None */,
    PPtr<TMP_InputField> m_SearchField /* None */,
    PPtr<OwlcatMultiButton> m_SearchButton /* None */,
    PPtr<TextMeshProUGUI> m_SearchButtonText /* None */,
    PPtr<CreditsOneColumnPage> m_OneColumnPrefab /* None */,
    PPtr<CreditsTwoColumnsPage> m_TwoColumnsPrefab /* None */,
    float m_PageDurationTime /* None */,
    float m_PingDelay /* None */,
    PPtr<ConsoleHint> m_PrevHint /* None */,
    PPtr<ConsoleHint> m_NextHint /* None */,
    PPtr<ConsoleHint> m_PlayRolesHint /* None */,
    PPtr<ConsoleInputField> m_ConsoleInputField /* None */,
    PPtr<ConsoleHintsWidget> m_ConsoleHintsWidget /* None */)
{
    public static CreditsConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TitleLabel */
        PPtr<TextMeshProUGUI> _m_TitleLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_HeadLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Transform> _m_Content = PPtr<Transform>.Read(reader);
        PageGenerator _m_PageGenerator = PageGenerator.Read(reader);
        PPtr<CreditsMenuSelectorBaseView> _m_MenuSelector = PPtr<CreditsMenuSelectorBaseView>.Read(reader);
        PPtr<FlexibleLensSelectorView> _m_SelectorView = PPtr<FlexibleLensSelectorView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_MessageLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_Logo = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PageCounterText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ButtonLeft = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ButtonRight = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_PlayMultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TMP_InputField> _m_SearchField = PPtr<TMP_InputField>.Read(reader);
        PPtr<OwlcatMultiButton> _m_SearchButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SearchButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CreditsOneColumnPage> _m_OneColumnPrefab = PPtr<CreditsOneColumnPage>.Read(reader);
        PPtr<CreditsTwoColumnsPage> _m_TwoColumnsPrefab = PPtr<CreditsTwoColumnsPage>.Read(reader);
        float _m_PageDurationTime = reader.ReadF32();
        float _m_PingDelay = reader.ReadF32();
        PPtr<ConsoleHint> _m_PrevHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_NextHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_PlayRolesHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleInputField> _m_ConsoleInputField = PPtr<ConsoleInputField>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_ConsoleHintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_TitleLabel,
            _m_HeadLabel,
            _m_Content,
            _m_PageGenerator,
            _m_MenuSelector,
            _m_SelectorView,
            _m_MessageLabel,
            _m_Logo,
            _m_PageCounterText,
            _m_ButtonLeft,
            _m_ButtonRight,
            _m_PlayMultiButton,
            _m_SearchField,
            _m_SearchButton,
            _m_SearchButtonText,
            _m_OneColumnPrefab,
            _m_TwoColumnsPrefab,
            _m_PageDurationTime,
            _m_PingDelay,
            _m_PrevHint,
            _m_NextHint,
            _m_PlayRolesHint,
            _m_ConsoleInputField,
            _m_ConsoleHintsWidget);
    }
}

