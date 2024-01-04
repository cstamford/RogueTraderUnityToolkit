namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $StarshipUnitMark (9 fields) BB6EBC3FC9BEB704B961592BC559CE61/5E9249FFA408E2B752C428834E4CE154 */
public record class StarshipUnitMark(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    DecalColorSet m_ColorSet /* NeedsAlign */,
    PPtr<GameObject> m_NormalDecal /* None */,
    PPtr<Transform> m_Container /* None */,
    PPtr<ShipDecalData>[] m_Decals /* None */,
    PPtr<ShipDecalConfig> m_ShipDecalConfig /* None */)
{
    public static StarshipUnitMark Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ColorSet */
        DecalColorSet _m_ColorSet = DecalColorSet.Read(reader);
        PPtr<GameObject> _m_NormalDecal = PPtr<GameObject>.Read(reader);
        PPtr<Transform> _m_Container = PPtr<Transform>.Read(reader);
        PPtr<ShipDecalData>[] _m_Decals = BuiltInArray<PPtr<ShipDecalData>>.Read(reader);
        PPtr<ShipDecalConfig> _m_ShipDecalConfig = PPtr<ShipDecalConfig>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ColorSet,
            _m_NormalDecal,
            _m_Container,
            _m_Decals,
            _m_ShipDecalConfig);
    }
}

