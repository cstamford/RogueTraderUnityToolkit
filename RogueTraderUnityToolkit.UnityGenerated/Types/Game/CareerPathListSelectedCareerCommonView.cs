namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CareerPathListSelectedCareerCommonView (11 fields) BEEB61CE4A02E9F1D1910B47C7358FAE/EB9FF58D213A152673B12DF332130046 */
public record class CareerPathListSelectedCareerCommonView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_MainButton /* NeedsAlign */,
    PPtr<CareerPathRoundProgressionCommonView> m_CareerPathRoundProgressionCommonView /* None */,
    PPtr<TextMeshProUGUI> m_SelectedCareerStatusLabel /* None */,
    PPtr<TextMeshProUGUI> m_SelectedCareerUpgradesLabel /* None */,
    PPtr<TextMeshProUGUI> m_ClickToDoctrineLabel /* None */,
    AsciiString m_ClickToDoctrinePrefix /* None */,
    PPtr<RectTransform> m_TooltipPlace /* NeedsAlign */)
{
    public static CareerPathListSelectedCareerCommonView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MainButton */
        PPtr<OwlcatMultiButton> _m_MainButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<CareerPathRoundProgressionCommonView> _m_CareerPathRoundProgressionCommonView = PPtr<CareerPathRoundProgressionCommonView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SelectedCareerStatusLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SelectedCareerUpgradesLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ClickToDoctrineLabel = PPtr<TextMeshProUGUI>.Read(reader);
        AsciiString _m_ClickToDoctrinePrefix = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TooltipPlace */
        PPtr<RectTransform> _m_TooltipPlace = PPtr<RectTransform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MainButton,
            _m_CareerPathRoundProgressionCommonView,
            _m_SelectedCareerStatusLabel,
            _m_SelectedCareerUpgradesLabel,
            _m_ClickToDoctrineLabel,
            _m_ClickToDoctrinePrefix,
            _m_TooltipPlace);
    }
}

