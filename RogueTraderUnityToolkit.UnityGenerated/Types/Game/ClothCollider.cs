namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ClothCollider (7 fields) C0D1EDA5810434398E3336599E567D27/63FA0B8578E0BF27FB0788ED199C5CE9 */
public record class ClothCollider(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Collider> clothColliderCpu /* NeedsAlign */,
    PPtr<PBDColliderCapsule> clothColliderGpu /* None */,
    int bodyPartType /* None */)
{
    public static ClothCollider Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* clothColliderCpu */
        PPtr<Collider> _clothColliderCpu = PPtr<Collider>.Read(reader);
        PPtr<PBDColliderCapsule> _clothColliderGpu = PPtr<PBDColliderCapsule>.Read(reader);
        int _bodyPartType = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _clothColliderCpu,
            _clothColliderGpu,
            _bodyPartType);
    }
}

