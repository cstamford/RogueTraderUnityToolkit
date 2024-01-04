namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ToggleWorkaround (16 fields) 59627CFA6A86535587F6A125D24F91B1/09FBB1ABB98BE1C49731B9CE827FA7DD */
public record class ToggleWorkaround(
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
    int toggleTransition /* None */,
    PPtr<Graphic> graphic /* None */,
    PPtr<ToggleGroup> m_Group /* None */,
    ToggleEvent onValueChanged /* None */,
    byte m_IsOn /* NeedsAlign */)
{
    public static ToggleWorkaround Read(EndianBinaryReader reader)
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
        int _toggleTransition = reader.ReadS32();
        PPtr<Graphic> _graphic = PPtr<Graphic>.Read(reader);
        PPtr<ToggleGroup> _m_Group = PPtr<ToggleGroup>.Read(reader);
        ToggleEvent _onValueChanged = ToggleEvent.Read(reader);
        reader.AlignTo(4); /* m_IsOn */
        byte _m_IsOn = reader.ReadU8();
        
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
            _toggleTransition,
            _graphic,
            _m_Group,
            _onValueChanged,
            _m_IsOn);
    }
}

