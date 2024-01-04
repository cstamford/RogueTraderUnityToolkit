namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectGroup (7 fields) 57434411B9EE7F95CF9B7BF482D0B978/CF984C78E552C45A14A1F6017A4032BA */
public record class ObjectGroup(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    AsciiString _name /* NeedsAlign */,
    PPtr<GameObject> _groupObject /* NeedsAlign */,
    ObjectGroupView _view /* None */)
{
    public static ObjectGroup Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _name */
        AsciiString __name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _groupObject */
        PPtr<GameObject> __groupObject = PPtr<GameObject>.Read(reader);
        ObjectGroupView __view = ObjectGroupView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __name,
            __groupObject,
            __view);
    }
}

