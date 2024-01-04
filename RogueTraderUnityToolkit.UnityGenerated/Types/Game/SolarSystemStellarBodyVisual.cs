namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SolarSystemStellarBodyVisual (22 fields) 646ADD2921284001BA7B83B4C47FF210/8DD9AB98A6742E57F25B090E9FDC5FC9 */
public record class SolarSystemStellarBodyVisual(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte NoVisualOrbit /* NeedsAlign */,
    int OrbitLevel /* NeedsAlign */,
    int SecondaryOrbitsNumber /* None */,
    byte overrideSecondaryOrbitAngles /* None */,
    float SecondaryOrbitsDeviationZmin /* NeedsAlign */,
    float SecondaryOrbitsDeviationZmax /* None */,
    float SecondaryOrbitsDeviationXmin /* None */,
    float SecondaryOrbitsDeviationXmax /* None */,
    PPtr<GameObject> Visual /* None */,
    PPtr<GameObject> Mechanics /* None */,
    PPtr<LineRenderer> OrbitLineRenderer /* None */,
    PPtr<SplineComputer> OrbitSplineComputer /* None */,
    PPtr<GameObject> ShadowProjection /* None */,
    PPtr<LineRenderer> SelectorMarkerRing /* None */,
    PPtr<LineRenderer>[] SecondaryOrbits /* None */,
    PPtr<GameObject>[] SecondaryOrbitsArrows /* None */,
    PPtr<GameObject>[] SelectorMarkerRingArrows /* None */,
    StellarOrbit[] Orbits /* None */)
{
    public static SolarSystemStellarBodyVisual Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* NoVisualOrbit */
        byte _NoVisualOrbit = reader.ReadU8();
        reader.AlignTo(4); /* OrbitLevel */
        int _OrbitLevel = reader.ReadS32();
        int _SecondaryOrbitsNumber = reader.ReadS32();
        byte _overrideSecondaryOrbitAngles = reader.ReadU8();
        reader.AlignTo(4); /* SecondaryOrbitsDeviationZmin */
        float _SecondaryOrbitsDeviationZmin = reader.ReadF32();
        float _SecondaryOrbitsDeviationZmax = reader.ReadF32();
        float _SecondaryOrbitsDeviationXmin = reader.ReadF32();
        float _SecondaryOrbitsDeviationXmax = reader.ReadF32();
        PPtr<GameObject> _Visual = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _Mechanics = PPtr<GameObject>.Read(reader);
        PPtr<LineRenderer> _OrbitLineRenderer = PPtr<LineRenderer>.Read(reader);
        PPtr<SplineComputer> _OrbitSplineComputer = PPtr<SplineComputer>.Read(reader);
        PPtr<GameObject> _ShadowProjection = PPtr<GameObject>.Read(reader);
        PPtr<LineRenderer> _SelectorMarkerRing = PPtr<LineRenderer>.Read(reader);
        PPtr<LineRenderer>[] _SecondaryOrbits = BuiltInArray<PPtr<LineRenderer>>.Read(reader);
        PPtr<GameObject>[] _SecondaryOrbitsArrows = BuiltInArray<PPtr<GameObject>>.Read(reader);
        PPtr<GameObject>[] _SelectorMarkerRingArrows = BuiltInArray<PPtr<GameObject>>.Read(reader);
        StellarOrbit[] _Orbits = BuiltInArray<StellarOrbit>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _NoVisualOrbit,
            _OrbitLevel,
            _SecondaryOrbitsNumber,
            _overrideSecondaryOrbitAngles,
            _SecondaryOrbitsDeviationZmin,
            _SecondaryOrbitsDeviationZmax,
            _SecondaryOrbitsDeviationXmin,
            _SecondaryOrbitsDeviationXmax,
            _Visual,
            _Mechanics,
            _OrbitLineRenderer,
            _OrbitSplineComputer,
            _ShadowProjection,
            _SelectorMarkerRing,
            _SecondaryOrbits,
            _SecondaryOrbitsArrows,
            _SelectorMarkerRingArrows,
            _Orbits);
    }
}

