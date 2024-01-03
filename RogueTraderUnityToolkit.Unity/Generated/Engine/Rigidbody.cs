namespace RogueTraderUnityToolkit.Unity.Generated.Engine;

using Core;

/* $Rigidbody (16 fields) (IsEngineType) */
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
    int m_CollisionDetection)
{
    public static Rigidbody Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        float m_Mass = reader.ReadF32();
        float m_Drag = reader.ReadF32();
        float m_AngularDrag = reader.ReadF32();
        Vector3f m_CenterOfMass = Vector3f.Read(reader);
        Vector3f m_InertiaTensor = Vector3f.Read(reader);
        Quaternionf m_InertiaRotation = Quaternionf.Read(reader);
        BitField m_IncludeLayers = BitField.Read(reader);
        BitField m_ExcludeLayers = BitField.Read(reader);
        bool m_ImplicitCom = reader.ReadBool();
        bool m_ImplicitTensor = reader.ReadBool();
        bool m_UseGravity = reader.ReadBool();
        bool m_IsKinematic = reader.ReadBool();
        byte m_Interpolate = reader.ReadU8();
        int m_Constraints = reader.ReadS32();
        int m_CollisionDetection = reader.ReadS32();
        
        return new(m_GameObject,
            m_Mass,
            m_Drag,
            m_AngularDrag,
            m_CenterOfMass,
            m_InertiaTensor,
            m_InertiaRotation,
            m_IncludeLayers,
            m_ExcludeLayers,
            m_ImplicitCom,
            m_ImplicitTensor,
            m_UseGravity,
            m_IsKinematic,
            m_Interpolate,
            m_Constraints,
            m_CollisionDetection);
    }
}

