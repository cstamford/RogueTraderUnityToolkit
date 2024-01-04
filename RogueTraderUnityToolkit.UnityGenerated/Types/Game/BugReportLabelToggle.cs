namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $BugReportLabelToggle (7 fields) 13F32CA0FAF1D45ED47A7D437E66E01D/00E1C550874EBF3234F07C226133E4A0 */
public record class BugReportLabelToggle(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ToggleWorkaround> WorkToggle /* NeedsAlign */,
    PPtr<TMP_Text> TMP_Text /* None */,
    PPtr<GameObject> m_Selection /* None */)
{
    public static BugReportLabelToggle Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* WorkToggle */
        PPtr<ToggleWorkaround> _WorkToggle = PPtr<ToggleWorkaround>.Read(reader);
        PPtr<TMP_Text> _TMP_Text = PPtr<TMP_Text>.Read(reader);
        PPtr<GameObject> _m_Selection = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _WorkToggle,
            _TMP_Text,
            _m_Selection);
    }
}

