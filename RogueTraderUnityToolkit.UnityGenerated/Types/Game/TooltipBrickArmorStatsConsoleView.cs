namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickArmorStatsConsoleView (16 fields) E36E1806DED9C62246890D78961DF3D5/E5B0755ABF2C9EEC0FDE2ACDB24F97EB */
public record class TooltipBrickArmorStatsConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_DeflectionLabel /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_DeflectionValue /* None */,
    PPtr<Image> m_DeflectionTooltip /* None */,
    PPtr<TextMeshProUGUI> m_AbsorptionLabel /* None */,
    PPtr<TextMeshProUGUI> m_AbsorptionValue /* None */,
    PPtr<Image> m_AbsorptionTooltip /* None */,
    PPtr<TextMeshProUGUI> m_DodgeLabel /* None */,
    PPtr<TextMeshProUGUI> m_DodgeValue /* None */,
    PPtr<Image> m_DodgeTooltip /* None */,
    PPtr<OwlcatMultiButton> m_DeflectionButton /* None */,
    PPtr<OwlcatMultiButton> m_AbsorptionButton /* None */,
    PPtr<OwlcatMultiButton> m_DodgeButton /* None */)
{
    public static TooltipBrickArmorStatsConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_DeflectionLabel */
        PPtr<TextMeshProUGUI> _m_DeflectionLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DeflectionValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_DeflectionTooltip = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AbsorptionLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AbsorptionValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_AbsorptionTooltip = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DodgeLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DodgeValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_DodgeTooltip = PPtr<Image>.Read(reader);
        PPtr<OwlcatMultiButton> _m_DeflectionButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_AbsorptionButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_DodgeButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_DeflectionLabel,
            _m_DeflectionValue,
            _m_DeflectionTooltip,
            _m_AbsorptionLabel,
            _m_AbsorptionValue,
            _m_AbsorptionTooltip,
            _m_DodgeLabel,
            _m_DodgeValue,
            _m_DodgeTooltip,
            _m_DeflectionButton,
            _m_AbsorptionButton,
            _m_DodgeButton);
    }
}

