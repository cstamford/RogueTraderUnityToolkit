namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Material (12 fields) Material AC9800C6508BA266DB8005AA8C01BF11 */
public record class Material (
    AsciiString m_Name,
    PPtr<Shader> m_Shader,
    AsciiString[] m_ValidKeywords,
    AsciiString[] m_InvalidKeywords,
    uint m_LightmapFlags,
    bool m_EnableInstancingVariants,
    bool m_DoubleSidedGI,
    int m_CustomRenderQueue,
    Dictionary<AsciiString, AsciiString> stringTagMap,
    AsciiString[] disabledShaderPasses,
    UnityPropertySheet m_SavedProperties,
    BuildTextureStackReference[] m_BuildTextureStacks) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.Material;
    public static Hash128 Hash => new("AC9800C6508BA266DB8005AA8C01BF11");
    public static Material Read(EndianBinaryReader reader)
    {
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        PPtr<Shader> m_Shader_ = PPtr<Shader>.Read(reader);
        AsciiString[] m_ValidKeywords_ = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_ValidKeywords */
        AsciiString[] m_InvalidKeywords_ = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_InvalidKeywords */
        uint m_LightmapFlags_ = reader.ReadU32();
        bool m_EnableInstancingVariants_ = reader.ReadBool();
        bool m_DoubleSidedGI_ = reader.ReadBool();
        reader.AlignTo(4); /* m_DoubleSidedGI */
        int m_CustomRenderQueue_ = reader.ReadS32();
        Dictionary<AsciiString, AsciiString> stringTagMap_ = BuiltInMap<AsciiString, AsciiString>.Read(reader);
        reader.AlignTo(4); /* stringTagMap */
        AsciiString[] disabledShaderPasses_ = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* disabledShaderPasses */
        UnityPropertySheet m_SavedProperties_ = UnityPropertySheet.Read(reader);
        reader.AlignTo(4); /* m_SavedProperties */
        BuildTextureStackReference[] m_BuildTextureStacks_ = BuiltInArray<BuildTextureStackReference>.Read(reader);
        reader.AlignTo(4); /* m_BuildTextureStacks */
        
        return new(m_Name_,
            m_Shader_,
            m_ValidKeywords_,
            m_InvalidKeywords_,
            m_LightmapFlags_,
            m_EnableInstancingVariants_,
            m_DoubleSidedGI_,
            m_CustomRenderQueue_,
            stringTagMap_,
            disabledShaderPasses_,
            m_SavedProperties_,
            m_BuildTextureStacks_);
    }

    public override string ToString() => $"Material\n{ToString(4)}";

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
        ToString_Field11(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Shader: {m_Shader}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ValidKeywords[{m_ValidKeywords.Length}] = {{");
        if (m_ValidKeywords.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (AsciiString _4 in m_ValidKeywords)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = \"{_4}\"");
            ++_4i;
        }
        if (m_ValidKeywords.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_InvalidKeywords[{m_InvalidKeywords.Length}] = {{");
        if (m_InvalidKeywords.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (AsciiString _4 in m_InvalidKeywords)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = \"{_4}\"");
            ++_4i;
        }
        if (m_InvalidKeywords.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LightmapFlags: {m_LightmapFlags}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_EnableInstancingVariants: {m_EnableInstancingVariants}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DoubleSidedGI: {m_DoubleSidedGI}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CustomRenderQueue: {m_CustomRenderQueue}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}stringTagMap[{stringTagMap.Count}] = {{");
        if (stringTagMap.Count > 0) sb.AppendLine();
        int _4i = 0;
        foreach (KeyValuePair<AsciiString, AsciiString> _4 in stringTagMap)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[\"{_4.Key}\"] = \"{_4.Value}\"");
            ++_4i;
        }
        if (stringTagMap.Count > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}disabledShaderPasses[{disabledShaderPasses.Length}] = {{");
        if (disabledShaderPasses.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (AsciiString _4 in disabledShaderPasses)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = \"{_4}\"");
            ++_4i;
        }
        if (disabledShaderPasses.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_SavedProperties: {{ \n{m_SavedProperties.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_BuildTextureStacks[{m_BuildTextureStacks.Length}] = {{");
        if (m_BuildTextureStacks.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (BuildTextureStackReference _4 in m_BuildTextureStacks)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_BuildTextureStacks.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

