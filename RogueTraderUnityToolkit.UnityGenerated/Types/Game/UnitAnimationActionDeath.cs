namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UnitAnimationActionDeath (19 fields) EB37FCEF300A11D17DA1FC41B242B008/4ECFCBD791DD88E9BD89691D17035A93 */
public record class UnitAnimationActionDeath(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float TransitionIn /* NeedsAlign */,
    float TransitionOut /* None */,
    int ExecutionMode /* None */,
    byte UseEmptyAvatarMask /* None */,
    PPtr<AvatarMask>[] AvatarMasks /* NeedsAlign */,
    AnimationContainer DeathBase /* None */,
    AnimationContainer DeathInProneBack /* None */,
    AnimationContainer DeathInProneForward /* None */,
    AnimationContainer DeathConvultion /* None */,
    AnimationContainer DeathBehead /* None */,
    AnimationContainer DeathMashineGun /* None */,
    AnimationContainer DeathCutTheThroat /* None */,
    AnimationContainer DeathToxic /* None */,
    AnimationContainer DeathPsy /* None */,
    AnimationContainer DeathGuts /* None */)
{
    public static UnitAnimationActionDeath Read(EndianBinaryReader reader)
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
        AnimationContainer _DeathBase = AnimationContainer.Read(reader);
        AnimationContainer _DeathInProneBack = AnimationContainer.Read(reader);
        AnimationContainer _DeathInProneForward = AnimationContainer.Read(reader);
        AnimationContainer _DeathConvultion = AnimationContainer.Read(reader);
        AnimationContainer _DeathBehead = AnimationContainer.Read(reader);
        AnimationContainer _DeathMashineGun = AnimationContainer.Read(reader);
        AnimationContainer _DeathCutTheThroat = AnimationContainer.Read(reader);
        AnimationContainer _DeathToxic = AnimationContainer.Read(reader);
        AnimationContainer _DeathPsy = AnimationContainer.Read(reader);
        AnimationContainer _DeathGuts = AnimationContainer.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _TransitionIn,
            _TransitionOut,
            _ExecutionMode,
            _UseEmptyAvatarMask,
            _AvatarMasks,
            _DeathBase,
            _DeathInProneBack,
            _DeathInProneForward,
            _DeathConvultion,
            _DeathBehead,
            _DeathMashineGun,
            _DeathCutTheThroat,
            _DeathToxic,
            _DeathPsy,
            _DeathGuts);
    }
}

