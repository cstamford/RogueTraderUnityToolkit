namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ExplorationScanHintWrapperConsoleView (6 fields) 03681423DF758A9034E54CAED0D5442A/58BCB8F9DDE5EA4066C4086F64FF57D5 */
public record class ExplorationScanHintWrapperConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasGroup> m_CanvasGroup /* NeedsAlign */,
    PPtr<ConsoleHint> m_ScanHint /* None */)
{
    public static ExplorationScanHintWrapperConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CanvasGroup */
        PPtr<CanvasGroup> _m_CanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<ConsoleHint> _m_ScanHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CanvasGroup,
            _m_ScanHint);
    }
}

