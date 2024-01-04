namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickMinimalAdmissibleDamageView (10 fields) AC31D62E58F352434A32B968C98D2097/6DE4A9DA5BC1E36FC9F3D054D1AB3E67 */
public record class TooltipBrickMinimalAdmissibleDamageView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_HeaderText /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_ResultValueText /* None */,
    PPtr<TextMeshProUGUI> m_MinimalAdmissibleDamageText /* None */,
    PPtr<TextMeshProUGUI> m_MinimalAdmissibleDamageValueText /* None */,
    PPtr<TextMeshProUGUI> m_ReasonsText /* None */,
    PPtr<TextMeshProUGUI> m_GameDifficultyText /* None */)
{
    public static TooltipBrickMinimalAdmissibleDamageView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HeaderText */
        PPtr<TextMeshProUGUI> _m_HeaderText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ResultValueText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_MinimalAdmissibleDamageText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_MinimalAdmissibleDamageValueText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ReasonsText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_GameDifficultyText = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HeaderText,
            _m_ResultValueText,
            _m_MinimalAdmissibleDamageText,
            _m_MinimalAdmissibleDamageValueText,
            _m_ReasonsText,
            _m_GameDifficultyText);
    }
}

