namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ExplorationResourcePointConsoleView (10 fields) 4B532AED59A2EF990086F36A94A6C771/6BF41D7F29363E9C71E13AF9432C7F43 */
public record class ExplorationResourcePointConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_Icon /* NeedsAlign */,
    PPtr<Image> m_ActiveImage /* None */,
    PPtr<CanvasGroup> m_CanvasGroup /* None */,
    PPtr<OwlcatMultiButton> m_Button /* None */,
    PPtr<CanvasGroup> m_HintCanvasGroup /* None */,
    PPtr<TextMeshProUGUI> m_HintLabel /* None */)
{
    public static ExplorationResourcePointConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Icon */
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<Image> _m_ActiveImage = PPtr<Image>.Read(reader);
        PPtr<CanvasGroup> _m_CanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<OwlcatMultiButton> _m_Button = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<CanvasGroup> _m_HintCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<TextMeshProUGUI> _m_HintLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Icon,
            _m_ActiveImage,
            _m_CanvasGroup,
            _m_Button,
            _m_HintCanvasGroup,
            _m_HintLabel);
    }
}

