namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectPlacementPathTileConnectionTypeSettings (11 fields) 3FA4E2C3C30B151E5C27B928D4266CD0/82079C6DD3C7BD5FBB40A3EE1EFC716C */
public record class ObjectPlacementPathTileConnectionTypeSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int _tileConnectionType /* NeedsAlign */,
    Prefab _prefab /* None */,
    int _yAxisRotation /* NeedsAlign */,
    float _yOffset /* None */,
    int _upwardsExtrusionAmount /* None */,
    int _downwardsExtrusionAmount /* None */,
    ObjectPlacementPathTileConnectionTypeSettingsView _view /* None */)
{
    public static ObjectPlacementPathTileConnectionTypeSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _tileConnectionType */
        int __tileConnectionType = reader.ReadS32();
        Prefab __prefab = Prefab.Read(reader);
        reader.AlignTo(4); /* _yAxisRotation */
        int __yAxisRotation = reader.ReadS32();
        float __yOffset = reader.ReadF32();
        int __upwardsExtrusionAmount = reader.ReadS32();
        int __downwardsExtrusionAmount = reader.ReadS32();
        ObjectPlacementPathTileConnectionTypeSettingsView __view = ObjectPlacementPathTileConnectionTypeSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __tileConnectionType,
            __prefab,
            __yAxisRotation,
            __yOffset,
            __upwardsExtrusionAmount,
            __downwardsExtrusionAmount,
            __view);
    }
}

