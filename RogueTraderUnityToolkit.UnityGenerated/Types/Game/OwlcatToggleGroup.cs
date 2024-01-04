namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OwlcatToggleGroup (6 fields) 2D7B743CDD258EE751D5E990E415D811/9B0415EF2E79BB92A617390B5D7A18E3 */
public record class OwlcatToggleGroup(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_AllowSwitchOff /* NeedsAlign */,
    int m_ConsoleNavigation /* NeedsAlign */)
{
    public static OwlcatToggleGroup Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_AllowSwitchOff */
        byte _m_AllowSwitchOff = reader.ReadU8();
        reader.AlignTo(4); /* m_ConsoleNavigation */
        int _m_ConsoleNavigation = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_AllowSwitchOff,
            _m_ConsoleNavigation);
    }
}

