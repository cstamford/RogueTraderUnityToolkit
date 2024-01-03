namespace RogueTraderUnityToolkit.Unity.Generated.Engine;

using Core;

/* $TerrainCollider (9 fields) (IsEngineType) */
public record class TerrainCollider(
    PPtr<GameObject> m_GameObject,
    PPtr<PhysicMaterial> m_Material,
    BitField m_IncludeLayers,
    BitField m_ExcludeLayers,
    int m_LayerOverridePriority,
    bool m_ProvidesContacts,
    bool m_Enabled,
    PPtr<TerrainData> m_TerrainData,
    bool m_EnableTreeColliders)
{
    public static TerrainCollider Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        PPtr<PhysicMaterial> m_Material = PPtr<PhysicMaterial>.Read(reader);
        BitField m_IncludeLayers = BitField.Read(reader);
        BitField m_ExcludeLayers = BitField.Read(reader);
        int m_LayerOverridePriority = reader.ReadS32();
        bool m_ProvidesContacts = reader.ReadBool();
        bool m_Enabled = reader.ReadBool();
        PPtr<TerrainData> m_TerrainData = PPtr<TerrainData>.Read(reader);
        bool m_EnableTreeColliders = reader.ReadBool();
        
        return new(m_GameObject,
            m_Material,
            m_IncludeLayers,
            m_ExcludeLayers,
            m_LayerOverridePriority,
            m_ProvidesContacts,
            m_Enabled,
            m_TerrainData,
            m_EnableTreeColliders);
    }
}

