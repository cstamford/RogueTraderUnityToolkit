namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $SortingGroup (6 fields) SortingGroup 0A004E96695F1E76758D74B19732785D */
public record class SortingGroup (
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    int m_SortingLayerID,
    short m_SortingLayer,
    short m_SortingOrder,
    bool m_SortAtRoot) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.SortingGroup;
    public static Hash128 Hash => new("0A004E96695F1E76758D74B19732785D");
    public static SortingGroup Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject_ = PPtr<GameObject>.Read(reader);
        byte m_Enabled_ = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        int m_SortingLayerID_ = reader.ReadS32();
        short m_SortingLayer_ = reader.ReadS16();
        short m_SortingOrder_ = reader.ReadS16();
        bool m_SortAtRoot_ = reader.ReadBool();
        reader.AlignTo(4); /* m_SortAtRoot */
        
        return new(m_GameObject_,
            m_Enabled_,
            m_SortingLayerID_,
            m_SortingLayer_,
            m_SortingOrder_,
            m_SortAtRoot_);
    }

    public override string ToString() => $"SortingGroup\n{ToString(4)}";

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
        sb.AppendLine($"{indent_}m_SortingLayerID: {m_SortingLayerID}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SortingLayer: {m_SortingLayer}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SortingOrder: {m_SortingOrder}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SortAtRoot: {m_SortAtRoot}");
    }
}

