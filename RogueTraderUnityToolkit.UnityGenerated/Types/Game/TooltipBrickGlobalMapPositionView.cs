namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickGlobalMapPositionView (7 fields) FF555561794EDE48BBDCB0956448E82A/F7F9DF261CA82D27BF0955B278F6B120 */
public record class TooltipBrickGlobalMapPositionView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Transform>[] m_SystemPoints /* NeedsAlign */,
    PPtr<Transform> m_PositionSystemMarker /* None */,
    PPtr<Transform> m_PositionShipMarker /* None */)
{
    public static TooltipBrickGlobalMapPositionView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SystemPoints */
        PPtr<Transform>[] _m_SystemPoints = BuiltInArray<PPtr<Transform>>.Read(reader);
        PPtr<Transform> _m_PositionSystemMarker = PPtr<Transform>.Read(reader);
        PPtr<Transform> _m_PositionShipMarker = PPtr<Transform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SystemPoints,
            _m_PositionSystemMarker,
            _m_PositionShipMarker);
    }
}

