namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceActionBarPartConsumablesPCView (8 fields) 750D6700C3B97D35D3F4C2CD51707918/B21AE0B6E6688E271C98809A4AA3BC1F */
public record class SurfaceActionBarPartConsumablesPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatButton> m_InventoryButton /* NeedsAlign */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<SurfaceActionBarSlotConsumablePCView> m_SlotPCView /* None */,
    PPtr<RectTransform> m_LeftSideTooltipPlace /* None */)
{
    public static SurfaceActionBarPartConsumablesPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_InventoryButton */
        PPtr<OwlcatButton> _m_InventoryButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<SurfaceActionBarSlotConsumablePCView> _m_SlotPCView = PPtr<SurfaceActionBarSlotConsumablePCView>.Read(reader);
        PPtr<RectTransform> _m_LeftSideTooltipPlace = PPtr<RectTransform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_InventoryButton,
            _m_WidgetList,
            _m_SlotPCView,
            _m_LeftSideTooltipPlace);
    }
}

