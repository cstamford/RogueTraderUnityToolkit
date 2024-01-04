namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DepthOfField (16 fields) 76C468134CA618655A23B06402156E9D/F11C9C5B0201966F42DFFF162AA7939E */
public record class DepthOfField(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte active /* NeedsAlign */,
    DepthOfFieldModeParameter mode /* NeedsAlign */,
    MinFloatParameter gaussianStart /* NeedsAlign */,
    MinFloatParameter gaussianEnd /* NeedsAlign */,
    ClampedFloatParameter gaussianMaxRadius /* NeedsAlign */,
    BoolParameter highQualitySampling /* NeedsAlign */,
    MinFloatParameter focusDistance /* NeedsAlign */,
    ClampedFloatParameter aperture /* NeedsAlign */,
    ClampedFloatParameter focalLength /* NeedsAlign */,
    ClampedIntParameter bladeCount /* NeedsAlign */,
    ClampedFloatParameter bladeCurvature /* NeedsAlign */,
    ClampedFloatParameter bladeRotation /* NeedsAlign */)
{
    public static DepthOfField Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* active */
        byte _active = reader.ReadU8();
        reader.AlignTo(4); /* mode */
        DepthOfFieldModeParameter _mode = DepthOfFieldModeParameter.Read(reader);
        reader.AlignTo(4); /* gaussianStart */
        MinFloatParameter _gaussianStart = MinFloatParameter.Read(reader);
        reader.AlignTo(4); /* gaussianEnd */
        MinFloatParameter _gaussianEnd = MinFloatParameter.Read(reader);
        reader.AlignTo(4); /* gaussianMaxRadius */
        ClampedFloatParameter _gaussianMaxRadius = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* highQualitySampling */
        BoolParameter _highQualitySampling = BoolParameter.Read(reader);
        reader.AlignTo(4); /* focusDistance */
        MinFloatParameter _focusDistance = MinFloatParameter.Read(reader);
        reader.AlignTo(4); /* aperture */
        ClampedFloatParameter _aperture = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* focalLength */
        ClampedFloatParameter _focalLength = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* bladeCount */
        ClampedIntParameter _bladeCount = ClampedIntParameter.Read(reader);
        reader.AlignTo(4); /* bladeCurvature */
        ClampedFloatParameter _bladeCurvature = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* bladeRotation */
        ClampedFloatParameter _bladeRotation = ClampedFloatParameter.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _active,
            _mode,
            _gaussianStart,
            _gaussianEnd,
            _gaussianMaxRadius,
            _highQualitySampling,
            _focusDistance,
            _aperture,
            _focalLength,
            _bladeCount,
            _bladeCurvature,
            _bladeRotation);
    }
}

