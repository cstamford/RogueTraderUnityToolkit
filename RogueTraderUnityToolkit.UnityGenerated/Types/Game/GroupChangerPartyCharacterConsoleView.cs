namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $GroupChangerPartyCharacterConsoleView (12 fields) 66FCA47C166BFBDA4AB69D3C59477A72/287A0FF54DFDE6894A192502C699DFF0 */
public record class GroupChangerPartyCharacterConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_Button /* NeedsAlign */,
    PPtr<Image> m_Lock /* None */,
    PPtr<GameObject> m_LevelUp /* None */,
    PPtr<OwlcatMultiSelectable> m_Selectable /* None */,
    PPtr<TextMeshProUGUI> m_CharacterName /* None */,
    PPtr<TextMeshProUGUI> m_CharacterLevel /* None */,
    PPtr<UnitBuffPartPCView> m_BuffPartView /* None */,
    PPtr<UnitPortraitPartPCView> m_PortraitPartView /* None */)
{
    public static GroupChangerPartyCharacterConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Button */
        PPtr<OwlcatMultiButton> _m_Button = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<Image> _m_Lock = PPtr<Image>.Read(reader);
        PPtr<GameObject> _m_LevelUp = PPtr<GameObject>.Read(reader);
        PPtr<OwlcatMultiSelectable> _m_Selectable = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CharacterName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CharacterLevel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<UnitBuffPartPCView> _m_BuffPartView = PPtr<UnitBuffPartPCView>.Read(reader);
        PPtr<UnitPortraitPartPCView> _m_PortraitPartView = PPtr<UnitPortraitPartPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Button,
            _m_Lock,
            _m_LevelUp,
            _m_Selectable,
            _m_CharacterName,
            _m_CharacterLevel,
            _m_BuffPartView,
            _m_PortraitPartView);
    }
}

