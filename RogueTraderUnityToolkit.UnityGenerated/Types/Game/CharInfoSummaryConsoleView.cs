namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoSummaryConsoleView (14 fields) B98E7AA1659F9BC1AC6C7C273673276D/4D8A9F4C4B8006A86BDC31E736C748D2 */
public record class CharInfoSummaryConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<CharInfoStatusEffectsView> m_StatusEffectsView /* None */,
    PPtr<OwlcatMultiButton> m_MovePointsButton /* None */,
    PPtr<TextMeshProUGUI> m_MovePointsLabel /* None */,
    PPtr<TextMeshProUGUI> m_MovePoints /* None */,
    PPtr<OwlcatMultiButton> m_ActionPointsButton /* None */,
    PPtr<TextMeshProUGUI> m_ActionPointsLabel /* None */,
    PPtr<TextMeshProUGUI> m_ActionPoints /* None */,
    PPtr<CharInfoAlignmentWheelPCView> m_AlignmentWheelPCView /* None */,
    PPtr<CharInfoCurrentCareerView> m_CareerView /* None */)
{
    public static CharInfoSummaryConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<CharInfoStatusEffectsView> _m_StatusEffectsView = PPtr<CharInfoStatusEffectsView>.Read(reader);
        PPtr<OwlcatMultiButton> _m_MovePointsButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_MovePointsLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_MovePoints = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ActionPointsButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ActionPointsLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ActionPoints = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CharInfoAlignmentWheelPCView> _m_AlignmentWheelPCView = PPtr<CharInfoAlignmentWheelPCView>.Read(reader);
        PPtr<CharInfoCurrentCareerView> _m_CareerView = PPtr<CharInfoCurrentCareerView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_StatusEffectsView,
            _m_MovePointsButton,
            _m_MovePointsLabel,
            _m_MovePoints,
            _m_ActionPointsButton,
            _m_ActionPointsLabel,
            _m_ActionPoints,
            _m_AlignmentWheelPCView,
            _m_CareerView);
    }
}

