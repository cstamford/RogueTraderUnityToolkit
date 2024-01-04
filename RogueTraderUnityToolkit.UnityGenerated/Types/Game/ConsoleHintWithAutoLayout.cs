namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ConsoleHintWithAutoLayout (16 fields) 4757D4580E8C314A9149F7915ADE88D1/C0109E139279C799B48809AB45322AC8 */
public record class ConsoleHintWithAutoLayout(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasGroup> m_CanvasGroup /* NeedsAlign */,
    PPtr<Image> m_Icon /* None */,
    PPtr<Image> m_ProgressBar /* None */,
    PPtr<Image> m_ProgressHint /* None */,
    PPtr<TextMeshProUGUI> m_Label /* None */,
    int m_Animation /* None */,
    float m_ScaleFactor /* None */,
    float m_AnimTime /* None */,
    int m_LabelPlacement /* None */,
    PPtr<RectTransform> m_BackgroundLeft /* None */,
    PPtr<RectTransform> m_BackgroundRight /* None */,
    byte m_ShowBackground /* None */)
{
    public static ConsoleHintWithAutoLayout Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CanvasGroup */
        PPtr<CanvasGroup> _m_CanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<Image> _m_ProgressBar = PPtr<Image>.Read(reader);
        PPtr<Image> _m_ProgressHint = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        int _m_Animation = reader.ReadS32();
        float _m_ScaleFactor = reader.ReadF32();
        float _m_AnimTime = reader.ReadF32();
        int _m_LabelPlacement = reader.ReadS32();
        PPtr<RectTransform> _m_BackgroundLeft = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_BackgroundRight = PPtr<RectTransform>.Read(reader);
        byte _m_ShowBackground = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CanvasGroup,
            _m_Icon,
            _m_ProgressBar,
            _m_ProgressHint,
            _m_Label,
            _m_Animation,
            _m_ScaleFactor,
            _m_AnimTime,
            _m_LabelPlacement,
            _m_BackgroundLeft,
            _m_BackgroundRight,
            _m_ShowBackground);
    }
}

