namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SystemMapNoisesView (7 fields) 3E2BC884D750F316DB63DCC519D47E24/A05678A0FDFFBB611C78DDD64F6F94B9 */
public record class SystemMapNoisesView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> m_AnomalyNoise /* NeedsAlign */,
    PPtr<GameObject> m_PlanetPoiNoise /* None */,
    PPtr<GameObject> m_PlanetResourceNoise /* None */)
{
    public static SystemMapNoisesView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_AnomalyNoise */
        PPtr<GameObject> _m_AnomalyNoise = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_PlanetPoiNoise = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_PlanetResourceNoise = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_AnomalyNoise,
            _m_PlanetPoiNoise,
            _m_PlanetResourceNoise);
    }
}

