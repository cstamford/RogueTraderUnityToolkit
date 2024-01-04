namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $NewGamePCView (12 fields) 07746C85ABD0B3EDC9480CA3820D71D4/1E2BFDA97C038B675525F4269065BB6B */
public record class NewGamePCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<NewGameMenuSelectorBaseView> m_Selector /* NeedsAlign */,
    PPtr<NewGamePhaseStoryPCView> m_NewGamePhaseStoryPCView /* None */,
    PPtr<NewGamePhaseDifficultyPCView> m_NewGamePhaseDifficultyPCView /* None */,
    PPtr<OwlcatButton> m_CloseButton /* None */,
    PPtr<OwlcatButton> m_BackButton /* None */,
    PPtr<OwlcatButton> m_NextButton /* None */,
    PPtr<TextMeshProUGUI> m_BackButtonLabel /* None */,
    PPtr<TextMeshProUGUI> m_NextButtonLabel /* None */)
{
    public static NewGamePCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Selector */
        PPtr<NewGameMenuSelectorBaseView> _m_Selector = PPtr<NewGameMenuSelectorBaseView>.Read(reader);
        PPtr<NewGamePhaseStoryPCView> _m_NewGamePhaseStoryPCView = PPtr<NewGamePhaseStoryPCView>.Read(reader);
        PPtr<NewGamePhaseDifficultyPCView> _m_NewGamePhaseDifficultyPCView = PPtr<NewGamePhaseDifficultyPCView>.Read(reader);
        PPtr<OwlcatButton> _m_CloseButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_BackButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_NextButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_BackButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NextButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Selector,
            _m_NewGamePhaseStoryPCView,
            _m_NewGamePhaseDifficultyPCView,
            _m_CloseButton,
            _m_BackButton,
            _m_NextButton,
            _m_BackButtonLabel,
            _m_NextButtonLabel);
    }
}

