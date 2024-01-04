namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpawnerRoamingSettings (13 fields) FA86CF9321611011261660752C0F096E/222C46641ABD0745C9A5897B19B9AAE8 */
public record class SpawnerRoamingSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int Mode /* NeedsAlign */,
    EntityReference FirstWaypoint /* None */,
    float Radius /* NeedsAlign */,
    CutsceneReference IdleCutscenes /* None */,
    float MinIdleTime /* NeedsAlign */,
    float MaxIdleTime /* None */,
    int MovementType /* None */,
    float MovementSpeed /* None */,
    byte Sleepless /* None */)
{
    public static SpawnerRoamingSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Mode */
        int _Mode = reader.ReadS32();
        EntityReference _FirstWaypoint = EntityReference.Read(reader);
        reader.AlignTo(4); /* Radius */
        float _Radius = reader.ReadF32();
        CutsceneReference _IdleCutscenes = CutsceneReference.Read(reader);
        reader.AlignTo(4); /* MinIdleTime */
        float _MinIdleTime = reader.ReadF32();
        float _MaxIdleTime = reader.ReadF32();
        int _MovementType = reader.ReadS32();
        float _MovementSpeed = reader.ReadF32();
        byte _Sleepless = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Mode,
            _FirstWaypoint,
            _Radius,
            _IdleCutscenes,
            _MinIdleTime,
            _MaxIdleTime,
            _MovementType,
            _MovementSpeed,
            _Sleepless);
    }
}

