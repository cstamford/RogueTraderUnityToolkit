namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $InventoryDollPCView (32 fields) 178704C47D53C014528B23B639979CBA/07505BFC307B5D4E560E0526A0A00BB9 */
public record class InventoryDollPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Label /* None */,
    PPtr<DollRoomTargetController> m_CharacterController /* None */,
    PPtr<GameObject> m_LeftSlots /* None */,
    PPtr<GameObject> m_RightSlots /* None */,
    PPtr<InventoryEquipSlotPCView> m_BodyArmor /* None */,
    PPtr<InventoryEquipSlotPCView> m_HeadArmor /* None */,
    PPtr<InventoryEquipSlotPCView> m_Gloves /* None */,
    PPtr<InventoryEquipSlotPCView> m_Boots /* None */,
    PPtr<InventoryEquipSlotPCView> m_Back /* None */,
    PPtr<InventoryEquipSlotPCView> m_Neck /* None */,
    PPtr<InventoryEquipSlotPCView> m_Ring1 /* None */,
    PPtr<InventoryEquipSlotPCView> m_Ring2 /* None */,
    PPtr<GameObject> m_SkinImplant /* None */,
    PPtr<GameObject> m_HeadImplant /* None */,
    PPtr<GameObject> m_LimbImplant1 /* None */,
    PPtr<GameObject> m_LimbImplant2 /* None */,
    PPtr<GameObject> m_LimbImplant3 /* None */,
    PPtr<GameObject> m_LimbImplant4 /* None */,
    PPtr<GameObject> m_SensesImplant /* None */,
    PPtr<GameObject> m_InternalImplant1 /* None */,
    PPtr<GameObject> m_InternalImplant2 /* None */,
    PPtr<GameObject> m_InternalImplant3 /* None */,
    PPtr<InventoryEquipSlotPCView>[] m_QuickSlots /* None */,
    PPtr<WeaponSetSelectorPCView> m_WeaponSetSelector /* None */,
    PPtr<CharInfoEncumbranceView> m_EncumbranceView /* None */,
    PPtr<OwlcatButton> m_VisualSettingsViewButton /* None */,
    PPtr<CharacterVisualSettingsPCView> m_VisualSettingsPCView /* None */)
{
    public static InventoryDollPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<DollRoomTargetController> _m_CharacterController = PPtr<DollRoomTargetController>.Read(reader);
        PPtr<GameObject> _m_LeftSlots = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_RightSlots = PPtr<GameObject>.Read(reader);
        PPtr<InventoryEquipSlotPCView> _m_BodyArmor = PPtr<InventoryEquipSlotPCView>.Read(reader);
        PPtr<InventoryEquipSlotPCView> _m_HeadArmor = PPtr<InventoryEquipSlotPCView>.Read(reader);
        PPtr<InventoryEquipSlotPCView> _m_Gloves = PPtr<InventoryEquipSlotPCView>.Read(reader);
        PPtr<InventoryEquipSlotPCView> _m_Boots = PPtr<InventoryEquipSlotPCView>.Read(reader);
        PPtr<InventoryEquipSlotPCView> _m_Back = PPtr<InventoryEquipSlotPCView>.Read(reader);
        PPtr<InventoryEquipSlotPCView> _m_Neck = PPtr<InventoryEquipSlotPCView>.Read(reader);
        PPtr<InventoryEquipSlotPCView> _m_Ring1 = PPtr<InventoryEquipSlotPCView>.Read(reader);
        PPtr<InventoryEquipSlotPCView> _m_Ring2 = PPtr<InventoryEquipSlotPCView>.Read(reader);
        PPtr<GameObject> _m_SkinImplant = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_HeadImplant = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_LimbImplant1 = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_LimbImplant2 = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_LimbImplant3 = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_LimbImplant4 = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_SensesImplant = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_InternalImplant1 = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_InternalImplant2 = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_InternalImplant3 = PPtr<GameObject>.Read(reader);
        PPtr<InventoryEquipSlotPCView>[] _m_QuickSlots = BuiltInArray<PPtr<InventoryEquipSlotPCView>>.Read(reader);
        PPtr<WeaponSetSelectorPCView> _m_WeaponSetSelector = PPtr<WeaponSetSelectorPCView>.Read(reader);
        PPtr<CharInfoEncumbranceView> _m_EncumbranceView = PPtr<CharInfoEncumbranceView>.Read(reader);
        PPtr<OwlcatButton> _m_VisualSettingsViewButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<CharacterVisualSettingsPCView> _m_VisualSettingsPCView = PPtr<CharacterVisualSettingsPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_Label,
            _m_CharacterController,
            _m_LeftSlots,
            _m_RightSlots,
            _m_BodyArmor,
            _m_HeadArmor,
            _m_Gloves,
            _m_Boots,
            _m_Back,
            _m_Neck,
            _m_Ring1,
            _m_Ring2,
            _m_SkinImplant,
            _m_HeadImplant,
            _m_LimbImplant1,
            _m_LimbImplant2,
            _m_LimbImplant3,
            _m_LimbImplant4,
            _m_SensesImplant,
            _m_InternalImplant1,
            _m_InternalImplant2,
            _m_InternalImplant3,
            _m_QuickSlots,
            _m_WeaponSetSelector,
            _m_EncumbranceView,
            _m_VisualSettingsViewButton,
            _m_VisualSettingsPCView);
    }
}

