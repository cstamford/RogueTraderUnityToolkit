namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Transform (6 fields) 0859EF55586068C69197937FE65096F5 */
public record class Transform(
    PPtr<GameObject> m_GameObject,
    Quaternionf m_LocalRotation,
    Vector3f m_LocalPosition,
    Vector3f m_LocalScale,
    PPtr<Transform>[] m_Children,
    PPtr<Transform> m_Father) : IUnityEngineStructure
{
    public static Hash128 Hash => new(140111701, 1482713286, 2442630015, 3864041205);

    public static Transform Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        Quaternionf _m_LocalRotation = Quaternionf.Read(reader);
        Vector3f _m_LocalPosition = Vector3f.Read(reader);
        Vector3f _m_LocalScale = Vector3f.Read(reader);
        reader.AlignTo(4); /* m_LocalScale */
        PPtr<Transform>[] _m_Children = BuiltInArray<PPtr<Transform>>.Read(reader);
        reader.AlignTo(4); /* m_Children */
        PPtr<Transform> _m_Father = PPtr<Transform>.Read(reader);
        
        return new(_m_GameObject,
            _m_LocalRotation,
            _m_LocalPosition,
            _m_LocalScale,
            _m_Children,
            _m_Father);
    }

    public override string ToString() => $"Transform\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GameObject: ");
        sb.AppendLine(m_GameObject.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LocalRotation: ");
        sb.AppendLine();
        sb.Append(m_LocalRotation.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LocalPosition: ");
        sb.AppendLine();
        sb.Append(m_LocalPosition.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LocalScale: ");
        sb.AppendLine();
        sb.Append(m_LocalScale.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Children: ");
        sb.AppendLine(m_Children.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Father: ");
        sb.AppendLine(m_Father.ToString());

        return sb.ToString();
    }
}

