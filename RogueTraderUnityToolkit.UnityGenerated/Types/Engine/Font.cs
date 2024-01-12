namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Font (22 fields) Font 2253156A689268228F148ABCABE7844E */
public record class Font (
    AsciiString m_Name,
    float m_LineSpacing,
    PPtr<Material> m_DefaultMaterial,
    float m_FontSize,
    PPtr<Texture> m_Texture,
    int m_AsciiStartOffset,
    float m_Tracking,
    int m_CharacterSpacing,
    int m_CharacterPadding,
    int m_ConvertCase,
    CharacterInfo[] m_CharacterRects,
    Dictionary<pair, float> m_KerningValues,
    float m_PixelScale,
    char[] m_FontData,
    float m_Ascent,
    float m_Descent,
    uint m_DefaultStyle,
    AsciiString[] m_FontNames,
    PPtr<Font>[] m_FallbackFonts,
    int m_FontRenderingMode,
    bool m_UseLegacyBoundsCalculation,
    bool m_ShouldRoundAdvanceValue) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.Font;
    public static Hash128 Hash => new("2253156A689268228F148ABCABE7844E");
    public static Font Read(EndianBinaryReader reader)
    {
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        float m_LineSpacing_ = reader.ReadF32();
        PPtr<Material> m_DefaultMaterial_ = PPtr<Material>.Read(reader);
        float m_FontSize_ = reader.ReadF32();
        PPtr<Texture> m_Texture_ = PPtr<Texture>.Read(reader);
        reader.AlignTo(4); /* m_Texture */
        int m_AsciiStartOffset_ = reader.ReadS32();
        float m_Tracking_ = reader.ReadF32();
        int m_CharacterSpacing_ = reader.ReadS32();
        int m_CharacterPadding_ = reader.ReadS32();
        int m_ConvertCase_ = reader.ReadS32();
        CharacterInfo[] m_CharacterRects_ = BuiltInArray<CharacterInfo>.Read(reader);
        reader.AlignTo(4); /* m_CharacterRects */
        Dictionary<pair, float> m_KerningValues_ = BuiltInMap<pair, float>.Read(reader);
        float m_PixelScale_ = reader.ReadF32();
        reader.AlignTo(4); /* m_PixelScale */
        char[] m_FontData_ = BuiltInArray<char>.Read(reader);
        reader.AlignTo(4); /* m_FontData */
        float m_Ascent_ = reader.ReadF32();
        float m_Descent_ = reader.ReadF32();
        uint m_DefaultStyle_ = reader.ReadU32();
        AsciiString[] m_FontNames_ = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_FontNames */
        PPtr<Font>[] m_FallbackFonts_ = BuiltInArray<PPtr<Font>>.Read(reader);
        reader.AlignTo(4); /* m_FallbackFonts */
        int m_FontRenderingMode_ = reader.ReadS32();
        bool m_UseLegacyBoundsCalculation_ = reader.ReadBool();
        bool m_ShouldRoundAdvanceValue_ = reader.ReadBool();
        
        return new(m_Name_,
            m_LineSpacing_,
            m_DefaultMaterial_,
            m_FontSize_,
            m_Texture_,
            m_AsciiStartOffset_,
            m_Tracking_,
            m_CharacterSpacing_,
            m_CharacterPadding_,
            m_ConvertCase_,
            m_CharacterRects_,
            m_KerningValues_,
            m_PixelScale_,
            m_FontData_,
            m_Ascent_,
            m_Descent_,
            m_DefaultStyle_,
            m_FontNames_,
            m_FallbackFonts_,
            m_FontRenderingMode_,
            m_UseLegacyBoundsCalculation_,
            m_ShouldRoundAdvanceValue_);
    }

    public override string ToString() => $"Font\n{ToString(4)}";

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
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);
        ToString_Field15(sb, indent, indent_);
        ToString_Field16(sb, indent, indent_);
        ToString_Field17(sb, indent, indent_);
        ToString_Field18(sb, indent, indent_);
        ToString_Field19(sb, indent, indent_);
        ToString_Field20(sb, indent, indent_);
        ToString_Field21(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LineSpacing: {m_LineSpacing}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DefaultMaterial: {m_DefaultMaterial}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_FontSize: {m_FontSize}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Texture: {m_Texture}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_AsciiStartOffset: {m_AsciiStartOffset}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Tracking: {m_Tracking}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CharacterSpacing: {m_CharacterSpacing}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CharacterPadding: {m_CharacterPadding}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ConvertCase: {m_ConvertCase}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_CharacterRects[{m_CharacterRects.Length}] = {{");
        if (m_CharacterRects.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (CharacterInfo _4 in m_CharacterRects)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_CharacterRects.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_KerningValues[{m_KerningValues.Count}] = {{");
        if (m_KerningValues.Count > 0) sb.AppendLine();
        int _4i = 0;
        foreach (KeyValuePair<pair, float> _4 in m_KerningValues)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4.Key}] = {_4.Value}");
            ++_4i;
        }
        if (m_KerningValues.Count > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PixelScale: {m_PixelScale}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_FontData[{m_FontData.Length}] = {{");
        if (m_FontData.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (char _4 in m_FontData)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_FontData.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Ascent: {m_Ascent}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Descent: {m_Descent}");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DefaultStyle: {m_DefaultStyle}");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_FontNames[{m_FontNames.Length}] = {{");
        if (m_FontNames.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (AsciiString _4 in m_FontNames)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = \"{_4}\"");
            ++_4i;
        }
        if (m_FontNames.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_FallbackFonts[{m_FallbackFonts.Length}] = {{");
        if (m_FallbackFonts.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtr<Font> _4 in m_FallbackFonts)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_FallbackFonts.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field19(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_FontRenderingMode: {m_FontRenderingMode}");
    }

    public void ToString_Field20(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UseLegacyBoundsCalculation: {m_UseLegacyBoundsCalculation}");
    }

    public void ToString_Field21(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ShouldRoundAdvanceValue: {m_ShouldRoundAdvanceValue}");
    }
}

