namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ConvictionBarConsoleView (14 fields) 5480042485587B42A0786B934E6B2B4A/250823A1322B6E049DFF594F755EA7FB */
public record class ConvictionBarConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<RectTransform> m_Container /* None */,
    PPtr<RectTransform> m_Cursor /* None */,
    PPtr<OwlcatMultiButton> m_RightButtonRadical /* None */,
    PPtr<OwlcatMultiButton> m_LeftButtonPuritan /* None */,
    PPtr<OwlcatMultiButton> m_CurrentCursor /* None */,
    PPtr<TextMeshProUGUI> m_RightLabel /* None */,
    PPtr<TextMeshProUGUI> m_LeftLabel /* None */,
    PPtr<OwlcatMultiButton> m_RightLabelButton /* None */,
    PPtr<OwlcatMultiButton> m_LeftLabelButton /* None */)
{
    public static ConvictionBarConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<RectTransform> _m_Container = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_Cursor = PPtr<RectTransform>.Read(reader);
        PPtr<OwlcatMultiButton> _m_RightButtonRadical = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_LeftButtonPuritan = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_CurrentCursor = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RightLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_LeftLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_RightLabelButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_LeftLabelButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_Container,
            _m_Cursor,
            _m_RightButtonRadical,
            _m_LeftButtonPuritan,
            _m_CurrentCursor,
            _m_RightLabel,
            _m_LeftLabel,
            _m_RightLabelButton,
            _m_LeftLabelButton);
    }
}

