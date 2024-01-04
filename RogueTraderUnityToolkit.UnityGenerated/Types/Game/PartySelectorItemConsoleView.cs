namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PartySelectorItemConsoleView (9 fields) 2F85C7D61970D84D4CF42FE10B3A3121/4DB7B190855A1207DB1822593E096F22 */
public record class PartySelectorItemConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<UnitPortraitPartPCView> m_PortraitView /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_CharacterName /* None */,
    PPtr<GameObject> m_ConnectedIcon /* None */,
    PPtr<OwlcatMultiButton> m_Button /* None */,
    PPtr<GameObject> m_LevelUpObject /* None */)
{
    public static PartySelectorItemConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_PortraitView */
        PPtr<UnitPortraitPartPCView> _m_PortraitView = PPtr<UnitPortraitPartPCView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CharacterName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_ConnectedIcon = PPtr<GameObject>.Read(reader);
        PPtr<OwlcatMultiButton> _m_Button = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<GameObject> _m_LevelUpObject = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PortraitView,
            _m_CharacterName,
            _m_ConnectedIcon,
            _m_Button,
            _m_LevelUpObject);
    }
}

