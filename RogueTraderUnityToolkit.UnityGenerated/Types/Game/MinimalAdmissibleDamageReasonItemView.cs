namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $MinimalAdmissibleDamageReasonItemView (6 fields) 93E21DA6A71CCE119A2940B946F8D26E/12710C3378E715E2A4A54BE8728CF042 */
public record class MinimalAdmissibleDamageReasonItemView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_IconImage /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Text /* None */)
{
    public static MinimalAdmissibleDamageReasonItemView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_IconImage */
        PPtr<Image> _m_IconImage = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Text = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_IconImage,
            _m_Text);
    }
}

