namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CoordinateSystemAxisRenderSettings (10 fields) FE9813E7509D1C4A43A02BCC62666FFA/B900DDDEFE4AAF46F635BB7303311FF1 */
public record class CoordinateSystemAxisRenderSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int _axis /* NeedsAlign */,
    byte _isVisible /* None */,
    ColorRGBA _color /* NeedsAlign */,
    byte _isInfinite /* None */,
    float _finiteSize /* NeedsAlign */,
    CoordinateSystemAxisRenderSettingsView _view /* None */)
{
    public static CoordinateSystemAxisRenderSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _axis */
        int __axis = reader.ReadS32();
        byte __isVisible = reader.ReadU8();
        reader.AlignTo(4); /* _color */
        ColorRGBA __color = ColorRGBA.Read(reader);
        byte __isInfinite = reader.ReadU8();
        reader.AlignTo(4); /* _finiteSize */
        float __finiteSize = reader.ReadF32();
        CoordinateSystemAxisRenderSettingsView __view = CoordinateSystemAxisRenderSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __axis,
            __isVisible,
            __color,
            __isInfinite,
            __finiteSize,
            __view);
    }
}

