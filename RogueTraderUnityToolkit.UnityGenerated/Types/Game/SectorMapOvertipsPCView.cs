namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SectorMapOvertipsPCView (10 fields) A30BACECF43211530269CD99DF3F423E/A407135F4A4543C6BCE74451DD7D9A1B */
public record class SectorMapOvertipsPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_SectorObjectsContainer /* NeedsAlign */,
    PPtr<OvertipSystemPCView> m_OvertipSystemView /* None */,
    PPtr<OvertipRumourPCView> m_OvertipRumourView /* None */,
    PPtr<CanvasGroup> m_ClosePopupCanvas /* None */,
    PPtr<CanvasGroup> m_BlockPopupObject /* None */,
    PPtr<OwlcatButton> m_ClosePopup /* None */)
{
    public static SectorMapOvertipsPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SectorObjectsContainer */
        PPtr<RectTransform> _m_SectorObjectsContainer = PPtr<RectTransform>.Read(reader);
        PPtr<OvertipSystemPCView> _m_OvertipSystemView = PPtr<OvertipSystemPCView>.Read(reader);
        PPtr<OvertipRumourPCView> _m_OvertipRumourView = PPtr<OvertipRumourPCView>.Read(reader);
        PPtr<CanvasGroup> _m_ClosePopupCanvas = PPtr<CanvasGroup>.Read(reader);
        PPtr<CanvasGroup> _m_BlockPopupObject = PPtr<CanvasGroup>.Read(reader);
        PPtr<OwlcatButton> _m_ClosePopup = PPtr<OwlcatButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SectorObjectsContainer,
            _m_OvertipSystemView,
            _m_OvertipRumourView,
            _m_ClosePopupCanvas,
            _m_BlockPopupObject,
            _m_ClosePopup);
    }
}

