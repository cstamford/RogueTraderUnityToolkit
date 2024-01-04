namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $BugReportPCView (47 fields) 17BDE78CB61CDE020B3CCC1EB75789EA/0FD81BD243DE1A1D7DA162A2E8959F41 */
public record class BugReportPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_MainTitleText /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_AspectTitleText /* None */,
    PPtr<TextMeshProUGUI> m_ContextTitleText /* None */,
    PPtr<TextMeshProUGUI> m_SendButtonText /* None */,
    PPtr<TextMeshProUGUI> m_HintText /* None */,
    PPtr<TextMeshProUGUI> m_SuggestionToggleText /* None */,
    PPtr<TextMeshProUGUI> m_NormalToggleText /* None */,
    PPtr<TextMeshProUGUI> m_CriticalToggleText /* None */,
    PPtr<TextMeshProUGUI> m_DescriptionTitleText /* None */,
    PPtr<TextMeshProUGUI> m_EmailTitleText /* None */,
    PPtr<TextMeshProUGUI> m_BottomDescriptionText /* None */,
    PPtr<TextMeshProUGUI> m_PrivacyDescriptionText /* None */,
    PPtr<TextMeshProUGUI> m_DiscordTitleText /* None */,
    PPtr<TextMeshProUGUI> m_EmailUpdatesDescriptionText /* None */,
    PPtr<OwlcatMultiButton> m_CloseButton /* None */,
    PPtr<OwlcatMultiButton> m_DrawingButton /* None */,
    PPtr<OwlcatInputField> m_MessageInputField /* None */,
    PPtr<GameObject> m_EmailGroup /* None */,
    PPtr<OwlcatInputField> m_EmailInputField /* None */,
    PPtr<OwlcatInputField> m_DiscordInputField /* None */,
    PPtr<GameObject> m_DiscordGameObject /* None */,
    PPtr<OwlcatDropdown> m_ContextDropdown /* None */,
    PPtr<OwlcatDropdown> m_AspectDropdown /* None */,
    PPtr<GameObject> m_AssigneeGO /* None */,
    PPtr<OwlcatDropdown> m_AssigneeDropdown /* None */,
    PPtr<GameObject> m_FixVersionGO /* None */,
    PPtr<OwlcatDropdown> m_FixVersionDropdown /* None */,
    PPtr<OwlcatMultiButton> m_SendButton /* None */,
    PPtr<OwlcatToggleGroup> m_IssueTypeToggleGroup /* None */,
    PPtr<OwlcatToggle> m_CriticalToggle /* None */,
    PPtr<OwlcatToggle> m_NormalToggle /* None */,
    PPtr<OwlcatToggle> m_SuggestionToggle /* None */,
    PPtr<GameObject> m_LabelsGroup /* None */,
    PPtr<OwlcatMultiButton> m_LabelsButton /* None */,
    PPtr<TextMeshProUGUI> m_LabelsButtonText /* None */,
    PPtr<GameObject> m_LabelsPrefab /* None */,
    PPtr<RectTransform> m_LabelsList /* None */,
    PPtr<RectTransform> m_LabelsListContainer /* None */,
    PPtr<Button> m_LabelsBlocker /* None */,
    PPtr<OwlcatToggle> m_PrivacyToggle /* None */,
    PPtr<OwlcatToggle> m_EmailUpdatesToggle /* None */,
    PPtr<GameObject> m_EmailUpdatesGroup /* None */,
    PPtr<BugReportDrawingView> m_BugReportDrawingView /* None */)
{
    public static BugReportPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MainTitleText */
        PPtr<TextMeshProUGUI> _m_MainTitleText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AspectTitleText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ContextTitleText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SendButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_HintText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SuggestionToggleText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NormalToggleText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CriticalToggleText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DescriptionTitleText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_EmailTitleText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_BottomDescriptionText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PrivacyDescriptionText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DiscordTitleText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_EmailUpdatesDescriptionText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_CloseButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_DrawingButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatInputField> _m_MessageInputField = PPtr<OwlcatInputField>.Read(reader);
        PPtr<GameObject> _m_EmailGroup = PPtr<GameObject>.Read(reader);
        PPtr<OwlcatInputField> _m_EmailInputField = PPtr<OwlcatInputField>.Read(reader);
        PPtr<OwlcatInputField> _m_DiscordInputField = PPtr<OwlcatInputField>.Read(reader);
        PPtr<GameObject> _m_DiscordGameObject = PPtr<GameObject>.Read(reader);
        PPtr<OwlcatDropdown> _m_ContextDropdown = PPtr<OwlcatDropdown>.Read(reader);
        PPtr<OwlcatDropdown> _m_AspectDropdown = PPtr<OwlcatDropdown>.Read(reader);
        PPtr<GameObject> _m_AssigneeGO = PPtr<GameObject>.Read(reader);
        PPtr<OwlcatDropdown> _m_AssigneeDropdown = PPtr<OwlcatDropdown>.Read(reader);
        PPtr<GameObject> _m_FixVersionGO = PPtr<GameObject>.Read(reader);
        PPtr<OwlcatDropdown> _m_FixVersionDropdown = PPtr<OwlcatDropdown>.Read(reader);
        PPtr<OwlcatMultiButton> _m_SendButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatToggleGroup> _m_IssueTypeToggleGroup = PPtr<OwlcatToggleGroup>.Read(reader);
        PPtr<OwlcatToggle> _m_CriticalToggle = PPtr<OwlcatToggle>.Read(reader);
        PPtr<OwlcatToggle> _m_NormalToggle = PPtr<OwlcatToggle>.Read(reader);
        PPtr<OwlcatToggle> _m_SuggestionToggle = PPtr<OwlcatToggle>.Read(reader);
        PPtr<GameObject> _m_LabelsGroup = PPtr<GameObject>.Read(reader);
        PPtr<OwlcatMultiButton> _m_LabelsButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_LabelsButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_LabelsPrefab = PPtr<GameObject>.Read(reader);
        PPtr<RectTransform> _m_LabelsList = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_LabelsListContainer = PPtr<RectTransform>.Read(reader);
        PPtr<Button> _m_LabelsBlocker = PPtr<Button>.Read(reader);
        PPtr<OwlcatToggle> _m_PrivacyToggle = PPtr<OwlcatToggle>.Read(reader);
        PPtr<OwlcatToggle> _m_EmailUpdatesToggle = PPtr<OwlcatToggle>.Read(reader);
        PPtr<GameObject> _m_EmailUpdatesGroup = PPtr<GameObject>.Read(reader);
        PPtr<BugReportDrawingView> _m_BugReportDrawingView = PPtr<BugReportDrawingView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MainTitleText,
            _m_AspectTitleText,
            _m_ContextTitleText,
            _m_SendButtonText,
            _m_HintText,
            _m_SuggestionToggleText,
            _m_NormalToggleText,
            _m_CriticalToggleText,
            _m_DescriptionTitleText,
            _m_EmailTitleText,
            _m_BottomDescriptionText,
            _m_PrivacyDescriptionText,
            _m_DiscordTitleText,
            _m_EmailUpdatesDescriptionText,
            _m_CloseButton,
            _m_DrawingButton,
            _m_MessageInputField,
            _m_EmailGroup,
            _m_EmailInputField,
            _m_DiscordInputField,
            _m_DiscordGameObject,
            _m_ContextDropdown,
            _m_AspectDropdown,
            _m_AssigneeGO,
            _m_AssigneeDropdown,
            _m_FixVersionGO,
            _m_FixVersionDropdown,
            _m_SendButton,
            _m_IssueTypeToggleGroup,
            _m_CriticalToggle,
            _m_NormalToggle,
            _m_SuggestionToggle,
            _m_LabelsGroup,
            _m_LabelsButton,
            _m_LabelsButtonText,
            _m_LabelsPrefab,
            _m_LabelsList,
            _m_LabelsListContainer,
            _m_LabelsBlocker,
            _m_PrivacyToggle,
            _m_EmailUpdatesToggle,
            _m_EmailUpdatesGroup,
            _m_BugReportDrawingView);
    }
}

