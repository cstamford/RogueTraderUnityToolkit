namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $AudioListener (2 fields) EA4A5E30154BB6CBDA102586CB0275D4 */
public record class AudioListener(
    PPtr<GameObject> m_GameObject,
    byte m_Enabled) : IUnityEngineStructure
{
    public static Hash128 Hash => new(3930742320, 357283531, 3658491270, 3405936084);

    public static AudioListener Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        
        return new(_m_GameObject,
            _m_Enabled);
    }

    public override string ToString() => $"AudioListener\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GameObject: ");
        sb.AppendLine(m_GameObject.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Enabled: ");
        sb.AppendLine(m_Enabled.ToString());

        return sb.ToString();
    }
}

