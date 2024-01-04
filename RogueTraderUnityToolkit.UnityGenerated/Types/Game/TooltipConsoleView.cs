namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipConsoleView (16 fields) 0F959FA05113622C25FCE7A9B6040949/1AE52D608818D77E7A6E787DC551DB8C */
public record class TooltipConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_HeaderContainer /* NeedsAlign */,
    PPtr<RectTransform> m_BodyContainer /* None */,
    PPtr<RectTransform> m_FooterContainer /* None */,
    PPtr<RectTransform> m_HintContainer /* None */,
    PPtr<TooltipBricksView> m_BricksConfig /* None */,
    PPtr<Image>[] m_Backgrounds /* None */,
    PPtr<LayoutElement> m_LayoutElement /* None */,
    PPtr<LayoutElement> m_BodyLayoutElement /* None */,
    PPtr<GameObject> m_Separator /* None */,
    float m_MaxHeight /* None */,
    PPtr<VerticalLayoutGroup> m_ContentVerticalLayoutGroup /* None */,
    PPtr<ConsoleHint> m_InteractionHint /* None */)
{
    public static TooltipConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HeaderContainer */
        PPtr<RectTransform> _m_HeaderContainer = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_BodyContainer = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_FooterContainer = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_HintContainer = PPtr<RectTransform>.Read(reader);
        PPtr<TooltipBricksView> _m_BricksConfig = PPtr<TooltipBricksView>.Read(reader);
        PPtr<Image>[] _m_Backgrounds = BuiltInArray<PPtr<Image>>.Read(reader);
        PPtr<LayoutElement> _m_LayoutElement = PPtr<LayoutElement>.Read(reader);
        PPtr<LayoutElement> _m_BodyLayoutElement = PPtr<LayoutElement>.Read(reader);
        PPtr<GameObject> _m_Separator = PPtr<GameObject>.Read(reader);
        float _m_MaxHeight = reader.ReadF32();
        PPtr<VerticalLayoutGroup> _m_ContentVerticalLayoutGroup = PPtr<VerticalLayoutGroup>.Read(reader);
        PPtr<ConsoleHint> _m_InteractionHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HeaderContainer,
            _m_BodyContainer,
            _m_FooterContainer,
            _m_HintContainer,
            _m_BricksConfig,
            _m_Backgrounds,
            _m_LayoutElement,
            _m_BodyLayoutElement,
            _m_Separator,
            _m_MaxHeight,
            _m_ContentVerticalLayoutGroup,
            _m_InteractionHint);
    }
}

