namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PlayerStashConsoleView (10 fields) AE054871375BBD444322EB4E8ACD1286/4CF6A9D4A810762B5462F0C2BD246A82 */
public record class PlayerStashConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<LootObjectView> m_LootView /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_HeaderTitle /* None */,
    PPtr<OwlcatButton> m_CloseButton /* None */,
    PPtr<OwlcatButton> m_LootManagerButton /* None */,
    PPtr<TextMeshProUGUI> m_LootManagerButtonLable /* None */,
    PPtr<ScrollRectExtended> m_ScrollRect /* None */)
{
    public static PlayerStashConsoleView Read(EndianBinaryReader reader)
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
        PPtr<ScrollRectExtended> _m_ScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_LootView,
            _m_HeaderTitle,
            _m_CloseButton,
            _m_LootManagerButton,
            _m_LootManagerButtonLable,
            _m_ScrollRect);
    }
}

