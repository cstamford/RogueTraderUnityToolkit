namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $ParticleSystem (41 fields) FA711CF463BE239D5FF509B658C95D25 */
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
    InitialModule _InitialModule,
    ShapeModule _ShapeModule,
    EmissionModule _EmissionModule,
    SizeModule _SizeModule,
    RotationModule _RotationModule,
    ColorModule _ColorModule,
    UVModule _UVModule,
    VelocityModule _VelocityModule,
    InheritVelocityModule _InheritVelocityModule,
    LifetimeByEmitterSpeedModule _LifetimeByEmitterSpeedModule,
    ForceModule _ForceModule,
    ExternalForcesModule _ExternalForcesModule,
    ClampVelocityModule _ClampVelocityModule,
    NoiseModule _NoiseModule,
    SizeBySpeedModule _SizeBySpeedModule,
    RotationBySpeedModule _RotationBySpeedModule,
    ColorBySpeedModule _ColorBySpeedModule,
    CollisionModule _CollisionModule,
    TriggerModule _TriggerModule,
    SubModule _SubModule,
    LightsModule _LightsModule,
    TrailModule _TrailModule,
    CustomDataModule _CustomDataModule) : IUnityEngineStructure
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
        reader.AlignTo(4); /* autoRandomSeed */
        MinMaxCurve _startDelay = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* startDelay */
        int _moveWithTransform = reader.ReadS32();
        reader.AlignTo(4); /* moveWithTransform */
        PPtr<Transform> _moveWithCustomTransform = PPtr<Transform>.Read(reader);
        int _scalingMode = reader.ReadS32();
        int _randomSeed = reader.ReadS32();
        InitialModule __InitialModule = InitialModule.Read(reader);
        reader.AlignTo(4); /* _InitialModule */
        ShapeModule __ShapeModule = ShapeModule.Read(reader);
        reader.AlignTo(4); /* _ShapeModule */
        EmissionModule __EmissionModule = EmissionModule.Read(reader);
        reader.AlignTo(4); /* _EmissionModule */
        SizeModule __SizeModule = SizeModule.Read(reader);
        reader.AlignTo(4); /* _SizeModule */
        RotationModule __RotationModule = RotationModule.Read(reader);
        reader.AlignTo(4); /* _RotationModule */
        ColorModule __ColorModule = ColorModule.Read(reader);
        reader.AlignTo(4); /* _ColorModule */
        UVModule __UVModule = UVModule.Read(reader);
        reader.AlignTo(4); /* _UVModule */
        VelocityModule __VelocityModule = VelocityModule.Read(reader);
        reader.AlignTo(4); /* _VelocityModule */
        InheritVelocityModule __InheritVelocityModule = InheritVelocityModule.Read(reader);
        reader.AlignTo(4); /* _InheritVelocityModule */
        LifetimeByEmitterSpeedModule __LifetimeByEmitterSpeedModule = LifetimeByEmitterSpeedModule.Read(reader);
        reader.AlignTo(4); /* _LifetimeByEmitterSpeedModule */
        ForceModule __ForceModule = ForceModule.Read(reader);
        reader.AlignTo(4); /* _ForceModule */
        ExternalForcesModule __ExternalForcesModule = ExternalForcesModule.Read(reader);
        reader.AlignTo(4); /* _ExternalForcesModule */
        ClampVelocityModule __ClampVelocityModule = ClampVelocityModule.Read(reader);
        reader.AlignTo(4); /* _ClampVelocityModule */
        NoiseModule __NoiseModule = NoiseModule.Read(reader);
        reader.AlignTo(4); /* _NoiseModule */
        SizeBySpeedModule __SizeBySpeedModule = SizeBySpeedModule.Read(reader);
        reader.AlignTo(4); /* _SizeBySpeedModule */
        RotationBySpeedModule __RotationBySpeedModule = RotationBySpeedModule.Read(reader);
        reader.AlignTo(4); /* _RotationBySpeedModule */
        ColorBySpeedModule __ColorBySpeedModule = ColorBySpeedModule.Read(reader);
        reader.AlignTo(4); /* _ColorBySpeedModule */
        CollisionModule __CollisionModule = CollisionModule.Read(reader);
        reader.AlignTo(4); /* _CollisionModule */
        TriggerModule __TriggerModule = TriggerModule.Read(reader);
        reader.AlignTo(4); /* _TriggerModule */
        SubModule __SubModule = SubModule.Read(reader);
        reader.AlignTo(4); /* _SubModule */
        LightsModule __LightsModule = LightsModule.Read(reader);
        reader.AlignTo(4); /* _LightsModule */
        TrailModule __TrailModule = TrailModule.Read(reader);
        reader.AlignTo(4); /* _TrailModule */
        CustomDataModule __CustomDataModule = CustomDataModule.Read(reader);
        reader.AlignTo(4); /* _CustomDataModule */
        
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
            __InitialModule,
            __ShapeModule,
            __EmissionModule,
            __SizeModule,
            __RotationModule,
            __ColorModule,
            __UVModule,
            __VelocityModule,
            __InheritVelocityModule,
            __LifetimeByEmitterSpeedModule,
            __ForceModule,
            __ExternalForcesModule,
            __ClampVelocityModule,
            __NoiseModule,
            __SizeBySpeedModule,
            __RotationBySpeedModule,
            __ColorBySpeedModule,
            __CollisionModule,
            __TriggerModule,
            __SubModule,
            __LightsModule,
            __TrailModule,
            __CustomDataModule);
    }

    public override string ToString() => $"ParticleSystem\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GameObject: ");
        sb.AppendLine(m_GameObject.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("lengthInSec: ");
        sb.AppendLine(lengthInSec.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("simulationSpeed: ");
        sb.AppendLine(simulationSpeed.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("stopAction: ");
        sb.AppendLine(stopAction.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("cullingMode: ");
        sb.AppendLine(cullingMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("ringBufferMode: ");
        sb.AppendLine(ringBufferMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("ringBufferLoopRange: ");
        sb.AppendLine();
        sb.Append(ringBufferLoopRange.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("emitterVelocityMode: ");
        sb.AppendLine(emitterVelocityMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("looping: ");
        sb.AppendLine(looping.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("prewarm: ");
        sb.AppendLine(prewarm.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("playOnAwake: ");
        sb.AppendLine(playOnAwake.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("useUnscaledTime: ");
        sb.AppendLine(useUnscaledTime.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("autoRandomSeed: ");
        sb.AppendLine(autoRandomSeed.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("startDelay: ");
        sb.AppendLine();
        sb.Append(startDelay.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("moveWithTransform: ");
        sb.AppendLine(moveWithTransform.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("moveWithCustomTransform: ");
        sb.AppendLine(moveWithCustomTransform.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("scalingMode: ");
        sb.AppendLine(scalingMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("randomSeed: ");
        sb.AppendLine(randomSeed.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("_InitialModule: ");
        sb.AppendLine();
        sb.Append(_InitialModule.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("_ShapeModule: ");
        sb.AppendLine();
        sb.Append(_ShapeModule.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("_EmissionModule: ");
        sb.AppendLine();
        sb.Append(_EmissionModule.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("_SizeModule: ");
        sb.AppendLine();
        sb.Append(_SizeModule.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("_RotationModule: ");
        sb.AppendLine();
        sb.Append(_RotationModule.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("_ColorModule: ");
        sb.AppendLine();
        sb.Append(_ColorModule.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("_UVModule: ");
        sb.AppendLine();
        sb.Append(_UVModule.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("_VelocityModule: ");
        sb.AppendLine();
        sb.Append(_VelocityModule.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("_InheritVelocityModule: ");
        sb.AppendLine();
        sb.Append(_InheritVelocityModule.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("_LifetimeByEmitterSpeedModule: ");
        sb.AppendLine();
        sb.Append(_LifetimeByEmitterSpeedModule.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("_ForceModule: ");
        sb.AppendLine();
        sb.Append(_ForceModule.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("_ExternalForcesModule: ");
        sb.AppendLine();
        sb.Append(_ExternalForcesModule.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("_ClampVelocityModule: ");
        sb.AppendLine();
        sb.Append(_ClampVelocityModule.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("_NoiseModule: ");
        sb.AppendLine();
        sb.Append(_NoiseModule.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("_SizeBySpeedModule: ");
        sb.AppendLine();
        sb.Append(_SizeBySpeedModule.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("_RotationBySpeedModule: ");
        sb.AppendLine();
        sb.Append(_RotationBySpeedModule.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("_ColorBySpeedModule: ");
        sb.AppendLine();
        sb.Append(_ColorBySpeedModule.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("_CollisionModule: ");
        sb.AppendLine();
        sb.Append(_CollisionModule.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("_TriggerModule: ");
        sb.AppendLine();
        sb.Append(_TriggerModule.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("_SubModule: ");
        sb.AppendLine();
        sb.Append(_SubModule.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("_LightsModule: ");
        sb.AppendLine();
        sb.Append(_LightsModule.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("_TrailModule: ");
        sb.AppendLine();
        sb.Append(_TrailModule.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("_CustomDataModule: ");
        sb.AppendLine();
        sb.Append(_CustomDataModule.ToString(indent+4));

        return sb.ToString();
    }
}

