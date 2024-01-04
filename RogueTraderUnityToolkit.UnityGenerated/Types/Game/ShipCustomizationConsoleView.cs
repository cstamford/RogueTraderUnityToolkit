namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipCustomizationConsoleView (21 fields) 43898EFF0AF9F2158F8E7B54791CE4B1/3BFAA1AA1D3FF74980FCA4B2C769B79F */
public record class ShipCustomizationConsoleView(
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
    PPtr<ShipHealthAndRepairConsoleView> m_ShipHealthAndRepairView /* None */,
    PPtr<FlexibleLensSelectorView> m_SelectorView /* None */,
    PPtr<ShipUpgradeConsoleView> m_ShipUpgradePCView /* None */,
    PPtr<FadeAnimator> m_SkillsAndPostsFadeAnimator /* None */,
    PPtr<ShipSkillsConsoleView> m_ShipSkillsPCView /* None */,
    PPtr<PostsBaseView> m_ShipPostsView /* None */,
    PPtr<GameObject> LockState /* None */,
    PPtr<TextMeshProUGUI> LockStateText /* None */,
    PPtr<ConsoleHintsWidget> m_HintsWidget /* None */,
    PPtr<ConsoleHint> m_NextConsoleHint /* None */,
    PPtr<ConsoleHint> m_PrevConsoleHint /* None */)
{
    public static ShipCustomizationConsoleView Read(EndianBinaryReader reader)
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
        PPtr<ShipHealthAndRepairConsoleView> _m_ShipHealthAndRepairView = PPtr<ShipHealthAndRepairConsoleView>.Read(reader);
        PPtr<FlexibleLensSelectorView> _m_SelectorView = PPtr<FlexibleLensSelectorView>.Read(reader);
        PPtr<ShipUpgradeConsoleView> _m_ShipUpgradePCView = PPtr<ShipUpgradeConsoleView>.Read(reader);
        PPtr<FadeAnimator> _m_SkillsAndPostsFadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<ShipSkillsConsoleView> _m_ShipSkillsPCView = PPtr<ShipSkillsConsoleView>.Read(reader);
        PPtr<PostsBaseView> _m_ShipPostsView = PPtr<PostsBaseView>.Read(reader);
        PPtr<GameObject> _LockState = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _LockStateText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_HintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        PPtr<ConsoleHint> _m_NextConsoleHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_PrevConsoleHint = PPtr<ConsoleHint>.Read(reader);
        
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
            _m_HintsWidget,
            _m_NextConsoleHint,
            _m_PrevConsoleHint);
    }
}

