namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PostAbilityDetailedPCView (35 fields) 066BF6CD97729E0D41F06B96B08E2E8E/BFF5B53D9F2CD431E99365CBCDF06880 */
public record class PostAbilityDetailedPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_Icon /* NeedsAlign */,
    PPtr<Image> m_IconGrayScale /* None */,
    PPtr<TextMeshProUGUI> m_AbilityName /* None */,
    PPtr<OwlcatMultiButton> m_Selectable /* None */,
    PPtr<GameObject> m_AttunedStateBlock /* None */,
    PPtr<TextMeshProUGUI> m_AttunedStateText /* None */,
    PPtr<Image> m_DurationBlock /* None */,
    PPtr<TextMeshProUGUI> m_DurationTitle /* None */,
    PPtr<TextMeshProUGUI> m_DurationValue /* None */,
    PPtr<Image> m_CooldownBlock /* None */,
    PPtr<TextMeshProUGUI> m_CooldownTitle /* None */,
    PPtr<TextMeshProUGUI> m_CooldownValue /* None */,
    PPtr<GameObject> m_PenaltyBlock /* None */,
    PPtr<TextMeshProUGUI> m_PenaltyText /* None */,
    PPtr<GameObject> m_LockedBlock /* None */,
    PPtr<TextMeshProUGUI> m_LockedText /* None */,
    PPtr<GameObject> m_AttuneBlock /* None */,
    PPtr<GameObject> m_AttuneActionBlock /* None */,
    PPtr<OwlcatMultiSelectable> m_ScrapPrerequisiteSelectable /* None */,
    PPtr<TextMeshProUGUI> m_ScrapPrerequisiteText /* None */,
    PPtr<OwlcatMultiSelectable> m_UsingPrerequisiteSelectable /* None */,
    PPtr<TextMeshProUGUI> m_UsingPrerequisiteText /* None */,
    PPtr<OwlcatMultiSelectable> m_ShipFullHPSelectable /* None */,
    PPtr<TextMeshProUGUI> m_ShipFullHPText /* None */,
    PPtr<GameObject> m_AttuneAbilityBlock /* None */,
    PPtr<GameObject> m_ArrowsAttuneAbilityBlock /* None */,
    PPtr<Image> m_AttuneAbilityIcon /* None */,
    PPtr<TextMeshProUGUI> m_AttuneName /* None */,
    PPtr<TextMeshProUGUI> m_AttuneRequirement /* None */,
    PPtr<OwlcatButton> m_AttuneButton /* None */,
    PPtr<TextMeshProUGUI> m_AttuneButtonText /* None */)
{
    public static PostAbilityDetailedPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Icon */
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<Image> _m_IconGrayScale = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AbilityName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_Selectable = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<GameObject> _m_AttunedStateBlock = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AttunedStateText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_DurationBlock = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DurationTitle = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DurationValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_CooldownBlock = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CooldownTitle = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CooldownValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_PenaltyBlock = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PenaltyText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_LockedBlock = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_LockedText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_AttuneBlock = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_AttuneActionBlock = PPtr<GameObject>.Read(reader);
        PPtr<OwlcatMultiSelectable> _m_ScrapPrerequisiteSelectable = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ScrapPrerequisiteText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiSelectable> _m_UsingPrerequisiteSelectable = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<TextMeshProUGUI> _m_UsingPrerequisiteText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiSelectable> _m_ShipFullHPSelectable = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ShipFullHPText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_AttuneAbilityBlock = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_ArrowsAttuneAbilityBlock = PPtr<GameObject>.Read(reader);
        PPtr<Image> _m_AttuneAbilityIcon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AttuneName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AttuneRequirement = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_AttuneButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AttuneButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Icon,
            _m_IconGrayScale,
            _m_AbilityName,
            _m_Selectable,
            _m_AttunedStateBlock,
            _m_AttunedStateText,
            _m_DurationBlock,
            _m_DurationTitle,
            _m_DurationValue,
            _m_CooldownBlock,
            _m_CooldownTitle,
            _m_CooldownValue,
            _m_PenaltyBlock,
            _m_PenaltyText,
            _m_LockedBlock,
            _m_LockedText,
            _m_AttuneBlock,
            _m_AttuneActionBlock,
            _m_ScrapPrerequisiteSelectable,
            _m_ScrapPrerequisiteText,
            _m_UsingPrerequisiteSelectable,
            _m_UsingPrerequisiteText,
            _m_ShipFullHPSelectable,
            _m_ShipFullHPText,
            _m_AttuneAbilityBlock,
            _m_ArrowsAttuneAbilityBlock,
            _m_AttuneAbilityIcon,
            _m_AttuneName,
            _m_AttuneRequirement,
            _m_AttuneButton,
            _m_AttuneButtonText);
    }
}

