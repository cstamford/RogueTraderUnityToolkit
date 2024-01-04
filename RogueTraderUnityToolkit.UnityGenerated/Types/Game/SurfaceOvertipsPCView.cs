namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceOvertipsPCView (7 fields) 789C723FE564199E66D2305CACC30B59/A84DBA92E937FB35BF18062FC9A9A449 */
public record class SurfaceOvertipsPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<UnitOvertipsView> m_UnitOvertipsPCView /* NeedsAlign */,
    PPtr<LightweightUnitOvertipsCollectionView> m_LightweightUnitOvertipsPCView /* None */,
    PPtr<MapObjectOvertipsPCView> m_MapObjectOvertipsPCView /* None */)
{
    public static SurfaceOvertipsPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_UnitOvertipsPCView */
        PPtr<UnitOvertipsView> _m_UnitOvertipsPCView = PPtr<UnitOvertipsView>.Read(reader);
        PPtr<LightweightUnitOvertipsCollectionView> _m_LightweightUnitOvertipsPCView = PPtr<LightweightUnitOvertipsCollectionView>.Read(reader);
        PPtr<MapObjectOvertipsPCView> _m_MapObjectOvertipsPCView = PPtr<MapObjectOvertipsPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_UnitOvertipsPCView,
            _m_LightweightUnitOvertipsPCView,
            _m_MapObjectOvertipsPCView);
    }
}

