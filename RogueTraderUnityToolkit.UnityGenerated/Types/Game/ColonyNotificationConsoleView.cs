namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyNotificationConsoleView (9 fields) 78CB23A6F6074B7D38DEBA3FE1F29653/10AACE48AAB5B956BA8B072682B192E0 */
public record class ColonyNotificationConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Status /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Title /* None */,
    PPtr<WindowAnimator> m_Animator /* None */,
    byte HasActionHint /* None */,
    PPtr<ConsoleHint> m_ActionHint /* NeedsAlign */)
{
    public static ColonyNotificationConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Status */
        PPtr<TextMeshProUGUI> _m_Status = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<WindowAnimator> _m_Animator = PPtr<WindowAnimator>.Read(reader);
        byte _HasActionHint = reader.ReadU8();
        reader.AlignTo(4); /* m_ActionHint */
        PPtr<ConsoleHint> _m_ActionHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Status,
            _m_Title,
            _m_Animator,
            _HasActionHint,
            _m_ActionHint);
    }
}

