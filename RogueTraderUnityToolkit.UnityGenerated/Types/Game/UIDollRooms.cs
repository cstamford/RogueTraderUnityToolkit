namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UIDollRooms (9 fields) 3ED753B67DDE4A6605027840FC32824B/CDA2DDAEB5F4471FC5A860F19CD8E09A */
public record class UIDollRooms(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CharacterDollRoom> CharacterDollRoom /* NeedsAlign */,
    PPtr<CharGenDollRoom> CharGenDollRoom /* None */,
    PPtr<ShipDollRoom> ShipDollRoom /* None */,
    PPtr<CharGenShipDollRoom> CharGenShipDollRoom /* None */,
    PPtr<PlanetDollRoom> PlanetDollRoom /* None */)
{
    public static UIDollRooms Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* CharacterDollRoom */
        PPtr<CharacterDollRoom> _CharacterDollRoom = PPtr<CharacterDollRoom>.Read(reader);
        PPtr<CharGenDollRoom> _CharGenDollRoom = PPtr<CharGenDollRoom>.Read(reader);
        PPtr<ShipDollRoom> _ShipDollRoom = PPtr<ShipDollRoom>.Read(reader);
        PPtr<CharGenShipDollRoom> _CharGenShipDollRoom = PPtr<CharGenShipDollRoom>.Read(reader);
        PPtr<PlanetDollRoom> _PlanetDollRoom = PPtr<PlanetDollRoom>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _CharacterDollRoom,
            _CharGenDollRoom,
            _ShipDollRoom,
            _CharGenShipDollRoom,
            _PlanetDollRoom);
    }
}

