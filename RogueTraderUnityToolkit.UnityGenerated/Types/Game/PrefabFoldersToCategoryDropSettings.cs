namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PrefabFoldersToCategoryDropSettings (10 fields) EF8BA108538A4AF820C3F35BBBD80F78/B053671D303042E72B302E51FFCDEDD3 */
public record class PrefabFoldersToCategoryDropSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte _createPrefabCategoriesFromDroppedFolders /* NeedsAlign */,
    byte _activateLastCreatedCategory /* NeedsAlign */,
    AsciiString[] _tagNamesForDroppedPrefabFolders /* NeedsAlign */,
    byte _createPrefabTagsForEachDroppedFolder /* NeedsAlign */,
    byte _processSubfolders /* NeedsAlign */,
    PrefabFoldersToCategoryDropSettingsView _view /* NeedsAlign */)
{
    public static PrefabFoldersToCategoryDropSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _createPrefabCategoriesFromDroppedFolders */
        byte __createPrefabCategoriesFromDroppedFolders = reader.ReadU8();
        reader.AlignTo(4); /* _activateLastCreatedCategory */
        byte __activateLastCreatedCategory = reader.ReadU8();
        reader.AlignTo(4); /* _tagNamesForDroppedPrefabFolders */
        AsciiString[] __tagNamesForDroppedPrefabFolders = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* _createPrefabTagsForEachDroppedFolder */
        byte __createPrefabTagsForEachDroppedFolder = reader.ReadU8();
        reader.AlignTo(4); /* _processSubfolders */
        byte __processSubfolders = reader.ReadU8();
        reader.AlignTo(4); /* _view */
        PrefabFoldersToCategoryDropSettingsView __view = PrefabFoldersToCategoryDropSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __createPrefabCategoriesFromDroppedFolders,
            __activateLastCreatedCategory,
            __tagNamesForDroppedPrefabFolders,
            __createPrefabTagsForEachDroppedFolder,
            __processSubfolders,
            __view);
    }
}

