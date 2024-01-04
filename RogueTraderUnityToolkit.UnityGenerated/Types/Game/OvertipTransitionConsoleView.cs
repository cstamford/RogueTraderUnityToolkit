namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OvertipTransitionConsoleView (12 fields) FD03F4192DA344E598F4EAEE103220CF/8EB848AC20BDB55E200289AD1AE2F509 */
public record class OvertipTransitionConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_Button /* NeedsAlign */,
    PPtr<CanvasGroup> m_TitleBlock /* None */,
    PPtr<TextMeshProUGUI> m_Title /* None */,
    PPtr<CanvasGroup> m_ActiveLayer /* None */,
    PPtr<OvertipConsoleView> m_OvertipConsoleView /* None */,
    byte m_NeedHintPositionCorrection /* None */,
    float m_UpperY /* NeedsAlign */,
    float m_LowerY /* None */)
{
    public static OvertipTransitionConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Button */
        PPtr<OwlcatMultiButton> _m_Button = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<CanvasGroup> _m_TitleBlock = PPtr<CanvasGroup>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CanvasGroup> _m_ActiveLayer = PPtr<CanvasGroup>.Read(reader);
        PPtr<OvertipConsoleView> _m_OvertipConsoleView = PPtr<OvertipConsoleView>.Read(reader);
        byte _m_NeedHintPositionCorrection = reader.ReadU8();
        reader.AlignTo(4); /* m_UpperY */
        float _m_UpperY = reader.ReadF32();
        float _m_LowerY = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Button,
            _m_TitleBlock,
            _m_Title,
            _m_ActiveLayer,
            _m_OvertipConsoleView,
            _m_NeedHintPositionCorrection,
            _m_UpperY,
            _m_LowerY);
    }
}

