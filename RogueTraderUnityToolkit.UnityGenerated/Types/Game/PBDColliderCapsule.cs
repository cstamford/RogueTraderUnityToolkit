namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PBDColliderCapsule (11 fields) 3CADF85FA70C91F5AC0D53E0232A9039/5DFF9FD342D2900FA39C41B2CEDAFB1C */
public record class PBDColliderCapsule(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float Restitution /* NeedsAlign */,
    float Friction /* None */,
    byte m_IsGlobal /* None */,
    float Radius0 /* NeedsAlign */,
    float Radius1 /* None */,
    float Height /* None */,
    int Direction /* None */)
{
    public static PBDColliderCapsule Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Restitution */
        float _Restitution = reader.ReadF32();
        float _Friction = reader.ReadF32();
        byte _m_IsGlobal = reader.ReadU8();
        reader.AlignTo(4); /* Radius0 */
        float _Radius0 = reader.ReadF32();
        float _Radius1 = reader.ReadF32();
        float _Height = reader.ReadF32();
        int _Direction = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Restitution,
            _Friction,
            _m_IsGlobal,
            _Radius0,
            _Radius1,
            _Height,
            _Direction);
    }
}

