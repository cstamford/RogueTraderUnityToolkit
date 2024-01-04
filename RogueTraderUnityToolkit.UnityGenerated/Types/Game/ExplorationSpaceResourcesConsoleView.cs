namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ExplorationSpaceResourcesConsoleView (7 fields) 75C9647A9068C3CB0791B273E23BAAA6/076898E9EBBFBE926184EA9F8EE2F7F3 */
public record class ExplorationSpaceResourcesConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<WidgetListMVVM> m_WidgetListResources /* NeedsAlign */,
    PPtr<SystemMapSpaceResourceView> m_SystemMapSpaceResourceViewPrefab /* None */,
    PPtr<SystemMapSpaceProfitFactorView> m_SystemMapSpaceProfitFactorViewPrefab /* None */)
{
    public static ExplorationSpaceResourcesConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_WidgetListResources */
        PPtr<WidgetListMVVM> _m_WidgetListResources = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<SystemMapSpaceResourceView> _m_SystemMapSpaceResourceViewPrefab = PPtr<SystemMapSpaceResourceView>.Read(reader);
        PPtr<SystemMapSpaceProfitFactorView> _m_SystemMapSpaceProfitFactorViewPrefab = PPtr<SystemMapSpaceProfitFactorView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_WidgetListResources,
            _m_SystemMapSpaceResourceViewPrefab,
            _m_SystemMapSpaceProfitFactorViewPrefab);
    }
}

