namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $BugReportCanvas (7 fields) B2748EE9A8F0F05BF36E9039519494BC/135BF8CBE8D0C77F56D70FDB95DA7934 */
public record class BugReportCanvas(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> StatusTextMeshPro /* NeedsAlign */,
    PPtr<TextMeshProUGUI> WatermarkText /* None */,
    PPtr<CanvasGroup> m_BugreportCanvasGroup /* None */)
{
    public static BugReportCanvas Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* StatusTextMeshPro */
        PPtr<TextMeshProUGUI> _StatusTextMeshPro = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _WatermarkText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CanvasGroup> _m_BugreportCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _StatusTextMeshPro,
            _WatermarkText,
            _m_BugreportCanvasGroup);
    }
}

