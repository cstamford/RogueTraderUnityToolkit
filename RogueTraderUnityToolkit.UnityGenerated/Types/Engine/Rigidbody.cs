namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $Rigidbody (16 fields) 7CDF0ED26B63B4662FF0F7A70274F395 */
public record class Rigidbody(
    PPtr<GameObject> m_GameObject /* None */,
    float m_Mass /* None */,
    float m_Drag /* None */,
    float m_AngularDrag /* None */,
    Vector3f m_CenterOfMass /* None */,
    Vector3f m_InertiaTensor /* None */,
    Quaternionf m_InertiaRotation /* None */,
    BitField m_IncludeLayers /* None */,
    BitField m_ExcludeLayers /* None */,
    bool m_ImplicitCom /* None */,
    bool m_ImplicitTensor /* None */,
    bool m_UseGravity /* None */,
    bool m_IsKinematic /* None */,
    byte m_Interpolate /* None */,
    int m_Constraints /* NeedsAlign */,
    int m_CollisionDetection /* None */) : IUnityObject
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
        reader.AlignTo(4); /* m_Constraints */
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
}

