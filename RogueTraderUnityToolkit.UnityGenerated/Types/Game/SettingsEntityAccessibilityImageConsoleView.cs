namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SettingsEntityAccessibilityImageConsoleView (6 fields) 1A949219F793483A286AB97DC56C37C3/8AC1FBE14C3C0698420EA9076FED59C3 */
public record class SettingsEntityAccessibilityImageConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_AccessibilityImage /* NeedsAlign */,
    VirtualListLayoutElementSettings m_LayoutSettings /* None */)
{
    public static SettingsEntityAccessibilityImageConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_AccessibilityImage */
        PPtr<Image> _m_AccessibilityImage = PPtr<Image>.Read(reader);
        VirtualListLayoutElementSettings _m_LayoutSettings = VirtualListLayoutElementSettings.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_AccessibilityImage,
            _m_LayoutSettings);
    }
}

