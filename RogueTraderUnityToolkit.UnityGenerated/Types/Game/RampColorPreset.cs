namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $RampColorPreset (7 fields) F54E438617BD28300CC4DF1BE0C2EF23/79D0BCC876DF6EBDA83541A028ED71D6 */
public record class RampColorPreset(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    IndexSet[] IndexPairs /* NeedsAlign */,
    int PrimaryIndex /* NeedsAlign */,
    int SecondaryIndex /* None */)
{
    public static RampColorPreset Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* IndexPairs */
        IndexSet[] _IndexPairs = BuiltInArray<IndexSet>.Read(reader);
        reader.AlignTo(4); /* PrimaryIndex */
        int _PrimaryIndex = reader.ReadS32();
        int _SecondaryIndex = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _IndexPairs,
            _PrimaryIndex,
            _SecondaryIndex);
    }
}

