namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AoeSnapToTerrain (9 fields) 8B30185DA2A49C8BEE710BD705E28273/0E4D5074727AC15D653EBEA80597A131 */
public record class AoeSnapToTerrain(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    BitField RaycastMask /* NeedsAlign */,
    AABB Bounds /* None */,
    float UpDownShift /* None */,
    byte SingleRaycast /* None */,
    float LimitAngleXZ /* NeedsAlign */)
{
    public static AoeSnapToTerrain Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* RaycastMask */
        BitField _RaycastMask = BitField.Read(reader);
        AABB _Bounds = AABB.Read(reader);
        float _UpDownShift = reader.ReadF32();
        byte _SingleRaycast = reader.ReadU8();
        reader.AlignTo(4); /* LimitAngleXZ */
        float _LimitAngleXZ = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _RaycastMask,
            _Bounds,
            _UpDownShift,
            _SingleRaycast,
            _LimitAngleXZ);
    }
}

