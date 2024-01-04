namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $InventoryCargoConsoleView (20 fields) C4C98E3D4D2C5CD7B0AE2B270D17A66C/FE117D4A48A76C6743B05466881E889D */
public record class InventoryCargoConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<VirtualListGridVertical> m_VirtualList /* NeedsAlign */,
    PPtr<VirtualListElementViewBase_1> m_SlotPrefab /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* None */,
    PPtr<CargoDropZonePCView> m_DropZonePCView /* None */,
    PPtr<CargoDetailedZoneBaseView> m_CargoZoneView /* None */,
    PPtr<FadeAnimator> m_ListContentFadeAnimator /* None */,
    PPtr<GameObject> m_EmptyCargo /* None */,
    PPtr<TextMeshProUGUI> m_EmptyCargoText /* None */,
    PPtr<TextMeshProUGUI> m_CargoButtonText /* None */,
    PPtr<TextMeshProUGUI> m_ListButtonText /* None */,
    float m_ScrollToCargoDelay /* None */,
    PPtr<ConsoleHint> m_CargoHint /* None */,
    PPtr<ConsoleHint> m_CargoLeftHint /* None */,
    PPtr<ConsoleHint> m_CargoRightHint /* None */,
    PPtr<ConsoleHint> m_CloseHint /* None */,
    PPtr<TextMeshProUGUI> m_ChangeCargoViewText /* None */)
{
    public static InventoryCargoConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_VirtualList */
        PPtr<VirtualListGridVertical> _m_VirtualList = PPtr<VirtualListGridVertical>.Read(reader);
        PPtr<VirtualListElementViewBase_1> _m_SlotPrefab = PPtr<VirtualListElementViewBase_1>.Read(reader);
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<CargoDropZonePCView> _m_DropZonePCView = PPtr<CargoDropZonePCView>.Read(reader);
        PPtr<CargoDetailedZoneBaseView> _m_CargoZoneView = PPtr<CargoDetailedZoneBaseView>.Read(reader);
        PPtr<FadeAnimator> _m_ListContentFadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<GameObject> _m_EmptyCargo = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_EmptyCargoText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CargoButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ListButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        float _m_ScrollToCargoDelay = reader.ReadF32();
        PPtr<ConsoleHint> _m_CargoHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_CargoLeftHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_CargoRightHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_CloseHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ChangeCargoViewText = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_VirtualList,
            _m_SlotPrefab,
            _m_FadeAnimator,
            _m_DropZonePCView,
            _m_CargoZoneView,
            _m_ListContentFadeAnimator,
            _m_EmptyCargo,
            _m_EmptyCargoText,
            _m_CargoButtonText,
            _m_ListButtonText,
            _m_ScrollToCargoDelay,
            _m_CargoHint,
            _m_CargoLeftHint,
            _m_CargoRightHint,
            _m_CloseHint,
            _m_ChangeCargoViewText);
    }
}

