namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $MeshCollider (11 fields) (IsEngineType) */
public record class MeshCollider(
    PPtr<GameObject> m_GameObject,
    PPtr<PhysicMaterial> m_Material,
    BitField m_IncludeLayers,
    BitField m_ExcludeLayers,
    int m_LayerOverridePriority,
    bool m_IsTrigger,
    bool m_ProvidesContacts,
    bool m_Enabled,
    bool m_Convex,
    int m_CookingOptions,
    PPtr<Mesh> m_Mesh)
{
    public static MeshCollider Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        PPtr<PhysicMaterial> m_Material = PPtr<PhysicMaterial>.Read(reader);
        BitField m_IncludeLayers = BitField.Read(reader);
        BitField m_ExcludeLayers = BitField.Read(reader);
        int m_LayerOverridePriority = reader.ReadS32();
        bool m_IsTrigger = reader.ReadBool();
        bool m_ProvidesContacts = reader.ReadBool();
        bool m_Enabled = reader.ReadBool();
        bool m_Convex = reader.ReadBool();
        int m_CookingOptions = reader.ReadS32();
        PPtr<Mesh> m_Mesh = PPtr<Mesh>.Read(reader);
        
        return new(m_GameObject,
            m_Material,
            m_IncludeLayers,
            m_ExcludeLayers,
            m_LayerOverridePriority,
            m_IsTrigger,
            m_ProvidesContacts,
            m_Enabled,
            m_Convex,
            m_CookingOptions,
            m_Mesh);
    }
}

