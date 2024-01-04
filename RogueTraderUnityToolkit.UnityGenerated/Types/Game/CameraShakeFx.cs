namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CameraShakeFx (16 fields) C183F5CF0E944390CAA3BFBD1FB075A0/BE78B2ABA7433E8CB902B82A1E07AEC7 */
public record class CameraShakeFx(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    AnimationCurve DeltaX /* NeedsAlign */,
    AnimationCurve DeltaY /* NeedsAlign */,
    AnimationCurve AmplitudeOverLifetime /* NeedsAlign */,
    AnimationCurve FreqOverLifetime /* NeedsAlign */,
    AnimationCurve AmplitudeOverDistance /* NeedsAlign */,
    AnimationCurve FreqOverDistance /* NeedsAlign */,
    byte ShakeAnchor /* NeedsAlign */,
    float AmplitudeMultiplier /* NeedsAlign */,
    float FreqMultiplier /* None */,
    byte InvertXRandomly /* None */,
    byte InvertYRandomly /* NeedsAlign */,
    float Delay /* NeedsAlign */)
{
    public static CameraShakeFx Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* DeltaX */
        AnimationCurve _DeltaX = AnimationCurve.Read(reader);
        reader.AlignTo(4); /* DeltaY */
        AnimationCurve _DeltaY = AnimationCurve.Read(reader);
        reader.AlignTo(4); /* AmplitudeOverLifetime */
        AnimationCurve _AmplitudeOverLifetime = AnimationCurve.Read(reader);
        reader.AlignTo(4); /* FreqOverLifetime */
        AnimationCurve _FreqOverLifetime = AnimationCurve.Read(reader);
        reader.AlignTo(4); /* AmplitudeOverDistance */
        AnimationCurve _AmplitudeOverDistance = AnimationCurve.Read(reader);
        reader.AlignTo(4); /* FreqOverDistance */
        AnimationCurve _FreqOverDistance = AnimationCurve.Read(reader);
        reader.AlignTo(4); /* ShakeAnchor */
        byte _ShakeAnchor = reader.ReadU8();
        reader.AlignTo(4); /* AmplitudeMultiplier */
        float _AmplitudeMultiplier = reader.ReadF32();
        float _FreqMultiplier = reader.ReadF32();
        byte _InvertXRandomly = reader.ReadU8();
        reader.AlignTo(4); /* InvertYRandomly */
        byte _InvertYRandomly = reader.ReadU8();
        reader.AlignTo(4); /* Delay */
        float _Delay = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _DeltaX,
            _DeltaY,
            _AmplitudeOverLifetime,
            _FreqOverLifetime,
            _AmplitudeOverDistance,
            _FreqOverDistance,
            _ShakeAnchor,
            _AmplitudeMultiplier,
            _FreqMultiplier,
            _InvertXRandomly,
            _InvertYRandomly,
            _Delay);
    }
}

