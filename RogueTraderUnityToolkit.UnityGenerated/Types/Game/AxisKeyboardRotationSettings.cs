namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AxisKeyboardRotationSettings (7 fields) B28E89B00F75DEF869732752985A24CD/DA9DCC3197796FAD258519F52C88F2C6 */
public record class AxisKeyboardRotationSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int _rotationAxis /* NeedsAlign */,
    float _rotationAmountInDegrees /* None */,
    AxisKeyboardRotationSettingsView _view /* None */)
{
    public static AxisKeyboardRotationSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _rotationAxis */
        int __rotationAxis = reader.ReadS32();
        float __rotationAmountInDegrees = reader.ReadF32();
        AxisKeyboardRotationSettingsView __view = AxisKeyboardRotationSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __rotationAxis,
            __rotationAmountInDegrees,
            __view);
    }
}

