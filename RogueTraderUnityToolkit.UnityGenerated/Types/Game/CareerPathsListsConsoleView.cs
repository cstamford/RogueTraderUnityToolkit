namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CareerPathsListsConsoleView (8 fields) A366443C06C28F9C5DF1BC68EC665679/5CC45F9756944AA2EB303EF0DB12AF25 */
public record class CareerPathsListsConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<RankExpCounterCommonView> m_RankExpCounterCommonView /* None */,
    PPtr<UnitBackgroundBlockCommonView> m_UnitBackgroundBlockCommonView /* None */,
    PPtr<CareerPathsListCommonView>[] m_CareerPathsLists /* None */)
{
    public static CareerPathsListsConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<RankExpCounterCommonView> _m_RankExpCounterCommonView = PPtr<RankExpCounterCommonView>.Read(reader);
        PPtr<UnitBackgroundBlockCommonView> _m_UnitBackgroundBlockCommonView = PPtr<UnitBackgroundBlockCommonView>.Read(reader);
        PPtr<CareerPathsListCommonView>[] _m_CareerPathsLists = BuiltInArray<PPtr<CareerPathsListCommonView>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_RankExpCounterCommonView,
            _m_UnitBackgroundBlockCommonView,
            _m_CareerPathsLists);
    }
}

