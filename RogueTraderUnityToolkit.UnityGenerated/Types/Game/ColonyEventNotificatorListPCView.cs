namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyEventNotificatorListPCView (6 fields) E9778DD7CA21E8CD009A6C1EA65FD202/4433AA9CB9CB0079CF8533670734E48C */
public record class ColonyEventNotificatorListPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ColonyEventNotificatorPCView> m_ColonyEventNotificatorPCView /* NeedsAlign */,
    PPtr<WidgetListMVVM> m_WidgetListNotificators /* None */)
{
    public static ColonyEventNotificatorListPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ColonyEventNotificatorPCView */
        PPtr<ColonyEventNotificatorPCView> _m_ColonyEventNotificatorPCView = PPtr<ColonyEventNotificatorPCView>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetListNotificators = PPtr<WidgetListMVVM>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ColonyEventNotificatorPCView,
            _m_WidgetListNotificators);
    }
}

