namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AnomalyPCView (12 fields) C0B577A001973B33810ED21E25F5E2B1/804DEF32DF00D9957605E1F6EEB7E97A */
public record class AnomalyPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<StatCheckLootPCView> m_StatCheckLootView /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_AnomalyName /* None */,
    PPtr<TextMeshProUGUI> m_AnomalyDescription /* None */,
    PPtr<GameObject> m_FullyScannedContainer /* None */,
    PPtr<TextMeshProUGUI> m_VisitAnomalyButtonText /* None */,
    PPtr<OwlcatButton> m_VisitAnomalyButton /* None */,
    PPtr<OwlcatButton> m_CloseButton /* None */,
    PPtr<FadeAnimator> m_Animator /* None */)
{
    public static AnomalyPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_StatCheckLootView */
        PPtr<StatCheckLootPCView> _m_StatCheckLootView = PPtr<StatCheckLootPCView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AnomalyName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AnomalyDescription = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_FullyScannedContainer = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_VisitAnomalyButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_VisitAnomalyButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_CloseButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<FadeAnimator> _m_Animator = PPtr<FadeAnimator>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_StatCheckLootView,
            _m_AnomalyName,
            _m_AnomalyDescription,
            _m_FullyScannedContainer,
            _m_VisitAnomalyButtonText,
            _m_VisitAnomalyButton,
            _m_CloseButton,
            _m_Animator);
    }
}

