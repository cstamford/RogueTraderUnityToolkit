namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ScrapRewardSlotView (8 fields) 9E625DC9DB1F7F5F6C1E8AA79F77F7C0/55F348CB9FD8619AD44FCB77F3403969 */
public record class ScrapRewardSlotView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_MainButton /* NeedsAlign */,
    PPtr<GameObject> m_Container /* None */,
    PPtr<TextMeshProUGUI> m_ScrapTitle /* None */,
    PPtr<TextMeshProUGUI> m_ScrapAmount /* None */)
{
    public static ScrapRewardSlotView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MainButton */
        PPtr<OwlcatMultiButton> _m_MainButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<GameObject> _m_Container = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ScrapTitle = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ScrapAmount = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MainButton,
            _m_Container,
            _m_ScrapTitle,
            _m_ScrapAmount);
    }
}

