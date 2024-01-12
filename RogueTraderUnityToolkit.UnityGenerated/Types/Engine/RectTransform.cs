namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $RectTransform (11 fields) RectTransform FA41C0F096F995631A4D8B0C878F41B9 */
public record class RectTransform (
    PPtr<GameObject> m_GameObject,
    Quaternionf m_LocalRotation,
    Vector3f m_LocalPosition,
    Vector3f m_LocalScale,
    PPtr<Transform>[] m_Children,
    PPtr<Transform> m_Father,
    Vector2f m_AnchorMin,
    Vector2f m_AnchorMax,
    Vector2f m_AnchoredPosition,
    Vector2f m_SizeDelta,
    Vector2f m_Pivot) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.RectTransform;
    public static Hash128 Hash => new("FA41C0F096F995631A4D8B0C878F41B9");
    public static RectTransform Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject_ = PPtr<GameObject>.Read(reader);
        Quaternionf m_LocalRotation_ = Quaternionf.Read(reader);
        Vector3f m_LocalPosition_ = Vector3f.Read(reader);
        Vector3f m_LocalScale_ = Vector3f.Read(reader);
        reader.AlignTo(4); /* m_LocalScale */
        PPtr<Transform>[] m_Children_ = BuiltInArray<PPtr<Transform>>.Read(reader);
        reader.AlignTo(4); /* m_Children */
        PPtr<Transform> m_Father_ = PPtr<Transform>.Read(reader);
        Vector2f m_AnchorMin_ = Vector2f.Read(reader);
        Vector2f m_AnchorMax_ = Vector2f.Read(reader);
        Vector2f m_AnchoredPosition_ = Vector2f.Read(reader);
        Vector2f m_SizeDelta_ = Vector2f.Read(reader);
        Vector2f m_Pivot_ = Vector2f.Read(reader);
        
        return new(m_GameObject_,
            m_LocalRotation_,
            m_LocalPosition_,
            m_LocalScale_,
            m_Children_,
            m_Father_,
            m_AnchorMin_,
            m_AnchorMax_,
            m_AnchoredPosition_,
            m_SizeDelta_,
            m_Pivot_);
    }

    public override string ToString() => $"RectTransform\n{ToString(4)}";

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
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);

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

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_AnchorMin: {{ x: {m_AnchorMin.x}, y: {m_AnchorMin.y} }}\n");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_AnchorMax: {{ x: {m_AnchorMax.x}, y: {m_AnchorMax.y} }}\n");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_AnchoredPosition: {{ x: {m_AnchoredPosition.x}, y: {m_AnchoredPosition.y} }}\n");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_SizeDelta: {{ x: {m_SizeDelta.x}, y: {m_SizeDelta.y} }}\n");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Pivot: {{ x: {m_Pivot.x}, y: {m_Pivot.y} }}\n");
    }
}

