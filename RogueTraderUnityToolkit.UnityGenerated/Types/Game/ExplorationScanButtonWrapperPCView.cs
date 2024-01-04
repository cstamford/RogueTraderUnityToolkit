namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ExplorationScanButtonWrapperPCView (7 fields) 4E6D1ADDD6FB9BD40489AAD679A7BECF/F2B7C583CD28E0A4449A18916694E32F */
public record class ExplorationScanButtonWrapperPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasGroup> m_CanvasGroup /* NeedsAlign */,
    PPtr<OwlcatButton> m_ScanButton /* None */,
    PPtr<TextMeshProUGUI> m_ScanButtonLabel /* None */)
{
    public static ExplorationScanButtonWrapperPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CanvasGroup */
        PPtr<CanvasGroup> _m_CanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<OwlcatButton> _m_ScanButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ScanButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CanvasGroup,
            _m_ScanButton,
            _m_ScanButtonLabel);
    }
}

