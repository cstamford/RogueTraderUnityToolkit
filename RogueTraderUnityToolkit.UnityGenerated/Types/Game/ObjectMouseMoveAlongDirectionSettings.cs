namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectMouseMoveAlongDirectionSettings (6 fields) 4772B46FDC019BAFCD6A0FA29C6E941E/6B801F3E1C702537163FC1B345EDAA62 */
public record class ObjectMouseMoveAlongDirectionSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float _mouseSensitivity /* NeedsAlign */,
    ObjectMouseMoveAlongDirectionSettingsView _view /* None */)
{
    public static ObjectMouseMoveAlongDirectionSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _mouseSensitivity */
        float __mouseSensitivity = reader.ReadF32();
        ObjectMouseMoveAlongDirectionSettingsView __view = ObjectMouseMoveAlongDirectionSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __mouseSensitivity,
            __view);
    }
}

