namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipShieldsUnitMarkPart (9 fields) 1D6F87DADBE0FE4228BEC3AF46A1FBE2/084867BCE1C5D8F07188EEED895C0C6E */
public record class ShipShieldsUnitMarkPart(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_IsDirect /* NeedsAlign */,
    ShieldsDecalMaterialSet[] m_ShieldMaterialSets /* NeedsAlign */,
    PPtr<MeshRenderer>[] m_ShieldsDecals /* None */,
    PPtr<MeshRenderer>[] m_ShieldReinforcementDecals /* None */,
    PPtr<TextMeshPro>[] m_ShieldValueTexts /* None */)
{
    public static ShipShieldsUnitMarkPart Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_IsDirect */
        byte _m_IsDirect = reader.ReadU8();
        reader.AlignTo(4); /* m_ShieldMaterialSets */
        ShieldsDecalMaterialSet[] _m_ShieldMaterialSets = BuiltInArray<ShieldsDecalMaterialSet>.Read(reader);
        PPtr<MeshRenderer>[] _m_ShieldsDecals = BuiltInArray<PPtr<MeshRenderer>>.Read(reader);
        PPtr<MeshRenderer>[] _m_ShieldReinforcementDecals = BuiltInArray<PPtr<MeshRenderer>>.Read(reader);
        PPtr<TextMeshPro>[] _m_ShieldValueTexts = BuiltInArray<PPtr<TextMeshPro>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_IsDirect,
            _m_ShieldMaterialSets,
            _m_ShieldsDecals,
            _m_ShieldReinforcementDecals,
            _m_ShieldValueTexts);
    }
}

