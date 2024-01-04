namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AnimatedLight (23 fields) B0CBA514F1FCB9CBB95782001CA03E66/28E47F0DC181E8C5D285CECBAF393EC6 */
public record class AnimatedLight(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float m_Delay /* NeedsAlign */,
    float m_Lifetime /* None */,
    float m_Frequency /* None */,
    Gradient m_ColorOverLifetime /* None */,
    float m_ColorMin /* NeedsAlign */,
    float m_ColorMax /* None */,
    AnimationCurve m_RangeOverLifetime /* None */,
    float m_RandomRangeMin /* NeedsAlign */,
    float m_RandomRangeMax /* None */,
    AnimationCurve m_MoveXOverLifetime /* None */,
    AnimationCurve m_MoveYOverLifetime /* NeedsAlign */,
    AnimationCurve m_MoveZOverLifetime /* NeedsAlign */,
    float m_MoveMultiplier /* NeedsAlign */,
    byte m_LoopAnimation /* None */,
    byte m_MoveInWorldspace /* NeedsAlign */,
    byte m_DestroyOnEnd /* NeedsAlign */,
    ColorRGBA m_Color /* NeedsAlign */,
    float m_Intensity /* None */,
    float m_Range /* None */)
{
    public static AnimatedLight Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Delay */
        float _m_Delay = reader.ReadF32();
        float _m_Lifetime = reader.ReadF32();
        float _m_Frequency = reader.ReadF32();
        Gradient _m_ColorOverLifetime = Gradient.Read(reader);
        reader.AlignTo(4); /* m_ColorMin */
        float _m_ColorMin = reader.ReadF32();
        float _m_ColorMax = reader.ReadF32();
        AnimationCurve _m_RangeOverLifetime = AnimationCurve.Read(reader);
        reader.AlignTo(4); /* m_RandomRangeMin */
        float _m_RandomRangeMin = reader.ReadF32();
        float _m_RandomRangeMax = reader.ReadF32();
        AnimationCurve _m_MoveXOverLifetime = AnimationCurve.Read(reader);
        reader.AlignTo(4); /* m_MoveYOverLifetime */
        AnimationCurve _m_MoveYOverLifetime = AnimationCurve.Read(reader);
        reader.AlignTo(4); /* m_MoveZOverLifetime */
        AnimationCurve _m_MoveZOverLifetime = AnimationCurve.Read(reader);
        reader.AlignTo(4); /* m_MoveMultiplier */
        float _m_MoveMultiplier = reader.ReadF32();
        byte _m_LoopAnimation = reader.ReadU8();
        reader.AlignTo(4); /* m_MoveInWorldspace */
        byte _m_MoveInWorldspace = reader.ReadU8();
        reader.AlignTo(4); /* m_DestroyOnEnd */
        byte _m_DestroyOnEnd = reader.ReadU8();
        reader.AlignTo(4); /* m_Color */
        ColorRGBA _m_Color = ColorRGBA.Read(reader);
        float _m_Intensity = reader.ReadF32();
        float _m_Range = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Delay,
            _m_Lifetime,
            _m_Frequency,
            _m_ColorOverLifetime,
            _m_ColorMin,
            _m_ColorMax,
            _m_RangeOverLifetime,
            _m_RandomRangeMin,
            _m_RandomRangeMax,
            _m_MoveXOverLifetime,
            _m_MoveYOverLifetime,
            _m_MoveZOverLifetime,
            _m_MoveMultiplier,
            _m_LoopAnimation,
            _m_MoveInWorldspace,
            _m_DestroyOnEnd,
            _m_Color,
            _m_Intensity,
            _m_Range);
    }
}

