namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FxFluidFogInteraction (18 fields) A22ACAD86937C3C1B2C10BD40FE47C56/4E1FE859AB35FEB21B3FD2DD7BDD5C29 */
public record class FxFluidFogInteraction(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float Delay /* NeedsAlign */,
    float Duration /* None */,
    float Lifetime /* None */,
    float RateOverDistance /* None */,
    AnimationCurve RateOverDuration /* None */,
    float RateOverDurationMultiplier /* NeedsAlign */,
    float RadialWeight /* None */,
    byte AlwaysUseObjectRotation /* None */,
    float RandomizePositionRadius /* NeedsAlign */,
    Vector2f RandomizeRotation /* None */,
    float SizeMultiplier /* None */,
    AnimationCurve SizeOverDuration /* None */,
    float ForceMultiplier /* NeedsAlign */,
    AnimationCurve ForceOverDuration /* None */)
{
    public static FxFluidFogInteraction Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Delay */
        float _Delay = reader.ReadF32();
        float _Duration = reader.ReadF32();
        float _Lifetime = reader.ReadF32();
        float _RateOverDistance = reader.ReadF32();
        AnimationCurve _RateOverDuration = AnimationCurve.Read(reader);
        reader.AlignTo(4); /* RateOverDurationMultiplier */
        float _RateOverDurationMultiplier = reader.ReadF32();
        float _RadialWeight = reader.ReadF32();
        byte _AlwaysUseObjectRotation = reader.ReadU8();
        reader.AlignTo(4); /* RandomizePositionRadius */
        float _RandomizePositionRadius = reader.ReadF32();
        Vector2f _RandomizeRotation = Vector2f.Read(reader);
        float _SizeMultiplier = reader.ReadF32();
        AnimationCurve _SizeOverDuration = AnimationCurve.Read(reader);
        reader.AlignTo(4); /* ForceMultiplier */
        float _ForceMultiplier = reader.ReadF32();
        AnimationCurve _ForceOverDuration = AnimationCurve.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Delay,
            _Duration,
            _Lifetime,
            _RateOverDistance,
            _RateOverDuration,
            _RateOverDurationMultiplier,
            _RadialWeight,
            _AlwaysUseObjectRotation,
            _RandomizePositionRadius,
            _RandomizeRotation,
            _SizeMultiplier,
            _SizeOverDuration,
            _ForceMultiplier,
            _ForceOverDuration);
    }
}

