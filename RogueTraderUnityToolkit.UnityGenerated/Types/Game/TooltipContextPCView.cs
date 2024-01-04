namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipContextPCView (9 fields) EDC6DE91C24B5B3B2190FF97903C9DFE/87C40D41D154549046D656E6E551C28A */
public record class TooltipContextPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TooltipPCView> m_TooltipPCView /* NeedsAlign */,
    PPtr<HintView> m_HintPCView /* None */,
    PPtr<InfoWindowPCView> m_InfoWindowPCView /* None */,
    PPtr<InfoWindowPCView> m_GlossaryInfoWindowPCView /* None */,
    PPtr<ComparativeTooltipPCView> m_ComparativeTooltipPCView /* None */)
{
    public static TooltipContextPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TooltipPCView */
        PPtr<TooltipPCView> _m_TooltipPCView = PPtr<TooltipPCView>.Read(reader);
        PPtr<HintView> _m_HintPCView = PPtr<HintView>.Read(reader);
        PPtr<InfoWindowPCView> _m_InfoWindowPCView = PPtr<InfoWindowPCView>.Read(reader);
        PPtr<InfoWindowPCView> _m_GlossaryInfoWindowPCView = PPtr<InfoWindowPCView>.Read(reader);
        PPtr<ComparativeTooltipPCView> _m_ComparativeTooltipPCView = PPtr<ComparativeTooltipPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_TooltipPCView,
            _m_HintPCView,
            _m_InfoWindowPCView,
            _m_GlossaryInfoWindowPCView,
            _m_ComparativeTooltipPCView);
    }
}

