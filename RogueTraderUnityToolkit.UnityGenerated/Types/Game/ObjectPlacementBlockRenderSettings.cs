namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectPlacementBlockRenderSettings (6 fields) 4648795E3F534053681904F22D0E44D4/D6AD7A004331A1CE4B44673620EABD26 */
public record class ObjectPlacementBlockRenderSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ObjectPlacementBlockManualConstructionRenderSettings> _manualConstructionRenderSettings /* NeedsAlign */,
    ObjectPlacementBlockRenderSettingsView _view /* None */)
{
    public static ObjectPlacementBlockRenderSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _manualConstructionRenderSettings */
        PPtr<ObjectPlacementBlockManualConstructionRenderSettings> __manualConstructionRenderSettings = PPtr<ObjectPlacementBlockManualConstructionRenderSettings>.Read(reader);
        ObjectPlacementBlockRenderSettingsView __view = ObjectPlacementBlockRenderSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __manualConstructionRenderSettings,
            __view);
    }
}

