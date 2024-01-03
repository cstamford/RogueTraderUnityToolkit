namespace RogueTraderUnityToolkit.Unity.Generated.Engine;

using Core;

/* $Font (22 fields) (IsEngineType) */
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
    bool m_ShouldRoundAdvanceValue)
{
    public static Font Read(EndianBinaryReader reader)
    {
        AsciiString m_Name = String.Read(reader);
        float m_LineSpacing = reader.ReadF32();
        PPtr<Material> m_DefaultMaterial = PPtr<Material>.Read(reader);
        float m_FontSize = reader.ReadF32();
        PPtr<Texture> m_Texture = PPtr<Texture>.Read(reader);
        int m_AsciiStartOffset = reader.ReadS32();
        float m_Tracking = reader.ReadF32();
        int m_CharacterSpacing = reader.ReadS32();
        int m_CharacterPadding = reader.ReadS32();
        int m_ConvertCase = reader.ReadS32();
        CharacterInfo[] m_CharacterRects = Array<CharacterInfo>.Read(reader);
        Dictionary<pair, float> m_KerningValues = Map<pair, float>.Read(reader);
        float m_PixelScale = reader.ReadF32();
        char[] m_FontData = Array<char>.Read(reader);
        float m_Ascent = reader.ReadF32();
        float m_Descent = reader.ReadF32();
        uint m_DefaultStyle = reader.ReadU32();
        AsciiString[] m_FontNames = Array<AsciiString>.Read(reader);
        PPtr<Font>[] m_FallbackFonts = Array<PPtr<Font>>.Read(reader);
        int m_FontRenderingMode = reader.ReadS32();
        bool m_UseLegacyBoundsCalculation = reader.ReadBool();
        bool m_ShouldRoundAdvanceValue = reader.ReadBool();
        
        return new(m_Name,
            m_LineSpacing,
            m_DefaultMaterial,
            m_FontSize,
            m_Texture,
            m_AsciiStartOffset,
            m_Tracking,
            m_CharacterSpacing,
            m_CharacterPadding,
            m_ConvertCase,
            m_CharacterRects,
            m_KerningValues,
            m_PixelScale,
            m_FontData,
            m_Ascent,
            m_Descent,
            m_DefaultStyle,
            m_FontNames,
            m_FallbackFonts,
            m_FontRenderingMode,
            m_UseLegacyBoundsCalculation,
            m_ShouldRoundAdvanceValue);
    }
}

