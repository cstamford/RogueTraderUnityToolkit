namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $RectangleShapeRenderSettings (7 fields) ECFE00C1D4D97FD2DA28838C823DC59C/1CA2C207BD3081ED48860F8B4DA72F60 */
public record class RectangleShapeRenderSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    ColorRGBA _borderLineColor /* NeedsAlign */,
    ColorRGBA _fillColor /* None */,
    RectangleShapeRenderSettingsView _view /* None */)
{
    public static RectangleShapeRenderSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _borderLineColor */
        ColorRGBA __borderLineColor = ColorRGBA.Read(reader);
        ColorRGBA __fillColor = ColorRGBA.Read(reader);
        RectangleShapeRenderSettingsView __view = RectangleShapeRenderSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __borderLineColor,
            __fillColor,
            __view);
    }
}

