namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ScrollRectExtended (33 fields) EBCD173EC7F8AA8DE966DC0917FD90AD/CD84CC39470FC9EB23DBC40B3A6E23E7 */
public record class ScrollRectExtended(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_Content /* NeedsAlign */,
    byte m_Horizontal /* None */,
    PPtr<Graphic> m_LeftEdge /* NeedsAlign */,
    PPtr<Graphic> m_RightEdge /* None */,
    byte m_Vertical /* None */,
    PPtr<Graphic> m_TopEdge /* NeedsAlign */,
    BoolEvent m_OnReachedTopEdge /* None */,
    PPtr<Graphic> m_BottomEdge /* NeedsAlign */,
    BoolEvent m_OnReachedBottomEdge /* None */,
    float m_EdgeVisibleThreshold /* NeedsAlign */,
    byte m_InvertedWheelScroll /* None */,
    int m_MovementType /* NeedsAlign */,
    float m_Elasticity /* None */,
    byte m_Inertia /* None */,
    float m_DecelerationRate /* NeedsAlign */,
    float m_ScrollSensitivity /* None */,
    float m_ButtonScrollSensitivity /* None */,
    PPtr<RectTransform> m_Viewport /* None */,
    PPtr<Scrollbar> m_HorizontalScrollbar /* None */,
    byte m_HorizontalScrollbarSizeEffector /* None */,
    PPtr<Scrollbar> m_VerticalScrollbar /* NeedsAlign */,
    byte m_VerticalScrollbarSizeEffector /* None */,
    int m_HorizontalScrollbarVisibility /* NeedsAlign */,
    int m_VerticalScrollbarVisibility /* None */,
    float m_HorizontalScrollbarSpacing /* None */,
    float m_VerticalScrollbarSpacing /* None */,
    ScrollRectEvent m_OnValueChanged /* None */,
    byte m_IsDraggable /* NeedsAlign */,
    float m_SmoothScrollTime /* NeedsAlign */)
{
    public static ScrollRectExtended Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Content */
        PPtr<RectTransform> _m_Content = PPtr<RectTransform>.Read(reader);
        byte _m_Horizontal = reader.ReadU8();
        reader.AlignTo(4); /* m_LeftEdge */
        PPtr<Graphic> _m_LeftEdge = PPtr<Graphic>.Read(reader);
        PPtr<Graphic> _m_RightEdge = PPtr<Graphic>.Read(reader);
        byte _m_Vertical = reader.ReadU8();
        reader.AlignTo(4); /* m_TopEdge */
        PPtr<Graphic> _m_TopEdge = PPtr<Graphic>.Read(reader);
        BoolEvent _m_OnReachedTopEdge = BoolEvent.Read(reader);
        reader.AlignTo(4); /* m_BottomEdge */
        PPtr<Graphic> _m_BottomEdge = PPtr<Graphic>.Read(reader);
        BoolEvent _m_OnReachedBottomEdge = BoolEvent.Read(reader);
        reader.AlignTo(4); /* m_EdgeVisibleThreshold */
        float _m_EdgeVisibleThreshold = reader.ReadF32();
        byte _m_InvertedWheelScroll = reader.ReadU8();
        reader.AlignTo(4); /* m_MovementType */
        int _m_MovementType = reader.ReadS32();
        float _m_Elasticity = reader.ReadF32();
        byte _m_Inertia = reader.ReadU8();
        reader.AlignTo(4); /* m_DecelerationRate */
        float _m_DecelerationRate = reader.ReadF32();
        float _m_ScrollSensitivity = reader.ReadF32();
        float _m_ButtonScrollSensitivity = reader.ReadF32();
        PPtr<RectTransform> _m_Viewport = PPtr<RectTransform>.Read(reader);
        PPtr<Scrollbar> _m_HorizontalScrollbar = PPtr<Scrollbar>.Read(reader);
        byte _m_HorizontalScrollbarSizeEffector = reader.ReadU8();
        reader.AlignTo(4); /* m_VerticalScrollbar */
        PPtr<Scrollbar> _m_VerticalScrollbar = PPtr<Scrollbar>.Read(reader);
        byte _m_VerticalScrollbarSizeEffector = reader.ReadU8();
        reader.AlignTo(4); /* m_HorizontalScrollbarVisibility */
        int _m_HorizontalScrollbarVisibility = reader.ReadS32();
        int _m_VerticalScrollbarVisibility = reader.ReadS32();
        float _m_HorizontalScrollbarSpacing = reader.ReadF32();
        float _m_VerticalScrollbarSpacing = reader.ReadF32();
        ScrollRectEvent _m_OnValueChanged = ScrollRectEvent.Read(reader);
        reader.AlignTo(4); /* m_IsDraggable */
        byte _m_IsDraggable = reader.ReadU8();
        reader.AlignTo(4); /* m_SmoothScrollTime */
        float _m_SmoothScrollTime = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Content,
            _m_Horizontal,
            _m_LeftEdge,
            _m_RightEdge,
            _m_Vertical,
            _m_TopEdge,
            _m_OnReachedTopEdge,
            _m_BottomEdge,
            _m_OnReachedBottomEdge,
            _m_EdgeVisibleThreshold,
            _m_InvertedWheelScroll,
            _m_MovementType,
            _m_Elasticity,
            _m_Inertia,
            _m_DecelerationRate,
            _m_ScrollSensitivity,
            _m_ButtonScrollSensitivity,
            _m_Viewport,
            _m_HorizontalScrollbar,
            _m_HorizontalScrollbarSizeEffector,
            _m_VerticalScrollbar,
            _m_VerticalScrollbarSizeEffector,
            _m_HorizontalScrollbarVisibility,
            _m_VerticalScrollbarVisibility,
            _m_HorizontalScrollbarSpacing,
            _m_VerticalScrollbarSpacing,
            _m_OnValueChanged,
            _m_IsDraggable,
            _m_SmoothScrollTime);
    }
}

