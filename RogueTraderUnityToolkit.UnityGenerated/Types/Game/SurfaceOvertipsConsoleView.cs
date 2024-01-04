namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceOvertipsConsoleView (7 fields) D787D1B7FE83B51A0AFAAE40A34ED4C3/10D5D2D57904C7017B0D0DF89124C647 */
public record class SurfaceOvertipsConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<UnitOvertipsView> m_UnitOvertipsView /* NeedsAlign */,
    PPtr<LightweightUnitOvertipsCollectionView> m_LightweightUnitOvertipsView /* None */,
    PPtr<MapObjectOvertipsConsoleView> m_MapObjectOvertipsConsoleView /* None */)
{
    public static SurfaceOvertipsConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_UnitOvertipsView */
        PPtr<UnitOvertipsView> _m_UnitOvertipsView = PPtr<UnitOvertipsView>.Read(reader);
        PPtr<LightweightUnitOvertipsCollectionView> _m_LightweightUnitOvertipsView = PPtr<LightweightUnitOvertipsCollectionView>.Read(reader);
        PPtr<MapObjectOvertipsConsoleView> _m_MapObjectOvertipsConsoleView = PPtr<MapObjectOvertipsConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_UnitOvertipsView,
            _m_LightweightUnitOvertipsView,
            _m_MapObjectOvertipsConsoleView);
    }
}

