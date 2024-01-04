namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OvertipHitChanceBlockView (22 fields) 9EB56E4387EF2A53422EFEC55EE278C6/396C9340D1C760024B7E2905808EFD48 */
public record class OvertipHitChanceBlockView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasGroup> m_AttackStatusesBlock /* NeedsAlign */,
    PPtr<CanvasGroup> m_HitChanceBlock /* None */,
    PPtr<TextMeshProUGUI> m_HitChance /* None */,
    PPtr<CanvasGroup> m_AbilityBlock /* None */,
    PPtr<Image> m_Ability /* None */,
    ColorRGBA m_PositiveHintColor /* None */,
    ColorRGBA m_NegativeHintColor /* None */,
    PPtr<CanvasGroup> m_DamageObject /* None */,
    PPtr<TextMeshProUGUI> m_Damage /* None */,
    PPtr<CanvasGroup> m_DamageLine /* None */,
    PPtr<CanvasGroup> m_BurstContainer /* None */,
    PPtr<TextMeshProUGUI> m_BurstIndex /* None */,
    PPtr<Image> m_BurstImage /* None */,
    PPtr<CanvasGroup> m_Push /* None */,
    PPtr<Image> m_PushImage /* None */,
    PPtr<TextMeshProUGUI> m_InitialChance /* None */,
    PPtr<SpriteGlitchSurfaceOvertip> m_Glitch /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* None */)
{
    public static OvertipHitChanceBlockView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_AttackStatusesBlock */
        PPtr<CanvasGroup> _m_AttackStatusesBlock = PPtr<CanvasGroup>.Read(reader);
        PPtr<CanvasGroup> _m_HitChanceBlock = PPtr<CanvasGroup>.Read(reader);
        PPtr<TextMeshProUGUI> _m_HitChance = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CanvasGroup> _m_AbilityBlock = PPtr<CanvasGroup>.Read(reader);
        PPtr<Image> _m_Ability = PPtr<Image>.Read(reader);
        ColorRGBA _m_PositiveHintColor = ColorRGBA.Read(reader);
        ColorRGBA _m_NegativeHintColor = ColorRGBA.Read(reader);
        PPtr<CanvasGroup> _m_DamageObject = PPtr<CanvasGroup>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Damage = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CanvasGroup> _m_DamageLine = PPtr<CanvasGroup>.Read(reader);
        PPtr<CanvasGroup> _m_BurstContainer = PPtr<CanvasGroup>.Read(reader);
        PPtr<TextMeshProUGUI> _m_BurstIndex = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_BurstImage = PPtr<Image>.Read(reader);
        PPtr<CanvasGroup> _m_Push = PPtr<CanvasGroup>.Read(reader);
        PPtr<Image> _m_PushImage = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_InitialChance = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<SpriteGlitchSurfaceOvertip> _m_Glitch = PPtr<SpriteGlitchSurfaceOvertip>.Read(reader);
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_AttackStatusesBlock,
            _m_HitChanceBlock,
            _m_HitChance,
            _m_AbilityBlock,
            _m_Ability,
            _m_PositiveHintColor,
            _m_NegativeHintColor,
            _m_DamageObject,
            _m_Damage,
            _m_DamageLine,
            _m_BurstContainer,
            _m_BurstIndex,
            _m_BurstImage,
            _m_Push,
            _m_PushImage,
            _m_InitialChance,
            _m_Glitch,
            _m_FadeAnimator);
    }
}

