namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ConsoleHint (12 fields) DC353110D157EAC2627E21A729DCAB56/6E37497CA8E1A087C45D8B31E95C923D */
public record class ConsoleHint(
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
    float m_AnimTime /* None */)
{
    public static ConsoleHint Read(EndianBinaryReader reader)
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
            _m_AnimTime);
    }
}

