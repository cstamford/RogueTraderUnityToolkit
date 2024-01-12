namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $AudioListener (2 fields) AudioListener EA4A5E30154BB6CBDA102586CB0275D4 */
public record class AudioListener (
    PPtr<GameObject> m_GameObject,
    byte m_Enabled) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.AudioListener;
    public static Hash128 Hash => new("EA4A5E30154BB6CBDA102586CB0275D4");
    public static AudioListener Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject_ = PPtr<GameObject>.Read(reader);
        byte m_Enabled_ = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        
        return new(m_GameObject_,
            m_Enabled_);
    }

    public override string ToString() => $"AudioListener\n{ToString(4)}";

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

