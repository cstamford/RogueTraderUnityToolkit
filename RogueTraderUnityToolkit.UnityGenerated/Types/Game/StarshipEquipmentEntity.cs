namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $StarshipEquipmentEntity (5 fields) 2036D775232ACD20789487F02B9036EB/DED17B559D841FCEBED727CBE56C5A4F */
public record class StarshipEquipmentEntity(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    StarshipSlotDescription[] EEArtSlotsDescription /* NeedsAlign */)
{
    public static StarshipEquipmentEntity Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* EEArtSlotsDescription */
        StarshipSlotDescription[] _EEArtSlotsDescription = BuiltInArray<StarshipSlotDescription>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _EEArtSlotsDescription);
    }
}

