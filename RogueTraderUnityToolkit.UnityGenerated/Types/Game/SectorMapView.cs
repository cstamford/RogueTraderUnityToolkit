namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SectorMapView (17 fields) 51657D60F1DA8ADE4981D808B60F8731/801BE77F0BFB8D2449D1BB583613118D */
public record class SectorMapView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte ShowAdditionalGizmos /* NeedsAlign */,
    PPtr<Transform> HorizontalPointerLine /* NeedsAlign */,
    PPtr<Transform> VerticalPointerLine /* None */,
    PPtr<Collider> MapCollider /* None */,
    PPtr<ScanPulseController> ScanPulse /* None */,
    PPtr<SystemNameController> SystemNamePrefab /* None */,
    float distanceBetweenBezierPoints /* None */,
    float bezierPointsCurveRangeSafe /* None */,
    float bezierPointsCurveRangeUnsafe /* None */,
    float bezierPointsCurveRangeDangerous /* None */,
    float bezierPointsCurveRangeDeadly /* None */,
    PPtr<SectorMapObject>[] SectorMapObjects /* None */,
    PPtr<SectorMapPassageView>[] SectorMapPassages /* None */)
{
    public static SectorMapView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* ShowAdditionalGizmos */
        byte _ShowAdditionalGizmos = reader.ReadU8();
        reader.AlignTo(4); /* HorizontalPointerLine */
        PPtr<Transform> _HorizontalPointerLine = PPtr<Transform>.Read(reader);
        PPtr<Transform> _VerticalPointerLine = PPtr<Transform>.Read(reader);
        PPtr<Collider> _MapCollider = PPtr<Collider>.Read(reader);
        PPtr<ScanPulseController> _ScanPulse = PPtr<ScanPulseController>.Read(reader);
        PPtr<SystemNameController> _SystemNamePrefab = PPtr<SystemNameController>.Read(reader);
        float _distanceBetweenBezierPoints = reader.ReadF32();
        float _bezierPointsCurveRangeSafe = reader.ReadF32();
        float _bezierPointsCurveRangeUnsafe = reader.ReadF32();
        float _bezierPointsCurveRangeDangerous = reader.ReadF32();
        float _bezierPointsCurveRangeDeadly = reader.ReadF32();
        PPtr<SectorMapObject>[] _SectorMapObjects = BuiltInArray<PPtr<SectorMapObject>>.Read(reader);
        PPtr<SectorMapPassageView>[] _SectorMapPassages = BuiltInArray<PPtr<SectorMapPassageView>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _ShowAdditionalGizmos,
            _HorizontalPointerLine,
            _VerticalPointerLine,
            _MapCollider,
            _ScanPulse,
            _SystemNamePrefab,
            _distanceBetweenBezierPoints,
            _bezierPointsCurveRangeSafe,
            _bezierPointsCurveRangeUnsafe,
            _bezierPointsCurveRangeDangerous,
            _bezierPointsCurveRangeDeadly,
            _SectorMapObjects,
            _SectorMapPassages);
    }
}

