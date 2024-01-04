namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenCharInfoSkillView (11 fields) 65CB63147D22A8C374A1D1A4A49FEA5D/424EA53A8A19DC270495566B67FF19A5 */
public record class CharGenCharInfoSkillView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_NameLabel /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_ValueLabel /* None */,
    PPtr<TextMeshProUGUI> m_DiffValueLabel /* None */,
    PPtr<GameObject> m_DiffState /* None */,
    PPtr<Image> m_Icon /* None */,
    PPtr<TextMeshProUGUI> m_SourceNameLabel /* None */,
    PPtr<OwlcatMultiSelectable> m_Selectable /* None */)
{
    public static CharGenCharInfoSkillView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_NameLabel */
        PPtr<TextMeshProUGUI> _m_NameLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ValueLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DiffValueLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_DiffState = PPtr<GameObject>.Read(reader);
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SourceNameLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiSelectable> _m_Selectable = PPtr<OwlcatMultiSelectable>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_NameLabel,
            _m_ValueLabel,
            _m_DiffValueLabel,
            _m_DiffState,
            _m_Icon,
            _m_SourceNameLabel,
            _m_Selectable);
    }
}

