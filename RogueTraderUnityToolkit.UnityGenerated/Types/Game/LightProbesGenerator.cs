namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LightProbesGenerator (10 fields) 4ECDEC1DA5BB30F9ACFFC2FE13CD9B75/1752C724D63A15C2A776E65F70CA55A3 */
public record class LightProbesGenerator(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    AABB Bounds /* NeedsAlign */,
    float GridStep /* None */,
    int LevelCount /* None */,
    float LevelHeight /* None */,
    float OffsetY /* None */,
    BitField RaycastMask /* None */)
{
    public static LightProbesGenerator Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Bounds */
        AABB _Bounds = AABB.Read(reader);
        float _GridStep = reader.ReadF32();
        int _LevelCount = reader.ReadS32();
        float _LevelHeight = reader.ReadF32();
        float _OffsetY = reader.ReadF32();
        BitField _RaycastMask = BitField.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Bounds,
            _GridStep,
            _LevelCount,
            _LevelHeight,
            _OffsetY,
            _RaycastMask);
    }
}

