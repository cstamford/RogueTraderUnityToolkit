namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Shader (11 fields) Shader 5F4A42EAB68DE4C195DF442105109E6F */
public record class Shader (
    AsciiString m_Name,
    SerializedShader m_ParsedForm,
    uint[] platforms,
    uint[][] offsets,
    uint[][] compressedLengths,
    uint[][] decompressedLengths,
    byte[] compressedBlob,
    uint[] stageCounts,
    PPtr<Shader>[] m_Dependencies,
    Dictionary<AsciiString, PPtr<Texture>> m_NonModifiableTextures,
    bool m_ShaderIsBaked) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.Shader;
    public static Hash128 Hash => new("5F4A42EAB68DE4C195DF442105109E6F");
    public static Shader Read(EndianBinaryReader reader)
    {
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        SerializedShader m_ParsedForm_ = SerializedShader.Read(reader);
        reader.AlignTo(4); /* m_ParsedForm */
        uint[] platforms_ = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* platforms */
        uint[][] offsets_ = BuiltInArray<uint[]>.Read(reader);
        reader.AlignTo(4); /* offsets */
        uint[][] compressedLengths_ = BuiltInArray<uint[]>.Read(reader);
        reader.AlignTo(4); /* compressedLengths */
        uint[][] decompressedLengths_ = BuiltInArray<uint[]>.Read(reader);
        reader.AlignTo(4); /* decompressedLengths */
        byte[] compressedBlob_ = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* compressedBlob */
        uint[] stageCounts_ = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* stageCounts */
        PPtr<Shader>[] m_Dependencies_ = BuiltInArray<PPtr<Shader>>.Read(reader);
        reader.AlignTo(4); /* m_Dependencies */
        Dictionary<AsciiString, PPtr<Texture>> m_NonModifiableTextures_ = BuiltInMap<AsciiString, PPtr<Texture>>.Read(reader);
        reader.AlignTo(4); /* m_NonModifiableTextures */
        bool m_ShaderIsBaked_ = reader.ReadBool();
        reader.AlignTo(4); /* m_ShaderIsBaked */
        
        return new(m_Name_,
            m_ParsedForm_,
            platforms_,
            offsets_,
            compressedLengths_,
            decompressedLengths_,
            compressedBlob_,
            stageCounts_,
            m_Dependencies_,
            m_NonModifiableTextures_,
            m_ShaderIsBaked_);
    }

    public override string ToString() => $"Shader\n{ToString(4)}";

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
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ParsedForm: {{ \n{m_ParsedForm.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}platforms[{platforms.Length}] = {{");
        if (platforms.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint _4 in platforms)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (platforms.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}offsets[{offsets.Length}] = {{");
        if (offsets.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint[] _4 in offsets)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = [{_4.Length}] = {{");
            if (_4.Length > 0) sb.AppendLine();
            int _8i = 0;
            foreach (uint _8 in _4)
            {
                sb.AppendLine($"{indent_ + ' '.Repeat(8)}[{_8i}] = {_8}");
                ++_8i;
            }
            if (_4.Length > 0) sb.Append(indent_ + ' '.Repeat(4));
            sb.AppendLine("}");
            ++_4i;
        }
        if (offsets.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}compressedLengths[{compressedLengths.Length}] = {{");
        if (compressedLengths.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint[] _4 in compressedLengths)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = [{_4.Length}] = {{");
            if (_4.Length > 0) sb.AppendLine();
            int _8i = 0;
            foreach (uint _8 in _4)
            {
                sb.AppendLine($"{indent_ + ' '.Repeat(8)}[{_8i}] = {_8}");
                ++_8i;
            }
            if (_4.Length > 0) sb.Append(indent_ + ' '.Repeat(4));
            sb.AppendLine("}");
            ++_4i;
        }
        if (compressedLengths.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}decompressedLengths[{decompressedLengths.Length}] = {{");
        if (decompressedLengths.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint[] _4 in decompressedLengths)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = [{_4.Length}] = {{");
            if (_4.Length > 0) sb.AppendLine();
            int _8i = 0;
            foreach (uint _8 in _4)
            {
                sb.AppendLine($"{indent_ + ' '.Repeat(8)}[{_8i}] = {_8}");
                ++_8i;
            }
            if (_4.Length > 0) sb.Append(indent_ + ' '.Repeat(4));
            sb.AppendLine("}");
            ++_4i;
        }
        if (decompressedLengths.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}compressedBlob[{compressedBlob.Length}] = {{");
        if (compressedBlob.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (byte _4 in compressedBlob)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (compressedBlob.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}stageCounts[{stageCounts.Length}] = {{");
        if (stageCounts.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint _4 in stageCounts)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (stageCounts.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Dependencies[{m_Dependencies.Length}] = {{");
        if (m_Dependencies.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtr<Shader> _4 in m_Dependencies)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_Dependencies.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_NonModifiableTextures[{m_NonModifiableTextures.Count}] = {{");
        if (m_NonModifiableTextures.Count > 0) sb.AppendLine();
        int _4i = 0;
        foreach (KeyValuePair<AsciiString, PPtr<Texture>> _4 in m_NonModifiableTextures)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[\"{_4.Key}\"] = {_4.Value}");
            ++_4i;
        }
        if (m_NonModifiableTextures.Count > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ShaderIsBaked: {m_ShaderIsBaked}");
    }
}

