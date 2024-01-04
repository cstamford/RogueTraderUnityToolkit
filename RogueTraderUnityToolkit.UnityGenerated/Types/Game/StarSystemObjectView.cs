namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $StarSystemObjectView (11 fields) 792CBC245F9797D04463C97EEEA8F730/84EDE3433456F7ACAEB42DEE23F62C8F */
public record class StarSystemObjectView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_IsInGame /* NeedsAlign */,
    AsciiString UniqueId /* NeedsAlign */,
    PPtr<Renderer>[] m_HideRenderers /* NeedsAlign */,
    byte AreaHighlighted /* None */,
    BlueprintStarSystemObjectReference Blueprint /* NeedsAlign */,
    int ObjectSize /* NeedsAlign */,
    PPtr<GameObject> BaseVisualRoot /* None */)
{
    public static StarSystemObjectView Read(EndianBinaryReader reader)
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
        reader.AlignTo(4); /* Blueprint */
        BlueprintStarSystemObjectReference _Blueprint = BlueprintStarSystemObjectReference.Read(reader);
        reader.AlignTo(4); /* ObjectSize */
        int _ObjectSize = reader.ReadS32();
        PPtr<GameObject> _BaseVisualRoot = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_IsInGame,
            _UniqueId,
            _m_HideRenderers,
            _AreaHighlighted,
            _Blueprint,
            _ObjectSize,
            _BaseVisualRoot);
    }
}

