namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpaceCombatServicePanelConsoleView (13 fields) FC0FF8728168677DB7014119E1D97AB6/5BA2D9A7160B81D6D35E4A9DAA32235F */
public record class SpaceCombatServicePanelConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<DelayedSlider> m_HPSlider /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_ShipHealth /* None */,
    PPtr<GameObject> m_TurnCounter /* None */,
    PPtr<TextMeshProUGUI> m_RoundsLeft /* None */,
    PPtr<InitiativeTrackerVerticalConsoleView> m_InitiativeTrackerView /* None */,
    PPtr<SpaceCombatTorpedoPanelConsoleView> m_SpaceCombatTorpedoPanelConsoleView /* None */,
    PPtr<MoveAnimator> m_ControlPanelAnimator /* None */,
    PPtr<MoveAnimator> m_TorpedoesPanelAnimator /* None */,
    PPtr<ConsoleHintsWidget> m_ConsoleHintsWidget /* None */)
{
    public static SpaceCombatServicePanelConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HPSlider */
        PPtr<DelayedSlider> _m_HPSlider = PPtr<DelayedSlider>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ShipHealth = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_TurnCounter = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RoundsLeft = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<InitiativeTrackerVerticalConsoleView> _m_InitiativeTrackerView = PPtr<InitiativeTrackerVerticalConsoleView>.Read(reader);
        PPtr<SpaceCombatTorpedoPanelConsoleView> _m_SpaceCombatTorpedoPanelConsoleView = PPtr<SpaceCombatTorpedoPanelConsoleView>.Read(reader);
        PPtr<MoveAnimator> _m_ControlPanelAnimator = PPtr<MoveAnimator>.Read(reader);
        PPtr<MoveAnimator> _m_TorpedoesPanelAnimator = PPtr<MoveAnimator>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_ConsoleHintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HPSlider,
            _m_ShipHealth,
            _m_TurnCounter,
            _m_RoundsLeft,
            _m_InitiativeTrackerView,
            _m_SpaceCombatTorpedoPanelConsoleView,
            _m_ControlPanelAnimator,
            _m_TorpedoesPanelAnimator,
            _m_ConsoleHintsWidget);
    }
}

