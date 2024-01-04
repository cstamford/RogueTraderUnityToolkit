namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DollRoomServoskull (10 fields) 3E4D4B8785061E631BA1E3F59BCBEC73/7D62C4075EEBA3DE48A261E5DE872AF1 */
public record class DollRoomServoskull(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Transform> LookAtObject /* NeedsAlign */,
    PPtr<Transform> RotationDonorRoot /* None */,
    PPtr<Transform> RotationDonor /* None */,
    PPtr<Transform> LookAtTarget /* None */,
    Vector3f ServitorRootUpDirection /* None */,
    byte EditorMode /* None */)
{
    public static DollRoomServoskull Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* LookAtObject */
        PPtr<Transform> _LookAtObject = PPtr<Transform>.Read(reader);
        PPtr<Transform> _RotationDonorRoot = PPtr<Transform>.Read(reader);
        PPtr<Transform> _RotationDonor = PPtr<Transform>.Read(reader);
        PPtr<Transform> _LookAtTarget = PPtr<Transform>.Read(reader);
        Vector3f _ServitorRootUpDirection = Vector3f.Read(reader);
        byte _EditorMode = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _LookAtObject,
            _RotationDonorRoot,
            _RotationDonor,
            _LookAtTarget,
            _ServitorRootUpDirection,
            _EditorMode);
    }
}

