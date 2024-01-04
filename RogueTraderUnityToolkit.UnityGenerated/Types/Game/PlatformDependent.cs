namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PlatformDependent (7 fields) 9B249A5144F18F67D1F7C12EA494FF89/A6D4220831585B4D9961DC4F37ADF7C5 */
public record class PlatformDependent(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte AllowOnConsole /* NeedsAlign */,
    byte AllowOnPC /* NeedsAlign */,
    byte AllowOnMac /* NeedsAlign */)
{
    public static PlatformDependent Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* AllowOnConsole */
        byte _AllowOnConsole = reader.ReadU8();
        reader.AlignTo(4); /* AllowOnPC */
        byte _AllowOnPC = reader.ReadU8();
        reader.AlignTo(4); /* AllowOnMac */
        byte _AllowOnMac = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _AllowOnConsole,
            _AllowOnPC,
            _AllowOnMac);
    }
}

