namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SystemScannerView (9 fields) AE6EB1AD9FED2CAE9F072A9FC277CB7F/4A1956BF0A830769D9EC0DF67E552DB9 */
public record class SystemScannerView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_Radar /* NeedsAlign */,
    PPtr<WidgetListMVVM> m_WidgetListObjects /* None */,
    PPtr<SystemScannerObjectView> m_SystemScannerObjectViewPrefab /* None */,
    PPtr<CanvasGroup> m_RadarCanvasGroup /* None */,
    PPtr<TextMeshProUGUI> m_AnomaliesTypesText /* None */)
{
    public static SystemScannerView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Radar */
        PPtr<RectTransform> _m_Radar = PPtr<RectTransform>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetListObjects = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<SystemScannerObjectView> _m_SystemScannerObjectViewPrefab = PPtr<SystemScannerObjectView>.Read(reader);
        PPtr<CanvasGroup> _m_RadarCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AnomaliesTypesText = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Radar,
            _m_WidgetListObjects,
            _m_SystemScannerObjectViewPrefab,
            _m_RadarCanvasGroup,
            _m_AnomaliesTypesText);
    }
}

