namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DirectorAdapter (9 fields) 0D20BA3F8481276A33370505BF278447/F770E0873681A340AEB81ED5E1E555C7 */
public record class DirectorAdapter(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_IsInGame /* NeedsAlign */,
    AsciiString UniqueId /* NeedsAlign */,
    UnitBinding[] BoundUnits /* NeedsAlign */,
    TrackBinding[] BoundTracks /* NeedsAlign */,
    PPtr<DirectorCameraLink> CameraLink /* NeedsAlign */)
{
    public static DirectorAdapter Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_IsInGame */
        byte _m_IsInGame = reader.ReadU8();
        reader.AlignTo(4); /* UniqueId */
        AsciiString _UniqueId = BuiltInString.Read(reader);
        reader.AlignTo(4); /* BoundUnits */
        UnitBinding[] _BoundUnits = BuiltInArray<UnitBinding>.Read(reader);
        reader.AlignTo(4); /* BoundTracks */
        TrackBinding[] _BoundTracks = BuiltInArray<TrackBinding>.Read(reader);
        reader.AlignTo(4); /* CameraLink */
        PPtr<DirectorCameraLink> _CameraLink = PPtr<DirectorCameraLink>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_IsInGame,
            _UniqueId,
            _BoundUnits,
            _BoundTracks,
            _CameraLink);
    }
}

