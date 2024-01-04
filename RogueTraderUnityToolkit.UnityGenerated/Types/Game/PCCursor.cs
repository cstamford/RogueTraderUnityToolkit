namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PCCursor (12 fields) FF2FD09C4BB7CC8CA1A39039A78F8C5B/F613EC99124D93F116219B6FD564F9EC */
public record class PCCursor(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_CursorTransform /* NeedsAlign */,
    PPtr<Image> m_CursorImage /* None */,
    PPtr<GameObject> m_AbilityGroup /* None */,
    PPtr<Image> m_AbilityImage /* None */,
    PPtr<GameObject> m_TextsGroup /* None */,
    PPtr<TextMeshProUGUI> m_UpperText /* None */,
    PPtr<TextMeshProUGUI> m_LowerText /* None */,
    PPtr<GameObject> m_NoMoveObject /* None */)
{
    public static PCCursor Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CursorTransform */
        PPtr<RectTransform> _m_CursorTransform = PPtr<RectTransform>.Read(reader);
        PPtr<Image> _m_CursorImage = PPtr<Image>.Read(reader);
        PPtr<GameObject> _m_AbilityGroup = PPtr<GameObject>.Read(reader);
        PPtr<Image> _m_AbilityImage = PPtr<Image>.Read(reader);
        PPtr<GameObject> _m_TextsGroup = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_UpperText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_LowerText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_NoMoveObject = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CursorTransform,
            _m_CursorImage,
            _m_AbilityGroup,
            _m_AbilityImage,
            _m_TextsGroup,
            _m_UpperText,
            _m_LowerText,
            _m_NoMoveObject);
    }
}

