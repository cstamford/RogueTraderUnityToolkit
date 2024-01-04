namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AnomalyView (12 fields) 6BD70F3DA8E0F3753529A2547C278E6F/39C9C91D5E88C12B01CF0F136F1A7A9F */
public record class AnomalyView(
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
    PPtr<GameObject> BaseVisualRoot /* None */,
    PPtr<StarSystemObjectView> BlockedObject /* None */)
{
    public static AnomalyView Read(EndianBinaryReader reader)
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
        PPtr<StarSystemObjectView> _BlockedObject = PPtr<StarSystemObjectView>.Read(reader);
        
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
            _BaseVisualRoot,
            _BlockedObject);
    }
}

