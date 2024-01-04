namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $InventoryDollConsoleView (36 fields) EB1242523E52FDAE19E9780AA46A4BF7/C438DAE0F97EE63F0693C2CED5BB7D66 */
public record class InventoryDollConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Label /* None */,
    PPtr<DollRoomTargetController> m_CharacterController /* None */,
    PPtr<GameObject> m_LeftSlots /* None */,
    PPtr<GameObject> m_RightSlots /* None */,
    PPtr<InventoryEquipSlotConsoleView> m_BodyArmor /* None */,
    PPtr<InventoryEquipSlotConsoleView> m_HeadArmor /* None */,
    PPtr<InventoryEquipSlotConsoleView> m_Gloves /* None */,
    PPtr<InventoryEquipSlotConsoleView> m_Boots /* None */,
    PPtr<InventoryEquipSlotConsoleView> m_Back /* None */,
    PPtr<InventoryEquipSlotConsoleView> m_Neck /* None */,
    PPtr<InventoryEquipSlotConsoleView> m_Ring1 /* None */,
    PPtr<InventoryEquipSlotConsoleView> m_Ring2 /* None */,
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
    PPtr<InventoryEquipSlotConsoleView>[] m_QuickSlots /* None */,
    PPtr<WeaponSetSelectorPCView> m_WeaponSetSelector /* None */,
    PPtr<CharInfoEncumbranceView> m_EncumbranceView /* None */,
    float m_RotateFactor /* None */,
    float m_ZoomFactor /* None */,
    float m_ZoomThresholdValue /* None */,
    PPtr<InventorySelectorWindowConsoleView> m_SelectorWindowView /* None */,
    PPtr<CharacterVisualSettingsConsoleView> m_VisualSettingsConsoleView /* None */,
    PPtr<ConsoleHintsWidget> m_ConsoleHintsWidget /* None */)
{
    public static InventoryDollConsoleView Read(EndianBinaryReader reader)
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
        PPtr<InventoryEquipSlotConsoleView> _m_BodyArmor = PPtr<InventoryEquipSlotConsoleView>.Read(reader);
        PPtr<InventoryEquipSlotConsoleView> _m_HeadArmor = PPtr<InventoryEquipSlotConsoleView>.Read(reader);
        PPtr<InventoryEquipSlotConsoleView> _m_Gloves = PPtr<InventoryEquipSlotConsoleView>.Read(reader);
        PPtr<InventoryEquipSlotConsoleView> _m_Boots = PPtr<InventoryEquipSlotConsoleView>.Read(reader);
        PPtr<InventoryEquipSlotConsoleView> _m_Back = PPtr<InventoryEquipSlotConsoleView>.Read(reader);
        PPtr<InventoryEquipSlotConsoleView> _m_Neck = PPtr<InventoryEquipSlotConsoleView>.Read(reader);
        PPtr<InventoryEquipSlotConsoleView> _m_Ring1 = PPtr<InventoryEquipSlotConsoleView>.Read(reader);
        PPtr<InventoryEquipSlotConsoleView> _m_Ring2 = PPtr<InventoryEquipSlotConsoleView>.Read(reader);
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
        PPtr<InventoryEquipSlotConsoleView>[] _m_QuickSlots = BuiltInArray<PPtr<InventoryEquipSlotConsoleView>>.Read(reader);
        PPtr<WeaponSetSelectorPCView> _m_WeaponSetSelector = PPtr<WeaponSetSelectorPCView>.Read(reader);
        PPtr<CharInfoEncumbranceView> _m_EncumbranceView = PPtr<CharInfoEncumbranceView>.Read(reader);
        float _m_RotateFactor = reader.ReadF32();
        float _m_ZoomFactor = reader.ReadF32();
        float _m_ZoomThresholdValue = reader.ReadF32();
        PPtr<InventorySelectorWindowConsoleView> _m_SelectorWindowView = PPtr<InventorySelectorWindowConsoleView>.Read(reader);
        PPtr<CharacterVisualSettingsConsoleView> _m_VisualSettingsConsoleView = PPtr<CharacterVisualSettingsConsoleView>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_ConsoleHintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        
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
            _m_RotateFactor,
            _m_ZoomFactor,
            _m_ZoomThresholdValue,
            _m_SelectorWindowView,
            _m_VisualSettingsConsoleView,
            _m_ConsoleHintsWidget);
    }
}

