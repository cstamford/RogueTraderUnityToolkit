namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $SortingGroup (6 fields) 0A004E96695F1E76758D74B19732785D */
public record class SortingGroup(
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    int m_SortingLayerID,
    short m_SortingLayer,
    short m_SortingOrder,
    bool m_SortAtRoot) : IUnityEngineStructure
{
    public static Hash128 Hash => new(167792278, 1767841398, 1972204721, 2536667229);

    public static SortingGroup Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        int _m_SortingLayerID = reader.ReadS32();
        short _m_SortingLayer = reader.ReadS16();
        short _m_SortingOrder = reader.ReadS16();
        bool _m_SortAtRoot = reader.ReadBool();
        reader.AlignTo(4); /* m_SortAtRoot */
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_SortingLayerID,
            _m_SortingLayer,
            _m_SortingOrder,
            _m_SortAtRoot);
    }

    public override string ToString() => $"SortingGroup\n{ToString(4)}";

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
        sb.Append("m_SortingLayerID: ");
        sb.AppendLine(m_SortingLayerID.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SortingLayer: ");
        sb.AppendLine(m_SortingLayer.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SortingOrder: ");
        sb.AppendLine(m_SortingOrder.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SortAtRoot: ");
        sb.AppendLine(m_SortAtRoot.ToString());

        return sb.ToString();
    }
}

