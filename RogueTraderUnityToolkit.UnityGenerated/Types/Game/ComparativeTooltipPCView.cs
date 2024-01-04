namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ComparativeTooltipPCView (6 fields) 6A77D570984DC4FCC0B285C18AB40009/CBAF01C5839C86D3A7C7F17C63D5B398 */
public record class ComparativeTooltipPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TooltipBaseView> m_TooltipView /* NeedsAlign */,
    PPtr<RectTransform> m_TooltipContainer /* None */)
{
    public static ComparativeTooltipPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TooltipView */
        PPtr<TooltipBaseView> _m_TooltipView = PPtr<TooltipBaseView>.Read(reader);
        PPtr<RectTransform> _m_TooltipContainer = PPtr<RectTransform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_TooltipView,
            _m_TooltipContainer);
    }
}

