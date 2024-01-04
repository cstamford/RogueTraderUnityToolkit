namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FogOfWarRevealerSettings (10 fields) AFCA2EB7922CB9F83F981D6A87F8C428/DE3956C9C823141A5231A0FBC998AEF2 */
public record class FogOfWarRevealerSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Texture2D> MaskTexture /* NeedsAlign */,
    float Radius /* None */,
    byte DefaultRadius /* None */,
    byte RevealOnStart /* NeedsAlign */,
    byte RevealAlways /* NeedsAlign */,
    byte RevealManual /* NeedsAlign */)
{
    public static FogOfWarRevealerSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* MaskTexture */
        PPtr<Texture2D> _MaskTexture = PPtr<Texture2D>.Read(reader);
        float _Radius = reader.ReadF32();
        byte _DefaultRadius = reader.ReadU8();
        reader.AlignTo(4); /* RevealOnStart */
        byte _RevealOnStart = reader.ReadU8();
        reader.AlignTo(4); /* RevealAlways */
        byte _RevealAlways = reader.ReadU8();
        reader.AlignTo(4); /* RevealManual */
        byte _RevealManual = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _MaskTexture,
            _Radius,
            _DefaultRadius,
            _RevealOnStart,
            _RevealAlways,
            _RevealManual);
    }
}

