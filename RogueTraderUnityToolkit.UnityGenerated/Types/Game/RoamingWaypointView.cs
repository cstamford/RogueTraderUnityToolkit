namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $RoamingWaypointView (11 fields) 2535F4AB6A6C75E7C46D06B5AB76448F/87748548BC37D4EF24B4AF3DD028B921 */
public record class RoamingWaypointView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_IsInGame /* NeedsAlign */,
    AsciiString UniqueId /* NeedsAlign */,
    byte UseOrientation /* NeedsAlign */,
    float MinIdleTime /* NeedsAlign */,
    float MaxIdleTime /* None */,
    CutsceneReference[] IdleCutscenes /* None */,
    NextWaypointEntry[] NextWaypoints /* NeedsAlign */)
{
    public static RoamingWaypointView Read(EndianBinaryReader reader)
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
        reader.AlignTo(4); /* UseOrientation */
        byte _UseOrientation = reader.ReadU8();
        reader.AlignTo(4); /* MinIdleTime */
        float _MinIdleTime = reader.ReadF32();
        float _MaxIdleTime = reader.ReadF32();
        CutsceneReference[] _IdleCutscenes = BuiltInArray<CutsceneReference>.Read(reader);
        reader.AlignTo(4); /* NextWaypoints */
        NextWaypointEntry[] _NextWaypoints = BuiltInArray<NextWaypointEntry>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_IsInGame,
            _UniqueId,
            _UseOrientation,
            _MinIdleTime,
            _MaxIdleTime,
            _IdleCutscenes,
            _NextWaypoints);
    }
}

