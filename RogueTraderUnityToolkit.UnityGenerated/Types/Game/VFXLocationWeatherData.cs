namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VFXLocationWeatherData (6 fields) A24DB0BAC0A438A21071AB27E5F49429/0853771EB312C2E28E2D2519E1F52DA0 */
public record class VFXLocationWeatherData(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Texture2D> Texture /* NeedsAlign */,
    VFXBakedGroundAreaAsset[] Textures /* None */)
{
    public static VFXLocationWeatherData Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Texture */
        PPtr<Texture2D> _Texture = PPtr<Texture2D>.Read(reader);
        VFXBakedGroundAreaAsset[] _Textures = BuiltInArray<VFXBakedGroundAreaAsset>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Texture,
            _Textures);
    }
}

