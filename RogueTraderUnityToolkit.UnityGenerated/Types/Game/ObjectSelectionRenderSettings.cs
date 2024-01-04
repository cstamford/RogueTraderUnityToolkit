namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectSelectionRenderSettings (6 fields) 093F1AEF913D08848F6958309094A3D8/7250D4AD076F852075CAA85C39FB8041 */
public record class ObjectSelectionRenderSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ObjectSelectionBoxRenderModeSettings> _boxRenderModeSettings /* NeedsAlign */,
    ObjectSelectionRenderSettingsView _view /* None */)
{
    public static ObjectSelectionRenderSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _boxRenderModeSettings */
        PPtr<ObjectSelectionBoxRenderModeSettings> __boxRenderModeSettings = PPtr<ObjectSelectionBoxRenderModeSettings>.Read(reader);
        ObjectSelectionRenderSettingsView __view = ObjectSelectionRenderSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __boxRenderModeSettings,
            __view);
    }
}

