namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ExplorationResourceListConsoleView (7 fields) 1F2BA532901CFACACF706EB3EF68B94A/9FCDCA97AF184CB704D6A41FE864F6B6 */
public record class ExplorationResourceListConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<WidgetListMVVM> m_WidgetListResources /* NeedsAlign */,
    PPtr<ExplorationResourceConsoleView> m_PlanetResourcePrefab /* None */,
    PPtr<TextMeshProUGUI> m_PlanetResourcesLabel /* None */)
{
    public static ExplorationResourceListConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_WidgetListResources */
        PPtr<WidgetListMVVM> _m_WidgetListResources = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<ExplorationResourceConsoleView> _m_PlanetResourcePrefab = PPtr<ExplorationResourceConsoleView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PlanetResourcesLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_WidgetListResources,
            _m_PlanetResourcePrefab,
            _m_PlanetResourcesLabel);
    }
}

