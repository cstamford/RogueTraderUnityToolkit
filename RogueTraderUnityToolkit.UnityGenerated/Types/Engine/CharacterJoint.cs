namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $CharacterJoint (23 fields) 8A3DB5E65FCB61A57DACFDE8C7813878 */
public record class CharacterJoint(
    PPtr<GameObject> m_GameObject /* None */,
    PPtr<Rigidbody> m_ConnectedBody /* None */,
    PPtr<ArticulationBody> m_ConnectedArticulationBody /* None */,
    Vector3f m_Anchor /* None */,
    Vector3f m_Axis /* None */,
    bool m_AutoConfigureConnectedAnchor /* None */,
    Vector3f m_ConnectedAnchor /* NeedsAlign */,
    Vector3f m_SwingAxis /* None */,
    SoftJointLimitSpring m_TwistLimitSpring /* None */,
    SoftJointLimit m_LowTwistLimit /* None */,
    SoftJointLimit m_HighTwistLimit /* None */,
    SoftJointLimitSpring m_SwingLimitSpring /* None */,
    SoftJointLimit m_Swing1Limit /* None */,
    SoftJointLimit m_Swing2Limit /* None */,
    bool m_EnableProjection /* None */,
    float m_ProjectionDistance /* NeedsAlign */,
    float m_ProjectionAngle /* None */,
    float m_BreakForce /* None */,
    float m_BreakTorque /* None */,
    bool m_EnableCollision /* None */,
    bool m_EnablePreprocessing /* None */,
    float m_MassScale /* NeedsAlign */,
    float m_ConnectedMassScale /* None */) : IUnityObject
{
    public static Hash128 Hash => new(2319300070, 1607164325, 2108489192, 3347134584);
    public static CharacterJoint Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        PPtr<Rigidbody> _m_ConnectedBody = PPtr<Rigidbody>.Read(reader);
        PPtr<ArticulationBody> _m_ConnectedArticulationBody = PPtr<ArticulationBody>.Read(reader);
        Vector3f _m_Anchor = Vector3f.Read(reader);
        Vector3f _m_Axis = Vector3f.Read(reader);
        bool _m_AutoConfigureConnectedAnchor = reader.ReadBool();
        reader.AlignTo(4); /* m_ConnectedAnchor */
        Vector3f _m_ConnectedAnchor = Vector3f.Read(reader);
        Vector3f _m_SwingAxis = Vector3f.Read(reader);
        SoftJointLimitSpring _m_TwistLimitSpring = SoftJointLimitSpring.Read(reader);
        SoftJointLimit _m_LowTwistLimit = SoftJointLimit.Read(reader);
        SoftJointLimit _m_HighTwistLimit = SoftJointLimit.Read(reader);
        SoftJointLimitSpring _m_SwingLimitSpring = SoftJointLimitSpring.Read(reader);
        SoftJointLimit _m_Swing1Limit = SoftJointLimit.Read(reader);
        SoftJointLimit _m_Swing2Limit = SoftJointLimit.Read(reader);
        bool _m_EnableProjection = reader.ReadBool();
        reader.AlignTo(4); /* m_ProjectionDistance */
        float _m_ProjectionDistance = reader.ReadF32();
        float _m_ProjectionAngle = reader.ReadF32();
        float _m_BreakForce = reader.ReadF32();
        float _m_BreakTorque = reader.ReadF32();
        bool _m_EnableCollision = reader.ReadBool();
        bool _m_EnablePreprocessing = reader.ReadBool();
        reader.AlignTo(4); /* m_MassScale */
        float _m_MassScale = reader.ReadF32();
        float _m_ConnectedMassScale = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_ConnectedBody,
            _m_ConnectedArticulationBody,
            _m_Anchor,
            _m_Axis,
            _m_AutoConfigureConnectedAnchor,
            _m_ConnectedAnchor,
            _m_SwingAxis,
            _m_TwistLimitSpring,
            _m_LowTwistLimit,
            _m_HighTwistLimit,
            _m_SwingLimitSpring,
            _m_Swing1Limit,
            _m_Swing2Limit,
            _m_EnableProjection,
            _m_ProjectionDistance,
            _m_ProjectionAngle,
            _m_BreakForce,
            _m_BreakTorque,
            _m_EnableCollision,
            _m_EnablePreprocessing,
            _m_MassScale,
            _m_ConnectedMassScale);
    }
}

