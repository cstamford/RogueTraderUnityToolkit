namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $StarshipItemSlot (6 fields) C0A8DA77FAFECEE78E140453D74EF3F4/1A65FEE686347487464B8578E2A46991 */
public record class StarshipItemSlot(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int Type /* NeedsAlign */,
    PPtr<GameObject> itemPrefab /* None */)
{
    public static StarshipItemSlot Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Type */
        int _Type = reader.ReadS32();
        PPtr<GameObject> _itemPrefab = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Type,
            _itemPrefab);
    }
}

