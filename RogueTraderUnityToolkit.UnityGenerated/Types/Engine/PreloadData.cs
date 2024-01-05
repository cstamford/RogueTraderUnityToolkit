namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $PreloadData (4 fields) B5957185FBF85C93CB980B7CAC7E71A9 */
public record class PreloadData(
    AsciiString m_Name,
    PPtr<Object>[] m_Assets,
    AsciiString[] m_Dependencies,
    bool m_ExplicitDataLayout) : IUnityEngineStructure
{
    public static Hash128 Hash => new(3046470021, 4227357843, 3415739260, 2893967785);

    public static PreloadData Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        PPtr<Object>[] _m_Assets = BuiltInArray<PPtr<Object>>.Read(reader);
        reader.AlignTo(4); /* m_Assets */
        AsciiString[] _m_Dependencies = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_Dependencies */
        bool _m_ExplicitDataLayout = reader.ReadBool();
        
        return new(_m_Name,
            _m_Assets,
            _m_Dependencies,
            _m_ExplicitDataLayout);
    }

    public override string ToString() => $"PreloadData\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Assets: ");
        sb.AppendLine(m_Assets.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Dependencies: ");
        sb.AppendLine(m_Dependencies.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ExplicitDataLayout: ");
        sb.AppendLine(m_ExplicitDataLayout.ToString());

        return sb.ToString();
    }
}

