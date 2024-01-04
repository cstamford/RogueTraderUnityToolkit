namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LoadingScreenGlitchAnimator (14 fields) E82D29A90117B076FC76206F208CAA4C/98E92A6A500B662B92AE5A75B3068FF1 */
public record class LoadingScreenGlitchAnimator(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasGroup> m_ShowCanvasGroup /* NeedsAlign */,
    PPtr<Image> m_MainImage /* None */,
    PPtr<Sprite> m_DefaultSprite /* None */,
    PPtr<Image> m_GlitchImage /* None */,
    PPtr<Material> m_GlitchMaterial /* None */,
    float m_FadeTime /* None */,
    float m_GlitchStep /* None */,
    float m_GlitchTime /* None */,
    float m_DelayBeforeGlitch /* None */,
    float m_GlitchStrength /* None */)
{
    public static LoadingScreenGlitchAnimator Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ShowCanvasGroup */
        PPtr<CanvasGroup> _m_ShowCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<Image> _m_MainImage = PPtr<Image>.Read(reader);
        PPtr<Sprite> _m_DefaultSprite = PPtr<Sprite>.Read(reader);
        PPtr<Image> _m_GlitchImage = PPtr<Image>.Read(reader);
        PPtr<Material> _m_GlitchMaterial = PPtr<Material>.Read(reader);
        float _m_FadeTime = reader.ReadF32();
        float _m_GlitchStep = reader.ReadF32();
        float _m_GlitchTime = reader.ReadF32();
        float _m_DelayBeforeGlitch = reader.ReadF32();
        float _m_GlitchStrength = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ShowCanvasGroup,
            _m_MainImage,
            _m_DefaultSprite,
            _m_GlitchImage,
            _m_GlitchMaterial,
            _m_FadeTime,
            _m_GlitchStep,
            _m_GlitchTime,
            _m_DelayBeforeGlitch,
            _m_GlitchStrength);
    }
}

