namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $TextAsset (2 fields) E1A46B48EA6ABD5D64A0C18AC8895830 */
public record class TextAsset(
    AsciiString m_Name,
    AsciiString m_Script) : IUnityEngineStructure
{
    public static Hash128 Hash => new(3785648968, 3932863837, 1688256906, 3364444208);

    public static TextAsset Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        AsciiString _m_Script = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Script */
        
        return new(_m_Name,
            _m_Script);
    }

    public override string ToString() => $"TextAsset\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Script: ");
        sb.AppendLine(m_Script.ToString());

        return sb.ToString();
    }
}

