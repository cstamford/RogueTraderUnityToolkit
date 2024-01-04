namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickDamageRangeView (23 fields) 7484CB84AC828653B3C4ED392CBD3A06/AE77FEC64AB786D623BA792BB961046D */
public record class TooltipBrickDamageRangeView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_BackgroundImage /* NeedsAlign */,
    PPtr<Image> m_IconImage /* None */,
    PPtr<TextMeshProUGUI> m_NameText /* None */,
    PPtr<TextMeshProUGUI> m_ResultValueText /* None */,
    PPtr<GameObject> m_ResultLineImage /* None */,
    PPtr<GameObject> m_FirstNestedBlock /* None */,
    PPtr<GameObject> m_SecondNestedBlock /* None */,
    PPtr<GameObject> m_ThirdNestedBlock /* None */,
    PPtr<GameObject> m_FourthNestedBlock /* None */,
    PPtr<Sprite> m_ProtectionSprite /* None */,
    PPtr<Sprite> m_TargetHitSprite /* None */,
    PPtr<Sprite> m_BorderChanceSprite /* None */,
    ColorRGBA m_GrayBackgroundColor /* None */,
    ColorRGBA m_BeigeBackgroundColor /* None */,
    ColorRGBA m_RedBackgroundColor /* None */,
    PPtr<Slider> m_CurrentValueSlider /* None */,
    PPtr<TextMeshProUGUI> m_CurrentValueText /* None */,
    PPtr<TextMeshProUGUI> m_MinValueText /* None */,
    PPtr<TextMeshProUGUI> m_MaxValueText /* None */)
{
    public static TooltipBrickDamageRangeView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_BackgroundImage */
        PPtr<Image> _m_BackgroundImage = PPtr<Image>.Read(reader);
        PPtr<Image> _m_IconImage = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NameText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ResultValueText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_ResultLineImage = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_FirstNestedBlock = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_SecondNestedBlock = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_ThirdNestedBlock = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_FourthNestedBlock = PPtr<GameObject>.Read(reader);
        PPtr<Sprite> _m_ProtectionSprite = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_TargetHitSprite = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_BorderChanceSprite = PPtr<Sprite>.Read(reader);
        ColorRGBA _m_GrayBackgroundColor = ColorRGBA.Read(reader);
        ColorRGBA _m_BeigeBackgroundColor = ColorRGBA.Read(reader);
        ColorRGBA _m_RedBackgroundColor = ColorRGBA.Read(reader);
        PPtr<Slider> _m_CurrentValueSlider = PPtr<Slider>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CurrentValueText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_MinValueText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_MaxValueText = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_BackgroundImage,
            _m_IconImage,
            _m_NameText,
            _m_ResultValueText,
            _m_ResultLineImage,
            _m_FirstNestedBlock,
            _m_SecondNestedBlock,
            _m_ThirdNestedBlock,
            _m_FourthNestedBlock,
            _m_ProtectionSprite,
            _m_TargetHitSprite,
            _m_BorderChanceSprite,
            _m_GrayBackgroundColor,
            _m_BeigeBackgroundColor,
            _m_RedBackgroundColor,
            _m_CurrentValueSlider,
            _m_CurrentValueText,
            _m_MinValueText,
            _m_MaxValueText);
    }
}

