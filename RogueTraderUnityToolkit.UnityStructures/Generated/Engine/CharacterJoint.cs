namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $CharacterJoint (23 fields) (IsEngineType) */
public record class CharacterJoint(
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
    float m_ConnectedMassScale)
{
    public static CharacterJoint Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        PPtr<Rigidbody> m_ConnectedBody = PPtr<Rigidbody>.Read(reader);
        PPtr<ArticulationBody> m_ConnectedArticulationBody = PPtr<ArticulationBody>.Read(reader);
        Vector3f m_Anchor = Vector3f.Read(reader);
        Vector3f m_Axis = Vector3f.Read(reader);
        bool m_AutoConfigureConnectedAnchor = reader.ReadBool();
        Vector3f m_ConnectedAnchor = Vector3f.Read(reader);
        Vector3f m_SwingAxis = Vector3f.Read(reader);
        SoftJointLimitSpring m_TwistLimitSpring = SoftJointLimitSpring.Read(reader);
        SoftJointLimit m_LowTwistLimit = SoftJointLimit.Read(reader);
        SoftJointLimit m_HighTwistLimit = SoftJointLimit.Read(reader);
        SoftJointLimitSpring m_SwingLimitSpring = SoftJointLimitSpring.Read(reader);
        SoftJointLimit m_Swing1Limit = SoftJointLimit.Read(reader);
        SoftJointLimit m_Swing2Limit = SoftJointLimit.Read(reader);
        bool m_EnableProjection = reader.ReadBool();
        float m_ProjectionDistance = reader.ReadF32();
        float m_ProjectionAngle = reader.ReadF32();
        float m_BreakForce = reader.ReadF32();
        float m_BreakTorque = reader.ReadF32();
        bool m_EnableCollision = reader.ReadBool();
        bool m_EnablePreprocessing = reader.ReadBool();
        float m_MassScale = reader.ReadF32();
        float m_ConnectedMassScale = reader.ReadF32();
        
        return new(m_GameObject,
            m_ConnectedBody,
            m_ConnectedArticulationBody,
            m_Anchor,
            m_Axis,
            m_AutoConfigureConnectedAnchor,
            m_ConnectedAnchor,
            m_SwingAxis,
            m_TwistLimitSpring,
            m_LowTwistLimit,
            m_HighTwistLimit,
            m_SwingLimitSpring,
            m_Swing1Limit,
            m_Swing2Limit,
            m_EnableProjection,
            m_ProjectionDistance,
            m_ProjectionAngle,
            m_BreakForce,
            m_BreakTorque,
            m_EnableCollision,
            m_EnablePreprocessing,
            m_MassScale,
            m_ConnectedMassScale);
    }
}

