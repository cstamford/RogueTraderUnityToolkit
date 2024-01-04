namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FogOfWarBlocker (9 fields) DD01A0C66B3926AD7683C614089AB2CC/2AC70BE45F94406C39EA1D7E4664821D */
public record class FogOfWarBlocker(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float ShadowFalloff /* NeedsAlign */,
    Vector2f HeightMinMax /* None */,
    Vector2f Center /* None */,
    Vector2f Radius /* None */,
    byte TwoSided /* None */)
{
    public static FogOfWarBlocker Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* ShadowFalloff */
        float _ShadowFalloff = reader.ReadF32();
        Vector2f _HeightMinMax = Vector2f.Read(reader);
        Vector2f _Center = Vector2f.Read(reader);
        Vector2f _Radius = Vector2f.Read(reader);
        byte _TwoSided = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _ShadowFalloff,
            _HeightMinMax,
            _Center,
            _Radius,
            _TwoSided);
    }
}

