namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ExplorationPointOfInterestConsoleView (15 fields) 9F683D65CADE4B86A88DBCBEB093C7D6/60F240ADE962D9C3352C086050CE9AB3 */
public record class ExplorationPointOfInterestConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_Icon /* NeedsAlign */,
    PPtr<Image> m_UnavailableEffect /* None */,
    PPtr<Image> m_QuestMarkImage /* None */,
    PPtr<Image> m_QuestAreaImage /* None */,
    PPtr<Image> m_RumourMarkImage /* None */,
    PPtr<CanvasGroup> m_CanvasGroup /* None */,
    ColorRGBA m_HeaderColor /* None */,
    PPtr<Sprite>[] m_PoiMarks /* None */,
    PPtr<OwlcatMultiButton> m_Button /* None */,
    PPtr<CanvasGroup> m_HintCanvasGroup /* None */,
    PPtr<TextMeshProUGUI> m_HintLabel /* None */)
{
    public static ExplorationPointOfInterestConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Icon */
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<Image> _m_UnavailableEffect = PPtr<Image>.Read(reader);
        PPtr<Image> _m_QuestMarkImage = PPtr<Image>.Read(reader);
        PPtr<Image> _m_QuestAreaImage = PPtr<Image>.Read(reader);
        PPtr<Image> _m_RumourMarkImage = PPtr<Image>.Read(reader);
        PPtr<CanvasGroup> _m_CanvasGroup = PPtr<CanvasGroup>.Read(reader);
        ColorRGBA _m_HeaderColor = ColorRGBA.Read(reader);
        PPtr<Sprite>[] _m_PoiMarks = BuiltInArray<PPtr<Sprite>>.Read(reader);
        PPtr<OwlcatMultiButton> _m_Button = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<CanvasGroup> _m_HintCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<TextMeshProUGUI> _m_HintLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Icon,
            _m_UnavailableEffect,
            _m_QuestMarkImage,
            _m_QuestAreaImage,
            _m_RumourMarkImage,
            _m_CanvasGroup,
            _m_HeaderColor,
            _m_PoiMarks,
            _m_Button,
            _m_HintCanvasGroup,
            _m_HintLabel);
    }
}

