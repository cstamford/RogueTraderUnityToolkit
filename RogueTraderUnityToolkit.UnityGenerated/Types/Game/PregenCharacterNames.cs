namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PregenCharacterNames (7 fields) 47A87346CFEB31D18DD4D5025E400E5B/D8FE2F5F1E8453A9B58E1987F87E4D00 */
public record class PregenCharacterNames(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PregenCharacterNameList[] m_CharacterNames /* NeedsAlign */,
    LocalizedString m_PetNames /* NeedsAlign */,
    LocalizedString m_ShipNames /* NeedsAlign */)
{
    public static PregenCharacterNames Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CharacterNames */
        PregenCharacterNameList[] _m_CharacterNames = BuiltInArray<PregenCharacterNameList>.Read(reader);
        reader.AlignTo(4); /* m_PetNames */
        LocalizedString _m_PetNames = LocalizedString.Read(reader);
        reader.AlignTo(4); /* m_ShipNames */
        LocalizedString _m_ShipNames = LocalizedString.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CharacterNames,
            _m_PetNames,
            _m_ShipNames);
    }
}

