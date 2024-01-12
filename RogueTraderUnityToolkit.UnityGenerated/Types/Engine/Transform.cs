namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Transform (6 fields) Transform 0859EF55586068C69197937FE65096F5 */
public record class Transform (
    PPtr<GameObject> m_GameObject,
    Quaternionf m_LocalRotation,
    Vector3f m_LocalPosition,
    Vector3f m_LocalScale,
    PPtr<Transform>[] m_Children,
    PPtr<Transform> m_Father) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.Transform;
    public static Hash128 Hash => new("0859EF55586068C69197937FE65096F5");
    public static Transform Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject_ = PPtr<GameObject>.Read(reader);
        Quaternionf m_LocalRotation_ = Quaternionf.Read(reader);
        Vector3f m_LocalPosition_ = Vector3f.Read(reader);
        Vector3f m_LocalScale_ = Vector3f.Read(reader);
        reader.AlignTo(4); /* m_LocalScale */
        PPtr<Transform>[] m_Children_ = BuiltInArray<PPtr<Transform>>.Read(reader);
        reader.AlignTo(4); /* m_Children */
        PPtr<Transform> m_Father_ = PPtr<Transform>.Read(reader);
        
        return new(m_GameObject_,
            m_LocalRotation_,
            m_LocalPosition_,
            m_LocalScale_,
            m_Children_,
            m_Father_);
    }

    public override string ToString() => $"Transform\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_GameObject: {m_GameObject}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_LocalRotation: {{ x: {m_LocalRotation.x}, y: {m_LocalRotation.y}, z: {m_LocalRotation.z}, w: {m_LocalRotation.w} }}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_LocalPosition: {{ x: {m_LocalPosition.x}, y: {m_LocalPosition.y}, z: {m_LocalPosition.z} }}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_LocalScale: {{ x: {m_LocalScale.x}, y: {m_LocalScale.y}, z: {m_LocalScale.z} }}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Children[{m_Children.Length}] = {{");
        if (m_Children.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtr<Transform> _4 in m_Children)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_Children.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Father: {m_Father}");
    }
}

