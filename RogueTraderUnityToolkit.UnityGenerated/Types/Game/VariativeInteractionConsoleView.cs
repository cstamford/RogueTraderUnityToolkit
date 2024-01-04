namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VariativeInteractionConsoleView (6 fields) 9B5BC7F6022CD671CEAE8D7C9956C3A1/3318492AAEC6CA81CF7A236406C5D6F0 */
public record class VariativeInteractionConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<WidgetList> WidgetList /* NeedsAlign */,
    PPtr<InteractionVariantConsoleView> m_InteractionVariantViewPrefab /* None */)
{
    public static VariativeInteractionConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* WidgetList */
        PPtr<WidgetList> _WidgetList = PPtr<WidgetList>.Read(reader);
        PPtr<InteractionVariantConsoleView> _m_InteractionVariantViewPrefab = PPtr<InteractionVariantConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _WidgetList,
            _m_InteractionVariantViewPrefab);
    }
}

