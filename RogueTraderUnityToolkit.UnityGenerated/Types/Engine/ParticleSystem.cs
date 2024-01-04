namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $ParticleSystem (41 fields) FA711CF463BE239D5FF509B658C95D25 */
public record class ParticleSystem(
    PPtr<GameObject> m_GameObject /* None */,
    float lengthInSec /* None */,
    float simulationSpeed /* None */,
    int stopAction /* None */,
    int cullingMode /* None */,
    int ringBufferMode /* None */,
    Vector2f ringBufferLoopRange /* None */,
    int emitterVelocityMode /* None */,
    bool looping /* None */,
    bool prewarm /* None */,
    bool playOnAwake /* None */,
    bool useUnscaledTime /* None */,
    bool autoRandomSeed /* None */,
    MinMaxCurve startDelay /* NeedsAlign */,
    int moveWithTransform /* NeedsAlign */,
    PPtr<Transform> moveWithCustomTransform /* NeedsAlign */,
    int scalingMode /* None */,
    int randomSeed /* None */,
    InitialModule InitialModule /* None */,
    ShapeModule ShapeModule /* NeedsAlign */,
    EmissionModule EmissionModule /* NeedsAlign */,
    SizeModule SizeModule /* NeedsAlign */,
    RotationModule RotationModule /* NeedsAlign */,
    ColorModule ColorModule /* NeedsAlign */,
    UVModule UVModule /* NeedsAlign */,
    VelocityModule VelocityModule /* NeedsAlign */,
    InheritVelocityModule InheritVelocityModule /* NeedsAlign */,
    LifetimeByEmitterSpeedModule LifetimeByEmitterSpeedModule /* NeedsAlign */,
    ForceModule ForceModule /* NeedsAlign */,
    ExternalForcesModule ExternalForcesModule /* NeedsAlign */,
    ClampVelocityModule ClampVelocityModule /* NeedsAlign */,
    NoiseModule NoiseModule /* NeedsAlign */,
    SizeBySpeedModule SizeBySpeedModule /* NeedsAlign */,
    RotationBySpeedModule RotationBySpeedModule /* NeedsAlign */,
    ColorBySpeedModule ColorBySpeedModule /* NeedsAlign */,
    CollisionModule CollisionModule /* NeedsAlign */,
    TriggerModule TriggerModule /* NeedsAlign */,
    SubModule SubModule /* NeedsAlign */,
    LightsModule LightsModule /* NeedsAlign */,
    TrailModule TrailModule /* NeedsAlign */,
    CustomDataModule CustomDataModule /* NeedsAlign */) : IUnityObject
{
    public static Hash128 Hash => new(4201716980, 1673405341, 1609894326, 1489591589);
    public static ParticleSystem Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        float _lengthInSec = reader.ReadF32();
        float _simulationSpeed = reader.ReadF32();
        int _stopAction = reader.ReadS32();
        int _cullingMode = reader.ReadS32();
        int _ringBufferMode = reader.ReadS32();
        Vector2f _ringBufferLoopRange = Vector2f.Read(reader);
        int _emitterVelocityMode = reader.ReadS32();
        bool _looping = reader.ReadBool();
        bool _prewarm = reader.ReadBool();
        bool _playOnAwake = reader.ReadBool();
        bool _useUnscaledTime = reader.ReadBool();
        bool _autoRandomSeed = reader.ReadBool();
        reader.AlignTo(4); /* startDelay */
        MinMaxCurve _startDelay = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* moveWithTransform */
        int _moveWithTransform = reader.ReadS32();
        reader.AlignTo(4); /* moveWithCustomTransform */
        PPtr<Transform> _moveWithCustomTransform = PPtr<Transform>.Read(reader);
        int _scalingMode = reader.ReadS32();
        int _randomSeed = reader.ReadS32();
        InitialModule _InitialModule = InitialModule.Read(reader);
        reader.AlignTo(4); /* ShapeModule */
        ShapeModule _ShapeModule = ShapeModule.Read(reader);
        reader.AlignTo(4); /* EmissionModule */
        EmissionModule _EmissionModule = EmissionModule.Read(reader);
        reader.AlignTo(4); /* SizeModule */
        SizeModule _SizeModule = SizeModule.Read(reader);
        reader.AlignTo(4); /* RotationModule */
        RotationModule _RotationModule = RotationModule.Read(reader);
        reader.AlignTo(4); /* ColorModule */
        ColorModule _ColorModule = ColorModule.Read(reader);
        reader.AlignTo(4); /* UVModule */
        UVModule _UVModule = UVModule.Read(reader);
        reader.AlignTo(4); /* VelocityModule */
        VelocityModule _VelocityModule = VelocityModule.Read(reader);
        reader.AlignTo(4); /* InheritVelocityModule */
        InheritVelocityModule _InheritVelocityModule = InheritVelocityModule.Read(reader);
        reader.AlignTo(4); /* LifetimeByEmitterSpeedModule */
        LifetimeByEmitterSpeedModule _LifetimeByEmitterSpeedModule = LifetimeByEmitterSpeedModule.Read(reader);
        reader.AlignTo(4); /* ForceModule */
        ForceModule _ForceModule = ForceModule.Read(reader);
        reader.AlignTo(4); /* ExternalForcesModule */
        ExternalForcesModule _ExternalForcesModule = ExternalForcesModule.Read(reader);
        reader.AlignTo(4); /* ClampVelocityModule */
        ClampVelocityModule _ClampVelocityModule = ClampVelocityModule.Read(reader);
        reader.AlignTo(4); /* NoiseModule */
        NoiseModule _NoiseModule = NoiseModule.Read(reader);
        reader.AlignTo(4); /* SizeBySpeedModule */
        SizeBySpeedModule _SizeBySpeedModule = SizeBySpeedModule.Read(reader);
        reader.AlignTo(4); /* RotationBySpeedModule */
        RotationBySpeedModule _RotationBySpeedModule = RotationBySpeedModule.Read(reader);
        reader.AlignTo(4); /* ColorBySpeedModule */
        ColorBySpeedModule _ColorBySpeedModule = ColorBySpeedModule.Read(reader);
        reader.AlignTo(4); /* CollisionModule */
        CollisionModule _CollisionModule = CollisionModule.Read(reader);
        reader.AlignTo(4); /* TriggerModule */
        TriggerModule _TriggerModule = TriggerModule.Read(reader);
        reader.AlignTo(4); /* SubModule */
        SubModule _SubModule = SubModule.Read(reader);
        reader.AlignTo(4); /* LightsModule */
        LightsModule _LightsModule = LightsModule.Read(reader);
        reader.AlignTo(4); /* TrailModule */
        TrailModule _TrailModule = TrailModule.Read(reader);
        reader.AlignTo(4); /* CustomDataModule */
        CustomDataModule _CustomDataModule = CustomDataModule.Read(reader);
        
        return new(_m_GameObject,
            _lengthInSec,
            _simulationSpeed,
            _stopAction,
            _cullingMode,
            _ringBufferMode,
            _ringBufferLoopRange,
            _emitterVelocityMode,
            _looping,
            _prewarm,
            _playOnAwake,
            _useUnscaledTime,
            _autoRandomSeed,
            _startDelay,
            _moveWithTransform,
            _moveWithCustomTransform,
            _scalingMode,
            _randomSeed,
            _InitialModule,
            _ShapeModule,
            _EmissionModule,
            _SizeModule,
            _RotationModule,
            _ColorModule,
            _UVModule,
            _VelocityModule,
            _InheritVelocityModule,
            _LifetimeByEmitterSpeedModule,
            _ForceModule,
            _ExternalForcesModule,
            _ClampVelocityModule,
            _NoiseModule,
            _SizeBySpeedModule,
            _RotationBySpeedModule,
            _ColorBySpeedModule,
            _CollisionModule,
            _TriggerModule,
            _SubModule,
            _LightsModule,
            _TrailModule,
            _CustomDataModule);
    }
}

