namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DetailsData (6 fields) 5EF137D5FE5DEC02E415E436EF77B5DE/D64513C68EB025F939CB706C30A08F75 */
public record class DetailsData(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float InstancePerMeter /* NeedsAlign */,
    DetailInstanceData[] Instances /* None */)
{
    public static DetailsData Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* InstancePerMeter */
        float _InstancePerMeter = reader.ReadF32();
        DetailInstanceData[] _Instances = BuiltInArray<DetailInstanceData>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _InstancePerMeter,
            _Instances);
    }
}

