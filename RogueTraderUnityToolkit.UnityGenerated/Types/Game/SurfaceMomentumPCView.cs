namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceMomentumPCView (9 fields) 35DD17D71E7AC3A482273CB82865B2D9/E1884923CA9E703514937C20FA7CC2D5 */
public record class SurfaceMomentumPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<SurfaceMomentumEntityView> m_SurfaceMomentumEntityView /* NeedsAlign */,
    PPtr<WidgetListMVVM> m_HeroicActWidgetList /* None */,
    PPtr<WidgetListMVVM> m_DesperateMeasureWidgetList /* None */,
    PPtr<SurfaceActionBarSlotAbilityView> m_SlotView /* None */,
    PPtr<FadeAnimator> m_Animator /* None */)
{
    public static SurfaceMomentumPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SurfaceMomentumEntityView */
        PPtr<SurfaceMomentumEntityView> _m_SurfaceMomentumEntityView = PPtr<SurfaceMomentumEntityView>.Read(reader);
        PPtr<WidgetListMVVM> _m_HeroicActWidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<WidgetListMVVM> _m_DesperateMeasureWidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<SurfaceActionBarSlotAbilityView> _m_SlotView = PPtr<SurfaceActionBarSlotAbilityView>.Read(reader);
        PPtr<FadeAnimator> _m_Animator = PPtr<FadeAnimator>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SurfaceMomentumEntityView,
            _m_HeroicActWidgetList,
            _m_DesperateMeasureWidgetList,
            _m_SlotView,
            _m_Animator);
    }
}

