namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharacterAtlasData (6 fields) E5CB21C1A30AAA16267DB73B5CEBC053/0B5BC1AD9ADC587FD8EEECA2C5A47AAD */
public record class CharacterAtlasData(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int targetResolution /* NeedsAlign */,
    BodyPartCoords[] BodyPartsCoords /* None */)
{
    public static CharacterAtlasData Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* targetResolution */
        int _targetResolution = reader.ReadS32();
        BodyPartCoords[] _BodyPartsCoords = BuiltInArray<BodyPartCoords>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _targetResolution,
            _BodyPartsCoords);
    }
}

