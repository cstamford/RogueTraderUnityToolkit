namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectPlacementPathTileConnectionSettings (13 fields) E7844233E3A8C2A7FC4F85B49668C7C8/EC727BEDA323923DDEEF1B64D9E311BC */
public record class ObjectPlacementPathTileConnectionSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte _useTileConnections /* NeedsAlign */,
    int _commonYAxisRotation /* NeedsAlign */,
    float _commonYOffset /* None */,
    int _commonUpwardsExtrusionAmount /* None */,
    int _commonDownwardsExtrusionAmount /* None */,
    int _prefabInheritTileConnectionType /* None */,
    PPtr<ObjectPlacementPathTileConnectionTypeSettings>[] _tileConnectionTypeSettings /* None */,
    byte _wasInitialized /* None */,
    ObjectPlacementPathTileConnectionSettingsView _view /* NeedsAlign */)
{
    public static ObjectPlacementPathTileConnectionSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _useTileConnections */
        byte __useTileConnections = reader.ReadU8();
        reader.AlignTo(4); /* _commonYAxisRotation */
        int __commonYAxisRotation = reader.ReadS32();
        float __commonYOffset = reader.ReadF32();
        int __commonUpwardsExtrusionAmount = reader.ReadS32();
        int __commonDownwardsExtrusionAmount = reader.ReadS32();
        int __prefabInheritTileConnectionType = reader.ReadS32();
        PPtr<ObjectPlacementPathTileConnectionTypeSettings>[] __tileConnectionTypeSettings = BuiltInArray<PPtr<ObjectPlacementPathTileConnectionTypeSettings>>.Read(reader);
        byte __wasInitialized = reader.ReadU8();
        reader.AlignTo(4); /* _view */
        ObjectPlacementPathTileConnectionSettingsView __view = ObjectPlacementPathTileConnectionSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __useTileConnections,
            __commonYAxisRotation,
            __commonYOffset,
            __commonUpwardsExtrusionAmount,
            __commonDownwardsExtrusionAmount,
            __prefabInheritTileConnectionType,
            __tileConnectionTypeSettings,
            __wasInitialized,
            __view);
    }
}

