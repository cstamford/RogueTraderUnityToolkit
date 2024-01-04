namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoSoulMarkSectorView (14 fields) 6CCF2A88A6D5EE5DBF8B968EC2D3E1E5/3C6C0AD89DE61DB10944157CDC551551 */
public record class CharInfoSoulMarkSectorView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<OwlcatMultiButton> m_SectorInfo /* None */,
    PPtr<FadeAnimator> m_SectorGroup /* None */,
    PPtr<FadeAnimator> m_SlotsGroup /* None */,
    PPtr<TextMeshProUGUI> m_Title /* None */,
    PPtr<TextMeshProUGUI> m_Value /* None */,
    PPtr<TextMeshProUGUI> m_Level /* None */,
    PPtr<Image> m_LevelProgressImage /* None */,
    PPtr<CharInfoAlignmentAbilitySlotPCView>[] m_AbilitySlots /* None */,
    float[] m_GlobalProgressThreshold /* None */)
{
    public static CharInfoSoulMarkSectorView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<OwlcatMultiButton> _m_SectorInfo = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<FadeAnimator> _m_SectorGroup = PPtr<FadeAnimator>.Read(reader);
        PPtr<FadeAnimator> _m_SlotsGroup = PPtr<FadeAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Value = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Level = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_LevelProgressImage = PPtr<Image>.Read(reader);
        PPtr<CharInfoAlignmentAbilitySlotPCView>[] _m_AbilitySlots = BuiltInArray<PPtr<CharInfoAlignmentAbilitySlotPCView>>.Read(reader);
        float[] _m_GlobalProgressThreshold = BuiltInArray<float>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_SectorInfo,
            _m_SectorGroup,
            _m_SlotsGroup,
            _m_Title,
            _m_Value,
            _m_Level,
            _m_LevelProgressImage,
            _m_AbilitySlots,
            _m_GlobalProgressThreshold);
    }
}

