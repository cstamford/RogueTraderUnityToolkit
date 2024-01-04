namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $BugReportDrawingView (14 fields) 0811DF90E0A1DC77676C190581C126C8/896C0624CC95FE8E5BB1CC293B1E69CC */
public record class BugReportDrawingView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<AspectRatioFitter> m_ScreenshotFitter /* NeedsAlign */,
    PPtr<RawImage> m_ScreenshotRawImage /* None */,
    PPtr<RawImage> m_ScreenshotDrawingRawImage /* None */,
    PPtr<TextMeshProUGUI> m_TitleText /* None */,
    PPtr<TextMeshProUGUI> m_ClearButtonText /* None */,
    PPtr<TextMeshProUGUI> m_SaveButtonText /* None */,
    PPtr<OwlcatMultiButton> m_ClearButton /* None */,
    PPtr<OwlcatMultiButton> m_SaveButton /* None */,
    PPtr<OwlcatMultiButton> m_CloseButton /* None */,
    PPtr<ConsoleHintsWidget> m_HintsWidget /* None */)
{
    public static BugReportDrawingView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ScreenshotFitter */
        PPtr<AspectRatioFitter> _m_ScreenshotFitter = PPtr<AspectRatioFitter>.Read(reader);
        PPtr<RawImage> _m_ScreenshotRawImage = PPtr<RawImage>.Read(reader);
        PPtr<RawImage> _m_ScreenshotDrawingRawImage = PPtr<RawImage>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TitleText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ClearButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SaveButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ClearButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_SaveButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_CloseButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_HintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ScreenshotFitter,
            _m_ScreenshotRawImage,
            _m_ScreenshotDrawingRawImage,
            _m_TitleText,
            _m_ClearButtonText,
            _m_SaveButtonText,
            _m_ClearButton,
            _m_SaveButton,
            _m_CloseButton,
            _m_HintsWidget);
    }
}

