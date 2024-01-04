namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipTabsNavigationPCView (10 fields) E1598A1D75226F3C5D43D12846CA38E2/756C658619A5B8555424C6FBEB55DC81 */
public record class ShipTabsNavigationPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_UpgradeButton /* NeedsAlign */,
    PPtr<OwlcatMultiButton> m_SkillsButton /* None */,
    PPtr<OwlcatMultiButton> m_PostsButton /* None */,
    PPtr<TextMeshProUGUI> m_UpgradeLabel /* None */,
    PPtr<TextMeshProUGUI> m_SkillsLabel /* None */,
    PPtr<TextMeshProUGUI> m_PostsLabel /* None */)
{
    public static ShipTabsNavigationPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_UpgradeButton */
        PPtr<OwlcatMultiButton> _m_UpgradeButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_SkillsButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_PostsButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_UpgradeLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SkillsLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PostsLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_UpgradeButton,
            _m_SkillsButton,
            _m_PostsButton,
            _m_UpgradeLabel,
            _m_SkillsLabel,
            _m_PostsLabel);
    }
}

