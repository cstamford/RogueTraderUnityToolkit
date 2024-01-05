namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $VisualEffectAsset (3 fields) 9E4574B6881DEB162C7B7E88AD5B3242 */
public record class VisualEffectAsset(
    AsciiString m_Name,
    VisualEffectInfo m_Infos,
    VFXSystemDesc[] m_Systems) : IUnityEngineStructure
{
    public static Hash128 Hash => new(2655351990, 2283662102, 746290824, 2908435010);

    public static VisualEffectAsset Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        VisualEffectInfo _m_Infos = VisualEffectInfo.Read(reader);
        reader.AlignTo(4); /* m_Infos */
        VFXSystemDesc[] _m_Systems = BuiltInArray<VFXSystemDesc>.Read(reader);
        reader.AlignTo(4); /* m_Systems */
        
        return new(_m_Name,
            _m_Infos,
            _m_Systems);
    }

    public override string ToString() => $"VisualEffectAsset\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Infos: ");
        sb.AppendLine();
        sb.Append(m_Infos.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Systems: ");
        sb.AppendLine(m_Systems.ToString());

        return sb.ToString();
    }
}

