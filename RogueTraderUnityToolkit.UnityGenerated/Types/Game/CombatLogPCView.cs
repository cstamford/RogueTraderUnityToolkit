namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CombatLogPCView (21 fields) ABE7365BA692F893DE7F91A7930941AD/B1E80D0A6A3A7DE2A9EE1649F3F605C8 */
public record class CombatLogPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<VirtualListVertical> m_VirtualList /* NeedsAlign */,
    PPtr<CombatLogItemBaseView> m_LogItemView /* None */,
    PPtr<CombatLogSeparatorView> m_LogSeparatorView /* None */,
    PPtr<FadeAnimator> m_Animator /* None */,
    float m_MoveAnimationTime /* None */,
    PPtr<RectTransform> m_PinnedContainer /* None */,
    CanvasTransformSettings m_PinnedContainerShowSettings /* None */,
    CanvasTransformSettings m_PinnedContainerHideSettings /* None */,
    PPtr<OwlcatToggle>[] m_Toggles /* None */,
    PPtr<TextMeshProUGUI>[] m_ToggleTexts /* None */,
    PPtr<OwlcatToggleGroup> m_ToggleGroup /* None */,
    PPtr<OwlcatMultiButton> m_SwitchPinButton /* None */,
    PPtr<OwlcatButton> m_ForceScrollToBottomButton /* None */,
    PPtr<ResizePanel> m_ResizePanel /* None */,
    PPtr<FadeAnimator> m_FiltersAnimator /* None */,
    PPtr<FadeAnimator>[] m_FiltersAnimators /* None */,
    PPtr<Image>[] m_FilterArrows /* None */)
{
    public static CombatLogPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_VirtualList */
        PPtr<VirtualListVertical> _m_VirtualList = PPtr<VirtualListVertical>.Read(reader);
        PPtr<CombatLogItemBaseView> _m_LogItemView = PPtr<CombatLogItemBaseView>.Read(reader);
        PPtr<CombatLogSeparatorView> _m_LogSeparatorView = PPtr<CombatLogSeparatorView>.Read(reader);
        PPtr<FadeAnimator> _m_Animator = PPtr<FadeAnimator>.Read(reader);
        float _m_MoveAnimationTime = reader.ReadF32();
        PPtr<RectTransform> _m_PinnedContainer = PPtr<RectTransform>.Read(reader);
        CanvasTransformSettings _m_PinnedContainerShowSettings = CanvasTransformSettings.Read(reader);
        CanvasTransformSettings _m_PinnedContainerHideSettings = CanvasTransformSettings.Read(reader);
        PPtr<OwlcatToggle>[] _m_Toggles = BuiltInArray<PPtr<OwlcatToggle>>.Read(reader);
        PPtr<TextMeshProUGUI>[] _m_ToggleTexts = BuiltInArray<PPtr<TextMeshProUGUI>>.Read(reader);
        PPtr<OwlcatToggleGroup> _m_ToggleGroup = PPtr<OwlcatToggleGroup>.Read(reader);
        PPtr<OwlcatMultiButton> _m_SwitchPinButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatButton> _m_ForceScrollToBottomButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<ResizePanel> _m_ResizePanel = PPtr<ResizePanel>.Read(reader);
        PPtr<FadeAnimator> _m_FiltersAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<FadeAnimator>[] _m_FiltersAnimators = BuiltInArray<PPtr<FadeAnimator>>.Read(reader);
        PPtr<Image>[] _m_FilterArrows = BuiltInArray<PPtr<Image>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_VirtualList,
            _m_LogItemView,
            _m_LogSeparatorView,
            _m_Animator,
            _m_MoveAnimationTime,
            _m_PinnedContainer,
            _m_PinnedContainerShowSettings,
            _m_PinnedContainerHideSettings,
            _m_Toggles,
            _m_ToggleTexts,
            _m_ToggleGroup,
            _m_SwitchPinButton,
            _m_ForceScrollToBottomButton,
            _m_ResizePanel,
            _m_FiltersAnimator,
            _m_FiltersAnimators,
            _m_FilterArrows);
    }
}

