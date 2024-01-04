namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $KingmakerInputModule (12 fields) 75861D75CD13F453DBE56FE80D78020B/B5D4FAEA8E8F3C4D42CEF2D8A26D3731 */
public record class KingmakerInputModule(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_SendPointerHoverToParent /* NeedsAlign */,
    AsciiString m_HorizontalAxis /* NeedsAlign */,
    AsciiString m_VerticalAxis /* NeedsAlign */,
    AsciiString m_SubmitButton /* NeedsAlign */,
    AsciiString m_CancelButton /* NeedsAlign */,
    float m_InputActionsPerSecond /* NeedsAlign */,
    float m_RepeatDelay /* None */,
    byte m_ForceModuleActive /* None */)
{
    public static KingmakerInputModule Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SendPointerHoverToParent */
        byte _m_SendPointerHoverToParent = reader.ReadU8();
        reader.AlignTo(4); /* m_HorizontalAxis */
        AsciiString _m_HorizontalAxis = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_VerticalAxis */
        AsciiString _m_VerticalAxis = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SubmitButton */
        AsciiString _m_SubmitButton = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CancelButton */
        AsciiString _m_CancelButton = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_InputActionsPerSecond */
        float _m_InputActionsPerSecond = reader.ReadF32();
        float _m_RepeatDelay = reader.ReadF32();
        byte _m_ForceModuleActive = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SendPointerHoverToParent,
            _m_HorizontalAxis,
            _m_VerticalAxis,
            _m_SubmitButton,
            _m_CancelButton,
            _m_InputActionsPerSecond,
            _m_RepeatDelay,
            _m_ForceModuleActive);
    }
}

