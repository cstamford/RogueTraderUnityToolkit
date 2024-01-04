namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickFeatureShortDescriptionConsoleView (15 fields) 555DB833B8338F1BD8EC121045D0933F/800B52F4F25A0C65590EF5E2ED7FB3C3 */
public record class TooltipBrickFeatureShortDescriptionConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Label /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Description /* None */,
    PPtr<Image> m_Icon /* None */,
    PPtr<Image> m_FrameIcon /* None */,
    PPtr<Sprite> m_DefaultFrame /* None */,
    PPtr<TextMeshProUGUI> m_Acronym /* None */,
    float m_DefaultFontSizeLabel /* None */,
    float m_DefaultFontSizeDescription /* None */,
    float m_DefaultConsoleFontSizeLabel /* None */,
    float m_DefaultConsoleFontSizeDescription /* None */,
    PPtr<OwlcatMultiButton> m_MultiButton /* None */)
{
    public static TooltipBrickFeatureShortDescriptionConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Label */
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Description = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<Image> _m_FrameIcon = PPtr<Image>.Read(reader);
        PPtr<Sprite> _m_DefaultFrame = PPtr<Sprite>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Acronym = PPtr<TextMeshProUGUI>.Read(reader);
        float _m_DefaultFontSizeLabel = reader.ReadF32();
        float _m_DefaultFontSizeDescription = reader.ReadF32();
        float _m_DefaultConsoleFontSizeLabel = reader.ReadF32();
        float _m_DefaultConsoleFontSizeDescription = reader.ReadF32();
        PPtr<OwlcatMultiButton> _m_MultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Label,
            _m_Description,
            _m_Icon,
            _m_FrameIcon,
            _m_DefaultFrame,
            _m_Acronym,
            _m_DefaultFontSizeLabel,
            _m_DefaultFontSizeDescription,
            _m_DefaultConsoleFontSizeLabel,
            _m_DefaultConsoleFontSizeDescription,
            _m_MultiButton);
    }
}

