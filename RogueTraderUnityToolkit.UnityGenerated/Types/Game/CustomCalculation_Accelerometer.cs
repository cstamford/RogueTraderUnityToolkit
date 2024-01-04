namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CustomCalculation_Accelerometer (7 fields) 044308C167967DF95C4953CB87A35122/170923E00081B951C17F3E05AA7E7D66 */
public record class CustomCalculation_Accelerometer(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int _calculationType /* NeedsAlign */,
    int _inputType /* None */,
    int _outputType /* None */)
{
    public static CustomCalculation_Accelerometer Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _calculationType */
        int __calculationType = reader.ReadS32();
        int __inputType = reader.ReadS32();
        int __outputType = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __calculationType,
            __inputType,
            __outputType);
    }
}

