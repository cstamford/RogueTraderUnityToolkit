namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $StarSystemShip (8 fields) 91FA49A6B6193A6FE0A7A4E82715EC52/A82445F9DFF529A053CF569F944F0CF5 */
public record class StarSystemShip(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Transform> mechanicsTransform /* NeedsAlign */,
    PPtr<StarSystemStarshipView> view /* None */,
    float m_MaxSpeedOverride /* None */,
    float m_ApproachStarSystemObjectRadius /* None */)
{
    public static StarSystemShip Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* mechanicsTransform */
        PPtr<Transform> _mechanicsTransform = PPtr<Transform>.Read(reader);
        PPtr<StarSystemStarshipView> _view = PPtr<StarSystemStarshipView>.Read(reader);
        float _m_MaxSpeedOverride = reader.ReadF32();
        float _m_ApproachStarSystemObjectRadius = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _mechanicsTransform,
            _view,
            _m_MaxSpeedOverride,
            _m_ApproachStarSystemObjectRadius);
    }
}

