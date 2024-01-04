namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ExplorationColonyProjectsWrapperConsoleView (6 fields) 78ACB1CA4936C453AD44C65C1EB96342/8D4B7F98B21E90749CCA65416BF86C9B */
public record class ExplorationColonyProjectsWrapperConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasGroup> m_CanvasGroup /* NeedsAlign */,
    PPtr<ColonyProjectsConsoleView> m_ColonyProjectsView /* None */)
{
    public static ExplorationColonyProjectsWrapperConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CanvasGroup */
        PPtr<CanvasGroup> _m_CanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<ColonyProjectsConsoleView> _m_ColonyProjectsView = PPtr<ColonyProjectsConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CanvasGroup,
            _m_ColonyProjectsView);
    }
}

