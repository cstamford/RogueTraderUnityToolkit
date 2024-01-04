namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TMP_Dropdown (21 fields) 3C5C8C84C27F5598069219F29AA6EAA7/18E347A01650F1B524C7F26CCDF5DBA3 */
public record class TMP_Dropdown(
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
    PPtr<RectTransform> m_Template /* None */,
    PPtr<TMP_Text> m_CaptionText /* None */,
    PPtr<Image> m_CaptionImage /* None */,
    PPtr<Graphic> m_Placeholder /* None */,
    PPtr<TMP_Text> m_ItemText /* None */,
    PPtr<Image> m_ItemImage /* None */,
    int m_Value /* None */,
    OptionDataList m_Options /* None */,
    DropdownEvent m_OnValueChanged /* NeedsAlign */,
    float m_AlphaFadeSpeed /* NeedsAlign */)
{
    public static TMP_Dropdown Read(EndianBinaryReader reader)
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
        PPtr<RectTransform> _m_Template = PPtr<RectTransform>.Read(reader);
        PPtr<TMP_Text> _m_CaptionText = PPtr<TMP_Text>.Read(reader);
        PPtr<Image> _m_CaptionImage = PPtr<Image>.Read(reader);
        PPtr<Graphic> _m_Placeholder = PPtr<Graphic>.Read(reader);
        PPtr<TMP_Text> _m_ItemText = PPtr<TMP_Text>.Read(reader);
        PPtr<Image> _m_ItemImage = PPtr<Image>.Read(reader);
        int _m_Value = reader.ReadS32();
        OptionDataList _m_Options = OptionDataList.Read(reader);
        reader.AlignTo(4); /* m_OnValueChanged */
        DropdownEvent _m_OnValueChanged = DropdownEvent.Read(reader);
        reader.AlignTo(4); /* m_AlphaFadeSpeed */
        float _m_AlphaFadeSpeed = reader.ReadF32();
        
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
            _m_Template,
            _m_CaptionText,
            _m_CaptionImage,
            _m_Placeholder,
            _m_ItemText,
            _m_ItemImage,
            _m_Value,
            _m_Options,
            _m_OnValueChanged,
            _m_AlphaFadeSpeed);
    }
}

