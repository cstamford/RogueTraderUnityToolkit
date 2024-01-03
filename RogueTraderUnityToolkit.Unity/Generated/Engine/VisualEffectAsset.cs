namespace RogueTraderUnityToolkit.Unity.Generated.Engine;

using Core;

/* $VisualEffectAsset (3 fields) (IsEngineType) */
public record class VisualEffectAsset(
    AsciiString m_Name,
    VisualEffectInfo m_Infos,
    VFXSystemDesc[] m_Systems)
{
    public static VisualEffectAsset Read(EndianBinaryReader reader)
    {
        AsciiString m_Name = String.Read(reader);
        VisualEffectInfo m_Infos = VisualEffectInfo.Read(reader);
        VFXSystemDesc[] m_Systems = Array<VFXSystemDesc>.Read(reader);
        
        return new(m_Name,
            m_Infos,
            m_Systems);
    }
}

