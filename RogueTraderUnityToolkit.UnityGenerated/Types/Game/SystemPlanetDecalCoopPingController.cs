namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SystemPlanetDecalCoopPingController (5 fields) CD4BCD49AFF29465CF6CF3732EFA7159/699E769B4983524F7DEEC5F05E52D508 */
public record class SystemPlanetDecalCoopPingController(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> m_SystemPlanetDecalCoopPing /* NeedsAlign */)
{
    public static SystemPlanetDecalCoopPingController Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SystemPlanetDecalCoopPing */
        PPtr<GameObject> _m_SystemPlanetDecalCoopPing = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SystemPlanetDecalCoopPing);
    }
}

