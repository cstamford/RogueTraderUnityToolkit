namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $MeshFilter (2 fields) MeshFilter B130169D24BCE3D7586EE4AB79A1A260 */
public record class MeshFilter (
    PPtr<GameObject> m_GameObject,
    PPtr<Mesh> m_Mesh) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.MeshFilter;
    public static Hash128 Hash => new("B130169D24BCE3D7586EE4AB79A1A260");
    public static MeshFilter Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject_ = PPtr<GameObject>.Read(reader);
        PPtr<Mesh> m_Mesh_ = PPtr<Mesh>.Read(reader);
        
        return new(m_GameObject_,
            m_Mesh_);
    }

    public override string ToString() => $"MeshFilter\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_GameObject: {m_GameObject}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Mesh: {m_Mesh}");
    }
}

