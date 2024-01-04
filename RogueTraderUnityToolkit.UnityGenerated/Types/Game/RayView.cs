namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $RayView (18 fields) 1FBBBDFBB08A86B2115A1DBA1853FE29/CADFC99E51C26CCBC3BBC1139838C4FA */
public record class RayView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    BlueprintProjectileTrajectoryReference m_Trajectory /* NeedsAlign */,
    float m_DistanceBetweenVertices /* NeedsAlign */,
    byte m_SnapToGround /* None */,
    float m_Delay /* NeedsAlign */,
    float m_DelayAfterHit /* None */,
    float m_FadeInSpeed /* None */,
    float m_FadeInDistance /* None */,
    byte m_FadeOutEnabled /* None */,
    float m_FadeOutSpeed /* NeedsAlign */,
    float m_FadeOutDistance /* None */,
    PPtr<AnimationClip> m_FinishingAnimation /* None */,
    float m_UV0XSpeed /* None */,
    byte m_ApplyFadeInSpeeedToUV0X /* None */,
    float m_UV0XAlphaSpeedScale /* NeedsAlign */)
{
    public static RayView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Trajectory */
        BlueprintProjectileTrajectoryReference _m_Trajectory = BlueprintProjectileTrajectoryReference.Read(reader);
        reader.AlignTo(4); /* m_DistanceBetweenVertices */
        float _m_DistanceBetweenVertices = reader.ReadF32();
        byte _m_SnapToGround = reader.ReadU8();
        reader.AlignTo(4); /* m_Delay */
        float _m_Delay = reader.ReadF32();
        float _m_DelayAfterHit = reader.ReadF32();
        float _m_FadeInSpeed = reader.ReadF32();
        float _m_FadeInDistance = reader.ReadF32();
        byte _m_FadeOutEnabled = reader.ReadU8();
        reader.AlignTo(4); /* m_FadeOutSpeed */
        float _m_FadeOutSpeed = reader.ReadF32();
        float _m_FadeOutDistance = reader.ReadF32();
        PPtr<AnimationClip> _m_FinishingAnimation = PPtr<AnimationClip>.Read(reader);
        float _m_UV0XSpeed = reader.ReadF32();
        byte _m_ApplyFadeInSpeeedToUV0X = reader.ReadU8();
        reader.AlignTo(4); /* m_UV0XAlphaSpeedScale */
        float _m_UV0XAlphaSpeedScale = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Trajectory,
            _m_DistanceBetweenVertices,
            _m_SnapToGround,
            _m_Delay,
            _m_DelayAfterHit,
            _m_FadeInSpeed,
            _m_FadeInDistance,
            _m_FadeOutEnabled,
            _m_FadeOutSpeed,
            _m_FadeOutDistance,
            _m_FinishingAnimation,
            _m_UV0XSpeed,
            _m_ApplyFadeInSpeeedToUV0X,
            _m_UV0XAlphaSpeedScale);
    }
}

