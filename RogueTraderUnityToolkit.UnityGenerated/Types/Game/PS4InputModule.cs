namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PS4InputModule (13 fields) D0B954C6C8E352EBDB380E9C95605CC7/5A96CCD1A838818A36561FE6F5CAF0E2 */
public record class PS4InputModule(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_SendPointerHoverToParent /* NeedsAlign */,
    byte m_EnableTouchPadButton /* NeedsAlign */,
    AsciiString m_HorizontalAxis /* NeedsAlign */,
    AsciiString m_VerticalAxis /* NeedsAlign */,
    AsciiString m_SubmitButton /* NeedsAlign */,
    AsciiString m_CancelButton /* NeedsAlign */,
    AsciiString m_AxisNameSuffix /* NeedsAlign */,
    float m_RepeatSpeed /* NeedsAlign */,
    float m_RepeatDelay /* None */)
{
    public static PS4InputModule Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SendPointerHoverToParent */
        byte _m_SendPointerHoverToParent = reader.ReadU8();
        reader.AlignTo(4); /* m_EnableTouchPadButton */
        byte _m_EnableTouchPadButton = reader.ReadU8();
        reader.AlignTo(4); /* m_HorizontalAxis */
        AsciiString _m_HorizontalAxis = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_VerticalAxis */
        AsciiString _m_VerticalAxis = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SubmitButton */
        AsciiString _m_SubmitButton = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CancelButton */
        AsciiString _m_CancelButton = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_AxisNameSuffix */
        AsciiString _m_AxisNameSuffix = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_RepeatSpeed */
        float _m_RepeatSpeed = reader.ReadF32();
        float _m_RepeatDelay = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SendPointerHoverToParent,
            _m_EnableTouchPadButton,
            _m_HorizontalAxis,
            _m_VerticalAxis,
            _m_SubmitButton,
            _m_CancelButton,
            _m_AxisNameSuffix,
            _m_RepeatSpeed,
            _m_RepeatDelay);
    }
}

