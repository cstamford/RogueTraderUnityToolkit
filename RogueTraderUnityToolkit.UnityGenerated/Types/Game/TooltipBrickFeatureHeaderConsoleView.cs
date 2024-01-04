namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickFeatureHeaderConsoleView (14 fields) 34AC9FB496EAB813A7C370742696DCE3/1DB00CBC8E8DEC4026B43E2EB95027D4 */
public record class TooltipBrickFeatureHeaderConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Label /* NeedsAlign */,
    PPtr<Image> m_Icon /* None */,
    PPtr<TextMeshProUGUI> m_AdditionalDescription1 /* None */,
    PPtr<TextMeshProUGUI> m_AdditionalDescription2 /* None */,
    PPtr<TextMeshProUGUI> m_Acronym /* None */,
    float m_DefaultFontSize /* None */,
    float m_AdditionalDescDefaultFontSize /* None */,
    float m_DefaultConsoleFontSize /* None */,
    float m_AdditionalDescDefaultConsoleFontSize /* None */,
    PPtr<OwlcatMultiButton> m_MultiButton /* None */)
{
    public static TooltipBrickFeatureHeaderConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Label */
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AdditionalDescription1 = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AdditionalDescription2 = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Acronym = PPtr<TextMeshProUGUI>.Read(reader);
        float _m_DefaultFontSize = reader.ReadF32();
        float _m_AdditionalDescDefaultFontSize = reader.ReadF32();
        float _m_DefaultConsoleFontSize = reader.ReadF32();
        float _m_AdditionalDescDefaultConsoleFontSize = reader.ReadF32();
        PPtr<OwlcatMultiButton> _m_MultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Label,
            _m_Icon,
            _m_AdditionalDescription1,
            _m_AdditionalDescription2,
            _m_Acronym,
            _m_DefaultFontSize,
            _m_AdditionalDescDefaultFontSize,
            _m_DefaultConsoleFontSize,
            _m_AdditionalDescDefaultConsoleFontSize,
            _m_MultiButton);
    }
}

