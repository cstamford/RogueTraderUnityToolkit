namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ScriptZone (16 fields) 71070403ED2D09CF2FB2502451106C28/26D13C7167884EE21C839BD52CE396E1 */
public record class ScriptZone(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_IsInGame /* NeedsAlign */,
    AsciiString UniqueId /* NeedsAlign */,
    PPtr<Renderer>[] m_HideRenderers /* NeedsAlign */,
    byte AreaHighlighted /* None */,
    BlueprintScriptZoneReference m_Blueprint /* NeedsAlign */,
    AABB m_Bounds /* NeedsAlign */,
    AABB[] m_MoreBounds /* None */,
    byte m_OnceOnly /* NeedsAlign */,
    byte m_PlayersOnly /* NeedsAlign */,
    byte m_StartInactive /* NeedsAlign */,
    UnitEvent OnUnitEntered /* NeedsAlign */,
    UnitEvent OnUnitExited /* NeedsAlign */)
{
    public static ScriptZone Read(EndianBinaryReader reader)
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
        reader.AlignTo(4); /* m_HideRenderers */
        PPtr<Renderer>[] _m_HideRenderers = BuiltInArray<PPtr<Renderer>>.Read(reader);
        byte _AreaHighlighted = reader.ReadU8();
        reader.AlignTo(4); /* m_Blueprint */
        BlueprintScriptZoneReference _m_Blueprint = BlueprintScriptZoneReference.Read(reader);
        reader.AlignTo(4); /* m_Bounds */
        AABB _m_Bounds = AABB.Read(reader);
        AABB[] _m_MoreBounds = BuiltInArray<AABB>.Read(reader);
        reader.AlignTo(4); /* m_OnceOnly */
        byte _m_OnceOnly = reader.ReadU8();
        reader.AlignTo(4); /* m_PlayersOnly */
        byte _m_PlayersOnly = reader.ReadU8();
        reader.AlignTo(4); /* m_StartInactive */
        byte _m_StartInactive = reader.ReadU8();
        reader.AlignTo(4); /* OnUnitEntered */
        UnitEvent _OnUnitEntered = UnitEvent.Read(reader);
        reader.AlignTo(4); /* OnUnitExited */
        UnitEvent _OnUnitExited = UnitEvent.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_IsInGame,
            _UniqueId,
            _m_HideRenderers,
            _AreaHighlighted,
            _m_Blueprint,
            _m_Bounds,
            _m_MoreBounds,
            _m_OnceOnly,
            _m_PlayersOnly,
            _m_StartInactive,
            _OnUnitEntered,
            _OnUnitExited);
    }
}

