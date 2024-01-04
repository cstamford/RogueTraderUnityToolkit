namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ServiceWindowsConsoleView (14 fields) 690DEC66308D05DCC0A7DB14F3EE0242/5880FF60655ADF460D3D99D157111865 */
public record class ServiceWindowsConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ServiceWindowMenuPCView> m_ServiceWindowMenuPcView /* NeedsAlign */,
    PPtr<InventoryConsoleView> InventoryBaseView /* None */,
    PPtr<CharacterInfoConsoleView> m_CharacterInfoConsoleView /* None */,
    PPtr<JournalConsoleView> m_JournalConsoleView /* None */,
    PPtr<LocalMapConsoleView> m_LocalMapConsoleView /* None */,
    PPtr<EncyclopediaConsoleView> m_EncyclopediaView /* None */,
    PPtr<ColonyManagementConsoleView> m_ColonyManagementConsoleView /* None */,
    PPtr<ShipCustomizationConsoleView> m_ShipCustomizationConsoleView /* None */,
    PPtr<CargoManagementConsoleView> m_CargoManagementConsoleView /* None */,
    PPtr<FadeAnimator> m_Background /* None */)
{
    public static ServiceWindowsConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ServiceWindowMenuPcView */
        PPtr<ServiceWindowMenuPCView> _m_ServiceWindowMenuPcView = PPtr<ServiceWindowMenuPCView>.Read(reader);
        PPtr<InventoryConsoleView> _InventoryBaseView = PPtr<InventoryConsoleView>.Read(reader);
        PPtr<CharacterInfoConsoleView> _m_CharacterInfoConsoleView = PPtr<CharacterInfoConsoleView>.Read(reader);
        PPtr<JournalConsoleView> _m_JournalConsoleView = PPtr<JournalConsoleView>.Read(reader);
        PPtr<LocalMapConsoleView> _m_LocalMapConsoleView = PPtr<LocalMapConsoleView>.Read(reader);
        PPtr<EncyclopediaConsoleView> _m_EncyclopediaView = PPtr<EncyclopediaConsoleView>.Read(reader);
        PPtr<ColonyManagementConsoleView> _m_ColonyManagementConsoleView = PPtr<ColonyManagementConsoleView>.Read(reader);
        PPtr<ShipCustomizationConsoleView> _m_ShipCustomizationConsoleView = PPtr<ShipCustomizationConsoleView>.Read(reader);
        PPtr<CargoManagementConsoleView> _m_CargoManagementConsoleView = PPtr<CargoManagementConsoleView>.Read(reader);
        PPtr<FadeAnimator> _m_Background = PPtr<FadeAnimator>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ServiceWindowMenuPcView,
            _InventoryBaseView,
            _m_CharacterInfoConsoleView,
            _m_JournalConsoleView,
            _m_LocalMapConsoleView,
            _m_EncyclopediaView,
            _m_ColonyManagementConsoleView,
            _m_ShipCustomizationConsoleView,
            _m_CargoManagementConsoleView,
            _m_Background);
    }
}

