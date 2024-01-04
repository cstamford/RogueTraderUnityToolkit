namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenNameConsoleView (7 fields) CE8B27BD34D6B9E38B59A145349725A8/582D23D37476AF6B88BC11D066E678F0 */
public record class CharGenNameConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<ScrambledTMP> m_NameFieldScrambled /* None */,
    PPtr<MessageBoxBaseView> m_MessageBoxView /* None */)
{
    public static CharGenNameConsoleView Read(EndianBinaryReader reader)
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
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_NameFieldScrambled,
            _m_MessageBoxView);
    }
}

