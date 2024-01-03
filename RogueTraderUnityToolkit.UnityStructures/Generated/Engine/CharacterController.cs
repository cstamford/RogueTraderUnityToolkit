namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $CharacterController (15 fields) (IsEngineType) */
public record class CharacterController(
    PPtr<GameObject> m_GameObject,
    PPtr<PhysicMaterial> m_Material,
    BitField m_IncludeLayers,
    BitField m_ExcludeLayers,
    int m_LayerOverridePriority,
    bool m_IsTrigger,
    bool m_ProvidesContacts,
    bool m_Enabled,
    float m_Height,
    float m_Radius,
    float m_SlopeLimit,
    float m_StepOffset,
    float m_SkinWidth,
    float m_MinMoveDistance,
    Vector3f m_Center)
{
    public static CharacterController Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        PPtr<PhysicMaterial> m_Material = PPtr<PhysicMaterial>.Read(reader);
        BitField m_IncludeLayers = BitField.Read(reader);
        BitField m_ExcludeLayers = BitField.Read(reader);
        int m_LayerOverridePriority = reader.ReadS32();
        bool m_IsTrigger = reader.ReadBool();
        bool m_ProvidesContacts = reader.ReadBool();
        bool m_Enabled = reader.ReadBool();
        float m_Height = reader.ReadF32();
        float m_Radius = reader.ReadF32();
        float m_SlopeLimit = reader.ReadF32();
        float m_StepOffset = reader.ReadF32();
        float m_SkinWidth = reader.ReadF32();
        float m_MinMoveDistance = reader.ReadF32();
        Vector3f m_Center = Vector3f.Read(reader);
        
        return new(m_GameObject,
            m_Material,
            m_IncludeLayers,
            m_ExcludeLayers,
            m_LayerOverridePriority,
            m_IsTrigger,
            m_ProvidesContacts,
            m_Enabled,
            m_Height,
            m_Radius,
            m_SlopeLimit,
            m_StepOffset,
            m_SkinWidth,
            m_MinMoveDistance,
            m_Center);
    }
}

