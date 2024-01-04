namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoNameAndPortraitPCView (11 fields) 5538D152639CC01E2C43F8F5D898CD53/705897A34357705FD584D819BEBA7936 */
public record class CharInfoNameAndPortraitPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<ScrambledTMP> m_NameFieldScrambled /* None */,
    PPtr<CharBPortraitChanger> m_Portrait /* None */,
    PPtr<CharInfoHitPointsPCView> m_HitPointsView /* None */,
    PPtr<OwlcatButton> m_NextButton /* None */,
    PPtr<OwlcatButton> m_PrevButton /* None */,
    int m_Size /* None */)
{
    public static CharInfoNameAndPortraitPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<ScrambledTMP> _m_NameFieldScrambled = PPtr<ScrambledTMP>.Read(reader);
        PPtr<CharBPortraitChanger> _m_Portrait = PPtr<CharBPortraitChanger>.Read(reader);
        PPtr<CharInfoHitPointsPCView> _m_HitPointsView = PPtr<CharInfoHitPointsPCView>.Read(reader);
        PPtr<OwlcatButton> _m_NextButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_PrevButton = PPtr<OwlcatButton>.Read(reader);
        int _m_Size = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_NameFieldScrambled,
            _m_Portrait,
            _m_HitPointsView,
            _m_NextButton,
            _m_PrevButton,
            _m_Size);
    }
}

