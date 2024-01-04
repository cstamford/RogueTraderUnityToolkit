namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SettingsPCView (18 fields) BA4C82885EF03042173CF70B40DCC76F/E24B2E278E6BC88F94922EF96A905B62 */
public record class SettingsPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    SettingsViews m_SettingsViews /* NeedsAlign */,
    PPtr<VirtualListVertical> m_VirtualList /* None */,
    PPtr<InfoSectionView> m_InfoView /* None */,
    PPtr<SettingsMenuSelectorPCView> m_MenuSelector /* None */,
    PPtr<FlexibleLensSelectorView> m_SelectorView /* None */,
    PPtr<KeyBindingSetupDialogPCView> m_KeyBindingSetupDialogView /* None */,
    PPtr<OwlcatButton> m_CloseButton /* None */,
    PPtr<OwlcatButton> m_DefaultButton /* None */,
    PPtr<TextMeshProUGUI> m_DefaultText /* None */,
    PPtr<OwlcatButton> m_CancelButton /* None */,
    PPtr<TextMeshProUGUI> m_CancelText /* None */,
    PPtr<OwlcatButton> m_ApplyButton /* None */,
    PPtr<TextMeshProUGUI> m_ApplyText /* None */,
    PPtr<FadeAnimator> m_Animator /* None */)
{
    public static SettingsPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SettingsViews */
        SettingsViews _m_SettingsViews = SettingsViews.Read(reader);
        PPtr<VirtualListVertical> _m_VirtualList = PPtr<VirtualListVertical>.Read(reader);
        PPtr<InfoSectionView> _m_InfoView = PPtr<InfoSectionView>.Read(reader);
        PPtr<SettingsMenuSelectorPCView> _m_MenuSelector = PPtr<SettingsMenuSelectorPCView>.Read(reader);
        PPtr<FlexibleLensSelectorView> _m_SelectorView = PPtr<FlexibleLensSelectorView>.Read(reader);
        PPtr<KeyBindingSetupDialogPCView> _m_KeyBindingSetupDialogView = PPtr<KeyBindingSetupDialogPCView>.Read(reader);
        PPtr<OwlcatButton> _m_CloseButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_DefaultButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DefaultText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_CancelButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CancelText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_ApplyButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ApplyText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<FadeAnimator> _m_Animator = PPtr<FadeAnimator>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SettingsViews,
            _m_VirtualList,
            _m_InfoView,
            _m_MenuSelector,
            _m_SelectorView,
            _m_KeyBindingSetupDialogView,
            _m_CloseButton,
            _m_DefaultButton,
            _m_DefaultText,
            _m_CancelButton,
            _m_CancelText,
            _m_ApplyButton,
            _m_ApplyText,
            _m_Animator);
    }
}

