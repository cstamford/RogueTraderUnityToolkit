namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CalculatedPrerequisiteStrings (16 fields) 4D8C27B8ACF0574527CE5E5B3636BE78/65A2D3827D78F7C76E036A9EFB239144 */
public record class CalculatedPrerequisiteStrings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    LocalizedString CompositeAndTrue /* NeedsAlign */,
    LocalizedString CompositeAndFalse /* NeedsAlign */,
    LocalizedString CompositeOrTrue /* NeedsAlign */,
    LocalizedString CompositeOrFalse /* NeedsAlign */,
    LocalizedString HasFact /* NeedsAlign */,
    LocalizedString HasNoFact /* NeedsAlign */,
    LocalizedString AtRankOrGreater /* NeedsAlign */,
    LocalizedString AtLeastAtRank /* NeedsAlign */,
    LocalizedString CurrentRankLessThan /* NeedsAlign */,
    LocalizedString HasStat /* NeedsAlign */,
    LocalizedString StatLessThan /* NeedsAlign */,
    LocalizedString StatGreaterOrEqual /* NeedsAlign */)
{
    public static CalculatedPrerequisiteStrings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* CompositeAndTrue */
        LocalizedString _CompositeAndTrue = LocalizedString.Read(reader);
        reader.AlignTo(4); /* CompositeAndFalse */
        LocalizedString _CompositeAndFalse = LocalizedString.Read(reader);
        reader.AlignTo(4); /* CompositeOrTrue */
        LocalizedString _CompositeOrTrue = LocalizedString.Read(reader);
        reader.AlignTo(4); /* CompositeOrFalse */
        LocalizedString _CompositeOrFalse = LocalizedString.Read(reader);
        reader.AlignTo(4); /* HasFact */
        LocalizedString _HasFact = LocalizedString.Read(reader);
        reader.AlignTo(4); /* HasNoFact */
        LocalizedString _HasNoFact = LocalizedString.Read(reader);
        reader.AlignTo(4); /* AtRankOrGreater */
        LocalizedString _AtRankOrGreater = LocalizedString.Read(reader);
        reader.AlignTo(4); /* AtLeastAtRank */
        LocalizedString _AtLeastAtRank = LocalizedString.Read(reader);
        reader.AlignTo(4); /* CurrentRankLessThan */
        LocalizedString _CurrentRankLessThan = LocalizedString.Read(reader);
        reader.AlignTo(4); /* HasStat */
        LocalizedString _HasStat = LocalizedString.Read(reader);
        reader.AlignTo(4); /* StatLessThan */
        LocalizedString _StatLessThan = LocalizedString.Read(reader);
        reader.AlignTo(4); /* StatGreaterOrEqual */
        LocalizedString _StatGreaterOrEqual = LocalizedString.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _CompositeAndTrue,
            _CompositeAndFalse,
            _CompositeOrTrue,
            _CompositeOrFalse,
            _HasFact,
            _HasNoFact,
            _AtRankOrGreater,
            _AtLeastAtRank,
            _CurrentRankLessThan,
            _HasStat,
            _StatLessThan,
            _StatGreaterOrEqual);
    }
}

