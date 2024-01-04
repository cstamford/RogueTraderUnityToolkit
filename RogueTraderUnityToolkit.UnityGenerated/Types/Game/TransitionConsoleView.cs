namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TransitionConsoleView (9 fields) E7CD6E1A8DEEF94D993264CA5D36EFC6/A810E9FDC2F741C23F83B5962347F4CB */
public record class TransitionConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_MapName /* NeedsAlign */,
    TransitionMapPart m_Parts /* None */,
    PPtr<PantographView> m_PantographView /* NeedsAlign */,
    PPtr<TransitionLegendButtonView> m_TransitionLegendButtonViewPrefab /* None */,
    PPtr<ConsoleHintsWidget> m_HintsWidget /* None */)
{
    public static TransitionConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MapName */
        PPtr<TextMeshProUGUI> _m_MapName = PPtr<TextMeshProUGUI>.Read(reader);
        TransitionMapPart _m_Parts = TransitionMapPart.Read(reader);
        reader.AlignTo(4); /* m_PantographView */
        PPtr<PantographView> _m_PantographView = PPtr<PantographView>.Read(reader);
        PPtr<TransitionLegendButtonView> _m_TransitionLegendButtonViewPrefab = PPtr<TransitionLegendButtonView>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_HintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MapName,
            _m_Parts,
            _m_PantographView,
            _m_TransitionLegendButtonViewPrefab,
            _m_HintsWidget);
    }
}

