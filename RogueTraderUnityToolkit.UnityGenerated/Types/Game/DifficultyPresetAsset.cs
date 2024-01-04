namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DifficultyPresetAsset (9 fields) 400CBDADF56F994BBD5D79E996BFD24A/2897929F855A2B36CE146A39F8A8D33E */
public record class DifficultyPresetAsset(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte IsCustomMode /* NeedsAlign */,
    DifficultyPreset Preset /* NeedsAlign */,
    PPtr<Sprite> Icon /* NeedsAlign */,
    LocalizedString LocalizedName /* None */,
    LocalizedString LocalizedDescription /* NeedsAlign */)
{
    public static DifficultyPresetAsset Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* IsCustomMode */
        byte _IsCustomMode = reader.ReadU8();
        reader.AlignTo(4); /* Preset */
        DifficultyPreset _Preset = DifficultyPreset.Read(reader);
        reader.AlignTo(4); /* Icon */
        PPtr<Sprite> _Icon = PPtr<Sprite>.Read(reader);
        LocalizedString _LocalizedName = LocalizedString.Read(reader);
        reader.AlignTo(4); /* LocalizedDescription */
        LocalizedString _LocalizedDescription = LocalizedString.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _IsCustomMode,
            _Preset,
            _Icon,
            _LocalizedName,
            _LocalizedDescription);
    }
}

