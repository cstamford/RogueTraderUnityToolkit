namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UnitBackgroundBlockCommonView (16 fields) 3A07BFCA7E8B91F72D6C5B3A2A107D68/FDCC8E90EB42418489BA3EB16D0C7236 */
public record class UnitBackgroundBlockCommonView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_HomeworldTitle /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_HomeworldLabel /* None */,
    PPtr<OwlcatMultiButton> m_HomeworldButton /* None */,
    PPtr<TextMeshProUGUI> m_OccupationTitle /* None */,
    PPtr<TextMeshProUGUI> m_OccupationLabel /* None */,
    PPtr<OwlcatMultiButton> m_OccupationButton /* None */,
    PPtr<TextMeshProUGUI> m_MomentOfTriumphTitle /* None */,
    PPtr<TextMeshProUGUI> m_MomentOfTriumphLabel /* None */,
    PPtr<OwlcatMultiButton> m_MomentOfTriumphButton /* None */,
    PPtr<TextMeshProUGUI> m_DarkestHourTitle /* None */,
    PPtr<TextMeshProUGUI> m_DarkestHourLabel /* None */,
    PPtr<OwlcatMultiButton> m_DarkestHourButton /* None */)
{
    public static UnitBackgroundBlockCommonView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HomeworldTitle */
        PPtr<TextMeshProUGUI> _m_HomeworldTitle = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_HomeworldLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_HomeworldButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_OccupationTitle = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_OccupationLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_OccupationButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_MomentOfTriumphTitle = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_MomentOfTriumphLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_MomentOfTriumphButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DarkestHourTitle = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DarkestHourLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_DarkestHourButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HomeworldTitle,
            _m_HomeworldLabel,
            _m_HomeworldButton,
            _m_OccupationTitle,
            _m_OccupationLabel,
            _m_OccupationButton,
            _m_MomentOfTriumphTitle,
            _m_MomentOfTriumphLabel,
            _m_MomentOfTriumphButton,
            _m_DarkestHourTitle,
            _m_DarkestHourLabel,
            _m_DarkestHourButton);
    }
}

