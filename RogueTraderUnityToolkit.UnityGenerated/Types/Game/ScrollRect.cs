namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ScrollRect (20 fields) C4FDCF1A01CAE17D383DAE4D86103D4C/C89B31E6A7D1A49D0C23F97DB7038D0B */
public record class ScrollRect(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_Content /* NeedsAlign */,
    byte m_Horizontal /* None */,
    byte m_Vertical /* NeedsAlign */,
    int m_MovementType /* NeedsAlign */,
    float m_Elasticity /* None */,
    byte m_Inertia /* None */,
    float m_DecelerationRate /* NeedsAlign */,
    float m_ScrollSensitivity /* None */,
    PPtr<RectTransform> m_Viewport /* None */,
    PPtr<Scrollbar> m_HorizontalScrollbar /* None */,
    PPtr<Scrollbar> m_VerticalScrollbar /* None */,
    int m_HorizontalScrollbarVisibility /* None */,
    int m_VerticalScrollbarVisibility /* None */,
    float m_HorizontalScrollbarSpacing /* None */,
    float m_VerticalScrollbarSpacing /* None */,
    ScrollRectEvent m_OnValueChanged /* None */)
{
    public static ScrollRect Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Content */
        PPtr<RectTransform> _m_Content = PPtr<RectTransform>.Read(reader);
        byte _m_Horizontal = reader.ReadU8();
        reader.AlignTo(4); /* m_Vertical */
        byte _m_Vertical = reader.ReadU8();
        reader.AlignTo(4); /* m_MovementType */
        int _m_MovementType = reader.ReadS32();
        float _m_Elasticity = reader.ReadF32();
        byte _m_Inertia = reader.ReadU8();
        reader.AlignTo(4); /* m_DecelerationRate */
        float _m_DecelerationRate = reader.ReadF32();
        float _m_ScrollSensitivity = reader.ReadF32();
        PPtr<RectTransform> _m_Viewport = PPtr<RectTransform>.Read(reader);
        PPtr<Scrollbar> _m_HorizontalScrollbar = PPtr<Scrollbar>.Read(reader);
        PPtr<Scrollbar> _m_VerticalScrollbar = PPtr<Scrollbar>.Read(reader);
        int _m_HorizontalScrollbarVisibility = reader.ReadS32();
        int _m_VerticalScrollbarVisibility = reader.ReadS32();
        float _m_HorizontalScrollbarSpacing = reader.ReadF32();
        float _m_VerticalScrollbarSpacing = reader.ReadF32();
        ScrollRectEvent _m_OnValueChanged = ScrollRectEvent.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Content,
            _m_Horizontal,
            _m_Vertical,
            _m_MovementType,
            _m_Elasticity,
            _m_Inertia,
            _m_DecelerationRate,
            _m_ScrollSensitivity,
            _m_Viewport,
            _m_HorizontalScrollbar,
            _m_VerticalScrollbar,
            _m_HorizontalScrollbarVisibility,
            _m_VerticalScrollbarVisibility,
            _m_HorizontalScrollbarSpacing,
            _m_VerticalScrollbarSpacing,
            _m_OnValueChanged);
    }
}

