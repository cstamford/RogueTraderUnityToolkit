namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipSelectorWindowConsoleView (11 fields) 1A2AC5DA0E4B360E53494CC363A91805/3CFA1D715419FC622790B8CDD25DBFDE */
public record class ShipSelectorWindowConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Header /* None */,
    PPtr<VirtualListComponent> m_VirtualList /* None */,
    PPtr<ShipComponentItemSlotConsoleView> m_SlotPrefab /* None */,
    PPtr<InfoSectionView> m_InfoSectionView /* None */,
    PPtr<CanvasSortingComponent> m_SortingComponent /* None */,
    PPtr<ConsoleHintsWidget> m_ConsoleHintsWidget /* None */)
{
    public static ShipSelectorWindowConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Header = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<VirtualListComponent> _m_VirtualList = PPtr<VirtualListComponent>.Read(reader);
        PPtr<ShipComponentItemSlotConsoleView> _m_SlotPrefab = PPtr<ShipComponentItemSlotConsoleView>.Read(reader);
        PPtr<InfoSectionView> _m_InfoSectionView = PPtr<InfoSectionView>.Read(reader);
        PPtr<CanvasSortingComponent> _m_SortingComponent = PPtr<CanvasSortingComponent>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_ConsoleHintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_Header,
            _m_VirtualList,
            _m_SlotPrefab,
            _m_InfoSectionView,
            _m_SortingComponent,
            _m_ConsoleHintsWidget);
    }
}

