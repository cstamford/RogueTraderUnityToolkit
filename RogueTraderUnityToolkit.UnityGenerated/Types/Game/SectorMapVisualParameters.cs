namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SectorMapVisualParameters (9 fields) 7AAE513446CF3D27BBB654624835CE12/06426C643DD75E872518B953289FE348 */
public record class SectorMapVisualParameters(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    WarpPassageVisualParameters WarpPassagesVisualParameters /* NeedsAlign */,
    PPtr<Transform> PlayerShip /* NeedsAlign */,
    float WaitWarpTravelToStartInSeconds /* None */,
    float WaitWarpTravelToEndInSeconds /* None */,
    StarSystemPrefab StarSystemPrefabVariants /* None */)
{
    public static SectorMapVisualParameters Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* WarpPassagesVisualParameters */
        WarpPassageVisualParameters _WarpPassagesVisualParameters = WarpPassageVisualParameters.Read(reader);
        reader.AlignTo(4); /* PlayerShip */
        PPtr<Transform> _PlayerShip = PPtr<Transform>.Read(reader);
        float _WaitWarpTravelToStartInSeconds = reader.ReadF32();
        float _WaitWarpTravelToEndInSeconds = reader.ReadF32();
        StarSystemPrefab _StarSystemPrefabVariants = StarSystemPrefab.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _WarpPassagesVisualParameters,
            _PlayerShip,
            _WaitWarpTravelToStartInSeconds,
            _WaitWarpTravelToEndInSeconds,
            _StarSystemPrefabVariants);
    }
}

