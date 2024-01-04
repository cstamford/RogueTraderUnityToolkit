namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UnitTerrainAlignment (6 fields) F328012DADEFDC845BAE230D37FB5B17/3DD38F994630B346D8A4EBAEFE712B49 */
public record class UnitTerrainAlignment(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float SampleRadious /* NeedsAlign */,
    float maxTilt /* None */)
{
    public static UnitTerrainAlignment Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* SampleRadious */
        float _SampleRadious = reader.ReadF32();
        float _maxTilt = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _SampleRadious,
            _maxTilt);
    }
}

