namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FeedbackPopupItemPCView (7 fields) F1A53E8BD31B5E1D8645F1C3F3E30E22/B2EC51C17C55C0FA8E90C9FAE850E330 */
public record class FeedbackPopupItemPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_MainButton /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Label /* None */,
    PPtr<Image> m_Icon /* None */)
{
    public static FeedbackPopupItemPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MainButton */
        PPtr<OwlcatMultiButton> _m_MainButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MainButton,
            _m_Label,
            _m_Icon);
    }
}

