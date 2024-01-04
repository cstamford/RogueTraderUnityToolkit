namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CoordinateSystemRenderSettings (8 fields) 70D8EA140281408BFD93FABDF2F26671/41EC99E0AFB3781F806D408F02D9178D */
public record class CoordinateSystemRenderSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte _isVisible /* NeedsAlign */,
    PPtr<CoordinateSystemAxisRenderSettings>[] _axesRenderSettings /* NeedsAlign */,
    CoordinateSystemRenderSettingsView _view /* None */,
    byte _wasInitialized /* NeedsAlign */)
{
    public static CoordinateSystemRenderSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _isVisible */
        byte __isVisible = reader.ReadU8();
        reader.AlignTo(4); /* _axesRenderSettings */
        PPtr<CoordinateSystemAxisRenderSettings>[] __axesRenderSettings = BuiltInArray<PPtr<CoordinateSystemAxisRenderSettings>>.Read(reader);
        CoordinateSystemRenderSettingsView __view = CoordinateSystemRenderSettingsView.Read(reader);
        reader.AlignTo(4); /* _wasInitialized */
        byte __wasInitialized = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __isVisible,
            __axesRenderSettings,
            __view,
            __wasInitialized);
    }
}

