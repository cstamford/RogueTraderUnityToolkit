namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpaceCombatBackgroundComposerConfigs (9 fields) C6DCE1CB91EA3BAD1FA17B2A534516CC/F03CC3C2735918C367CD2F9ED2D45BBB */
public record class SpaceCombatBackgroundComposerConfigs(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float SystemRadius /* NeedsAlign */,
    Vector3f SystemOffset /* None */,
    MaterialLink SkyDomeMaterial /* None */,
    StarProperties Star /* NeedsAlign */,
    SpaceObjectProperties[] Planets /* NeedsAlign */)
{
    public static SpaceCombatBackgroundComposerConfigs Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* SystemRadius */
        float _SystemRadius = reader.ReadF32();
        Vector3f _SystemOffset = Vector3f.Read(reader);
        MaterialLink _SkyDomeMaterial = MaterialLink.Read(reader);
        reader.AlignTo(4); /* Star */
        StarProperties _Star = StarProperties.Read(reader);
        reader.AlignTo(4); /* Planets */
        SpaceObjectProperties[] _Planets = BuiltInArray<SpaceObjectProperties>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _SystemRadius,
            _SystemOffset,
            _SkyDomeMaterial,
            _Star,
            _Planets);
    }
}

