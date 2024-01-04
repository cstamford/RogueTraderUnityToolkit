namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CreditsTwoColumnsPage (7 fields) BA8E98BFB5F5CBE72B285410AAB307CF/9154AE5A4FBC6F4DE784496D6D7A7F07 */
public record class CreditsTwoColumnsPage(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasGroup> m_Group /* NeedsAlign */,
    PPtr<RectTransform> m_Content /* None */,
    PPtr<CreditsPersonElement> m_PersonPrefab /* None */)
{
    public static CreditsTwoColumnsPage Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Group */
        PPtr<CanvasGroup> _m_Group = PPtr<CanvasGroup>.Read(reader);
        PPtr<RectTransform> _m_Content = PPtr<RectTransform>.Read(reader);
        PPtr<CreditsPersonElement> _m_PersonPrefab = PPtr<CreditsPersonElement>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Group,
            _m_Content,
            _m_PersonPrefab);
    }
}

