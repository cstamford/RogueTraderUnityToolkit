namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $KeyBindingSetupDialogPCView (12 fields) B7A493DB604A48D4CCB11552CD6F47FF/166D9E3F18E2AE3A82E15D4E3DCE454C */
public record class KeyBindingSetupDialogPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_PressedKeysText /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_BindingIsOccupied /* None */,
    ColorRGBA m_NormalColor /* None */,
    ColorRGBA m_TempColor /* None */,
    ColorRGBA m_OccupiedColor /* None */,
    PPtr<OwlcatButton> m_CloseButton /* None */,
    PPtr<OwlcatButton> m_UnbindButton /* None */,
    PPtr<FadeAnimator> m_Animator /* None */)
{
    public static KeyBindingSetupDialogPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_PressedKeysText */
        PPtr<TextMeshProUGUI> _m_PressedKeysText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_BindingIsOccupied = PPtr<TextMeshProUGUI>.Read(reader);
        ColorRGBA _m_NormalColor = ColorRGBA.Read(reader);
        ColorRGBA _m_TempColor = ColorRGBA.Read(reader);
        ColorRGBA _m_OccupiedColor = ColorRGBA.Read(reader);
        PPtr<OwlcatButton> _m_CloseButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_UnbindButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<FadeAnimator> _m_Animator = PPtr<FadeAnimator>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PressedKeysText,
            _m_BindingIsOccupied,
            _m_NormalColor,
            _m_TempColor,
            _m_OccupiedColor,
            _m_CloseButton,
            _m_UnbindButton,
            _m_Animator);
    }
}

