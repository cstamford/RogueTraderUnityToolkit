namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SnapToLocator (14 fields) B342748AB12FAC43BCCEC36E9DF68225/8229B9472AE4328B5959131981844102 */
public record class SnapToLocator(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    AsciiString BoneName /* NeedsAlign */,
    AnimationCurve CameraOffsetScale /* NeedsAlign */,
    byte DontScale /* NeedsAlign */,
    byte DontRotate /* NeedsAlign */,
    byte DontAttach /* NeedsAlign */,
    byte NoOffsetWhileAttached /* NeedsAlign */,
    byte DropToGround /* NeedsAlign */,
    AsciiString[] BoneNames /* NeedsAlign */,
    Reference m_LocatorGroups /* NeedsAlign */,
    int IndexForExtraSnapping /* NeedsAlign */)
{
    public static SnapToLocator Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* BoneName */
        AsciiString _BoneName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* CameraOffsetScale */
        AnimationCurve _CameraOffsetScale = AnimationCurve.Read(reader);
        reader.AlignTo(4); /* DontScale */
        byte _DontScale = reader.ReadU8();
        reader.AlignTo(4); /* DontRotate */
        byte _DontRotate = reader.ReadU8();
        reader.AlignTo(4); /* DontAttach */
        byte _DontAttach = reader.ReadU8();
        reader.AlignTo(4); /* NoOffsetWhileAttached */
        byte _NoOffsetWhileAttached = reader.ReadU8();
        reader.AlignTo(4); /* DropToGround */
        byte _DropToGround = reader.ReadU8();
        reader.AlignTo(4); /* BoneNames */
        AsciiString[] _BoneNames = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_LocatorGroups */
        Reference _m_LocatorGroups = Reference.Read(reader);
        reader.AlignTo(4); /* IndexForExtraSnapping */
        int _IndexForExtraSnapping = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _BoneName,
            _CameraOffsetScale,
            _DontScale,
            _DontRotate,
            _DontAttach,
            _NoOffsetWhileAttached,
            _DropToGround,
            _BoneNames,
            _m_LocatorGroups,
            _IndexForExtraSnapping);
    }
}

