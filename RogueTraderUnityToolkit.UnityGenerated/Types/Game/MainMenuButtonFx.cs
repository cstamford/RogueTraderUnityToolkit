namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $MainMenuButtonFx (13 fields) CEF2A9822F1E3F7BA4BEE13C280F199C/446F4C2EFFAA6AAFC80AE3E1A674171C */
public record class MainMenuButtonFx(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Label /* NeedsAlign */,
    PPtr<CanvasGroup> m_BlinkBackground /* None */,
    PPtr<Image> m_GlitchFX /* None */,
    PPtr<Material> m_FxMaterial /* None */,
    PPtr<OwlcatMultiButton> m_Button /* None */,
    PPtr<CanvasGroup> m_HoverCanvasGroup /* None */,
    float m_HoveredImageTime /* None */,
    float m_HoveredGlitchTime /* None */,
    float m_ShowDelay /* None */)
{
    public static MainMenuButtonFx Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Label */
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CanvasGroup> _m_BlinkBackground = PPtr<CanvasGroup>.Read(reader);
        PPtr<Image> _m_GlitchFX = PPtr<Image>.Read(reader);
        PPtr<Material> _m_FxMaterial = PPtr<Material>.Read(reader);
        PPtr<OwlcatMultiButton> _m_Button = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<CanvasGroup> _m_HoverCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        float _m_HoveredImageTime = reader.ReadF32();
        float _m_HoveredGlitchTime = reader.ReadF32();
        float _m_ShowDelay = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Label,
            _m_BlinkBackground,
            _m_GlitchFX,
            _m_FxMaterial,
            _m_Button,
            _m_HoverCanvasGroup,
            _m_HoveredImageTime,
            _m_HoveredGlitchTime,
            _m_ShowDelay);
    }
}

