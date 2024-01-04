namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipPCView (15 fields) CE519D80F155862B62A7DFA41D3C91CD/E8215CDC29049BD6D23B9BD2FB239E3A */
public record class TooltipPCView(
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
    PPtr<VerticalLayoutGroup> m_ContentVerticalLayoutGroup /* None */)
{
    public static TooltipPCView Read(EndianBinaryReader reader)
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
            _m_ContentVerticalLayoutGroup);
    }
}

