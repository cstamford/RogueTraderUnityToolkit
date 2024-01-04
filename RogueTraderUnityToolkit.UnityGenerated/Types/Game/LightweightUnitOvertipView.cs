namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LightweightUnitOvertipView (11 fields) 13E2AD5B3F4505DE2468430CFE860A6F/F0BFB5B5111A1DA272D17010E6249A89 */
public record class LightweightUnitOvertipView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OvertipLightweightUnitNameView> m_NameBlockPCView /* NeedsAlign */,
    PPtr<OvertipBarkBlockView> m_BarkBlockPCView /* None */,
    PPtr<RectTransform> m_RectTransform /* None */,
    PPtr<CanvasGroup> m_InnerCanvasGroup /* None */,
    UnitOvertipVisibilitySettings[] m_UnitOvertipVisibilitySettings /* None */,
    float m_FarDistance /* None */,
    float m_StandardOvertipPositionYCorrection /* None */)
{
    public static LightweightUnitOvertipView Read(EndianBinaryReader reader)
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
        UnitOvertipVisibilitySettings[] _m_UnitOvertipVisibilitySettings = BuiltInArray<UnitOvertipVisibilitySettings>.Read(reader);
        float _m_FarDistance = reader.ReadF32();
        float _m_StandardOvertipPositionYCorrection = reader.ReadF32();
        
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
            _m_StandardOvertipPositionYCorrection);
    }
}

