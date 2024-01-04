namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipUpgradeConsoleView (23 fields) 2BE733AD6A399F22947EC8D206F632AA/65AF57BAE47D4C70C6DF075E394A0055 */
public record class ShipUpgradeConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ShipInventoryStashConsoleView> m_InventoryStashView /* NeedsAlign */,
    PPtr<DollRoomTargetController> m_CharacterController /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* None */,
    PPtr<ShipSelectorWindowConsoleView> m_SelectorWindowView /* None */,
    PPtr<ShipComponentSlotConsoleView> m_PlasmaDrives /* None */,
    PPtr<ShipComponentSlotConsoleView> m_VoidShieldGenerator /* None */,
    PPtr<ShipComponentSlotConsoleView> m_AugerArray /* None */,
    PPtr<ShipComponentSlotConsoleView> m_ArmorPlating /* None */,
    PPtr<ShipComponentSlotConsoleView>[] m_WeaponSlots /* None */,
    PPtr<ShipUpgradeStructureSlotConsoleView> m_UpgradeStructureSlot /* None */,
    PPtr<ShipUpgradeProwRamSlotConsoleView> m_UpgradeProwRamSlot /* None */,
    PPtr<Image> m_ExperiencePanel /* None */,
    PPtr<RectTransform> UpgradeSlotsBlock /* None */,
    PPtr<RectTransform> m_MiddlePosition /* None */,
    PPtr<RectTransform> m_TopPosition /* None */,
    NavigationParameters m_Parameters /* None */,
    PPtr<ConsoleHintsWidget> m_ConsoleHintsWidget /* NeedsAlign */,
    PPtr<OwlcatMultiButton> m_ExperienceButton /* None */,
    PPtr<Image> m_TooltipPlace /* None */)
{
    public static ShipUpgradeConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_InventoryStashView */
        PPtr<ShipInventoryStashConsoleView> _m_InventoryStashView = PPtr<ShipInventoryStashConsoleView>.Read(reader);
        PPtr<DollRoomTargetController> _m_CharacterController = PPtr<DollRoomTargetController>.Read(reader);
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<ShipSelectorWindowConsoleView> _m_SelectorWindowView = PPtr<ShipSelectorWindowConsoleView>.Read(reader);
        PPtr<ShipComponentSlotConsoleView> _m_PlasmaDrives = PPtr<ShipComponentSlotConsoleView>.Read(reader);
        PPtr<ShipComponentSlotConsoleView> _m_VoidShieldGenerator = PPtr<ShipComponentSlotConsoleView>.Read(reader);
        PPtr<ShipComponentSlotConsoleView> _m_AugerArray = PPtr<ShipComponentSlotConsoleView>.Read(reader);
        PPtr<ShipComponentSlotConsoleView> _m_ArmorPlating = PPtr<ShipComponentSlotConsoleView>.Read(reader);
        PPtr<ShipComponentSlotConsoleView>[] _m_WeaponSlots = BuiltInArray<PPtr<ShipComponentSlotConsoleView>>.Read(reader);
        PPtr<ShipUpgradeStructureSlotConsoleView> _m_UpgradeStructureSlot = PPtr<ShipUpgradeStructureSlotConsoleView>.Read(reader);
        PPtr<ShipUpgradeProwRamSlotConsoleView> _m_UpgradeProwRamSlot = PPtr<ShipUpgradeProwRamSlotConsoleView>.Read(reader);
        PPtr<Image> _m_ExperiencePanel = PPtr<Image>.Read(reader);
        PPtr<RectTransform> _UpgradeSlotsBlock = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_MiddlePosition = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_TopPosition = PPtr<RectTransform>.Read(reader);
        NavigationParameters _m_Parameters = NavigationParameters.Read(reader);
        reader.AlignTo(4); /* m_ConsoleHintsWidget */
        PPtr<ConsoleHintsWidget> _m_ConsoleHintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ExperienceButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<Image> _m_TooltipPlace = PPtr<Image>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_InventoryStashView,
            _m_CharacterController,
            _m_FadeAnimator,
            _m_SelectorWindowView,
            _m_PlasmaDrives,
            _m_VoidShieldGenerator,
            _m_AugerArray,
            _m_ArmorPlating,
            _m_WeaponSlots,
            _m_UpgradeStructureSlot,
            _m_UpgradeProwRamSlot,
            _m_ExperiencePanel,
            _UpgradeSlotsBlock,
            _m_MiddlePosition,
            _m_TopPosition,
            _m_Parameters,
            _m_ConsoleHintsWidget,
            _m_ExperienceButton,
            _m_TooltipPlace);
    }
}

