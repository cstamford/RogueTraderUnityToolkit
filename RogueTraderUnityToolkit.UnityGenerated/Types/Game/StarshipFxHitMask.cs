namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $StarshipFxHitMask (10 fields) E28F9BD5BDAFBC1F0C17DB218312CD1A/458CBEF710498E850B64D6F25E684BB5 */
public record class StarshipFxHitMask(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Mesh> mesh /* NeedsAlign */,
    int hitPointsPerSide /* None */,
    Vector3f[] frontHitPositions /* None */,
    Vector3f[] backHitPositions /* NeedsAlign */,
    Vector3f[] leftHitPositions /* NeedsAlign */,
    Vector3f[] rightHitPositions /* NeedsAlign */)
{
    public static StarshipFxHitMask Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* mesh */
        PPtr<Mesh> _mesh = PPtr<Mesh>.Read(reader);
        int _hitPointsPerSide = reader.ReadS32();
        Vector3f[] _frontHitPositions = BuiltInArray<Vector3f>.Read(reader);
        reader.AlignTo(4); /* backHitPositions */
        Vector3f[] _backHitPositions = BuiltInArray<Vector3f>.Read(reader);
        reader.AlignTo(4); /* leftHitPositions */
        Vector3f[] _leftHitPositions = BuiltInArray<Vector3f>.Read(reader);
        reader.AlignTo(4); /* rightHitPositions */
        Vector3f[] _rightHitPositions = BuiltInArray<Vector3f>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _mesh,
            _hitPointsPerSide,
            _frontHitPositions,
            _backHitPositions,
            _leftHitPositions,
            _rightHitPositions);
    }
}

