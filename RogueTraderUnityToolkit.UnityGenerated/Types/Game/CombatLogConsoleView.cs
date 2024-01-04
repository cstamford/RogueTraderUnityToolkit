namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CombatLogConsoleView (27 fields) 421891077509800AA469B64A3B138D85/B50F7FD2FDD76DC660EC259248F6B220 */
public record class CombatLogConsoleView(
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
    PPtr<GameObject> m_ChannelPanel /* None */,
    PPtr<GameObject> m_PinBackground /* None */,
    PPtr<TextMeshProUGUI> m_ChannelText /* None */,
    float[] m_YSizesList /* None */,
    PPtr<ConsoleHint> m_ChangeSizeHint /* NeedsAlign */,
    PPtr<ConsoleHint> m_ModePinHint /* None */,
    PPtr<ConsoleHint> m_ConsoleHintFilterPrev /* None */,
    PPtr<ConsoleHint> m_ConsoleHintFilterNext /* None */,
    PPtr<ConsoleHint> m_ConsoleHintClose /* None */,
    PPtr<ConsoleHint> m_ConsoleHintOpen /* None */,
    PPtr<ConsoleHint> m_ConsoleHintOpenCombat /* None */,
    PPtr<ConsoleHint> m_MoveCameraToHint /* None */)
{
    public static CombatLogConsoleView Read(EndianBinaryReader reader)
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
        PPtr<GameObject> _m_ChannelPanel = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_PinBackground = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ChannelText = PPtr<TextMeshProUGUI>.Read(reader);
        float[] _m_YSizesList = BuiltInArray<float>.Read(reader);
        reader.AlignTo(4); /* m_ChangeSizeHint */
        PPtr<ConsoleHint> _m_ChangeSizeHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_ModePinHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_ConsoleHintFilterPrev = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_ConsoleHintFilterNext = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_ConsoleHintClose = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_ConsoleHintOpen = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_ConsoleHintOpenCombat = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_MoveCameraToHint = PPtr<ConsoleHint>.Read(reader);
        
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
            _m_ChannelPanel,
            _m_PinBackground,
            _m_ChannelText,
            _m_YSizesList,
            _m_ChangeSizeHint,
            _m_ModePinHint,
            _m_ConsoleHintFilterPrev,
            _m_ConsoleHintFilterNext,
            _m_ConsoleHintClose,
            _m_ConsoleHintOpen,
            _m_ConsoleHintOpenCombat,
            _m_MoveCameraToHint);
    }
}

