namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $MapObjectOvertipsConsoleView (9 fields) F1E2ABC03E9C5CFD71E3ADF539B60472/D13ECB93E296986C5AA3F3B7AC70A617 */
public record class MapObjectOvertipsConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_TargetContainer /* NeedsAlign */,
    PPtr<OvertipTransitionConsoleView> m_OvertipTransitionView /* None */,
    PPtr<OvertipMapObjectSimpleConsoleView> m_OvertipMapObjectSimpleView /* None */,
    PPtr<OvertipMapObjectInteractionConsoleView> m_OvertipMapObjectInteractionView /* None */,
    PPtr<OvertipDestructibleObjectConsoleView> m_OvertipDestructibleObjectView /* None */)
{
    public static MapObjectOvertipsConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TargetContainer */
        PPtr<RectTransform> _m_TargetContainer = PPtr<RectTransform>.Read(reader);
        PPtr<OvertipTransitionConsoleView> _m_OvertipTransitionView = PPtr<OvertipTransitionConsoleView>.Read(reader);
        PPtr<OvertipMapObjectSimpleConsoleView> _m_OvertipMapObjectSimpleView = PPtr<OvertipMapObjectSimpleConsoleView>.Read(reader);
        PPtr<OvertipMapObjectInteractionConsoleView> _m_OvertipMapObjectInteractionView = PPtr<OvertipMapObjectInteractionConsoleView>.Read(reader);
        PPtr<OvertipDestructibleObjectConsoleView> _m_OvertipDestructibleObjectView = PPtr<OvertipDestructibleObjectConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_TargetContainer,
            _m_OvertipTransitionView,
            _m_OvertipMapObjectSimpleView,
            _m_OvertipMapObjectInteractionView,
            _m_OvertipDestructibleObjectView);
    }
}

