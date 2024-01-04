namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $MapObjectOvertipNameBlockView (8 fields) C8369292D71A9A6F64F1F26C4EE7617E/E0A7427716D90D1FA85A8428BFB94EAC */
public record class MapObjectOvertipNameBlockView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasGroup> m_CanvasGroup /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_NameText /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* None */,
    PPtr<RectTransform>[] m_ContainersList /* None */)
{
    public static MapObjectOvertipNameBlockView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CanvasGroup */
        PPtr<CanvasGroup> _m_CanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NameText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<RectTransform>[] _m_ContainersList = BuiltInArray<PPtr<RectTransform>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CanvasGroup,
            _m_NameText,
            _m_FadeAnimator,
            _m_ContainersList);
    }
}

