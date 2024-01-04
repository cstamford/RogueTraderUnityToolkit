namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickAbilityScoresBlockConsoleView (9 fields) C5503C792E55B28288D2478DF4BD01FD/C2CDD7A25325A30E72738AB51932077A */
public record class TooltipBrickAbilityScoresBlockConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Title /* NeedsAlign */,
    PPtr<CharInfoAbilityScoresBlockBaseView> m_AbilityScoresBlockView /* None */,
    float m_DefaultFontSize /* None */,
    float m_DefaultConsoleFontSize /* None */,
    PPtr<OwlcatMultiButton> m_TitleFrame /* None */)
{
    public static TooltipBrickAbilityScoresBlockConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Title */
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CharInfoAbilityScoresBlockBaseView> _m_AbilityScoresBlockView = PPtr<CharInfoAbilityScoresBlockBaseView>.Read(reader);
        float _m_DefaultFontSize = reader.ReadF32();
        float _m_DefaultConsoleFontSize = reader.ReadF32();
        PPtr<OwlcatMultiButton> _m_TitleFrame = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Title,
            _m_AbilityScoresBlockView,
            _m_DefaultFontSize,
            _m_DefaultConsoleFontSize,
            _m_TitleFrame);
    }
}

