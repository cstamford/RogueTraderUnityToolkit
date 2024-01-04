namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipUpgradePCView (21 fields) 53833DB14371D3768DF860CCFCC92FF7/B4428D20A3586B8DC82B1ADD4895905D */
public record class ShipUpgradePCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ShipInventoryStashView> m_InventoryStashView /* NeedsAlign */,
    PPtr<DollRoomTargetController> m_CharacterController /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* None */,
    PPtr<ShipSelectorWindowPCView> m_SelectorWindowView /* None */,
    PPtr<ShipComponentSlotPCView> m_PlasmaDrives /* None */,
    PPtr<ShipComponentSlotPCView> m_VoidShieldGenerator /* None */,
    PPtr<ShipComponentSlotPCView> m_AugerArray /* None */,
    PPtr<ShipComponentSlotPCView> m_ArmorPlating /* None */,
    PPtr<ShipComponentSlotPCView>[] m_WeaponSlots /* None */,
    PPtr<ShipUpgradeStructureSlotPCView> m_UpgradeStructureSlot /* None */,
    PPtr<ShipUpgradeProwRamSlotPCView> m_UpgradeProwRamSlot /* None */,
    PPtr<Image> m_ExperiencePanel /* None */,
    PPtr<RectTransform> UpgradeSlotsBlock /* None */,
    PPtr<RectTransform> m_MiddlePosition /* None */,
    PPtr<RectTransform> m_TopPosition /* None */,
    PPtr<OwlcatButton> ToDefaultPosition /* None */,
    PPtr<TextMeshProUGUI> ToDefaultPositionText /* None */)
{
    public static ShipUpgradePCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_InventoryStashView */
        PPtr<ShipInventoryStashView> _m_InventoryStashView = PPtr<ShipInventoryStashView>.Read(reader);
        PPtr<DollRoomTargetController> _m_CharacterController = PPtr<DollRoomTargetController>.Read(reader);
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<ShipSelectorWindowPCView> _m_SelectorWindowView = PPtr<ShipSelectorWindowPCView>.Read(reader);
        PPtr<ShipComponentSlotPCView> _m_PlasmaDrives = PPtr<ShipComponentSlotPCView>.Read(reader);
        PPtr<ShipComponentSlotPCView> _m_VoidShieldGenerator = PPtr<ShipComponentSlotPCView>.Read(reader);
        PPtr<ShipComponentSlotPCView> _m_AugerArray = PPtr<ShipComponentSlotPCView>.Read(reader);
        PPtr<ShipComponentSlotPCView> _m_ArmorPlating = PPtr<ShipComponentSlotPCView>.Read(reader);
        PPtr<ShipComponentSlotPCView>[] _m_WeaponSlots = BuiltInArray<PPtr<ShipComponentSlotPCView>>.Read(reader);
        PPtr<ShipUpgradeStructureSlotPCView> _m_UpgradeStructureSlot = PPtr<ShipUpgradeStructureSlotPCView>.Read(reader);
        PPtr<ShipUpgradeProwRamSlotPCView> _m_UpgradeProwRamSlot = PPtr<ShipUpgradeProwRamSlotPCView>.Read(reader);
        PPtr<Image> _m_ExperiencePanel = PPtr<Image>.Read(reader);
        PPtr<RectTransform> _UpgradeSlotsBlock = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_MiddlePosition = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_TopPosition = PPtr<RectTransform>.Read(reader);
        PPtr<OwlcatButton> _ToDefaultPosition = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _ToDefaultPositionText = PPtr<TextMeshProUGUI>.Read(reader);
        
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
            _ToDefaultPosition,
            _ToDefaultPositionText);
    }
}

