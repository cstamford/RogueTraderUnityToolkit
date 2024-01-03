namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $BoxCollider (10 fields) (IsEngineType) */
public record class BoxCollider(
    PPtr<GameObject> m_GameObject,
    PPtr<PhysicMaterial> m_Material,
    BitField m_IncludeLayers,
    BitField m_ExcludeLayers,
    int m_LayerOverridePriority,
    bool m_IsTrigger,
    bool m_ProvidesContacts,
    bool m_Enabled,
    Vector3f m_Size,
    Vector3f m_Center)
{
    public static BoxCollider Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        PPtr<PhysicMaterial> m_Material = PPtr<PhysicMaterial>.Read(reader);
        BitField m_IncludeLayers = BitField.Read(reader);
        BitField m_ExcludeLayers = BitField.Read(reader);
        int m_LayerOverridePriority = reader.ReadS32();
        bool m_IsTrigger = reader.ReadBool();
        bool m_ProvidesContacts = reader.ReadBool();
        bool m_Enabled = reader.ReadBool();
        Vector3f m_Size = Vector3f.Read(reader);
        Vector3f m_Center = Vector3f.Read(reader);
        
        return new(m_GameObject,
            m_Material,
            m_IncludeLayers,
            m_ExcludeLayers,
            m_LayerOverridePriority,
            m_IsTrigger,
            m_ProvidesContacts,
            m_Enabled,
            m_Size,
            m_Center);
    }
}

