namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DialogCuePCView (12 fields) 7AE7EDF3539BA48C115A4C059DC7DE01/CE6CF1D1E6A5192F91F6A8C6EB3A50CF */
public record class DialogCuePCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasGroup> m_CueGroup /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Text /* None */,
    int m_NormalFontStyle /* None */,
    int m_HighlightFontStyle /* None */,
    int m_SpecialFontStyle /* None */,
    int m_SpecialFontSize /* None */,
    float m_DefaultFontSize /* None */,
    float m_DefaultConsoleFontSize /* None */)
{
    public static DialogCuePCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CueGroup */
        PPtr<CanvasGroup> _m_CueGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Text = PPtr<TextMeshProUGUI>.Read(reader);
        int _m_NormalFontStyle = reader.ReadS32();
        int _m_HighlightFontStyle = reader.ReadS32();
        int _m_SpecialFontStyle = reader.ReadS32();
        int _m_SpecialFontSize = reader.ReadS32();
        float _m_DefaultFontSize = reader.ReadF32();
        float _m_DefaultConsoleFontSize = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CueGroup,
            _m_Text,
            _m_NormalFontStyle,
            _m_HighlightFontStyle,
            _m_SpecialFontStyle,
            _m_SpecialFontSize,
            _m_DefaultFontSize,
            _m_DefaultConsoleFontSize);
    }
}

