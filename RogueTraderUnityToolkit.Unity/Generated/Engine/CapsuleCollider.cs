namespace RogueTraderUnityToolkit.Unity.Generated.Engine;

using Core;

/* $CapsuleCollider (12 fields) (IsEngineType) */
public record class CapsuleCollider(
    PPtr<GameObject> m_GameObject,
    PPtr<PhysicMaterial> m_Material,
    BitField m_IncludeLayers,
    BitField m_ExcludeLayers,
    int m_LayerOverridePriority,
    bool m_IsTrigger,
    bool m_ProvidesContacts,
    bool m_Enabled,
    float m_Radius,
    float m_Height,
    int m_Direction,
    Vector3f m_Center)
{
    public static CapsuleCollider Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        PPtr<PhysicMaterial> m_Material = PPtr<PhysicMaterial>.Read(reader);
        BitField m_IncludeLayers = BitField.Read(reader);
        BitField m_ExcludeLayers = BitField.Read(reader);
        int m_LayerOverridePriority = reader.ReadS32();
        bool m_IsTrigger = reader.ReadBool();
        bool m_ProvidesContacts = reader.ReadBool();
        bool m_Enabled = reader.ReadBool();
        float m_Radius = reader.ReadF32();
        float m_Height = reader.ReadF32();
        int m_Direction = reader.ReadS32();
        Vector3f m_Center = Vector3f.Read(reader);
        
        return new(m_GameObject,
            m_Material,
            m_IncludeLayers,
            m_ExcludeLayers,
            m_LayerOverridePriority,
            m_IsTrigger,
            m_ProvidesContacts,
            m_Enabled,
            m_Radius,
            m_Height,
            m_Direction,
            m_Center);
    }
}

