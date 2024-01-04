namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VolumetricFog (13 fields) 550A13B9A51FF587F9BB754FC7802FE9/F4D1ED94CBD520C5806B1D2AC7AE5086 */
public record class VolumetricFog(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte active /* NeedsAlign */,
    BoolParameter FogEnabled /* NeedsAlign */,
    ClampedFloatParameter Anisotropy /* NeedsAlign */,
    MinFloatParameter FogDistanceAttenuation /* NeedsAlign */,
    ColorParameter Albedo /* NeedsAlign */,
    MinFloatParameter AmbientLightMultiplier /* NeedsAlign */,
    BoolParameter HeightFogEnabled /* NeedsAlign */,
    FloatParameter BaseHeight /* NeedsAlign */,
    MinFloatParameter FogHeight /* NeedsAlign */)
{
    public static VolumetricFog Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* active */
        byte _active = reader.ReadU8();
        reader.AlignTo(4); /* FogEnabled */
        BoolParameter _FogEnabled = BoolParameter.Read(reader);
        reader.AlignTo(4); /* Anisotropy */
        ClampedFloatParameter _Anisotropy = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* FogDistanceAttenuation */
        MinFloatParameter _FogDistanceAttenuation = MinFloatParameter.Read(reader);
        reader.AlignTo(4); /* Albedo */
        ColorParameter _Albedo = ColorParameter.Read(reader);
        reader.AlignTo(4); /* AmbientLightMultiplier */
        MinFloatParameter _AmbientLightMultiplier = MinFloatParameter.Read(reader);
        reader.AlignTo(4); /* HeightFogEnabled */
        BoolParameter _HeightFogEnabled = BoolParameter.Read(reader);
        reader.AlignTo(4); /* BaseHeight */
        FloatParameter _BaseHeight = FloatParameter.Read(reader);
        reader.AlignTo(4); /* FogHeight */
        MinFloatParameter _FogHeight = MinFloatParameter.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _active,
            _FogEnabled,
            _Anisotropy,
            _FogDistanceAttenuation,
            _Albedo,
            _AmbientLightMultiplier,
            _HeightFogEnabled,
            _BaseHeight,
            _FogHeight);
    }
}

