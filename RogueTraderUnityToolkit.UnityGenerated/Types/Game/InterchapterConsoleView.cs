namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $InterchapterConsoleView (8 fields) 85B41ED376E16F7A00B087DE45AD124B/2F3030FE8BE3ECB47858B0C31DA5C810 */
public record class InterchapterConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<VideoPlayerHelper> m_Video /* NeedsAlign */,
    PPtr<CanvasGroup> m_VideoGroup /* None */,
    PPtr<TextMeshProUGUI> m_SubtitleText /* None */,
    PPtr<CanvasGroup> m_SubtitleGroup /* None */)
{
    public static InterchapterConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Video */
        PPtr<VideoPlayerHelper> _m_Video = PPtr<VideoPlayerHelper>.Read(reader);
        PPtr<CanvasGroup> _m_VideoGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SubtitleText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CanvasGroup> _m_SubtitleGroup = PPtr<CanvasGroup>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Video,
            _m_VideoGroup,
            _m_SubtitleText,
            _m_SubtitleGroup);
    }
}

