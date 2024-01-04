namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipConsoleView (31 fields) 426115852D038970BA939E408EF73E6B/F971CB6316FBAF502F84DA73EABDAFAD */
public record class ShipConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_ShipName /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_FrontArmor /* None */,
    PPtr<TextMeshProUGUI> m_PortArmor /* None */,
    PPtr<TextMeshProUGUI> m_StarboardArmor /* None */,
    PPtr<TextMeshProUGUI> m_RearArmor /* None */,
    PPtr<TextMeshProUGUI> m_FrontShield /* None */,
    PPtr<TextMeshProUGUI> m_PortShield /* None */,
    PPtr<TextMeshProUGUI> m_StarboardShield /* None */,
    PPtr<TextMeshProUGUI> m_RearShield /* None */,
    PPtr<TextMeshProUGUI> m_Experience /* None */,
    PPtr<TextMeshProUGUI> m_ExperienceText /* None */,
    PPtr<TextMeshProUGUI> m_Level /* None */,
    PPtr<TextMeshProUGUI> m_LevelText /* None */,
    PPtr<Image> m_ExpBar /* None */,
    PPtr<OwlcatMultiButton> m_ProwRamDamageBlock /* None */,
    PPtr<TextMeshProUGUI> ProwRamDamageBonus /* None */,
    PPtr<OwlcatMultiButton> m_ProwRamSelfDamageReduceBlock /* None */,
    PPtr<TextMeshProUGUI> ProwRamSelfDamageReduceBonus /* None */,
    PPtr<CanvasGroup> m_ProwMark /* None */,
    PPtr<CanvasGroup> m_ShieldsMark /* None */,
    PPtr<CanvasGroup> m_HullMark /* None */,
    PPtr<OwlcatMultiButton>[] m_Shields /* None */,
    PPtr<OwlcatMultiButton>[] m_Hulls /* None */,
    PPtr<MonoBehaviour> TooltipPlace /* None */,
    PPtr<OwlcatMultiButton> m_HPBarTooltipObject /* None */,
    PPtr<OwlcatMultiButton> m_VoidshipHealthTextTooltipObject /* None */,
    PPtr<OwlcatMultiButton> m_RepairBlock /* None */)
{
    public static ShipConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ShipName */
        PPtr<TextMeshProUGUI> _m_ShipName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_FrontArmor = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PortArmor = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_StarboardArmor = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RearArmor = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_FrontShield = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PortShield = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_StarboardShield = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RearShield = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Experience = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ExperienceText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Level = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_LevelText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_ExpBar = PPtr<Image>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ProwRamDamageBlock = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _ProwRamDamageBonus = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ProwRamSelfDamageReduceBlock = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _ProwRamSelfDamageReduceBonus = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CanvasGroup> _m_ProwMark = PPtr<CanvasGroup>.Read(reader);
        PPtr<CanvasGroup> _m_ShieldsMark = PPtr<CanvasGroup>.Read(reader);
        PPtr<CanvasGroup> _m_HullMark = PPtr<CanvasGroup>.Read(reader);
        PPtr<OwlcatMultiButton>[] _m_Shields = BuiltInArray<PPtr<OwlcatMultiButton>>.Read(reader);
        PPtr<OwlcatMultiButton>[] _m_Hulls = BuiltInArray<PPtr<OwlcatMultiButton>>.Read(reader);
        PPtr<MonoBehaviour> _TooltipPlace = PPtr<MonoBehaviour>.Read(reader);
        PPtr<OwlcatMultiButton> _m_HPBarTooltipObject = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_VoidshipHealthTextTooltipObject = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_RepairBlock = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ShipName,
            _m_FrontArmor,
            _m_PortArmor,
            _m_StarboardArmor,
            _m_RearArmor,
            _m_FrontShield,
            _m_PortShield,
            _m_StarboardShield,
            _m_RearShield,
            _m_Experience,
            _m_ExperienceText,
            _m_Level,
            _m_LevelText,
            _m_ExpBar,
            _m_ProwRamDamageBlock,
            _ProwRamDamageBonus,
            _m_ProwRamSelfDamageReduceBlock,
            _ProwRamSelfDamageReduceBonus,
            _m_ProwMark,
            _m_ShieldsMark,
            _m_HullMark,
            _m_Shields,
            _m_Hulls,
            _TooltipPlace,
            _m_HPBarTooltipObject,
            _m_VoidshipHealthTextTooltipObject,
            _m_RepairBlock);
    }
}

