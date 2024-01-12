namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Rigidbody (16 fields) Rigidbody 7CDF0ED26B63B4662FF0F7A70274F395 */
public record class Rigidbody (
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
    public static UnityObjectType ObjectType => UnityObjectType.Rigidbody;
    public static Hash128 Hash => new("7CDF0ED26B63B4662FF0F7A70274F395");
    public static Rigidbody Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject_ = PPtr<GameObject>.Read(reader);
        float m_Mass_ = reader.ReadF32();
        float m_Drag_ = reader.ReadF32();
        float m_AngularDrag_ = reader.ReadF32();
        Vector3f m_CenterOfMass_ = Vector3f.Read(reader);
        Vector3f m_InertiaTensor_ = Vector3f.Read(reader);
        Quaternionf m_InertiaRotation_ = Quaternionf.Read(reader);
        BitField m_IncludeLayers_ = BitField.Read(reader);
        BitField m_ExcludeLayers_ = BitField.Read(reader);
        bool m_ImplicitCom_ = reader.ReadBool();
        bool m_ImplicitTensor_ = reader.ReadBool();
        bool m_UseGravity_ = reader.ReadBool();
        bool m_IsKinematic_ = reader.ReadBool();
        byte m_Interpolate_ = reader.ReadU8();
        reader.AlignTo(4); /* m_Interpolate */
        int m_Constraints_ = reader.ReadS32();
        int m_CollisionDetection_ = reader.ReadS32();
        
        return new(m_GameObject_,
            m_Mass_,
            m_Drag_,
            m_AngularDrag_,
            m_CenterOfMass_,
            m_InertiaTensor_,
            m_InertiaRotation_,
            m_IncludeLayers_,
            m_ExcludeLayers_,
            m_ImplicitCom_,
            m_ImplicitTensor_,
            m_UseGravity_,
            m_IsKinematic_,
            m_Interpolate_,
            m_Constraints_,
            m_CollisionDetection_);
    }

    public override string ToString() => $"Rigidbody\n{ToString(4)}";

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

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_GameObject: {m_GameObject}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Mass: {m_Mass}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Drag: {m_Drag}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_AngularDrag: {m_AngularDrag}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_CenterOfMass: {{ x: {m_CenterOfMass.x}, y: {m_CenterOfMass.y}, z: {m_CenterOfMass.z} }}\n");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_InertiaTensor: {{ x: {m_InertiaTensor.x}, y: {m_InertiaTensor.y}, z: {m_InertiaTensor.z} }}\n");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_InertiaRotation: {{ x: {m_InertiaRotation.x}, y: {m_InertiaRotation.y}, z: {m_InertiaRotation.z}, w: {m_InertiaRotation.w} }}\n");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_IncludeLayers: {{ m_Bits: {m_IncludeLayers.m_Bits} }}\n");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ExcludeLayers: {{ m_Bits: {m_ExcludeLayers.m_Bits} }}\n");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ImplicitCom: {m_ImplicitCom}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ImplicitTensor: {m_ImplicitTensor}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UseGravity: {m_UseGravity}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_IsKinematic: {m_IsKinematic}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Interpolate: {m_Interpolate}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Constraints: {m_Constraints}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CollisionDetection: {m_CollisionDetection}");
    }
}

