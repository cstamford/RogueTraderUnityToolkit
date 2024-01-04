namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectMouseUniformScaleSettings (8 fields) E1B1D70C7171905B0C8E1F9A73BC9285/FAEB882B60B72ACE818A4C50AFE5B80B */
public record class ObjectMouseUniformScaleSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float _mouseSensitivity /* NeedsAlign */,
    float _snapStep /* None */,
    byte _useSnapping /* None */,
    ObjectMouseUniformScaleSettingsView _view /* NeedsAlign */)
{
    public static ObjectMouseUniformScaleSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _mouseSensitivity */
        float __mouseSensitivity = reader.ReadF32();
        float __snapStep = reader.ReadF32();
        byte __useSnapping = reader.ReadU8();
        reader.AlignTo(4); /* _view */
        ObjectMouseUniformScaleSettingsView __view = ObjectMouseUniformScaleSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __mouseSensitivity,
            __snapStep,
            __useSnapping,
            __view);
    }
}

