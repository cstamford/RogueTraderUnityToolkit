namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Avatar (5 fields) 7C11FC061465D9A6CA18CC0CA1C10C84 */
public record class Avatar(
    AsciiString m_Name,
    uint m_AvatarSize,
    AvatarConstant m_Avatar,
    Dictionary<uint, AsciiString> m_TOS,
    HumanDescription m_HumanDescription) : IUnityEngineStructure
{
    public static Hash128 Hash => new(2081553414, 342219174, 3390622732, 2713783428);

    public static Avatar Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        uint _m_AvatarSize = reader.ReadU32();
        AvatarConstant _m_Avatar = AvatarConstant.Read(reader);
        reader.AlignTo(4); /* m_Avatar */
        Dictionary<uint, AsciiString> _m_TOS = BuiltInMap<uint, AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_TOS */
        HumanDescription _m_HumanDescription = HumanDescription.Read(reader);
        reader.AlignTo(4); /* m_HumanDescription */
        
        return new(_m_Name,
            _m_AvatarSize,
            _m_Avatar,
            _m_TOS,
            _m_HumanDescription);
    }

    public override string ToString() => $"Avatar\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AvatarSize: ");
        sb.AppendLine(m_AvatarSize.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Avatar: ");
        sb.AppendLine();
        sb.Append(m_Avatar.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TOS: ");
        sb.AppendLine(m_TOS.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HumanDescription: ");
        sb.AppendLine();
        sb.Append(m_HumanDescription.ToString(indent+4));

        return sb.ToString();
    }
}

