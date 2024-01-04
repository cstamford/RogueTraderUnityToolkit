namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SectorMapPCView (8 fields) 2ABBCEFA66FA8899F3F1D1090B2ED212/45A5D861DBB65433750C3FB117C47659 */
public record class SectorMapPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<SectorMapBottomHudPCView> m_SectorMapBottomHudPCView /* NeedsAlign */,
    PPtr<SpaceSystemInformationWindowPCView> m_SpaceSystemInformationWindowPCView /* None */,
    PPtr<OwlcatMultiButton> m_ShowHideAllSystemsInformationWindowButton /* None */,
    PPtr<AllSystemsInformationWindowPCView> m_AllSystemsInformationWindowPCView /* None */)
{
    public static SectorMapPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SectorMapBottomHudPCView */
        PPtr<SectorMapBottomHudPCView> _m_SectorMapBottomHudPCView = PPtr<SectorMapBottomHudPCView>.Read(reader);
        PPtr<SpaceSystemInformationWindowPCView> _m_SpaceSystemInformationWindowPCView = PPtr<SpaceSystemInformationWindowPCView>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ShowHideAllSystemsInformationWindowButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<AllSystemsInformationWindowPCView> _m_AllSystemsInformationWindowPCView = PPtr<AllSystemsInformationWindowPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SectorMapBottomHudPCView,
            _m_SpaceSystemInformationWindowPCView,
            _m_ShowHideAllSystemsInformationWindowButton,
            _m_AllSystemsInformationWindowPCView);
    }
}

