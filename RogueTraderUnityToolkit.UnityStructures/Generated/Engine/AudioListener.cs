namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $AudioListener (2 fields) (IsEngineType) */
public record class AudioListener(
    PPtr<GameObject> m_GameObject,
    byte m_Enabled)
{
    public static AudioListener Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        byte m_Enabled = reader.ReadU8();
        
        return new(m_GameObject,
            m_Enabled);
    }
}

