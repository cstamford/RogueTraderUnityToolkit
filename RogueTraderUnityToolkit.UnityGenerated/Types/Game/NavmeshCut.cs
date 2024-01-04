namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $NavmeshCut (20 fields) 0B3073438BAEDC063F56BAC61941816D/76948F7FF05D67133F6B4E72B48DEF5B */
public record class NavmeshCut(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int version /* NeedsAlign */,
    byte gridGuoApplied /* None */,
    int type /* NeedsAlign */,
    PPtr<Mesh> mesh /* None */,
    Vector2f rectangleSize /* None */,
    float circleRadius /* None */,
    int circleResolution /* None */,
    float height /* None */,
    float meshScale /* None */,
    Vector3f center /* None */,
    float updateDistance /* None */,
    byte isDual /* None */,
    byte cutsAddedGeom /* NeedsAlign */,
    float updateRotationDistance /* NeedsAlign */,
    byte useRotationAndScale /* None */,
    AABB lastBounds /* NeedsAlign */)
{
    public static NavmeshCut Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* version */
        int _version = reader.ReadS32();
        byte _gridGuoApplied = reader.ReadU8();
        reader.AlignTo(4); /* type */
        int _type = reader.ReadS32();
        PPtr<Mesh> _mesh = PPtr<Mesh>.Read(reader);
        Vector2f _rectangleSize = Vector2f.Read(reader);
        float _circleRadius = reader.ReadF32();
        int _circleResolution = reader.ReadS32();
        float _height = reader.ReadF32();
        float _meshScale = reader.ReadF32();
        Vector3f _center = Vector3f.Read(reader);
        float _updateDistance = reader.ReadF32();
        byte _isDual = reader.ReadU8();
        reader.AlignTo(4); /* cutsAddedGeom */
        byte _cutsAddedGeom = reader.ReadU8();
        reader.AlignTo(4); /* updateRotationDistance */
        float _updateRotationDistance = reader.ReadF32();
        byte _useRotationAndScale = reader.ReadU8();
        reader.AlignTo(4); /* lastBounds */
        AABB _lastBounds = AABB.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _version,
            _gridGuoApplied,
            _type,
            _mesh,
            _rectangleSize,
            _circleRadius,
            _circleResolution,
            _height,
            _meshScale,
            _center,
            _updateDistance,
            _isDual,
            _cutsAddedGeom,
            _updateRotationDistance,
            _useRotationAndScale,
            _lastBounds);
    }
}

