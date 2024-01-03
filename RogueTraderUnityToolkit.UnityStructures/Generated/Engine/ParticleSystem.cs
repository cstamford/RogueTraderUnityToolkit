namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $ParticleSystem (41 fields) (IsEngineType) */
public record class ParticleSystem(
    PPtr<GameObject> m_GameObject,
    float lengthInSec,
    float simulationSpeed,
    int stopAction,
    int cullingMode,
    int ringBufferMode,
    Vector2f ringBufferLoopRange,
    int emitterVelocityMode,
    bool looping,
    bool prewarm,
    bool playOnAwake,
    bool useUnscaledTime,
    bool autoRandomSeed,
    MinMaxCurve startDelay,
    int moveWithTransform,
    PPtr<Transform> moveWithCustomTransform,
    int scalingMode,
    int randomSeed,
    InitialModule InitialModule,
    ShapeModule ShapeModule,
    EmissionModule EmissionModule,
    SizeModule SizeModule,
    RotationModule RotationModule,
    ColorModule ColorModule,
    UVModule UVModule,
    VelocityModule VelocityModule,
    InheritVelocityModule InheritVelocityModule,
    LifetimeByEmitterSpeedModule LifetimeByEmitterSpeedModule,
    ForceModule ForceModule,
    ExternalForcesModule ExternalForcesModule,
    ClampVelocityModule ClampVelocityModule,
    NoiseModule NoiseModule,
    SizeBySpeedModule SizeBySpeedModule,
    RotationBySpeedModule RotationBySpeedModule,
    ColorBySpeedModule ColorBySpeedModule,
    CollisionModule CollisionModule,
    TriggerModule TriggerModule,
    SubModule SubModule,
    LightsModule LightsModule,
    TrailModule TrailModule,
    CustomDataModule CustomDataModule)
{
    public static ParticleSystem Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        float lengthInSec = reader.ReadF32();
        float simulationSpeed = reader.ReadF32();
        int stopAction = reader.ReadS32();
        int cullingMode = reader.ReadS32();
        int ringBufferMode = reader.ReadS32();
        Vector2f ringBufferLoopRange = Vector2f.Read(reader);
        int emitterVelocityMode = reader.ReadS32();
        bool looping = reader.ReadBool();
        bool prewarm = reader.ReadBool();
        bool playOnAwake = reader.ReadBool();
        bool useUnscaledTime = reader.ReadBool();
        bool autoRandomSeed = reader.ReadBool();
        MinMaxCurve startDelay = MinMaxCurve.Read(reader);
        int moveWithTransform = reader.ReadS32();
        PPtr<Transform> moveWithCustomTransform = PPtr<Transform>.Read(reader);
        int scalingMode = reader.ReadS32();
        int randomSeed = reader.ReadS32();
        InitialModule InitialModule = InitialModule.Read(reader);
        ShapeModule ShapeModule = ShapeModule.Read(reader);
        EmissionModule EmissionModule = EmissionModule.Read(reader);
        SizeModule SizeModule = SizeModule.Read(reader);
        RotationModule RotationModule = RotationModule.Read(reader);
        ColorModule ColorModule = ColorModule.Read(reader);
        UVModule UVModule = UVModule.Read(reader);
        VelocityModule VelocityModule = VelocityModule.Read(reader);
        InheritVelocityModule InheritVelocityModule = InheritVelocityModule.Read(reader);
        LifetimeByEmitterSpeedModule LifetimeByEmitterSpeedModule = LifetimeByEmitterSpeedModule.Read(reader);
        ForceModule ForceModule = ForceModule.Read(reader);
        ExternalForcesModule ExternalForcesModule = ExternalForcesModule.Read(reader);
        ClampVelocityModule ClampVelocityModule = ClampVelocityModule.Read(reader);
        NoiseModule NoiseModule = NoiseModule.Read(reader);
        SizeBySpeedModule SizeBySpeedModule = SizeBySpeedModule.Read(reader);
        RotationBySpeedModule RotationBySpeedModule = RotationBySpeedModule.Read(reader);
        ColorBySpeedModule ColorBySpeedModule = ColorBySpeedModule.Read(reader);
        CollisionModule CollisionModule = CollisionModule.Read(reader);
        TriggerModule TriggerModule = TriggerModule.Read(reader);
        SubModule SubModule = SubModule.Read(reader);
        LightsModule LightsModule = LightsModule.Read(reader);
        TrailModule TrailModule = TrailModule.Read(reader);
        CustomDataModule CustomDataModule = CustomDataModule.Read(reader);
        
        return new(m_GameObject,
            lengthInSec,
            simulationSpeed,
            stopAction,
            cullingMode,
            ringBufferMode,
            ringBufferLoopRange,
            emitterVelocityMode,
            looping,
            prewarm,
            playOnAwake,
            useUnscaledTime,
            autoRandomSeed,
            startDelay,
            moveWithTransform,
            moveWithCustomTransform,
            scalingMode,
            randomSeed,
            InitialModule,
            ShapeModule,
            EmissionModule,
            SizeModule,
            RotationModule,
            ColorModule,
            UVModule,
            VelocityModule,
            InheritVelocityModule,
            LifetimeByEmitterSpeedModule,
            ForceModule,
            ExternalForcesModule,
            ClampVelocityModule,
            NoiseModule,
            SizeBySpeedModule,
            RotationBySpeedModule,
            ColorBySpeedModule,
            CollisionModule,
            TriggerModule,
            SubModule,
            LightsModule,
            TrailModule,
            CustomDataModule);
    }
}

