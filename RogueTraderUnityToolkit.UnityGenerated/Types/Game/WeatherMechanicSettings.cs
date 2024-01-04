namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $WeatherMechanicSettings (11 fields) 7D5BCB6F6452774FB37B631D26E4206E/AB132A6668EF6531A70C7722B6F824EF */
public record class WeatherMechanicSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    double CastAbilityEvery /* NeedsAlign */,
    int m_InclemencyType /* None */,
    int m_WeatherEffectsDifficulty /* None */,
    int m_Target /* None */,
    BlueprintUnitReference m_BlueprintActor /* None */,
    BlueprintAbilityReference m_BlueprintAbility /* NeedsAlign */,
    BlueprintBuffReference m_BlueprintBuff /* NeedsAlign */)
{
    public static WeatherMechanicSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* CastAbilityEvery */
        double _CastAbilityEvery = reader.ReadF64();
        int _m_InclemencyType = reader.ReadS32();
        int _m_WeatherEffectsDifficulty = reader.ReadS32();
        int _m_Target = reader.ReadS32();
        BlueprintUnitReference _m_BlueprintActor = BlueprintUnitReference.Read(reader);
        reader.AlignTo(4); /* m_BlueprintAbility */
        BlueprintAbilityReference _m_BlueprintAbility = BlueprintAbilityReference.Read(reader);
        reader.AlignTo(4); /* m_BlueprintBuff */
        BlueprintBuffReference _m_BlueprintBuff = BlueprintBuffReference.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _CastAbilityEvery,
            _m_InclemencyType,
            _m_WeatherEffectsDifficulty,
            _m_Target,
            _m_BlueprintActor,
            _m_BlueprintAbility,
            _m_BlueprintBuff);
    }
}

