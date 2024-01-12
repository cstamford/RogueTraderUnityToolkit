namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $CanvasGroup (6 fields) CanvasGroup 932BC45BAA679215A624A7BB033692A7 */
public record class CanvasGroup (
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    float m_Alpha,
    bool m_Interactable,
    bool m_BlocksRaycasts,
    bool m_IgnoreParentGroups) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.CanvasGroup;
    public static Hash128 Hash => new("932BC45BAA679215A624A7BB033692A7");
    public static CanvasGroup Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject_ = PPtr<GameObject>.Read(reader);
        byte m_Enabled_ = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        float m_Alpha_ = reader.ReadF32();
        bool m_Interactable_ = reader.ReadBool();
        bool m_BlocksRaycasts_ = reader.ReadBool();
        bool m_IgnoreParentGroups_ = reader.ReadBool();
        reader.AlignTo(4); /* m_IgnoreParentGroups */
        
        return new(m_GameObject_,
            m_Enabled_,
            m_Alpha_,
            m_Interactable_,
            m_BlocksRaycasts_,
            m_IgnoreParentGroups_);
    }

    public override string ToString() => $"CanvasGroup\n{ToString(4)}";

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
        sb.AppendLine($"{indent_}m_Enabled: {m_Enabled}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Alpha: {m_Alpha}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Interactable: {m_Interactable}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BlocksRaycasts: {m_BlocksRaycasts}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_IgnoreParentGroups: {m_IgnoreParentGroups}");
    }
}

