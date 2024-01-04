namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenCareerPhaseDetailedConsoleView (8 fields) 0F69D528329E9B999EBE43175F1CDFD6/994AE4D16DD0776ECD2B07156D901736 */
public record class CharGenCareerPhaseDetailedConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_PageAnimator /* NeedsAlign */,
    PPtr<UnitProgressionCommonView> m_UnitProgressionView /* None */,
    PPtr<InfoSectionView> m_InfoView /* None */,
    PPtr<ConsoleHint> m_SelectHint /* None */)
{
    public static CharGenCareerPhaseDetailedConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_PageAnimator */
        PPtr<FadeAnimator> _m_PageAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<UnitProgressionCommonView> _m_UnitProgressionView = PPtr<UnitProgressionCommonView>.Read(reader);
        PPtr<InfoSectionView> _m_InfoView = PPtr<InfoSectionView>.Read(reader);
        PPtr<ConsoleHint> _m_SelectHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PageAnimator,
            _m_UnitProgressionView,
            _m_InfoView,
            _m_SelectHint);
    }
}

