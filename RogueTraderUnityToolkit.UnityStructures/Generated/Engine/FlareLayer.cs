namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $FlareLayer (2 fields) (IsEngineType) */
public record class FlareLayer(
    PPtr<GameObject> m_GameObject,
    byte m_Enabled)
{
    public static FlareLayer Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        byte m_Enabled = reader.ReadU8();
        
        return new(m_GameObject,
            m_Enabled);
    }
}

