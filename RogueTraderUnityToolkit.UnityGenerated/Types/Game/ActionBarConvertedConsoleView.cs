namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ActionBarConvertedConsoleView (8 fields) B694BBD25C2BC53E5D311F8897E6A925/B7D41D8DE00FEC12BFF14D6EBAD30A84 */
public record class ActionBarConvertedConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ActionBarBaseSlotView> m_SlotView /* NeedsAlign */,
    PPtr<RectTransform> m_Container /* None */,
    PPtr<ConsoleHintsWidget> m_HintsWidget /* None */,
    PPtr<RectTransform> m_TooltipPlace /* None */)
{
    public static ActionBarConvertedConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SlotView */
        PPtr<ActionBarBaseSlotView> _m_SlotView = PPtr<ActionBarBaseSlotView>.Read(reader);
        PPtr<RectTransform> _m_Container = PPtr<RectTransform>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_HintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        PPtr<RectTransform> _m_TooltipPlace = PPtr<RectTransform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SlotView,
            _m_Container,
            _m_HintsWidget,
            _m_TooltipPlace);
    }
}

