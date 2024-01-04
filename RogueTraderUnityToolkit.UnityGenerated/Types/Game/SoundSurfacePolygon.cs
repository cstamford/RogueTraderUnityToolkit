namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SoundSurfacePolygon (10 fields) 13D8E6F47799AA1CA1DCC75142BCC9F8/C73F16A5A86A6E49739428D8B27AC269 */
public record class SoundSurfacePolygon(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    Vector3f[] m_Points /* NeedsAlign */,
    ColorRGBA m_GizmoColor /* NeedsAlign */,
    byte m_Closed /* None */,
    float PointYShift /* NeedsAlign */,
    AsciiString SwitchString /* None */,
    int Switch /* NeedsAlign */)
{
    public static SoundSurfacePolygon Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Points */
        Vector3f[] _m_Points = BuiltInArray<Vector3f>.Read(reader);
        reader.AlignTo(4); /* m_GizmoColor */
        ColorRGBA _m_GizmoColor = ColorRGBA.Read(reader);
        byte _m_Closed = reader.ReadU8();
        reader.AlignTo(4); /* PointYShift */
        float _PointYShift = reader.ReadF32();
        AsciiString _SwitchString = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Switch */
        int _Switch = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Points,
            _m_GizmoColor,
            _m_Closed,
            _PointYShift,
            _SwitchString,
            _Switch);
    }
}

