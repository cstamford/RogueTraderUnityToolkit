namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickAbilityScoresView (5 fields) 0B32BCBB24DCCDC676B71E43CEC6643E/1EC2633B8F730F38BF870A00AC0A4874 */
public record class TooltipBrickAbilityScoresView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CharInfoAbilityScoresBlockBaseView> m_AbilityScoresBlockView /* NeedsAlign */)
{
    public static TooltipBrickAbilityScoresView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_AbilityScoresBlockView */
        PPtr<CharInfoAbilityScoresBlockBaseView> _m_AbilityScoresBlockView = PPtr<CharInfoAbilityScoresBlockBaseView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_AbilityScoresBlockView);
    }
}

