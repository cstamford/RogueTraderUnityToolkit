namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $CanvasRenderer (2 fields) 90E55057E9E1204E4D4268B70DA10487 */
public record class CanvasRenderer(
    PPtr<GameObject> m_GameObject,
    bool m_CullTransparentMesh) : IUnityEngineStructure
{
    public static Hash128 Hash => new(2430947415, 3923845198, 1296197815, 228656263);

    public static CanvasRenderer Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        bool _m_CullTransparentMesh = reader.ReadBool();
        
        return new(_m_GameObject,
            _m_CullTransparentMesh);
    }

    public override string ToString() => $"CanvasRenderer\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GameObject: ");
        sb.AppendLine(m_GameObject.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CullTransparentMesh: ");
        sb.AppendLine(m_CullTransparentMesh.ToString());

        return sb.ToString();
    }
}

