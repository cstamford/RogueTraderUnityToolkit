namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipStatsConsoleView (12 fields) 3E8C0D985C1E1BA0D0B6317B5210A637/077AE4FD22B349584A9EF59D33B23400 */
public record class ShipStatsConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_SpeedBlock /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Speed /* None */,
    PPtr<TextMeshProUGUI> m_SpeedText /* None */,
    PPtr<OwlcatMultiButton> m_InertiaBlock /* None */,
    PPtr<TextMeshProUGUI> m_Inertia /* None */,
    PPtr<TextMeshProUGUI> m_InertiaText /* None */,
    PPtr<MonoBehaviour> TooltipPlace /* None */,
    PPtr<CanvasGroup> m_AnimatedMark /* None */)
{
    public static ShipStatsConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SpeedBlock */
        PPtr<OwlcatMultiButton> _m_SpeedBlock = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Speed = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SpeedText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_InertiaBlock = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Inertia = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_InertiaText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<MonoBehaviour> _TooltipPlace = PPtr<MonoBehaviour>.Read(reader);
        PPtr<CanvasGroup> _m_AnimatedMark = PPtr<CanvasGroup>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SpeedBlock,
            _m_Speed,
            _m_SpeedText,
            _m_InertiaBlock,
            _m_Inertia,
            _m_InertiaText,
            _TooltipPlace,
            _m_AnimatedMark);
    }
}

