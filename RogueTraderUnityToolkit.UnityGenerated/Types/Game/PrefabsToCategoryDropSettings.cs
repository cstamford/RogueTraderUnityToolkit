namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PrefabsToCategoryDropSettings (6 fields) 4D119B4082EEFCF34600B9F5163790FC/5D729216DBEF9F4EBFCF1B22BFC7770D */
public record class PrefabsToCategoryDropSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    AsciiString[] _tagNamesForDroppedPrefabs /* NeedsAlign */,
    PrefabToCategoryDropSettingsView _view /* NeedsAlign */)
{
    public static PrefabsToCategoryDropSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _tagNamesForDroppedPrefabs */
        AsciiString[] __tagNamesForDroppedPrefabs = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* _view */
        PrefabToCategoryDropSettingsView __view = PrefabToCategoryDropSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __tagNamesForDroppedPrefabs,
            __view);
    }
}

