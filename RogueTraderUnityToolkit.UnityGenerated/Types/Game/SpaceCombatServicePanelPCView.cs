namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpaceCombatServicePanelPCView (15 fields) 3CA2F85E1EEF1013A5A2F931C571244F/811F1109BE3FDA62AA3EAA7D8B04AF96 */
public record class SpaceCombatServicePanelPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<DelayedSlider> m_HPSlider /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_ShipHealth /* None */,
    PPtr<OwlcatMultiButton> m_EndTurnButton /* None */,
    PPtr<MoveAnimator> m_EndTurnButtonAnimator /* None */,
    PPtr<TextMeshProUGUI> m_EndTurnBindText /* None */,
    PPtr<OwlcatMultiSelectable> m_TurnCounter /* None */,
    PPtr<TextMeshProUGUI> m_RoundsLeft /* None */,
    PPtr<InitiativeTrackerView> m_InitiativeTrackerView /* None */,
    PPtr<SpaceCombatTorpedoPanelPCView> m_SpaceCombatTorpedoPanelPCView /* None */,
    PPtr<MoveAnimator> m_ControlPanelAnimator /* None */,
    PPtr<MoveAnimator> m_TorpedoesPanelAnimator /* None */)
{
    public static SpaceCombatServicePanelPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HPSlider */
        PPtr<DelayedSlider> _m_HPSlider = PPtr<DelayedSlider>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ShipHealth = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_EndTurnButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<MoveAnimator> _m_EndTurnButtonAnimator = PPtr<MoveAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_EndTurnBindText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiSelectable> _m_TurnCounter = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RoundsLeft = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<InitiativeTrackerView> _m_InitiativeTrackerView = PPtr<InitiativeTrackerView>.Read(reader);
        PPtr<SpaceCombatTorpedoPanelPCView> _m_SpaceCombatTorpedoPanelPCView = PPtr<SpaceCombatTorpedoPanelPCView>.Read(reader);
        PPtr<MoveAnimator> _m_ControlPanelAnimator = PPtr<MoveAnimator>.Read(reader);
        PPtr<MoveAnimator> _m_TorpedoesPanelAnimator = PPtr<MoveAnimator>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HPSlider,
            _m_ShipHealth,
            _m_EndTurnButton,
            _m_EndTurnButtonAnimator,
            _m_EndTurnBindText,
            _m_TurnCounter,
            _m_RoundsLeft,
            _m_InitiativeTrackerView,
            _m_SpaceCombatTorpedoPanelPCView,
            _m_ControlPanelAnimator,
            _m_TorpedoesPanelAnimator);
    }
}

