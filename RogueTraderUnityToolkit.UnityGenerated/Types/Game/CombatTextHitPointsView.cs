namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CombatTextHitPointsView (18 fields) 09898375A57396008C52AB6AB4E7C222/D422C7A88E8DC77B5E80E8B835640F67 */
public record class CombatTextHitPointsView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float Duration /* NeedsAlign */,
    float ShowFadeTime /* None */,
    PPtr<CanvasGroup> m_CanvasGroup /* None */,
    PPtr<TextMeshProUGUI> m_Text /* None */,
    ColorRGBA m_DamageColor /* None */,
    ColorRGBA m_CritDamageColor /* None */,
    ColorRGBA m_HealColor /* None */,
    ColorRGBA m_MissColor /* None */,
    float m_MoveDelta /* None */,
    float m_DamageScaleDelta /* None */,
    float m_CritScaleDelta /* None */,
    float m_MissScaleDelta /* None */,
    float m_MoveTime /* None */,
    int m_MoveEase /* None */)
{
    public static CombatTextHitPointsView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Duration */
        float _Duration = reader.ReadF32();
        float _ShowFadeTime = reader.ReadF32();
        PPtr<CanvasGroup> _m_CanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Text = PPtr<TextMeshProUGUI>.Read(reader);
        ColorRGBA _m_DamageColor = ColorRGBA.Read(reader);
        ColorRGBA _m_CritDamageColor = ColorRGBA.Read(reader);
        ColorRGBA _m_HealColor = ColorRGBA.Read(reader);
        ColorRGBA _m_MissColor = ColorRGBA.Read(reader);
        float _m_MoveDelta = reader.ReadF32();
        float _m_DamageScaleDelta = reader.ReadF32();
        float _m_CritScaleDelta = reader.ReadF32();
        float _m_MissScaleDelta = reader.ReadF32();
        float _m_MoveTime = reader.ReadF32();
        int _m_MoveEase = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Duration,
            _ShowFadeTime,
            _m_CanvasGroup,
            _m_Text,
            _m_DamageColor,
            _m_CritDamageColor,
            _m_HealColor,
            _m_MissColor,
            _m_MoveDelta,
            _m_DamageScaleDelta,
            _m_CritScaleDelta,
            _m_MissScaleDelta,
            _m_MoveTime,
            _m_MoveEase);
    }
}

