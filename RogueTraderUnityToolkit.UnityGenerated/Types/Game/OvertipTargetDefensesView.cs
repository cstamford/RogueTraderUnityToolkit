namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OvertipTargetDefensesView (13 fields) AB7CF080F720B19135B30D81D0A04AD3/7413FCEC449D462409EACA0CA4E036B5 */
public record class OvertipTargetDefensesView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasGroup> m_Dodge /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_DodgeChance /* None */,
    PPtr<Image> m_DodgeHintPlace /* None */,
    PPtr<CanvasGroup> m_Parry /* None */,
    PPtr<TextMeshProUGUI> m_ParryChance /* None */,
    PPtr<Image> m_ParryHintPlace /* None */,
    PPtr<CanvasGroup> m_Cover /* None */,
    PPtr<TextMeshProUGUI> m_CoverChance /* None */,
    PPtr<Image> m_CoverHintPlace /* None */)
{
    public static OvertipTargetDefensesView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Dodge */
        PPtr<CanvasGroup> _m_Dodge = PPtr<CanvasGroup>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DodgeChance = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_DodgeHintPlace = PPtr<Image>.Read(reader);
        PPtr<CanvasGroup> _m_Parry = PPtr<CanvasGroup>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ParryChance = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_ParryHintPlace = PPtr<Image>.Read(reader);
        PPtr<CanvasGroup> _m_Cover = PPtr<CanvasGroup>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CoverChance = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_CoverHintPlace = PPtr<Image>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Dodge,
            _m_DodgeChance,
            _m_DodgeHintPlace,
            _m_Parry,
            _m_ParryChance,
            _m_ParryHintPlace,
            _m_Cover,
            _m_CoverChance,
            _m_CoverHintPlace);
    }
}

