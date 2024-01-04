namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $EncyclopediaPageBlockAstropathBriefPCView (13 fields) 22FDC77D693FBEA9FC0498930B4827C3/651402FC2C5F899B23FD31F59AE9CC43 */
public record class EncyclopediaPageBlockAstropathBriefPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_MessageLocationLabel /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_MessageDateLabel /* None */,
    PPtr<TextMeshProUGUI> m_MessageSenderLabel /* None */,
    PPtr<TextMeshProUGUI> m_MessageBodyLabel /* None */,
    PPtr<TextMeshProUGUI> m_IsMessageReadLabel /* None */,
    PPtr<GameObject> m_IsMessageReadContainer /* None */,
    ColorRGBA m_FieldNameColor /* None */,
    float m_DefaultFontSize /* None */,
    float m_DefaultConsoleFontSize /* None */)
{
    public static EncyclopediaPageBlockAstropathBriefPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MessageLocationLabel */
        PPtr<TextMeshProUGUI> _m_MessageLocationLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_MessageDateLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_MessageSenderLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_MessageBodyLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_IsMessageReadLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_IsMessageReadContainer = PPtr<GameObject>.Read(reader);
        ColorRGBA _m_FieldNameColor = ColorRGBA.Read(reader);
        float _m_DefaultFontSize = reader.ReadF32();
        float _m_DefaultConsoleFontSize = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MessageLocationLabel,
            _m_MessageDateLabel,
            _m_MessageSenderLabel,
            _m_MessageBodyLabel,
            _m_IsMessageReadLabel,
            _m_IsMessageReadContainer,
            _m_FieldNameColor,
            _m_DefaultFontSize,
            _m_DefaultConsoleFontSize);
    }
}

