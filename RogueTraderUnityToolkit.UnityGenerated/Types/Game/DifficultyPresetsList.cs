namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DifficultyPresetsList (8 fields) 70507202BC0F7144EBBA97FC451E1F87/D4400DD976DE50C2BA00EB2ADF80C87A */
public record class DifficultyPresetsList(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<DifficultyPresetAsset>[] m_Difficulties /* NeedsAlign */,
    PPtr<DifficultyPresetAsset> m_CoreDifficulty /* None */,
    PPtr<DifficultyPresetAsset> m_HardDifficulty /* None */,
    PPtr<DifficultyPresetAsset> m_UnfairDifficulty /* None */)
{
    public static DifficultyPresetsList Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Difficulties */
        PPtr<DifficultyPresetAsset>[] _m_Difficulties = BuiltInArray<PPtr<DifficultyPresetAsset>>.Read(reader);
        PPtr<DifficultyPresetAsset> _m_CoreDifficulty = PPtr<DifficultyPresetAsset>.Read(reader);
        PPtr<DifficultyPresetAsset> _m_HardDifficulty = PPtr<DifficultyPresetAsset>.Read(reader);
        PPtr<DifficultyPresetAsset> _m_UnfairDifficulty = PPtr<DifficultyPresetAsset>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Difficulties,
            _m_CoreDifficulty,
            _m_HardDifficulty,
            _m_UnfairDifficulty);
    }
}

