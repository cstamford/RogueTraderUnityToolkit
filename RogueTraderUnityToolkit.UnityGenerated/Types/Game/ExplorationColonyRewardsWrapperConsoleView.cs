namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ExplorationColonyRewardsWrapperConsoleView (6 fields) 783A57982ECAED45C023479E8BC894F8/DF36BCACB3E581516EF0932AEDD02F79 */
public record class ExplorationColonyRewardsWrapperConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasGroup> m_CanvasGroup /* NeedsAlign */,
    PPtr<ColonyRewardsConsoleView> m_ColonyRewardsView /* None */)
{
    public static ExplorationColonyRewardsWrapperConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CanvasGroup */
        PPtr<CanvasGroup> _m_CanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<ColonyRewardsConsoleView> _m_ColonyRewardsView = PPtr<ColonyRewardsConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CanvasGroup,
            _m_ColonyRewardsView);
    }
}

