namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $ComputeShader (2 fields) AB63DFBF5A4DE80CE55E762CE70FD960 */
public record class ComputeShader(
    AsciiString m_Name,
    ComputeShaderPlatformVariant[] variants) : IUnityEngineStructure
{
    public static Hash128 Hash => new(2875449279, 1515055116, 3848173100, 3876575584);

    public static ComputeShader Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        ComputeShaderPlatformVariant[] _variants = BuiltInArray<ComputeShaderPlatformVariant>.Read(reader);
        reader.AlignTo(4); /* variants */
        
        return new(_m_Name,
            _variants);
    }

    public override string ToString() => $"ComputeShader\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("variants: ");
        sb.AppendLine(variants.ToString());

        return sb.ToString();
    }
}

