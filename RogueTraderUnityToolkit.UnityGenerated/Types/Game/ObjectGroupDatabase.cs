namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectGroupDatabase (7 fields) 5F0D613BC44EDEBDDECF78472C7857E6/65DB6051946BD42ADF446A493E672498 */
public record class ObjectGroupDatabase(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    ObjectGroupCollection _objectGroups /* NeedsAlign */,
    byte _preserveGroupChildren /* None */,
    ObjectGroupDatabaseView _view /* NeedsAlign */)
{
    public static ObjectGroupDatabase Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _objectGroups */
        ObjectGroupCollection __objectGroups = ObjectGroupCollection.Read(reader);
        byte __preserveGroupChildren = reader.ReadU8();
        reader.AlignTo(4); /* _view */
        ObjectGroupDatabaseView __view = ObjectGroupDatabaseView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __objectGroups,
            __preserveGroupChildren,
            __view);
    }
}

