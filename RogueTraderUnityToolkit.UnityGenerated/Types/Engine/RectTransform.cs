namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $RectTransform (11 fields) FA41C0F096F995631A4D8B0C878F41B9 */
public record class RectTransform(
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
    public static Hash128 Hash => new(4198613232, 2532939107, 441289484, 2274312633);

    public static RectTransform Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        Quaternionf _m_LocalRotation = Quaternionf.Read(reader);
        Vector3f _m_LocalPosition = Vector3f.Read(reader);
        Vector3f _m_LocalScale = Vector3f.Read(reader);
        reader.AlignTo(4); /* m_LocalScale */
        PPtr<Transform>[] _m_Children = BuiltInArray<PPtr<Transform>>.Read(reader);
        reader.AlignTo(4); /* m_Children */
        PPtr<Transform> _m_Father = PPtr<Transform>.Read(reader);
        Vector2f _m_AnchorMin = Vector2f.Read(reader);
        Vector2f _m_AnchorMax = Vector2f.Read(reader);
        Vector2f _m_AnchoredPosition = Vector2f.Read(reader);
        Vector2f _m_SizeDelta = Vector2f.Read(reader);
        Vector2f _m_Pivot = Vector2f.Read(reader);
        
        return new(_m_GameObject,
            _m_LocalRotation,
            _m_LocalPosition,
            _m_LocalScale,
            _m_Children,
            _m_Father,
            _m_AnchorMin,
            _m_AnchorMax,
            _m_AnchoredPosition,
            _m_SizeDelta,
            _m_Pivot);
    }

    public override string ToString() => $"RectTransform\n{ToString(4)}";

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

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AnchorMin: ");
        sb.AppendLine();
        sb.Append(m_AnchorMin.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AnchorMax: ");
        sb.AppendLine();
        sb.Append(m_AnchorMax.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AnchoredPosition: ");
        sb.AppendLine();
        sb.Append(m_AnchoredPosition.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SizeDelta: ");
        sb.AppendLine();
        sb.Append(m_SizeDelta.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Pivot: ");
        sb.AppendLine();
        sb.Append(m_Pivot.ToString(indent+4));

        return sb.ToString();
    }
}

