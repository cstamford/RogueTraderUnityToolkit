namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $Scrollbar (17 fields) E0FA21E093737C7B5F72183E213E6276/5C1ED83577D4535D0A281FC53E346E37 */
public record class Scrollbar(
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
    PPtr<RectTransform> m_HandleRect /* None */,
    int m_Direction /* None */,
    float m_Value /* None */,
    float m_Size /* None */,
    int m_NumberOfSteps /* None */,
    ScrollEvent m_OnValueChanged /* None */)
{
    public static Scrollbar Read(EndianBinaryReader reader)
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
        PPtr<RectTransform> _m_HandleRect = PPtr<RectTransform>.Read(reader);
        int _m_Direction = reader.ReadS32();
        float _m_Value = reader.ReadF32();
        float _m_Size = reader.ReadF32();
        int _m_NumberOfSteps = reader.ReadS32();
        ScrollEvent _m_OnValueChanged = ScrollEvent.Read(reader);
        
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
            _m_HandleRect,
            _m_Direction,
            _m_Value,
            _m_Size,
            _m_NumberOfSteps,
            _m_OnValueChanged);
    }
}

