namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CustomAxisKeyboardRotationSettings (6 fields) 1DD06776F1A42040D1032582D7BB5953/083A86E780E174EF55EE30594B75517A */
public record class CustomAxisKeyboardRotationSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float _rotationAmountInDegrees /* NeedsAlign */,
    CustomAxisKeyboardRotationSettingsView _view /* None */)
{
    public static CustomAxisKeyboardRotationSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _rotationAmountInDegrees */
        float __rotationAmountInDegrees = reader.ReadF32();
        CustomAxisKeyboardRotationSettingsView __view = CustomAxisKeyboardRotationSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __rotationAmountInDegrees,
            __view);
    }
}

