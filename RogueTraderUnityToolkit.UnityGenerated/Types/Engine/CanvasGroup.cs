namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $CanvasGroup (6 fields) 932BC45BAA679215A624A7BB033692A7 */
public record class CanvasGroup(
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    float m_Alpha,
    bool m_Interactable,
    bool m_BlocksRaycasts,
    bool m_IgnoreParentGroups) : IUnityEngineStructure
{
    public static Hash128 Hash => new(2469119067, 2858914325, 2787420091, 53908135);

    public static CanvasGroup Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        float _m_Alpha = reader.ReadF32();
        bool _m_Interactable = reader.ReadBool();
        bool _m_BlocksRaycasts = reader.ReadBool();
        bool _m_IgnoreParentGroups = reader.ReadBool();
        reader.AlignTo(4); /* m_IgnoreParentGroups */
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Alpha,
            _m_Interactable,
            _m_BlocksRaycasts,
            _m_IgnoreParentGroups);
    }

    public override string ToString() => $"CanvasGroup\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GameObject: ");
        sb.AppendLine(m_GameObject.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Enabled: ");
        sb.AppendLine(m_Enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Alpha: ");
        sb.AppendLine(m_Alpha.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Interactable: ");
        sb.AppendLine(m_Interactable.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BlocksRaycasts: ");
        sb.AppendLine(m_BlocksRaycasts.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IgnoreParentGroups: ");
        sb.AppendLine(m_IgnoreParentGroups.ToString());

        return sb.ToString();
    }
}

