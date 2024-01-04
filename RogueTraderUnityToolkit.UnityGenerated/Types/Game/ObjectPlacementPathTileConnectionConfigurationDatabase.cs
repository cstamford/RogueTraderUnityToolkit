namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectPlacementPathTileConnectionConfigurationDatabase (6 fields) 78932F2F36C34F28D256745E5F91D37C/8BBDA57F3CBA52D96351BD38A3DF1523 */
public record class ObjectPlacementPathTileConnectionConfigurationDatabase(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    ObjectPlacementPathTileConnectionConfigurationCollection _configurations /* NeedsAlign */,
    ObjectPlacementPathTileConnectionConfigurationDatabaseView _view /* None */)
{
    public static ObjectPlacementPathTileConnectionConfigurationDatabase Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _configurations */
        ObjectPlacementPathTileConnectionConfigurationCollection __configurations = ObjectPlacementPathTileConnectionConfigurationCollection.Read(reader);
        ObjectPlacementPathTileConnectionConfigurationDatabaseView __view = ObjectPlacementPathTileConnectionConfigurationDatabaseView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __configurations,
            __view);
    }
}

