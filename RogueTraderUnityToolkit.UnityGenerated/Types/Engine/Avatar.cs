namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $Avatar (5 fields) 7C11FC061465D9A6CA18CC0CA1C10C84 */
public record class Avatar(
    AsciiString m_Name /* None */,
    uint m_AvatarSize /* NeedsAlign */,
    AvatarConstant m_Avatar /* None */,
    Dictionary<uint, AsciiString> m_TOS /* NeedsAlign */,
    HumanDescription m_HumanDescription /* NeedsAlign */) : IUnityObject
{
    public static Hash128 Hash => new(2081553414, 342219174, 3390622732, 2713783428);
    public static Avatar Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_AvatarSize */
        uint _m_AvatarSize = reader.ReadU32();
        AvatarConstant _m_Avatar = AvatarConstant.Read(reader);
        reader.AlignTo(4); /* m_TOS */
        Dictionary<uint, AsciiString> _m_TOS = BuiltInMap<uint, AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_HumanDescription */
        HumanDescription _m_HumanDescription = HumanDescription.Read(reader);
        
        return new(_m_Name,
            _m_AvatarSize,
            _m_Avatar,
            _m_TOS,
            _m_HumanDescription);
    }
}

