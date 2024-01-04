namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickPlanetTraitsView (10 fields) CC04954F5B61BCB98F819E141497AAE9/BA2D4BE9207CE3BADE8675425263D3E2 */
public record class TooltipBrickPlanetTraitsView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Title /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Description /* None */,
    float m_DefaultFontSizeTitle /* None */,
    float m_DefaultFontSizeDescription /* None */,
    float m_DefaultConsoleFontSizeTitle /* None */,
    float m_DefaultConsoleFontSizeDescription /* None */)
{
    public static TooltipBrickPlanetTraitsView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Title */
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Description = PPtr<TextMeshProUGUI>.Read(reader);
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
            _m_DefaultFontSizeTitle,
            _m_DefaultFontSizeDescription,
            _m_DefaultConsoleFontSizeTitle,
            _m_DefaultConsoleFontSizeDescription);
    }
}

