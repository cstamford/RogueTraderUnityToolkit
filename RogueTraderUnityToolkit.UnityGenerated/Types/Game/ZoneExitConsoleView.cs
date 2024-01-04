namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ZoneExitConsoleView (8 fields) 2013D14ECAD30B42052B549D733F9994/E485A3619E50DDF9E1B0418AA86EE679 */
public record class ZoneExitConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ConsoleHint> m_StopShipHint /* NeedsAlign */,
    PPtr<ConsoleHint> m_ExitToShipHint /* None */,
    PPtr<ConsoleHint> m_ExitToWarpHint /* None */,
    PPtr<ConsoleHint> m_OpenShipCustomizationHint /* None */)
{
    public static ZoneExitConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_StopShipHint */
        PPtr<ConsoleHint> _m_StopShipHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_ExitToShipHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_ExitToWarpHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_OpenShipCustomizationHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_StopShipHint,
            _m_ExitToShipHint,
            _m_ExitToWarpHint,
            _m_OpenShipCustomizationHint);
    }
}

