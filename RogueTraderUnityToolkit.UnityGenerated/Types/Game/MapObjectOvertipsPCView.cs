namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $MapObjectOvertipsPCView (9 fields) 800308D6E1146FF71D21ABB01D4129AF/6B6537BDD038A297C5CFAB15EC589E40 */
public record class MapObjectOvertipsPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_TargetContainer /* NeedsAlign */,
    PPtr<OvertipTransitionPCView> m_OvertipTransitionView /* None */,
    PPtr<OvertipMapObjectSimplePCView> m_OvertipMapObjectSimpleView /* None */,
    PPtr<OvertipMapObjectInteractionPCView> m_OvertipMapObjectInteractionView /* None */,
    PPtr<OvertipDestructibleObjectPCView> m_OvertipDestructibleObjectView /* None */)
{
    public static MapObjectOvertipsPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TargetContainer */
        PPtr<RectTransform> _m_TargetContainer = PPtr<RectTransform>.Read(reader);
        PPtr<OvertipTransitionPCView> _m_OvertipTransitionView = PPtr<OvertipTransitionPCView>.Read(reader);
        PPtr<OvertipMapObjectSimplePCView> _m_OvertipMapObjectSimpleView = PPtr<OvertipMapObjectSimplePCView>.Read(reader);
        PPtr<OvertipMapObjectInteractionPCView> _m_OvertipMapObjectInteractionView = PPtr<OvertipMapObjectInteractionPCView>.Read(reader);
        PPtr<OvertipDestructibleObjectPCView> _m_OvertipDestructibleObjectView = PPtr<OvertipDestructibleObjectPCView>.Read(reader);
        
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

