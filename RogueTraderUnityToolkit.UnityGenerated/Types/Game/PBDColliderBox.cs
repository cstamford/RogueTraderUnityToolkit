namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PBDColliderBox (8 fields) 5AC516670B1CC0861127CC58F0DEC97C/649E0E63763C7D93A2394B18FDA059F9 */
public record class PBDColliderBox(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float Restitution /* NeedsAlign */,
    float Friction /* None */,
    byte m_IsGlobal /* None */,
    float3 Size /* NeedsAlign */)
{
    public static PBDColliderBox Read(EndianBinaryReader reader)
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
        reader.AlignTo(4); /* Size */
        float3 _Size = float3.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Restitution,
            _Friction,
            _m_IsGlobal,
            _Size);
    }
}

