namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $Avatar (5 fields) (IsEngineType) */
public record class Avatar(
    AsciiString m_Name,
    uint m_AvatarSize,
    AvatarConstant m_Avatar,
    Dictionary<uint, AsciiString> m_TOS,
    HumanDescription m_HumanDescription)
{
    public static Avatar Read(EndianBinaryReader reader)
    {
        AsciiString m_Name = String.Read(reader);
        uint m_AvatarSize = reader.ReadU32();
        AvatarConstant m_Avatar = AvatarConstant.Read(reader);
        Dictionary<uint, AsciiString> m_TOS = Map<uint, AsciiString>.Read(reader);
        HumanDescription m_HumanDescription = HumanDescription.Read(reader);
        
        return new(m_Name,
            m_AvatarSize,
            m_Avatar,
            m_TOS,
            m_HumanDescription);
    }
}

