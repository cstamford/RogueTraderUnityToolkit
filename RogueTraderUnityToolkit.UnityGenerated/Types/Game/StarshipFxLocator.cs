namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $StarshipFxLocator (10 fields) D52B2B8A5D4A2B3E97CD0DBA1798DD81/D0388740C296EBD5F0EF15819B16440E */
public record class StarshipFxLocator(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    Reference m_Group /* NeedsAlign */,
    PPtr<SnapMapBase> particleMap /* NeedsAlign */,
    FxBone Data /* None */,
    PPtr<CharacterFxBonesMap> bonesMap /* NeedsAlign */,
    int weaponSlotType /* None */,
    int starshipWeaponType /* None */)
{
    public static StarshipFxLocator Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Group */
        Reference _m_Group = Reference.Read(reader);
        reader.AlignTo(4); /* particleMap */
        PPtr<SnapMapBase> _particleMap = PPtr<SnapMapBase>.Read(reader);
        FxBone _Data = FxBone.Read(reader);
        reader.AlignTo(4); /* bonesMap */
        PPtr<CharacterFxBonesMap> _bonesMap = PPtr<CharacterFxBonesMap>.Read(reader);
        int _weaponSlotType = reader.ReadS32();
        int _starshipWeaponType = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Group,
            _particleMap,
            _Data,
            _bonesMap,
            _weaponSlotType,
            _starshipWeaponType);
    }
}

