namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AnimationPlayableAsset (14 fields) 79F6AD0C3A0B147002779779703CC402/87CA37F56CF28ED0FD15F621770E693D */
public record class AnimationPlayableAsset(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<AnimationClip> m_Clip /* NeedsAlign */,
    Vector3f m_Position /* None */,
    Vector3f m_EulerAngles /* None */,
    byte m_UseTrackMatchFields /* None */,
    int m_MatchTargetFields /* NeedsAlign */,
    byte m_RemoveStartOffset /* None */,
    byte m_ApplyFootIK /* NeedsAlign */,
    int m_Loop /* NeedsAlign */,
    int m_Version /* None */,
    Quaternionf m_Rotation /* None */)
{
    public static AnimationPlayableAsset Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Clip */
        PPtr<AnimationClip> _m_Clip = PPtr<AnimationClip>.Read(reader);
        Vector3f _m_Position = Vector3f.Read(reader);
        Vector3f _m_EulerAngles = Vector3f.Read(reader);
        byte _m_UseTrackMatchFields = reader.ReadU8();
        reader.AlignTo(4); /* m_MatchTargetFields */
        int _m_MatchTargetFields = reader.ReadS32();
        byte _m_RemoveStartOffset = reader.ReadU8();
        reader.AlignTo(4); /* m_ApplyFootIK */
        byte _m_ApplyFootIK = reader.ReadU8();
        reader.AlignTo(4); /* m_Loop */
        int _m_Loop = reader.ReadS32();
        int _m_Version = reader.ReadS32();
        Quaternionf _m_Rotation = Quaternionf.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Clip,
            _m_Position,
            _m_EulerAngles,
            _m_UseTrackMatchFields,
            _m_MatchTargetFields,
            _m_RemoveStartOffset,
            _m_ApplyFootIK,
            _m_Loop,
            _m_Version,
            _m_Rotation);
    }
}

