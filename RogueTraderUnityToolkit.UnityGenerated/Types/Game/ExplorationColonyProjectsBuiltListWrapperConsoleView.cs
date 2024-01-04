namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ExplorationColonyProjectsBuiltListWrapperConsoleView (6 fields) 42F5D030F4FA18ACEC7DA6342D8B4DDD/D17ED86C5C6B2A16F87477E1BFD804A1 */
public record class ExplorationColonyProjectsBuiltListWrapperConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasGroup> m_CanvasGroup /* NeedsAlign */,
    PPtr<ColonyProjectsBuiltListConsoleView> m_ColonyProjectsBuiltListView /* None */)
{
    public static ExplorationColonyProjectsBuiltListWrapperConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CanvasGroup */
        PPtr<CanvasGroup> _m_CanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<ColonyProjectsBuiltListConsoleView> _m_ColonyProjectsBuiltListView = PPtr<ColonyProjectsBuiltListConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CanvasGroup,
            _m_ColonyProjectsBuiltListView);
    }
}

