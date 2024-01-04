namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LightweightUnitOvertipConsoleView (12 fields) 2E559EB062080FE2C1F72566B8D51568/7E45EE001539C3E77E6018A3A9A166CD */
public record class LightweightUnitOvertipConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OvertipLightweightUnitNameView> m_NameBlockPCView /* NeedsAlign */,
    PPtr<OvertipBarkBlockView> m_BarkBlockPCView /* None */,
    PPtr<RectTransform> m_RectTransform /* None */,
    PPtr<CanvasGroup> m_InnerCanvasGroup /* None */,
    UnitOvertipVisibilitySettings m_UnitOvertipVisibilitySettings /* None */,
    float m_FarDistance /* None */,
    float m_StandardOvertipPositionYCorrection /* None */,
    PPtr<OvertipConsoleView> m_OvertipConsoleView /* None */)
{
    public static LightweightUnitOvertipConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_NameBlockPCView */
        PPtr<OvertipLightweightUnitNameView> _m_NameBlockPCView = PPtr<OvertipLightweightUnitNameView>.Read(reader);
        PPtr<OvertipBarkBlockView> _m_BarkBlockPCView = PPtr<OvertipBarkBlockView>.Read(reader);
        PPtr<RectTransform> _m_RectTransform = PPtr<RectTransform>.Read(reader);
        PPtr<CanvasGroup> _m_InnerCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        UnitOvertipVisibilitySettings _m_UnitOvertipVisibilitySettings = UnitOvertipVisibilitySettings.Read(reader);
        float _m_FarDistance = reader.ReadF32();
        float _m_StandardOvertipPositionYCorrection = reader.ReadF32();
        PPtr<OvertipConsoleView> _m_OvertipConsoleView = PPtr<OvertipConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_NameBlockPCView,
            _m_BarkBlockPCView,
            _m_RectTransform,
            _m_InnerCanvasGroup,
            _m_UnitOvertipVisibilitySettings,
            _m_FarDistance,
            _m_StandardOvertipPositionYCorrection,
            _m_OvertipConsoleView);
    }
}

