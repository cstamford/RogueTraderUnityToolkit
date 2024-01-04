namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LootCollectorConsoleView (19 fields) 8FE92FA3739A91F41FA1508867576CE0/4650E4C83B03E557B5634298F2832ABE */
public record class LootCollectorConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<LootObjectView> m_LootToInventory /* NeedsAlign */,
    PPtr<LootObjectView> m_LootToCargo /* None */,
    PPtr<ScrollRectExtended> m_ScrollRect /* None */,
    PPtr<GameObject> m_SkillCheckContainer /* None */,
    PPtr<TextMeshProUGUI> m_SkillCheckText /* None */,
    PPtr<TextMeshProUGUI> m_ToCargoText /* None */,
    PPtr<TextMeshProUGUI> m_ToInventoryText /* None */,
    PPtr<ConsoleHint> m_CollectAllHint /* None */,
    PPtr<ConsoleHint> m_CollectAllLongHint /* None */,
    PPtr<ConsoleHint> m_CloseHint /* None */,
    PPtr<ConsoleHint>[] m_ChangeViewHints /* None */,
    PPtr<ConsoleHint> m_AllToCargo /* None */,
    PPtr<ConsoleHint> m_AllToInventory /* None */,
    PPtr<OwlcatMultiButton> m_ToCargoTitleFrame /* None */,
    PPtr<OwlcatMultiButton> m_ToInventoryTitleFrame /* None */)
{
    public static LootCollectorConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_LootToInventory */
        PPtr<LootObjectView> _m_LootToInventory = PPtr<LootObjectView>.Read(reader);
        PPtr<LootObjectView> _m_LootToCargo = PPtr<LootObjectView>.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<GameObject> _m_SkillCheckContainer = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SkillCheckText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ToCargoText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ToInventoryText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<ConsoleHint> _m_CollectAllHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_CollectAllLongHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_CloseHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint>[] _m_ChangeViewHints = BuiltInArray<PPtr<ConsoleHint>>.Read(reader);
        PPtr<ConsoleHint> _m_AllToCargo = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_AllToInventory = PPtr<ConsoleHint>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ToCargoTitleFrame = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ToInventoryTitleFrame = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_LootToInventory,
            _m_LootToCargo,
            _m_ScrollRect,
            _m_SkillCheckContainer,
            _m_SkillCheckText,
            _m_ToCargoText,
            _m_ToInventoryText,
            _m_CollectAllHint,
            _m_CollectAllLongHint,
            _m_CloseHint,
            _m_ChangeViewHints,
            _m_AllToCargo,
            _m_AllToInventory,
            _m_ToCargoTitleFrame,
            _m_ToInventoryTitleFrame);
    }
}

