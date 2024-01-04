namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SystemPlanetDecalConsoleFocusController (5 fields) BFEC7A8A679BCF257990160071FC31F8/3B4FF9199C6F061BEA81622DDF9EF658 */
public record class SystemPlanetDecalConsoleFocusController(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> m_SystemPlanetDecalFocusDecal /* NeedsAlign */)
{
    public static SystemPlanetDecalConsoleFocusController Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SystemPlanetDecalFocusDecal */
        PPtr<GameObject> _m_SystemPlanetDecalFocusDecal = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SystemPlanetDecalFocusDecal);
    }
}

