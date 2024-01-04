namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $EncyclopediaPageBlockGlossaryEntryPCView (11 fields) 32D383C22DA95ADB5B258B01BBA39205/ACCE17ED47A00A061E2C3A869CFBA9D9 */
public record class EncyclopediaPageBlockGlossaryEntryPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Title /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Description /* None */,
    ColorRGBA m_MarkColor /* None */,
    float m_DefaultFontSizeTitle /* None */,
    float m_DefaultFontSizeDescription /* None */,
    float m_DefaultConsoleFontSizeTitle /* None */,
    float m_DefaultConsoleFontSizeDescription /* None */)
{
    public static EncyclopediaPageBlockGlossaryEntryPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Title */
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Description = PPtr<TextMeshProUGUI>.Read(reader);
        ColorRGBA _m_MarkColor = ColorRGBA.Read(reader);
        float _m_DefaultFontSizeTitle = reader.ReadF32();
        float _m_DefaultFontSizeDescription = reader.ReadF32();
        float _m_DefaultConsoleFontSizeTitle = reader.ReadF32();
        float _m_DefaultConsoleFontSizeDescription = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Title,
            _m_Description,
            _m_MarkColor,
            _m_DefaultFontSizeTitle,
            _m_DefaultFontSizeDescription,
            _m_DefaultConsoleFontSizeTitle,
            _m_DefaultConsoleFontSizeDescription);
    }
}

