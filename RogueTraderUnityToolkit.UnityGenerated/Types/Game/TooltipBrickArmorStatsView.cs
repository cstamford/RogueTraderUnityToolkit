namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickArmorStatsView (13 fields) 6AA57DB895CBA7C010B4F95CEE7E3345/0B8632556ADB0491E0DCBE57A29DA5C2 */
public record class TooltipBrickArmorStatsView(
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
    PPtr<Image> m_DodgeTooltip /* None */)
{
    public static TooltipBrickArmorStatsView Read(EndianBinaryReader reader)
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
            _m_DodgeTooltip);
    }
}

