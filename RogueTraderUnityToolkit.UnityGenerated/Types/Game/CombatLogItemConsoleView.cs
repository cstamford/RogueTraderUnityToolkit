namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CombatLogItemConsoleView (11 fields) 1AEADCAC17DE511EA39A9D49A8307C03/E9F46EE0A76AA72DFCA0C4FB4544ADA6 */
public record class CombatLogItemConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Text /* NeedsAlign */,
    PPtr<CanvasGroup> m_PrefixCanvasGroup /* None */,
    PPtr<Image> m_IconImage /* None */,
    VirtualListLayoutElementSettings m_VirtualListSettings /* None */,
    PPtr<CanvasGroup> m_FocusCanvasGroup /* NeedsAlign */,
    PPtr<CanvasGroup> m_HighlightCanvasGroup /* None */,
    float m_DefaultConsoleFontSize /* None */)
{
    public static CombatLogItemConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Text */
        PPtr<TextMeshProUGUI> _m_Text = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CanvasGroup> _m_PrefixCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<Image> _m_IconImage = PPtr<Image>.Read(reader);
        VirtualListLayoutElementSettings _m_VirtualListSettings = VirtualListLayoutElementSettings.Read(reader);
        reader.AlignTo(4); /* m_FocusCanvasGroup */
        PPtr<CanvasGroup> _m_FocusCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<CanvasGroup> _m_HighlightCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        float _m_DefaultConsoleFontSize = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Text,
            _m_PrefixCanvasGroup,
            _m_IconImage,
            _m_VirtualListSettings,
            _m_FocusCanvasGroup,
            _m_HighlightCanvasGroup,
            _m_DefaultConsoleFontSize);
    }
}

