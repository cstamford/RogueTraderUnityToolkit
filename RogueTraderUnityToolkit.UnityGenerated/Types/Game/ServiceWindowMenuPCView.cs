namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ServiceWindowMenuPCView (8 fields) BF75E939FEA4CFF803ED4556E2D98353/80932CCFEBACAD03D21B7D95FF3187A9 */
public record class ServiceWindowMenuPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_Animator /* NeedsAlign */,
    PPtr<ServiceWindowMenuSelectorPCView> m_MenuSelector /* None */,
    PPtr<OwlcatButton> m_CloseButton /* None */,
    PPtr<GameObject> m_AdditionalBackground /* None */)
{
    public static ServiceWindowMenuPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Animator */
        PPtr<FadeAnimator> _m_Animator = PPtr<FadeAnimator>.Read(reader);
        PPtr<ServiceWindowMenuSelectorPCView> _m_MenuSelector = PPtr<ServiceWindowMenuSelectorPCView>.Read(reader);
        PPtr<OwlcatButton> _m_CloseButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<GameObject> _m_AdditionalBackground = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Animator,
            _m_MenuSelector,
            _m_CloseButton,
            _m_AdditionalBackground);
    }
}

