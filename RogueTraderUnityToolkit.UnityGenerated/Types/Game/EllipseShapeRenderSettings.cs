namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $EllipseShapeRenderSettings (7 fields) 4EDDBB66BE13ED03999BB9BF09CA8B15/B4FC7F2CDE92337DF9DE8AAC38F3CDDF */
public record class EllipseShapeRenderSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    ColorRGBA _borderLineColor /* NeedsAlign */,
    ColorRGBA _fillColor /* None */,
    EllipseShapeRenderSettingsView _view /* None */)
{
    public static EllipseShapeRenderSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _borderLineColor */
        ColorRGBA __borderLineColor = ColorRGBA.Read(reader);
        ColorRGBA __fillColor = ColorRGBA.Read(reader);
        EllipseShapeRenderSettingsView __view = EllipseShapeRenderSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __borderLineColor,
            __fillColor,
            __view);
    }
}

