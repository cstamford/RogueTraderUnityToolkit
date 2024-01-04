namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CritterMoveAgent (7 fields) 6FA2F1B2D0792DF00AC79189C3905736/C0C40A75B91A9699CB1913C167C31CA4 */
public record class CritterMoveAgent(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float m_Acceleration /* NeedsAlign */,
    float m_AngularSpeed /* None */,
    float MaxSpeed /* None */)
{
    public static CritterMoveAgent Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Acceleration */
        float _m_Acceleration = reader.ReadF32();
        float _m_AngularSpeed = reader.ReadF32();
        float _MaxSpeed = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Acceleration,
            _m_AngularSpeed,
            _MaxSpeed);
    }
}

