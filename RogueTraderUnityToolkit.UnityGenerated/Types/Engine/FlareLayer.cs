namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $FlareLayer (2 fields) FlareLayer 8914DAE0941BD801D7679C24C69CE55D */
public record class FlareLayer (
    PPtr<GameObject> m_GameObject,
    byte m_Enabled) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.FlareLayer;
    public static Hash128 Hash => new("8914DAE0941BD801D7679C24C69CE55D");
    public static FlareLayer Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject_ = PPtr<GameObject>.Read(reader);
        byte m_Enabled_ = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        
        return new(m_GameObject_,
            m_Enabled_);
    }

    public override string ToString() => $"FlareLayer\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

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
}

