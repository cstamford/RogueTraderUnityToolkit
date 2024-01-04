namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UnitBarkPartView (10 fields) E29A397985BEC9D0C13B0B0658EAA979/B6ED0C1351E0C6E3CE1406EE375C7F65 */
public record class UnitBarkPartView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Text /* NeedsAlign */,
    PPtr<RectTransform> m_BarkContainer /* None */,
    Vector2f m_ContainerPaddings /* None */,
    PPtr<FadeAnimator> FadeAnimator /* None */,
    float m_BaseFontSize /* None */,
    PPtr<GameObject> m_BarkActiveIcon /* None */)
{
    public static UnitBarkPartView Read(EndianBinaryReader reader)
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
        PPtr<GameObject> _m_BarkActiveIcon = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Text,
            _m_BarkContainer,
            _m_ContainerPaddings,
            _FadeAnimator,
            _m_BaseFontSize,
            _m_BarkActiveIcon);
    }
}

