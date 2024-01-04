namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CreditsPersonRoleHighlightElement (9 fields) CC12D6926A481C175B1DBA7CA866E631/4E11E94B9622C374A34DFE995775B3DC */
public record class CreditsPersonRoleHighlightElement(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> NameLabel /* NeedsAlign */,
    PPtr<TextMeshProUGUI> RoleLabel /* None */,
    PPtr<TextMeshProUGUI> NameLabelHighlighted /* None */,
    PPtr<TextMeshProUGUI> RoleLabelHighlighted /* None */,
    PPtr<DOTweenAnimation> m_Ping /* None */)
{
    public static CreditsPersonRoleHighlightElement Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* NameLabel */
        PPtr<TextMeshProUGUI> _NameLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _RoleLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _NameLabelHighlighted = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _RoleLabelHighlighted = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<DOTweenAnimation> _m_Ping = PPtr<DOTweenAnimation>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _NameLabel,
            _RoleLabel,
            _NameLabelHighlighted,
            _RoleLabelHighlighted,
            _m_Ping);
    }
}

