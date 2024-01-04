namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $XZOrientedEllipseShapeRenderSettings (6 fields) AC49B15C5061EE7B416768564CED4A52/D8D9B53B75ACEF8332047C95AB2CE4B7 */
public record class XZOrientedEllipseShapeRenderSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    ColorRGBA _borderLineColor /* NeedsAlign */,
    XZOrientedEllipseShapeRenderSettingsView _view /* None */)
{
    public static XZOrientedEllipseShapeRenderSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _borderLineColor */
        ColorRGBA __borderLineColor = ColorRGBA.Read(reader);
        XZOrientedEllipseShapeRenderSettingsView __view = XZOrientedEllipseShapeRenderSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __borderLineColor,
            __view);
    }
}

