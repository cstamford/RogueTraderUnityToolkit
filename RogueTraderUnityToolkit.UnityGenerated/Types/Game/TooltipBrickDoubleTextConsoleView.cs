namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickDoubleTextConsoleView (10 fields) 3F4BE3274B77897B25AFFE5C6AE8AD08/E2EFDB7F1FF7068099CB03D237BFBB3B */
public record class TooltipBrickDoubleTextConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_LeftLabel /* NeedsAlign */,
    PPtr<GameObject> m_LeftSide /* None */,
    PPtr<TextMeshProUGUI> m_RightLabel /* None */,
    PPtr<GameObject> m_RightSide /* None */,
    PPtr<OwlcatMultiButton> m_LeftMultiButton /* None */,
    PPtr<OwlcatMultiButton> m_RightMultiButton /* None */)
{
    public static TooltipBrickDoubleTextConsoleView Read(EndianBinaryReader reader)
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
        PPtr<OwlcatMultiButton> _m_LeftMultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_RightMultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_LeftLabel,
            _m_LeftSide,
            _m_RightLabel,
            _m_RightSide,
            _m_LeftMultiButton,
            _m_RightMultiButton);
    }
}

