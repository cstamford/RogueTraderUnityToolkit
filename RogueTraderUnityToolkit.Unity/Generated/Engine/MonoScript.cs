namespace RogueTraderUnityToolkit.Unity.Generated.Engine;

using Core;

/* $MonoScript (6 fields) (IsEngineType) */
public record class MonoScript(
    AsciiString m_Name,
    int m_ExecutionOrder,
    Hash128 m_PropertiesHash,
    AsciiString m_ClassName,
    AsciiString m_Namespace,
    AsciiString m_AssemblyName)
{
    public static MonoScript Read(EndianBinaryReader reader)
    {
        AsciiString m_Name = String.Read(reader);
        int m_ExecutionOrder = reader.ReadS32();
        Hash128 m_PropertiesHash = Hash128.Read(reader);
        AsciiString m_ClassName = String.Read(reader);
        AsciiString m_Namespace = String.Read(reader);
        AsciiString m_AssemblyName = String.Read(reader);
        
        return new(m_Name,
            m_ExecutionOrder,
            m_PropertiesHash,
            m_ClassName,
            m_Namespace,
            m_AssemblyName);
    }
}

