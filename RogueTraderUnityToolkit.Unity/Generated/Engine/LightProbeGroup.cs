namespace RogueTraderUnityToolkit.Unity.Generated.Engine;

using Core;

/* $LightProbeGroup (2 fields) (IsEngineType) */
public record class LightProbeGroup(
    PPtr<GameObject> m_GameObject,
    byte m_Enabled)
{
    public static LightProbeGroup Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        byte m_Enabled = reader.ReadU8();
        
        return new(m_GameObject,
            m_Enabled);
    }
}

