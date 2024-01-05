namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $MeshCollider (11 fields) D2B33489530AD4ABF8EDF3976BC1BFC2 */
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
    PPtr<Mesh> m_Mesh) : IUnityEngineStructure
{
    public static Hash128 Hash => new(3534959753, 1393218731, 4176343959, 1807859650);

    public static MeshCollider Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        PPtr<PhysicMaterial> _m_Material = PPtr<PhysicMaterial>.Read(reader);
        BitField _m_IncludeLayers = BitField.Read(reader);
        BitField _m_ExcludeLayers = BitField.Read(reader);
        int _m_LayerOverridePriority = reader.ReadS32();
        bool _m_IsTrigger = reader.ReadBool();
        bool _m_ProvidesContacts = reader.ReadBool();
        reader.AlignTo(4); /* m_ProvidesContacts */
        bool _m_Enabled = reader.ReadBool();
        reader.AlignTo(4); /* m_Enabled */
        bool _m_Convex = reader.ReadBool();
        reader.AlignTo(4); /* m_Convex */
        int _m_CookingOptions = reader.ReadS32();
        reader.AlignTo(4); /* m_CookingOptions */
        PPtr<Mesh> _m_Mesh = PPtr<Mesh>.Read(reader);
        
        return new(_m_GameObject,
            _m_Material,
            _m_IncludeLayers,
            _m_ExcludeLayers,
            _m_LayerOverridePriority,
            _m_IsTrigger,
            _m_ProvidesContacts,
            _m_Enabled,
            _m_Convex,
            _m_CookingOptions,
            _m_Mesh);
    }

    public override string ToString() => $"MeshCollider\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GameObject: ");
        sb.AppendLine(m_GameObject.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Material: ");
        sb.AppendLine(m_Material.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IncludeLayers: ");
        sb.AppendLine();
        sb.Append(m_IncludeLayers.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ExcludeLayers: ");
        sb.AppendLine();
        sb.Append(m_ExcludeLayers.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LayerOverridePriority: ");
        sb.AppendLine(m_LayerOverridePriority.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IsTrigger: ");
        sb.AppendLine(m_IsTrigger.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ProvidesContacts: ");
        sb.AppendLine(m_ProvidesContacts.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Enabled: ");
        sb.AppendLine(m_Enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Convex: ");
        sb.AppendLine(m_Convex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CookingOptions: ");
        sb.AppendLine(m_CookingOptions.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Mesh: ");
        sb.AppendLine(m_Mesh.ToString());

        return sb.ToString();
    }
}

