namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $StarSystemSpaceBarkConsoleView (18 fields) A629F901518B8B1A946BF947557F051A/708C7BF8A68E310B32988A471C2E917A */
public record class StarSystemSpaceBarkConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Text /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_LinkText /* None */,
    PPtr<OwlcatButton> m_OpenEncyclopediaButton /* None */,
    PPtr<Image> m_UnitPortrait /* None */,
    PPtr<RectTransform> m_MessageContainer /* None */,
    PPtr<CanvasGroup> m_CanvasGroup /* None */,
    Vector2f m_StartPos /* None */,
    Vector2f m_MidPos /* None */,
    Vector2f m_EndPos /* None */,
    float m_AppearTime /* None */,
    float m_HalfDisappearTime /* None */,
    float m_HoldTime /* None */,
    float m_DisappearTime /* None */,
    PPtr<ConsoleHint> m_ShowLastMessageHint /* None */)
{
    public static StarSystemSpaceBarkConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Text */
        PPtr<TextMeshProUGUI> _m_Text = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_LinkText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_OpenEncyclopediaButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<Image> _m_UnitPortrait = PPtr<Image>.Read(reader);
        PPtr<RectTransform> _m_MessageContainer = PPtr<RectTransform>.Read(reader);
        PPtr<CanvasGroup> _m_CanvasGroup = PPtr<CanvasGroup>.Read(reader);
        Vector2f _m_StartPos = Vector2f.Read(reader);
        Vector2f _m_MidPos = Vector2f.Read(reader);
        Vector2f _m_EndPos = Vector2f.Read(reader);
        float _m_AppearTime = reader.ReadF32();
        float _m_HalfDisappearTime = reader.ReadF32();
        float _m_HoldTime = reader.ReadF32();
        float _m_DisappearTime = reader.ReadF32();
        PPtr<ConsoleHint> _m_ShowLastMessageHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Text,
            _m_LinkText,
            _m_OpenEncyclopediaButton,
            _m_UnitPortrait,
            _m_MessageContainer,
            _m_CanvasGroup,
            _m_StartPos,
            _m_MidPos,
            _m_EndPos,
            _m_AppearTime,
            _m_HalfDisappearTime,
            _m_HoldTime,
            _m_DisappearTime,
            _m_ShowLastMessageHint);
    }
}

