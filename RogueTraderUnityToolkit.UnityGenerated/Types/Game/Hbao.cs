namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $Hbao (26 fields) F8CFB7831A3F964646D593B0E818D778/25142C2810EFB883B77BF6AEB44358EE */
public record class Hbao(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte active /* NeedsAlign */,
    QualityParameter Quality /* NeedsAlign */,
    DeinterleavingParameter Deinterleaving /* NeedsAlign */,
    ResolutionParameter Resolution /* NeedsAlign */,
    NoiseTypeParameter NoiseType /* NeedsAlign */,
    ClampedFloatParameter Radius /* NeedsAlign */,
    ClampedFloatParameter MaxRadiusPixels /* NeedsAlign */,
    ClampedFloatParameter Bias /* NeedsAlign */,
    ClampedFloatParameter Intensity /* NeedsAlign */,
    BoolParameter UseMultiBounce /* NeedsAlign */,
    ClampedFloatParameter MultiBounceInfluence /* NeedsAlign */,
    FloatParameter MaxDistance /* NeedsAlign */,
    FloatParameter DistanceFalloff /* NeedsAlign */,
    ColorParameter BaseColor /* NeedsAlign */,
    BoolParameter ColorBleedingEnabled /* NeedsAlign */,
    ClampedFloatParameter Saturation /* NeedsAlign */,
    ClampedFloatParameter AlbedoMultiplier /* NeedsAlign */,
    ClampedFloatParameter BrightnessMask /* NeedsAlign */,
    Vector2Parameter BrightnessMaskRange /* NeedsAlign */,
    BlurParameter BlurAmount /* NeedsAlign */,
    ClampedFloatParameter Sharpness /* NeedsAlign */,
    BoolParameter Downsample /* NeedsAlign */)
{
    public static Hbao Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* active */
        byte _active = reader.ReadU8();
        reader.AlignTo(4); /* Quality */
        QualityParameter _Quality = QualityParameter.Read(reader);
        reader.AlignTo(4); /* Deinterleaving */
        DeinterleavingParameter _Deinterleaving = DeinterleavingParameter.Read(reader);
        reader.AlignTo(4); /* Resolution */
        ResolutionParameter _Resolution = ResolutionParameter.Read(reader);
        reader.AlignTo(4); /* NoiseType */
        NoiseTypeParameter _NoiseType = NoiseTypeParameter.Read(reader);
        reader.AlignTo(4); /* Radius */
        ClampedFloatParameter _Radius = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* MaxRadiusPixels */
        ClampedFloatParameter _MaxRadiusPixels = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* Bias */
        ClampedFloatParameter _Bias = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* Intensity */
        ClampedFloatParameter _Intensity = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* UseMultiBounce */
        BoolParameter _UseMultiBounce = BoolParameter.Read(reader);
        reader.AlignTo(4); /* MultiBounceInfluence */
        ClampedFloatParameter _MultiBounceInfluence = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* MaxDistance */
        FloatParameter _MaxDistance = FloatParameter.Read(reader);
        reader.AlignTo(4); /* DistanceFalloff */
        FloatParameter _DistanceFalloff = FloatParameter.Read(reader);
        reader.AlignTo(4); /* BaseColor */
        ColorParameter _BaseColor = ColorParameter.Read(reader);
        reader.AlignTo(4); /* ColorBleedingEnabled */
        BoolParameter _ColorBleedingEnabled = BoolParameter.Read(reader);
        reader.AlignTo(4); /* Saturation */
        ClampedFloatParameter _Saturation = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* AlbedoMultiplier */
        ClampedFloatParameter _AlbedoMultiplier = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* BrightnessMask */
        ClampedFloatParameter _BrightnessMask = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* BrightnessMaskRange */
        Vector2Parameter _BrightnessMaskRange = Vector2Parameter.Read(reader);
        reader.AlignTo(4); /* BlurAmount */
        BlurParameter _BlurAmount = BlurParameter.Read(reader);
        reader.AlignTo(4); /* Sharpness */
        ClampedFloatParameter _Sharpness = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* Downsample */
        BoolParameter _Downsample = BoolParameter.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _active,
            _Quality,
            _Deinterleaving,
            _Resolution,
            _NoiseType,
            _Radius,
            _MaxRadiusPixels,
            _Bias,
            _Intensity,
            _UseMultiBounce,
            _MultiBounceInfluence,
            _MaxDistance,
            _DistanceFalloff,
            _BaseColor,
            _ColorBleedingEnabled,
            _Saturation,
            _AlbedoMultiplier,
            _BrightnessMask,
            _BrightnessMaskRange,
            _BlurAmount,
            _Sharpness,
            _Downsample);
    }
}

