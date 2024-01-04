namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $WarhammerUnitAnimationActionHandEquipHuman (11 fields) 59DD3EABF59CEEF7BCFD03E0AD87903D/7E85893FD69CB396BF6BE0B6A53A936E */
public record class WarhammerUnitAnimationActionHandEquipHuman(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float TransitionIn /* NeedsAlign */,
    float TransitionOut /* None */,
    int ExecutionMode /* None */,
    byte UseEmptyAvatarMask /* None */,
    PPtr<AvatarMask>[] AvatarMasks /* NeedsAlign */,
    int m_Type /* None */,
    EquipmentStyleSetting[] m_Styles /* None */)
{
    public static WarhammerUnitAnimationActionHandEquipHuman Read(EndianBinaryReader reader)
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
        int _m_Type = reader.ReadS32();
        EquipmentStyleSetting[] _m_Styles = BuiltInArray<EquipmentStyleSetting>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _TransitionIn,
            _TransitionOut,
            _ExecutionMode,
            _UseEmptyAvatarMask,
            _AvatarMasks,
            _m_Type,
            _m_Styles);
    }
}

