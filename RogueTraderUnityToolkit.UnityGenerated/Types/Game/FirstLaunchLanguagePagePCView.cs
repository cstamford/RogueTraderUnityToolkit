namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FirstLaunchLanguagePagePCView (5 fields) 7735DC46A6AAB6C2D83E1DD3A8AFC707/97F15E93F5EC1F77E3D2C66A0584045D */
public record class FirstLaunchLanguagePagePCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FirstLaunchEntityLanguagePCView> m_FirstLaunchEntityLanguagePCView /* NeedsAlign */)
{
    public static FirstLaunchLanguagePagePCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FirstLaunchEntityLanguagePCView */
        PPtr<FirstLaunchEntityLanguagePCView> _m_FirstLaunchEntityLanguagePCView = PPtr<FirstLaunchEntityLanguagePCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FirstLaunchEntityLanguagePCView);
    }
}

