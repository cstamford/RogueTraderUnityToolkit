namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickAbilityTargetView (15 fields) 1CC034D32F26BF4C7131CF24F5AF4299/44F22D7E249345BF1F91D34C18F51B61 */
public record class TooltipBrickAbilityTargetView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_Icon /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Title /* None */,
    PPtr<TextMeshProUGUI> m_Text /* None */,
    PPtr<LayoutElement> m_IconContainer /* None */,
    int m_BigSize /* None */,
    int m_MediumSize /* None */,
    int m_SmallSize /* None */,
    float m_DefaultFontSizeTitle /* None */,
    float m_DefaultFontSizeText /* None */,
    float m_DefaultConsoleFontSizeTitle /* None */,
    float m_DefaultConsoleFontSizeText /* None */)
{
    public static TooltipBrickAbilityTargetView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Icon */
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Text = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<LayoutElement> _m_IconContainer = PPtr<LayoutElement>.Read(reader);
        int _m_BigSize = reader.ReadS32();
        int _m_MediumSize = reader.ReadS32();
        int _m_SmallSize = reader.ReadS32();
        float _m_DefaultFontSizeTitle = reader.ReadF32();
        float _m_DefaultFontSizeText = reader.ReadF32();
        float _m_DefaultConsoleFontSizeTitle = reader.ReadF32();
        float _m_DefaultConsoleFontSizeText = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Icon,
            _m_Title,
            _m_Text,
            _m_IconContainer,
            _m_BigSize,
            _m_MediumSize,
            _m_SmallSize,
            _m_DefaultFontSizeTitle,
            _m_DefaultFontSizeText,
            _m_DefaultConsoleFontSizeTitle,
            _m_DefaultConsoleFontSizeText);
    }
}

