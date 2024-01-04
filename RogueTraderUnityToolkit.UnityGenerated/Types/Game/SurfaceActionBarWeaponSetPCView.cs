namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceActionBarWeaponSetPCView (13 fields) 08329DDF2FD51B0EDF8BC980DB6C651E/C6B0BDF1B26DD27C30AE42B1240C652E */
public record class SurfaceActionBarWeaponSetPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatButton> m_SwitchWeaponButton /* NeedsAlign */,
    PPtr<SurfaceActionBarSlotWeaponPCView> m_MainHandWeapon /* None */,
    PPtr<SurfaceActionBarSlotWeaponPCView> m_OffHandWeapon /* None */,
    PPtr<SurfaceActionBarSlotWeaponAbilityPCView> m_SlotPCView /* None */,
    PPtr<GreedyWidgetList> m_MainHandWidgetList /* None */,
    PPtr<GreedyWidgetList> m_OffHandWidgetList /* None */,
    PPtr<GreedyWidgetList> m_ComboHandWidgetList /* None */,
    PPtr<Image> m_CurrentSetImage /* None */,
    PPtr<RectTransform> m_LeftSideTooltipPlace /* None */)
{
    public static SurfaceActionBarWeaponSetPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SwitchWeaponButton */
        PPtr<OwlcatButton> _m_SwitchWeaponButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<SurfaceActionBarSlotWeaponPCView> _m_MainHandWeapon = PPtr<SurfaceActionBarSlotWeaponPCView>.Read(reader);
        PPtr<SurfaceActionBarSlotWeaponPCView> _m_OffHandWeapon = PPtr<SurfaceActionBarSlotWeaponPCView>.Read(reader);
        PPtr<SurfaceActionBarSlotWeaponAbilityPCView> _m_SlotPCView = PPtr<SurfaceActionBarSlotWeaponAbilityPCView>.Read(reader);
        PPtr<GreedyWidgetList> _m_MainHandWidgetList = PPtr<GreedyWidgetList>.Read(reader);
        PPtr<GreedyWidgetList> _m_OffHandWidgetList = PPtr<GreedyWidgetList>.Read(reader);
        PPtr<GreedyWidgetList> _m_ComboHandWidgetList = PPtr<GreedyWidgetList>.Read(reader);
        PPtr<Image> _m_CurrentSetImage = PPtr<Image>.Read(reader);
        PPtr<RectTransform> _m_LeftSideTooltipPlace = PPtr<RectTransform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SwitchWeaponButton,
            _m_MainHandWeapon,
            _m_OffHandWeapon,
            _m_SlotPCView,
            _m_MainHandWidgetList,
            _m_OffHandWidgetList,
            _m_ComboHandWidgetList,
            _m_CurrentSetImage,
            _m_LeftSideTooltipPlace);
    }
}

