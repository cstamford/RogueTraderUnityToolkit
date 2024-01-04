namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OvertipBarkBlockView (9 fields) D4EF80E5950BE42DE8A6BF17800FC575/EC7986CCAC365C65BA4E3F41773DAADA */
public record class OvertipBarkBlockView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Text /* NeedsAlign */,
    PPtr<RectTransform> m_BarkContainer /* None */,
    Vector2f m_ContainerPaddings /* None */,
    PPtr<FadeAnimator> FadeAnimator /* None */,
    float m_BaseFontSize /* None */)
{
    public static OvertipBarkBlockView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Text */
        PPtr<TextMeshProUGUI> _m_Text = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<RectTransform> _m_BarkContainer = PPtr<RectTransform>.Read(reader);
        Vector2f _m_ContainerPaddings = Vector2f.Read(reader);
        PPtr<FadeAnimator> _FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        float _m_BaseFontSize = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Text,
            _m_BarkContainer,
            _m_ContainerPaddings,
            _FadeAnimator,
            _m_BaseFontSize);
    }
}

