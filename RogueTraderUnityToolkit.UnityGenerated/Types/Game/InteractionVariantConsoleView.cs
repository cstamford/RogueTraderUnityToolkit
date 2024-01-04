namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $InteractionVariantConsoleView (17 fields) 8AA6CBBF8AAA6301FC09AC8C2408E2D5/304911CC94980F0DA13085E618F8D793 */
public record class InteractionVariantConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatButton> m_Button /* NeedsAlign */,
    PPtr<Image> m_ImageNormal /* None */,
    PPtr<Image> m_ImageHighlighted /* None */,
    PPtr<Image> m_ImagePressed /* None */,
    PPtr<Image> m_ImageDisabled /* None */,
    PPtr<Sprite> m_DefaultIconNormal /* None */,
    PPtr<Sprite> m_DefaultIconHighlighted /* None */,
    PPtr<Sprite> m_DefaultIconPressed /* None */,
    PPtr<Sprite> m_DefaultIconDisabled /* None */,
    PPtr<TextMeshProUGUI> m_ActionName /* None */,
    PPtr<TextMeshProUGUI> m_ResourceCount /* None */,
    PPtr<ConsoleHint> m_Hint /* None */,
    PPtr<TextMeshProUGUI> m_ResourcesHint /* None */)
{
    public static InteractionVariantConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Button */
        PPtr<OwlcatButton> _m_Button = PPtr<OwlcatButton>.Read(reader);
        PPtr<Image> _m_ImageNormal = PPtr<Image>.Read(reader);
        PPtr<Image> _m_ImageHighlighted = PPtr<Image>.Read(reader);
        PPtr<Image> _m_ImagePressed = PPtr<Image>.Read(reader);
        PPtr<Image> _m_ImageDisabled = PPtr<Image>.Read(reader);
        PPtr<Sprite> _m_DefaultIconNormal = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_DefaultIconHighlighted = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_DefaultIconPressed = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_DefaultIconDisabled = PPtr<Sprite>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ActionName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ResourceCount = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<ConsoleHint> _m_Hint = PPtr<ConsoleHint>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ResourcesHint = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Button,
            _m_ImageNormal,
            _m_ImageHighlighted,
            _m_ImagePressed,
            _m_ImageDisabled,
            _m_DefaultIconNormal,
            _m_DefaultIconHighlighted,
            _m_DefaultIconPressed,
            _m_DefaultIconDisabled,
            _m_ActionName,
            _m_ResourceCount,
            _m_Hint,
            _m_ResourcesHint);
    }
}

