namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $Inspector (11 fields) 2459E6BC337142855E4A1125756E4B8F/0A16C6CC79E75AC34E8D4C71E938F2F7 */
public record class Inspector(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Editor> _editorWindow /* NeedsAlign */,
    int _activeInspectorGUIIdentifier /* None */,
    InspectorGUISelectionToolbar _inpectorGUISelectionTolbar /* None */,
    ObjectPlacementInspectorGUI _objectPlacementInspectorGUI /* NeedsAlign */,
    ObjectEraseInspectorGUI _objectEraseInspectorGUI /* NeedsAlign */,
    ObjectSnappingInspectorGUI _objectSnappingInspectorGUI /* NeedsAlign */,
    ObjectSelectionInspectorGUI _objectSelectionInspectorGUI /* NeedsAlign */)
{
    public static Inspector Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _editorWindow */
        PPtr<Editor> __editorWindow = PPtr<Editor>.Read(reader);
        int __activeInspectorGUIIdentifier = reader.ReadS32();
        InspectorGUISelectionToolbar __inpectorGUISelectionTolbar = InspectorGUISelectionToolbar.Read(reader);
        reader.AlignTo(4); /* _objectPlacementInspectorGUI */
        ObjectPlacementInspectorGUI __objectPlacementInspectorGUI = ObjectPlacementInspectorGUI.Read(reader);
        reader.AlignTo(4); /* _objectEraseInspectorGUI */
        ObjectEraseInspectorGUI __objectEraseInspectorGUI = ObjectEraseInspectorGUI.Read(reader);
        reader.AlignTo(4); /* _objectSnappingInspectorGUI */
        ObjectSnappingInspectorGUI __objectSnappingInspectorGUI = ObjectSnappingInspectorGUI.Read(reader);
        reader.AlignTo(4); /* _objectSelectionInspectorGUI */
        ObjectSelectionInspectorGUI __objectSelectionInspectorGUI = ObjectSelectionInspectorGUI.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __editorWindow,
            __activeInspectorGUIIdentifier,
            __inpectorGUISelectionTolbar,
            __objectPlacementInspectorGUI,
            __objectEraseInspectorGUI,
            __objectSnappingInspectorGUI,
            __objectSelectionInspectorGUI);
    }
}

