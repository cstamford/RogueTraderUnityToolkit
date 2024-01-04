namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SectorMapObject (19 fields) 2EF7D7543DC4A038C427BDF6B1553FEA/63100EA72B0AE48FEEC104040CE3B5C3 */
public record class SectorMapObject(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_IsInGame /* NeedsAlign */,
    AsciiString UniqueId /* NeedsAlign */,
    BlueprintSectorMapPointReference m_Blueprint /* NeedsAlign */,
    byte IsSystem /* NeedsAlign */,
    byte IsExploredOnStart /* NeedsAlign */,
    byte IsVisitedOnStart /* NeedsAlign */,
    byte Hidden /* NeedsAlign */,
    int VisualVariant /* NeedsAlign */,
    StarSystemPrefab OverrideVisualPrefab /* None */,
    PPtr<SystemNameController> SystemNamePrefab /* None */,
    byte m_LayerNameVisibility /* None */,
    PPtr<SystemPlanetDecalCanTravelController> SystemPlanetDecalCanTravelPrefab /* NeedsAlign */,
    byte m_LayerPlanetDecalCanTravelVisibility /* None */,
    PPtr<SystemPlanetDecalConsoleFocusController> SystemPlanetDecalConsoleFocusPrefab /* NeedsAlign */,
    PPtr<SystemPlanetDecalCoopPingController> SystemPlanetDecalCoopPingPrefab /* None */)
{
    public static SectorMapObject Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_IsInGame */
        byte _m_IsInGame = reader.ReadU8();
        reader.AlignTo(4); /* UniqueId */
        AsciiString _UniqueId = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Blueprint */
        BlueprintSectorMapPointReference _m_Blueprint = BlueprintSectorMapPointReference.Read(reader);
        reader.AlignTo(4); /* IsSystem */
        byte _IsSystem = reader.ReadU8();
        reader.AlignTo(4); /* IsExploredOnStart */
        byte _IsExploredOnStart = reader.ReadU8();
        reader.AlignTo(4); /* IsVisitedOnStart */
        byte _IsVisitedOnStart = reader.ReadU8();
        reader.AlignTo(4); /* Hidden */
        byte _Hidden = reader.ReadU8();
        reader.AlignTo(4); /* VisualVariant */
        int _VisualVariant = reader.ReadS32();
        StarSystemPrefab _OverrideVisualPrefab = StarSystemPrefab.Read(reader);
        PPtr<SystemNameController> _SystemNamePrefab = PPtr<SystemNameController>.Read(reader);
        byte _m_LayerNameVisibility = reader.ReadU8();
        reader.AlignTo(4); /* SystemPlanetDecalCanTravelPrefab */
        PPtr<SystemPlanetDecalCanTravelController> _SystemPlanetDecalCanTravelPrefab = PPtr<SystemPlanetDecalCanTravelController>.Read(reader);
        byte _m_LayerPlanetDecalCanTravelVisibility = reader.ReadU8();
        reader.AlignTo(4); /* SystemPlanetDecalConsoleFocusPrefab */
        PPtr<SystemPlanetDecalConsoleFocusController> _SystemPlanetDecalConsoleFocusPrefab = PPtr<SystemPlanetDecalConsoleFocusController>.Read(reader);
        PPtr<SystemPlanetDecalCoopPingController> _SystemPlanetDecalCoopPingPrefab = PPtr<SystemPlanetDecalCoopPingController>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_IsInGame,
            _UniqueId,
            _m_Blueprint,
            _IsSystem,
            _IsExploredOnStart,
            _IsVisitedOnStart,
            _Hidden,
            _VisualVariant,
            _OverrideVisualPrefab,
            _SystemNamePrefab,
            _m_LayerNameVisibility,
            _SystemPlanetDecalCanTravelPrefab,
            _m_LayerPlanetDecalCanTravelVisibility,
            _SystemPlanetDecalConsoleFocusPrefab,
            _SystemPlanetDecalCoopPingPrefab);
    }
}

