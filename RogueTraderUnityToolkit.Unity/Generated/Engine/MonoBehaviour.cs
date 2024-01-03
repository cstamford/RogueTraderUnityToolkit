namespace RogueTraderUnityToolkit.Unity.Generated.Engine;

using Core;

/* $MonoBehaviour (4 fields) (IsEngineType) */
public record class MonoBehaviour(
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    PPtr<MonoScript> m_Script,
    AsciiString m_Name)
{
    public static MonoBehaviour Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        byte m_Enabled = reader.ReadU8();
        PPtr<MonoScript> m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString m_Name = String.Read(reader);
        
        return new(m_GameObject,
            m_Enabled,
            m_Script,
            m_Name);
    }
}

