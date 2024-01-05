namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $AvatarMask (3 fields) 9215D1126AA8279C97CEA97F18DAEFDA */
public record class AvatarMask(
    AsciiString m_Name,
    uint[] m_Mask,
    TransformMaskElement[] m_Elements) : IUnityEngineStructure
{
    public static Hash128 Hash => new(2450903314, 1789405084, 2546903423, 417001434);

    public static AvatarMask Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        uint[] _m_Mask = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* m_Mask */
        TransformMaskElement[] _m_Elements = BuiltInArray<TransformMaskElement>.Read(reader);
        reader.AlignTo(4); /* m_Elements */
        
        return new(_m_Name,
            _m_Mask,
            _m_Elements);
    }

    public override string ToString() => $"AvatarMask\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Mask: ");
        sb.AppendLine(m_Mask.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Elements: ");
        sb.AppendLine(m_Elements.ToString());

        return sb.ToString();
    }
}

