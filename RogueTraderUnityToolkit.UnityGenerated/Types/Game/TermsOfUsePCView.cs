namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TermsOfUsePCView (12 fields) 0B5C58DD5AEA9B4C912315B013F3D88A/8007FF640C397B80DEC936B1B8100A20 */
public record class TermsOfUsePCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_MainContainer /* NeedsAlign */,
    PPtr<MoveAnimator> m_Header /* None */,
    PPtr<TextMeshProUGUI> m_Licence /* None */,
    PPtr<TextMeshProUGUI> m_Title /* None */,
    PPtr<TextMeshProUGUI> m_SubLicence /* None */,
    PPtr<TextMeshProUGUI> m_OkLabel /* None */,
    PPtr<OwlcatButton> m_ButtonOk /* None */,
    PPtr<OwlcatButton> m_ButtonClose /* None */)
{
    public static TermsOfUsePCView Read(EndianBinaryReader reader)
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
        PPtr<TextMeshProUGUI> _m_OkLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_ButtonOk = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_ButtonClose = PPtr<OwlcatButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MainContainer,
            _m_Header,
            _m_Licence,
            _m_Title,
            _m_SubLicence,
            _m_OkLabel,
            _m_ButtonOk,
            _m_ButtonClose);
    }
}

