namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $CanvasRenderer (2 fields) CanvasRenderer 90E55057E9E1204E4D4268B70DA10487 */
public record class CanvasRenderer (
    PPtr<GameObject> m_GameObject,
    bool m_CullTransparentMesh) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.CanvasRenderer;
    public static Hash128 Hash => new("90E55057E9E1204E4D4268B70DA10487");
    public static CanvasRenderer Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject_ = PPtr<GameObject>.Read(reader);
        bool m_CullTransparentMesh_ = reader.ReadBool();
        
        return new(m_GameObject_,
            m_CullTransparentMesh_);
    }

    public override string ToString() => $"CanvasRenderer\n{ToString(4)}";

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
        sb.AppendLine($"{indent_}m_CullTransparentMesh: {m_CullTransparentMesh}");
    }
}

