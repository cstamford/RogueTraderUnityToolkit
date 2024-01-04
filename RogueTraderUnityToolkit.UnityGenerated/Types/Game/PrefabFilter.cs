namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PrefabFilter (7 fields) F097B3F42D890DB57BF39DA7F5D6B1D7/356C0B747D19FE0895BFB2FF063D2DE3 */
public record class PrefabFilter(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<EntityNameFilter> _nameFilter /* NeedsAlign */,
    EntityFilterProperty _filterByActiveTags /* None */,
    PrefabFilterView _view /* NeedsAlign */)
{
    public static PrefabFilter Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _nameFilter */
        PPtr<EntityNameFilter> __nameFilter = PPtr<EntityNameFilter>.Read(reader);
        EntityFilterProperty __filterByActiveTags = EntityFilterProperty.Read(reader);
        reader.AlignTo(4); /* _view */
        PrefabFilterView __view = PrefabFilterView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __nameFilter,
            __filterByActiveTags,
            __view);
    }
}

