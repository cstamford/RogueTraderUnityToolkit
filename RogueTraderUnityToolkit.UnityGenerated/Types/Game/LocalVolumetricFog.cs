namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LocalVolumetricFog (5 fields) DA5EDDCFD5E553A04ECBCC102E2290B0/7B346E2E3009A474BFDC52327FAE9352 */
public record class LocalVolumetricFog(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    LocalVolumetricFogArtistParameters Parameters /* NeedsAlign */)
{
    public static LocalVolumetricFog Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Parameters */
        LocalVolumetricFogArtistParameters _Parameters = LocalVolumetricFogArtistParameters.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Parameters);
    }
}

