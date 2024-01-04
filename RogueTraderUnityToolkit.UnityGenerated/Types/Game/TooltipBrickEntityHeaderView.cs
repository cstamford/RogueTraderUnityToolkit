namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickEntityHeaderView (15 fields) 4B017F522F960364225CFCC6E5DE30EB/48914934801A14EFE11CBE55CC5A45E7 */
public record class TooltipBrickEntityHeaderView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_MainTitle /* NeedsAlign */,
    PPtr<GameObject> m_ImageContainer /* None */,
    PPtr<Image> m_Image /* None */,
    PPtr<TextMeshProUGUI> m_Title /* None */,
    PPtr<TextMeshProUGUI> m_LeftLabel /* None */,
    PPtr<TextMeshProUGUI> m_RightLabel /* None */,
    PPtr<GameObject> m_UpgradeItemIndicator /* None */,
    float m_DefaultFontSizeTitle /* None */,
    float m_DefaultFontSize /* None */,
    float m_DefaultConsoleFontSizeTitle /* None */,
    float m_DefaultConsoleFontSize /* None */)
{
    public static TooltipBrickEntityHeaderView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MainTitle */
        PPtr<TextMeshProUGUI> _m_MainTitle = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_ImageContainer = PPtr<GameObject>.Read(reader);
        PPtr<Image> _m_Image = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_LeftLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RightLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_UpgradeItemIndicator = PPtr<GameObject>.Read(reader);
        float _m_DefaultFontSizeTitle = reader.ReadF32();
        float _m_DefaultFontSize = reader.ReadF32();
        float _m_DefaultConsoleFontSizeTitle = reader.ReadF32();
        float _m_DefaultConsoleFontSize = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MainTitle,
            _m_ImageContainer,
            _m_Image,
            _m_Title,
            _m_LeftLabel,
            _m_RightLabel,
            _m_UpgradeItemIndicator,
            _m_DefaultFontSizeTitle,
            _m_DefaultFontSize,
            _m_DefaultConsoleFontSizeTitle,
            _m_DefaultConsoleFontSize);
    }
}

