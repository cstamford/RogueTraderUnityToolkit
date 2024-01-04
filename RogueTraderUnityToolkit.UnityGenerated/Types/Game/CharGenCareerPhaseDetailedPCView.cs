namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenCareerPhaseDetailedPCView (7 fields) 82ED7AACDD268B086CAA9F573CFB2021/8CA85E737C41B6E30838AB341D2C067E */
public record class CharGenCareerPhaseDetailedPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_PageAnimator /* NeedsAlign */,
    PPtr<UnitProgressionCommonView> m_UnitProgressionView /* None */,
    PPtr<InfoSectionView> m_InfoView /* None */)
{
    public static CharGenCareerPhaseDetailedPCView Read(EndianBinaryReader reader)
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
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PageAnimator,
            _m_UnitProgressionView,
            _m_InfoView);
    }
}

