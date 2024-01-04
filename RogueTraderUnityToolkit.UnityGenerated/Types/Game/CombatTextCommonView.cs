namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CombatTextCommonView (13 fields) 6399383472252DC4E606FA7539672B45/EE11F67104785B80B8B56A89E6FA45E4 */
public record class CombatTextCommonView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float Duration /* NeedsAlign */,
    float ShowFadeTime /* None */,
    PPtr<CanvasGroup> m_CanvasGroup /* None */,
    PPtr<Image> m_Icon /* None */,
    PPtr<Image> m_IconContainer /* None */,
    PPtr<CanvasGroup> m_IconCanvasGroup /* None */,
    PPtr<TextMeshProUGUI> m_Text /* None */,
    ColorRGBA m_DefaultColor /* None */,
    float m_Spacing /* None */)
{
    public static CombatTextCommonView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Duration */
        float _Duration = reader.ReadF32();
        float _ShowFadeTime = reader.ReadF32();
        PPtr<CanvasGroup> _m_CanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<Image> _m_IconContainer = PPtr<Image>.Read(reader);
        PPtr<CanvasGroup> _m_IconCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Text = PPtr<TextMeshProUGUI>.Read(reader);
        ColorRGBA _m_DefaultColor = ColorRGBA.Read(reader);
        float _m_Spacing = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Duration,
            _ShowFadeTime,
            _m_CanvasGroup,
            _m_Icon,
            _m_IconContainer,
            _m_IconCanvasGroup,
            _m_Text,
            _m_DefaultColor,
            _m_Spacing);
    }
}

