namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LootCollectorPCView (20 fields) 26256E0D413A2ECD672E7D235AC80B9D/2CC6435CE9ADB7F0F9714DBA5A5F296B */
public record class LootCollectorPCView(
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
    PPtr<OwlcatButton> m_CollectAllButton /* None */,
    PPtr<GameObject> m_CollectAllButtonBlock /* None */,
    PPtr<TextMeshProUGUI> m_CollectAllButtonLabel /* None */,
    PPtr<OwlcatButton> m_CloseButton /* None */,
    PPtr<GameObject> m_CloseButtonBlock /* None */,
    PPtr<TextMeshProUGUI> m_CloseButtonText /* None */,
    PPtr<OwlcatButton>[] m_LootManagerButtons /* None */,
    PPtr<OwlcatButton> m_AllToCargo /* None */,
    PPtr<OwlcatButton> m_AllToInventory /* None */)
{
    public static LootCollectorPCView Read(EndianBinaryReader reader)
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
        PPtr<OwlcatButton> _m_CollectAllButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<GameObject> _m_CollectAllButtonBlock = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CollectAllButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_CloseButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<GameObject> _m_CloseButtonBlock = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CloseButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton>[] _m_LootManagerButtons = BuiltInArray<PPtr<OwlcatButton>>.Read(reader);
        PPtr<OwlcatButton> _m_AllToCargo = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_AllToInventory = PPtr<OwlcatButton>.Read(reader);
        
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
            _m_CollectAllButton,
            _m_CollectAllButtonBlock,
            _m_CollectAllButtonLabel,
            _m_CloseButton,
            _m_CloseButtonBlock,
            _m_CloseButtonText,
            _m_LootManagerButtons,
            _m_AllToCargo,
            _m_AllToInventory);
    }
}

