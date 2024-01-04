namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CreditsPersonElement (6 fields) 497B384834ABA34D3ACABCD46288247C/7CA890E48B55E6E7584BA3AFD941DF53 */
public record class CreditsPersonElement(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> NameLabel /* NeedsAlign */,
    PPtr<TextMeshProUGUI> RoleLabel /* None */)
{
    public static CreditsPersonElement Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* NameLabel */
        PPtr<TextMeshProUGUI> _NameLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _RoleLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _NameLabel,
            _RoleLabel);
    }
}

