namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TitlesPCView (23 fields) 4466589EEAE3730DE23775F31FE112B5/7CE5D15374BD44D595BC15BF9E9F0F01 */
public record class TitlesPCView(
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
    PPtr<TextMeshProUGUI> m_HoldToSpeedupTitle /* None */,
    ColorRGBA m_HintColor /* None */)
{
    public static TitlesPCView Read(EndianBinaryReader reader)
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
        PPtr<TextMeshProUGUI> _m_HoldToSpeedupTitle = PPtr<TextMeshProUGUI>.Read(reader);
        ColorRGBA _m_HintColor = ColorRGBA.Read(reader);
        
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
            _m_HoldToSpeedupTitle,
            _m_HintColor);
    }
}

