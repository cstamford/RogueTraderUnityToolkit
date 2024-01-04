namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyProjectsPCView (14 fields) F4A3337CA0D12DD4E6C5838D267BED35/3DCE7427E2CDE133BD602C334950775C */
public record class ColonyProjectsPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_HeaderLabel /* NeedsAlign */,
    PPtr<OwlcatButton> m_StartProjectButton /* None */,
    PPtr<TextMeshProUGUI> m_StartProjectButtonLabel /* None */,
    PPtr<OwlcatMultiButton> m_ShowBlockedProjectsButton /* None */,
    PPtr<TextMeshProUGUI> m_ShowBlockedProjectsButtonLabel /* None */,
    PPtr<OwlcatMultiButton> m_ShowFinishedProjectsButton /* None */,
    PPtr<TextMeshProUGUI> m_ShowFinishedProjectsButtonLabel /* None */,
    PPtr<OwlcatButton> m_CloseButton /* None */,
    PPtr<ColonyProjectsNavigationPCView> m_Navigation /* None */,
    PPtr<ColonyProjectsPagePCView> m_Page /* None */)
{
    public static ColonyProjectsPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HeaderLabel */
        PPtr<TextMeshProUGUI> _m_HeaderLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_StartProjectButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_StartProjectButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ShowBlockedProjectsButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ShowBlockedProjectsButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ShowFinishedProjectsButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ShowFinishedProjectsButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_CloseButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<ColonyProjectsNavigationPCView> _m_Navigation = PPtr<ColonyProjectsNavigationPCView>.Read(reader);
        PPtr<ColonyProjectsPagePCView> _m_Page = PPtr<ColonyProjectsPagePCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HeaderLabel,
            _m_StartProjectButton,
            _m_StartProjectButtonLabel,
            _m_ShowBlockedProjectsButton,
            _m_ShowBlockedProjectsButtonLabel,
            _m_ShowFinishedProjectsButton,
            _m_ShowFinishedProjectsButtonLabel,
            _m_CloseButton,
            _m_Navigation,
            _m_Page);
    }
}

