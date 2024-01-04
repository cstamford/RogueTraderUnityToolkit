namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SystemInfoAllSystemsInformationWindowPCView (10 fields) 43535498760899B409EDB82F1463D258/5A1643ED75644886749879ABCD4DAAB0 */
public record class SystemInfoAllSystemsInformationWindowPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_SystemName /* NeedsAlign */,
    PPtr<Image> m_ColonizedIcon /* None */,
    PPtr<Image> m_QuestIcon /* None */,
    PPtr<Image> m_ExtractumIcon /* None */,
    PPtr<TextMeshProUGUI> m_ResearchCountText /* None */,
    PPtr<OwlcatButton> m_MoveCameraToSystemButton /* None */)
{
    public static SystemInfoAllSystemsInformationWindowPCView Read(EndianBinaryReader reader)
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
        PPtr<OwlcatButton> _m_MoveCameraToSystemButton = PPtr<OwlcatButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SystemName,
            _m_ColonizedIcon,
            _m_QuestIcon,
            _m_ExtractumIcon,
            _m_ResearchCountText,
            _m_MoveCameraToSystemButton);
    }
}

