namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipHealthAndRepairPCView (37 fields) 26F4C100B499CFA8115EC0FDAA001BAD/BB918269C7F168B1E69752A0D94E67F4 */
public record class ShipHealthAndRepairPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_ScrapWeHave /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_VoidshipHealthText /* None */,
    PPtr<RectTransform> m_HPBarMaxHealth /* None */,
    PPtr<RectTransform> m_HPBarHealth /* None */,
    PPtr<RectTransform> m_HPBarHealthAfterRepair /* None */,
    PPtr<Image> m_ShipIcon /* None */,
    PPtr<FadeAnimator> m_ButtonRepairAnimator /* None */,
    PPtr<GameObject> m_NeedRepairBlock /* None */,
    PPtr<TextMeshProUGUI> m_CostRepair /* None */,
    PPtr<TextMeshProUGUI> m_RepairHullText /* None */,
    PPtr<GameObject> m_FullHpBlock /* None */,
    PPtr<TextMeshProUGUI> m_FullHpText /* None */,
    PPtr<GameObject> m_NeedMoreMoneyBlock /* None */,
    PPtr<TextMeshProUGUI> m_NeedMoreMoneyText /* None */,
    PPtr<TextMeshProUGUI> m_HowMuchMoneyWeNeed /* None */,
    byte HasPartsLabels /* None */,
    PPtr<TextMeshProUGUI> m_EngineLabel /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_RamLabel /* None */,
    PPtr<TextMeshProUGUI> m_ShieldsLabel /* None */,
    PPtr<TextMeshProUGUI> m_RepairLabel /* None */,
    PPtr<TextMeshProUGUI> m_DamageReductionLabel /* None */,
    PPtr<TextMeshProUGUI> m_DamageBonusLabel /* None */,
    PPtr<CanvasGroup>[] m_HealthMark /* None */,
    PPtr<Image> m_HPBarTooltipObject /* None */,
    PPtr<Image> m_VoidshipHealthTextTooltipObject /* None */,
    PPtr<OwlcatButton> m_ButtonRepair /* None */,
    PPtr<FadeAnimator> m_DialogBoxAnimator /* None */,
    PPtr<TextMeshProUGUI> m_DialogBoxDescription /* None */,
    PPtr<OwlcatButton> m_DialogBoxOkButton /* None */,
    PPtr<OwlcatButton> m_DialogBoxAbortButton /* None */,
    PPtr<TextMeshProUGUI> m_DialogBoxOkLabel /* None */,
    PPtr<TextMeshProUGUI> m_DialogBoxAbortLabel /* None */,
    PPtr<RectTransform> TooltipPlace /* None */)
{
    public static ShipHealthAndRepairPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ScrapWeHave */
        PPtr<TextMeshProUGUI> _m_ScrapWeHave = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_VoidshipHealthText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<RectTransform> _m_HPBarMaxHealth = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_HPBarHealth = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_HPBarHealthAfterRepair = PPtr<RectTransform>.Read(reader);
        PPtr<Image> _m_ShipIcon = PPtr<Image>.Read(reader);
        PPtr<FadeAnimator> _m_ButtonRepairAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<GameObject> _m_NeedRepairBlock = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CostRepair = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RepairHullText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_FullHpBlock = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_FullHpText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_NeedMoreMoneyBlock = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NeedMoreMoneyText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_HowMuchMoneyWeNeed = PPtr<TextMeshProUGUI>.Read(reader);
        byte _HasPartsLabels = reader.ReadU8();
        reader.AlignTo(4); /* m_EngineLabel */
        PPtr<TextMeshProUGUI> _m_EngineLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RamLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ShieldsLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RepairLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DamageReductionLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DamageBonusLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CanvasGroup>[] _m_HealthMark = BuiltInArray<PPtr<CanvasGroup>>.Read(reader);
        PPtr<Image> _m_HPBarTooltipObject = PPtr<Image>.Read(reader);
        PPtr<Image> _m_VoidshipHealthTextTooltipObject = PPtr<Image>.Read(reader);
        PPtr<OwlcatButton> _m_ButtonRepair = PPtr<OwlcatButton>.Read(reader);
        PPtr<FadeAnimator> _m_DialogBoxAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DialogBoxDescription = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_DialogBoxOkButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_DialogBoxAbortButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DialogBoxOkLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DialogBoxAbortLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<RectTransform> _TooltipPlace = PPtr<RectTransform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ScrapWeHave,
            _m_VoidshipHealthText,
            _m_HPBarMaxHealth,
            _m_HPBarHealth,
            _m_HPBarHealthAfterRepair,
            _m_ShipIcon,
            _m_ButtonRepairAnimator,
            _m_NeedRepairBlock,
            _m_CostRepair,
            _m_RepairHullText,
            _m_FullHpBlock,
            _m_FullHpText,
            _m_NeedMoreMoneyBlock,
            _m_NeedMoreMoneyText,
            _m_HowMuchMoneyWeNeed,
            _HasPartsLabels,
            _m_EngineLabel,
            _m_RamLabel,
            _m_ShieldsLabel,
            _m_RepairLabel,
            _m_DamageReductionLabel,
            _m_DamageBonusLabel,
            _m_HealthMark,
            _m_HPBarTooltipObject,
            _m_VoidshipHealthTextTooltipObject,
            _m_ButtonRepair,
            _m_DialogBoxAnimator,
            _m_DialogBoxDescription,
            _m_DialogBoxOkButton,
            _m_DialogBoxAbortButton,
            _m_DialogBoxOkLabel,
            _m_DialogBoxAbortLabel,
            _TooltipPlace);
    }
}

