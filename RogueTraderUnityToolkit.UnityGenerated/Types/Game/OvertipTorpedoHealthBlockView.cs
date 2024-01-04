namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OvertipTorpedoHealthBlockView (11 fields) 6C044E99E191B1FFBBFB33ADD8981C43/204459125F4E54ECA756896D3CFB4709 */
public record class OvertipTorpedoHealthBlockView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_RectTransform /* NeedsAlign */,
    PPtr<CanvasGroup> m_CanvasGroup /* None */,
    OvertipTorpedoHealthPoint[] m_HealthPoints /* None */,
    ColorRGBA[] m_HealthPointColors /* None */,
    PPtr<CanvasGroup> m_DamageHealthCanvasGroup /* NeedsAlign */,
    float m_DamageHealthBlinkAlpha /* None */,
    UnitOvertipVisibilitySettings m_UnitOvertipVisibilitySettings /* None */)
{
    public static OvertipTorpedoHealthBlockView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_RectTransform */
        PPtr<RectTransform> _m_RectTransform = PPtr<RectTransform>.Read(reader);
        PPtr<CanvasGroup> _m_CanvasGroup = PPtr<CanvasGroup>.Read(reader);
        OvertipTorpedoHealthPoint[] _m_HealthPoints = BuiltInArray<OvertipTorpedoHealthPoint>.Read(reader);
        ColorRGBA[] _m_HealthPointColors = BuiltInArray<ColorRGBA>.Read(reader);
        reader.AlignTo(4); /* m_DamageHealthCanvasGroup */
        PPtr<CanvasGroup> _m_DamageHealthCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        float _m_DamageHealthBlinkAlpha = reader.ReadF32();
        UnitOvertipVisibilitySettings _m_UnitOvertipVisibilitySettings = UnitOvertipVisibilitySettings.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_RectTransform,
            _m_CanvasGroup,
            _m_HealthPoints,
            _m_HealthPointColors,
            _m_DamageHealthCanvasGroup,
            _m_DamageHealthBlinkAlpha,
            _m_UnitOvertipVisibilitySettings);
    }
}

