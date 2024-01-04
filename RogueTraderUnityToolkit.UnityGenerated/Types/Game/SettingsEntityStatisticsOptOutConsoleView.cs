namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SettingsEntityStatisticsOptOutConsoleView (14 fields) 402F4D3CEC16DDB3A074534212165C72/52FD7A2BE8118E2A3577056EC1F14E77 */
public record class SettingsEntityStatisticsOptOutConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> m_SetConnector /* NeedsAlign */,
    PPtr<GameObject> m_SetConnectorIAmSet /* None */,
    PPtr<TextMeshProUGUI> m_Title /* None */,
    PPtr<OwlcatMultiButton> m_GoToStatisticsButton /* None */,
    PPtr<TextMeshProUGUI> m_GoToStatisticsButtonLabel /* None */,
    PPtr<ConsoleHint> m_GoToStatisticsHint /* None */,
    PPtr<OwlcatMultiButton> m_DeleteStatisticsDataButton /* None */,
    PPtr<TextMeshProUGUI> m_DeleteDataButtonLabel /* None */,
    PPtr<ConsoleHint> m_DeleteDataHint /* None */,
    PPtr<OwlcatMultiButton> m_SelectableMultiButton /* None */)
{
    public static SettingsEntityStatisticsOptOutConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SetConnector */
        PPtr<GameObject> _m_SetConnector = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_SetConnectorIAmSet = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_GoToStatisticsButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_GoToStatisticsButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<ConsoleHint> _m_GoToStatisticsHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<OwlcatMultiButton> _m_DeleteStatisticsDataButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DeleteDataButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<ConsoleHint> _m_DeleteDataHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<OwlcatMultiButton> _m_SelectableMultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SetConnector,
            _m_SetConnectorIAmSet,
            _m_Title,
            _m_GoToStatisticsButton,
            _m_GoToStatisticsButtonLabel,
            _m_GoToStatisticsHint,
            _m_DeleteStatisticsDataButton,
            _m_DeleteDataButtonLabel,
            _m_DeleteDataHint,
            _m_SelectableMultiButton);
    }
}

