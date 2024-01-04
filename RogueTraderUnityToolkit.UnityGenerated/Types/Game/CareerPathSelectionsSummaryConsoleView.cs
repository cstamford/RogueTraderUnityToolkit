namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CareerPathSelectionsSummaryConsoleView (7 fields) 89400F23BD1A137BC03A8B2DE714A87A/E5AC4A8D6C017AAA3F2DC859F5FBF1D5 */
public record class CareerPathSelectionsSummaryConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> m_HeaderBlock /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_HeaderLabel /* None */,
    PPtr<InfoSectionView> m_InfoView /* None */)
{
    public static CareerPathSelectionsSummaryConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HeaderBlock */
        PPtr<GameObject> _m_HeaderBlock = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_HeaderLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<InfoSectionView> _m_InfoView = PPtr<InfoSectionView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HeaderBlock,
            _m_HeaderLabel,
            _m_InfoView);
    }
}

