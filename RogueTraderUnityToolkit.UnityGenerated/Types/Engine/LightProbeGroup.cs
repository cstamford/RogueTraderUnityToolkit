namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $LightProbeGroup (2 fields) 45DCEC263C239AB6B5F0A75EC811CDD8 */
public record class LightProbeGroup(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */) : IUnityObject
{
    public static Hash128 Hash => new(1172106278, 1008966326, 3052447582, 3356610008);
    public static LightProbeGroup Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled);
    }
}

