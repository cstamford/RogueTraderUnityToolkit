namespace RogueTraderUnityToolkit.Unity.Generated.Engine;

using Core;

/* $TextAsset (2 fields) (IsEngineType) */
public record class TextAsset(
    AsciiString m_Name,
    AsciiString m_Script)
{
    public static TextAsset Read(EndianBinaryReader reader)
    {
        AsciiString m_Name = String.Read(reader);
        AsciiString m_Script = String.Read(reader);
        
        return new(m_Name,
            m_Script);
    }
}

