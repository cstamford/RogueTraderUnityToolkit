namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectSelectionPrefabCreationSettings (9 fields) 5B2C2641E61C0716215CC61D4951BC8F/14CC10E4CBD0EC571C8AC1DDCDF03F78 */
public record class ObjectSelectionPrefabCreationSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<PrefabCategory> _destinationCategory /* NeedsAlign */,
    AsciiString _prefabName /* None */,
    AsciiString _destinationFolder /* NeedsAlign */,
    int _pivot /* NeedsAlign */,
    ObjectSelectionPrefabCreationSettingsView _view /* None */)
{
    public static ObjectSelectionPrefabCreationSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _destinationCategory */
        PPtr<PrefabCategory> __destinationCategory = PPtr<PrefabCategory>.Read(reader);
        AsciiString __prefabName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _destinationFolder */
        AsciiString __destinationFolder = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _pivot */
        int __pivot = reader.ReadS32();
        ObjectSelectionPrefabCreationSettingsView __view = ObjectSelectionPrefabCreationSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __destinationCategory,
            __prefabName,
            __destinationFolder,
            __pivot,
            __view);
    }
}

