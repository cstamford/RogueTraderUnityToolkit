namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpawnerGuardSettings (9 fields) 4B9E0F5AF2B720F0B15862810F3DD894/FECFD782079D3B2CF3C424D8EE5CB973 */
public record class SpawnerGuardSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float Range /* NeedsAlign */,
    int CoercionBonus /* None */,
    PPtr<ScriptZone> ExtendedVisionArea /* None */,
    byte UseLosInsteadOfVisibility /* None */,
    ActionsReference OnDetect /* NeedsAlign */)
{
    public static SpawnerGuardSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Range */
        float _Range = reader.ReadF32();
        int _CoercionBonus = reader.ReadS32();
        PPtr<ScriptZone> _ExtendedVisionArea = PPtr<ScriptZone>.Read(reader);
        byte _UseLosInsteadOfVisibility = reader.ReadU8();
        reader.AlignTo(4); /* OnDetect */
        ActionsReference _OnDetect = ActionsReference.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Range,
            _CoercionBonus,
            _ExtendedVisionArea,
            _UseLosInsteadOfVisibility,
            _OnDetect);
    }
}

