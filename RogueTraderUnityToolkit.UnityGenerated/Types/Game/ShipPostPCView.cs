namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipPostPCView (14 fields) 41D9BA6D04E6B9BFC1DFE826F7AA02FC/C4ED30949D79CF342F1FAA49E7FC451F */
public record class ShipPostPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_Portrait /* NeedsAlign */,
    PPtr<Image> m_PostIcon /* None */,
    ShipPostTypeIcon[] m_PostTypeIcons /* None */,
    PPtr<CanvasGroup> m_PostBlock /* None */,
    PPtr<TextMeshProUGUI> m_BlockDuration /* None */,
    PPtr<GameObject> m_PostBlockFX /* None */,
    PPtr<OwlcatButton> m_MainButton /* None */,
    ColorRGBA m_PortraitEmptyColor /* None */,
    PPtr<TextMeshProUGUI> m_Title /* None */,
    PPtr<AbilitiesGroupPCView> m_AbilitiesGroupPCView /* None */)
{
    public static ShipPostPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Portrait */
        PPtr<Image> _m_Portrait = PPtr<Image>.Read(reader);
        PPtr<Image> _m_PostIcon = PPtr<Image>.Read(reader);
        ShipPostTypeIcon[] _m_PostTypeIcons = BuiltInArray<ShipPostTypeIcon>.Read(reader);
        PPtr<CanvasGroup> _m_PostBlock = PPtr<CanvasGroup>.Read(reader);
        PPtr<TextMeshProUGUI> _m_BlockDuration = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_PostBlockFX = PPtr<GameObject>.Read(reader);
        PPtr<OwlcatButton> _m_MainButton = PPtr<OwlcatButton>.Read(reader);
        ColorRGBA _m_PortraitEmptyColor = ColorRGBA.Read(reader);
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<AbilitiesGroupPCView> _m_AbilitiesGroupPCView = PPtr<AbilitiesGroupPCView>.Read(reader);
        
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
            _m_MainButton,
            _m_PortraitEmptyColor,
            _m_Title,
            _m_AbilitiesGroupPCView);
    }
}

