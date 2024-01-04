namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ActivePrefabCategoryViewData (13 fields) 8326C18F254A528EE57137174E6DB799/E5F6B3F3A43B3260D39BEC619AE2AFEF */
public record class ActivePrefabCategoryViewData(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte _showPrefabCategoryFolderNames /* NeedsAlign */,
    int _maxNumberOfCategoryFolderNames /* NeedsAlign */,
    AsciiString _nameForNewPrefabCategory /* None */,
    int _prefabMoveType /* NeedsAlign */,
    PPtr<PrefabCategory> _destinationCategoryForPrefabMove /* None */,
    float _prefabOffsetFromGridSurface /* None */,
    float _prefabOffsetFromObjectSurface /* None */,
    AsciiString _prefabConfigLoadDir /* None */,
    AsciiString _prefabConfigSaveDir /* NeedsAlign */)
{
    public static ActivePrefabCategoryViewData Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _showPrefabCategoryFolderNames */
        byte __showPrefabCategoryFolderNames = reader.ReadU8();
        reader.AlignTo(4); /* _maxNumberOfCategoryFolderNames */
        int __maxNumberOfCategoryFolderNames = reader.ReadS32();
        AsciiString __nameForNewPrefabCategory = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _prefabMoveType */
        int __prefabMoveType = reader.ReadS32();
        PPtr<PrefabCategory> __destinationCategoryForPrefabMove = PPtr<PrefabCategory>.Read(reader);
        float __prefabOffsetFromGridSurface = reader.ReadF32();
        float __prefabOffsetFromObjectSurface = reader.ReadF32();
        AsciiString __prefabConfigLoadDir = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _prefabConfigSaveDir */
        AsciiString __prefabConfigSaveDir = BuiltInString.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __showPrefabCategoryFolderNames,
            __maxNumberOfCategoryFolderNames,
            __nameForNewPrefabCategory,
            __prefabMoveType,
            __destinationCategoryForPrefabMove,
            __prefabOffsetFromGridSurface,
            __prefabOffsetFromObjectSurface,
            __prefabConfigLoadDir,
            __prefabConfigSaveDir);
    }
}

