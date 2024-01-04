namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $EditorWindowPool (16 fields) 0B246FDFDEB277006AE52A874A083B99/4A259D61A5EDA00CEA0763DDB6F33E87 */
public record class EditorWindowPool(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Octave3DEditorWindow>[] _allWindows /* NeedsAlign */,
    PPtr<PrefabManagementWindow> _prefabManagementWindow /* None */,
    PPtr<ObjectPlacementSettingsWindow> _objectPlacementSettingsWindow /* None */,
    PPtr<PrefabsToCategoryDropSettingsWindow> _prefabsToCategoryDropSettingsWindow /* None */,
    PPtr<PrefabTagsWindow> _prefabTagsWindow /* None */,
    PPtr<ObjectLayersWindow> _objectLayersWindow /* None */,
    PPtr<ObjectGrabSettingsWindow> _selectionGrabSettingsWindow /* None */,
    PPtr<Octave3DConfigSaveWindow> _octave3DConfigSaveWindow /* None */,
    PPtr<Octave3DConfigLoadWindow> _octave3DConfigLoadWindow /* None */,
    PPtr<DecorPaintBrushViewLookAndFeelWindow> _decorPaintBrushViewLookAndFeelWindow /* None */,
    ActivePrefabCategoryView _activePrefabCategoryView /* None */,
    ActivePrefabView _activePrefabView /* NeedsAlign */)
{
    public static EditorWindowPool Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _allWindows */
        PPtr<Octave3DEditorWindow>[] __allWindows = BuiltInArray<PPtr<Octave3DEditorWindow>>.Read(reader);
        PPtr<PrefabManagementWindow> __prefabManagementWindow = PPtr<PrefabManagementWindow>.Read(reader);
        PPtr<ObjectPlacementSettingsWindow> __objectPlacementSettingsWindow = PPtr<ObjectPlacementSettingsWindow>.Read(reader);
        PPtr<PrefabsToCategoryDropSettingsWindow> __prefabsToCategoryDropSettingsWindow = PPtr<PrefabsToCategoryDropSettingsWindow>.Read(reader);
        PPtr<PrefabTagsWindow> __prefabTagsWindow = PPtr<PrefabTagsWindow>.Read(reader);
        PPtr<ObjectLayersWindow> __objectLayersWindow = PPtr<ObjectLayersWindow>.Read(reader);
        PPtr<ObjectGrabSettingsWindow> __selectionGrabSettingsWindow = PPtr<ObjectGrabSettingsWindow>.Read(reader);
        PPtr<Octave3DConfigSaveWindow> __octave3DConfigSaveWindow = PPtr<Octave3DConfigSaveWindow>.Read(reader);
        PPtr<Octave3DConfigLoadWindow> __octave3DConfigLoadWindow = PPtr<Octave3DConfigLoadWindow>.Read(reader);
        PPtr<DecorPaintBrushViewLookAndFeelWindow> __decorPaintBrushViewLookAndFeelWindow = PPtr<DecorPaintBrushViewLookAndFeelWindow>.Read(reader);
        ActivePrefabCategoryView __activePrefabCategoryView = ActivePrefabCategoryView.Read(reader);
        reader.AlignTo(4); /* _activePrefabView */
        ActivePrefabView __activePrefabView = ActivePrefabView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __allWindows,
            __prefabManagementWindow,
            __objectPlacementSettingsWindow,
            __prefabsToCategoryDropSettingsWindow,
            __prefabTagsWindow,
            __objectLayersWindow,
            __selectionGrabSettingsWindow,
            __octave3DConfigSaveWindow,
            __octave3DConfigLoadWindow,
            __decorPaintBrushViewLookAndFeelWindow,
            __activePrefabCategoryView,
            __activePrefabView);
    }
}

