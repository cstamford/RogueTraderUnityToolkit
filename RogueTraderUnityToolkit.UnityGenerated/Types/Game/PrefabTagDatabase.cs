namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PrefabTagDatabase (7 fields) 7BA2FAD8FA291737D6E12AB74FE84C3F/88277C3E4E895F5B5F3A3BECACF052F4 */
public record class PrefabTagDatabase(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PrefabTagCollection _prefabTags /* NeedsAlign */,
    PPtr<PrefabTagFilter> _prefabTagFilter /* None */,
    PrefabTagDatabaseView _view /* None */)
{
    public static PrefabTagDatabase Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _prefabTags */
        PrefabTagCollection __prefabTags = PrefabTagCollection.Read(reader);
        PPtr<PrefabTagFilter> __prefabTagFilter = PPtr<PrefabTagFilter>.Read(reader);
        PrefabTagDatabaseView __view = PrefabTagDatabaseView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __prefabTags,
            __prefabTagFilter,
            __view);
    }
}

