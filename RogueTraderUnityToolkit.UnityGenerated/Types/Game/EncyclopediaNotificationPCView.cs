namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $EncyclopediaNotificationPCView (11 fields) 4C6A461966771B24C00BEEA59AE8F80D/03F00BA5EE6FFD3C861594ACD9734854 */
public record class EncyclopediaNotificationPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Status /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Title /* None */,
    PPtr<WindowAnimator> m_Animator /* None */,
    PPtr<OwlcatButton> m_ActionButton /* None */,
    PPtr<OwlcatButton> m_FullBodyButton /* None */,
    PPtr<OwlcatMultiButton> m_CloseButton /* None */,
    PPtr<TextMeshProUGUI> m_ActionButtonLabel /* None */)
{
    public static EncyclopediaNotificationPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Status */
        PPtr<TextMeshProUGUI> _m_Status = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<WindowAnimator> _m_Animator = PPtr<WindowAnimator>.Read(reader);
        PPtr<OwlcatButton> _m_ActionButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_FullBodyButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_CloseButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ActionButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Status,
            _m_Title,
            _m_Animator,
            _m_ActionButton,
            _m_FullBodyButton,
            _m_CloseButton,
            _m_ActionButtonLabel);
    }
}

