namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $ParticleSystem (41 fields) ParticleSystem FA711CF463BE239D5FF509B658C95D25 */
public record class ParticleSystem (
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
    InitialModule InitialModule_,
    ShapeModule ShapeModule_,
    EmissionModule EmissionModule_,
    SizeModule SizeModule_,
    RotationModule RotationModule_,
    ColorModule ColorModule_,
    UVModule UVModule_,
    VelocityModule VelocityModule_,
    InheritVelocityModule InheritVelocityModule_,
    LifetimeByEmitterSpeedModule LifetimeByEmitterSpeedModule_,
    ForceModule ForceModule_,
    ExternalForcesModule ExternalForcesModule_,
    ClampVelocityModule ClampVelocityModule_,
    NoiseModule NoiseModule_,
    SizeBySpeedModule SizeBySpeedModule_,
    RotationBySpeedModule RotationBySpeedModule_,
    ColorBySpeedModule ColorBySpeedModule_,
    CollisionModule CollisionModule_,
    TriggerModule TriggerModule_,
    SubModule SubModule_,
    LightsModule LightsModule_,
    TrailModule TrailModule_,
    CustomDataModule CustomDataModule_) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.ParticleSystem;
    public static Hash128 Hash => new("FA711CF463BE239D5FF509B658C95D25");
    public static ParticleSystem Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject_ = PPtr<GameObject>.Read(reader);
        float lengthInSec_ = reader.ReadF32();
        float simulationSpeed_ = reader.ReadF32();
        int stopAction_ = reader.ReadS32();
        int cullingMode_ = reader.ReadS32();
        int ringBufferMode_ = reader.ReadS32();
        Vector2f ringBufferLoopRange_ = Vector2f.Read(reader);
        int emitterVelocityMode_ = reader.ReadS32();
        bool looping_ = reader.ReadBool();
        bool prewarm_ = reader.ReadBool();
        bool playOnAwake_ = reader.ReadBool();
        bool useUnscaledTime_ = reader.ReadBool();
        bool autoRandomSeed_ = reader.ReadBool();
        reader.AlignTo(4); /* autoRandomSeed */
        MinMaxCurve startDelay_ = MinMaxCurve.Read(reader);
        reader.AlignTo(4); /* startDelay */
        int moveWithTransform_ = reader.ReadS32();
        reader.AlignTo(4); /* moveWithTransform */
        PPtr<Transform> moveWithCustomTransform_ = PPtr<Transform>.Read(reader);
        int scalingMode_ = reader.ReadS32();
        int randomSeed_ = reader.ReadS32();
        InitialModule InitialModule__ = InitialModule.Read(reader);
        reader.AlignTo(4); /* InitialModule_ */
        ShapeModule ShapeModule__ = ShapeModule.Read(reader);
        reader.AlignTo(4); /* ShapeModule_ */
        EmissionModule EmissionModule__ = EmissionModule.Read(reader);
        reader.AlignTo(4); /* EmissionModule_ */
        SizeModule SizeModule__ = SizeModule.Read(reader);
        reader.AlignTo(4); /* SizeModule_ */
        RotationModule RotationModule__ = RotationModule.Read(reader);
        reader.AlignTo(4); /* RotationModule_ */
        ColorModule ColorModule__ = ColorModule.Read(reader);
        reader.AlignTo(4); /* ColorModule_ */
        UVModule UVModule__ = UVModule.Read(reader);
        reader.AlignTo(4); /* UVModule_ */
        VelocityModule VelocityModule__ = VelocityModule.Read(reader);
        reader.AlignTo(4); /* VelocityModule_ */
        InheritVelocityModule InheritVelocityModule__ = InheritVelocityModule.Read(reader);
        reader.AlignTo(4); /* InheritVelocityModule_ */
        LifetimeByEmitterSpeedModule LifetimeByEmitterSpeedModule__ = LifetimeByEmitterSpeedModule.Read(reader);
        reader.AlignTo(4); /* LifetimeByEmitterSpeedModule_ */
        ForceModule ForceModule__ = ForceModule.Read(reader);
        reader.AlignTo(4); /* ForceModule_ */
        ExternalForcesModule ExternalForcesModule__ = ExternalForcesModule.Read(reader);
        reader.AlignTo(4); /* ExternalForcesModule_ */
        ClampVelocityModule ClampVelocityModule__ = ClampVelocityModule.Read(reader);
        reader.AlignTo(4); /* ClampVelocityModule_ */
        NoiseModule NoiseModule__ = NoiseModule.Read(reader);
        reader.AlignTo(4); /* NoiseModule_ */
        SizeBySpeedModule SizeBySpeedModule__ = SizeBySpeedModule.Read(reader);
        reader.AlignTo(4); /* SizeBySpeedModule_ */
        RotationBySpeedModule RotationBySpeedModule__ = RotationBySpeedModule.Read(reader);
        reader.AlignTo(4); /* RotationBySpeedModule_ */
        ColorBySpeedModule ColorBySpeedModule__ = ColorBySpeedModule.Read(reader);
        reader.AlignTo(4); /* ColorBySpeedModule_ */
        CollisionModule CollisionModule__ = CollisionModule.Read(reader);
        reader.AlignTo(4); /* CollisionModule_ */
        TriggerModule TriggerModule__ = TriggerModule.Read(reader);
        reader.AlignTo(4); /* TriggerModule_ */
        SubModule SubModule__ = SubModule.Read(reader);
        reader.AlignTo(4); /* SubModule_ */
        LightsModule LightsModule__ = LightsModule.Read(reader);
        reader.AlignTo(4); /* LightsModule_ */
        TrailModule TrailModule__ = TrailModule.Read(reader);
        reader.AlignTo(4); /* TrailModule_ */
        CustomDataModule CustomDataModule__ = CustomDataModule.Read(reader);
        reader.AlignTo(4); /* CustomDataModule_ */
        
        return new(m_GameObject_,
            lengthInSec_,
            simulationSpeed_,
            stopAction_,
            cullingMode_,
            ringBufferMode_,
            ringBufferLoopRange_,
            emitterVelocityMode_,
            looping_,
            prewarm_,
            playOnAwake_,
            useUnscaledTime_,
            autoRandomSeed_,
            startDelay_,
            moveWithTransform_,
            moveWithCustomTransform_,
            scalingMode_,
            randomSeed_,
            InitialModule__,
            ShapeModule__,
            EmissionModule__,
            SizeModule__,
            RotationModule__,
            ColorModule__,
            UVModule__,
            VelocityModule__,
            InheritVelocityModule__,
            LifetimeByEmitterSpeedModule__,
            ForceModule__,
            ExternalForcesModule__,
            ClampVelocityModule__,
            NoiseModule__,
            SizeBySpeedModule__,
            RotationBySpeedModule__,
            ColorBySpeedModule__,
            CollisionModule__,
            TriggerModule__,
            SubModule__,
            LightsModule__,
            TrailModule__,
            CustomDataModule__);
    }

    public override string ToString() => $"ParticleSystem\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);
        ToString_Field15(sb, indent, indent_);
        ToString_Field16(sb, indent, indent_);
        ToString_Field17(sb, indent, indent_);
        ToString_Field18(sb, indent, indent_);
        ToString_Field19(sb, indent, indent_);
        ToString_Field20(sb, indent, indent_);
        ToString_Field21(sb, indent, indent_);
        ToString_Field22(sb, indent, indent_);
        ToString_Field23(sb, indent, indent_);
        ToString_Field24(sb, indent, indent_);
        ToString_Field25(sb, indent, indent_);
        ToString_Field26(sb, indent, indent_);
        ToString_Field27(sb, indent, indent_);
        ToString_Field28(sb, indent, indent_);
        ToString_Field29(sb, indent, indent_);
        ToString_Field30(sb, indent, indent_);
        ToString_Field31(sb, indent, indent_);
        ToString_Field32(sb, indent, indent_);
        ToString_Field33(sb, indent, indent_);
        ToString_Field34(sb, indent, indent_);
        ToString_Field35(sb, indent, indent_);
        ToString_Field36(sb, indent, indent_);
        ToString_Field37(sb, indent, indent_);
        ToString_Field38(sb, indent, indent_);
        ToString_Field39(sb, indent, indent_);
        ToString_Field40(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_GameObject: {m_GameObject}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}lengthInSec: {lengthInSec}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}simulationSpeed: {simulationSpeed}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}stopAction: {stopAction}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}cullingMode: {cullingMode}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}ringBufferMode: {ringBufferMode}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}ringBufferLoopRange: {{ x: {ringBufferLoopRange.x}, y: {ringBufferLoopRange.y} }}\n");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}emitterVelocityMode: {emitterVelocityMode}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}looping: {looping}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}prewarm: {prewarm}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}playOnAwake: {playOnAwake}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}useUnscaledTime: {useUnscaledTime}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}autoRandomSeed: {autoRandomSeed}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}startDelay: {{ \n{startDelay.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}moveWithTransform: {moveWithTransform}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}moveWithCustomTransform: {moveWithCustomTransform}");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}scalingMode: {scalingMode}");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}randomSeed: {randomSeed}");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}InitialModule_: {{ \n{InitialModule_.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field19(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}ShapeModule_: {{ \n{ShapeModule_.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field20(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}EmissionModule_: {{ \n{EmissionModule_.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field21(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}SizeModule_: {{ \n{SizeModule_.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field22(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}RotationModule_: {{ \n{RotationModule_.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field23(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}ColorModule_: {{ \n{ColorModule_.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field24(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}UVModule_: {{ \n{UVModule_.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field25(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}VelocityModule_: {{ \n{VelocityModule_.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field26(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}InheritVelocityModule_: {{ \n{InheritVelocityModule_.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field27(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}LifetimeByEmitterSpeedModule_: {{ \n{LifetimeByEmitterSpeedModule_.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field28(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}ForceModule_: {{ \n{ForceModule_.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field29(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}ExternalForcesModule_: {{ \n{ExternalForcesModule_.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field30(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}ClampVelocityModule_: {{ \n{ClampVelocityModule_.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field31(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}NoiseModule_: {{ \n{NoiseModule_.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field32(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}SizeBySpeedModule_: {{ \n{SizeBySpeedModule_.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field33(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}RotationBySpeedModule_: {{ \n{RotationBySpeedModule_.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field34(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}ColorBySpeedModule_: {{ \n{ColorBySpeedModule_.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field35(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}CollisionModule_: {{ \n{CollisionModule_.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field36(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}TriggerModule_: {{ \n{TriggerModule_.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field37(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}SubModule_: {{ \n{SubModule_.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field38(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}LightsModule_: {{ \n{LightsModule_.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field39(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}TrailModule_: {{ \n{TrailModule_.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field40(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}CustomDataModule_: {{ \n{CustomDataModule_.ToString(indent+4)}{indent_}}}\n");
    }
}

