namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PrefabCategory (9 fields) 94468E6CAC2B2FE91978B1D6B5F35869/DCC01249D38F8080379A5CA77A7F4238 */
public record class PrefabCategory(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PrefabCollection _prefabs /* NeedsAlign */,
    PPtr<PrefabFilter> _prefabFilter /* NeedsAlign */,
    AsciiString[] _pathFolderNames /* None */,
    PPtr<ObjectGroup> _objectGroup /* NeedsAlign */,
    AsciiString _name /* None */)
{
    public static PrefabCategory Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _prefabs */
        PrefabCollection __prefabs = PrefabCollection.Read(reader);
        reader.AlignTo(4); /* _prefabFilter */
        PPtr<PrefabFilter> __prefabFilter = PPtr<PrefabFilter>.Read(reader);
        AsciiString[] __pathFolderNames = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* _objectGroup */
        PPtr<ObjectGroup> __objectGroup = PPtr<ObjectGroup>.Read(reader);
        AsciiString __name = BuiltInString.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __prefabs,
            __prefabFilter,
            __pathFolderNames,
            __objectGroup,
            __name);
    }
}

