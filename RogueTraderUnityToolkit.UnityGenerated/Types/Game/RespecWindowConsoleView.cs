namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $RespecWindowConsoleView (11 fields) 0BD9774CE582CED6D68A74C76DB18526/91C17F25D9A6DEB32D9F1016AFE1754C */
public record class RespecWindowConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_Animator /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_HeaderLabel /* None */,
    PPtr<TextMeshProUGUI> m_RespecCost /* None */,
    PPtr<RespecCharactersSelectorView> m_RespecCharactersSelectorView /* None */,
    PPtr<SystemMapSpaceResourcesPCView> m_SystemMapSpaceResourcesView /* None */,
    PPtr<ScrollRectExtended> m_ScrollRect /* None */,
    PPtr<ConsoleHintsWidget> m_ConsoleHintsWidget /* None */)
{
    public static RespecWindowConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Animator */
        PPtr<FadeAnimator> _m_Animator = PPtr<FadeAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_HeaderLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RespecCost = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<RespecCharactersSelectorView> _m_RespecCharactersSelectorView = PPtr<RespecCharactersSelectorView>.Read(reader);
        PPtr<SystemMapSpaceResourcesPCView> _m_SystemMapSpaceResourcesView = PPtr<SystemMapSpaceResourcesPCView>.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_ConsoleHintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Animator,
            _m_HeaderLabel,
            _m_RespecCost,
            _m_RespecCharactersSelectorView,
            _m_SystemMapSpaceResourcesView,
            _m_ScrollRect,
            _m_ConsoleHintsWidget);
    }
}

