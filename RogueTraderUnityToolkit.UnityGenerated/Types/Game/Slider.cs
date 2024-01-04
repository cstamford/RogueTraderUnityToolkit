namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $Slider (19 fields) 93502B8953227596D280A95B8420E48C/96E4F3CA9832DB5EC1D4FE3B998A6219 */
public record class Slider(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    Navigation m_Navigation /* NeedsAlign */,
    int m_Transition /* NeedsAlign */,
    ColorBlock m_Colors /* None */,
    SpriteState m_SpriteState /* None */,
    AnimationTriggers m_AnimationTriggers /* None */,
    byte m_Interactable /* NeedsAlign */,
    PPtr<Graphic> m_TargetGraphic /* NeedsAlign */,
    PPtr<RectTransform> m_FillRect /* None */,
    PPtr<RectTransform> m_HandleRect /* None */,
    int m_Direction /* None */,
    float m_MinValue /* None */,
    float m_MaxValue /* None */,
    byte m_WholeNumbers /* None */,
    float m_Value /* NeedsAlign */,
    SliderEvent m_OnValueChanged /* None */)
{
    public static Slider Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Navigation */
        Navigation _m_Navigation = Navigation.Read(reader);
        reader.AlignTo(4); /* m_Transition */
        int _m_Transition = reader.ReadS32();
        ColorBlock _m_Colors = ColorBlock.Read(reader);
        SpriteState _m_SpriteState = SpriteState.Read(reader);
        AnimationTriggers _m_AnimationTriggers = AnimationTriggers.Read(reader);
        reader.AlignTo(4); /* m_Interactable */
        byte _m_Interactable = reader.ReadU8();
        reader.AlignTo(4); /* m_TargetGraphic */
        PPtr<Graphic> _m_TargetGraphic = PPtr<Graphic>.Read(reader);
        PPtr<RectTransform> _m_FillRect = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_HandleRect = PPtr<RectTransform>.Read(reader);
        int _m_Direction = reader.ReadS32();
        float _m_MinValue = reader.ReadF32();
        float _m_MaxValue = reader.ReadF32();
        byte _m_WholeNumbers = reader.ReadU8();
        reader.AlignTo(4); /* m_Value */
        float _m_Value = reader.ReadF32();
        SliderEvent _m_OnValueChanged = SliderEvent.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Navigation,
            _m_Transition,
            _m_Colors,
            _m_SpriteState,
            _m_AnimationTriggers,
            _m_Interactable,
            _m_TargetGraphic,
            _m_FillRect,
            _m_HandleRect,
            _m_Direction,
            _m_MinValue,
            _m_MaxValue,
            _m_WholeNumbers,
            _m_Value,
            _m_OnValueChanged);
    }
}

