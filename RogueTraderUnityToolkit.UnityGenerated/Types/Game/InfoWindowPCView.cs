namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $InfoWindowPCView (19 fields) 91C9D520182CC6735F900E24FD1C4773/654B7AF7F3A6E41FAEA9D34CD9CD5CE4 */
public record class InfoWindowPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_HeaderContainer /* NeedsAlign */,
    PPtr<RectTransform> m_BodyContainer /* None */,
    PPtr<RectTransform> m_FooterContainer /* None */,
    PPtr<RectTransform> m_HintContainer /* None */,
    PPtr<TooltipBricksView> m_BricksConfig /* None */,
    PPtr<FadeAnimator> m_Animator /* None */,
    PPtr<ScrollRectExtended> m_ScrollRect /* None */,
    byte m_IsBodyViewportMinHeight /* None */,
    float m_MaxViewportHeight /* NeedsAlign */,
    PPtr<LayoutElement> m_BodyViewportLayoutElement /* None */,
    byte m_IsStartPosition /* None */,
    Vector2f m_Position /* NeedsAlign */,
    PPtr<VerticalLayoutGroup> m_ContentVerticalLayoutGroup /* None */,
    PPtr<OwlcatButton> m_CloseButton /* None */,
    Vector2f m_DefaultPosition /* None */)
{
    public static InfoWindowPCView Read(EndianBinaryReader reader)
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
        PPtr<FadeAnimator> _m_Animator = PPtr<FadeAnimator>.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        byte _m_IsBodyViewportMinHeight = reader.ReadU8();
        reader.AlignTo(4); /* m_MaxViewportHeight */
        float _m_MaxViewportHeight = reader.ReadF32();
        PPtr<LayoutElement> _m_BodyViewportLayoutElement = PPtr<LayoutElement>.Read(reader);
        byte _m_IsStartPosition = reader.ReadU8();
        reader.AlignTo(4); /* m_Position */
        Vector2f _m_Position = Vector2f.Read(reader);
        PPtr<VerticalLayoutGroup> _m_ContentVerticalLayoutGroup = PPtr<VerticalLayoutGroup>.Read(reader);
        PPtr<OwlcatButton> _m_CloseButton = PPtr<OwlcatButton>.Read(reader);
        Vector2f _m_DefaultPosition = Vector2f.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HeaderContainer,
            _m_BodyContainer,
            _m_FooterContainer,
            _m_HintContainer,
            _m_BricksConfig,
            _m_Animator,
            _m_ScrollRect,
            _m_IsBodyViewportMinHeight,
            _m_MaxViewportHeight,
            _m_BodyViewportLayoutElement,
            _m_IsStartPosition,
            _m_Position,
            _m_ContentVerticalLayoutGroup,
            _m_CloseButton,
            _m_DefaultPosition);
    }
}

