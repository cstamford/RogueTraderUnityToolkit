namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $CharacterController (15 fields) 659FEC10CCCBE8CDBE1413BC8C64405A */
public record class CharacterController(
    PPtr<GameObject> m_GameObject /* None */,
    PPtr<PhysicMaterial> m_Material /* None */,
    BitField m_IncludeLayers /* None */,
    BitField m_ExcludeLayers /* None */,
    int m_LayerOverridePriority /* None */,
    bool m_IsTrigger /* None */,
    bool m_ProvidesContacts /* None */,
    bool m_Enabled /* NeedsAlign */,
    float m_Height /* NeedsAlign */,
    float m_Radius /* None */,
    float m_SlopeLimit /* None */,
    float m_StepOffset /* None */,
    float m_SkinWidth /* None */,
    float m_MinMoveDistance /* None */,
    Vector3f m_Center /* None */) : IUnityObject
{
    public static Hash128 Hash => new(1704979472, 3435915469, 3188986812, 2355380314);
    public static CharacterController Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        PPtr<PhysicMaterial> _m_Material = PPtr<PhysicMaterial>.Read(reader);
        BitField _m_IncludeLayers = BitField.Read(reader);
        BitField _m_ExcludeLayers = BitField.Read(reader);
        int _m_LayerOverridePriority = reader.ReadS32();
        bool _m_IsTrigger = reader.ReadBool();
        bool _m_ProvidesContacts = reader.ReadBool();
        reader.AlignTo(4); /* m_Enabled */
        bool _m_Enabled = reader.ReadBool();
        reader.AlignTo(4); /* m_Height */
        float _m_Height = reader.ReadF32();
        float _m_Radius = reader.ReadF32();
        float _m_SlopeLimit = reader.ReadF32();
        float _m_StepOffset = reader.ReadF32();
        float _m_SkinWidth = reader.ReadF32();
        float _m_MinMoveDistance = reader.ReadF32();
        Vector3f _m_Center = Vector3f.Read(reader);
        
        return new(_m_GameObject,
            _m_Material,
            _m_IncludeLayers,
            _m_ExcludeLayers,
            _m_LayerOverridePriority,
            _m_IsTrigger,
            _m_ProvidesContacts,
            _m_Enabled,
            _m_Height,
            _m_Radius,
            _m_SlopeLimit,
            _m_StepOffset,
            _m_SkinWidth,
            _m_MinMoveDistance,
            _m_Center);
    }
}

