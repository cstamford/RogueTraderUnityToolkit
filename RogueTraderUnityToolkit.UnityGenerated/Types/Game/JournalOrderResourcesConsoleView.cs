namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $JournalOrderResourcesConsoleView (11 fields) 231DACD0AB4544C0234ABFBC2899C28F/33BD16E98FBDF1B882D8DB6698ABA4A7 */
public record class JournalOrderResourcesConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_Icon /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Count /* None */,
    PPtr<Image> m_Arrow /* None */,
    PPtr<Sprite> m_GreenArrow /* None */,
    PPtr<Sprite> m_RedArrow /* None */,
    PPtr<OwlcatSelectable> m_OwlcatSelectable /* None */,
    PPtr<Image> m_BackgroundImage /* None */)
{
    public static JournalOrderResourcesConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Icon */
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Count = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_Arrow = PPtr<Image>.Read(reader);
        PPtr<Sprite> _m_GreenArrow = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_RedArrow = PPtr<Sprite>.Read(reader);
        PPtr<OwlcatSelectable> _m_OwlcatSelectable = PPtr<OwlcatSelectable>.Read(reader);
        PPtr<Image> _m_BackgroundImage = PPtr<Image>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Icon,
            _m_Count,
            _m_Arrow,
            _m_GreenArrow,
            _m_RedArrow,
            _m_OwlcatSelectable,
            _m_BackgroundImage);
    }
}

