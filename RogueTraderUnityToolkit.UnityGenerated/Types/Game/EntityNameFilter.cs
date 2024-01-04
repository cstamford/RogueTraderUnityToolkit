namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $EntityNameFilter (6 fields) B4F17D8F64DDE71208D0CD5A80076256/F730475519DAB66E46B615CC8F5AD93D */
public record class EntityNameFilter(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    AsciiString _nameFilter /* NeedsAlign */,
    EntityNameFilterView _view /* NeedsAlign */)
{
    public static EntityNameFilter Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _nameFilter */
        AsciiString __nameFilter = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _view */
        EntityNameFilterView __view = EntityNameFilterView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __nameFilter,
            __view);
    }
}

