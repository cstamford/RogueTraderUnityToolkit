namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $CharacterJoint (23 fields) 8A3DB5E65FCB61A57DACFDE8C7813878 */
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
    float m_ConnectedMassScale) : IUnityEngineStructure
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
        reader.AlignTo(4); /* m_AutoConfigureConnectedAnchor */
        Vector3f _m_ConnectedAnchor = Vector3f.Read(reader);
        Vector3f _m_SwingAxis = Vector3f.Read(reader);
        SoftJointLimitSpring _m_TwistLimitSpring = SoftJointLimitSpring.Read(reader);
        SoftJointLimit _m_LowTwistLimit = SoftJointLimit.Read(reader);
        SoftJointLimit _m_HighTwistLimit = SoftJointLimit.Read(reader);
        SoftJointLimitSpring _m_SwingLimitSpring = SoftJointLimitSpring.Read(reader);
        SoftJointLimit _m_Swing1Limit = SoftJointLimit.Read(reader);
        SoftJointLimit _m_Swing2Limit = SoftJointLimit.Read(reader);
        bool _m_EnableProjection = reader.ReadBool();
        reader.AlignTo(4); /* m_EnableProjection */
        float _m_ProjectionDistance = reader.ReadF32();
        float _m_ProjectionAngle = reader.ReadF32();
        float _m_BreakForce = reader.ReadF32();
        float _m_BreakTorque = reader.ReadF32();
        bool _m_EnableCollision = reader.ReadBool();
        bool _m_EnablePreprocessing = reader.ReadBool();
        reader.AlignTo(4); /* m_EnablePreprocessing */
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

    public override string ToString() => $"CharacterJoint\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GameObject: ");
        sb.AppendLine(m_GameObject.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ConnectedBody: ");
        sb.AppendLine(m_ConnectedBody.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ConnectedArticulationBody: ");
        sb.AppendLine(m_ConnectedArticulationBody.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Anchor: ");
        sb.AppendLine();
        sb.Append(m_Anchor.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Axis: ");
        sb.AppendLine();
        sb.Append(m_Axis.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AutoConfigureConnectedAnchor: ");
        sb.AppendLine(m_AutoConfigureConnectedAnchor.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ConnectedAnchor: ");
        sb.AppendLine();
        sb.Append(m_ConnectedAnchor.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SwingAxis: ");
        sb.AppendLine();
        sb.Append(m_SwingAxis.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TwistLimitSpring: ");
        sb.AppendLine();
        sb.Append(m_TwistLimitSpring.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LowTwistLimit: ");
        sb.AppendLine();
        sb.Append(m_LowTwistLimit.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HighTwistLimit: ");
        sb.AppendLine();
        sb.Append(m_HighTwistLimit.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SwingLimitSpring: ");
        sb.AppendLine();
        sb.Append(m_SwingLimitSpring.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Swing1Limit: ");
        sb.AppendLine();
        sb.Append(m_Swing1Limit.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Swing2Limit: ");
        sb.AppendLine();
        sb.Append(m_Swing2Limit.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_EnableProjection: ");
        sb.AppendLine(m_EnableProjection.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ProjectionDistance: ");
        sb.AppendLine(m_ProjectionDistance.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ProjectionAngle: ");
        sb.AppendLine(m_ProjectionAngle.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BreakForce: ");
        sb.AppendLine(m_BreakForce.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BreakTorque: ");
        sb.AppendLine(m_BreakTorque.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_EnableCollision: ");
        sb.AppendLine(m_EnableCollision.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_EnablePreprocessing: ");
        sb.AppendLine(m_EnablePreprocessing.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MassScale: ");
        sb.AppendLine(m_MassScale.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ConnectedMassScale: ");
        sb.AppendLine(m_ConnectedMassScale.ToString());

        return sb.ToString();
    }
}

