namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectPlacementBlockManualConstructionRenderSettings (7 fields) 911F57153BEBEA152136623D34AE28A6/41D346EA165DC9333414F643AB8AEB7C */
public record class ObjectPlacementBlockManualConstructionRenderSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    ColorRGBA _boxBorderLineColor /* NeedsAlign */,
    PPtr<LabelRenderSettings> _dimensionsLabelRenderSettings /* None */,
    ObjectPlacementBlockManualConstructionRenderSettingsView _view /* None */)
{
    public static ObjectPlacementBlockManualConstructionRenderSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _boxBorderLineColor */
        ColorRGBA __boxBorderLineColor = ColorRGBA.Read(reader);
        PPtr<LabelRenderSettings> __dimensionsLabelRenderSettings = PPtr<LabelRenderSettings>.Read(reader);
        ObjectPlacementBlockManualConstructionRenderSettingsView __view = ObjectPlacementBlockManualConstructionRenderSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __boxBorderLineColor,
            __dimensionsLabelRenderSettings,
            __view);
    }
}

