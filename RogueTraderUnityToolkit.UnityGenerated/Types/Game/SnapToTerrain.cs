namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SnapToTerrain (8 fields) 0551F50FEED6CDD5F56FAEB345502270/00F0FC2E80225A9C6097B44DDCDC8DA6 */
public record class SnapToTerrain(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    AABB Bounds /* NeedsAlign */,
    byte NoRotationSnap /* None */,
    byte FixParentRotation /* NeedsAlign */,
    float UpShift /* NeedsAlign */)
{
    public static SnapToTerrain Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Bounds */
        AABB _Bounds = AABB.Read(reader);
        byte _NoRotationSnap = reader.ReadU8();
        reader.AlignTo(4); /* FixParentRotation */
        byte _FixParentRotation = reader.ReadU8();
        reader.AlignTo(4); /* UpShift */
        float _UpShift = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Bounds,
            _NoRotationSnap,
            _FixParentRotation,
            _UpShift);
    }
}

