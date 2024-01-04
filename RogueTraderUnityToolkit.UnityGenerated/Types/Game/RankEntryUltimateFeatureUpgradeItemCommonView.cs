namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $RankEntryUltimateFeatureUpgradeItemCommonView (8 fields) 6A79334B34057A84332253581A9111DB/06D2370010D270A9102924F5D06468D9 */
public record class RankEntryUltimateFeatureUpgradeItemCommonView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Description /* NeedsAlign */,
    PPtr<OwlcatMultiButton> m_MainButton /* None */,
    PPtr<GameObject> m_FocusedMark /* None */,
    VirtualListLayoutElementSettings m_LayoutSettings /* None */)
{
    public static RankEntryUltimateFeatureUpgradeItemCommonView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Description */
        PPtr<TextMeshProUGUI> _m_Description = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_MainButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<GameObject> _m_FocusedMark = PPtr<GameObject>.Read(reader);
        VirtualListLayoutElementSettings _m_LayoutSettings = VirtualListLayoutElementSettings.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Description,
            _m_MainButton,
            _m_FocusedMark,
            _m_LayoutSettings);
    }
}

