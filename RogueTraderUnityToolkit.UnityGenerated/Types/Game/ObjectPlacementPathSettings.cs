namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectPlacementPathSettings (7 fields) 6818FAFFF1CC80BC1A4B1D36C8C51E68/0ECB9DA89FC21259FC04A6917D08B9A1 */
public record class ObjectPlacementPathSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ObjectPlacementPathManualConstructionSettings> _manualConstructionSettings /* NeedsAlign */,
    PPtr<ObjectPlacementPathTileConnectionSettings> _tileConnectionSettings /* None */,
    ObjectPlacementPathSettingsView _view /* None */)
{
    public static ObjectPlacementPathSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _manualConstructionSettings */
        PPtr<ObjectPlacementPathManualConstructionSettings> __manualConstructionSettings = PPtr<ObjectPlacementPathManualConstructionSettings>.Read(reader);
        PPtr<ObjectPlacementPathTileConnectionSettings> __tileConnectionSettings = PPtr<ObjectPlacementPathTileConnectionSettings>.Read(reader);
        ObjectPlacementPathSettingsView __view = ObjectPlacementPathSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __manualConstructionSettings,
            __tileConnectionSettings,
            __view);
    }
}

