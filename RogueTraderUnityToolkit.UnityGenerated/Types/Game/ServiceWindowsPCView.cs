namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ServiceWindowsPCView (14 fields) 415D1688E6D2FA4E29C7818B28A74CDA/341B7A5B6D2824F8E87314D3232A6D9C */
public record class ServiceWindowsPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ServiceWindowMenuPCView> m_ServiceWindowMenuPcView /* NeedsAlign */,
    PPtr<InventoryPCView> InventoryBaseView /* None */,
    PPtr<CharacterInfoPCView> m_CharacterInfoPCView /* None */,
    PPtr<JournalPCView> m_JournalPCView /* None */,
    PPtr<LocalMapPCView> m_LocalMapPCView /* None */,
    PPtr<EncyclopediaPCView> m_EncyclopediaView /* None */,
    PPtr<ColonyManagementPCView> m_ColonyManagementPCView /* None */,
    PPtr<ShipCustomizationPCView> m_ShipCustomizationPCView /* None */,
    PPtr<CargoManagementPCView> m_CargoManagementPCView /* None */,
    PPtr<FadeAnimator> m_Background /* None */)
{
    public static ServiceWindowsPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ServiceWindowMenuPcView */
        PPtr<ServiceWindowMenuPCView> _m_ServiceWindowMenuPcView = PPtr<ServiceWindowMenuPCView>.Read(reader);
        PPtr<InventoryPCView> _InventoryBaseView = PPtr<InventoryPCView>.Read(reader);
        PPtr<CharacterInfoPCView> _m_CharacterInfoPCView = PPtr<CharacterInfoPCView>.Read(reader);
        PPtr<JournalPCView> _m_JournalPCView = PPtr<JournalPCView>.Read(reader);
        PPtr<LocalMapPCView> _m_LocalMapPCView = PPtr<LocalMapPCView>.Read(reader);
        PPtr<EncyclopediaPCView> _m_EncyclopediaView = PPtr<EncyclopediaPCView>.Read(reader);
        PPtr<ColonyManagementPCView> _m_ColonyManagementPCView = PPtr<ColonyManagementPCView>.Read(reader);
        PPtr<ShipCustomizationPCView> _m_ShipCustomizationPCView = PPtr<ShipCustomizationPCView>.Read(reader);
        PPtr<CargoManagementPCView> _m_CargoManagementPCView = PPtr<CargoManagementPCView>.Read(reader);
        PPtr<FadeAnimator> _m_Background = PPtr<FadeAnimator>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ServiceWindowMenuPcView,
            _InventoryBaseView,
            _m_CharacterInfoPCView,
            _m_JournalPCView,
            _m_LocalMapPCView,
            _m_EncyclopediaView,
            _m_ColonyManagementPCView,
            _m_ShipCustomizationPCView,
            _m_CargoManagementPCView,
            _m_Background);
    }
}

