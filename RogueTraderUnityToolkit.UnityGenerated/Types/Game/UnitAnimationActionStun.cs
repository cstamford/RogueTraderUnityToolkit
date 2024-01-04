namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UnitAnimationActionStun (10 fields) CE89BF36D0C464BF5BD3025DDAEE79DB/7DC02B1BFA924A1DC418B3523BFE97F0 */
public record class UnitAnimationActionStun(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float TransitionIn /* NeedsAlign */,
    float TransitionOut /* None */,
    int ExecutionMode /* None */,
    byte UseEmptyAvatarMask /* None */,
    PPtr<AvatarMask>[] AvatarMasks /* NeedsAlign */,
    AnimationEntry m_Animations /* None */)
{
    public static UnitAnimationActionStun Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* TransitionIn */
        float _TransitionIn = reader.ReadF32();
        float _TransitionOut = reader.ReadF32();
        int _ExecutionMode = reader.ReadS32();
        byte _UseEmptyAvatarMask = reader.ReadU8();
        reader.AlignTo(4); /* AvatarMasks */
        PPtr<AvatarMask>[] _AvatarMasks = BuiltInArray<PPtr<AvatarMask>>.Read(reader);
        AnimationEntry _m_Animations = AnimationEntry.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _TransitionIn,
            _TransitionOut,
            _ExecutionMode,
            _UseEmptyAvatarMask,
            _AvatarMasks,
            _m_Animations);
    }
}

