namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AudioEnvironment (8 fields) BF9B01D5B7F5C6199D723488B7A706E0/4DB6F93CEC0FA75B65E4E36B1FBC4493 */
public record class AudioEnvironment(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte ExcludeOthers /* NeedsAlign */,
    byte IsDefault /* NeedsAlign */,
    AkAuxBusReference Bus /* NeedsAlign */,
    int Priority /* NeedsAlign */)
{
    public static AudioEnvironment Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* ExcludeOthers */
        byte _ExcludeOthers = reader.ReadU8();
        reader.AlignTo(4); /* IsDefault */
        byte _IsDefault = reader.ReadU8();
        reader.AlignTo(4); /* Bus */
        AkAuxBusReference _Bus = AkAuxBusReference.Read(reader);
        reader.AlignTo(4); /* Priority */
        int _Priority = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _ExcludeOthers,
            _IsDefault,
            _Bus,
            _Priority);
    }
}

