namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceCombatInitiativeOrderSquadUnitView (6 fields) DCF6F794D88D86A294974FB2068159F4/A7E77B95621B3E671B390C3FBD148BB6 */
public record class SurfaceCombatInitiativeOrderSquadUnitView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_Portrait /* NeedsAlign */,
    PPtr<UnitHealthPartProgressPCView> m_UnitHealthPartProgressPCView /* None */)
{
    public static SurfaceCombatInitiativeOrderSquadUnitView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Portrait */
        PPtr<Image> _m_Portrait = PPtr<Image>.Read(reader);
        PPtr<UnitHealthPartProgressPCView> _m_UnitHealthPartProgressPCView = PPtr<UnitHealthPartProgressPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Portrait,
            _m_UnitHealthPartProgressPCView);
    }
}

