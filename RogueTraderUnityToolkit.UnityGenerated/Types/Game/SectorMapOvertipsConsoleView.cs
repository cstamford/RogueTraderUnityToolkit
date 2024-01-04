namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SectorMapOvertipsConsoleView (9 fields) 3753174BE3C812573435865C838A0E26/3E20CC1A0CA6B90A15589837B4B1A5EF */
public record class SectorMapOvertipsConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_SectorObjectsContainer /* NeedsAlign */,
    PPtr<OvertipSystemConsoleView> m_OvertipSystemView /* None */,
    PPtr<OvertipRumourConsoleView> m_OvertipRumourView /* None */,
    PPtr<CanvasGroup> m_ClosePopupCanvas /* None */,
    PPtr<CanvasGroup> m_BlockPopupObject /* None */)
{
    public static SectorMapOvertipsConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SectorObjectsContainer */
        PPtr<RectTransform> _m_SectorObjectsContainer = PPtr<RectTransform>.Read(reader);
        PPtr<OvertipSystemConsoleView> _m_OvertipSystemView = PPtr<OvertipSystemConsoleView>.Read(reader);
        PPtr<OvertipRumourConsoleView> _m_OvertipRumourView = PPtr<OvertipRumourConsoleView>.Read(reader);
        PPtr<CanvasGroup> _m_ClosePopupCanvas = PPtr<CanvasGroup>.Read(reader);
        PPtr<CanvasGroup> _m_BlockPopupObject = PPtr<CanvasGroup>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SectorObjectsContainer,
            _m_OvertipSystemView,
            _m_OvertipRumourView,
            _m_ClosePopupCanvas,
            _m_BlockPopupObject);
    }
}

