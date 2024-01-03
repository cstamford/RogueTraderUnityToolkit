namespace RogueTraderUnityToolkit.Unity.Generated.Engine;

using Core;

/* $PreloadData (4 fields) (IsEngineType) */
public record class PreloadData(
    AsciiString m_Name,
    PPtr<Object>[] m_Assets,
    AsciiString[] m_Dependencies,
    bool m_ExplicitDataLayout)
{
    public static PreloadData Read(EndianBinaryReader reader)
    {
        AsciiString m_Name = String.Read(reader);
        PPtr<Object>[] m_Assets = Array<PPtr<Object>>.Read(reader);
        AsciiString[] m_Dependencies = Array<AsciiString>.Read(reader);
        bool m_ExplicitDataLayout = reader.ReadBool();
        
        return new(m_Name,
            m_Assets,
            m_Dependencies,
            m_ExplicitDataLayout);
    }
}

