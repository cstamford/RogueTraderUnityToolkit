namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $Font (22 fields) 2253156A689268228F148ABCABE7844E */
public record class Font(
    AsciiString m_Name /* None */,
    float m_LineSpacing /* NeedsAlign */,
    PPtr<Material> m_DefaultMaterial /* None */,
    float m_FontSize /* None */,
    PPtr<Texture> m_Texture /* None */,
    int m_AsciiStartOffset /* NeedsAlign */,
    float m_Tracking /* None */,
    int m_CharacterSpacing /* None */,
    int m_CharacterPadding /* None */,
    int m_ConvertCase /* None */,
    CharacterInfo[] m_CharacterRects /* None */,
    Dictionary<pair, float> m_KerningValues /* NeedsAlign */,
    float m_PixelScale /* None */,
    char[] m_FontData /* NeedsAlign */,
    float m_Ascent /* NeedsAlign */,
    float m_Descent /* None */,
    uint m_DefaultStyle /* None */,
    AsciiString[] m_FontNames /* None */,
    PPtr<Font>[] m_FallbackFonts /* NeedsAlign */,
    int m_FontRenderingMode /* NeedsAlign */,
    bool m_UseLegacyBoundsCalculation /* None */,
    bool m_ShouldRoundAdvanceValue /* None */) : IUnityObject
{
    public static Hash128 Hash => new(575870314, 1754425378, 2400488124, 2884076622);
    public static Font Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_LineSpacing */
        float _m_LineSpacing = reader.ReadF32();
        PPtr<Material> _m_DefaultMaterial = PPtr<Material>.Read(reader);
        float _m_FontSize = reader.ReadF32();
        PPtr<Texture> _m_Texture = PPtr<Texture>.Read(reader);
        reader.AlignTo(4); /* m_AsciiStartOffset */
        int _m_AsciiStartOffset = reader.ReadS32();
        float _m_Tracking = reader.ReadF32();
        int _m_CharacterSpacing = reader.ReadS32();
        int _m_CharacterPadding = reader.ReadS32();
        int _m_ConvertCase = reader.ReadS32();
        CharacterInfo[] _m_CharacterRects = BuiltInArray<CharacterInfo>.Read(reader);
        reader.AlignTo(4); /* m_KerningValues */
        Dictionary<pair, float> _m_KerningValues = BuiltInMap<pair, float>.Read(reader);
        float _m_PixelScale = reader.ReadF32();
        reader.AlignTo(4); /* m_FontData */
        char[] _m_FontData = BuiltInArray<char>.Read(reader);
        reader.AlignTo(4); /* m_Ascent */
        float _m_Ascent = reader.ReadF32();
        float _m_Descent = reader.ReadF32();
        uint _m_DefaultStyle = reader.ReadU32();
        AsciiString[] _m_FontNames = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_FallbackFonts */
        PPtr<Font>[] _m_FallbackFonts = BuiltInArray<PPtr<Font>>.Read(reader);
        reader.AlignTo(4); /* m_FontRenderingMode */
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
}

