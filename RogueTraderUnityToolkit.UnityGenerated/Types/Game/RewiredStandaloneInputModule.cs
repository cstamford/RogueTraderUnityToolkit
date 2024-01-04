namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $RewiredStandaloneInputModule (29 fields) DD8302EED8605BD5523676805F9C7558/78C798D8639BBF4D7A90BE66C0D1E239 */
public record class RewiredStandaloneInputModule(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_SendPointerHoverToParent /* NeedsAlign */,
    PPtr<InputManager_Base> rewiredInputManager /* NeedsAlign */,
    byte useAllRewiredGamePlayers /* None */,
    byte useRewiredSystemPlayer /* NeedsAlign */,
    int[] rewiredPlayerIds /* NeedsAlign */,
    byte usePlayingPlayersOnly /* NeedsAlign */,
    PPtr<PlayerMouse>[] playerMice /* NeedsAlign */,
    byte moveOneElementPerAxisPress /* None */,
    byte setActionsById /* NeedsAlign */,
    int horizontalActionId /* NeedsAlign */,
    int verticalActionId /* None */,
    int submitActionId /* None */,
    int cancelActionId /* None */,
    AsciiString m_HorizontalAxis /* None */,
    AsciiString m_VerticalAxis /* NeedsAlign */,
    AsciiString m_SubmitButton /* NeedsAlign */,
    AsciiString m_CancelButton /* NeedsAlign */,
    float m_InputActionsPerSecond /* NeedsAlign */,
    float m_RepeatDelay /* None */,
    byte m_allowMouseInput /* None */,
    byte m_allowMouseInputIfTouchSupported /* NeedsAlign */,
    byte m_allowTouchInput /* NeedsAlign */,
    byte m_deselectIfBackgroundClicked /* NeedsAlign */,
    byte m_deselectBeforeSelecting /* NeedsAlign */,
    byte m_ForceModuleActive /* NeedsAlign */)
{
    public static RewiredStandaloneInputModule Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SendPointerHoverToParent */
        byte _m_SendPointerHoverToParent = reader.ReadU8();
        reader.AlignTo(4); /* rewiredInputManager */
        PPtr<InputManager_Base> _rewiredInputManager = PPtr<InputManager_Base>.Read(reader);
        byte _useAllRewiredGamePlayers = reader.ReadU8();
        reader.AlignTo(4); /* useRewiredSystemPlayer */
        byte _useRewiredSystemPlayer = reader.ReadU8();
        reader.AlignTo(4); /* rewiredPlayerIds */
        int[] _rewiredPlayerIds = BuiltInArray<int>.Read(reader);
        reader.AlignTo(4); /* usePlayingPlayersOnly */
        byte _usePlayingPlayersOnly = reader.ReadU8();
        reader.AlignTo(4); /* playerMice */
        PPtr<PlayerMouse>[] _playerMice = BuiltInArray<PPtr<PlayerMouse>>.Read(reader);
        byte _moveOneElementPerAxisPress = reader.ReadU8();
        reader.AlignTo(4); /* setActionsById */
        byte _setActionsById = reader.ReadU8();
        reader.AlignTo(4); /* horizontalActionId */
        int _horizontalActionId = reader.ReadS32();
        int _verticalActionId = reader.ReadS32();
        int _submitActionId = reader.ReadS32();
        int _cancelActionId = reader.ReadS32();
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
        byte _m_allowMouseInput = reader.ReadU8();
        reader.AlignTo(4); /* m_allowMouseInputIfTouchSupported */
        byte _m_allowMouseInputIfTouchSupported = reader.ReadU8();
        reader.AlignTo(4); /* m_allowTouchInput */
        byte _m_allowTouchInput = reader.ReadU8();
        reader.AlignTo(4); /* m_deselectIfBackgroundClicked */
        byte _m_deselectIfBackgroundClicked = reader.ReadU8();
        reader.AlignTo(4); /* m_deselectBeforeSelecting */
        byte _m_deselectBeforeSelecting = reader.ReadU8();
        reader.AlignTo(4); /* m_ForceModuleActive */
        byte _m_ForceModuleActive = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SendPointerHoverToParent,
            _rewiredInputManager,
            _useAllRewiredGamePlayers,
            _useRewiredSystemPlayer,
            _rewiredPlayerIds,
            _usePlayingPlayersOnly,
            _playerMice,
            _moveOneElementPerAxisPress,
            _setActionsById,
            _horizontalActionId,
            _verticalActionId,
            _submitActionId,
            _cancelActionId,
            _m_HorizontalAxis,
            _m_VerticalAxis,
            _m_SubmitButton,
            _m_CancelButton,
            _m_InputActionsPerSecond,
            _m_RepeatDelay,
            _m_allowMouseInput,
            _m_allowMouseInputIfTouchSupported,
            _m_allowTouchInput,
            _m_deselectIfBackgroundClicked,
            _m_deselectBeforeSelecting,
            _m_ForceModuleActive);
    }
}

