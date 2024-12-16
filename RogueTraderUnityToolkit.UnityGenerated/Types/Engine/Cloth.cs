namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Cloth (25 fields) Cloth 5AC9B18A3ADACD763E2617346F7688C6 */
public record class Cloth (
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    float m_StretchingStiffness,
    float m_BendingStiffness,
    bool m_UseTethers,
    bool m_UseGravity,
    float m_Damping,
    Vector3f m_ExternalAcceleration,
    Vector3f m_RandomAcceleration,
    float m_WorldVelocityScale,
    float m_WorldAccelerationScale,
    float m_Friction,
    float m_CollisionMassScale,
    bool m_UseContinuousCollision,
    bool m_UseVirtualParticles,
    float m_SolverFrequency,
    float m_SleepThreshold,
    ClothConstrainCoefficients[] m_Coefficients,
    PPtr<CapsuleCollider>[] m_CapsuleColliders,
    ClothSphereColliderPair[] m_SphereColliders,
    float m_SelfCollisionDistance,
    float m_SelfCollisionStiffness,
    uint[] m_SelfAndInterCollisionIndices,
    Vector3f[] m_VirtualParticleWeights,
    uint[] m_VirtualParticleIndices) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.Cloth;
    public static Hash128 Hash => new("5AC9B18A3ADACD763E2617346F7688C6");
    public static Cloth Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject_ = PPtr<GameObject>.Read(reader);
        byte m_Enabled_ = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        float m_StretchingStiffness_ = reader.ReadF32();
        float m_BendingStiffness_ = reader.ReadF32();
        bool m_UseTethers_ = reader.ReadBool();
        bool m_UseGravity_ = reader.ReadBool();
        reader.AlignTo(4); /* m_UseGravity */
        float m_Damping_ = reader.ReadF32();
        Vector3f m_ExternalAcceleration_ = Vector3f.Read(reader);
        Vector3f m_RandomAcceleration_ = Vector3f.Read(reader);
        float m_WorldVelocityScale_ = reader.ReadF32();
        float m_WorldAccelerationScale_ = reader.ReadF32();
        float m_Friction_ = reader.ReadF32();
        float m_CollisionMassScale_ = reader.ReadF32();
        bool m_UseContinuousCollision_ = reader.ReadBool();
        bool m_UseVirtualParticles_ = reader.ReadBool();
        reader.AlignTo(4); /* m_UseVirtualParticles */
        float m_SolverFrequency_ = reader.ReadF32();
        float m_SleepThreshold_ = reader.ReadF32();
        ClothConstrainCoefficients[] m_Coefficients_ = BuiltInArray<ClothConstrainCoefficients>.Read(reader);
        reader.AlignTo(4); /* m_Coefficients */
        PPtr<CapsuleCollider>[] m_CapsuleColliders_ = BuiltInArray<PPtr<CapsuleCollider>>.Read(reader);
        reader.AlignTo(4); /* m_CapsuleColliders */
        ClothSphereColliderPair[] m_SphereColliders_ = BuiltInArray<ClothSphereColliderPair>.Read(reader);
        reader.AlignTo(4); /* m_SphereColliders */
        float m_SelfCollisionDistance_ = reader.ReadF32();
        float m_SelfCollisionStiffness_ = reader.ReadF32();
        uint[] m_SelfAndInterCollisionIndices_ = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* m_SelfAndInterCollisionIndices */
        Vector3f[] m_VirtualParticleWeights_ = BuiltInArray<Vector3f>.Read(reader);
        reader.AlignTo(4); /* m_VirtualParticleWeights */
        uint[] m_VirtualParticleIndices_ = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* m_VirtualParticleIndices */
        
        return new(m_GameObject_,
            m_Enabled_,
            m_StretchingStiffness_,
            m_BendingStiffness_,
            m_UseTethers_,
            m_UseGravity_,
            m_Damping_,
            m_ExternalAcceleration_,
            m_RandomAcceleration_,
            m_WorldVelocityScale_,
            m_WorldAccelerationScale_,
            m_Friction_,
            m_CollisionMassScale_,
            m_UseContinuousCollision_,
            m_UseVirtualParticles_,
            m_SolverFrequency_,
            m_SleepThreshold_,
            m_Coefficients_,
            m_CapsuleColliders_,
            m_SphereColliders_,
            m_SelfCollisionDistance_,
            m_SelfCollisionStiffness_,
            m_SelfAndInterCollisionIndices_,
            m_VirtualParticleWeights_,
            m_VirtualParticleIndices_);
    }

    public override string ToString() => $"Cloth\n{ToString(4)}";

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

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_GameObject: {m_GameObject}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Enabled: {m_Enabled}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_StretchingStiffness: {m_StretchingStiffness}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BendingStiffness: {m_BendingStiffness}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UseTethers: {m_UseTethers}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UseGravity: {m_UseGravity}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Damping: {m_Damping}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ExternalAcceleration: {{ x: {m_ExternalAcceleration.x}, y: {m_ExternalAcceleration.y}, z: {m_ExternalAcceleration.z} }}\n");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_RandomAcceleration: {{ x: {m_RandomAcceleration.x}, y: {m_RandomAcceleration.y}, z: {m_RandomAcceleration.z} }}\n");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_WorldVelocityScale: {m_WorldVelocityScale}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_WorldAccelerationScale: {m_WorldAccelerationScale}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Friction: {m_Friction}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CollisionMassScale: {m_CollisionMassScale}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UseContinuousCollision: {m_UseContinuousCollision}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UseVirtualParticles: {m_UseVirtualParticles}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SolverFrequency: {m_SolverFrequency}");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SleepThreshold: {m_SleepThreshold}");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Coefficients[{m_Coefficients.Length}] = {{");
        if (m_Coefficients.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (ClothConstrainCoefficients _4 in m_Coefficients)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ maxDistance: {_4.maxDistance}, collisionSphereDistance: {_4.collisionSphereDistance} }}\n");
            ++_4i;
        }
        if (m_Coefficients.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_CapsuleColliders[{m_CapsuleColliders.Length}] = {{");
        if (m_CapsuleColliders.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtr<CapsuleCollider> _4 in m_CapsuleColliders)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_CapsuleColliders.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field19(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_SphereColliders[{m_SphereColliders.Length}] = {{");
        if (m_SphereColliders.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (ClothSphereColliderPair _4 in m_SphereColliders)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_SphereColliders.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field20(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SelfCollisionDistance: {m_SelfCollisionDistance}");
    }

    public void ToString_Field21(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SelfCollisionStiffness: {m_SelfCollisionStiffness}");
    }

    public void ToString_Field22(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_SelfAndInterCollisionIndices[{m_SelfAndInterCollisionIndices.Length}] = {{");
        if (m_SelfAndInterCollisionIndices.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint _4 in m_SelfAndInterCollisionIndices)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_SelfAndInterCollisionIndices.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field23(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_VirtualParticleWeights[{m_VirtualParticleWeights.Length}] = {{");
        if (m_VirtualParticleWeights.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (Vector3f _4 in m_VirtualParticleWeights)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ x: {_4.x}, y: {_4.y}, z: {_4.z} }}\n");
            ++_4i;
        }
        if (m_VirtualParticleWeights.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field24(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_VirtualParticleIndices[{m_VirtualParticleIndices.Length}] = {{");
        if (m_VirtualParticleIndices.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint _4 in m_VirtualParticleIndices)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_VirtualParticleIndices.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

