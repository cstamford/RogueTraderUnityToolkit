namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipCustomizationPCView (19 fields) 130CBD342AFC0EAD35A6B3D0BD4265FA/B4BE42C560912DAB38D460EF943CCE89 */
public record class ShipCustomizationPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<ShipTabsNavigationPCView> m_ShipTabsNavigationPCView /* None */,
    PPtr<GameObject> m_HasShipLevel /* None */,
    PPtr<GameObject> m_ShipInfo /* None */,
    PPtr<ShipPCView> m_SpaceShipPCView /* None */,
    PPtr<ShipStatsPCView> m_ShipStatsPCView /* None */,
    PPtr<ShipHealthAndRepairPCView> m_ShipHealthAndRepairView /* None */,
    PPtr<FlexibleLensSelectorView> m_SelectorView /* None */,
    PPtr<ShipUpgradePCView> m_ShipUpgradePCView /* None */,
    PPtr<FadeAnimator> m_SkillsAndPostsFadeAnimator /* None */,
    PPtr<ShipSkillsPCView> m_ShipSkillsPCView /* None */,
    PPtr<PostsBaseView> m_ShipPostsView /* None */,
    PPtr<GameObject> LockState /* None */,
    PPtr<TextMeshProUGUI> LockStateText /* None */,
    PPtr<OwlcatMultiButton> m_CloseButton /* None */)
{
    public static ShipCustomizationPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<ShipTabsNavigationPCView> _m_ShipTabsNavigationPCView = PPtr<ShipTabsNavigationPCView>.Read(reader);
        PPtr<GameObject> _m_HasShipLevel = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_ShipInfo = PPtr<GameObject>.Read(reader);
        PPtr<ShipPCView> _m_SpaceShipPCView = PPtr<ShipPCView>.Read(reader);
        PPtr<ShipStatsPCView> _m_ShipStatsPCView = PPtr<ShipStatsPCView>.Read(reader);
        PPtr<ShipHealthAndRepairPCView> _m_ShipHealthAndRepairView = PPtr<ShipHealthAndRepairPCView>.Read(reader);
        PPtr<FlexibleLensSelectorView> _m_SelectorView = PPtr<FlexibleLensSelectorView>.Read(reader);
        PPtr<ShipUpgradePCView> _m_ShipUpgradePCView = PPtr<ShipUpgradePCView>.Read(reader);
        PPtr<FadeAnimator> _m_SkillsAndPostsFadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<ShipSkillsPCView> _m_ShipSkillsPCView = PPtr<ShipSkillsPCView>.Read(reader);
        PPtr<PostsBaseView> _m_ShipPostsView = PPtr<PostsBaseView>.Read(reader);
        PPtr<GameObject> _LockState = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _LockStateText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_CloseButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_ShipTabsNavigationPCView,
            _m_HasShipLevel,
            _m_ShipInfo,
            _m_SpaceShipPCView,
            _m_ShipStatsPCView,
            _m_ShipHealthAndRepairView,
            _m_SelectorView,
            _m_ShipUpgradePCView,
            _m_SkillsAndPostsFadeAnimator,
            _m_ShipSkillsPCView,
            _m_ShipPostsView,
            _LockState,
            _LockStateText,
            _m_CloseButton);
    }
}

