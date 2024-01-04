namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $InteractableMirrorSettings (8 fields) 24041A5CF6EDB9E273CFF333B9FDF56C/A1B78019F8B97C0A605D28F54DEB44AB */
public record class InteractableMirrorSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ObjectMouseMoveAlongDirectionSettings> _mouseOffsetFromHoverSurfaceSettings /* NeedsAlign */,
    PPtr<ObjectMouseRotationSettings> _mouseRotationSettings /* None */,
    PPtr<ObjectKeyboardRotationSettings> _keyboardRotationSettings /* None */,
    InteractableMirrorSettingsView _view /* None */)
{
    public static InteractableMirrorSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _mouseOffsetFromHoverSurfaceSettings */
        PPtr<ObjectMouseMoveAlongDirectionSettings> __mouseOffsetFromHoverSurfaceSettings = PPtr<ObjectMouseMoveAlongDirectionSettings>.Read(reader);
        PPtr<ObjectMouseRotationSettings> __mouseRotationSettings = PPtr<ObjectMouseRotationSettings>.Read(reader);
        PPtr<ObjectKeyboardRotationSettings> __keyboardRotationSettings = PPtr<ObjectKeyboardRotationSettings>.Read(reader);
        InteractableMirrorSettingsView __view = InteractableMirrorSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __mouseOffsetFromHoverSurfaceSettings,
            __mouseRotationSettings,
            __keyboardRotationSettings,
            __view);
    }
}

