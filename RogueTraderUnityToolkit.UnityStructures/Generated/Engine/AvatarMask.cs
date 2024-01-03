namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $AvatarMask (3 fields) (IsEngineType) */
public record class AvatarMask(
    AsciiString m_Name,
    uint[] m_Mask,
    TransformMaskElement[] m_Elements)
{
    public static AvatarMask Read(EndianBinaryReader reader)
    {
        AsciiString m_Name = String.Read(reader);
        uint[] m_Mask = Array<uint>.Read(reader);
        TransformMaskElement[] m_Elements = Array<TransformMaskElement>.Read(reader);
        
        return new(m_Name,
            m_Mask,
            m_Elements);
    }
}

