namespace RogueTraderUnityToolkit.Unity.Generated.Engine;

using Core;

/* $SphereCollider (10 fields) (IsEngineType) */
public record class SphereCollider(
    PPtr<GameObject> m_GameObject,
    PPtr<PhysicMaterial> m_Material,
    BitField m_IncludeLayers,
    BitField m_ExcludeLayers,
    int m_LayerOverridePriority,
    bool m_IsTrigger,
    bool m_ProvidesContacts,
    bool m_Enabled,
    float m_Radius,
    Vector3f m_Center)
{
    public static SphereCollider Read(EndianBinaryReader reader)
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
            m_Center);
    }
}

