namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $XZGridRenderSettings (9 fields) 38FBDEEDC248E6F6802F8388887D543B/2488BB8FC9A83C7CAECF3139C6C32316 */
public record class XZGridRenderSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte _isVisible /* NeedsAlign */,
    ColorRGBA _cellLineColor /* NeedsAlign */,
    float _cellLineThickness /* None */,
    ColorRGBA _planeColor /* None */,
    XZGridRenderSettingsView _view /* None */)
{
    public static XZGridRenderSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _isVisible */
        byte __isVisible = reader.ReadU8();
        reader.AlignTo(4); /* _cellLineColor */
        ColorRGBA __cellLineColor = ColorRGBA.Read(reader);
        float __cellLineThickness = reader.ReadF32();
        ColorRGBA __planeColor = ColorRGBA.Read(reader);
        XZGridRenderSettingsView __view = XZGridRenderSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __isVisible,
            __cellLineColor,
            __cellLineThickness,
            __planeColor,
            __view);
    }
}

