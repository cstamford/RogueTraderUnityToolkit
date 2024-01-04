namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipContextConsoleView (9 fields) 4E26B5CD5D23C644C7931693F0788C3E/60B76E55B60EE457839BB41979AC892B */
public record class TooltipContextConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TooltipConsoleView> m_TooltipConsoleView /* NeedsAlign */,
    PPtr<HintView> m_HintView /* None */,
    PPtr<ComparativeTooltipConsoleView> m_ComparativeTooltipConsoleView /* None */,
    PPtr<InfoWindowConsoleView> m_InfoWindowConsoleView /* None */,
    PPtr<InfoWindowConsoleView> m_GlossaryInfoWindowConsoleView /* None */)
{
    public static TooltipContextConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TooltipConsoleView */
        PPtr<TooltipConsoleView> _m_TooltipConsoleView = PPtr<TooltipConsoleView>.Read(reader);
        PPtr<HintView> _m_HintView = PPtr<HintView>.Read(reader);
        PPtr<ComparativeTooltipConsoleView> _m_ComparativeTooltipConsoleView = PPtr<ComparativeTooltipConsoleView>.Read(reader);
        PPtr<InfoWindowConsoleView> _m_InfoWindowConsoleView = PPtr<InfoWindowConsoleView>.Read(reader);
        PPtr<InfoWindowConsoleView> _m_GlossaryInfoWindowConsoleView = PPtr<InfoWindowConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_TooltipConsoleView,
            _m_HintView,
            _m_ComparativeTooltipConsoleView,
            _m_InfoWindowConsoleView,
            _m_GlossaryInfoWindowConsoleView);
    }
}

