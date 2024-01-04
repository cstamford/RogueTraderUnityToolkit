namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipDecalData (7 fields) 9CC97311916574E33010193D5CE7AC27/7B232BFCF8CB5D6C92B7B7F8D726EB9E */
public record class ShipDecalData(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ShipShieldsUnitMarkPart>[] ShipShields /* NeedsAlign */,
    ShipDecalMeshData[] ShipDecals /* None */,
    int Size /* NeedsAlign */)
{
    public static ShipDecalData Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* ShipShields */
        PPtr<ShipShieldsUnitMarkPart>[] _ShipShields = BuiltInArray<PPtr<ShipShieldsUnitMarkPart>>.Read(reader);
        ShipDecalMeshData[] _ShipDecals = BuiltInArray<ShipDecalMeshData>.Read(reader);
        reader.AlignTo(4); /* Size */
        int _Size = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _ShipShields,
            _ShipDecals,
            _Size);
    }
}

