namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickTriggeredAutoView (12 fields) AD37CAF1BEACE256E3C8731B2D956BFA/1B7F807B3347B241E6946F9CEF270721 */
public record class TooltipBrickTriggeredAutoView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_TriggeredAutoText /* NeedsAlign */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<ReasonBuffItemView> m_ReasonBuffItemView /* None */,
    PPtr<Image> m_ResultSignImage /* None */,
    PPtr<Sprite> m_ResultSignSuccessSprite /* None */,
    PPtr<Sprite> m_ResultSignFailedSprite /* None */,
    ColorRGBA m_OrangeColor /* None */,
    ColorRGBA m_LightColor /* None */)
{
    public static TooltipBrickTriggeredAutoView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TriggeredAutoText */
        PPtr<TextMeshProUGUI> _m_TriggeredAutoText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<ReasonBuffItemView> _m_ReasonBuffItemView = PPtr<ReasonBuffItemView>.Read(reader);
        PPtr<Image> _m_ResultSignImage = PPtr<Image>.Read(reader);
        PPtr<Sprite> _m_ResultSignSuccessSprite = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_ResultSignFailedSprite = PPtr<Sprite>.Read(reader);
        ColorRGBA _m_OrangeColor = ColorRGBA.Read(reader);
        ColorRGBA _m_LightColor = ColorRGBA.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_TriggeredAutoText,
            _m_WidgetList,
            _m_ReasonBuffItemView,
            _m_ResultSignImage,
            _m_ResultSignSuccessSprite,
            _m_ResultSignFailedSprite,
            _m_OrangeColor,
            _m_LightColor);
    }
}

