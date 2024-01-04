namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TitlesConsoleView (22 fields) 7DB9D1FB2C52C27F1F2729EB02E634D6/63539309C7441D8BD5237D65E70A0ECC */
public record class TitlesConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<FadeAnimator> m_TheEndTitleAnimator /* None */,
    PPtr<TextMeshProUGUI> m_TheEndTitle /* None */,
    PPtr<ScrambledTMP> m_ScrumbledTheEndTitle /* None */,
    PPtr<RectTransform> m_Content /* None */,
    PPtr<CreditsOneColumnPage> m_OneColumnPrefab /* None */,
    PPtr<CreditsTwoColumnsPage> m_MultipleColumnsPrefab /* None */,
    PPtr<Sprite> m_FirstBackground /* None */,
    float m_ScrollSpeedPxPerSec /* None */,
    float m_ScrollSpeedUpMultiplyer /* None */,
    float m_StartDelayTime /* None */,
    float m_EndDelayTime /* None */,
    float m_ChangeScreenTime /* None */,
    float m_ScrollBottomOffset /* None */,
    float m_DestinationBgrAlpha /* None */,
    float m_BgrFadeTime /* None */,
    PPtr<Image>[] m_BackgroundImages /* None */,
    PPtr<ConsoleHint> m_SpeedUPHint /* None */)
{
    public static TitlesConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<FadeAnimator> _m_TheEndTitleAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TheEndTitle = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<ScrambledTMP> _m_ScrumbledTheEndTitle = PPtr<ScrambledTMP>.Read(reader);
        PPtr<RectTransform> _m_Content = PPtr<RectTransform>.Read(reader);
        PPtr<CreditsOneColumnPage> _m_OneColumnPrefab = PPtr<CreditsOneColumnPage>.Read(reader);
        PPtr<CreditsTwoColumnsPage> _m_MultipleColumnsPrefab = PPtr<CreditsTwoColumnsPage>.Read(reader);
        PPtr<Sprite> _m_FirstBackground = PPtr<Sprite>.Read(reader);
        float _m_ScrollSpeedPxPerSec = reader.ReadF32();
        float _m_ScrollSpeedUpMultiplyer = reader.ReadF32();
        float _m_StartDelayTime = reader.ReadF32();
        float _m_EndDelayTime = reader.ReadF32();
        float _m_ChangeScreenTime = reader.ReadF32();
        float _m_ScrollBottomOffset = reader.ReadF32();
        float _m_DestinationBgrAlpha = reader.ReadF32();
        float _m_BgrFadeTime = reader.ReadF32();
        PPtr<Image>[] _m_BackgroundImages = BuiltInArray<PPtr<Image>>.Read(reader);
        PPtr<ConsoleHint> _m_SpeedUPHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_TheEndTitleAnimator,
            _m_TheEndTitle,
            _m_ScrumbledTheEndTitle,
            _m_Content,
            _m_OneColumnPrefab,
            _m_MultipleColumnsPrefab,
            _m_FirstBackground,
            _m_ScrollSpeedPxPerSec,
            _m_ScrollSpeedUpMultiplyer,
            _m_StartDelayTime,
            _m_EndDelayTime,
            _m_ChangeScreenTime,
            _m_ScrollBottomOffset,
            _m_DestinationBgrAlpha,
            _m_BgrFadeTime,
            _m_BackgroundImages,
            _m_SpeedUPHint);
    }
}

