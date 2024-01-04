namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OvertipMapObjectSimpleConsoleView (14 fields) CB7442665569E7D316FB115A662D9F0D/A37C8BF3E106F033DF3A982596D22007 */
public record class OvertipMapObjectSimpleConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OvertipBarkBlockView> m_BarkBlockPCView /* NeedsAlign */,
    PPtr<MapObjectOvertipNameBlockView> m_OvertipNameBlockPCView /* None */,
    PPtr<MapObjectOvertipSkillCheckBlockView> m_OvertipSkillCheckBlockPCView /* None */,
    PPtr<CanvasGroup> m_InnerCanvasGroup /* None */,
    PPtr<OvertipConsoleView> m_OvertipConsoleView /* None */,
    byte m_NeedHintPositionCorrection /* None */,
    float m_ConfirmUpperY /* NeedsAlign */,
    float m_ConfirmLowerY /* None */,
    float m_PaginatorUpperY /* None */,
    float m_PaginatorLowerY /* None */)
{
    public static OvertipMapObjectSimpleConsoleView Read(EndianBinaryReader reader)
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
        PPtr<OvertipConsoleView> _m_OvertipConsoleView = PPtr<OvertipConsoleView>.Read(reader);
        byte _m_NeedHintPositionCorrection = reader.ReadU8();
        reader.AlignTo(4); /* m_ConfirmUpperY */
        float _m_ConfirmUpperY = reader.ReadF32();
        float _m_ConfirmLowerY = reader.ReadF32();
        float _m_PaginatorUpperY = reader.ReadF32();
        float _m_PaginatorLowerY = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_BarkBlockPCView,
            _m_OvertipNameBlockPCView,
            _m_OvertipSkillCheckBlockPCView,
            _m_InnerCanvasGroup,
            _m_OvertipConsoleView,
            _m_NeedHintPositionCorrection,
            _m_ConfirmUpperY,
            _m_ConfirmLowerY,
            _m_PaginatorUpperY,
            _m_PaginatorLowerY);
    }
}

