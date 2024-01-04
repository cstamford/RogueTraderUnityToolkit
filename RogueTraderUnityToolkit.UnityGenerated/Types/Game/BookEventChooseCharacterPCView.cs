namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $BookEventChooseCharacterPCView (13 fields) 5C2845D42753A7FC358EA080903373E6/C9A258BE55E89EDB432DE3553DB4EF5D */
public record class BookEventChooseCharacterPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_WindowAnimator /* NeedsAlign */,
    PPtr<Button> m_CloseButton /* None */,
    PPtr<WidgetListMVVM> m_WidgetListCharacter /* None */,
    PPtr<BookEventCharacterPCView> m_BookEventCharacterViewPrefab /* None */,
    PPtr<WidgetListMVVM> m_WidgetListSkills /* None */,
    PPtr<BookEventSkillsBlockPCView> m_BookEventSkillsBlockViewPrefab /* None */,
    PPtr<Button> m_ConfirmButton /* None */,
    PPtr<TextMeshProUGUI> m_Title /* None */,
    PPtr<TextMeshProUGUI> m_ConfirmLabel /* None */)
{
    public static BookEventChooseCharacterPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_WindowAnimator */
        PPtr<FadeAnimator> _m_WindowAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<Button> _m_CloseButton = PPtr<Button>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetListCharacter = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<BookEventCharacterPCView> _m_BookEventCharacterViewPrefab = PPtr<BookEventCharacterPCView>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetListSkills = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<BookEventSkillsBlockPCView> _m_BookEventSkillsBlockViewPrefab = PPtr<BookEventSkillsBlockPCView>.Read(reader);
        PPtr<Button> _m_ConfirmButton = PPtr<Button>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ConfirmLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_WindowAnimator,
            _m_CloseButton,
            _m_WidgetListCharacter,
            _m_BookEventCharacterViewPrefab,
            _m_WidgetListSkills,
            _m_BookEventSkillsBlockViewPrefab,
            _m_ConfirmButton,
            _m_Title,
            _m_ConfirmLabel);
    }
}

