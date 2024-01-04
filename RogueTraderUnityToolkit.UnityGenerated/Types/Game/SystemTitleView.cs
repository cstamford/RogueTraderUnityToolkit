namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SystemTitleView (8 fields) 8589442DF0C7FA89B33AF99AD34716FA/D79125DA972BE6C260B2751373F78B4C */
public record class SystemTitleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_SystemTitleNameText /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_TitleResearchCountText /* None */,
    PPtr<Image> m_TitleTooltipTaker /* None */,
    PPtr<RectTransform> m_TitleTooltipPlace /* None */)
{
    public static SystemTitleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SystemTitleNameText */
        PPtr<TextMeshProUGUI> _m_SystemTitleNameText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TitleResearchCountText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_TitleTooltipTaker = PPtr<Image>.Read(reader);
        PPtr<RectTransform> _m_TitleTooltipPlace = PPtr<RectTransform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SystemTitleNameText,
            _m_TitleResearchCountText,
            _m_TitleTooltipTaker,
            _m_TitleTooltipPlace);
    }
}

