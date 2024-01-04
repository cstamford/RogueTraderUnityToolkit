namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickTitleConsoleView (10 fields) EEF23C9FD8AAD434B619B1C03B752512/D57D82B89E67AB4788B7A8EFDCB6B96B */
public record class TooltipBrickTitleConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject>[] m_TitleObjects /* NeedsAlign */,
    PPtr<TextMeshProUGUI>[] m_Titles /* None */,
    PPtr<LayoutGroup>[] m_LayoutGroups /* None */,
    float[] m_DefaultFontSizes /* None */,
    float[] m_DefaultConsoleFontSizes /* NeedsAlign */,
    PPtr<OwlcatMultiButton>[] m_Buttons /* NeedsAlign */)
{
    public static TooltipBrickTitleConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TitleObjects */
        PPtr<GameObject>[] _m_TitleObjects = BuiltInArray<PPtr<GameObject>>.Read(reader);
        PPtr<TextMeshProUGUI>[] _m_Titles = BuiltInArray<PPtr<TextMeshProUGUI>>.Read(reader);
        PPtr<LayoutGroup>[] _m_LayoutGroups = BuiltInArray<PPtr<LayoutGroup>>.Read(reader);
        float[] _m_DefaultFontSizes = BuiltInArray<float>.Read(reader);
        reader.AlignTo(4); /* m_DefaultConsoleFontSizes */
        float[] _m_DefaultConsoleFontSizes = BuiltInArray<float>.Read(reader);
        reader.AlignTo(4); /* m_Buttons */
        PPtr<OwlcatMultiButton>[] _m_Buttons = BuiltInArray<PPtr<OwlcatMultiButton>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_TitleObjects,
            _m_Titles,
            _m_LayoutGroups,
            _m_DefaultFontSizes,
            _m_DefaultConsoleFontSizes,
            _m_Buttons);
    }
}

