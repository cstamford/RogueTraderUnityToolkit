namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $StatsStrings (9 fields) 297E3F18F7E7C44A8908A36F2A99889A/8E1C615C396EEE01B141269F35340AAB */
public record class StatsStrings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    Entry Entries /* NeedsAlign */,
    WeaponCategoryEntry[] WeaponCategoryEntries /* NeedsAlign */,
    WeaponFamilyEntry[] WeaponFamilyEntries /* NeedsAlign */,
    ArmorEntry[] ArmorEntries /* NeedsAlign */,
    ArmorCategoryEntry[] ArmorCategoryEntriesEntries /* NeedsAlign */)
{
    public static StatsStrings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Entries */
        Entry _Entries = Entry.Read(reader);
        reader.AlignTo(4); /* WeaponCategoryEntries */
        WeaponCategoryEntry[] _WeaponCategoryEntries = BuiltInArray<WeaponCategoryEntry>.Read(reader);
        reader.AlignTo(4); /* WeaponFamilyEntries */
        WeaponFamilyEntry[] _WeaponFamilyEntries = BuiltInArray<WeaponFamilyEntry>.Read(reader);
        reader.AlignTo(4); /* ArmorEntries */
        ArmorEntry[] _ArmorEntries = BuiltInArray<ArmorEntry>.Read(reader);
        reader.AlignTo(4); /* ArmorCategoryEntriesEntries */
        ArmorCategoryEntry[] _ArmorCategoryEntriesEntries = BuiltInArray<ArmorCategoryEntry>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Entries,
            _WeaponCategoryEntries,
            _WeaponFamilyEntries,
            _ArmorEntries,
            _ArmorCategoryEntriesEntries);
    }
}

