namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickSkillsView (5 fields) E3A98E615D60C7EC17D0F670FCA76793/6C1BEE10F013748A0B174E5844856529 */
public record class TooltipBrickSkillsView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CharInfoSkillsBlockCommonView> m_AbilityScoresBlockView /* NeedsAlign */)
{
    public static TooltipBrickSkillsView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_AbilityScoresBlockView */
        PPtr<CharInfoSkillsBlockCommonView> _m_AbilityScoresBlockView = PPtr<CharInfoSkillsBlockCommonView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_AbilityScoresBlockView);
    }
}

