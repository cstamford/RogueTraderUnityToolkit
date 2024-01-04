namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceActionBarPartQuickAccessConsoleView (16 fields) C4E0A4AD775F4436E913E20416A88A3A/657DE05414A32C50636D2CFD8E19548D */
public record class SurfaceActionBarPartQuickAccessConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<SurfaceActionBarQuickAccessCarouselView> m_HorizontalCarousel /* NeedsAlign */,
    PPtr<SurfaceActionBarQuickAccessCarouselView> m_VerticalCarousel /* None */,
    PPtr<MoveAnimator> m_MoveAnimator /* None */,
    PPtr<RectTransform> m_TooltipPlace /* None */,
    PPtr<SurfaceActionBarPartWeaponsConsoleView> m_WeaponsConsoleView /* None */,
    PPtr<SurfaceActionBarPartAbilitiesConsoleView> m_AbilitiesConsoleView /* None */,
    PPtr<ConsoleHint> m_DPadSurfaceHint /* None */,
    PPtr<ConsoleHint> m_DPadCombatHint /* None */,
    PPtr<ConsoleHint> m_DPadInternalHint /* None */,
    PPtr<ConsoleHint> m_ConfirmHint /* None */,
    PPtr<ConsoleHint> m_InfoHint /* None */,
    PPtr<ConsoleHint> m_AbilitiesHint /* None */)
{
    public static SurfaceActionBarPartQuickAccessConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HorizontalCarousel */
        PPtr<SurfaceActionBarQuickAccessCarouselView> _m_HorizontalCarousel = PPtr<SurfaceActionBarQuickAccessCarouselView>.Read(reader);
        PPtr<SurfaceActionBarQuickAccessCarouselView> _m_VerticalCarousel = PPtr<SurfaceActionBarQuickAccessCarouselView>.Read(reader);
        PPtr<MoveAnimator> _m_MoveAnimator = PPtr<MoveAnimator>.Read(reader);
        PPtr<RectTransform> _m_TooltipPlace = PPtr<RectTransform>.Read(reader);
        PPtr<SurfaceActionBarPartWeaponsConsoleView> _m_WeaponsConsoleView = PPtr<SurfaceActionBarPartWeaponsConsoleView>.Read(reader);
        PPtr<SurfaceActionBarPartAbilitiesConsoleView> _m_AbilitiesConsoleView = PPtr<SurfaceActionBarPartAbilitiesConsoleView>.Read(reader);
        PPtr<ConsoleHint> _m_DPadSurfaceHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_DPadCombatHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_DPadInternalHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_ConfirmHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_InfoHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_AbilitiesHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HorizontalCarousel,
            _m_VerticalCarousel,
            _m_MoveAnimator,
            _m_TooltipPlace,
            _m_WeaponsConsoleView,
            _m_AbilitiesConsoleView,
            _m_DPadSurfaceHint,
            _m_DPadCombatHint,
            _m_DPadInternalHint,
            _m_ConfirmHint,
            _m_InfoHint,
            _m_AbilitiesHint);
    }
}

