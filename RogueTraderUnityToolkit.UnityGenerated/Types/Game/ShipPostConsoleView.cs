namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipPostConsoleView (12 fields) F97BF2E7FA822CB143EAE9FC27FC37B7/5C4D51F4FCF490ECBB3AAF8972CE59AB */
public record class ShipPostConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_Portrait /* NeedsAlign */,
    PPtr<Image> m_PostIcon /* None */,
    ShipPostTypeIcon m_PostTypeIcons /* None */,
    PPtr<CanvasGroup> m_PostBlock /* None */,
    PPtr<TextMeshProUGUI> m_BlockDuration /* None */,
    PPtr<GameObject> m_PostBlockFX /* None */,
    PPtr<CanvasGroup> m_PortraitBlock /* None */,
    PPtr<AbilitiesGroupConsoleView> m_AbilitiesGroupConsoleView /* None */)
{
    public static ShipPostConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Portrait */
        PPtr<Image> _m_Portrait = PPtr<Image>.Read(reader);
        PPtr<Image> _m_PostIcon = PPtr<Image>.Read(reader);
        ShipPostTypeIcon _m_PostTypeIcons = ShipPostTypeIcon.Read(reader);
        PPtr<CanvasGroup> _m_PostBlock = PPtr<CanvasGroup>.Read(reader);
        PPtr<TextMeshProUGUI> _m_BlockDuration = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_PostBlockFX = PPtr<GameObject>.Read(reader);
        PPtr<CanvasGroup> _m_PortraitBlock = PPtr<CanvasGroup>.Read(reader);
        PPtr<AbilitiesGroupConsoleView> _m_AbilitiesGroupConsoleView = PPtr<AbilitiesGroupConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Portrait,
            _m_PostIcon,
            _m_PostTypeIcons,
            _m_PostBlock,
            _m_BlockDuration,
            _m_PostBlockFX,
            _m_PortraitBlock,
            _m_AbilitiesGroupConsoleView);
    }
}

