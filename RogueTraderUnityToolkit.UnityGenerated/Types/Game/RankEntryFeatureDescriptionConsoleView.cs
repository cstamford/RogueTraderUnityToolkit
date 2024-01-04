namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $RankEntryFeatureDescriptionConsoleView (9 fields) 617A956DA3BDA803A8AAACA09169C40C/C0228C025F2154554A9D27470DCE7195 */
public record class RankEntryFeatureDescriptionConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> m_HeaderBlock /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_HeaderLabel /* None */,
    PPtr<InfoSectionView> m_InfoView /* None */,
    PPtr<ConsoleHint> m_ScrollHint /* None */,
    PPtr<ConsoleHint> m_ConfirmHint /* None */)
{
    public static RankEntryFeatureDescriptionConsoleView Read(EndianBinaryReader reader)
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
        PPtr<ConsoleHint> _m_ScrollHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_ConfirmHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HeaderBlock,
            _m_HeaderLabel,
            _m_InfoView,
            _m_ScrollHint,
            _m_ConfirmHint);
    }
}

