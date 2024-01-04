namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickItemFooterView (11 fields) 1619671D4F73FC23A90F230735F4EF7E/720A7B34B4D410F6C213FD34973E3856 */
public record class TooltipBrickItemFooterView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_LeftLabel /* NeedsAlign */,
    PPtr<GameObject> m_LeftSide /* None */,
    PPtr<TextMeshProUGUI> m_RightLabel /* None */,
    PPtr<GameObject> m_RightSide /* None */,
    PPtr<GameObject> m_LeftEmpty /* None */,
    PPtr<GameObject> m_LeftInfo /* None */,
    PPtr<Image> m_Icon /* None */)
{
    public static TooltipBrickItemFooterView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_LeftLabel */
        PPtr<TextMeshProUGUI> _m_LeftLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_LeftSide = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RightLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_RightSide = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_LeftEmpty = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_LeftInfo = PPtr<GameObject>.Read(reader);
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_LeftLabel,
            _m_LeftSide,
            _m_RightLabel,
            _m_RightSide,
            _m_LeftEmpty,
            _m_LeftInfo,
            _m_Icon);
    }
}

