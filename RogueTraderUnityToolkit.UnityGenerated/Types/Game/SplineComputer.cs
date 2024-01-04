namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SplineComputer (17 fields) EEC4E4B05EEA96C769EA5B1FBCAC754B/A52EAAAF3DD0228772ACE9A5CFED099C */
public record class SplineComputer(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte multithreaded /* NeedsAlign */,
    int updateMode /* NeedsAlign */,
    TriggerGroup[] triggerGroups /* None */,
    Spline _spline /* NeedsAlign */,
    double[] _originalSamplePercents /* NeedsAlign */,
    byte _is2D /* NeedsAlign */,
    byte hasSamples /* NeedsAlign */,
    float _optimizeAngleThreshold /* NeedsAlign */,
    int _space /* None */,
    int _sampleMode /* None */,
    PPtr<SplineUser>[] _subscribers /* None */,
    SplineSample _rawSamples /* None */,
    NodeLink[] _nodes /* None */)
{
    public static SplineComputer Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* multithreaded */
        byte _multithreaded = reader.ReadU8();
        reader.AlignTo(4); /* updateMode */
        int _updateMode = reader.ReadS32();
        TriggerGroup[] _triggerGroups = BuiltInArray<TriggerGroup>.Read(reader);
        reader.AlignTo(4); /* _spline */
        Spline __spline = Spline.Read(reader);
        reader.AlignTo(4); /* _originalSamplePercents */
        double[] __originalSamplePercents = BuiltInArray<double>.Read(reader);
        reader.AlignTo(4); /* _is2D */
        byte __is2D = reader.ReadU8();
        reader.AlignTo(4); /* hasSamples */
        byte _hasSamples = reader.ReadU8();
        reader.AlignTo(4); /* _optimizeAngleThreshold */
        float __optimizeAngleThreshold = reader.ReadF32();
        int __space = reader.ReadS32();
        int __sampleMode = reader.ReadS32();
        PPtr<SplineUser>[] __subscribers = BuiltInArray<PPtr<SplineUser>>.Read(reader);
        SplineSample __rawSamples = SplineSample.Read(reader);
        NodeLink[] __nodes = BuiltInArray<NodeLink>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _multithreaded,
            _updateMode,
            _triggerGroups,
            __spline,
            __originalSamplePercents,
            __is2D,
            _hasSamples,
            __optimizeAngleThreshold,
            __space,
            __sampleMode,
            __subscribers,
            __rawSamples,
            __nodes);
    }
}

