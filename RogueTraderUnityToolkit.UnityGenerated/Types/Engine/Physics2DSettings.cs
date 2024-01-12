namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Physics2DSettings (23 fields) Physics2DSettings 367DF3D0A75E97FC985A7D933391DAFB */
public record class Physics2DSettings (
    Vector2f m_Gravity,
    PPtr<PhysicsMaterial2D> m_DefaultMaterial,
    int m_VelocityIterations,
    int m_PositionIterations,
    float m_VelocityThreshold,
    float m_MaxLinearCorrection,
    float m_MaxAngularCorrection,
    float m_MaxTranslationSpeed,
    float m_MaxRotationSpeed,
    float m_BaumgarteScale,
    float m_BaumgarteTimeOfImpactScale,
    float m_TimeToSleep,
    float m_LinearSleepTolerance,
    float m_AngularSleepTolerance,
    float m_DefaultContactOffset,
    PhysicsJobOptions2D m_JobOptions,
    int m_SimulationMode,
    bool m_QueriesHitTriggers,
    bool m_QueriesStartInColliders,
    bool m_CallbacksOnDisable,
    bool m_ReuseCollisionCallbacks,
    bool m_AutoSyncTransforms,
    uint[] m_LayerCollisionMatrix) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.Physics2DSettings;
    public static Hash128 Hash => new("367DF3D0A75E97FC985A7D933391DAFB");
    public static Physics2DSettings Read(EndianBinaryReader reader)
    {
        Vector2f m_Gravity_ = Vector2f.Read(reader);
        PPtr<PhysicsMaterial2D> m_DefaultMaterial_ = PPtr<PhysicsMaterial2D>.Read(reader);
        int m_VelocityIterations_ = reader.ReadS32();
        int m_PositionIterations_ = reader.ReadS32();
        float m_VelocityThreshold_ = reader.ReadF32();
        float m_MaxLinearCorrection_ = reader.ReadF32();
        float m_MaxAngularCorrection_ = reader.ReadF32();
        float m_MaxTranslationSpeed_ = reader.ReadF32();
        float m_MaxRotationSpeed_ = reader.ReadF32();
        float m_BaumgarteScale_ = reader.ReadF32();
        float m_BaumgarteTimeOfImpactScale_ = reader.ReadF32();
        float m_TimeToSleep_ = reader.ReadF32();
        float m_LinearSleepTolerance_ = reader.ReadF32();
        float m_AngularSleepTolerance_ = reader.ReadF32();
        float m_DefaultContactOffset_ = reader.ReadF32();
        PhysicsJobOptions2D m_JobOptions_ = PhysicsJobOptions2D.Read(reader);
        reader.AlignTo(4); /* m_JobOptions */
        int m_SimulationMode_ = reader.ReadS32();
        bool m_QueriesHitTriggers_ = reader.ReadBool();
        bool m_QueriesStartInColliders_ = reader.ReadBool();
        bool m_CallbacksOnDisable_ = reader.ReadBool();
        bool m_ReuseCollisionCallbacks_ = reader.ReadBool();
        bool m_AutoSyncTransforms_ = reader.ReadBool();
        reader.AlignTo(4); /* m_AutoSyncTransforms */
        uint[] m_LayerCollisionMatrix_ = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* m_LayerCollisionMatrix */
        
        return new(m_Gravity_,
            m_DefaultMaterial_,
            m_VelocityIterations_,
            m_PositionIterations_,
            m_VelocityThreshold_,
            m_MaxLinearCorrection_,
            m_MaxAngularCorrection_,
            m_MaxTranslationSpeed_,
            m_MaxRotationSpeed_,
            m_BaumgarteScale_,
            m_BaumgarteTimeOfImpactScale_,
            m_TimeToSleep_,
            m_LinearSleepTolerance_,
            m_AngularSleepTolerance_,
            m_DefaultContactOffset_,
            m_JobOptions_,
            m_SimulationMode_,
            m_QueriesHitTriggers_,
            m_QueriesStartInColliders_,
            m_CallbacksOnDisable_,
            m_ReuseCollisionCallbacks_,
            m_AutoSyncTransforms_,
            m_LayerCollisionMatrix_);
    }

    public override string ToString() => $"Physics2DSettings\n{ToString(4)}";

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

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Gravity: {{ x: {m_Gravity.x}, y: {m_Gravity.y} }}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DefaultMaterial: {m_DefaultMaterial}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_VelocityIterations: {m_VelocityIterations}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PositionIterations: {m_PositionIterations}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_VelocityThreshold: {m_VelocityThreshold}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MaxLinearCorrection: {m_MaxLinearCorrection}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MaxAngularCorrection: {m_MaxAngularCorrection}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MaxTranslationSpeed: {m_MaxTranslationSpeed}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MaxRotationSpeed: {m_MaxRotationSpeed}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BaumgarteScale: {m_BaumgarteScale}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BaumgarteTimeOfImpactScale: {m_BaumgarteTimeOfImpactScale}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TimeToSleep: {m_TimeToSleep}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LinearSleepTolerance: {m_LinearSleepTolerance}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_AngularSleepTolerance: {m_AngularSleepTolerance}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DefaultContactOffset: {m_DefaultContactOffset}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_JobOptions: {{ \n{m_JobOptions.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SimulationMode: {m_SimulationMode}");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_QueriesHitTriggers: {m_QueriesHitTriggers}");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_QueriesStartInColliders: {m_QueriesStartInColliders}");
    }

    public void ToString_Field19(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CallbacksOnDisable: {m_CallbacksOnDisable}");
    }

    public void ToString_Field20(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ReuseCollisionCallbacks: {m_ReuseCollisionCallbacks}");
    }

    public void ToString_Field21(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_AutoSyncTransforms: {m_AutoSyncTransforms}");
    }

    public void ToString_Field22(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_LayerCollisionMatrix[{m_LayerCollisionMatrix.Length}] = {{");
        if (m_LayerCollisionMatrix.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint _4 in m_LayerCollisionMatrix)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_LayerCollisionMatrix.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

