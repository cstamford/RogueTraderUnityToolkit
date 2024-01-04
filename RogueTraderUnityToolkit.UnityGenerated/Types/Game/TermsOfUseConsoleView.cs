namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TermsOfUseConsoleView (11 fields) 12E9A69F5190025F5FEB110B0E9700F1/DAD91F4957D17E5E3CC039DF418EE9BF */
public record class TermsOfUseConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_MainContainer /* NeedsAlign */,
    PPtr<MoveAnimator> m_Header /* None */,
    PPtr<TextMeshProUGUI> m_Licence /* None */,
    PPtr<TextMeshProUGUI> m_Title /* None */,
    PPtr<TextMeshProUGUI> m_SubLicence /* None */,
    PPtr<ScrollRectExtended> m_ScrollRect /* None */,
    PPtr<ConsoleHint> m_AcceptHint /* None */)
{
    public static TermsOfUseConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MainContainer */
        PPtr<FadeAnimator> _m_MainContainer = PPtr<FadeAnimator>.Read(reader);
        PPtr<MoveAnimator> _m_Header = PPtr<MoveAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Licence = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SubLicence = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<ConsoleHint> _m_AcceptHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MainContainer,
            _m_Header,
            _m_Licence,
            _m_Title,
            _m_SubLicence,
            _m_ScrollRect,
            _m_AcceptHint);
    }
}

