namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $NewGamePhaseStoryPCView (9 fields) 9AB5D05BFCEDDFACBD36C23EB196005C/5182F34F679C7F1E02E15A8A94330C49 */
public record class NewGamePhaseStoryPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<PantographView> m_PantographView /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_MainStoryButtonLabel /* None */,
    PPtr<TextMeshProUGUI> m_MainStoryButtonDescription /* None */,
    PPtr<TextMeshProUGUI> m_OtherModsAreComingSoonLabel /* None */,
    PPtr<ScrollRectExtended> m_ScrollRect /* None */)
{
    public static NewGamePhaseStoryPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_PantographView */
        PPtr<PantographView> _m_PantographView = PPtr<PantographView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_MainStoryButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_MainStoryButtonDescription = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_OtherModsAreComingSoonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PantographView,
            _m_MainStoryButtonLabel,
            _m_MainStoryButtonDescription,
            _m_OtherModsAreComingSoonLabel,
            _m_ScrollRect);
    }
}

