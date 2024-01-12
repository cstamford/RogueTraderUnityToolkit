namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $CharacterJoint (23 fields) CharacterJoint 8A3DB5E65FCB61A57DACFDE8C7813878 */
public record class CharacterJoint (
    PPtr<GameObject> m_GameObject,
    PPtr<Rigidbody> m_ConnectedBody,
    PPtr<ArticulationBody> m_ConnectedArticulationBody,
    Vector3f m_Anchor,
    Vector3f m_Axis,
    bool m_AutoConfigureConnectedAnchor,
    Vector3f m_ConnectedAnchor,
    Vector3f m_SwingAxis,
    SoftJointLimitSpring m_TwistLimitSpring,
    SoftJointLimit m_LowTwistLimit,
    SoftJointLimit m_HighTwistLimit,
    SoftJointLimitSpring m_SwingLimitSpring,
    SoftJointLimit m_Swing1Limit,
    SoftJointLimit m_Swing2Limit,
    bool m_EnableProjection,
    float m_ProjectionDistance,
    float m_ProjectionAngle,
    float m_BreakForce,
    float m_BreakTorque,
    bool m_EnableCollision,
    bool m_EnablePreprocessing,
    float m_MassScale,
    float m_ConnectedMassScale) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.CharacterJoint;
    public static Hash128 Hash => new("8A3DB5E65FCB61A57DACFDE8C7813878");
    public static CharacterJoint Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject_ = PPtr<GameObject>.Read(reader);
        PPtr<Rigidbody> m_ConnectedBody_ = PPtr<Rigidbody>.Read(reader);
        PPtr<ArticulationBody> m_ConnectedArticulationBody_ = PPtr<ArticulationBody>.Read(reader);
        Vector3f m_Anchor_ = Vector3f.Read(reader);
        Vector3f m_Axis_ = Vector3f.Read(reader);
        bool m_AutoConfigureConnectedAnchor_ = reader.ReadBool();
        reader.AlignTo(4); /* m_AutoConfigureConnectedAnchor */
        Vector3f m_ConnectedAnchor_ = Vector3f.Read(reader);
        Vector3f m_SwingAxis_ = Vector3f.Read(reader);
        SoftJointLimitSpring m_TwistLimitSpring_ = SoftJointLimitSpring.Read(reader);
        SoftJointLimit m_LowTwistLimit_ = SoftJointLimit.Read(reader);
        SoftJointLimit m_HighTwistLimit_ = SoftJointLimit.Read(reader);
        SoftJointLimitSpring m_SwingLimitSpring_ = SoftJointLimitSpring.Read(reader);
        SoftJointLimit m_Swing1Limit_ = SoftJointLimit.Read(reader);
        SoftJointLimit m_Swing2Limit_ = SoftJointLimit.Read(reader);
        bool m_EnableProjection_ = reader.ReadBool();
        reader.AlignTo(4); /* m_EnableProjection */
        float m_ProjectionDistance_ = reader.ReadF32();
        float m_ProjectionAngle_ = reader.ReadF32();
        float m_BreakForce_ = reader.ReadF32();
        float m_BreakTorque_ = reader.ReadF32();
        bool m_EnableCollision_ = reader.ReadBool();
        bool m_EnablePreprocessing_ = reader.ReadBool();
        reader.AlignTo(4); /* m_EnablePreprocessing */
        float m_MassScale_ = reader.ReadF32();
        float m_ConnectedMassScale_ = reader.ReadF32();
        
        return new(m_GameObject_,
            m_ConnectedBody_,
            m_ConnectedArticulationBody_,
            m_Anchor_,
            m_Axis_,
            m_AutoConfigureConnectedAnchor_,
            m_ConnectedAnchor_,
            m_SwingAxis_,
            m_TwistLimitSpring_,
            m_LowTwistLimit_,
            m_HighTwistLimit_,
            m_SwingLimitSpring_,
            m_Swing1Limit_,
            m_Swing2Limit_,
            m_EnableProjection_,
            m_ProjectionDistance_,
            m_ProjectionAngle_,
            m_BreakForce_,
            m_BreakTorque_,
            m_EnableCollision_,
            m_EnablePreprocessing_,
            m_MassScale_,
            m_ConnectedMassScale_);
    }

    public override string ToString() => $"CharacterJoint\n{ToString(4)}";

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
        sb.AppendLine($"{indent_}m_GameObject: {m_GameObject}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ConnectedBody: {m_ConnectedBody}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ConnectedArticulationBody: {m_ConnectedArticulationBody}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Anchor: {{ x: {m_Anchor.x}, y: {m_Anchor.y}, z: {m_Anchor.z} }}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Axis: {{ x: {m_Axis.x}, y: {m_Axis.y}, z: {m_Axis.z} }}\n");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_AutoConfigureConnectedAnchor: {m_AutoConfigureConnectedAnchor}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ConnectedAnchor: {{ x: {m_ConnectedAnchor.x}, y: {m_ConnectedAnchor.y}, z: {m_ConnectedAnchor.z} }}\n");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_SwingAxis: {{ x: {m_SwingAxis.x}, y: {m_SwingAxis.y}, z: {m_SwingAxis.z} }}\n");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_TwistLimitSpring: {{ spring: {m_TwistLimitSpring.spring}, damper: {m_TwistLimitSpring.damper} }}\n");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_LowTwistLimit: {{ limit: {m_LowTwistLimit.limit}, bounciness: {m_LowTwistLimit.bounciness}, contactDistance: {m_LowTwistLimit.contactDistance} }}\n");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_HighTwistLimit: {{ limit: {m_HighTwistLimit.limit}, bounciness: {m_HighTwistLimit.bounciness}, contactDistance: {m_HighTwistLimit.contactDistance} }}\n");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_SwingLimitSpring: {{ spring: {m_SwingLimitSpring.spring}, damper: {m_SwingLimitSpring.damper} }}\n");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Swing1Limit: {{ limit: {m_Swing1Limit.limit}, bounciness: {m_Swing1Limit.bounciness}, contactDistance: {m_Swing1Limit.contactDistance} }}\n");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Swing2Limit: {{ limit: {m_Swing2Limit.limit}, bounciness: {m_Swing2Limit.bounciness}, contactDistance: {m_Swing2Limit.contactDistance} }}\n");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_EnableProjection: {m_EnableProjection}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ProjectionDistance: {m_ProjectionDistance}");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ProjectionAngle: {m_ProjectionAngle}");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BreakForce: {m_BreakForce}");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BreakTorque: {m_BreakTorque}");
    }

    public void ToString_Field19(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_EnableCollision: {m_EnableCollision}");
    }

    public void ToString_Field20(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_EnablePreprocessing: {m_EnablePreprocessing}");
    }

    public void ToString_Field21(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MassScale: {m_MassScale}");
    }

    public void ToString_Field22(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ConnectedMassScale: {m_ConnectedMassScale}");
    }
}

