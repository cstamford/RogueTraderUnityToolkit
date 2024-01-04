namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpawnerCustomization (14 fields) D66D5C29CB397B1BBE0D10DF382D6DD2/2C14137A36CEBA50C2FC1C6EB27B6A32 */
public record class SpawnerCustomization(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    UnitCustomizationPresetReference m_Preset /* NeedsAlign */,
    BlueprintUnitReference m_Blueprint /* NeedsAlign */,
    UnitViewLink SelectedPrefab /* NeedsAlign */,
    BlueprintRaceReference m_SelectedRace /* NeedsAlign */,
    int SelectedGender /* NeedsAlign */,
    BlueprintUnitAsksListReference m_SelectedVoice /* None */,
    byte LeftHanded /* NeedsAlign */,
    BlueprintRaceReference m_RaceRequirement /* NeedsAlign */,
    byte HasGenderRequirement /* NeedsAlign */,
    int GenderRequirement /* NeedsAlign */)
{
    public static SpawnerCustomization Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Preset */
        UnitCustomizationPresetReference _m_Preset = UnitCustomizationPresetReference.Read(reader);
        reader.AlignTo(4); /* m_Blueprint */
        BlueprintUnitReference _m_Blueprint = BlueprintUnitReference.Read(reader);
        reader.AlignTo(4); /* SelectedPrefab */
        UnitViewLink _SelectedPrefab = UnitViewLink.Read(reader);
        reader.AlignTo(4); /* m_SelectedRace */
        BlueprintRaceReference _m_SelectedRace = BlueprintRaceReference.Read(reader);
        reader.AlignTo(4); /* SelectedGender */
        int _SelectedGender = reader.ReadS32();
        BlueprintUnitAsksListReference _m_SelectedVoice = BlueprintUnitAsksListReference.Read(reader);
        reader.AlignTo(4); /* LeftHanded */
        byte _LeftHanded = reader.ReadU8();
        reader.AlignTo(4); /* m_RaceRequirement */
        BlueprintRaceReference _m_RaceRequirement = BlueprintRaceReference.Read(reader);
        reader.AlignTo(4); /* HasGenderRequirement */
        byte _HasGenderRequirement = reader.ReadU8();
        reader.AlignTo(4); /* GenderRequirement */
        int _GenderRequirement = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Preset,
            _m_Blueprint,
            _SelectedPrefab,
            _m_SelectedRace,
            _SelectedGender,
            _m_SelectedVoice,
            _LeftHanded,
            _m_RaceRequirement,
            _HasGenderRequirement,
            _GenderRequirement);
    }
}

