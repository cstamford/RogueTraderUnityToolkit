namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBricksMomentumPortraitsView (5 fields) 0A2449497BF9EB02F5DC788F63A0C479/42DBDDF46987901C516AB0E1AB832866 */
public record class TooltipBricksMomentumPortraitsView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TooltipBrickMomentumPortraitView>[] MomentumPortraitViews /* NeedsAlign */)
{
    public static TooltipBricksMomentumPortraitsView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* MomentumPortraitViews */
        PPtr<TooltipBrickMomentumPortraitView>[] _MomentumPortraitViews = BuiltInArray<PPtr<TooltipBrickMomentumPortraitView>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _MomentumPortraitViews);
    }
}

