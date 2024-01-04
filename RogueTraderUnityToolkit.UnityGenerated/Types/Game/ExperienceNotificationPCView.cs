namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ExperienceNotificationPCView (13 fields) 7321A52CD6ECC59D7267A840030792B7/291F07C0F11AEF9565F376EAFFA9B2E6 */
public record class ExperienceNotificationPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_Container /* NeedsAlign */,
    PPtr<CanvasGroup> m_CanvasGroup /* None */,
    Vector2f m_StartPos /* None */,
    Vector2f m_MidPos /* None */,
    Vector2f m_EndPos /* None */,
    float m_AppearTime /* None */,
    float m_HoldTime /* None */,
    float m_DisappearTime /* None */,
    PPtr<TextMeshProUGUI> m_Text /* None */)
{
    public static ExperienceNotificationPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Container */
        PPtr<RectTransform> _m_Container = PPtr<RectTransform>.Read(reader);
        PPtr<CanvasGroup> _m_CanvasGroup = PPtr<CanvasGroup>.Read(reader);
        Vector2f _m_StartPos = Vector2f.Read(reader);
        Vector2f _m_MidPos = Vector2f.Read(reader);
        Vector2f _m_EndPos = Vector2f.Read(reader);
        float _m_AppearTime = reader.ReadF32();
        float _m_HoldTime = reader.ReadF32();
        float _m_DisappearTime = reader.ReadF32();
        PPtr<TextMeshProUGUI> _m_Text = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Container,
            _m_CanvasGroup,
            _m_StartPos,
            _m_MidPos,
            _m_EndPos,
            _m_AppearTime,
            _m_HoldTime,
            _m_DisappearTime,
            _m_Text);
    }
}

