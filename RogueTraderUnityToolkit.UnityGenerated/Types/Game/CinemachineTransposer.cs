namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CinemachineTransposer (14 fields) BA8DBF049C7E868E5563933CE44384C1/551428FA4075AEDFC96EEAABD93071F9 */
public record class CinemachineTransposer(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int m_BindingMode /* NeedsAlign */,
    Vector3f m_FollowOffset /* None */,
    float m_XDamping /* None */,
    float m_YDamping /* None */,
    float m_ZDamping /* None */,
    int m_AngularDampingMode /* None */,
    float m_PitchDamping /* None */,
    float m_YawDamping /* None */,
    float m_RollDamping /* None */,
    float m_AngularDamping /* None */)
{
    public static CinemachineTransposer Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_BindingMode */
        int _m_BindingMode = reader.ReadS32();
        Vector3f _m_FollowOffset = Vector3f.Read(reader);
        float _m_XDamping = reader.ReadF32();
        float _m_YDamping = reader.ReadF32();
        float _m_ZDamping = reader.ReadF32();
        int _m_AngularDampingMode = reader.ReadS32();
        float _m_PitchDamping = reader.ReadF32();
        float _m_YawDamping = reader.ReadF32();
        float _m_RollDamping = reader.ReadF32();
        float _m_AngularDamping = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_BindingMode,
            _m_FollowOffset,
            _m_XDamping,
            _m_YDamping,
            _m_ZDamping,
            _m_AngularDampingMode,
            _m_PitchDamping,
            _m_YawDamping,
            _m_RollDamping,
            _m_AngularDamping);
    }
}

