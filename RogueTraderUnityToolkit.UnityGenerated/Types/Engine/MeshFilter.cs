namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $MeshFilter (2 fields) B130169D24BCE3D7586EE4AB79A1A260 */
public record class MeshFilter(
    PPtr<GameObject> m_GameObject,
    PPtr<Mesh> m_Mesh) : IUnityEngineStructure
{
    public static Hash128 Hash => new(2972718749, 616358871, 1483662507, 2040636000);

    public static MeshFilter Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        PPtr<Mesh> _m_Mesh = PPtr<Mesh>.Read(reader);
        
        return new(_m_GameObject,
            _m_Mesh);
    }

    public override string ToString() => $"MeshFilter\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GameObject: ");
        sb.AppendLine(m_GameObject.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Mesh: ");
        sb.AppendLine(m_Mesh.ToString());

        return sb.ToString();
    }
}

