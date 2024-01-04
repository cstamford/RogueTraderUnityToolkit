namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $InputManager (7 fields) 0F8CD2D9ED2C27AAA40804513AF47C52/D47E735029C2237EF4F7F45A8A9D0CD5 */
public record class InputManager(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte _dontDestroyOnLoad /* NeedsAlign */,
    UserData _userData /* NeedsAlign */,
    PPtr<ControllerDataFiles> _controllerDataFiles /* NeedsAlign */)
{
    public static InputManager Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _dontDestroyOnLoad */
        byte __dontDestroyOnLoad = reader.ReadU8();
        reader.AlignTo(4); /* _userData */
        UserData __userData = UserData.Read(reader);
        reader.AlignTo(4); /* _controllerDataFiles */
        PPtr<ControllerDataFiles> __controllerDataFiles = PPtr<ControllerDataFiles>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __dontDestroyOnLoad,
            __userData,
            __controllerDataFiles);
    }
}

