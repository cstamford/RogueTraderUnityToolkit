namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CustomAxisMouseRotationSettings (6 fields) C9412A0DC4B5E61456F63F39D282EBDF/2FC5C47BA910DCF7A1DB8B1299514DF1 */
public record class CustomAxisMouseRotationSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float _mouseSensitivity /* NeedsAlign */,
    CustomAxisMouseRotationSettingsView _view /* None */)
{
    public static CustomAxisMouseRotationSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _mouseSensitivity */
        float __mouseSensitivity = reader.ReadF32();
        CustomAxisMouseRotationSettingsView __view = CustomAxisMouseRotationSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __mouseSensitivity,
            __view);
    }
}

