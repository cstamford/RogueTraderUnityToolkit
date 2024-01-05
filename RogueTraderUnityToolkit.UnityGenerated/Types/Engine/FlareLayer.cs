namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $FlareLayer (2 fields) 8914DAE0941BD801D7679C24C69CE55D */
public record class FlareLayer(
    PPtr<GameObject> m_GameObject,
    byte m_Enabled) : IUnityEngineStructure
{
    public static Hash128 Hash => new(2299845344, 2484852737, 3613891620, 3332171101);

    public static FlareLayer Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        
        return new(_m_GameObject,
            _m_Enabled);
    }

    public override string ToString() => $"FlareLayer\n{ToString(4)}";

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

