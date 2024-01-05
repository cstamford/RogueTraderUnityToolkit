namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Rigidbody (16 fields) 7CDF0ED26B63B4662FF0F7A70274F395 */
public record class Rigidbody(
    PPtr<GameObject> m_GameObject,
    float m_Mass,
    float m_Drag,
    float m_AngularDrag,
    Vector3f m_CenterOfMass,
    Vector3f m_InertiaTensor,
    Quaternionf m_InertiaRotation,
    BitField m_IncludeLayers,
    BitField m_ExcludeLayers,
    bool m_ImplicitCom,
    bool m_ImplicitTensor,
    bool m_UseGravity,
    bool m_IsKinematic,
    byte m_Interpolate,
    int m_Constraints,
    int m_CollisionDetection) : IUnityEngineStructure
{
    public static Hash128 Hash => new(2094993106, 1801696358, 804321191, 41218965);

    public static Rigidbody Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        float _m_Mass = reader.ReadF32();
        float _m_Drag = reader.ReadF32();
        float _m_AngularDrag = reader.ReadF32();
        Vector3f _m_CenterOfMass = Vector3f.Read(reader);
        Vector3f _m_InertiaTensor = Vector3f.Read(reader);
        Quaternionf _m_InertiaRotation = Quaternionf.Read(reader);
        BitField _m_IncludeLayers = BitField.Read(reader);
        BitField _m_ExcludeLayers = BitField.Read(reader);
        bool _m_ImplicitCom = reader.ReadBool();
        bool _m_ImplicitTensor = reader.ReadBool();
        bool _m_UseGravity = reader.ReadBool();
        bool _m_IsKinematic = reader.ReadBool();
        byte _m_Interpolate = reader.ReadU8();
        reader.AlignTo(4); /* m_Interpolate */
        int _m_Constraints = reader.ReadS32();
        int _m_CollisionDetection = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Mass,
            _m_Drag,
            _m_AngularDrag,
            _m_CenterOfMass,
            _m_InertiaTensor,
            _m_InertiaRotation,
            _m_IncludeLayers,
            _m_ExcludeLayers,
            _m_ImplicitCom,
            _m_ImplicitTensor,
            _m_UseGravity,
            _m_IsKinematic,
            _m_Interpolate,
            _m_Constraints,
            _m_CollisionDetection);
    }

    public override string ToString() => $"Rigidbody\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GameObject: ");
        sb.AppendLine(m_GameObject.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Mass: ");
        sb.AppendLine(m_Mass.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Drag: ");
        sb.AppendLine(m_Drag.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AngularDrag: ");
        sb.AppendLine(m_AngularDrag.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CenterOfMass: ");
        sb.AppendLine();
        sb.Append(m_CenterOfMass.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_InertiaTensor: ");
        sb.AppendLine();
        sb.Append(m_InertiaTensor.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_InertiaRotation: ");
        sb.AppendLine();
        sb.Append(m_InertiaRotation.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IncludeLayers: ");
        sb.AppendLine();
        sb.Append(m_IncludeLayers.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ExcludeLayers: ");
        sb.AppendLine();
        sb.Append(m_ExcludeLayers.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ImplicitCom: ");
        sb.AppendLine(m_ImplicitCom.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ImplicitTensor: ");
        sb.AppendLine(m_ImplicitTensor.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_UseGravity: ");
        sb.AppendLine(m_UseGravity.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IsKinematic: ");
        sb.AppendLine(m_IsKinematic.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Interpolate: ");
        sb.AppendLine(m_Interpolate.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Constraints: ");
        sb.AppendLine(m_Constraints.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CollisionDetection: ");
        sb.AppendLine(m_CollisionDetection.ToString());

        return sb.ToString();
    }
}

