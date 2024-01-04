namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SingleObjectPivotPointRenderSettings (9 fields) CFF9D93866E383F995873DD080223B7A/57071E913C8882A5CC9CC82C4024941E */
public record class SingleObjectPivotPointRenderSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte _isVisible /* NeedsAlign */,
    ColorRGBA _fillColor /* NeedsAlign */,
    ColorRGBA _borderLineColor /* None */,
    float _scale /* None */,
    SingleObjectPivotPointRenderSettingsView _view /* None */)
{
    public static SingleObjectPivotPointRenderSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _isVisible */
        byte __isVisible = reader.ReadU8();
        reader.AlignTo(4); /* _fillColor */
        ColorRGBA __fillColor = ColorRGBA.Read(reader);
        ColorRGBA __borderLineColor = ColorRGBA.Read(reader);
        float __scale = reader.ReadF32();
        SingleObjectPivotPointRenderSettingsView __view = SingleObjectPivotPointRenderSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __isVisible,
            __fillColor,
            __borderLineColor,
            __scale,
            __view);
    }
}

