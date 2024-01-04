namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OvertipMapObjectSimplePCView (8 fields) 475C76BBCEEAC6AD30CA6FE65897D262/127DC6540A60DCB2C6D9CFE9FE3E87EC */
public record class OvertipMapObjectSimplePCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OvertipBarkBlockView> m_BarkBlockPCView /* NeedsAlign */,
    PPtr<MapObjectOvertipNameBlockView> m_OvertipNameBlockPCView /* None */,
    PPtr<MapObjectOvertipSkillCheckBlockView> m_OvertipSkillCheckBlockPCView /* None */,
    PPtr<CanvasGroup> m_InnerCanvasGroup /* None */)
{
    public static OvertipMapObjectSimplePCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_BarkBlockPCView */
        PPtr<OvertipBarkBlockView> _m_BarkBlockPCView = PPtr<OvertipBarkBlockView>.Read(reader);
        PPtr<MapObjectOvertipNameBlockView> _m_OvertipNameBlockPCView = PPtr<MapObjectOvertipNameBlockView>.Read(reader);
        PPtr<MapObjectOvertipSkillCheckBlockView> _m_OvertipSkillCheckBlockPCView = PPtr<MapObjectOvertipSkillCheckBlockView>.Read(reader);
        PPtr<CanvasGroup> _m_InnerCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_BarkBlockPCView,
            _m_OvertipNameBlockPCView,
            _m_OvertipSkillCheckBlockPCView,
            _m_InnerCanvasGroup);
    }
}

