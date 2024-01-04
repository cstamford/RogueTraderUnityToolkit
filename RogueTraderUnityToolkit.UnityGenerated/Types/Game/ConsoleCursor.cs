namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ConsoleCursor (18 fields) A478C45D5769A9E05D36F853BDAB0248/48F8DFADE6B925AC61DB9AE38877C0E7 */
public record class ConsoleCursor(
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
    PPtr<GameObject> m_NoMoveObject /* None */,
    float m_MoveSpeed /* None */,
    float m_RotationAngle /* None */,
    PPtr<GameObject> m_LineContainer /* None */,
    BoolReactiveProperty IsActiveProperty /* None */,
    BoolReactiveProperty IsNotActiveProperty /* NeedsAlign */,
    PPtr<PlayerMouse> m_Mouse /* NeedsAlign */)
{
    public static ConsoleCursor Read(EndianBinaryReader reader)
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
        float _m_MoveSpeed = reader.ReadF32();
        float _m_RotationAngle = reader.ReadF32();
        PPtr<GameObject> _m_LineContainer = PPtr<GameObject>.Read(reader);
        BoolReactiveProperty _IsActiveProperty = BoolReactiveProperty.Read(reader);
        reader.AlignTo(4); /* IsNotActiveProperty */
        BoolReactiveProperty _IsNotActiveProperty = BoolReactiveProperty.Read(reader);
        reader.AlignTo(4); /* m_Mouse */
        PPtr<PlayerMouse> _m_Mouse = PPtr<PlayerMouse>.Read(reader);
        
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
            _m_NoMoveObject,
            _m_MoveSpeed,
            _m_RotationAngle,
            _m_LineContainer,
            _IsActiveProperty,
            _IsNotActiveProperty,
            _m_Mouse);
    }
}

