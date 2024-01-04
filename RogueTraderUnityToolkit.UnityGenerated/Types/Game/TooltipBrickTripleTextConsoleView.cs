namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickTripleTextConsoleView (16 fields) 9931DAD895690DE0CC2AF9D142AF3971/AA3028278577E3617E3CE27ACFB49CD1 */
public record class TooltipBrickTripleTextConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_LeftLabel /* NeedsAlign */,
    PPtr<GameObject> m_LeftSide /* None */,
    PPtr<TextMeshProUGUI> m_RightLabel /* None */,
    PPtr<GameObject> m_RightSide /* None */,
    PPtr<TextMeshProUGUI> m_MiddleLabel /* None */,
    PPtr<GameObject> m_MiddleSide /* None */,
    PPtr<Image> m_LeftIcon /* None */,
    PPtr<Image> m_MiddleIcon /* None */,
    PPtr<Image> m_RightIcon /* None */,
    PPtr<OwlcatMultiButton> m_LeftMultiButton /* None */,
    PPtr<OwlcatMultiButton> m_MiddleMultiButton /* None */,
    PPtr<OwlcatMultiButton> m_RightMultiButton /* None */)
{
    public static TooltipBrickTripleTextConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_LeftLabel */
        PPtr<TextMeshProUGUI> _m_LeftLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_LeftSide = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RightLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_RightSide = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_MiddleLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_MiddleSide = PPtr<GameObject>.Read(reader);
        PPtr<Image> _m_LeftIcon = PPtr<Image>.Read(reader);
        PPtr<Image> _m_MiddleIcon = PPtr<Image>.Read(reader);
        PPtr<Image> _m_RightIcon = PPtr<Image>.Read(reader);
        PPtr<OwlcatMultiButton> _m_LeftMultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_MiddleMultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_RightMultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_LeftLabel,
            _m_LeftSide,
            _m_RightLabel,
            _m_RightSide,
            _m_MiddleLabel,
            _m_MiddleSide,
            _m_LeftIcon,
            _m_MiddleIcon,
            _m_RightIcon,
            _m_LeftMultiButton,
            _m_MiddleMultiButton,
            _m_RightMultiButton);
    }
}

