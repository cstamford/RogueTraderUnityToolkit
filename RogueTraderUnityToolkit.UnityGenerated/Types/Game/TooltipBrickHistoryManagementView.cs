namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickHistoryManagementView (9 fields) DD8ECEEDD7E4822D18B4145807C35512/F3D442DCDB88E183C458418923F51508 */
public record class TooltipBrickHistoryManagementView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_TitleLabel /* NeedsAlign */,
    PPtr<OwlcatMultiButton> m_PreviousButton /* None */,
    PPtr<OwlcatMultiButton> m_NextButton /* None */,
    float m_DefaultFontSize /* None */,
    float m_DefaultConsoleFontSize /* None */)
{
    public static TooltipBrickHistoryManagementView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TitleLabel */
        PPtr<TextMeshProUGUI> _m_TitleLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_PreviousButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_NextButton = PPtr<OwlcatMultiButton>.Read(reader);
        float _m_DefaultFontSize = reader.ReadF32();
        float _m_DefaultConsoleFontSize = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_TitleLabel,
            _m_PreviousButton,
            _m_NextButton,
            _m_DefaultFontSize,
            _m_DefaultConsoleFontSize);
    }
}

