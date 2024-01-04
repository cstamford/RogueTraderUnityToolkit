namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ItemsFilterStrings (6 fields) 050D6E5BFA3100DF8FBBADB226614546/B28C143B781E3DDE8D1EF7EC3CEC9329 */
public record class ItemsFilterStrings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    SorterTypeEntry[] SorterTypeEntries /* NeedsAlign */,
    FilterTypeEntry[] FilterTypentries /* NeedsAlign */)
{
    public static ItemsFilterStrings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* SorterTypeEntries */
        SorterTypeEntry[] _SorterTypeEntries = BuiltInArray<SorterTypeEntry>.Read(reader);
        reader.AlignTo(4); /* FilterTypentries */
        FilterTypeEntry[] _FilterTypentries = BuiltInArray<FilterTypeEntry>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _SorterTypeEntries,
            _FilterTypentries);
    }
}

