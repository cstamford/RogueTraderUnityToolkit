namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Font (22 fields) 2253156A689268228F148ABCABE7844E */
public record class Font(
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
    Dictionary<pair_0, float> m_KerningValues,
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
    public static Hash128 Hash => new(575870314, 1754425378, 2400488124, 2884076622);

    public static Font Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        float _m_LineSpacing = reader.ReadF32();
        PPtr<Material> _m_DefaultMaterial = PPtr<Material>.Read(reader);
        float _m_FontSize = reader.ReadF32();
        PPtr<Texture> _m_Texture = PPtr<Texture>.Read(reader);
        reader.AlignTo(4); /* m_Texture */
        int _m_AsciiStartOffset = reader.ReadS32();
        float _m_Tracking = reader.ReadF32();
        int _m_CharacterSpacing = reader.ReadS32();
        int _m_CharacterPadding = reader.ReadS32();
        int _m_ConvertCase = reader.ReadS32();
        CharacterInfo[] _m_CharacterRects = BuiltInArray<CharacterInfo>.Read(reader);
        reader.AlignTo(4); /* m_CharacterRects */
        Dictionary<pair_0, float> _m_KerningValues = BuiltInMap<pair_0, float>.Read(reader);
        float _m_PixelScale = reader.ReadF32();
        reader.AlignTo(4); /* m_PixelScale */
        char[] _m_FontData = BuiltInArray<char>.Read(reader);
        reader.AlignTo(4); /* m_FontData */
        float _m_Ascent = reader.ReadF32();
        float _m_Descent = reader.ReadF32();
        uint _m_DefaultStyle = reader.ReadU32();
        AsciiString[] _m_FontNames = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_FontNames */
        PPtr<Font>[] _m_FallbackFonts = BuiltInArray<PPtr<Font>>.Read(reader);
        reader.AlignTo(4); /* m_FallbackFonts */
        int _m_FontRenderingMode = reader.ReadS32();
        bool _m_UseLegacyBoundsCalculation = reader.ReadBool();
        bool _m_ShouldRoundAdvanceValue = reader.ReadBool();
        
        return new(_m_Name,
            _m_LineSpacing,
            _m_DefaultMaterial,
            _m_FontSize,
            _m_Texture,
            _m_AsciiStartOffset,
            _m_Tracking,
            _m_CharacterSpacing,
            _m_CharacterPadding,
            _m_ConvertCase,
            _m_CharacterRects,
            _m_KerningValues,
            _m_PixelScale,
            _m_FontData,
            _m_Ascent,
            _m_Descent,
            _m_DefaultStyle,
            _m_FontNames,
            _m_FallbackFonts,
            _m_FontRenderingMode,
            _m_UseLegacyBoundsCalculation,
            _m_ShouldRoundAdvanceValue);
    }

    public override string ToString() => $"Font\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LineSpacing: ");
        sb.AppendLine(m_LineSpacing.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DefaultMaterial: ");
        sb.AppendLine(m_DefaultMaterial.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FontSize: ");
        sb.AppendLine(m_FontSize.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Texture: ");
        sb.AppendLine(m_Texture.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AsciiStartOffset: ");
        sb.AppendLine(m_AsciiStartOffset.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Tracking: ");
        sb.AppendLine(m_Tracking.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CharacterSpacing: ");
        sb.AppendLine(m_CharacterSpacing.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CharacterPadding: ");
        sb.AppendLine(m_CharacterPadding.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ConvertCase: ");
        sb.AppendLine(m_ConvertCase.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CharacterRects: ");
        sb.AppendLine(m_CharacterRects.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_KerningValues: ");
        sb.AppendLine(m_KerningValues.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PixelScale: ");
        sb.AppendLine(m_PixelScale.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FontData: ");
        sb.AppendLine(m_FontData.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Ascent: ");
        sb.AppendLine(m_Ascent.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Descent: ");
        sb.AppendLine(m_Descent.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DefaultStyle: ");
        sb.AppendLine(m_DefaultStyle.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FontNames: ");
        sb.AppendLine(m_FontNames.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FallbackFonts: ");
        sb.AppendLine(m_FallbackFonts.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FontRenderingMode: ");
        sb.AppendLine(m_FontRenderingMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_UseLegacyBoundsCalculation: ");
        sb.AppendLine(m_UseLegacyBoundsCalculation.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ShouldRoundAdvanceValue: ");
        sb.AppendLine(m_ShouldRoundAdvanceValue.ToString());

        return sb.ToString();
    }
}

