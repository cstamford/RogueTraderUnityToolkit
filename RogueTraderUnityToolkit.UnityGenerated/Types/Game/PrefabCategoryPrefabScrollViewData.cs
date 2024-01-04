namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PrefabCategoryPrefabScrollViewData (12 fields) F906F49DD8E65435016591EDECF043BF/42FD108DF14D868A3EDEFDFC6C288B3C */
public record class PrefabCategoryPrefabScrollViewData(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    Vector2f _prefabScrollPosition /* NeedsAlign */,
    int _numberOfPrefabsPerRow /* None */,
    float _prefabPreviewScale /* None */,
    float _prefabScrollViewHeight /* None */,
    ColorRGBA _activePrefabTint /* None */,
    byte _showPrefabNames /* None */,
    ColorRGBA _prefabNameLabelColor /* NeedsAlign */,
    PPtr<PrefabCategoryScrollViewLookAndFeelWindow> _lookAndFeelWindow /* None */)
{
    public static PrefabCategoryPrefabScrollViewData Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _prefabScrollPosition */
        Vector2f __prefabScrollPosition = Vector2f.Read(reader);
        int __numberOfPrefabsPerRow = reader.ReadS32();
        float __prefabPreviewScale = reader.ReadF32();
        float __prefabScrollViewHeight = reader.ReadF32();
        ColorRGBA __activePrefabTint = ColorRGBA.Read(reader);
        byte __showPrefabNames = reader.ReadU8();
        reader.AlignTo(4); /* _prefabNameLabelColor */
        ColorRGBA __prefabNameLabelColor = ColorRGBA.Read(reader);
        PPtr<PrefabCategoryScrollViewLookAndFeelWindow> __lookAndFeelWindow = PPtr<PrefabCategoryScrollViewLookAndFeelWindow>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __prefabScrollPosition,
            __numberOfPrefabsPerRow,
            __prefabPreviewScale,
            __prefabScrollViewHeight,
            __activePrefabTint,
            __showPrefabNames,
            __prefabNameLabelColor,
            __lookAndFeelWindow);
    }
}

