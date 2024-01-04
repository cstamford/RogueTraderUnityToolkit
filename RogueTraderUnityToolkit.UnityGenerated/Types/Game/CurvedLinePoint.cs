namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CurvedLinePoint (7 fields) EFA7A1F4A4C749347034CF505BE3D874/B89DCCA522396B81554971D350C9311B */
public record class CurvedLinePoint(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte showGizmo /* NeedsAlign */,
    float gizmoSize /* NeedsAlign */,
    ColorRGBA gizmoColor /* None */)
{
    public static CurvedLinePoint Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* showGizmo */
        byte _showGizmo = reader.ReadU8();
        reader.AlignTo(4); /* gizmoSize */
        float _gizmoSize = reader.ReadF32();
        ColorRGBA _gizmoColor = ColorRGBA.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _showGizmo,
            _gizmoSize,
            _gizmoColor);
    }
}

