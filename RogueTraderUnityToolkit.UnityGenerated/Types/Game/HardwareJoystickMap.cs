namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $HardwareJoystickMap (44 fields) 1823D8ACB4C52AD7518D2CC260C1EE88/9D16F05AC1C9BA4E141569CDB76A5F32 */
public record class HardwareJoystickMap(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    AsciiString controllerName /* NeedsAlign */,
    AsciiString editorControllerName /* NeedsAlign */,
    AsciiString description /* NeedsAlign */,
    AsciiString controllerGuid /* NeedsAlign */,
    AsciiString[] templateGuids /* NeedsAlign */,
    byte hideInLists /* NeedsAlign */,
    int[] joystickTypes /* NeedsAlign */,
    ControllerElementIdentifier elementIdentifiers /* NeedsAlign */,
    CompoundElement[] compoundElements /* NeedsAlign */,
    Platform_DirectInput directInput /* NeedsAlign */,
    Platform_RawInput rawInput /* NeedsAlign */,
    Platform_XInput xInput /* NeedsAlign */,
    Platform_OSX osx /* NeedsAlign */,
    Platform_Linux linux /* NeedsAlign */,
    Platform_WindowsUWP windowsUWP /* NeedsAlign */,
    Platform_Fallback fallback_Windows /* NeedsAlign */,
    Platform_Fallback fallback_WindowsUWP /* NeedsAlign */,
    Platform_Fallback fallback_OSX /* NeedsAlign */,
    Platform_Fallback fallback_Linux /* NeedsAlign */,
    Platform_Fallback fallback_Linux_PreConfigured /* NeedsAlign */,
    Platform_Fallback fallback_Android /* NeedsAlign */,
    Platform_Fallback fallback_iOS /* NeedsAlign */,
    Platform_Fallback fallback_XBoxOne /* NeedsAlign */,
    Platform_Fallback fallback_PS4 /* NeedsAlign */,
    Platform_PS5 ps5 /* NeedsAlign */,
    Platform_Fallback fallback_PSM /* NeedsAlign */,
    Platform_Fallback fallback_PSVita /* NeedsAlign */,
    Platform_Fallback fallback_AmazonFireTV /* NeedsAlign */,
    Platform_WebGL webGL /* NeedsAlign */,
    Platform_XboxOne xboxOne /* NeedsAlign */,
    Platform_GameCore gameCore /* NeedsAlign */,
    Platform_PS4 ps4 /* NeedsAlign */,
    Platform_NintendoSwitch nintendoSwitch /* NeedsAlign */,
    Platform_Stadia stadia /* NeedsAlign */,
    Platform_InternalDriver internalDriver /* NeedsAlign */,
    Platform_SDL2 sdl2_Linux /* NeedsAlign */,
    Platform_SDL2 sdl2_Windows /* NeedsAlign */,
    Platform_SDL2 sdl2_OSX /* NeedsAlign */,
    Platform_AppleGCController appleGCController /* NeedsAlign */,
    int elementIdentifierIdCounter /* NeedsAlign */)
{
    public static HardwareJoystickMap Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* controllerName */
        AsciiString _controllerName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* editorControllerName */
        AsciiString _editorControllerName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* description */
        AsciiString _description = BuiltInString.Read(reader);
        reader.AlignTo(4); /* controllerGuid */
        AsciiString _controllerGuid = BuiltInString.Read(reader);
        reader.AlignTo(4); /* templateGuids */
        AsciiString[] _templateGuids = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* hideInLists */
        byte _hideInLists = reader.ReadU8();
        reader.AlignTo(4); /* joystickTypes */
        int[] _joystickTypes = BuiltInArray<int>.Read(reader);
        reader.AlignTo(4); /* elementIdentifiers */
        ControllerElementIdentifier _elementIdentifiers = ControllerElementIdentifier.Read(reader);
        reader.AlignTo(4); /* compoundElements */
        CompoundElement[] _compoundElements = BuiltInArray<CompoundElement>.Read(reader);
        reader.AlignTo(4); /* directInput */
        Platform_DirectInput _directInput = Platform_DirectInput.Read(reader);
        reader.AlignTo(4); /* rawInput */
        Platform_RawInput _rawInput = Platform_RawInput.Read(reader);
        reader.AlignTo(4); /* xInput */
        Platform_XInput _xInput = Platform_XInput.Read(reader);
        reader.AlignTo(4); /* osx */
        Platform_OSX _osx = Platform_OSX.Read(reader);
        reader.AlignTo(4); /* linux */
        Platform_Linux _linux = Platform_Linux.Read(reader);
        reader.AlignTo(4); /* windowsUWP */
        Platform_WindowsUWP _windowsUWP = Platform_WindowsUWP.Read(reader);
        reader.AlignTo(4); /* fallback_Windows */
        Platform_Fallback _fallback_Windows = Platform_Fallback.Read(reader);
        reader.AlignTo(4); /* fallback_WindowsUWP */
        Platform_Fallback _fallback_WindowsUWP = Platform_Fallback.Read(reader);
        reader.AlignTo(4); /* fallback_OSX */
        Platform_Fallback _fallback_OSX = Platform_Fallback.Read(reader);
        reader.AlignTo(4); /* fallback_Linux */
        Platform_Fallback _fallback_Linux = Platform_Fallback.Read(reader);
        reader.AlignTo(4); /* fallback_Linux_PreConfigured */
        Platform_Fallback _fallback_Linux_PreConfigured = Platform_Fallback.Read(reader);
        reader.AlignTo(4); /* fallback_Android */
        Platform_Fallback _fallback_Android = Platform_Fallback.Read(reader);
        reader.AlignTo(4); /* fallback_iOS */
        Platform_Fallback _fallback_iOS = Platform_Fallback.Read(reader);
        reader.AlignTo(4); /* fallback_XBoxOne */
        Platform_Fallback _fallback_XBoxOne = Platform_Fallback.Read(reader);
        reader.AlignTo(4); /* fallback_PS4 */
        Platform_Fallback _fallback_PS4 = Platform_Fallback.Read(reader);
        reader.AlignTo(4); /* ps5 */
        Platform_PS5 _ps5 = Platform_PS5.Read(reader);
        reader.AlignTo(4); /* fallback_PSM */
        Platform_Fallback _fallback_PSM = Platform_Fallback.Read(reader);
        reader.AlignTo(4); /* fallback_PSVita */
        Platform_Fallback _fallback_PSVita = Platform_Fallback.Read(reader);
        reader.AlignTo(4); /* fallback_AmazonFireTV */
        Platform_Fallback _fallback_AmazonFireTV = Platform_Fallback.Read(reader);
        reader.AlignTo(4); /* webGL */
        Platform_WebGL _webGL = Platform_WebGL.Read(reader);
        reader.AlignTo(4); /* xboxOne */
        Platform_XboxOne _xboxOne = Platform_XboxOne.Read(reader);
        reader.AlignTo(4); /* gameCore */
        Platform_GameCore _gameCore = Platform_GameCore.Read(reader);
        reader.AlignTo(4); /* ps4 */
        Platform_PS4 _ps4 = Platform_PS4.Read(reader);
        reader.AlignTo(4); /* nintendoSwitch */
        Platform_NintendoSwitch _nintendoSwitch = Platform_NintendoSwitch.Read(reader);
        reader.AlignTo(4); /* stadia */
        Platform_Stadia _stadia = Platform_Stadia.Read(reader);
        reader.AlignTo(4); /* internalDriver */
        Platform_InternalDriver _internalDriver = Platform_InternalDriver.Read(reader);
        reader.AlignTo(4); /* sdl2_Linux */
        Platform_SDL2 _sdl2_Linux = Platform_SDL2.Read(reader);
        reader.AlignTo(4); /* sdl2_Windows */
        Platform_SDL2 _sdl2_Windows = Platform_SDL2.Read(reader);
        reader.AlignTo(4); /* sdl2_OSX */
        Platform_SDL2 _sdl2_OSX = Platform_SDL2.Read(reader);
        reader.AlignTo(4); /* appleGCController */
        Platform_AppleGCController _appleGCController = Platform_AppleGCController.Read(reader);
        reader.AlignTo(4); /* elementIdentifierIdCounter */
        int _elementIdentifierIdCounter = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _controllerName,
            _editorControllerName,
            _description,
            _controllerGuid,
            _templateGuids,
            _hideInLists,
            _joystickTypes,
            _elementIdentifiers,
            _compoundElements,
            _directInput,
            _rawInput,
            _xInput,
            _osx,
            _linux,
            _windowsUWP,
            _fallback_Windows,
            _fallback_WindowsUWP,
            _fallback_OSX,
            _fallback_Linux,
            _fallback_Linux_PreConfigured,
            _fallback_Android,
            _fallback_iOS,
            _fallback_XBoxOne,
            _fallback_PS4,
            _ps5,
            _fallback_PSM,
            _fallback_PSVita,
            _fallback_AmazonFireTV,
            _webGL,
            _xboxOne,
            _gameCore,
            _ps4,
            _nintendoSwitch,
            _stadia,
            _internalDriver,
            _sdl2_Linux,
            _sdl2_Windows,
            _sdl2_OSX,
            _appleGCController,
            _elementIdentifierIdCounter);
    }
}

