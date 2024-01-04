namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ExplorationSpaceResourcesWrapperConsoleView (6 fields) 8A36D8B9A3F1BB0AED269446DC68EBF4/3DE329B50F3ECB487B53A707C954CD3E */
public record class ExplorationSpaceResourcesWrapperConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasGroup> m_CanvasGroup /* NeedsAlign */,
    PPtr<ExplorationSpaceResourcesConsoleView> m_ExplorationSpaceResourcesPCView /* None */)
{
    public static ExplorationSpaceResourcesWrapperConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CanvasGroup */
        PPtr<CanvasGroup> _m_CanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<ExplorationSpaceResourcesConsoleView> _m_ExplorationSpaceResourcesPCView = PPtr<ExplorationSpaceResourcesConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CanvasGroup,
            _m_ExplorationSpaceResourcesPCView);
    }
}

