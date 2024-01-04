namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoProfitFactorConsoleBaseView (12 fields) 218EEBBB5F122656C2751B0E8ACBB69E/31CA4E081A41A7EAE7426C127C4125D0 */
public record class CharInfoProfitFactorConsoleBaseView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Title /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_EmptyListDesc /* None */,
    PPtr<TextMeshProUGUI> m_ProfitFactorValue /* None */,
    PPtr<ScrollRectExtended> m_ColoniesInfoScroll /* None */,
    PPtr<GameObject> m_EmptyListContainer /* None */,
    PPtr<TooltipBrickIconStatValueView> m_ColonyInfoPrefab /* None */,
    PPtr<OwlcatMultiSelectable> m_FrameButton /* None */,
    PPtr<ConsoleHint> m_ScrollHint /* None */)
{
    public static CharInfoProfitFactorConsoleBaseView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Title */
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_EmptyListDesc = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ProfitFactorValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<ScrollRectExtended> _m_ColoniesInfoScroll = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<GameObject> _m_EmptyListContainer = PPtr<GameObject>.Read(reader);
        PPtr<TooltipBrickIconStatValueView> _m_ColonyInfoPrefab = PPtr<TooltipBrickIconStatValueView>.Read(reader);
        PPtr<OwlcatMultiSelectable> _m_FrameButton = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<ConsoleHint> _m_ScrollHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Title,
            _m_EmptyListDesc,
            _m_ProfitFactorValue,
            _m_ColoniesInfoScroll,
            _m_EmptyListContainer,
            _m_ColonyInfoPrefab,
            _m_FrameButton,
            _m_ScrollHint);
    }
}

