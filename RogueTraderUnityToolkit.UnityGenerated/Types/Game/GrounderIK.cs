namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $GrounderIK (12 fields) 279228D5473D1E8657E9CB1FFC68DE1F/2B8B0E2BA28628AE45633B0403517FD3 */
public record class GrounderIK(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float weight /* NeedsAlign */,
    Grounding solver /* None */,
    PPtr<IK>[] legs /* NeedsAlign */,
    PPtr<Transform> pelvis /* None */,
    PPtr<Transform> characterRoot /* None */,
    float rootRotationWeight /* None */,
    float rootRotationSpeed /* None */,
    float maxRootRotationAngle /* None */)
{
    public static GrounderIK Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* weight */
        float _weight = reader.ReadF32();
        Grounding _solver = Grounding.Read(reader);
        reader.AlignTo(4); /* legs */
        PPtr<IK>[] _legs = BuiltInArray<PPtr<IK>>.Read(reader);
        PPtr<Transform> _pelvis = PPtr<Transform>.Read(reader);
        PPtr<Transform> _characterRoot = PPtr<Transform>.Read(reader);
        float _rootRotationWeight = reader.ReadF32();
        float _rootRotationSpeed = reader.ReadF32();
        float _maxRootRotationAngle = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _weight,
            _solver,
            _legs,
            _pelvis,
            _characterRoot,
            _rootRotationWeight,
            _rootRotationSpeed,
            _maxRootRotationAngle);
    }
}

