namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpaceCombatTorpedoPanelPCView (9 fields) 1896C01D6B8A73BCDB606F779B28CE7D/0A16CC1DEEE451EE34F577F7303ED26A */
public record class SpaceCombatTorpedoPanelPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<SpaceCombatHealthPartTextPCView> m_SpaceCombatHealthPartTextPCView /* NeedsAlign */,
    PPtr<SpaceCombatHealthPartProgressPCView> m_SpaceCombatHealthPartProgressPCView /* None */,
    PPtr<TextMeshProUGUI> m_TorpedoesCount /* None */,
    PPtr<TextMeshProUGUI> m_TorpedoSelfDestructTitle /* None */,
    PPtr<TextMeshProUGUI> m_TorpedoSelfDestructCounter /* None */)
{
    public static SpaceCombatTorpedoPanelPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SpaceCombatHealthPartTextPCView */
        PPtr<SpaceCombatHealthPartTextPCView> _m_SpaceCombatHealthPartTextPCView = PPtr<SpaceCombatHealthPartTextPCView>.Read(reader);
        PPtr<SpaceCombatHealthPartProgressPCView> _m_SpaceCombatHealthPartProgressPCView = PPtr<SpaceCombatHealthPartProgressPCView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TorpedoesCount = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TorpedoSelfDestructTitle = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TorpedoSelfDestructCounter = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SpaceCombatHealthPartTextPCView,
            _m_SpaceCombatHealthPartProgressPCView,
            _m_TorpedoesCount,
            _m_TorpedoSelfDestructTitle,
            _m_TorpedoSelfDestructCounter);
    }
}

