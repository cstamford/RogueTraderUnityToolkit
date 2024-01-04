namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectGroupDatabaseViewData (5 fields) BADF450E1D12985EDC80E86E5A115B5F/9CEE83C657741BAC6FAF6CF1AB528DFF */
public record class ObjectGroupDatabaseViewData(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    AsciiString _nameForNewGroup /* NeedsAlign */)
{
    public static ObjectGroupDatabaseViewData Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _nameForNewGroup */
        AsciiString __nameForNewGroup = BuiltInString.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __nameForNewGroup);
    }
}

