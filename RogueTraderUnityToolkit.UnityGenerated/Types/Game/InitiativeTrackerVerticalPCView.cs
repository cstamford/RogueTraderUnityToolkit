namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $InitiativeTrackerVerticalPCView (12 fields) DED75AB9E26E03283BD42EE2948BB4EA/FE0054BE42ECF8E71DFC187B1C822BF8 */
public record class InitiativeTrackerVerticalPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> TrackerContainer /* NeedsAlign */,
    PPtr<RectTransform> OrderContainer /* None */,
    PPtr<TurnVirtualListController> VirtualList /* None */,
    PPtr<SurfaceCombatUnitOrderView> CombatUnitPrefab /* None */,
    PPtr<FadeAnimator> m_OwnAnimation /* None */,
    PPtr<RectTransform> m_VirtualListViewport /* None */,
    PPtr<TextMeshProUGUI> m_StateValue /* None */,
    PPtr<SurfaceCombatUnitOrderVerticalView> m_CurrentUnit /* None */)
{
    public static InitiativeTrackerVerticalPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* TrackerContainer */
        PPtr<RectTransform> _TrackerContainer = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _OrderContainer = PPtr<RectTransform>.Read(reader);
        PPtr<TurnVirtualListController> _VirtualList = PPtr<TurnVirtualListController>.Read(reader);
        PPtr<SurfaceCombatUnitOrderView> _CombatUnitPrefab = PPtr<SurfaceCombatUnitOrderView>.Read(reader);
        PPtr<FadeAnimator> _m_OwnAnimation = PPtr<FadeAnimator>.Read(reader);
        PPtr<RectTransform> _m_VirtualListViewport = PPtr<RectTransform>.Read(reader);
        PPtr<TextMeshProUGUI> _m_StateValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<SurfaceCombatUnitOrderVerticalView> _m_CurrentUnit = PPtr<SurfaceCombatUnitOrderVerticalView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _TrackerContainer,
            _OrderContainer,
            _VirtualList,
            _CombatUnitPrefab,
            _m_OwnAnimation,
            _m_VirtualListViewport,
            _m_StateValue,
            _m_CurrentUnit);
    }
}

