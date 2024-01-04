namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $EpilogConsoleView (14 fields) F5856B0063A48B6C56080BD914918FFF/4D78E390E252619ABF08A9DB2FD31F86 */
public record class EpilogConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_WindowAnimator /* NeedsAlign */,
    PPtr<CharBPortraitChanger> m_Portrait /* None */,
    PPtr<EpilogCueBaseView> m_Cue /* None */,
    PPtr<ScrollRectExtended> m_CueScrollRect /* None */,
    PPtr<TextMeshProUGUI> m_Title /* None */,
    PPtr<Image> m_BackgroundImage /* None */,
    PPtr<VideoPlayerHelper> m_BackgroundVideo /* None */,
    PPtr<FadeAnimator> m_BackgroundAnimator /* None */,
    PPtr<ConsoleHint> m_Hint /* None */,
    PPtr<ConsoleHint> m_ScrollHint /* None */)
{
    public static EpilogConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_WindowAnimator */
        PPtr<FadeAnimator> _m_WindowAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<CharBPortraitChanger> _m_Portrait = PPtr<CharBPortraitChanger>.Read(reader);
        PPtr<EpilogCueBaseView> _m_Cue = PPtr<EpilogCueBaseView>.Read(reader);
        PPtr<ScrollRectExtended> _m_CueScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_BackgroundImage = PPtr<Image>.Read(reader);
        PPtr<VideoPlayerHelper> _m_BackgroundVideo = PPtr<VideoPlayerHelper>.Read(reader);
        PPtr<FadeAnimator> _m_BackgroundAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<ConsoleHint> _m_Hint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_ScrollHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_WindowAnimator,
            _m_Portrait,
            _m_Cue,
            _m_CueScrollRect,
            _m_Title,
            _m_BackgroundImage,
            _m_BackgroundVideo,
            _m_BackgroundAnimator,
            _m_Hint,
            _m_ScrollHint);
    }
}

