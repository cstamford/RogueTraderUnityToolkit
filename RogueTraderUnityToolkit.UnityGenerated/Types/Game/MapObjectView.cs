namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $MapObjectView (8 fields) 1FE6FE948DE4A36A906D3AC42A2FBAB2/4BDDE3B4AFEFE1E9597F67EDD3C0DB5A */
public record class MapObjectView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_IsInGame /* NeedsAlign */,
    AsciiString UniqueId /* NeedsAlign */,
    PPtr<Renderer>[] m_HideRenderers /* NeedsAlign */,
    byte AreaHighlighted /* None */)
{
    public static MapObjectView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_IsInGame */
        byte _m_IsInGame = reader.ReadU8();
        reader.AlignTo(4); /* UniqueId */
        AsciiString _UniqueId = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HideRenderers */
        PPtr<Renderer>[] _m_HideRenderers = BuiltInArray<PPtr<Renderer>>.Read(reader);
        byte _AreaHighlighted = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_IsInGame,
            _UniqueId,
            _m_HideRenderers,
            _AreaHighlighted);
    }
}

