namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyTraitConsoleView (7 fields) A49A245E1ACF81877F9889837903F253/10907586CFCC8634C25F896184654A4E */
public record class ColonyTraitConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_NameLabel /* NeedsAlign */,
    PPtr<Image> m_Icon /* None */,
    PPtr<OwlcatMultiButton> m_FocusButton /* None */)
{
    public static ColonyTraitConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_NameLabel */
        PPtr<TextMeshProUGUI> _m_NameLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<OwlcatMultiButton> _m_FocusButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_NameLabel,
            _m_Icon,
            _m_FocusButton);
    }
}

