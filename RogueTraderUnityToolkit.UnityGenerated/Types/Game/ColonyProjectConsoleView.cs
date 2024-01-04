namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyProjectConsoleView (9 fields) 2FA805118F7FAB37CF1C74CDBF59FAF1/02039FB78FC2AE82C8AFC00F6DDFB398 */
public record class ColonyProjectConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Label /* NeedsAlign */,
    PPtr<Image> m_Icon /* None */,
    PPtr<OwlcatMultiButton> m_MultiButton /* None */,
    PPtr<Slider> m_ProgressBar /* None */,
    PPtr<RectTransform> m_TooltipPlace /* None */)
{
    public static ColonyProjectConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Label */
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<OwlcatMultiButton> _m_MultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<Slider> _m_ProgressBar = PPtr<Slider>.Read(reader);
        PPtr<RectTransform> _m_TooltipPlace = PPtr<RectTransform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Label,
            _m_Icon,
            _m_MultiButton,
            _m_ProgressBar,
            _m_TooltipPlace);
    }
}

