namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FormationConsoleView (16 fields) 58AB6DF114B4D8E4A3AE4D2FC1720018/B426D8C7435A41C674FB36F0B7E2EF01 */
public record class FormationConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_FormationLabel /* NeedsAlign */,
    PPtr<FormationSelectorPCView> m_FormationSelectorPCView /* None */,
    PPtr<RectTransform> m_CharacterContainer /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* None */,
    PPtr<TextMeshProUGUI> m_UneditableFormationText /* None */,
    PPtr<FormationCharacterConsoleView> m_CharacterView /* None */,
    NavigationParameters m_Parameters /* None */,
    PPtr<ConsoleHintsWidget> m_ConsoleHintsTopWidget /* NeedsAlign */,
    PPtr<ConsoleHintsWidget> m_ConsoleHintsBottomWidget /* None */,
    PPtr<ConsoleHint> m_LeftHint /* None */,
    PPtr<ConsoleHint> m_RightHint /* None */,
    PPtr<ConsoleHint> m_MoveCharacterFree /* None */)
{
    public static FormationConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FormationLabel */
        PPtr<TextMeshProUGUI> _m_FormationLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<FormationSelectorPCView> _m_FormationSelectorPCView = PPtr<FormationSelectorPCView>.Read(reader);
        PPtr<RectTransform> _m_CharacterContainer = PPtr<RectTransform>.Read(reader);
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_UneditableFormationText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<FormationCharacterConsoleView> _m_CharacterView = PPtr<FormationCharacterConsoleView>.Read(reader);
        NavigationParameters _m_Parameters = NavigationParameters.Read(reader);
        reader.AlignTo(4); /* m_ConsoleHintsTopWidget */
        PPtr<ConsoleHintsWidget> _m_ConsoleHintsTopWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_ConsoleHintsBottomWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        PPtr<ConsoleHint> _m_LeftHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_RightHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_MoveCharacterFree = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FormationLabel,
            _m_FormationSelectorPCView,
            _m_CharacterContainer,
            _m_FadeAnimator,
            _m_UneditableFormationText,
            _m_CharacterView,
            _m_Parameters,
            _m_ConsoleHintsTopWidget,
            _m_ConsoleHintsBottomWidget,
            _m_LeftHint,
            _m_RightHint,
            _m_MoveCharacterFree);
    }
}

