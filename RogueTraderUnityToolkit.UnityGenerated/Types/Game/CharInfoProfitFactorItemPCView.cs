namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoProfitFactorItemPCView (13 fields) 15821297F7DC6E308FA0CECB6B7BB7FB/35C498E9BB2015B3E2FADF6FFE7B4EAA */
public record class CharInfoProfitFactorItemPCView(
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
    PPtr<TextMeshProUGUI> m_ButtonLabel /* None */,
    PPtr<OwlcatButton> m_InfoButton /* None */,
    PPtr<OwlcatMultiButton> m_ValueContainer /* None */)
{
    public static CharInfoProfitFactorItemPCView Read(EndianBinaryReader reader)
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
        PPtr<TextMeshProUGUI> _m_ButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_InfoButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ValueContainer = PPtr<OwlcatMultiButton>.Read(reader);
        
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
            _m_ButtonLabel,
            _m_InfoButton,
            _m_ValueContainer);
    }
}

