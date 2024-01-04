namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickPortraitAndNameConsoleView (13 fields) 9A596213DD7C98E8E65EEC524C2C0375/2BEA60FA6EF45DF49792E3198540433D */
public record class TooltipBrickPortraitAndNameConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiSelectable> m_MultiSelectableIcon /* NeedsAlign */,
    PPtr<OwlcatMultiSelectable> m_MultiSelectableBorderAndDifficulty /* None */,
    PPtr<Image> m_Icon /* None */,
    PPtr<TextMeshProUGUI> m_Title /* None */,
    PPtr<TooltipBrickTitleView> m_TitleView /* None */,
    PPtr<TextMeshProUGUI> m_DifficultyText /* None */,
    float m_DefaultFontSize /* None */,
    float m_DefaultConsoleFontSize /* None */,
    PPtr<OwlcatMultiButton> m_MultiButton /* None */)
{
    public static TooltipBrickPortraitAndNameConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MultiSelectableIcon */
        PPtr<OwlcatMultiSelectable> _m_MultiSelectableIcon = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<OwlcatMultiSelectable> _m_MultiSelectableBorderAndDifficulty = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TooltipBrickTitleView> _m_TitleView = PPtr<TooltipBrickTitleView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DifficultyText = PPtr<TextMeshProUGUI>.Read(reader);
        float _m_DefaultFontSize = reader.ReadF32();
        float _m_DefaultConsoleFontSize = reader.ReadF32();
        PPtr<OwlcatMultiButton> _m_MultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MultiSelectableIcon,
            _m_MultiSelectableBorderAndDifficulty,
            _m_Icon,
            _m_Title,
            _m_TitleView,
            _m_DifficultyText,
            _m_DefaultFontSize,
            _m_DefaultConsoleFontSize,
            _m_MultiButton);
    }
}

