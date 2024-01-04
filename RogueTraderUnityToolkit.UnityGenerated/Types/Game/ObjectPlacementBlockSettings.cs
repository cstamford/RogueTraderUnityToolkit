namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectPlacementBlockSettings (7 fields) C4AFC5989110794BFA59C225FB643496/BCEEC6B80BCA5A1019AE8E5F6FD155F7 */
public record class ObjectPlacementBlockSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ObjectPlacementBlockManualConstructionSettings> _manualConstructionSettings /* NeedsAlign */,
    ObjectPlacementBlockProjectionSettings _blockProjectionSettings /* None */,
    ObjectPlacementBlockSettingsView _view /* NeedsAlign */)
{
    public static ObjectPlacementBlockSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _manualConstructionSettings */
        PPtr<ObjectPlacementBlockManualConstructionSettings> __manualConstructionSettings = PPtr<ObjectPlacementBlockManualConstructionSettings>.Read(reader);
        ObjectPlacementBlockProjectionSettings __blockProjectionSettings = ObjectPlacementBlockProjectionSettings.Read(reader);
        reader.AlignTo(4); /* _view */
        ObjectPlacementBlockSettingsView __view = ObjectPlacementBlockSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __manualConstructionSettings,
            __blockProjectionSettings,
            __view);
    }
}

