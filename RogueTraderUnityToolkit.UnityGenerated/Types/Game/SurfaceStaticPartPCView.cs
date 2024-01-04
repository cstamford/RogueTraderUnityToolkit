namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceStaticPartPCView (20 fields) 91284FCCAB64ACA783DF9E1BB37D7BB8/A8E9E54E7A355BDC0F2BA0027BF6EA75 */
public record class SurfaceStaticPartPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<UIVisibilityView> m_UIVisibilityView /* NeedsAlign */,
    PPtr<ServiceWindowsPCView> m_ServiceWindowsPCView /* None */,
    PPtr<LootContextPCView> m_LootContextPCView /* None */,
    PPtr<DialogContextPCView> m_DialogContextPCView /* None */,
    PPtr<GroupChangerContextPCView> m_GroupChangerContextPCView /* None */,
    UIViewLink_2 m_TransitionPCViewLink /* None */,
    PPtr<FormationPCView> m_FormationPCView /* NeedsAlign */,
    PPtr<CreditsPCView> m_CreditsPCView /* None */,
    UIViewLink_2 m_VendorPCViewLink /* None */,
    PPtr<VendorSelectingWindowPCView> m_VendorSelectingWindowContextPCView /* NeedsAlign */,
    PPtr<SurfaceHUDPCView> SurfaceHUDView /* None */,
    PPtr<GameOverPCView> m_GameOverPCView /* None */,
    PPtr<SubtitleView> m_SubtitleView /* None */,
    PPtr<EtudeCounterView> m_EtudeCounterView /* None */,
    PPtr<CharGenContextPCView> m_CharGenContextPCView /* None */,
    PPtr<RespecContextCommonView> m_RespecContextCommonView /* None */)
{
    public static SurfaceStaticPartPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_UIVisibilityView */
        PPtr<UIVisibilityView> _m_UIVisibilityView = PPtr<UIVisibilityView>.Read(reader);
        PPtr<ServiceWindowsPCView> _m_ServiceWindowsPCView = PPtr<ServiceWindowsPCView>.Read(reader);
        PPtr<LootContextPCView> _m_LootContextPCView = PPtr<LootContextPCView>.Read(reader);
        PPtr<DialogContextPCView> _m_DialogContextPCView = PPtr<DialogContextPCView>.Read(reader);
        PPtr<GroupChangerContextPCView> _m_GroupChangerContextPCView = PPtr<GroupChangerContextPCView>.Read(reader);
        UIViewLink_2 _m_TransitionPCViewLink = UIViewLink_2.Read(reader);
        reader.AlignTo(4); /* m_FormationPCView */
        PPtr<FormationPCView> _m_FormationPCView = PPtr<FormationPCView>.Read(reader);
        PPtr<CreditsPCView> _m_CreditsPCView = PPtr<CreditsPCView>.Read(reader);
        UIViewLink_2 _m_VendorPCViewLink = UIViewLink_2.Read(reader);
        reader.AlignTo(4); /* m_VendorSelectingWindowContextPCView */
        PPtr<VendorSelectingWindowPCView> _m_VendorSelectingWindowContextPCView = PPtr<VendorSelectingWindowPCView>.Read(reader);
        PPtr<SurfaceHUDPCView> _SurfaceHUDView = PPtr<SurfaceHUDPCView>.Read(reader);
        PPtr<GameOverPCView> _m_GameOverPCView = PPtr<GameOverPCView>.Read(reader);
        PPtr<SubtitleView> _m_SubtitleView = PPtr<SubtitleView>.Read(reader);
        PPtr<EtudeCounterView> _m_EtudeCounterView = PPtr<EtudeCounterView>.Read(reader);
        PPtr<CharGenContextPCView> _m_CharGenContextPCView = PPtr<CharGenContextPCView>.Read(reader);
        PPtr<RespecContextCommonView> _m_RespecContextCommonView = PPtr<RespecContextCommonView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_UIVisibilityView,
            _m_ServiceWindowsPCView,
            _m_LootContextPCView,
            _m_DialogContextPCView,
            _m_GroupChangerContextPCView,
            _m_TransitionPCViewLink,
            _m_FormationPCView,
            _m_CreditsPCView,
            _m_VendorPCViewLink,
            _m_VendorSelectingWindowContextPCView,
            _SurfaceHUDView,
            _m_GameOverPCView,
            _m_SubtitleView,
            _m_EtudeCounterView,
            _m_CharGenContextPCView,
            _m_RespecContextCommonView);
    }
}

