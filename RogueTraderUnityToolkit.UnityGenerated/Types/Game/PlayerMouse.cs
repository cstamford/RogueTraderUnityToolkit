namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PlayerMouse (17 fields) 14E6C04115AC574AB51ECE55A35E5D44/36A047A0DA73FEBAD7D4C37872B681B1 */
public record class PlayerMouse(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<InputManager_Base> _rewiredInputManager /* NeedsAlign */,
    int _playerId /* None */,
    ElementInfo[] _elements /* None */,
    ButtonStateChangedHandler _onButtonStateChanged /* NeedsAlign */,
    AxisValueChangedHandler _onAxisValueChanged /* NeedsAlign */,
    EnabledStateChangedHandler _onEnabledStateChanged /* NeedsAlign */,
    byte _defaultToCenter /* NeedsAlign */,
    float _pointerSpeed /* NeedsAlign */,
    byte _useHardwarePointerPosition /* None */,
    byte _clampToMovementArea /* NeedsAlign */,
    Rectf _movementArea /* NeedsAlign */,
    int _movementAreaUnit /* None */,
    ScreenPositionChangedHandler _onScreenPositionChanged /* None */)
{
    public static PlayerMouse Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _rewiredInputManager */
        PPtr<InputManager_Base> __rewiredInputManager = PPtr<InputManager_Base>.Read(reader);
        int __playerId = reader.ReadS32();
        ElementInfo[] __elements = BuiltInArray<ElementInfo>.Read(reader);
        reader.AlignTo(4); /* _onButtonStateChanged */
        ButtonStateChangedHandler __onButtonStateChanged = ButtonStateChangedHandler.Read(reader);
        reader.AlignTo(4); /* _onAxisValueChanged */
        AxisValueChangedHandler __onAxisValueChanged = AxisValueChangedHandler.Read(reader);
        reader.AlignTo(4); /* _onEnabledStateChanged */
        EnabledStateChangedHandler __onEnabledStateChanged = EnabledStateChangedHandler.Read(reader);
        reader.AlignTo(4); /* _defaultToCenter */
        byte __defaultToCenter = reader.ReadU8();
        reader.AlignTo(4); /* _pointerSpeed */
        float __pointerSpeed = reader.ReadF32();
        byte __useHardwarePointerPosition = reader.ReadU8();
        reader.AlignTo(4); /* _clampToMovementArea */
        byte __clampToMovementArea = reader.ReadU8();
        reader.AlignTo(4); /* _movementArea */
        Rectf __movementArea = Rectf.Read(reader);
        int __movementAreaUnit = reader.ReadS32();
        ScreenPositionChangedHandler __onScreenPositionChanged = ScreenPositionChangedHandler.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __rewiredInputManager,
            __playerId,
            __elements,
            __onButtonStateChanged,
            __onAxisValueChanged,
            __onEnabledStateChanged,
            __defaultToCenter,
            __pointerSpeed,
            __useHardwarePointerPosition,
            __clampToMovementArea,
            __movementArea,
            __movementAreaUnit,
            __onScreenPositionChanged);
    }
}

