namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectRotator (6 fields) 6E5B966A760457AA268B06FB150115C8/108E8160C48ED652BC12A818A14A3E58 */
public record class ObjectRotator(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    Vector3f AngularSpeed /* NeedsAlign */,
    float TimeStep /* None */)
{
    public static ObjectRotator Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* AngularSpeed */
        Vector3f _AngularSpeed = Vector3f.Read(reader);
        float _TimeStep = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _AngularSpeed,
            _TimeStep);
    }
}

