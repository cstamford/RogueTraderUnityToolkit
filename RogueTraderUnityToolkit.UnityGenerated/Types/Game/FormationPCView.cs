namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FormationPCView (14 fields) 8ABE55B1A330C488640A91FF956BC62D/D81CA29DA734A58F0D5995AD0C1CB08F */
public record class FormationPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_FormationLabel /* NeedsAlign */,
    PPtr<FormationSelectorPCView> m_FormationSelectorPCView /* None */,
    PPtr<RectTransform> m_CharacterContainer /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* None */,
    PPtr<TextMeshProUGUI> m_UneditableFormationText /* None */,
    PPtr<FormationCharacterPCView> m_CharacterView /* None */,
    PPtr<OwlcatButton> m_CloseButton /* None */,
    PPtr<OwlcatButton> m_ResetButton /* None */,
    PPtr<TextMeshProUGUI> m_FormationHintPc /* None */,
    PPtr<TextMeshProUGUI> m_ResetLabel /* None */)
{
    public static FormationPCView Read(EndianBinaryReader reader)
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
        PPtr<FormationCharacterPCView> _m_CharacterView = PPtr<FormationCharacterPCView>.Read(reader);
        PPtr<OwlcatButton> _m_CloseButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_ResetButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_FormationHintPc = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ResetLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
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
            _m_CloseButton,
            _m_ResetButton,
            _m_FormationHintPc,
            _m_ResetLabel);
    }
}

