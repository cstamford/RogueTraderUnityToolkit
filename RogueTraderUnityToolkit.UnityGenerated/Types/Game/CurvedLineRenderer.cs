namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CurvedLineRenderer (10 fields) 430F603C3F63D718EACD2DBC4D234682/6C89729F8C7C8C41FF18599328DEAFFC */
public record class CurvedLineRenderer(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float lineSegmentSize /* NeedsAlign */,
    float lineWidth /* None */,
    byte closePoints /* None */,
    byte showGizmos /* NeedsAlign */,
    float gizmoSize /* NeedsAlign */,
    ColorRGBA gizmoColor /* None */)
{
    public static CurvedLineRenderer Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* lineSegmentSize */
        float _lineSegmentSize = reader.ReadF32();
        float _lineWidth = reader.ReadF32();
        byte _closePoints = reader.ReadU8();
        reader.AlignTo(4); /* showGizmos */
        byte _showGizmos = reader.ReadU8();
        reader.AlignTo(4); /* gizmoSize */
        float _gizmoSize = reader.ReadF32();
        ColorRGBA _gizmoColor = ColorRGBA.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _lineSegmentSize,
            _lineWidth,
            _closePoints,
            _showGizmos,
            _gizmoSize,
            _gizmoColor);
    }
}

