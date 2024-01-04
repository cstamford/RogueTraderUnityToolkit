namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PlayerStashPCView (9 fields) 4BF100BB63E4C763EF267F6BD64197CE/EA20168F0B710077CC305E43B4CAC2CC */
public record class PlayerStashPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<LootObjectView> m_LootView /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_HeaderTitle /* None */,
    PPtr<OwlcatButton> m_CloseButton /* None */,
    PPtr<OwlcatButton> m_LootManagerButton /* None */,
    PPtr<TextMeshProUGUI> m_LootManagerButtonLable /* None */)
{
    public static PlayerStashPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_LootView */
        PPtr<LootObjectView> _m_LootView = PPtr<LootObjectView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_HeaderTitle = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_CloseButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_LootManagerButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_LootManagerButtonLable = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_LootView,
            _m_HeaderTitle,
            _m_CloseButton,
            _m_LootManagerButton,
            _m_LootManagerButtonLable);
    }
}

