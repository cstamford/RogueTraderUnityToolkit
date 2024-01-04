namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $WeaponsListDism (7 fields) 8AB26CCC0CB42B578F35C753BA2B3F92/55DEF8A7D79D6745336AB80604EA8DD1 */
public record class WeaponsListDism(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte ForceRagdoll /* NeedsAlign */,
    byte ForceDismemberment /* NeedsAlign */,
    PrefabInPair[] WeaponsChancesArray /* NeedsAlign */)
{
    public static WeaponsListDism Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* ForceRagdoll */
        byte _ForceRagdoll = reader.ReadU8();
        reader.AlignTo(4); /* ForceDismemberment */
        byte _ForceDismemberment = reader.ReadU8();
        reader.AlignTo(4); /* WeaponsChancesArray */
        PrefabInPair[] _WeaponsChancesArray = BuiltInArray<PrefabInPair>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _ForceRagdoll,
            _ForceDismemberment,
            _WeaponsChancesArray);
    }
}

