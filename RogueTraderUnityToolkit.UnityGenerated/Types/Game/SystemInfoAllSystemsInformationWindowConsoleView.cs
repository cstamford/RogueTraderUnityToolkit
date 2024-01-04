namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SystemInfoAllSystemsInformationWindowConsoleView (12 fields) 0EF82C1583719734B89BE7A301DD4B17/D638690A7F934F65792B8488E7092DAF */
public record class SystemInfoAllSystemsInformationWindowConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_SystemName /* NeedsAlign */,
    PPtr<Image> m_ColonizedIcon /* None */,
    PPtr<Image> m_QuestIcon /* None */,
    PPtr<Image> m_ExtractumIcon /* None */,
    PPtr<TextMeshProUGUI> m_ResearchCountText /* None */,
    PPtr<GameObject> m_ConsoleFocusButton /* None */,
    PPtr<ConsoleHint> m_ConsoleAcceptHint /* None */,
    BoolReactiveProperty IsShouldBeFocusedAnyway /* None */)
{
    public static SystemInfoAllSystemsInformationWindowConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SystemName */
        PPtr<TextMeshProUGUI> _m_SystemName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_ColonizedIcon = PPtr<Image>.Read(reader);
        PPtr<Image> _m_QuestIcon = PPtr<Image>.Read(reader);
        PPtr<Image> _m_ExtractumIcon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ResearchCountText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_ConsoleFocusButton = PPtr<GameObject>.Read(reader);
        PPtr<ConsoleHint> _m_ConsoleAcceptHint = PPtr<ConsoleHint>.Read(reader);
        BoolReactiveProperty _IsShouldBeFocusedAnyway = BoolReactiveProperty.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SystemName,
            _m_ColonizedIcon,
            _m_QuestIcon,
            _m_ExtractumIcon,
            _m_ResearchCountText,
            _m_ConsoleFocusButton,
            _m_ConsoleAcceptHint,
            _IsShouldBeFocusedAnyway);
    }
}

