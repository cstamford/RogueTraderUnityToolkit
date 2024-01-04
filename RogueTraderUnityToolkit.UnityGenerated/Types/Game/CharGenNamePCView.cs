namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenNamePCView (10 fields) 218493AC105CC760E30AD7E93A92DF75/1B5C1535D1A6E31BC590209C4C67A012 */
public record class CharGenNamePCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<ScrambledTMP> m_NameFieldScrambled /* None */,
    PPtr<MessageBoxBaseView> m_MessageBoxView /* None */,
    PPtr<OwlcatButton> m_SetNameButton /* None */,
    PPtr<TextMeshProUGUI> m_SetNameLabel /* None */,
    PPtr<OwlcatButton> m_SetRandomNameButton /* None */)
{
    public static CharGenNamePCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<ScrambledTMP> _m_NameFieldScrambled = PPtr<ScrambledTMP>.Read(reader);
        PPtr<MessageBoxBaseView> _m_MessageBoxView = PPtr<MessageBoxBaseView>.Read(reader);
        PPtr<OwlcatButton> _m_SetNameButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SetNameLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_SetRandomNameButton = PPtr<OwlcatButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_NameFieldScrambled,
            _m_MessageBoxView,
            _m_SetNameButton,
            _m_SetNameLabel,
            _m_SetRandomNameButton);
    }
}

