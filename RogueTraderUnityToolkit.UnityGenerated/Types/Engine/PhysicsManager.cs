namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $PhysicsManager (32 fields) PhysicsManager 1D16AAA9354E60D9E85DBFDFE3F95BB8 */
public record class PhysicsManager (
    Vector3f m_Gravity,
    PPtr<PhysicMaterial> m_DefaultMaterial,
    float m_BounceThreshold,
    float m_DefaultMaxDepenetrationVelocity,
    float m_SleepThreshold,
    float m_DefaultContactOffset,
    int m_DefaultSolverIterations,
    int m_DefaultSolverVelocityIterations,
    bool m_QueriesHitBackfaces,
    bool m_QueriesHitTriggers,
    bool m_EnableAdaptiveForce,
    float m_ClothInterCollisionDistance,
    float m_ClothInterCollisionStiffness,
    int m_ContactsGeneration,
    uint[] m_LayerCollisionMatrix,
    int m_SimulationMode,
    bool m_AutoSyncTransforms,
    bool m_ReuseCollisionCallbacks,
    bool m_InvokeCollisionCallbacks,
    bool m_ClothInterCollisionSettingsToggle,
    Vector3f m_ClothGravity,
    int m_ContactPairsMode,
    int m_BroadphaseType,
    AABB m_WorldBounds,
    int m_WorldSubdivisions,
    int m_FrictionType,
    bool m_EnableEnhancedDeterminism,
    bool m_EnableUnifiedHeightmaps,
    bool m_ImprovedPatchFriction,
    int m_SolverType,
    float m_DefaultMaxAngularSpeed,
    float m_FastMotionThreshold) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.PhysicsManager;
    public static Hash128 Hash => new("1D16AAA9354E60D9E85DBFDFE3F95BB8");
    public static PhysicsManager Read(EndianBinaryReader reader)
    {
        Vector3f m_Gravity_ = Vector3f.Read(reader);
        PPtr<PhysicMaterial> m_DefaultMaterial_ = PPtr<PhysicMaterial>.Read(reader);
        float m_BounceThreshold_ = reader.ReadF32();
        float m_DefaultMaxDepenetrationVelocity_ = reader.ReadF32();
        float m_SleepThreshold_ = reader.ReadF32();
        float m_DefaultContactOffset_ = reader.ReadF32();
        int m_DefaultSolverIterations_ = reader.ReadS32();
        int m_DefaultSolverVelocityIterations_ = reader.ReadS32();
        bool m_QueriesHitBackfaces_ = reader.ReadBool();
        bool m_QueriesHitTriggers_ = reader.ReadBool();
        bool m_EnableAdaptiveForce_ = reader.ReadBool();
        reader.AlignTo(4); /* m_EnableAdaptiveForce */
        float m_ClothInterCollisionDistance_ = reader.ReadF32();
        float m_ClothInterCollisionStiffness_ = reader.ReadF32();
        int m_ContactsGeneration_ = reader.ReadS32();
        reader.AlignTo(4); /* m_ContactsGeneration */
        uint[] m_LayerCollisionMatrix_ = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* m_LayerCollisionMatrix */
        int m_SimulationMode_ = reader.ReadS32();
        reader.AlignTo(4); /* m_SimulationMode */
        bool m_AutoSyncTransforms_ = reader.ReadBool();
        bool m_ReuseCollisionCallbacks_ = reader.ReadBool();
        bool m_InvokeCollisionCallbacks_ = reader.ReadBool();
        bool m_ClothInterCollisionSettingsToggle_ = reader.ReadBool();
        reader.AlignTo(4); /* m_ClothInterCollisionSettingsToggle */
        Vector3f m_ClothGravity_ = Vector3f.Read(reader);
        int m_ContactPairsMode_ = reader.ReadS32();
        int m_BroadphaseType_ = reader.ReadS32();
        AABB m_WorldBounds_ = AABB.Read(reader);
        int m_WorldSubdivisions_ = reader.ReadS32();
        int m_FrictionType_ = reader.ReadS32();
        bool m_EnableEnhancedDeterminism_ = reader.ReadBool();
        bool m_EnableUnifiedHeightmaps_ = reader.ReadBool();
        bool m_ImprovedPatchFriction_ = reader.ReadBool();
        reader.AlignTo(4); /* m_ImprovedPatchFriction */
        int m_SolverType_ = reader.ReadS32();
        reader.AlignTo(4); /* m_SolverType */
        float m_DefaultMaxAngularSpeed_ = reader.ReadF32();
        float m_FastMotionThreshold_ = reader.ReadF32();
        
        return new(m_Gravity_,
            m_DefaultMaterial_,
            m_BounceThreshold_,
            m_DefaultMaxDepenetrationVelocity_,
            m_SleepThreshold_,
            m_DefaultContactOffset_,
            m_DefaultSolverIterations_,
            m_DefaultSolverVelocityIterations_,
            m_QueriesHitBackfaces_,
            m_QueriesHitTriggers_,
            m_EnableAdaptiveForce_,
            m_ClothInterCollisionDistance_,
            m_ClothInterCollisionStiffness_,
            m_ContactsGeneration_,
            m_LayerCollisionMatrix_,
            m_SimulationMode_,
            m_AutoSyncTransforms_,
            m_ReuseCollisionCallbacks_,
            m_InvokeCollisionCallbacks_,
            m_ClothInterCollisionSettingsToggle_,
            m_ClothGravity_,
            m_ContactPairsMode_,
            m_BroadphaseType_,
            m_WorldBounds_,
            m_WorldSubdivisions_,
            m_FrictionType_,
            m_EnableEnhancedDeterminism_,
            m_EnableUnifiedHeightmaps_,
            m_ImprovedPatchFriction_,
            m_SolverType_,
            m_DefaultMaxAngularSpeed_,
            m_FastMotionThreshold_);
    }

    public override string ToString() => $"PhysicsManager\n{ToString(4)}";

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

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Gravity: {{ x: {m_Gravity.x}, y: {m_Gravity.y}, z: {m_Gravity.z} }}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DefaultMaterial: {m_DefaultMaterial}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BounceThreshold: {m_BounceThreshold}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DefaultMaxDepenetrationVelocity: {m_DefaultMaxDepenetrationVelocity}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SleepThreshold: {m_SleepThreshold}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DefaultContactOffset: {m_DefaultContactOffset}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DefaultSolverIterations: {m_DefaultSolverIterations}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DefaultSolverVelocityIterations: {m_DefaultSolverVelocityIterations}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_QueriesHitBackfaces: {m_QueriesHitBackfaces}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_QueriesHitTriggers: {m_QueriesHitTriggers}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_EnableAdaptiveForce: {m_EnableAdaptiveForce}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ClothInterCollisionDistance: {m_ClothInterCollisionDistance}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ClothInterCollisionStiffness: {m_ClothInterCollisionStiffness}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ContactsGeneration: {m_ContactsGeneration}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
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

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SimulationMode: {m_SimulationMode}");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_AutoSyncTransforms: {m_AutoSyncTransforms}");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ReuseCollisionCallbacks: {m_ReuseCollisionCallbacks}");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_InvokeCollisionCallbacks: {m_InvokeCollisionCallbacks}");
    }

    public void ToString_Field19(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ClothInterCollisionSettingsToggle: {m_ClothInterCollisionSettingsToggle}");
    }

    public void ToString_Field20(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ClothGravity: {{ x: {m_ClothGravity.x}, y: {m_ClothGravity.y}, z: {m_ClothGravity.z} }}\n");
    }

    public void ToString_Field21(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ContactPairsMode: {m_ContactPairsMode}");
    }

    public void ToString_Field22(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BroadphaseType: {m_BroadphaseType}");
    }

    public void ToString_Field23(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_WorldBounds: {{ \n{m_WorldBounds.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field24(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_WorldSubdivisions: {m_WorldSubdivisions}");
    }

    public void ToString_Field25(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_FrictionType: {m_FrictionType}");
    }

    public void ToString_Field26(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_EnableEnhancedDeterminism: {m_EnableEnhancedDeterminism}");
    }

    public void ToString_Field27(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_EnableUnifiedHeightmaps: {m_EnableUnifiedHeightmaps}");
    }

    public void ToString_Field28(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ImprovedPatchFriction: {m_ImprovedPatchFriction}");
    }

    public void ToString_Field29(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SolverType: {m_SolverType}");
    }

    public void ToString_Field30(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DefaultMaxAngularSpeed: {m_DefaultMaxAngularSpeed}");
    }

    public void ToString_Field31(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_FastMotionThreshold: {m_FastMotionThreshold}");
    }
}

