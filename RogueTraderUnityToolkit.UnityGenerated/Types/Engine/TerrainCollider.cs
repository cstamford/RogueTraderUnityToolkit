namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $TerrainCollider (9 fields) 25904926B57B4F72A0D8ADEA16C2DCE3 */
public record class TerrainCollider(
    PPtr<GameObject> m_GameObject /* None */,
    PPtr<PhysicMaterial> m_Material /* None */,
    BitField m_IncludeLayers /* None */,
    BitField m_ExcludeLayers /* None */,
    int m_LayerOverridePriority /* None */,
    bool m_ProvidesContacts /* None */,
    bool m_Enabled /* NeedsAlign */,
    PPtr<TerrainData> m_TerrainData /* NeedsAlign */,
    bool m_EnableTreeColliders /* None */) : IUnityObject
{
    public static Hash128 Hash => new(630212902, 3044757362, 2698554858, 381869283);
    public static TerrainCollider Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        PPtr<PhysicMaterial> _m_Material = PPtr<PhysicMaterial>.Read(reader);
        BitField _m_IncludeLayers = BitField.Read(reader);
        BitField _m_ExcludeLayers = BitField.Read(reader);
        int _m_LayerOverridePriority = reader.ReadS32();
        bool _m_ProvidesContacts = reader.ReadBool();
        reader.AlignTo(4); /* m_Enabled */
        bool _m_Enabled = reader.ReadBool();
        reader.AlignTo(4); /* m_TerrainData */
        PPtr<TerrainData> _m_TerrainData = PPtr<TerrainData>.Read(reader);
        bool _m_EnableTreeColliders = reader.ReadBool();
        
        return new(_m_GameObject,
            _m_Material,
            _m_IncludeLayers,
            _m_ExcludeLayers,
            _m_LayerOverridePriority,
            _m_ProvidesContacts,
            _m_Enabled,
            _m_TerrainData,
            _m_EnableTreeColliders);
    }
}

