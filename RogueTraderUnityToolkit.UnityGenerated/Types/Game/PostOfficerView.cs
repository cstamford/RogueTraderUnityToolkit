namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PostOfficerView (14 fields) 3C13735E144E8261E7A02943DA0E3107/A767ABF85DE639D970ED0CCF7BD3618E */
public record class PostOfficerView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_Button /* NeedsAlign */,
    PPtr<PostAbilityView> m_UnitBuffForShip /* None */,
    PPtr<Image> m_Portrait /* None */,
    PPtr<GameObject> EmptyBlock /* None */,
    PPtr<GameObject> SkillValueBlock /* None */,
    PPtr<GameObject> m_PostImageBlock /* None */,
    PPtr<Image> m_PostImageIcon /* None */,
    PPtr<TextMeshProUGUI> SkillValue /* None */,
    PPtr<Image> SkillHintPlace /* None */,
    PPtr<OwlcatMultiSelectable> SkillValueState /* None */)
{
    public static PostOfficerView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Button */
        PPtr<OwlcatMultiButton> _m_Button = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<PostAbilityView> _m_UnitBuffForShip = PPtr<PostAbilityView>.Read(reader);
        PPtr<Image> _m_Portrait = PPtr<Image>.Read(reader);
        PPtr<GameObject> _EmptyBlock = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _SkillValueBlock = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_PostImageBlock = PPtr<GameObject>.Read(reader);
        PPtr<Image> _m_PostImageIcon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _SkillValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _SkillHintPlace = PPtr<Image>.Read(reader);
        PPtr<OwlcatMultiSelectable> _SkillValueState = PPtr<OwlcatMultiSelectable>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Button,
            _m_UnitBuffForShip,
            _m_Portrait,
            _EmptyBlock,
            _SkillValueBlock,
            _m_PostImageBlock,
            _m_PostImageIcon,
            _SkillValue,
            _SkillHintPlace,
            _SkillValueState);
    }
}

