namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TitlesOneColumnPage (11 fields) 937C8BAB5EDF552DFA6700F41837D106/50AE2C646367CB815F63158A237184B4 */
public record class TitlesOneColumnPage(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasGroup> m_Group /* NeedsAlign */,
    PPtr<CreditsPersonElement> PersonRolePrefab /* None */,
    PPtr<CreditsHeaderElement> m_HeaderPrefab /* None */,
    PPtr<CreditsTextElement> m_TextPrefab /* None */,
    PPtr<GameObject> m_RoleSeparator /* None */,
    PPtr<RectTransform> m_Content /* None */,
    PPtr<CreditsCompanyElement> CompanyPrefab /* None */)
{
    public static TitlesOneColumnPage Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Group */
        PPtr<CanvasGroup> _m_Group = PPtr<CanvasGroup>.Read(reader);
        PPtr<CreditsPersonElement> _PersonRolePrefab = PPtr<CreditsPersonElement>.Read(reader);
        PPtr<CreditsHeaderElement> _m_HeaderPrefab = PPtr<CreditsHeaderElement>.Read(reader);
        PPtr<CreditsTextElement> _m_TextPrefab = PPtr<CreditsTextElement>.Read(reader);
        PPtr<GameObject> _m_RoleSeparator = PPtr<GameObject>.Read(reader);
        PPtr<RectTransform> _m_Content = PPtr<RectTransform>.Read(reader);
        PPtr<CreditsCompanyElement> _CompanyPrefab = PPtr<CreditsCompanyElement>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Group,
            _PersonRolePrefab,
            _m_HeaderPrefab,
            _m_TextPrefab,
            _m_RoleSeparator,
            _m_Content,
            _CompanyPrefab);
    }
}

