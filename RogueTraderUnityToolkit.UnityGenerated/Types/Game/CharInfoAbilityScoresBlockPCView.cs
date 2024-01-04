namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoAbilityScoresBlockPCView (7 fields) 9C90FBBD5E0B202D9E2FD7B637D45A14/02A0F7194F09F5ABBCE7438032FF9237 */
public record class CharInfoAbilityScoresBlockPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<CharInfoAbilityScorePCView>[] m_StatEntries /* None */,
    PPtr<Transform> m_StatsContainer /* None */)
{
    public static CharInfoAbilityScoresBlockPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<CharInfoAbilityScorePCView>[] _m_StatEntries = BuiltInArray<PPtr<CharInfoAbilityScorePCView>>.Read(reader);
        PPtr<Transform> _m_StatsContainer = PPtr<Transform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_StatEntries,
            _m_StatsContainer);
    }
}

