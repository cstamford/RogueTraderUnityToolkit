namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OvertipTorpedoUnitView (11 fields) AFB6A956EB6440D480DB73C293DB4F8F/6C9015DC649BF9A2601A82C31AA602A6 */
public record class OvertipTorpedoUnitView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OvertipTorpedoHealthBlockView> m_OvertipTorpedoHealthBlockView /* NeedsAlign */,
    PPtr<OvertipUnitNameView> m_NameBlockPCView /* None */,
    PPtr<OvertipTorpedoRoundsBlockView> m_OvertipTorpedoRoundsBlockView /* None */,
    PPtr<RectTransform> m_RectTransform /* None */,
    PPtr<CanvasGroup> m_InnerCanvasGroup /* None */,
    UnitOvertipVisibilitySettings m_UnitOvertipVisibilitySettings /* None */,
    float m_FarDistance /* None */)
{
    public static OvertipTorpedoUnitView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_OvertipTorpedoHealthBlockView */
        PPtr<OvertipTorpedoHealthBlockView> _m_OvertipTorpedoHealthBlockView = PPtr<OvertipTorpedoHealthBlockView>.Read(reader);
        PPtr<OvertipUnitNameView> _m_NameBlockPCView = PPtr<OvertipUnitNameView>.Read(reader);
        PPtr<OvertipTorpedoRoundsBlockView> _m_OvertipTorpedoRoundsBlockView = PPtr<OvertipTorpedoRoundsBlockView>.Read(reader);
        PPtr<RectTransform> _m_RectTransform = PPtr<RectTransform>.Read(reader);
        PPtr<CanvasGroup> _m_InnerCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        UnitOvertipVisibilitySettings _m_UnitOvertipVisibilitySettings = UnitOvertipVisibilitySettings.Read(reader);
        float _m_FarDistance = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_OvertipTorpedoHealthBlockView,
            _m_NameBlockPCView,
            _m_OvertipTorpedoRoundsBlockView,
            _m_RectTransform,
            _m_InnerCanvasGroup,
            _m_UnitOvertipVisibilitySettings,
            _m_FarDistance);
    }
}

