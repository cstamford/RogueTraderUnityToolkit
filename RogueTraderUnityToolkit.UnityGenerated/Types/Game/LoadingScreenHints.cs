namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LoadingScreenHints (16 fields) 03218BDDBE5BB7E1DB4225429A43A469/1DA991167B721614E3DBDD4247656AB1 */
public record class LoadingScreenHints(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte BetaTesting /* NeedsAlign */,
    CategoryPlatformHints Hints /* NeedsAlign */,
    CategoryPlatformHints HintsLocation /* NeedsAlign */,
    CategoryPlatformHints HintsBridge /* NeedsAlign */,
    CategoryPlatformHints HintsStarSystem /* NeedsAlign */,
    CategoryPlatformHints HintsGlobalMap /* NeedsAlign */,
    CategoryPlatformHints HintsSpaceCombat /* NeedsAlign */,
    LocalizedString ReviewHint /* NeedsAlign */,
    LocalizedString VsHint /* NeedsAlign */,
    int DifficultyHintStart /* NeedsAlign */,
    int DifficultyHintInterval /* None */,
    LocalizedString DifficultyChangeHint /* None */)
{
    public static LoadingScreenHints Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* BetaTesting */
        byte _BetaTesting = reader.ReadU8();
        reader.AlignTo(4); /* Hints */
        CategoryPlatformHints _Hints = CategoryPlatformHints.Read(reader);
        reader.AlignTo(4); /* HintsLocation */
        CategoryPlatformHints _HintsLocation = CategoryPlatformHints.Read(reader);
        reader.AlignTo(4); /* HintsBridge */
        CategoryPlatformHints _HintsBridge = CategoryPlatformHints.Read(reader);
        reader.AlignTo(4); /* HintsStarSystem */
        CategoryPlatformHints _HintsStarSystem = CategoryPlatformHints.Read(reader);
        reader.AlignTo(4); /* HintsGlobalMap */
        CategoryPlatformHints _HintsGlobalMap = CategoryPlatformHints.Read(reader);
        reader.AlignTo(4); /* HintsSpaceCombat */
        CategoryPlatformHints _HintsSpaceCombat = CategoryPlatformHints.Read(reader);
        reader.AlignTo(4); /* ReviewHint */
        LocalizedString _ReviewHint = LocalizedString.Read(reader);
        reader.AlignTo(4); /* VsHint */
        LocalizedString _VsHint = LocalizedString.Read(reader);
        reader.AlignTo(4); /* DifficultyHintStart */
        int _DifficultyHintStart = reader.ReadS32();
        int _DifficultyHintInterval = reader.ReadS32();
        LocalizedString _DifficultyChangeHint = LocalizedString.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _BetaTesting,
            _Hints,
            _HintsLocation,
            _HintsBridge,
            _HintsStarSystem,
            _HintsGlobalMap,
            _HintsSpaceCombat,
            _ReviewHint,
            _VsHint,
            _DifficultyHintStart,
            _DifficultyHintInterval,
            _DifficultyChangeHint);
    }
}

