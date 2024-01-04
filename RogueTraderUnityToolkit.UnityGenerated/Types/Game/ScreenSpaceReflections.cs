namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ScreenSpaceReflections (26 fields) 355FB839EBA6256007CFC628255AA7DC/5D4317097350EF949C05F65C0B48A16B */
public record class ScreenSpaceReflections(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte active /* NeedsAlign */,
    ScreenSpaceReflectionsQualityParameter Quality /* NeedsAlign */,
    ColorPrecisionParameter ColorPrecision /* NeedsAlign */,
    TracingMethodParameter TracingMethod /* NeedsAlign */,
    ClampedIntParameter MaxRaySteps /* NeedsAlign */,
    ClampedFloatParameter MaxDistance /* NeedsAlign */,
    ClampedIntParameter ScreenSpaceStepSize /* NeedsAlign */,
    ClampedFloatParameter MaxRoughness /* NeedsAlign */,
    ClampedFloatParameter RoughnessFadeStart /* NeedsAlign */,
    ClampedFloatParameter ObjectThickness /* NeedsAlign */,
    ClampedFloatParameter FresnelPower /* NeedsAlign */,
    ClampedFloatParameter ConfidenceScale /* NeedsAlign */,
    BoolParameter UseUpsamplePass /* NeedsAlign */,
    BoolParameter HighlightSupression /* NeedsAlign */,
    BoolParameter UseMotionVectorsForReprojection /* NeedsAlign */,
    BoolParameter BlurEnabled /* NeedsAlign */,
    FloatRangeParameter RoughnessRemap /* NeedsAlign */,
    BoolParameter StochasticSSR /* NeedsAlign */,
    ClampedFloatParameter ScreenFadeDistance /* NeedsAlign */,
    ClampedFloatParameter HistoryInfluence /* NeedsAlign */,
    ClampedFloatParameter SpeedRejectionScalerFactor /* NeedsAlign */,
    FloatParameter SpeedRejectionParam /* NeedsAlign */)
{
    public static ScreenSpaceReflections Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* active */
        byte _active = reader.ReadU8();
        reader.AlignTo(4); /* Quality */
        ScreenSpaceReflectionsQualityParameter _Quality = ScreenSpaceReflectionsQualityParameter.Read(reader);
        reader.AlignTo(4); /* ColorPrecision */
        ColorPrecisionParameter _ColorPrecision = ColorPrecisionParameter.Read(reader);
        reader.AlignTo(4); /* TracingMethod */
        TracingMethodParameter _TracingMethod = TracingMethodParameter.Read(reader);
        reader.AlignTo(4); /* MaxRaySteps */
        ClampedIntParameter _MaxRaySteps = ClampedIntParameter.Read(reader);
        reader.AlignTo(4); /* MaxDistance */
        ClampedFloatParameter _MaxDistance = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* ScreenSpaceStepSize */
        ClampedIntParameter _ScreenSpaceStepSize = ClampedIntParameter.Read(reader);
        reader.AlignTo(4); /* MaxRoughness */
        ClampedFloatParameter _MaxRoughness = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* RoughnessFadeStart */
        ClampedFloatParameter _RoughnessFadeStart = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* ObjectThickness */
        ClampedFloatParameter _ObjectThickness = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* FresnelPower */
        ClampedFloatParameter _FresnelPower = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* ConfidenceScale */
        ClampedFloatParameter _ConfidenceScale = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* UseUpsamplePass */
        BoolParameter _UseUpsamplePass = BoolParameter.Read(reader);
        reader.AlignTo(4); /* HighlightSupression */
        BoolParameter _HighlightSupression = BoolParameter.Read(reader);
        reader.AlignTo(4); /* UseMotionVectorsForReprojection */
        BoolParameter _UseMotionVectorsForReprojection = BoolParameter.Read(reader);
        reader.AlignTo(4); /* BlurEnabled */
        BoolParameter _BlurEnabled = BoolParameter.Read(reader);
        reader.AlignTo(4); /* RoughnessRemap */
        FloatRangeParameter _RoughnessRemap = FloatRangeParameter.Read(reader);
        reader.AlignTo(4); /* StochasticSSR */
        BoolParameter _StochasticSSR = BoolParameter.Read(reader);
        reader.AlignTo(4); /* ScreenFadeDistance */
        ClampedFloatParameter _ScreenFadeDistance = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* HistoryInfluence */
        ClampedFloatParameter _HistoryInfluence = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* SpeedRejectionScalerFactor */
        ClampedFloatParameter _SpeedRejectionScalerFactor = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* SpeedRejectionParam */
        FloatParameter _SpeedRejectionParam = FloatParameter.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _active,
            _Quality,
            _ColorPrecision,
            _TracingMethod,
            _MaxRaySteps,
            _MaxDistance,
            _ScreenSpaceStepSize,
            _MaxRoughness,
            _RoughnessFadeStart,
            _ObjectThickness,
            _FresnelPower,
            _ConfidenceScale,
            _UseUpsamplePass,
            _HighlightSupression,
            _UseMotionVectorsForReprojection,
            _BlurEnabled,
            _RoughnessRemap,
            _StochasticSSR,
            _ScreenFadeDistance,
            _HistoryInfluence,
            _SpeedRejectionScalerFactor,
            _SpeedRejectionParam);
    }
}

