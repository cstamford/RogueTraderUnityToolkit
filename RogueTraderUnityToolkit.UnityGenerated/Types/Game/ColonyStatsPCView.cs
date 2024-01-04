namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyStatsPCView (7 fields) 8D779D9F805E31A55D200A2E6199AC9A/9DA0442A99F472BC9D7EB9562B9BE6C6 */
public record class ColonyStatsPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Title /* NeedsAlign */,
    PPtr<WidgetListMVVM> m_WidgetListStats /* None */,
    PPtr<ColonyStatPCView> m_ColonyStatPCView /* None */)
{
    public static ColonyStatsPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Title */
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetListStats = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<ColonyStatPCView> _m_ColonyStatPCView = PPtr<ColonyStatPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Title,
            _m_WidgetListStats,
            _m_ColonyStatPCView);
    }
}

