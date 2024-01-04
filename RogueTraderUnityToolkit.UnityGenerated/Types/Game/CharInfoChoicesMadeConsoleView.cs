namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoChoicesMadeConsoleView (10 fields) B7BF6D61F39E10C17217FCC30C26BA1B/8FBBE2C2BA910A8CC025CFB6C65979C7 */
public record class CharInfoChoicesMadeConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Label /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<CharInfoSoulMarkShiftRecordPCView> m_SoulMarkShiftRecordView /* None */,
    PPtr<ScrollRectExtended> m_ScrollView /* None */,
    PPtr<ConsoleHint> m_ScrollHint /* None */)
{
    public static CharInfoChoicesMadeConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<CharInfoSoulMarkShiftRecordPCView> _m_SoulMarkShiftRecordView = PPtr<CharInfoSoulMarkShiftRecordPCView>.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollView = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<ConsoleHint> _m_ScrollHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_Label,
            _m_WidgetList,
            _m_SoulMarkShiftRecordView,
            _m_ScrollView,
            _m_ScrollHint);
    }
}

